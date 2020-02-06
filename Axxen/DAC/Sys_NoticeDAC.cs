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
    public class Sys_NoticeDAC : DACParent
    {
        /// <summary>
        /// 현재 공지사항 가져오기
        /// </summary>
        /// <param name="Seq"></param>
        /// <returns></returns>
        public Sys_NoticeVO GetCurrentSysNotice(int Seq) 
        {
            Sys_NoticeVO item = null;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"  SELECT * FROM (
	SELECT ROW_NUMBER() OVER(ORDER BY [Seq] DESC) AS SEQ
      ,[Notice_Date]
      ,[Notice_End]
      ,[Title]
      ,[Description]
  FROM [dbo].[Sys_Notice]
  WHERE (getdate() between [Notice_Date] and DATEADD(DAY, 1, [Notice_End]))
  ) AS NOTICE
  WHERE NOTICE.SEQ = @Seq; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Seq", Seq);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    item = new Sys_NoticeVO()
                    {
                        Req = reader[0].ToString(),
                        Notice_Date = reader[1].ToString(),
                        Notice_End = reader[2].ToString(),
                        Title = reader[3].ToString(),
                        Description = reader[4].ToString(),
                    };
                }
                comm.Connection.Close();

                return item;
            }
        }
    }
}
