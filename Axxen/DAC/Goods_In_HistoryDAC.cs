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
        public List<Goods_In_HistoryVO> GetBoxingHistory(string date)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"SELECT ROW_NUMBER() OVER(ORDER BY In_Date) AS Num,g.Workorderno,Item_Name,Pallet_No
                                     ,In_Date,g.Remark,Closed_Time FROM Goods_In_History g,WorkOrder w, Item_Master i, WorkCenter_Master wc where g.Workorderno=w.Workorderno 
                                      and w.Item_Code=i.Item_Code and w.Wc_Code=wc.Wc_Code and wc.Process_Code ='PC10005' and In_Date=@In_Date";
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
        public List<Goods_In_HistoryVO> GetFigurationHistory(string date)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "select ROW_NUMBER() OVER(ORDER BY In_Date) AS Num,g.Workorderno,Pallet_No,g.In_Date,Item_Name,g.Remark ,g.Closed_Time from WorkOrder w, WorkCenter_Master wc, Item_Master i, Goods_In_History g where w.Wc_Code=wc.Wc_Code and i.Item_Code=w.Item_Code and g.Workorderno=w.Workorderno and  wc.Process_Code='PC10002' and In_Date=@In_Date";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@In_Date", date);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Goods_In_HistoryVO> list = Helper.DataReaderMapToList<Goods_In_HistoryVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        //public List<>

    }
}
