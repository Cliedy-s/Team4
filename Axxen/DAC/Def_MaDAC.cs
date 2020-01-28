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
   public class Def_MaDAC : DACParent
    {

        /// <summary>
        /// 비가동 대분류 전체
        /// </summary>
        /// <returns></returns>
        public List<Def_MaVO> GetAllDef_Ma_Master()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllDef_Ma_Master";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Def_MaVO> list = Helper.DataReaderMapToList<Def_MaVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 그룹 사용유무update 
        /// </summary>
        /// <returns></returns>
        public bool GetUpdateDef_Ma_Master(string groupcode, string used)
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetUpdateDef_Ma_Master";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Def_Ma_Code", groupcode);
                comm.Parameters.AddWithValue("@Use_YN", used);

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
