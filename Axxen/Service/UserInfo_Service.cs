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

        public List<UserInfoVO> UserID_UserName() //유저 아이디 / 닉네임 서치
        {

            return dac.UserID_UserName();
        }
        
        public bool InsertUser(UserInfoVO user)
        {
            return dac.InsertUser(user);
        }
    }
}
 