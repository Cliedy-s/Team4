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
        string sql = "select Seq, Notice_Date, Notice_End, Title from Sys_Notice";
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
    }
}