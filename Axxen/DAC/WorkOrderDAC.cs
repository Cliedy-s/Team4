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
    public class WorkOrderDAC : DACParent
    {
        public List<WorkOrder_J_WC_ItmeVO> GetAll_WorkOrder_Item_WC() //PRM_PRF_001 그리드뷰 사용
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAll_WorkOrder_Item_WC";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkOrder_J_WC_ItmeVO> list = Helper.DataReaderMapToList<WorkOrder_J_WC_ItmeVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<WorkOrder_J_WC_ItmeVO> GetDatePicker_WorkOrder_Item_WC(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_001 DateTimePicker 사용
        {
            List<WorkOrder_J_WC_ItmeVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select ROW_NUMBER() OVER(ORDER BY wo.Wo_Status) Num,Prd_Date, wo.Wo_Status,wo.Workorderno,wo.Item_Code,Item_Name,Wc_Name,wo.In_Qty_Main,wo.Out_Qty_Main,wo.Prd_Qty from WorkOrder wo INNER JOIN Item_Master im  ON wo.Item_Code=im.Item_Code INNER JOIN WorkCenter_Master wm ON wo.Wc_Code=wm.Wc_Code where Prd_Date BETWEEN '{ADateTimePickerValue1}' AND '{ADateTimePickerValue2}'";
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
