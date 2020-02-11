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
    public class GV_Current_StatusDAC : DACParent
    {
        /// <summary>
        /// 대차 현황 
        /// </summary>
        /// <param name="wccode"></param>
        /// <returns></returns>
        public List<GVStatusVO> GetGVCurrentStatus(string wccode = null, string ProcessName = null, string workorderno = null, string gvStatus = null, string gvName = null, string gvGroup = null)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"GetGVCurrentStatus";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@ProcessName", ProcessName);
                comm.Parameters.AddWithValue("@gvStatus", gvStatus);
                comm.Parameters.AddWithValue("@workorderno", workorderno);
                comm.Parameters.AddWithValue("@GVName", gvName);
                comm.Parameters.AddWithValue("@GVGroup", gvGroup);

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
                comm.CommandText = @"UpdateGVIn";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@gvcode", gvcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
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
                comm.CommandText = @"UpdateGVOut";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@gvcode", gvcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }

    }
}
