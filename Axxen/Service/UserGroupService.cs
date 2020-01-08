using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
  public class UserGroupService
    {
        public List<UserGroup_MasterVO> GetAllUserGroup()
        {
            UserGroupDAC dac = new UserGroupDAC();
   
            return dac.GetAllUserGroup();
        }

        public bool GetUpdateUserGroup(string groupcode,string check)
        {
            UserGroupDAC dac = new UserGroupDAC();

            return dac.GetUpdateUserGroup(groupcode, check);
        }
    }
}
