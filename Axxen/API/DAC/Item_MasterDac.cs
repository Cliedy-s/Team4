using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API.DAC
{
    public class Item_MasterDAC : DACParent
    {

        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<string> GetAllItem_Master()
        {
       

            List<string> list = new List<string>();

            string sql = "GetAllItem_Master";
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
 
                    while (reader.Read())
                    {
                        list.Add(reader[1].ToString());
                    }
                }
            }
            return list;

        }

    }
}