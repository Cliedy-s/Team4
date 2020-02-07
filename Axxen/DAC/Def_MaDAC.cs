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
        /// 상세내용 사용유무update 
        /// </summary>
        /// <returns></returns>
        public bool GetUpdateDef_Ma_Master(string Def_Ma_Code, string used)
        {
            try
            {       
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetUpdateDef_Ma_Master";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Def_Ma_Code", Def_Ma_Code);
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

                throw;
            }

        }

        /// <summary>
        /// 불량현상대분류 저장 및 업데이트
        /// </summary>
        /// <param name="def"></param>
        /// <returns></returns>
        public bool InsertUpdateDef_MaVO(Def_MaVO def)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "InsertUpdateDef_MaVO";
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@Def_Ma_Code", def.Def_Ma_Code);
                    comm.Parameters.AddWithValue("@Def_Ma_Name", def.Def_Ma_Name);
                    comm.Parameters.AddWithValue("@Ins_Emp", def.Ins_Emp);

                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch 
            {
               
                throw;
            }
        }
        
        /// <summary>
        /// 불량현상대분류 삭제
        /// </summary>
        /// <param name="def"></param>
        /// <returns></returns>
        public bool DeleteDef_MaVO(string defmacode)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "delete from Def_Ma_Master where Def_Ma_Code=@Def_Ma_Code";
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddWithValue("@Def_Ma_Code", defmacode);
              

                    comm.Connection.Open();
                    int result = Convert.ToInt32(comm.ExecuteNonQuery());
                    comm.Connection.Close();

                    if (result > 0)
                        return true;
                    return false;
                }
            }
            catch
            {

                throw;
            }
        }
    }
}
