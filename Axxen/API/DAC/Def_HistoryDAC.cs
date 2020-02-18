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
                    cmd.Parameters.AddWithValue("@Def_Image_Name", definfo.FileUploadFile.FileName);
                    cmd.Parameters.AddWithValue("@Def_Image_Path", definfo.FileUploadFilePath);
                    cmd.Parameters.AddWithValue("@Ins_Emp", definfo.Ins_Emp);
                    cmd.Parameters.AddWithValue("@Up_Emp", definfo.Up_Emp);
                    conn.Open();
                    int iResult = cmd.ExecuteNonQuery();
                    conn.Close();
                    return (iResult > 0);
                }
               
            }
        }

        public List<Def_HistoryVO> GetDefMiMasterCodeName() //상세 코드 ,코드명 가지고오는 쿼리
        {
            string sql = "select Def_Mi_Name,Def_Mi_Code from Def_Mi_Master";
            List<Def_HistoryVO> list = new List<Def_HistoryVO>();
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                list = Helper.DataReaderMapToList<Def_HistoryVO>(reader);
                reader.Close();
                conn.Close();
            }
            return list;
        }

        public List<string> GetDefHistoryWorkorderno() //작업지시번호만 가지고오는 쿼리
        {
            string sql = "select DISTINCT Workorderno from Workorder";
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


        public List<Def_History2VO> DefectiveDetails() // 불량이력 찾아오는 쿼리
        {
            string sql = @"select Def_Seq,Workorderno,defh.Def_Mi_Code as Def_Mi_Code,defm.Def_Mi_Name as Def_Mi_Name,Def_Date,Def_Qty,defm.Ins_Date as Ins_Date,defm.Ins_Emp as Ins_Emp
                            from Def_History defh INNER JOIN Def_Mi_Master defm ON defh.Def_Mi_Code = defm.Def_Mi_Code Order by Def_Seq ASC";
            List<Def_History2VO> list = new List<Def_History2VO>();
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Def_History2VO
                    {
                        Def_Seq = Convert.ToInt32(reader["Def_Seq"]),
                        Workorderno = reader["Workorderno"].ToString(),
                        Def_Mi_Code = reader["Def_Mi_Code"].ToString(),
                        Def_Mi_Name = reader["Def_Mi_Name"].ToString(),
                        Def_Date = reader["Def_Date"].ToString(),
                        Def_Qty = Convert.ToInt32(reader["Def_Qty"]),
                        //FileUploadFilePath = reader["Def_Image_Name"].ToString(),
                        //FileUploadFile = (HttpPostedFileBase)reader["Def_Image_Path"],
                        Ins_Date = reader["Ins_Date"].ToString(),
                        Ins_Emp = reader["Ins_Emp"].ToString(),
                    });
                }
                reader.Close();
                conn.Close();
            }
            return list;
        }
        
    }
}