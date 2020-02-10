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

                return result > 1;
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
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = @"UpdateGVClear";

                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@Clear_Qty", item.Clear_Qty);
                    comm.Parameters.AddWithValue("@Clear_Cause", item.Clear_Cause);
                    comm.Parameters.AddWithValue("@Clear_wc", item.Clear_wc);
                    comm.Parameters.AddWithValue("@Clear_Item", item.Clear_Item);
                    comm.Parameters.AddWithValue("@Up_Emp", item.Up_Emp);
                    comm.Parameters.AddWithValue("@GV_Code", item.GV_Code);

                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    if(result == 0)
                    {
                        Log.WriteError($"{item.Up_Emp}이(가) 대차비우기를 시도하였으나 GV_History와 GV_Master와 GV_Current_Status에 존재하지 않는 대차코드({item.GV_Code})였음");
                    }
                    return result > 0;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
