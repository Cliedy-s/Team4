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
    public class Nop_History_Mi_MaDAC : DACParent
    {
        public List<Nop_History_Mi_MaVO> GetAllNop_History_Mi_Ma() //전체 조회
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "select noh.Nop_Date,noh.Wc_Code,wcm.Wc_Name,noma.Nop_Ma_Name,nomi.Nop_Mi_Name,noh.Nop_Happentime,Nop_Canceltime,Nop_Time,noh.Remark,Nop_Type " +
                    "from Nop_History noh INNER JOIN Nop_Mi_Master nomi ON noh.Nop_Mi_Code = nomi.Nop_Mi_Code " +
                    "INNER JOIN Nop_Ma_Master noma ON nomi.Nop_Ma_Code = noma.Nop_Ma_Code " +
                    "INNER JOIN WorkCenter_Master wcm ON noh.Wc_Code = wcm.Wc_Code";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Nop_History_Mi_MaVO> list = Helper.DataReaderMapToList<Nop_History_Mi_MaVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<Nop_History_Mi_MaVO> GetDatePicker_Nop_History_Mi_Ma(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_008 DateTimePicker 사용
        {
            List<Nop_History_Mi_MaVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select noh.Nop_Date,noh.Wc_Code,wcm.Wc_Name,noma.Nop_Ma_Name,nomi.Nop_Mi_Name,noh.Nop_Happentime,Nop_Canceltime,Nop_Time,noh.Remark,Nop_Type " +
                    $"from Nop_History noh INNER JOIN Nop_Mi_Master nomi ON noh.Nop_Mi_Code = nomi.Nop_Mi_Code " +
                    $"INNER JOIN Nop_Ma_Master noma ON nomi.Nop_Ma_Code = noma.Nop_Ma_Code " +
                    $"INNER JOIN WorkCenter_Master wcm ON noh.Wc_Code = wcm.Wc_Code " +
                    $"where Nop_Date BETWEEN '{ADateTimePickerValue1}' AND '{ADateTimePickerValue2}' Order By Nop_Date Desc";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<Nop_History_Mi_MaVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
    }
}
