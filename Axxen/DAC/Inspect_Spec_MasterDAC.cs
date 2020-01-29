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
    /// <summary>
    /// 검사항목규격
    /// </summary>
    public class Inspect_Spec_MasterDAC : DACParent
    {
        /// <summary>
        /// 검사항목규격설정 가져오기
        /// </summary>
        /// <returns></returns>
        public List<InspectSpecVO> GetAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "SELECT ism.Item_Code, ism.Process_code, ism.Inspect_code, ism.Inspect_name," +
                    " ism.Spec_Desc, ism.USL, ism.SL, ism.LSL, ism.Sample_size, ism.Inspect_Unit, ism.Use_YN," +
                    " ism.Remark FROM Inspect_Spec_Master AS ism ; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectSpecVO> list = Helper.DataReaderMapToList<InspectSpecVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 품목규격 설정 
        /// </summary>
        /// <param name="inspctspec"></param>
        public bool InsertInspectSpec(InspectSpecVO inspctspec)
        {
            try
            {

            using (SqlCommand com = new SqlCommand())
            {
                com.Connection = new SqlConnection(Connstr);
                com.CommandText = "InsertInspectSpec";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Item_Code", inspctspec.Item_Code);
                com.Parameters.AddWithValue("@Process_code", inspctspec.Process_code);
                com.Parameters.AddWithValue("@Inspect_code", inspctspec.Inspect_code);
                com.Parameters.AddWithValue("@Inspect_name", inspctspec.Inspect_name);
                com.Parameters.AddWithValue("@USL", inspctspec.USL);
                com.Parameters.AddWithValue("@SL", inspctspec.SL);
                com.Parameters.AddWithValue("@LSL", inspctspec.LSL);
                com.Parameters.AddWithValue("@Sample_size", inspctspec.Sample_size);
                com.Parameters.AddWithValue("@Inspect_Unit", inspctspec.Inspect_Unit);
                com.Parameters.AddWithValue("@Remark", inspctspec.Remark);

                com.Connection.Open();
                int resault = Convert.ToInt32(com.ExecuteNonQuery());
                com.Connection.Close();
                return resault > 0;
            }

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
