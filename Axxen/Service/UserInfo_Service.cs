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
        public UserInfoVO GetUserInfo(string id, string pwd)
        {
            UserInfoDAC dac = new UserInfoDAC();
            return dac.GetUserInfo(id,pwd);
        }
}
}
