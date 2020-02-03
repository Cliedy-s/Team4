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
    public class Nop_Ma_MasterDAC :DACParent
    {

        /// <summary>
        /// 비가동 대분류 목록 사용하지 않는것도 전부 박상인
        /// </summary>
        public List<NopMaMasterVO> GetAllNopMA()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @" SELECT 	
	   Nop_Ma_Code,Nop_Ma_Name,Use_YN,Ins_Date,Ins_Emp,Up_Date,Up_Emp 
	   FROM Nop_Ma_Master ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMaMasterVO> list = Helper.DataReaderMapToList<NopMaMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
     


        /// <summary>
        /// 비가동 대분류 목록 소현이가만든거
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
        /// <summary>
        /// 비가동 상세 저장 수정
        /// </summary>
        /// <returns></returns>
        public bool InsertUpdateNop_Ma_Master(NopMaMasterVO item)
        {
            try
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = new SqlConnection(Connstr);
                    comm.CommandText = "InsertUpdateNop_Ma_Master";
                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@Nop_Ma_Code", item.Nop_Ma_Code);
                    comm.Parameters.AddWithValue("@Nop_Ma_Name", item.Nop_Ma_Name);
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

               throw;
            }

        }
        /// <summary>
        /// 그룹 사용유무update 
        /// </summary>
        /// <returns></returns>
        public bool GetUseNopservice(string groupcode, string used)
        {

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = $"update Nop_Ma_Master set Use_YN=@Use_YN where Nop_Ma_Code=@Nop_Ma_Code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Nop_Ma_Code", groupcode);
                comm.Parameters.AddWithValue("@Use_YN", used);

                comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteNonQuery());
                comm.Connection.Close();

                if (result > 0)
                    return true;
                return false;
            }

        }
    }
}
