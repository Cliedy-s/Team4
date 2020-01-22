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
    class Nop_Ma_MasterDAC :DACParent
    {
        /// <summary>
        /// 비가동 대분류 목록
        /// </summary>
        public List<NopMaMasterVO> GetAllNopMi()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 	
	nam.Nop_Ma_Code
	,nam.Nop_Ma_Name
	FROM Nop_Ma_Master AS nam
	WHERE nam.Use_YN = 'Y'; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMaMasterVO> list = Helper.DataReaderMapToList<NopMaMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
