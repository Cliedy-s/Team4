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
    public class InspectMeasure_History_MasterDAC : DACParent
    {
        

             public List<InspectMeasure_History_MasterVO> GetMainInspectMeasure_History_Master() //QAM 002 메인 그리드뷰
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"Select imh.Workorderno , Prd_Date ,imh.Process_code, Process_name , Wc_Name , imh.Item_Code , Item_Name , imh.Inspect_code
                                from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								 INNER JOIN WorkOrder wo ON imh.Workorderno = wo.Workorderno
								 INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
								 INNER JOIN Item_Master im ON imh.Item_code = im.Item_Code";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectMeasure_History_MasterVO> list = Helper.DataReaderMapToList<InspectMeasure_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<InspectMeasure_History_MasterVO> PickerMainInspectMeasure_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2) //QAM 002 날짜별
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"Select imh.Workorderno , Prd_Date ,imh.Process_code, Process_name , Wc_Name , imh.Item_Code , Item_Name , imh.Inspect_code
                                from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								 INNER JOIN WorkOrder wo ON imh.Workorderno = wo.Workorderno
								 INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
								 INNER JOIN Item_Master im ON imh.Item_code = im.Item_Code
								 where Prd_Date BETWEEN @ADateTimePickerValue1 AND @ADateTimePickerValue2
								 Order by Prd_Date Desc;";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ADateTimePickerValue1", ADateTimePickerValue1);
                comm.Parameters.AddWithValue("@ADateTimePickerValue2", ADateTimePickerValue2);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectMeasure_History_MasterVO> list = Helper.DataReaderMapToList<InspectMeasure_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        

        public List<InspectMeasure_History_MasterVO> GetSubInspectMeasure_History_Master(string Workorderno, string Process_code, string Item_Code, string Inspect_code) //QAM 002 서브 그리드뷰
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"Select Inspect_name, SL
                                from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								 INNER JOIN Inspect_Spec_Master ism ON imh.Item_code = ism.Item_Code 
								 and imh.Process_code = ism.Process_code
								 and imh.Inspect_code = ism.Inspect_code
								 where imh.Workorderno = @Workorderno AND ism.Item_code = @Item_Code AND ism.Process_code=@Process_code AND ism.Inspect_code=@Inspect_code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Workorderno", Workorderno);
                comm.Parameters.AddWithValue("@Process_code", Process_code);
                comm.Parameters.AddWithValue("@Item_Code", Item_Code);
                comm.Parameters.AddWithValue("@Inspect_code", Inspect_code);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectMeasure_History_MasterVO> list = Helper.DataReaderMapToList<InspectMeasure_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public DataTable GetSubSubInspectMeasure_History_Master(string Workorderno, string Process_code, string Item_Code, string Inspect_code) //QAM 002 서브서브 그리드뷰
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(Connstr))
                {
                    conn.Open();
                    string sql = @"DECLARE @QRY           VARCHAR(MAX)  --동적쿼리(피벗컬럼)
                            , @FIRST_DATA  VARCHAR(30)    --첫번째 데이터
                            , @ETC_DATA    VARCHAR(30)    --그 외 데이터
                            , @PIVOT_COL   VARCHAR(MAX) --피벗컬럼목록(IN)
                            , @CNT            INTEGER           --데이터 건수
                            , @PIVOT_QRY   VARCHAR(MAX) --피벗쿼리

                            DECLARE C1 CURSOR FOR
                            SELECT '[' + CAST(Z.NumCheck as varchar) + ']' FIRST_DATA
                                    , ',[' + CAST(Z.NumCheck as varchar) + ']' ETC_DATA
                              FROM (Select ROW_NUMBER() over (order by Inspect_date ASC) NumCheck
								from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								  INNER JOIN Item_Master im ON imh.Item_code = im.Item_Code
								 INNER JOIN Inspect_Spec_Master ism ON imh.Item_code = ism.Item_Code 
								 and imh.Process_code = ism.Process_code
								 and imh.Inspect_code = ism.Inspect_code
								 where imh.Workorderno = '" + Workorderno + @"' AND ism.Item_code = '" + Item_Code + @"' AND ism.Process_code='" + Process_code + @"' AND ism.Inspect_code='" + Inspect_code + @"') Z
                              ORDER BY Z.NumCheck
                            
                            SET @CNT = 0
                            SET @PIVOT_COL = ''
                            
                            OPEN C1
                            FETCH C1 INTO @FIRST_DATA, @ETC_DATA
                            WHILE(@@FETCH_STATUS <> -1)
                            BEGIN
                               SET @CNT = @CNT + 1
                            
                               --최초일 경우 쉼표 없고, 그 외에는 맨 앞 쉼표 포함처리
                               IF @CNT = 1 BEGIN
                                  SET @PIVOT_COL = @PIVOT_COL + @FIRST_DATA
                               END
                               ELSE BEGIN
                                  SET @PIVOT_COL = @PIVOT_COL + @ETC_DATA
                               END
                            
                               PRINT '@PIVOT_COL ********* ' + @PIVOT_COL;
                            
                               FETCH C1 INTO @FIRST_DATA, @ETC_DATA
                            END
                            CLOSE C1
                            DEALLOCATE C1
                                                       
                            SET @QRY = ''
                            SET @QRY = @QRY + '
                              SELECT *
                            FROM (Select Inspect_datetime ,imh.Item_code , Item_Name ,Inspect_val,ROW_NUMBER() over (order by Inspect_date ASC) NumCheck, CONVERT(VARCHAR,Inspect_date,23) Inspect_date
								from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								  INNER JOIN Item_Master im ON imh.Item_code = im.Item_Code
								 INNER JOIN Inspect_Spec_Master ism ON imh.Item_code = ism.Item_Code 
								 and imh.Process_code = ism.Process_code
								 and imh.Inspect_code = ism.Inspect_code
								 where imh.Workorderno = ''" + Workorderno + @"'' AND ism.Item_code = ''" + Item_Code + @"'' AND ism.Process_code=''" + Process_code + @"'' AND ism.Inspect_code=''" + Inspect_code + @"'') T
                            PIVOT (max(Inspect_val) FOR NumCheck IN (' + @PIVOT_COL + ')) AS P'
                            
                            PRINT '@QRY 쿼리 ********* ' + @QRY;
                            
                            EXEC (@QRY)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    conn.Close();
                }
                return dt;
            }
            catch
            {
                throw;
            }
        }

        public List<InspectMeasure_History_MasterVO> GetAllInspectMeasure_History_Master()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select imh.Workorderno,Prd_Date , Process_name , Wc_Name , imh.Item_Code , Item_Name ,Inspect_name, USL , SL , LSL , Inspect_datetime ,Inspect_date , Inspect_measure_seq , Inspect_val
                                 from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								 INNER JOIN WorkOrder wo ON imh.Workorderno = wo.Workorderno
								 INNER JOIN Item_Master im ON imh.Item_Code = im.Item_Code
								 INNER JOIN Inspect_Spec_Master ism ON imh.Inspect_code = ism.Inspect_code
								 INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectMeasure_History_MasterVO> list = Helper.DataReaderMapToList<InspectMeasure_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<InspectMeasure_History_MasterVO> PickerInspectMeasure_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select imh.Workorderno,Prd_Date , Process_name , Wc_Name , imh.Item_Code , Item_Name ,Inspect_name, USL , SL , LSL , Inspect_datetime ,Inspect_date , Inspect_measure_seq , Inspect_val
                                 from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								 INNER JOIN WorkOrder wo ON imh.Workorderno = wo.Workorderno
								 INNER JOIN Item_Master im ON imh.Item_Code = im.Item_Code
								 INNER JOIN Inspect_Spec_Master ism ON imh.Inspect_code = ism.Inspect_code
								 INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
								 where Prd_Date BETWEEN @ADateTimePickerValue1 AND @ADateTimePickerValue2
								 Order by Prd_Date Desc";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ADateTimePickerValue1", ADateTimePickerValue1);
                comm.Parameters.AddWithValue("@ADateTimePickerValue2", ADateTimePickerValue2);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectMeasure_History_MasterVO> list = Helper.DataReaderMapToList<InspectMeasure_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        
    }
}
