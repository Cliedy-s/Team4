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
    class GV_Current_StatusDAC : DACParent
    {
        /// <summary>
        /// 대차 현황 
        /// </summary>
        /// <param name="woinichar"></param>
        /// <returns></returns>
        public List<GVStatusVO> GetGVCurrentStatus(string woinichar)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"   SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,im.[Item_Code]
      ,im.[Item_Name]
      ,wo.[Workorderno]
      ,wo.[Prd_Qty]
      ,wo.[Prd_Unit]
	  ,wcm.[Wc_Code]
      ,wcm.[Wo_Ini_Char]
  FROM [WorkOrder] as wo
  JOIN wcm.[WorkCenter_Master] as wcm ON wo.[Wc_Code] = wcm.[Wc_Code] AND wcm.[Use_YN] = 'Y'
  JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
  JOIN (
            SELECT GV_Code, Loading_time 
            FROM [GV_Current_Status] as cs 
            WHERE Loading_time = (SELECT MAX(Loading_time) FROM [GV_Current_Status] as cs2 WHERE cs.GV_Code =cs2.GV_Code GROUP BY cs2.GV_Code 
            )) as gvcs ON gvcs.[Workorderno] = wo.[Workorderno]
  JOIN [GV_Master] as gv ON gv.[GV_Code] = gvcs.[GV_Code]
	WHERE wcm.[Wo_Ini_Char] = @woinichar ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@woinichar", woinichar);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVStatusVO> list = Helper.DataReaderMapToList<GVStatusVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 요입현황
        /// </summary>
        /// <param name="woinichar"></param>
        /// <returns></returns>
        public List<GVInOutVO> GetGVCurrentInOut(string gvgroup, string wccode)
        { // 소성대차, 현재 작업장 코드
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT gvcs.[Status_Seq]
      ,gvcs.[GV_Code]
      ,gvcs.[Workorderno]
      ,gvcs.[Loading_date]
      ,gvcs.[Loading_time]
      ,gvcs.[Loading_Wc]
      ,gvcs.[In_Time]
      ,gvcs.[Center_Time]
      ,gvcs.[Out_Time]
      ,gv.[GV_Name]
      ,wo.[Wc_Code]
      ,wo.[In_Qty_Main]
  FROM [GV_Current_Status] as gvcs
	  JOIN [GV_Master] as gv ON gv.[GV_Code] = gvcs.[GV_Code] AND gv.[Use_YN] = 'Y'
	  JOIN [WorkOrder] as wo ON gvcs.[Workorderno] = wo.[Workorderno]
WHERE gv.[GV_Group] = @gvgroup
	AND wo.[Wc_Code] = @wccode; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@gvgroup", gvgroup);
                comm.Parameters.AddWithValue("@wccode", wccode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVInOutVO> list = Helper.DataReaderMapToList<GVInOutVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 요입
        /// </summary>
        /// <param name="username"></param>
        /// <param name="gvcode"></param>
        /// <param name="workorderno"></param>
        /// <returns></returns>
        public bool UpdateGVIn(string username, string gvcode, string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"UpdateGVIn";
                /*
  UPDATE [dbo].[GV_Current_Status]
   SET 
      [In_Time] = getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @gvcode
      AND [Workorderno] = @workorderno
      AND [In_Time] = null;

   UPDATE [dbo].[GV_History]
   SET 
      [In_Time] = getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @gvcode
      AND [Workorderno] = @workorderno
      AND [In_Time] = null;
                 */
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@gvcode", gvcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        } // TODO - 프로시저 생성
        /// <summary>
        /// 요출
        /// </summary>
        /// <param name="username"></param>
        /// <param name="gvcode"></param>
        /// <param name="workorderno"></param>
        /// <returns></returns>
        public bool UpdateGVOut(string username, string gvcode, string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"UpdateGVOut";
                /*
  UPDATE [dbo].[GV_Current_Status]
   SET 
      [Center_Time] = [In_Time] + DATEDIFF(mm,[In_Time],getdate())
      ,[Out_Time] =  getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @gvcode
      AND [Workorderno] = @workorderno;

   UPDATE [dbo].[GV_History]
   SET
      [Center_Time] = [In_Time] + DATEDIFF(mm,[In_Time],getdate())
      ,[Out_Time] = getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @gvcode
      AND [Workorderno] = @workorderno
                 */
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@gvcode", gvcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        } // TODO - 프로시저 생성

    }
}
