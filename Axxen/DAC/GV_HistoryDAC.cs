using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    public class GV_HistoryDAC : DACParent
    {
        /// <summary>
        /// 로딩
        /// </summary>
        public bool UpdateLoad(string username, string gvcode, int qty, string wccode, string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"UpdateLoad"; // 기본대차 수량 설정해둠

                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@gvcode", gvcode);
                comm.Parameters.AddWithValue("@qty", qty);
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 언로딩
        /// </summary>
        public bool UpdateUnload(string username, string gvcode, string targetgvcode, string wccode, int qty)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"UpdateUnloading"; 

                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@gvcode", gvcode);
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@qty", qty);
                comm.Parameters.AddWithValue("@targetgvcode", targetgvcode); 

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        ///  옮겨타기
        /// </summary>
        public bool UpdateMoveGvItem(string unloadgvcode, string loadgvcode, int unloadqty, string userid, string wccode, string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"UpdateMoveGvItem";

                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@unloadgvcode", unloadgvcode);
                comm.Parameters.AddWithValue("@loadgvcode", loadgvcode);
                comm.Parameters.AddWithValue("@unloadqty", unloadqty);
                comm.Parameters.AddWithValue("@userid", userid);
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }

        /// <summary>
        /// 대차비우기
        /// </summary>
        public bool UpdateClearGV(GVClearVO item)
        {
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText =
 @"UPDATE [dbo].[GV_History]
 SET
 [Clear_Date] = getdate() 
 ,[Clear_Datetime] = getdate()
 ,[Clear_Qty] = @Clear_Qty
 ,[Clear_Cause] = @Clear_Cause 
 ,[Clear_wc] = @Clear_wc 
 ,[Clear_Item] = @Clear_Item
 ,[Up_Date] = getdate()
 ,[Up_Emp] = @Up_Emp
 WHERE [GV_Code] = @GV_Code
	AND Loading_time = (SELECT MAX(Loading_time) FROM [GV_History] WHERE GV_Code = @GV_Code); ";
                comm.Parameters.AddWithValue("@Clear_Qty", item.Clear_Qty);
                comm.Parameters.AddWithValue("@Clear_Cause", item.Clear_Cause);
                comm.Parameters.AddWithValue("@Clear_wc", item.Clear_wc);
                comm.Parameters.AddWithValue("@Clear_Item", item.Clear_Item);
                comm.Parameters.AddWithValue("@Up_Emp", item.Up_Emp);
                comm.Parameters.AddWithValue("@GV_Code", item.GV_Code);

                SqlCommand comm2 = new SqlCommand();
                comm2.Connection = conn;
                comm2.CommandText = 
@"UPDATE [GV_Master] SET GV_Status = '빈대차' WHERE GV_Code = @gvcode; ";
                comm2.Parameters.AddWithValue("@gvcode", item.GV_Code);

                SqlTransaction transaction =null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();

                    comm.Transaction = transaction;
                    comm2.Transaction = transaction;

                    int result = comm.ExecuteNonQuery();
                    int result2 = comm2.ExecuteNonQuery();
                    transaction.Commit();
                    conn.Close();

                    return (result > 0) && (result2 > 0);
                }
                catch (Exception ee)
                {
                    Debug.WriteLine(ee.Message);
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
