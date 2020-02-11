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
	WHERE ewa.Wc_Code = @wccode AND ewa.Release_datetime IS null; ";
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
 @"     
 SELECT * FROM (
  SELECT UM.User_ID,
  UM.User_Name,
  CASE WHEN Release_datetime IS NOT NULL THEN NULL WHEN Release_datetime IS NULL THEN WCM2.Wc_Name END AS NOWWC,
  CASE WHEN Release_datetime IS NOT NULL THEN NULL WHEN Release_datetime IS NULL THEN WCM2.Wc_Code END AS NOWWCcode
  FROM Emp_Wc_Allocation AS EWA
	JOIN User_Master AS UM ON UM.User_ID = EWA.User_ID
	JOIN WorkCenter_Master AS WCM ON WCM.Process_Code = UM.Default_Process_Code
	JOIN WorkCenter_Master AS WCM2 ON WCM2.Wc_Code = EWA.Wc_Code
  WHERE WCM.Wc_Code = @wccode) as currentt WHERE (currentt.NOWWCcode != @wccode or currentt.NOWWCcode is null) ";
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
