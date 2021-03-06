﻿using System;
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
                                    from Work_History wh INNER JOIN WorkCenter_Master wcm ON wcm.Wc_Code = wh.Wc_Code
					                                     INNER JOIN User_Master um ON wh.User_ID = um.User_ID Order by Work_Date Desc";
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

        public List<WorkHistory_Center_UserMasterVO> GetAllUserDetails(string UserName) //PRM_PRF_010 서브그리드뷰 사용
        {
            List<WorkHistory_Center_UserMasterVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select DISTINCT eahd.Workorderno,wcm.Wc_Code,Wc_Name,im.Item_Code,Item_Name,eahd.Prd_Starttime,eahd.Prd_Endtime,eahd.Prd_Qty,User_Name " +
                    $"from Work_History wh " +
                    $"INNER JOIN Emp_Allocation_History_Detail eahd ON wh.User_ID = eahd.User_ID " +
                    $"INNER JOIN WorkOrder wo ON eahd.Workorderno = wo.Workorderno " +
                    $"INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code " +
                    $"INNER JOIN Item_Master im ON wo.Item_Code = im.Item_Code " +
                    $"INNER JOIN User_Master um ON wh.User_ID = um.User_ID " +
                    $"where Work_Date = CONVERT(CHAR(10), eahd.Prd_Starttime, 23) AND User_Name = '{UserName}' " +
                    $"order by eahd.Prd_Starttime Desc";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<WorkHistory_Center_UserMasterVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
        
        public DataTable PickerWorkHistory_UserMaster(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_010 DateTimePicker 사용
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
                            SELECT '[' + Z.OUT_DT2 + ']' FIRST_DATA
                                    , ',[' + Z.OUT_DT2 + ']' ETC_DATA
                              FROM (
                            			 SELECT CONVERT(VARCHAR,A.Work_Date,112) OUT_DT2
                            			  FROM Work_History A
                            			  where Work_Date BETWEEN @ADateTimePickerValue1 AND @ADateTimePickerValue2
                            			 GROUP BY A.Work_Date
                            		   ) Z
                              ORDER BY Z.OUT_DT2
                            
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
                            FROM (select wh.User_ID,User_Name,Work_Date
                            from Work_History wh INNER JOIN User_Master um ON wh.User_ID=um.User_ID) T
                            PIVOT (Count(Work_Date) FOR Work_Date IN ('+ @PIVOT_COL +')) AS P'
                            
                            PRINT '@QRY 쿼리 ********* ' + @QRY;
                            
                            EXEC (@QRY)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ADateTimePickerValue1", ADateTimePickerValue1);
                        cmd.Parameters.AddWithValue("@ADateTimePickerValue2", ADateTimePickerValue2);
                        //list = Helper.DataReaderMapToList<WorkHistory_Center_UserMasterVO>(cmd.ExecuteReader());

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

        public DataTable PickerWorkHistory_UserMaster_UserID(string ADateTimePickerValue1, string ADateTimePickerValue2, string UserID) //PRM_PRF_010 작업자별 사용
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
                            SELECT '[' + Z.OUT_DT2 + ']' FIRST_DATA
                                    , ',[' + Z.OUT_DT2 + ']' ETC_DATA
                              FROM (
                            			 SELECT CONVERT(VARCHAR,A.Work_Date,112) OUT_DT2
                            			  FROM Work_History A
                            			  where Work_Date BETWEEN @ADateTimePickerValue1 AND @ADateTimePickerValue2
                            			 GROUP BY A.Work_Date
                            		   ) Z
                              ORDER BY Z.OUT_DT2
                            
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
                            FROM (select wh.User_ID,User_Name,Work_Date
                            from Work_History wh INNER JOIN User_Master um ON wh.User_ID=um.User_ID where  wh.User_ID = ''" + UserID + @"'') T
                            PIVOT (Count(Work_Date) FOR Work_Date IN ('+ @PIVOT_COL +')) AS P'
                            
                            PRINT '@QRY 쿼리 ********* ' + @QRY;
                            
                            EXEC (@QRY)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ADateTimePickerValue1", ADateTimePickerValue1);
                        cmd.Parameters.AddWithValue("@ADateTimePickerValue2", ADateTimePickerValue2);
                        //cmd.Parameters.AddWithValue("@UserID", UserID);
                        //list = Helper.DataReaderMapToList<WorkHistory_Center_UserMasterVO>(cmd.ExecuteReader());

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

        /// <summary>
        /// 근무 시작
        /// </summary>
        /// <param name="insertitem"></param>
        /// <returns></returns>
        public bool InsertStartWork(string processcode, string userid, string wccode)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {

                    comm.CommandText = @"InsertUpdateStartWork";
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@processcode", processcode);
                    comm.Parameters.AddWithValue("@userid", userid);
                    comm.Parameters.AddWithValue("@wccode", wccode);

                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    return (result > 0);
                }
            }
            catch (Exception ee)
            {
                Log.WriteFatal("오류 : ", ee);
                return false;
            }
        }
        /// <summary>
        /// 근무 종료
        /// </summary>
        /// <param name="insertitem"></param>
        /// <returns></returns>
        public bool UpdateEndWork(string processcode, string userid, string wccode)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    
                    comm.CommandText = @"
   UPDATE [dbo].[Work_History]
   SET [Work_EndTime] = getdate()
      ,[Work_Time] = DATEDIFF(HOUR, [Work_StartTime], getdate())
      ,Wc_Code = @wccode
      ,[Remark] = '근무종료'
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @userid
 WHERE DATEDIFF(DD, [Work_Date] ,getdate()) = 0
      AND [Process_Code] = @processcode
      AND [User_ID] = @userid; 
    ";
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@userid", userid);
                    comm.Parameters.AddWithValue("@processcode", processcode);
                    comm.Parameters.AddWithValue("@wccode", wccode);

                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    return (result > 0);
                }
            }
            catch (Exception ee)
            {
                Log.WriteFatal("오류 : ", ee);
                return false;
            }
        }

    }
}
