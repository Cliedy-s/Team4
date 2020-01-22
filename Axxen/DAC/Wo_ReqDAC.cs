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
    public class Wo_ReqDAC : DACParent
    {
        public List<Wo_Req_ItemVO> GetAllWoReq() //PPS_SCH_001 그리드뷰 사용
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllWoReq";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Wo_Req_ItemVO> list = Helper.DataReaderMapToList<Wo_Req_ItemVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public bool UpdateWoReq(string woNo)
        {
            int result =0;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "update Wo_Req set Req_Status ='마감' where Wo_Req_No = @Wo_Req_No ";
                comm.Parameters.AddWithValue("@Wo_Req_No", woNo);

                comm.Connection.Open();
                result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return (result > 0);
            }
        }

        public List<WorkOrder_J_WC_ItmeVO> GetWorkOrder()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "select Prd_Date, wo.Wo_Req_No, wo.Req_Seq,wo.Wo_Status,wo.Workorderno,wo.Item_Code,Item_Name,Wc_Name,wo.In_Qty_Main,wo.Out_Qty_Main,wo.Prd_Qty,wo.Remark from WorkOrder wo INNER JOIN Item_Master im ON wo.Item_Code = im.Item_Code INNER JOIN WorkCenter_Master wm ON wo.Wc_Code = wm.Wc_Code ";
                //where wo.Item_Code=@Item_Code
                //comm.Parameters.AddWithValue("@Item_Code", code);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkOrder_J_WC_ItmeVO> list = Helper.DataReaderMapToList<WorkOrder_J_WC_ItmeVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<WO_WC_Production_ItemVO> GetWO_WC_Production_Items() //PPS_SCH_003 그리드뷰 사용
        {
            List<WO_WC_Production_ItemVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "GetWO_WC_Production_Items";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    list = Helper.DataReaderMapToList<WO_WC_Production_ItemVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }

        public List<WorkOrder_J_WC_ItmeVO> GetWorkCenterName()
        {
            List<WorkOrder_J_WC_ItmeVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "select distinct Wc_Name from WorkCenter_Master";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<WorkOrder_J_WC_ItmeVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
    }
}
