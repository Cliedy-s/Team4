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
	public class Emp_Allocation_HistoryDAC : DACParent
    {
        /// <summary>
        /// 작업자 할당
        /// </summary>
        public bool InsertWorkerAllocate(string targetUserId, string username, string wcCode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"InsertWorkerAllocate";
				/*
INSERT INTO Emp_Allocation_History(
	User_ID
	, Allocation_date
	, Allocation_datetime
	, Release_datetime
	, Ins_Date
	, Ins_Emp
	, Up_Date
	, Up_Emp)
	VALUES(
	@User_ID
	, getdate()
	, getdate()
	, null
	, getdate()
	, @Ins_Emp
	, getdate()
	,@Up_Emp);
INSERT INTO Emp_Wc_Allocation (
	Wc_Code
	, User_ID
	, Allocation_datetime
	, Release_datetime
	, Ins_Date
	, Ins_Emp
	, Up_Date
	, Up_Emp
	)	
	VALUES(
	@Wc_Code
	, @User_ID
	, getdate()
	, null
	, getdate()
	, @Ins_Emp
	, getdate()
	, @Up_Emp);
                 */
				comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@User_ID", targetUserId);
                comm.Parameters.AddWithValue("@Wc_Code", wcCode);
                comm.Parameters.AddWithValue("@Ins_Emp", username);
                comm.Parameters.AddWithValue("@Up_Emp", username);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
		/// <summary>
		/// 작업자 해제
		/// </summary>
		/// <param name="targetUserId"></param>
		/// <param name="username"></param>
		/// <param name="wcCode"></param>
		/// <returns></returns>
		public bool UpdateWorkerDeallocate(string targetUserId, string username, string wcCode)
		{
			using (SqlCommand comm = new SqlCommand())
			{
				comm.Connection = new SqlConnection(Connstr);
				comm.CommandText =
 @"UpdateWorkerDeallocate";
				/*
UPDATE Emp_Allocation_History SET 
	 Release_datetime = getdate()
	, Up_Date = getdate()
	, Up_Emp = @Up_Emp
WHERE 
	Release_datetime = null 
	AND User_ID = @UserID;
UPDATE Emp_Wc_Allocation SET
	 Release_datetime = getdate()
	, Up_Date = getdate()
	, Up_Emp = @UpEmp
 WHERE 
	 Release_datetime =null
	AND Wc_Code = @wccode
	AND User_ID = @UserID;
                 */
				comm.CommandType = CommandType.StoredProcedure;
				comm.Parameters.AddWithValue("@Up_Emp", username);
				comm.Parameters.AddWithValue("@UserID", targetUserId);
				comm.Parameters.AddWithValue("@wccode", wcCode);

				comm.Connection.Open();
				int result = comm.ExecuteNonQuery();
				comm.Connection.Close();

				return result > 0;
			}

		}
		/// <summary>
		/// 작업자 전체 해제
		/// </summary>
		/// <param name="targetUserId"></param>
		/// <param name="username"></param>
		/// <param name="wcCode"></param>
		/// <returns></returns>
		public bool UpdateWorkerDeallocateAll(List<string> targetUserIds, string username, string wcCode)
		{
			StringBuilder sb = new StringBuilder();
			foreach (string item in targetUserIds)
			{
				sb.Append(item + "@");
			}

			using (SqlCommand comm = new SqlCommand())
			{
				comm.Connection = new SqlConnection(Connstr);
				comm.CommandText = @"UpdateWorkerDeallocateAll";
				comm.CommandType = CommandType.StoredProcedure;
				comm.Parameters.AddWithValue("@Up_Emp", username);
				comm.Parameters.AddWithValue("@UserID", targetUserIds.ToString().TrimEnd('@'));
				comm.Parameters.AddWithValue("@wccode", wcCode);
				comm.Parameters.AddWithValue("@splitchar", '@');

				comm.Connection.Open();
				int result = comm.ExecuteNonQuery();
				comm.Connection.Close();

				return result > 0;
			}

		}
	}
}
