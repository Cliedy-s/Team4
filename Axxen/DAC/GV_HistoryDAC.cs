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
    public class GV_HistoryDAC : DACParent
    {
        /// <summary>
        /// 언로딩
        /// </summary>
        public bool UpdateUnload(string username, string gvcode, string workorderno, string wccode, int qty)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"Unloading";
                //UPDATE[dbo].[GV_Current_Status]
                //  SET
                //     [Unloading_date] = getdate()
                //     ,[Unloading_time] = getdate()
                //     ,[Up_Date] = getdate()
                //     ,[Up_Emp] = @username
                //WHERE[GV_Code] = @gvcode
                //     AND[Workorderno] = @workorderno
                //     AND[Unloading_time] = null;

                //  UPDATE[dbo].[GV_History]
                //       SET
                //    [Unloading_Qty] = [Unloading_Qty] + @qty
                //     ,[Unloading_date] = getdate()
                //     ,[Unloading_datetime] = getdate()
                //     ,[Unloading_wc] = @wccode
                //     ,[Up_Date] = getdate()
                //     ,[Up_Emp] = @username
                //WHERE[GV_Code] = @gvcode
                //     AND[Workorderno] = @workorderno
                //     AND[Unloading_datetime] = null

                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@gvcode", gvcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);
                comm.Parameters.AddWithValue("@wccode", wccode);
                comm.Parameters.AddWithValue("@qty", qty);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }

        } // TODO : 프로시저 만들기
        /// <summary>
        /// 대차비우기
        /// </summary>
        public bool UpdateClearGV(GVClearVO item)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"
UPDATE[dbo].[GV_History]
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
,[Workorderno] = @Workorderno; ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Clear_Qty", item.Clear_Qty);
                comm.Parameters.AddWithValue("@Clear_Cause", item.Clear_Cause);
                comm.Parameters.AddWithValue("@Clear_wc", item.Clear_wc);
                comm.Parameters.AddWithValue("@Clear_Item", item.Clear_Item);
                comm.Parameters.AddWithValue("@Up_Emp", item.Up_Emp);
                comm.Parameters.AddWithValue("@GV_Code", item.GV_Code);
                comm.Parameters.AddWithValue("@Workorderno", item.Workorderno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
    }
}
