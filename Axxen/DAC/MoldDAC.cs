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
        public List<MoldVO> SelectMoldAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "SelectMoldAll";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<Mold_J_Item_Wc_MuseVO> SelectMold_Item_Wc_Muse()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "SelectMold_Item_Wc_Muse";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Mold_J_Item_Wc_MuseVO> list = Helper.DataReaderMapToList<Mold_J_Item_Wc_MuseVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
