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
    public class BoxingGrade_Detail_MasterDAC : DACParent
    {
        /// <summary>
        /// 포장등급 가져오기
        /// </summary>
        /// <returns></returns>
        public List<BoxingGrade_Detail_MasterVO> GetAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"
    SELECT [Grade_Detail_Code]
          ,[Grade_Detail_Name]
          ,[Boxing_Grade_Code]
          ,[Use_YN]
          ,[Ins_Date]
          ,[Ins_Emp]
          ,[Up_Date]
          ,[Up_Emp]
      FROM [dbo].[BoxingGrade_Detail_Master]; 
";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<BoxingGrade_Detail_MasterVO> list = Helper.DataReaderMapToList<BoxingGrade_Detail_MasterVO>(reader);
                comm.Connection.Close();
                return list;
            }
        }
        /// <summary>
        /// 포장등급상세로 등급 가져오기
        /// </summary>
        /// <returns></returns>
        public string GellBoxing_Grade(string boxingDetailCode)
        {
            string item = string.Empty;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"
    SELECT
          [Boxing_Grade_Code]
      FROM [dbo].[BoxingGrade_Detail_Master]
    WHERE [Grade_Detail_Code] = @boxingDetailCode ; 
";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@boxingDetailCode", boxingDetailCode);

                comm.Connection.Open();
                object objitem = comm.ExecuteScalar();
                if (objitem != null)
                    item = objitem.ToString();
                comm.Connection.Close();
                return item;
            }
        }
    }
}
