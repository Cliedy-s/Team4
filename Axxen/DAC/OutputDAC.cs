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
    public class OutputDAC : DACParent
    {
        /// <summary>
        /// 월별 생산현황
        /// </summary>
        /// <param name="month"></param>
        /// <param name="lmonth"></param>
        /// <returns></returns>
        public List<OutputVO> GetOutPut(string month, string lmonth)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = "GetOutput";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@lMonth", lmonth);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<OutputVO> list = Helper.DataReaderMapToList<OutputVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 월별 포장현황
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public List<BoxPackageVO> GetBoxPackage(string month)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = "GetBoxPackage";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Month", month);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<BoxPackageVO> list = Helper.DataReaderMapToList<BoxPackageVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
