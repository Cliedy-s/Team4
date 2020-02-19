using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    public class Goods_In_HistoryDAC : DACParent
    {
        /// <summary>
        /// PRM_RPT_004 포장작업일지
        /// </summary>
        /// <returns></returns>
        public List<Goods_In_HistoryPackageVO> GetBoxingHistory(string date)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"SELECT ROW_NUMBER() OVER(ORDER BY In_Date) AS Num,g.Workorderno,Item_Name,Pallet_No
,In_Date,g.Remark,Convert(Varchar,Prd_Endtime,8) Prd_Endtime FROM Goods_In_History g,WorkOrder w, Item_Master i, WorkCenter_Master wc where g.Workorderno=w.Workorderno 
and w.Item_Code=i.Item_Code and w.Wc_Code=wc.Wc_Code and wc.Process_Code ='PC10005' and In_Date is not null and In_Date=@In_Date";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@In_Date", date);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Goods_In_HistoryPackageVO> list = Helper.DataReaderMapToList<Goods_In_HistoryPackageVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// PRM_RPT_001 건조작업일지
        /// </summary>
        /// <returns></returns>
        public List<Goods_In_HistoryVO> GetDryingHistory(string date)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"SELECT ROW_NUMBER() OVER(ORDER BY In_Date) AS Num, g.Workorderno,Item_Name,Pallet_No
                                     ,In_Date,g.Remark,Closed_Time FROM Goods_In_History g, WorkOrder w, Item_Master i, WorkCenter_Master wc where g.Workorderno = w.Workorderno
                                      and w.Item_Code = i.Item_Code and w.Wc_Code = wc.Wc_Code and wc.Process_Code = 'PC10003' and In_Date=@In_Date";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@In_Date", date);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Goods_In_HistoryVO> list = Helper.DataReaderMapToList<Goods_In_HistoryVO>(reader);
                comm.Connection.Close();

                return list;
            }
            
        }

        /// <summary>
        /// PRM_PRT_002 성형작업일지
        /// </summary>
        /// <returns></returns>
        //public DataTable GetFigurationHistory(string date)
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection conn = new SqlConnection(Connstr))
        //    {
        //        conn.Open();
        //        string sql = @"SELECT ROW_NUMBER() OVER(ORDER BY Prd_Date) AS Num, w.Workorderno,Item_Name,GV_Code
        //                            ,Prd_Date,w.Remark,Prd_Endtime FROM GV_History gv, WorkOrder w, Item_Master i, WorkCenter_Master wc where gv.Workorderno = w.Workorderno
        //                             and w.Item_Code = i.Item_Code and w.Wc_Code = wc.Wc_Code and wc.Process_Code = 'PC10002' and Prd_Date= '" + date + "'";
        //        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        //        da.Fill(dt);

        //        conn.Close();
        //    }

        //    return dt;
        //}
        public List<Goods_In_HistoryVO> GetFigurationHistory(string date)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"SELECT ROW_NUMBER() OVER(ORDER BY Prd_Date) AS Num, w.Workorderno,Item_Name,GV_Code
,Prd_Date,w.Remark,Convert(Varchar,Prd_Endtime,8) Prd_Endtime FROM GV_History gv, WorkOrder w, Item_Master i, WorkCenter_Master wc where gv.Workorderno = w.Workorderno
and w.Item_Code = i.Item_Code and w.Wc_Code = wc.Wc_Code and wc.Process_Code = 'PC10002' and Prd_Date=@Prd_Date";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Prd_Date", date);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Goods_In_HistoryVO> list = Helper.DataReaderMapToList<Goods_In_HistoryVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// PRM_PRT_002 성형작업일지
        /// </summary>
        /// <returns></returns>
        public List<string> GetFigurationOrders(string date)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                List<string> orders = new List<string>();
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"select distinct wo.Workorderno
	from GV_History as gh 
	join WorkOrder as wo on wo.Workorderno = gh.Workorderno 
	join WorkCenter_Master as wcm on wo.Wc_Code = wcm.Wc_Code and wcm.Process_Code = 'PC10002'
	where Prd_Date=@Prd_Date ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Prd_Date", date);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                    orders.Add(reader[0].ToString());
                comm.Connection.Close();

                return orders;
            }
        }
        //public List<>

    }
}
