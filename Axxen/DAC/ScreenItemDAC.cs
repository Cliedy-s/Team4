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
   public class ScreenItemDAC : DACParent
    {

        /// <summary>
        /// 그룹에 연결된 화면들
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_AuthorityVO> GetGroupScreenItem(string groupCode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetGroupScreenItem";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@UserGroup_Code", groupCode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ScreenItem_AuthorityVO> list = Helper.DataReaderMapToList<ScreenItem_AuthorityVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
