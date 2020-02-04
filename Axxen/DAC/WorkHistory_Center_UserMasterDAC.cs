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
    public class WorkHistory_Center_UserMasterDAC : DACParent
    {
        public List<WorkHistory_Center_UserMasterVO> GetAllWorkHistory_Center_UserMaster()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select Work_Date,Wc_Name,User_Name,Work_StartTime,Work_EndTime,Work_Time 
                                    from Work_History wh INNER JOIN WorkCenter_Master wcm ON wh.Process_Code = wcm.Process_Code
					                                     INNER JOIN User_Master um ON wh.User_ID = um.User_ID";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkHistory_Center_UserMasterVO> list = Helper.DataReaderMapToList<WorkHistory_Center_UserMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<WorkHistory_Center_UserMasterVO> PickerWorkHistory_Center_UserMaster(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_008 DateTimePicker 사용
        {
            List<WorkHistory_Center_UserMasterVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select Work_Date,Wc_Name,User_Name,Work_StartTime,Work_EndTime,Work_Time " +
                    $"from Work_History wh INNER JOIN WorkCenter_Master wcm ON wh.Process_Code = wcm.Process_Code " +
                    $"INNER JOIN User_Master um ON wh.User_ID = um.User_ID " +
                    $"where Work_Date BETWEEN '{ADateTimePickerValue1}' AND '{ADateTimePickerValue2}' Order By Work_Date Desc";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<WorkHistory_Center_UserMasterVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
    }
}
