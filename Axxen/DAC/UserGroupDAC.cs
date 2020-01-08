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
            UserGroupDAC dac = new UserGroupDAC();

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllUserGroup";
                comm.CommandType = CommandType.StoredProcedure;
              //  comm.Parameters.AddWithValue("@")

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<UserGroup_MasterVO> list = Helper.DataReaderMapToList<UserGroup_MasterVO>(reader);
                comm.Connection.Close();

                return false;
            }

        }

    }
}
