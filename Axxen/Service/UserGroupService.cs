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
        UserGroupDAC dac;
        public UserGroupService()
        {
            dac = new UserGroupDAC();
        }

        public List<UserGroup_MappingVO> GetUserInfoGroup(string userID)
        {
            return dac.GetUserInfoGroup(userID);
        }

            public List<UserGroup_MasterVO> GetAllUserGroup()
        {


            return dac.GetAllUserGroup();
        }

        public bool GetUpdateUserGroup(string groupcode, string check)
        {


            return dac.GetUpdateUserGroup(groupcode, check);
        }

        public List<UserGroup_MappingVO> GetAllUserGroup_Mapping()
        {

            return dac.GetAllUserGroup_Mapping();

        }
        public void InsertUpdateUserGroup_Mapping(List<UserGroup_MappingVO> List)
        {
            dac.InsertUpdateUserGroup_Mapping(List);
        }
        public void DeleteUserGroup_Mapping(List<UserGroup_MappingVO> List)
        {
            dac.DeleteUserGroup_Mapping(List);
        }
        }
}
