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
 @" 	SELECT CASE WHEN ((Allocation_datetime IS NOT NULL) AND (Release_datetime IS NULL)) THEN WCM.Wc_Code ELSE NULL END AS NOWWCcode
			, um.User_ID
			, Allocation_datetime
			, um.User_Name
	FROM User_Master as UM
	LEFT OUTER JOIN (SELECT * FROM Emp_Wc_Allocation as ewa1 WHERE Allocation_datetime= (SELECT MAX(Allocation_datetime) FROM Emp_Wc_Allocation as ewa2 WHERE ewa1.User_ID = ewa2.User_ID)) AS EWA ON UM.User_ID = EWA.User_ID
	JOIN WorkCenter_Master AS WCM ON WCM.Process_Code = UM.Default_Process_Code
	WHERE WCM.Wc_Code = @wccode AND (CASE WHEN ((Allocation_datetime IS NOT NULL) AND (Release_datetime IS NULL)) THEN WCM.Wc_Code ELSE NULL END) = @wccode ";
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
	SELECT UM.User_ID,
		   UM.User_Name,
			CASE WHEN ((Allocation_datetime IS NOT NULL) AND (Release_datetime IS NULL)) THEN WCM.Wc_Name ELSE NULL END AS NOWWC
			,CASE WHEN ((Allocation_datetime IS NOT NULL) AND (Release_datetime IS NULL)) THEN WCM.Wc_Code ELSE NULL END AS NOWWCcode
	FROM User_Master as UM
	LEFT OUTER JOIN (SELECT * FROM Emp_Wc_Allocation as ewa1 WHERE Allocation_datetime= (SELECT MAX(Allocation_datetime) FROM Emp_Wc_Allocation as ewa2 WHERE ewa1.User_ID = ewa2.User_ID)) AS EWA ON UM.User_ID = EWA.User_ID
	JOIN WorkCenter_Master AS WCM ON WCM.Process_Code = UM.Default_Process_Code
	WHERE WCM.Wc_Code = @wccode AND (((CASE WHEN ((Allocation_datetime IS NOT NULL) AND (Release_datetime IS NULL)) THEN WCM.Wc_Code ELSE NULL END) IS NULL) OR (CASE WHEN ((Allocation_datetime IS NOT NULL) AND (Release_datetime IS NULL)) THEN WCM.Wc_Code ELSE NULL END) <> @wccode)
 ";
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
