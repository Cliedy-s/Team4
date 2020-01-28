using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    public class UserGroupDAC : DACParent
    {

        /// <summary>
        /// 로그인한 사용자가 속해있는 모든 그룹
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<UserGroup_MappingVO> GetUserInfoGroup(string userID)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetUserInfoGroup";
                comm.Parameters.AddWithValue("@User_ID", userID);
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<UserGroup_MappingVO> list = Helper.DataReaderMapToList<UserGroup_MappingVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }



        /// <summary>
        /// 그룹get
        /// </summary>
        /// <returns></returns>
        public List<UserGroup_MasterVO> GetAllUserGroup()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllUserGroup";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<UserGroup_MasterVO> list = Helper.DataReaderMapToList<UserGroup_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 그룹 사용유무update 
        /// </summary>
        /// <returns></returns>
        public bool GetUpdateUserGroup(string groupcode, string used)
        {
         
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetUpdateUserGroup";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@UserGroup_Code",groupcode);
                comm.Parameters.AddWithValue("@Use_YN", used);

                comm.Connection.Open();
               int result = Convert.ToInt32(comm.ExecuteScalar());
                comm.Connection.Close();

                if (result > 0)
                    return true;
                return false;
            }

        }
        /// <summary>
        /// 그룹 저장
        /// </summary>
        /// <returns></returns>
        public bool GetInsertUserGroup(string groupcode, string UserGroup_Name, string user)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "GetInsertUserGroup";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@UserGroup_Code", groupcode);
                    comm.Parameters.AddWithValue("@UserGroup_Name", UserGroup_Name);
                    comm.Parameters.AddWithValue("@Ins_Emp", user);


                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;

            }
        }
        
        /// <summary>
        /// 그룹 수정
        /// </summary>
        /// <returns></returns>
        public bool GetUpdateUserGroup(string groupcode, string UserGroup_Name, string user)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "GetUpdateUsedUserGroup";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@UserGroup_Code", groupcode);
                    comm.Parameters.AddWithValue("@UserGroup_Name", UserGroup_Name);
                    comm.Parameters.AddWithValue("@Ins_Emp", user);
                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;

            }
        }
        /// <summary>
        /// 그룹맵핑 
        /// </summary>
        /// <returns></returns>
        public List<UserGroup_MappingVO> GetAllUserGroup_Mapping()
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllUserGroup_Mapping";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<UserGroup_MappingVO> list = Helper.DataReaderMapToList<UserGroup_MappingVO>(reader);
                comm.Connection.Close();

                return list;
            }

        }

        /// <summary>
        /// 추가한 항목 저장
        /// </summary>
        /// <param name="List"></param>
        public void InsertUpdateUserGroup_Mapping(List<UserGroup_MappingVO> List)
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);

                for (int i = 0; i < List.Count; i++)
                {
                    comm.CommandText = "InsertUpdateUserGroup_Mapping";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@UserGroup_Code", List[i].UserGroup_Code);
                    comm.Parameters.AddWithValue("@User_ID", List[i].User_ID);
                    comm.Parameters.AddWithValue("@Ins_Date", List[i].Ins_Date);
                    comm.Parameters.AddWithValue("@Ins_Emp", List[i].Ins_Emp);
              

                    comm.Connection.Open();
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    comm.Connection.Close();
                }
            }

        }
        /// <summary>
        /// 그룹에서 사용하던 유저들을 더이상 사용하지않을때.
        /// </summary>
        /// <param name="List"></param>
        public void DeleteUserGroup_Mapping(List<UserGroup_MappingVO> List)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);

                for (int i = 0; i < List.Count; i++)
                {
                    comm.CommandText = "DeleteUserGroup_Mapping";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@UserGroup_Code", List[i].UserGroup_Code);
                    comm.Parameters.AddWithValue("@User_ID", List[i].User_ID);

                    comm.Connection.Open();
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    comm.Connection.Close();
                }
            }

        }

    }
}
