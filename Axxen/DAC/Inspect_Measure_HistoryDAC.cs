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
    public class Inspect_Measure_HistoryDAC : DACParent
    {
        /// <summary>
        /// Inspect_Measure_History 목록 가져오기
        /// </summary>
        public List<InspectHistoryVO> GetAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = 
 @" SELECT 
  imh,Inspect_measure_seq 
 , imh,Item_code 
 , imh,Process_code 
 , imh,Inspect_code 
 , imh,Inspect_date 
 , imh,Inspect_datetime 
 , imh,Inspect_val 
 , imh,Workorderno 
 FROM Inspect_Measure_History AS imh; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectHistoryVO> list = Helper.DataReaderMapToList<InspectHistoryVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 품질측정값 등록
        /// </summary>
        /// <param name="item">Inspect_measure_seq를 제외하고 채워야함</param>
        public bool InsertInspect_Measure(InspectHistoryVO item)
        { 
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
				comm.CommandText = 
 @" INSERT INTO Inspect_Measure_History( 
 Item_code, Process_code, Inspect_code, Inspect_date, Inspect_datetime 
 , Inspect_val, Workorderno, Ins_Date	, Ins_Emp, Up_Date, Up_Emp) 
 VALUES(	 @Item_code, @Process_code, @Inspect_code, @Inspect_date 
 , @Inspect_datetime, @Inspect_val, @Workorderno, @Ins_Date, @Ins_Emp, @Up_Date 
 , @Up_Emp);  ";

				comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Item_code", item.Item_code);
                comm.Parameters.AddWithValue("@Process_code", item.Process_code);
                comm.Parameters.AddWithValue("@Inspect_code", item.Inspect_code);
                comm.Parameters.AddWithValue("@Inspect_date", item.Inspect_date);
                comm.Parameters.AddWithValue("@Inspect_datetime", item.Inspect_datetime);
                comm.Parameters.AddWithValue("@Inspect_val", item.Inspect_val);
                comm.Parameters.AddWithValue("@Workorderno", item.Workorderno);
                comm.Parameters.AddWithValue("@Ins_Date", item.Ins_Date);
                comm.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);
                comm.Parameters.AddWithValue("@Up_Date", item.Up_Date);
                comm.Parameters.AddWithValue("@Up_Emp", item.Up_Emp);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 품질측정값 삭제
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public bool DeleteInspect_MeasureBySeq(int seq)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = 
 @" DELETE FROM Inspect_Measure_History 
 WHERE Inspect_measure_seq = @Inspect_measure_seq; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Inspect_measure_seq", seq);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
    }
}
