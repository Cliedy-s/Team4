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
        /// 공지\사항전체
        /// </summary>
        /// <returns></returns>
        public List<Sys_NoticeVO> GetAllSys_notice()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"
SELECT TOP (1000) [Req]
      ,[Notice_Date]
      ,[Notice_End]
      ,[Title]
      ,[Description]
      ,[Notice_Rtf]
      ,[Reg_Type]
      ,[Email_Recipients]
      ,[Email_Send_Code]
      ,[Use_YN]
      ,[Remark]
      ,[Ins_Date]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp]
  FROM [TEAM4].[dbo].[Sys_Notice]";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Sys_NoticeVO> list = Helper.DataReaderMapToList<Sys_NoticeVO>(reader);
                comm.Connection.Close();

                return list;
            }

        }

        public List<Sys_NoticeVO> GetDayAllSys_notice(string start, string end)
        {
            try
            {

           
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"
      SELECT Convert(nvarchar(10),[Seq]) Req
      ,CONVERT(nvarchar(15),[Notice_Date]) Notice_Date
      ,CONVERT(NVARCHAR(15),[Notice_End])  Notice_End
      ,[Title]
      ,[Description] 
        FROM [TEAM4].[dbo].[Sys_Notice] where Notice_Date between @start and @end";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@start", start);
                comm.Parameters.AddWithValue("@end", end);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Sys_NoticeVO> list = Helper.DataReaderMapToList<Sys_NoticeVO>(reader);
                comm.Connection.Close();

                return list;
            }
            }
            catch (Exception)
            {

                throw;
            }

        }
    



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
