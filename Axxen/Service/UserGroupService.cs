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
        /// <summary>
        /// 그룹 저장
        /// </summary>
        /// <returns></returns>
        public bool GetInsertUserGroup(string groupcode, string UserGroup_Name , string user)
        {

            return dac.GetInsertUserGroup(groupcode, UserGroup_Name, user);
        }
        /// <summary>
        /// 수정
        /// </summary>
        /// <param name="groupcode"></param>
        /// <param name="UserGroup_Name"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool GetUpdateUserGroup(string groupcode, string UserGroup_Name, string user)
        {
            return dac.GetUpdateUserGroup(groupcode, UserGroup_Name, user);
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
