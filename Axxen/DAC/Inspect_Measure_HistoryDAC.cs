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
                @"DELETE FROM Inspect_Measure_History WHERE Inspect_measure_seq = @Inspect_measure_seq ";
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
            List<InspectMeasureHistoryVO> list = new List<InspectMeasureHistoryVO>();
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @" 	SELECT A.Workorderno, Adate, Aval, Bdate, Bval, Cdate, Cval, Ddate, Dval, Edate, Eval FROM 
(select Top 1 Workorderno,Convert(Varchar,inspect_DateTime,8) Adate,cast(Inspect_Val as numeric(12,2)) Aval from Inspect_Measure_history where Inspect_Code = 'ES20001' and workorderno = @Workorderno order by Inspect_datetime desc ) AS A
,(select Top 1 Workorderno,Convert(Varchar,inspect_DateTime,8) Bdate,cast(Inspect_Val as numeric(12,2)) Bval from Inspect_Measure_history where Inspect_Code = 'ES20002' and workorderno = @Workorderno order by Inspect_datetime desc) AS B
,(select Top 1 Workorderno,Convert(Varchar,inspect_DateTime,8) Cdate,cast(Inspect_Val as numeric(12,2)) Cval from Inspect_Measure_history where Inspect_Code = 'ES20003' and workorderno = @Workorderno order by Inspect_datetime desc) AS C
,(select Top 1 Workorderno,Convert(Varchar,inspect_DateTime,8) Ddate,cast(Inspect_Val as numeric(12,2)) Dval from Inspect_Measure_history where Inspect_Code = 'ES20004' and workorderno = @Workorderno order by Inspect_datetime desc) AS D
,(select Top 1 Workorderno,Convert(Varchar,inspect_DateTime,8) Edate ,cast(Inspect_Val as numeric(12,2)) Eval from Inspect_Measure_history where Inspect_Code = 'ES20005' and workorderno = @Workorderno order by Inspect_datetime desc) AS E
where A.Workorderno=B.Workorderno and B.Workorderno=C.Workorderno and C.Workorderno=D.Workorderno and D.Workorderno=E.Workorderno";
                comm.CommandType = CommandType.Text;
                try
                {
                    foreach (var item in workno)
                    {
                        comm.Connection.Open();
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@Workorderno", item);

                        SqlDataReader reader = comm.ExecuteReader();
                        List<InspectMeasureHistoryVO> readlist = Helper.DataReaderMapToList<InspectMeasureHistoryVO>(reader);
                        foreach (var rlist in readlist)
                        {
                            list.Add(rlist);
                        }
                        comm.Connection.Close();
                    }
                }
                catch (Exception err)
                {
                    comm.Connection.Close();
                }
                return list;
            }
        }

        /// <summary>
        /// PRM_RPT_001 건조작업일지
        /// </summary>
        /// <param name="workno"></param>
        /// <returns></returns>
        public List<InspectMeasureHistoryVO> GetDrying(List<string> workno)
        {
            List<InspectMeasureHistoryVO> list = new List<InspectMeasureHistoryVO>() ;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @" SELECT A.Workorderno, Adate, Aval, Bdate, Bval, Cdate, Cval FROM 
(select Top 1 Workorderno,Convert(Varchar,inspect_DateTime,8) Adate,cast(Inspect_Val as numeric(12,2)) Aval from Inspect_Measure_history where Inspect_Code = 'ES30001' and workorderno = @Workorderno order by Inspect_datetime desc) AS A
,(select Top 1 Workorderno,Convert(Varchar,inspect_DateTime,8) Bdate,cast(Inspect_Val as numeric(12,2)) Bval from Inspect_Measure_history where Inspect_Code = 'ES30002' and workorderno = @Workorderno order by Inspect_datetime desc) AS B
,(select Top 1 Workorderno,Convert(Varchar,inspect_DateTime,8) Cdate,cast(Inspect_Val as numeric(12,2)) Cval from Inspect_Measure_history where Inspect_Code = 'ES30003' and workorderno = @Workorderno order by Inspect_datetime desc) AS C
where A.Workorderno=B.Workorderno and B.Workorderno=C.Workorderno ";
                comm.CommandType = CommandType.Text;
                try
                {
                    foreach (var item in workno)
                    {
                        comm.Connection.Open();
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@Workorderno", item);

                        SqlDataReader reader = comm.ExecuteReader();
                        List<InspectMeasureHistoryVO> readlist = Helper.DataReaderMapToList<InspectMeasureHistoryVO>(reader);
                        foreach (var rlist in readlist)
                        {
                            list.Add(rlist);
                        }
                        comm.Connection.Close();
                    }
                }
                catch (Exception err)
                {
                    comm.Connection.Close();
                }
                return list;
            }
        }
    }
}
