using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAC
{
    class MoldDAC : DACParent
    {
        //public List<BOMVO> SelectBomAll()
        //{
        //    using (SqlCommand comm = new SqlCommand())
        //    {
        //        comm.Connection = new SqlConnection(Connstr);
        //        comm.CommandText = "";
        //        comm.CommandType = CommandType.StoredProcedure;

        //        comm.Connection.Open();
        //        SqlDataReader reader = comm.ExecuteReader();
        //        List<BOMVO> bomList = Helper.DataReaderMapToList<BOMVO>(reader);
        //        comm.Connection.Close();

        //        return bomList;
        //    }
        //}
    }
}
