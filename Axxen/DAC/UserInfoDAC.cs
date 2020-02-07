﻿using System;
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
               int result= comm.ExecuteNonQuery();
                comm.Connection.Close();

                if (result>0)
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
                    com.Parameters.AddWithValue("@end",end.ToShortDateString());
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

    }
}
