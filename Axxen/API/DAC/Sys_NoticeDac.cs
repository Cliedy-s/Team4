using API.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API.DAC
{
    public class Sys_NoticeDAC : DACParent
    {
        public List<Sys_NoticeVO> Sys_noticeAll()
        {


            string sql = "select Seq, Notice_Date, Notice_End, Title,Description, Ins_Emp from Sys_Notice";
            List<Sys_NoticeVO> list = new List<Sys_NoticeVO>();
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                list = Helper.DataReaderMapToList<Sys_NoticeVO>(reader);
                reader.Close();
                conn.Close();
            }
            return list;
        }

        public bool InsertSys_Notice(Sys_NoticeVO notice)
        {
            string sql = "Insert into Sys_Notice (Notice_Date, Notice_End, Title,Description,Ins_Emp) values(@Notice_Date, @Notice_End, @Title,@Description,@Ins_Emp)";
        
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Notice_Date", notice.Notice_Date);
                cmd.Parameters.AddWithValue("@Notice_End", notice.Notice_End);
                cmd.Parameters.AddWithValue("@Title", notice.Title);
                cmd.Parameters.AddWithValue("@Description", notice.Description);
                cmd.Parameters.AddWithValue("@Ins_Emp", UserInfo.User_Name);
     
                conn.Open();
                int iResult = cmd.ExecuteNonQuery();
                conn.Close();
                return (iResult > 0);
            }
          
        }

        public Sys_NoticeVO GetDetailsSys_Notice(int id, bool bDetail)
        {
            Sys_NoticeVO list = new Sys_NoticeVO();
            string sql = string.Empty;
            if (bDetail)
            {
                sql = "update Sys_Notice set Notice_Date=@Notice_Date, Notice_End=@Notice_End, Title=@Title,Description=@Description where Seq=@Seq";
            }
            else //수정일경우에는 조회수 + x
            {

                sql = @"select Seq, Notice_Date, Notice_End, Title,Description,Ins_Emp, (select min(Seq) from Sys_Notice where Seq >a.Seq) nextNum, (select max(Seq) from Sys_Notice where Seq<a.Seq) notnext from Sys_Notice a where Seq=@Seq";
            }

            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);    
                conn.Open();
                cmd.Parameters.AddWithValue("@SEQ", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Seq = Convert.ToInt32(reader["Seq"]);
                    list.Notice_Date = Convert.ToDateTime(reader["Notice_Date"]);
                    list.Notice_End = Convert.ToDateTime(reader["Notice_End"]);                 
                    list.Title = reader["Title"].ToString();
                    list.Description = reader["Description"].ToString();
                    list.Ins_Emp = reader["Ins_Emp"].ToString();
                    list.nextNum = reader["nextNum"].ToString();
                    list.notnext = reader["notnext"].ToString();
                }
                reader.Close();
                conn.Close();
            }
            return list;
        }

        public bool UpdateSys_Notice(Sys_NoticeVO notice)
        {
          

            string sql = "update Sys_Notice set Notice_Date=@Notice_Date, Notice_End=@Notice_End, Title=@Title,Description=@Description where Seq=@Seq";

            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SEQ", notice.Seq);
                cmd.Parameters.AddWithValue("@Notice_Date", notice.Notice_Date);
                cmd.Parameters.AddWithValue("@Notice_End", notice.Notice_End);
                cmd.Parameters.AddWithValue("@Title", notice.Title);
                cmd.Parameters.AddWithValue("@Description", notice.Description);



                conn.Open();
                int iResult = cmd.ExecuteNonQuery();
                conn.Close();
                return (iResult > 0);
            }
        }

        public bool DeleteSys_Notice(int id)
        {                 
                string sql = "delete from Sys_Notice where Seq=@Seq";

                using (SqlConnection conn = new SqlConnection(Connstr))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@SEQ", id);

                    conn.Open();
                    int iResult = cmd.ExecuteNonQuery();
                    conn.Close();
                    return (iResult > 0);
                }           
        }

    }
}