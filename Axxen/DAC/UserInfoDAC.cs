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
  public  class UserInfoDAC :DACParent
    {
        /// <summary>
        /// 로그인시 사용자정보
        /// </summary>
        public UserInfoVO GetUserInfo(string id,string pwd)
        {
            List<UserInfoVO> user = null;
            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = new SqlConnection(Connstr);
                com.CommandText = "GetUserInfo";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@User_ID", id);
                com.Parameters.AddWithValue("@User_PW", pwd);
                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                user = Helper.DataReaderMapToList<UserInfoVO>(reader);  
                com.Connection.Close();

                return user[0];
            }
        }
        /// <summary>
        /// 유저전체목록
        /// </summary>
        /// <returns></returns>
        public List<UserInfoVO> GetAllUser()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllUser";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<UserInfoVO> list = Helper.DataReaderMapToList<UserInfoVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 유저 저장
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool InsertUser(UserInfoVO user)
        {

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = new SqlConnection(Connstr);
                com.CommandText = "InsertUser";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@User_ID", user.User_ID);
                com.Parameters.AddWithValue("@User_Name", user.User_Name);
                com.Parameters.AddWithValue("@User_PW", user.User_PW);
                com.Parameters.AddWithValue("@Ins_Date", user.Ins_Date);
                com.Parameters.AddWithValue("@Ins_Emp", user.Ins_Emp);

                com.Connection.Open();

               int resault = com.ExecuteNonQuery();

                com.Connection.Close();

                return resault>0;
            }
        }
    }
}
