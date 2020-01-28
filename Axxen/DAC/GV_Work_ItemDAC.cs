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

        public List<GV_History_Work_ItemVO> GetAllGV_History_Work_Item() //PRM_PRF_006 
        {
            List<GV_History_Work_ItemVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select gh.GV_Code,GV_Name,gh.Workorderno,wo.Item_Code,Item_Name,gh.Loading_Date,gh.Loading_Qty,gh.Loading_time,gh.Loading_Wc,gh.In_Time,gh.Center_Time,gh.Out_Time,gh.Unloading_Qty,gh.Unloading_date,gh.Unloading_datetime,gh.Unloading_wc,gh.Target_GV,gh.Clear_Date,gh.Clear_Datetime,gh.Clear_Qty,gh.Clear_Cause,gh.Clear_wc,gh.Clear_Item " +
                             $"from GV_History gh INNER JOIN GV_Master gvm ON gh.GV_Code = gvm.GV_Code " +
                                                $"INNER JOIN WorkOrder wo ON gh.Workorderno = wo.Workorderno " +
                                                $"INNER JOIN Item_Master im ON im.Item_Code = wo.Item_Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<GV_History_Work_ItemVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }

        public List<GV_History_Work_ItemVO> GetDatePicker_GV_History_Work_Item(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_001 DateTimePicker 사용
        {
            List<GV_History_Work_ItemVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select gh.GV_Code,GV_Name,gh.Workorderno,wo.Item_Code,Item_Name,gh.Loading_Date,gh.Loading_Qty,gh.Loading_time,gh.Loading_Wc,gh.In_Time,gh.Center_Time,gh.Out_Time,gh.Unloading_Qty,gh.Unloading_date,gh.Unloading_datetime,gh.Unloading_wc,gh.Target_GV,gh.Clear_Date,gh.Clear_Datetime,gh.Clear_Qty,gh.Clear_Cause,gh.Clear_wc,gh.Clear_Item " +
                             $"from GV_History gh INNER JOIN GV_Master gvm ON gh.GV_Code = gvm.GV_Code " +
                                                $"INNER JOIN WorkOrder wo ON gh.Workorderno = wo.Workorderno " +
                                                $"INNER JOIN Item_Master im ON im.Item_Code = wo.Item_Code " +
                             $"where gh.Loading_Date BETWEEN '{ADateTimePickerValue1}' AND '{ADateTimePickerValue2}' Order By gh.Loading_Date Desc";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<GV_History_Work_ItemVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
      
        public List<GV_History_Work_ItemVO> GV_Current_YesStatus() //PRM_PRF_007 사용중 대차 현황 
        {
            List<GV_History_Work_ItemVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "select GV_Name,GV_Status,gvm.Use_YN,gvcs.Workorderno,wo.Item_Code,Item_Name,Loading_time " +
                             "from GV_Current_Status gvcs INNER JOIN GV_Master gvm ON gvm.GV_Code = gvcs.GV_Code " +
                             "INNER JOIN WorkOrder wo ON gvcs.Workorderno = wo.Workorderno " +
                             "INNER JOIN Item_Master im ON wo.Item_Code = im.Item_Code " +
                             "where gvm.Use_YN = 'Y'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<GV_History_Work_ItemVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }

        public List<GV_History_Work_ItemVO> GetGV_Current_NO_Status() //PRM_PRF_007 빈 대차 현황 
        {
            List<GV_History_Work_ItemVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = "select GV_Code,GV_Name from GV_Master gvcs where Use_YN = 'N'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<GV_History_Work_ItemVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
        
    }
}
