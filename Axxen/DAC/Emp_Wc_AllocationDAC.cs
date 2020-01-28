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
    public class Emp_Wc_AllocationDAC : DACParent
    {
        /// <summary>
        /// 작업장에 할당된 작업자들 목록
        /// </summary>
        /// <param name="wccode"></param>
        /// <returns></returns>
        public List<WorkerVO> GetAllocatedWorker(string wccode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 
	ewa.Wc_Code
	, ewa.[User_ID]
	, ewa.Allocation_datetime
	, um.[User_Name]
FROM Emp_Wc_Allocation AS ewa
	JOIN User_Master AS um ON ewa.[User_ID] = um.[User_ID]
	WHERE ewa.Wc_Code = @wccode AND ewa.Release_datetime = null; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@wccode", wccode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkerVO> list = Helper.DataReaderMapToList<WorkerVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 작업장에 할당 가능한 작업자들 목록
        /// </summary>
        /// <param name="wccode"></param>
        /// <returns></returns>
        public List<WorkerAllocatableVO> GetAllocatableWorker(string wccode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 
	um.User_ID
	, um.User_Name
	, um.Default_Process_Code
	, wcm2.[Wc_Name]
FROM User_Master AS um
  RIGHT OUTER JOIN Emp_Wc_Allocation AS ewa ON ewa.User_ID = um.User_ID AND ewa.Release_datetime = null
  JOIN [WorkCenter_Master] as wcm ON um.Default_Process_Code = wcm.[Process_Code]
  JOIN [WorkCenter_Master] as wcm2 ON wcm2.[Wc_Code] = ewa.Wc_Code
	WHERE um.Use_YN = 'Y'
		AND wcm.[Wc_Code] =@wccode; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@wccode", wccode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<WorkerAllocatableVO> list = Helper.DataReaderMapToList<WorkerAllocatableVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
