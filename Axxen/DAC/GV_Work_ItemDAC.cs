using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    public class GV_Work_ItemDAC : DACParent
    {
        public List<GV_Work_ItemVO> GetAllGV_Work_Item() //PRM_PRF_005 
        {
            List<GV_Work_ItemVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select gvcs.GV_Code,GV_Name,gvcs.Workorderno,wo.Item_Code,Item_Name,GV_Status,GV_Qty,Loading_date,Loading_time,Loading_Wc,Unloading_date,Unloading_time,Unloading_Wc,In_Time,Center_Time,Out_Time " +
                             $"from GV_Current_Status gvcs INNER JOIN GV_Master gvm ON gvcs.GV_Code = gvm.GV_Code " +
                             $"INNER JOIN WorkOrder wo ON gvcs.Workorderno = wo.Workorderno " +
                             $"INNER JOIN Item_Master im ON wo.Item_Code = im.Item_Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<GV_Work_ItemVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
    }
}
