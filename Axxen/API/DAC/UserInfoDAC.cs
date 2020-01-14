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
    public class UserInfoDAC : DACParent
    {
        /// <summary>
        /// 사용자정보
        /// </summary>
        public UserInfoVO GetUserInfo(string id, string pwd)
        {
            List<UserInfoVO> user = null;
            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = new SqlConnection(Connstr);
                com.CommandText = "GetUserInfo";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@User_ID", id);
                com.Parameters.AddWithValue("@User_PW", pwd);
                com.Connection.Open();
                SqlDataReader reader = com.ExecuteReader();
                user = Helper.DataReaderMapToList<UserInfoVO>(reader);
                com.Connection.Close();

                return user[0];
            }


        }

    }
}
