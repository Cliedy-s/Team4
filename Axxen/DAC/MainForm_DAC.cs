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

        /// <summary>
        /// 즐겨찾기정보
        /// </summary>
        /// <returns></returns>
        public List<BookMark_VO> GetAll_BookMark(int id)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAll_BookMark";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@id", id);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<BookMark_VO> list = Helper.DataReaderMapToList<BookMark_VO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 즐겨찾기추가
        /// </summary>
        /// <param name="pcode">부모메뉴코드</param>
        /// <param name="scode">폼코드</param>
        /// <returns></returns>
        public bool InsertBookMark(string pcode,string scode)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = "InsertBookMark";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@User_ID", 1);
                cmd.Parameters.AddWithValue("@Screen_Code", scode);
                cmd.Parameters.AddWithValue("@Parent_Screen_Code", pcode);
                cmd.Parameters.AddWithValue("@Type", pcode);
                cmd.Parameters.AddWithValue("@Ins_Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Ins_Emp", "박상인");

                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rowsAffected > 0;
            }

      
        } 
    }




   }

