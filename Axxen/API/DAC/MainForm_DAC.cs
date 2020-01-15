using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using API.Models;

namespace API.DAC
{
    public class MainForm_DAC : DACParent
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
        public List<BookMark_VO> GetAll_BookMark(string id)
        {
            List<BookMark_VO> list = null;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAll_BookMark";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@User_ID", id);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                list = Helper.DataReaderMapToList<BookMark_VO>(reader);
                comm.Connection.Close();

                return list;
            }


        }

        /// <summary>
        /// 즐겨찾기추가
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool InsertBookMark(BookMark_VO list)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = "InsertBookMark";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@User_ID", list.User_ID);
                cmd.Parameters.AddWithValue("@Screen_Code", list.Screen_Code);
                cmd.Parameters.AddWithValue("@Parent_Screen_Code", list.Parent_Screen_Code);
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

