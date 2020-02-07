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
        public List<InspectHistoryVO> GetAll(string itemcode, string processcode, string inspectcode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 
  imh.Inspect_measure_seq 
 , imh.Item_code 
 , imh.Process_code 
 , imh.Inspect_code 
 , imh.Inspect_date 
 , imh.Inspect_datetime 
 , imh.Inspect_val 
 , imh.Workorderno 
 FROM Inspect_Measure_History AS imh
    WHERE imh.Item_Code = @itemcode and imh.Process_code =@processcode and imh.Inspect_code = @inspectcode ; ";
                comm.CommandType = CommandType.Text;

                comm.Parameters.AddWithValue("@itemcode", itemcode);
                comm.Parameters.AddWithValue("@processcode", processcode);
                comm.Parameters.AddWithValue("@inspectcode", inspectcode);

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
        public bool InsertInspect_Measure(InspectHistoryVO item, string userid)
        { 
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
				comm.CommandText = 
 @" INSERT INTO Inspect_Measure_History( 
 Item_code, Process_code, Inspect_code, Inspect_date, Inspect_datetime 
 , Inspect_val, Workorderno, Ins_Date	, Ins_Emp, Up_Date, Up_Emp) 
 VALUES(	 
@Item_code, 
@Process_code, 
@Inspect_code, 
getdate() , 
getdate(), 
@Inspect_val,
@Workorderno, 
getdate(),
@Ins_Emp,
getdate() ,
@Up_Emp);  ";

				comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Item_code", item.Item_code);
                comm.Parameters.AddWithValue("@Process_code", item.Process_code);
                comm.Parameters.AddWithValue("@Inspect_code", item.Inspect_code);
                comm.Parameters.AddWithValue("@Inspect_val", item.Inspect_val);
                comm.Parameters.AddWithValue("@Workorderno", item.Workorderno);
                comm.Parameters.AddWithValue("@Ins_Emp", userid);
                comm.Parameters.AddWithValue("@Up_Emp", userid);

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

        /// <summary>
        /// PRM_RPT_002 성형작업일지
        /// </summary>
        /// <param name="workno"></param>
        /// <returns></returns>
        public List<InspectMeasureHistoryVO> GetFiguration(List<string> workno)
        {
            List<InspectMeasureHistoryVO> list = null;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @" SELECT A.Workorderno, adate, aval, bdate, bval, cdate, cval, ddate, dval, edate, eval FROM 
(select Workorderno,inspect_DateTime adate,Inspect_Val aval from Inspect_Measure_history where Inspect_Code = 'SP1' and workorderno = @Workorderno) AS A
,(select Workorderno,inspect_DateTime bdate,Inspect_Val bval from Inspect_Measure_history where Inspect_Code = 'SP2' and workorderno = @Workorderno) AS B
,(select Workorderno,inspect_DateTime cdate,Inspect_Val cval from Inspect_Measure_history where Inspect_Code = 'SP3' and workorderno = @Workorderno) AS C
,(select Workorderno,inspect_DateTime ddate,Inspect_Val dval from Inspect_Measure_history where Inspect_Code = 'SP4' and workorderno = @Workorderno) AS D
,(select Workorderno,inspect_DateTime as edate ,Inspect_Val eval from Inspect_Measure_history where Inspect_Code = 'SP5' and workorderno = @Workorderno) AS E
where A.Workorderno=B.Workorderno and B.Workorderno=C.Workorderno and C.Workorderno=D.Workorderno and D.Workorderno=E.Workorderno";
                comm.CommandType = CommandType.Text;
                comm.Connection.Open();
                try
                {
                    foreach (var item in workno)
                    {
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@Workorderno", item);

                        SqlDataReader reader = comm.ExecuteReader();
                        list = Helper.DataReaderMapToList<InspectMeasureHistoryVO>(reader);
                        comm.Connection.Close();
                    }
                }
                catch (Exception)
                {
                    comm.Connection.Close();
                }
                return list;
            }
        }
    }
}
