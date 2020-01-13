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
        /// 모든 스크린 아이템
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_MasterVO> GetALLScreenItem()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetALLScreenItem";
                comm.CommandType = CommandType.StoredProcedure;
             

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ScreenItem_MasterVO> list = Helper.DataReaderMapToList<ScreenItem_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 그룹에 연결된 화면들
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_AuthorityVO> GetUseGroupScreenItem(string groupCode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetUseGroupScreenItem";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@UserGroup_Code", groupCode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ScreenItem_AuthorityVO> list = Helper.DataReaderMapToList<ScreenItem_AuthorityVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
           /// <summary>
        /// 그룹에서 사용하지않는 화면
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_AuthorityVO> GetNotUseGroupScreenItem(string groupCode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetNotUseGroupScreenItem";
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
