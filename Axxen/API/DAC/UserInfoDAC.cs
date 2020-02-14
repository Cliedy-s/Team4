using API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DAC
{
    public class UserInfoDAC : DACParent
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
        ///// <summary>
        ///// 로그인 이력추가
        ///// </summary>
        ///// <returns></returns>
        //public void InsertLogin_History(Login_History login)
        //{
        //    using (SqlCommand comm = new SqlCommand())
        //    {
        //        comm.Connection = new SqlConnection(Connstr);
        //        comm.CommandText = "insert into Login_History (Session_ID,User_ID,Login_Day,Login_Date,Login_Success) values(@Session_ID,@User_ID,@Login_Day,@Login_Date,@Login_Success)";
        //        comm.CommandType = CommandType.Text;
        //        comm.Parameters.AddWithValue("@Session_ID", login.Session_ID);
        //        comm.Parameters.AddWithValue("@User_ID", login.User_ID);
        //        comm.Parameters.AddWithValue("@Login_Day", login.Login_Day);
        //        comm.Parameters.AddWithValue("@Login_Date", login.Login_Date);
        //        comm.Parameters.AddWithValue("@Login_Success", login.Login_Success);

        //        comm.Connection.Open();
        //        comm.ExecuteNonQuery();
        //        comm.Connection.Close();


        //    }
        //}
        /// <summary>
        /// 사용자 삭제
        /// </summary>
        /// <returns></returns>
        public bool DeleteUserInfoVO(string userid)
        {
            try
            {

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "delete from User_Master where User_ID=@User_ID";
                    comm.CommandType = CommandType.Text;

                    comm.Parameters.AddWithValue("@User_ID", userid);

                    comm.Connection.Open();
                    int result = comm.ExecuteNonQuery();
                    comm.Connection.Close();

                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {

                return false;
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

                    return resault > 0;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// 사용자 기본화명설정
        /// </summary>
        /// <param name="screencode"></param>
        /// <returns></returns>
        public bool Default_Screen_Code(string id, string screencode)
        {
            try
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = @"UPDATE User_Master SET Default_Screen_Code=@Default_Screen_Code WHERE User_ID=@User_ID ";
                    com.CommandType = CommandType.Text;
                   
                    com.Parameters.AddWithValue("@User_ID", id);
                    com.Parameters.AddWithValue("@Default_Screen_Code", screencode);


                    com.Connection.Open();

                    int resault = Convert.ToInt32(com.ExecuteNonQuery());

                    com.Connection.Close();

                    return resault > 0;
                }

            }
            catch (Exception)
            {

                throw;
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
      
      
        /// <summary>
        /// POP 로그인하기 return null : 실패 x : 성공  => User_Name, User_Type 리턴
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        public UserInfoVO GetLoginInfo(string userID, string userPassword)
        {
            UserInfoVO item = null;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
@"
    SELECT TOP(1) [User_ID]
      ,[User_Name]
      ,[User_PW]
      ,[Customer_Code]
      ,[DefaultLanguage]
      ,[User_Type]
      ,[Price_Visible_YN]
      ,[IP_Security_YN]
      ,[Pw_Reset_Count]
      ,[Default_Screen_Code]
      ,[Default_Process_Code]
      ,[Monitoring_YN]
      ,[Use_YN]
      ,[S01]
      ,[S02]
      ,[S03]
      ,[S04]
      ,[S05]
      ,[S06]
      ,[S07]
      ,[S08]
      ,[S09]
      ,[S10]
      ,[S11]
      ,[S12]
      ,[Ins_Date]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp]
  FROM [dbo].[User_Master]
    WHERE User_ID = @User_ID AND User_PW = @User_PW ;
";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@User_ID", userID);
                comm.Parameters.AddWithValue("@User_PW", userPassword);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    UserInfoVO user = new UserInfoVO();
                    UserInfo.User_ID = reader[0].ToString();
                    UserInfo.User_Name = reader[1].ToString();
                    UserInfo.User_PW = reader[2].ToString();
                    UserInfo.Customer_Code = reader[3].ToString();
                    UserInfo.DefaultLanguage = reader[4].ToString();
                    UserInfo.User_Type = reader[5].ToString();
                    UserInfo.Price_Visible_YN = reader[6].ToString();
                    UserInfo.IP_Security_YN = reader[7].ToString();
                    UserInfo.Pw_Reset_Count = Convert.ToInt32(reader[8]);
                    UserInfo.Default_Screen_Code = reader[9].ToString();
                    UserInfo.Default_Process_Code = reader[10].ToString();
                    UserInfo.Monitoring_YN = reader[11].ToString();
                    UserInfo.Use_YN = reader[12].ToString();
                    UserInfo.S01 = reader[13].ToString();
                    UserInfo.S02 = reader[14].ToString();
                    UserInfo.S03 = reader[15].ToString();
                    UserInfo.S04 = reader[16].ToString();
                    UserInfo.S05 = reader[17].ToString();
                    UserInfo.S06 = reader[18].ToString();
                    UserInfo.S07 = reader[19].ToString();
                    UserInfo.S08 = reader[20].ToString();
                    UserInfo.S09 = reader[21].ToString();
                    UserInfo.S10 = reader[22].ToString();
                    UserInfo.S11 = reader[23].ToString();
                    UserInfo.S12 = reader[24].ToString();
                    UserInfo.Ins_Date = Convert.ToDateTime(reader[25]);
                    UserInfo.Ins_Emp = reader[26].ToString();
                    UserInfo.Up_Date = Convert.ToDateTime(reader[27]);
                    UserInfo.Up_Emp = reader[28].ToString();

                    user.User_ID = reader[0].ToString();
                    user.User_Name = reader[1].ToString();
                    user.User_PW = reader[2].ToString();
                    user.Customer_Code = reader[3].ToString();
                    user.DefaultLanguage = reader[4].ToString();
                    user.User_Type = reader[5].ToString();
                    user.Price_Visible_YN = reader[6].ToString();
                    user.IP_Security_YN = reader[7].ToString();
                    user.Pw_Reset_Count = Convert.ToInt32(reader[8]);
                    user.Default_Screen_Code = reader[9].ToString();
                    user.Default_Process_Code = reader[10].ToString();
                    user.Monitoring_YN = reader[11].ToString();
                    user.Use_YN = reader[12].ToString();
                    user.S01 = reader[13].ToString();
                    user.S02 = reader[14].ToString();
                    user.S03 = reader[15].ToString();
                    user.S04 = reader[16].ToString();
                    user.S05 = reader[17].ToString();
                    user.S06 = reader[18].ToString();
                    user.S07 = reader[19].ToString();
                    user.S08 = reader[20].ToString();
                    user.S09 = reader[21].ToString();
                    user.S10 = reader[22].ToString();
                    user.S11 = reader[23].ToString();
                    user.S12 = reader[24].ToString();
                    user.Ins_Date = Convert.ToDateTime(reader[25]);
                    user.Ins_Emp = reader[26].ToString();
                    user.Up_Date = Convert.ToDateTime(reader[27]);
                    user.Up_Emp = reader[28].ToString();
                }
                comm.Connection.Close();

                return item;
            }
        }
        /// <summary>
        /// 사용자 페스워드 변경
        /// </summary>
        /// <param name="id"></param>
        /// <param name="User_PW"></param>
        /// <returns></returns>
        public bool UpdateUserPassword(string id,string User_PW)
        {
            try
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = @"update User_Master set User_PW=@User_PW, Pw_Reset_Count=Pw_Reset_Count+1 where User_ID=@User_ID";
                    com.CommandType = CommandType.Text;
                  
                    com.Parameters.AddWithValue("@User_ID", id);
                    com.Parameters.AddWithValue("@User_PW", User_PW);


                    com.Connection.Open();

                    int resault = Convert.ToInt32(com.ExecuteNonQuery());

                    com.Connection.Close();

                    return resault > 0;
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        /// <summary>
        /// 사용자 단축기변경
        /// </summary>
        /// <param name="shortcut1"></param>
        /// <param name="shortcut2"></param>
        /// <param name="shortcut3"></param>
        /// <param name="shortcut4"></param>
        /// <param name="subshortcut1"></param>
        /// <param name="subshortcut2"></param>
        /// <param name="subshortcut3"></param>
        /// <param name="subshortcut4"></param>
        /// <returns></returns>
        public bool UpdateShortcutUser_Master(string userid,string shortcut1, string shortcut2, string shortcut3, string shortcut4, string subshortcut1, string subshortcut2, string subshortcut3, string subshortcut4)
        {

            try
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = @"update User_Master set S01=@S01, S02=@S02 , S03=@S03 , S04=@S04 where User_ID=@User_ID";
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@User_ID", userid);
                    com.Parameters.AddWithValue("@S01", shortcut1+"/"+subshortcut1);
                    com.Parameters.AddWithValue("@S02", shortcut2 + "/" + subshortcut2);
                    com.Parameters.AddWithValue("@S03", shortcut3 + "/" + subshortcut3);
                    com.Parameters.AddWithValue("@S04", shortcut4 + "/" + subshortcut4);

                    com.Connection.Open();

                    int resault = Convert.ToInt32(com.ExecuteNonQuery());

                    com.Connection.Close();

                    return resault > 0;
                }

            }
            catch (Exception )
            {
               // return false;
                throw;
            }
        }
        }
}
