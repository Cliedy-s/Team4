using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API.DAC
{
    public class ChartDAC : DACParent
    {
        public List<string> GetItemOutputChart()
        {
            List<string> list = new List<string>();
            string sql = "GetItemOutput";
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

        public List<string> GetItemBoxPackageChart()
        {
            List<string> list = new List<string>();
            string sql = "GetItemBoxPackage";
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