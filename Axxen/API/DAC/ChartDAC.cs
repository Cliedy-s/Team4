using API.Models;
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
        public List<ChartOutputVO> GetItemOutputChart(string name)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetItemOutput";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Item_Name", name);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ChartOutputVO> list = Helper.DataReaderMapToList<ChartOutputVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<ChartBoxPackageVO> GetItemBoxPackageChart(string name)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetItemBoxPackage";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Item_Name", name);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ChartBoxPackageVO> list = Helper.DataReaderMapToList<ChartBoxPackageVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}