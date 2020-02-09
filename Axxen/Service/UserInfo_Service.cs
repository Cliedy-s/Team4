using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class UserInfo_Service
    {
        UserInfoDAC dac;
        public UserInfo_Service()
        {
            dac = new UserInfoDAC();

        }
        public List<UserInfoVO> GetAllUser()
        {

            return dac.GetAllUser();
        }
        public void InsertLogin_History(Login_History login)
        {

            dac.InsertLogin_History(login);
        }
        public void InsertLogin_Screen_History(Login_Screen_HistoryVO loginscreen)
        {
            dac.InsertLogin_Screen_History(loginscreen);
        }
        /// <summary>
        /// 기간별 사용자 화면 사용 로그인 내역
        /// </summary>
        /// <param name="loginscreen"></param>
        /// <returns></returns>
        public List<SearchLogin_Screen_HistoryVO> GetUser_Screen_Login(DateTime start, DateTime end, string screencode, string userid)
        {
            return dac.GetUser_Screen_Login(start, end, screencode, userid);

        }
        public List<UserInfoVO> UserID_UserName() //유저 아이디 / 닉네임 서치
        {

            return dac.UserID_UserName();
        }
        public bool InsertUser(UserInfoVO user)
        {
            return dac.InsertUser(user);
        }
        /// <summary>
        /// 사용자 삭제
        /// </summary>
        /// <returns></returns>
        public bool DeleteUserInfoVO(string userid)
        {
            return dac.DeleteUserInfoVO(userid);
        }
        /// <summary>
        /// POP 로그인하기 return null : 실패 x : 성공  => User_Name, User_Type 리턴
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        public UserInfoVO GetLoginInfo(string userID, string userPassword)
        {
            return dac.GetLoginInfo(userID, userPassword);
        }
        public bool Default_Screen_Code(string id,string screencode)
        {
        

         return   dac.Default_Screen_Code(id,screencode);
        }

        public bool UpdateUserPassword(string id, string User_PW)
        {
            return dac.UpdateUserPassword(id, User_PW);
        }
        }
}
