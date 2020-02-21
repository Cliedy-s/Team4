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
      FROM [dbo].[BoxingGrade_Detail_Master]
	  WHERE Use_YN = 'Y'; 
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
        /// <summary>
        /// 박스삭제
        /// </summary>
        /// <param name="boxcode"></param>
        /// <returns></returns>
        public bool DeleteBoxingGrade_Detail_MasterVO(string boxcode)
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"delete from BoxingGrade_Detail_Master where Grade_Detail_Code=@Grade_Detail_Code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Grade_Detail_Code", boxcode);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                if (result > 0)

                    return true;
                else
                    return false;
            }
        }
        /// <summary>
        /// 포장 사용
        /// </summary>
        /// <param name="code"></param>
        /// <param name="use"></param>
        /// <returns></returns>
        public bool UsedBoxingGrade_Detail_MasterVO(string code, string use)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"update BoxingGrade_Detail_Master set Use_YN=@Use_YN where Grade_Detail_Code=@Grade_Detail_Code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Grade_Detail_Code", code);
                comm.Parameters.AddWithValue("@Use_YN", use);
                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                if (result > 0)

                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// 포장 저장 업데이트
        /// </summary>
        /// <returns></returns>
        public bool GetInsertUpdateBoxingGrade_Detail_MasterVO(string check, string code, string Name, string bigcode, string user)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {

                    if (check == "저장")
                    {
                        check = "GetInsertBox";
                    }
                    else
                    {
                        check = "GetUpdateBox";
                    }
                    comm.CommandText = check;
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Grade_Detail_Code", code);
                    comm.Parameters.AddWithValue("@Grade_Detail_Name", Name);
                    comm.Parameters.AddWithValue("@Boxing_Grade_Code", bigcode);
                    comm.Parameters.AddWithValue("@Ins_Emp", user);

                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                

            }
        }
    }
}
