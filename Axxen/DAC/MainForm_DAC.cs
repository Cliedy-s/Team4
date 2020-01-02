using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VO;
using System.Data;

namespace DAC
{
  public  class MainForm_DAC : DACParent
    {
        /// <summary>
        /// 메뉴 정보
        /// </summary>
        /// <returns></returns>
        public List<MenuTree_Master_VO> GetAll_MenuTree_Master()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAll_MenuTree_Master";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MenuTree_Master_VO> list = Helper.DataReaderMapToList<MenuTree_Master_VO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }




   }

