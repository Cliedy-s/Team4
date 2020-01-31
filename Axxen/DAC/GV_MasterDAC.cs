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
    public class GV_MasterDAC : DACParent
    {
        /// <summary>
        /// 대차리스트 작업장별로 가져오기
        /// </summary>
        public List<GVWorkItemVO> GetAllByWC(string wccode, string woinichar)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT tab1.[GV_Code] 
      ,tab1.[GV_Name] 
      ,tab1.[GV_Group] 
      ,tab1.[GV_Status] 
      ,tab1.[Unloading_Wc] 
      ,tab1.WorkOrderNo 
      ,wo.[Prd_Qty]  
      ,wo.[Prd_Unit] 
      ,wo.[Item_Code] 
      ,im.[Item_Name] 
 FROM (SELECT gv.[GV_Code] 
                    ,gv.[GV_Name] 
                    ,gv.[GV_Group] 
                    ,gv.[GV_Status]  
                    ,gv.[Unloading_Wc] 
                    ,GetCurrentWorkOrderNoByGVCode(gv.[GV_Code]) as WorkOrderNo 
            FROM [GV_Master] as gv 
            WHERE  
                  gv.[Unloading_Wc] = @UnloadingWc 
                  AND  gv.[Use_YN] = 'Y' 
                  AND (gv.[GV_Status] = '적재' OR gv.[GV_Status] = '언로딩') 
                  AND @Wo_Ini_Char = (SELECT [Wo_Ini_Char]  
                                                            FROM [WorkCenter_Master] 
                                                             WHERE gv.[Unloading_Wc] = [Wc_Code] 
                  AND gv.[Use_YN] = 1) 
             ) as tab1 
                JOIN [WorkOrder] as wo ON tab1.WorkOrderNo = wo.[Workorderno] 
                JOIN [Item_Master] as im ON wo.[Workorderno] = im.[Item_Code];  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@UnloadingWc", wccode);
                comm.Parameters.AddWithValue("@Wo_Ini_Char", woinichar);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVWorkItemVO> list = Helper.DataReaderMapToList<GVWorkItemVO>(reader);
                comm.Connection.Close();

                return list;
            }
        } // TODO : 프로시저로 빼기
        /// <summary>
        /// 대차리스트 대차그룹, 대차상태 따라 가져오기
        /// </summary>
        /// <param name="gvgroup"></param>
        /// <param name="gvstatus"></param>
        /// <returns></returns>
        public List<GVVO> GetAllByGV(string gvgroup, string gvstatus)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"   SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,gv.[Unloading_Wc]
  FROM [GV_Master] as gv
 WHERE @gvgroup = gv.[GV_Group] AND  gv.[GV_Status] = @gvstatus AND gv.[Use_YN]='Y';  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@gvgroup", gvgroup);
                comm.Parameters.AddWithValue("@gvstatus", gvstatus);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVVO> list = Helper.DataReaderMapToList<GVVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 적재시간을 포함한 대차리스트
        /// </summary>
        /// <returns></returns>
        public List<GVLoadingTimeVO> GetAllWithLoadingTime(string gvgroup, string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"    SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,gv.[Unloading_Wc]
	  ,GetCurrentWorkOrderNoByGVCode(gv.[GV_Code]) as Workorderno
      ,wo.[Prd_Qty]
      ,wo.[Prd_Unit]
      ,gvcs.[Loading_time]
  FROM [GV_Master] as gv
	JOIN [WorkOrder] as wo ON wo.[Workorderno] = Workorderno
	JOIN [GV_Current_Status] as gvcs ON gvcs.[Workorderno] = Workorderno
  WHERE gv.[Use_YN] = 'Y'
	AND gv.[GV_Group] = @Gv_Group
	AND wo.[Workorderno] = @workorderno;  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Gv_Group", gvgroup);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVLoadingTimeVO> list = Helper.DataReaderMapToList<GVLoadingTimeVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<GVMasterVO> GetAllByGVMaster()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"SELECT [GV_Code]
      ,[GV_Name]
      ,[GV_GroupCode]
      ,[GV_Group]
  FROM [TEAM4].[dbo].[GV_Master]";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVMasterVO> list = Helper.DataReaderMapToList<GVMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
