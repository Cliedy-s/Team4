using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Models;

namespace API.DAC
{
    public class UserGroupDAC : DACParent
    {
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
        /// 그룹update 
        /// </summary>
        /// <returns></returns>
        public bool GetUpdateUserGroup(string groupcode, string check)
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetUpdateUserGroup";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@UserGroup_Code", groupcode);
                comm.Parameters.AddWithValue("@Use_YN", check);

                comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteScalar());
                comm.Connection.Close();

                if (result > 0)
                    return true;
                return false;
            }

        }

    }
}
