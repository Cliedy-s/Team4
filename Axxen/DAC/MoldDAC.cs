using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VO;

namespace DAC
{
    public class MoldDAC : DACParent
    {
        public List<MoldVO> GetAllMold()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllMold";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MoldVO> moldlist = Helper.DataReaderMapToList<MoldVO>(reader);
                comm.Connection.Close();

                return moldlist;
            }
        }
    }
}
