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
        /// <summary>
        /// 로그인 이력추가
        /// </summary>
        /// <returns></returns>
        public void InsertLogin_History(Login_History login)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "insert into Login_History (Session_ID,User_ID,Login_Day,Login_Date,Login_Success) values(@Session_ID,@User_ID,@Login_Day,@Login_Date,@Login_Success)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Session_ID", login.Session_ID);
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
        /// 화면 사용내역 저장
        /// </summary>
        /// <param name="loginscreen"></param>
        /// <returns></returns>
        public bool InsertLogin_Screen_History(Login_Screen_HistoryVO loginscreen)
        {
            try
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = @"insert into Login_Screen_History (Session_ID,Open_Day,Open_Date,User_ID,Screen_Code)
                                    values(@Session_ID,@Open_Day,@Open_Date,@User_ID,@Screen_Code)";
                    com.CommandType = CommandType.Text;
                    com.Parameters.AddWithValue("@Session_ID", loginscreen.Session_ID);
                    // com.Parameters.AddWithValue("@Seg", loginscreen.Seg);
                    com.Parameters.AddWithValue("@Open_Day", loginscreen.Open_Day);
                    com.Parameters.AddWithValue("@Open_Date", loginscreen.Open_Date);
                    com.Parameters.AddWithValue("@User_ID", loginscreen.User_ID);
                    com.Parameters.AddWithValue("@Screen_Code", loginscreen.Screen_Code);


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
        /// <summary>
        /// 기간별 사용자 화면 사용 로그인 내역
        /// </summary>
        /// <param name="loginscreen"></param>
        /// <returns></returns>
        public List<SearchLogin_Screen_HistoryVO> GetUser_Screen_Login(DateTime start, DateTime end, string screencode, string userid)
        {
            try
            {

                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = "GetUser_Screen_Login";
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@User_ID", userid);
                    com.Parameters.AddWithValue("@start", start.ToShortDateString());
                    com.Parameters.AddWithValue("@end", end.ToShortDateString());
                    com.Parameters.AddWithValue("@Screen_Code", screencode);

                    com.Connection.Open();

                    SqlDataReader reader = com.ExecuteReader();
                    List<SearchLogin_Screen_HistoryVO> list = Helper.DataReaderMapToList<SearchLogin_Screen_HistoryVO>(reader);
                    com.Connection.Close();

                    return list;
                }

            }
            catch (Exception)
            {

                throw;
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
                    item = new UserInfoVO();
                    item.User_ID = reader[0].ToString();
                    item.User_Name = reader[1].ToString();
                    item.User_PW = reader[2].ToString();
                    item.Customer_Code = reader[3].ToString();
                    item.DefaultLanguage = reader[4].ToString();
                    item.User_Type = reader[5].ToString();
                    item.Price_Visible_YN = reader[6].ToString();
                    item.IP_Security_YN = reader[7].ToString();
                    item.Pw_Reset_Count = Convert.ToInt32(reader[8]);
                    item.Default_Screen_Code = reader[9].ToString();
                    item.Default_Process_Code = reader[10].ToString();
                    item.Monitoring_YN = reader[11].ToString();
                    item.Use_YN = reader[12].ToString();
                    item.S01 = reader[13].ToString();
                    item.S02 = reader[14].ToString();
                    item.S03 = reader[15].ToString();
                    item.S04 = reader[16].ToString();
                    item.S05 = reader[17].ToString();
                    item.S06 = reader[18].ToString();
                    item.S07 = reader[19].ToString();
                    item.S08 = reader[20].ToString();
                    item.S09 = reader[21].ToString();
                    item.S10 = reader[22].ToString();
                    item.S11 = reader[23].ToString();
                    item.S12 = reader[24].ToString();
                    item.Ins_Date = Convert.ToDateTime(reader[25]);
                    item.Ins_Emp = reader[26].ToString();
                    item.Up_Date = Convert.ToDateTime(reader[27]);
                    item.Up_Emp = reader[28].ToString();
                }
                comm.Connection.Close();

                return item;
            }
        }

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
    }
}
