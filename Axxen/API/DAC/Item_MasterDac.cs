using API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API.DAC
{
    public class Item_MasterDAC : DACParent
    {

        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<string> GetAllItem_Master()
        {
       

            List<string> list = new List<string>();

            string sql = "GetAllItem_Master";
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
 
                    while (reader.Read())
                    {
                        list.Add(reader[1].ToString());
                    }
                }
            }
            return list;

        }

        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Item_MasterVO> GetAllItem_Master2()
        {
            try
            {
                List<Item_MasterVO> Itemlist = null;
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = "GetAllItem_Master";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Connection.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    Itemlist = Helper.DataReaderMapToList<Item_MasterVO>(reader);
                    com.Connection.Close();

                    return Itemlist;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}