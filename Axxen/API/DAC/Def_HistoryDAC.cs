using API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API.DAC
{
    public class Def_HistoryDAC :DACParent
    {
        public bool SaveDef(Def_HistoryVO definfo) //불량 등록
        {    
            {
                string sql = @"insert into Def_History (Workorderno,Def_Mi_Code,Def_Date,Def_Qty,Def_Image_Name,Def_Image_Path,Ins_Emp,Up_Emp) 
                                values(@Workorderno,@Def_Mi_Code,@Def_Date,@Def_Qty,@Def_Image_Name,@Def_Image_Path,@Ins_Emp,@Up_Emp)";

                using (SqlConnection conn = new SqlConnection(Connstr))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Workorderno", definfo.Workorderno);
                    cmd.Parameters.AddWithValue("@Def_Mi_Code", definfo.Def_Mi_Code);
                    cmd.Parameters.AddWithValue("@Def_Date", definfo.Def_Date);
                    cmd.Parameters.AddWithValue("@Def_Qty", definfo.Def_Qty);
                    cmd.Parameters.AddWithValue("@Def_Image_Name", definfo.Def_Image_Name);
                    cmd.Parameters.AddWithValue("@Def_Image_Path", definfo.Def_Image_Path);
                    cmd.Parameters.AddWithValue("@Ins_Emp", definfo.Ins_Emp);
                    cmd.Parameters.AddWithValue("@Up_Emp", definfo.Up_Emp);
                    conn.Open();
                    int iResult = cmd.ExecuteNonQuery();
                    conn.Close();
                    return (iResult > 0);
                }
               
            }
        }

        public List<string> GetDefHistoryWorkorderno()
        {
            string sql = "select DISTINCT Workorderno from WorkOrder";
            List<string> list = new List<string>();
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
            return list;
        }
    }
}