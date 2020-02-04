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
        /// 로그인 이력추가
        /// </summary>
        /// <returns></returns>
        public void InsertLogin_History(Login_History login)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "insert into Login_History (User_ID,Login_Day,Login_Date,Login_Success) values(@User_ID,@Login_Day,@Login_Date,@Login_Success)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@User_ID", login.User_ID);
                comm.Parameters.AddWithValue("@Login_Day", login.Login_Day);
                comm.Parameters.AddWithValue("@Login_Date", login.Login_Date);
                comm.Parameters.AddWithValue("@Login_Success", login.Login_Success);

                 comm.Connection.Open();
                comm.ExecuteNonQuery();
                comm.Connection.Close();

                
            }
        }
        /// <summary>
        /// 유저 저장
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool InsertUser(UserInfoVO user)
        {

            try
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

               int resault = Convert.ToInt32(com.ExecuteNonQuery());

                com.Connection.Close();

                return resault>0;
            }

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<UserInfoVO> UserID_UserName()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select User_ID,User_Name from User_Master";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<UserInfoVO> list = Helper.DataReaderMapToList<UserInfoVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        
    }
}
