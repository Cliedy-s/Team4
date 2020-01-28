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
   public class ProcessDAC : DACParent
    {
        /// <summary>
        /// 모든공정get
        /// </summary>
        /// <returns></returns>
        public List<Process_MasterVO> GetAllProcess_Master()
        {
            try
            { 
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllProcess_Master";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Process_MasterVO> list = Helper.DataReaderMapToList<Process_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 공정 사용유무update 
        /// </summary>
        /// <returns></returns>
        public bool GetUpdateProcessMaster(string processcode, string used)
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetUpdateProcessMaster";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Process_code", processcode);
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
