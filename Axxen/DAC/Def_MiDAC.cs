﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
   public class Def_MiDAC : DACParent
    {

        /// <summary>
        /// 비가동 상세 전체
        /// </summary>
        /// <returns></returns>
        public List<Def_MiVO> GetAllDef_Mi_Master()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllDef_Mi_Master";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Def_MiVO> list = Helper.DataReaderMapToList<Def_MiVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 비가동 상세 저장 수정
        /// </summary>
        /// <returns></returns>
        public bool InsertUpdateDef_Mi_Master(Def_MiVO item)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "InsertUpdateDef_Mi_Master";
                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@Def_Mi_Code", item.Def_Mi_Code);
                    comm.Parameters.AddWithValue("@Def_Ma_Code", item.Def_Ma_Code);
                    comm.Parameters.AddWithValue("@Def_Mi_Name", item.Def_Mi_Name);
                    comm.Parameters.AddWithValue("@Remark", item.Remark);
                    comm.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);
               
                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    else
                        return false;

                }
            }
            catch
            {
            
                return false;
            }

        }

        /// <summary>
        ///  불량 상세 사용유무
        /// </summary>
        /// <param name="micode"></param>
        /// <param name="used"></param>
        /// <returns></returns>
        public bool UsedDef_Mi_Master(string micode, string used)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "UsedDef_Mi_Master";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Def_Mi_Code", micode);
                    comm.Parameters.AddWithValue("@Use_YN", used);

                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        /// <summary>
        /// 불량상세 삭제
        /// </summary>
        /// <param name="micode"></param>
        /// <returns></returns>
        public bool DeleteDef_MiVO(string micode)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "delete from Def_Mi_Master where @Def_Mi_Code=Def_Mi_Code";
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@Def_Mi_Code", micode);
               

                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
