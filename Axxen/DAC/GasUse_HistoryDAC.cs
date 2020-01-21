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
    public class GasUse_HistoryDAC : DACParent
    {
        public List<GasUse_HistoryVO> GetAllGasUse_History() //PRM_PRF_004 그리드뷰 사용
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllGasUse_History";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GasUse_HistoryVO> list = Helper.DataReaderMapToList<GasUse_HistoryVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<GasUse_HistoryVO> GetDatePicker_GasUse_History(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_001 DateTimePicker 사용
        {
            List<GasUse_HistoryVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select Seq, Std_Date,gh.Wc_Code, Wc_Name, Gas_Val, Dorm_Gas,gh.Remark from GasUse_History gh INNER JOIN WorkCenter_Master wcm ON gh.Wc_Code = wcm.Wc_Code  where Std_Date BETWEEN '{ADateTimePickerValue1}' AND '{ADateTimePickerValue2}' Order By Seq Desc";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<GasUse_HistoryVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
       
    }
}
