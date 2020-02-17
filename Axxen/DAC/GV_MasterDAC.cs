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
        /// 대차 검색
        /// </summary>
        /// <returns></returns>
        public List<GVMasterVO> GetGVs(string gvStatus = null, string gvName = null, string gvGroup = null)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"GetGVs";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@gvStatus", gvStatus);
                comm.Parameters.AddWithValue("@gvName", gvName);
                comm.Parameters.AddWithValue("@gvGroup", gvGroup);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVMasterVO> list = Helper.DataReaderMapToList<GVMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 모든대차의 모든정보
        /// </summary>
        /// <returns></returns>
        public List<GVMasterVO> GetALLGVMaster()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"SELECT  [GV_Code]
      ,[GV_Name]
      ,[GV_GroupCode]
      ,[GV_Group]
      ,[GV_Status]
      ,[Unloading_Wc]
      ,[Use_YN]
      ,[Ins_Date]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp]
  FROM [TEAM4].[dbo].[GV_Master] ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVMasterVO> list = Helper.DataReaderMapToList<GVMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 대차 INSERT UPDTAE
        /// </summary>
        /// <param name="GVMaster"></param>
        /// <returns></returns>
        public bool InsertUpdateGV_Master(GVMasterVO GVMaster)
        {
            try
            {

       
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"	IF NOT EXISTS(SELECT GV_Code FROM GV_Master WHERE GV_Code=@GV_Code)
   BEGIN
		INSERT INTO GV_Master(   GV_Code,GV_Name,GV_GroupCode,GV_Group,GV_Status,Ins_Date,Ins_Emp) 
VALUES(@GV_Code,@GV_Name,@GV_GroupCode,@GV_Group,@GV_Status,GETDATE(),@Ins_Emp)
   END
 ELSE
	 BEGIN
		UPDATE GV_Master SET GV_Code=@GV_Code,GV_Name=@GV_Name,GV_GroupCode=@GV_GroupCode,GV_Group=@GV_Group,GV_Status=@GV_Status
		,Up_Date=GETDATE(),Up_Emp=@Ins_Emp
		where GV_Code=@GV_Code
	   END";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@GV_Code", GVMaster.GV_Code);
                comm.Parameters.AddWithValue("@GV_Name", GVMaster.GV_Name);
                comm.Parameters.AddWithValue("@GV_GroupCode", GVMaster.GV_GroupCode);
                comm.Parameters.AddWithValue("@GV_Group", GVMaster.GV_Group);
                comm.Parameters.AddWithValue("@GV_Status", GVMaster.GV_Status);
                comm.Parameters.AddWithValue("@Ins_Emp", GVMaster.Ins_Emp);

                comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteNonQuery());
                comm.Connection.Close();

                if (result > 0)
                    return true;
                return false;
            }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 대차 사용여부 변경
        /// </summary>
        /// <param name="GV_Code"></param>
        /// <param name="used"></param>
        /// <returns></returns>
        public bool UsedGV_Master(string GV_Code, string used)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = @"	
		UPDATE GV_Master SET Use_YN =@Use_YN
		where GV_Code=@GV_Code";

                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@GV_Code", GV_Code);
                    comm.Parameters.AddWithValue("@Use_YN", used);

                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 대차삭제
        /// </summary>
        /// <param name="gvcode"></param>
        /// <returns></returns>
        public bool DeleteGVMasterVO(string gvcode)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = @"delete from GV_Master where GV_Code=@GV_Code";

                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@GV_Code", gvcode);
            

                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
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
        public List<GVMasterVO> GetGV_Code()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"SELECT [GV_Code]
      ,[GV_Name]
  FROM [TEAM4].[dbo].[GV_Master]";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<GVMasterVO> list = Helper.DataReaderMapToList<GVMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        public List<GVMasterVO> GetGV_GroupCode()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"SELECT  DISTINCT [GV_GroupCode],[GV_Group]
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
