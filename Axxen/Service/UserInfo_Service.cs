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


        public UserInfoVO GetUserInfo(string id, string pwd)
        {

            return dac.GetUserInfo(id,pwd);
        }

        public List<UserInfoVO> GetAllUser()
        {
        
            return dac.GetAllUser();
        }
        public bool InsertUser(UserInfoVO user)
        {
            return dac.InsertUser(user);
        }
    }
}
