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
    public class UserGroupController : ApiController
    {
        public List<UserGroup_MasterVO> GetAllUserGroup()
        {
            UserGroupDAC dac = new UserGroupDAC();
            return dac.GetAllUserGroup();
        }

        public bool GetUpdateUserGroup(string groupcode, string check)
        {
            UserGroupDAC dac = new UserGroupDAC();
            return dac.GetUpdateUserGroup(groupcode, check);
        }
    }
}
