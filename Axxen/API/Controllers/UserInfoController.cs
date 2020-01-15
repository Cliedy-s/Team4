using API.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VO;

namespace API.Controllers
{
    public class UserInfoController : ApiController
    {
        public UserInfoVO GetUserInfo(string id, string pwd)
        {
            UserInfoDAC dac = new UserInfoDAC();
            return dac.GetUserInfo(id, pwd);
        }
    }
}
