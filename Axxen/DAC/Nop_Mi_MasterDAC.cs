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
    public class Nop_Mi_MasterDAC :DACParent
    {
        /// <summary>
        /// 비가동 소분류 목록
        /// </summary>
        public List<NopMiMasterVO> GetAllNopMi()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 	
	nim.Nop_Mi_Code
	, nim.Nop_Mi_Name
	, nim.Nop_Ma_Code
	, nim.Remark
	FROM Nop_Mi_Master AS nim
	WHERE nim.Use_YN = 'Y'; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMiMasterVO> list = Helper.DataReaderMapToList<NopMiMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 비가동 소분류 검색
        /// </summary>
        public List<NopMiMasterVO> GetAllNopMi(string macode)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT 	
	nim.Nop_Mi_Code
	, nim.Nop_Mi_Name
	, nim.Nop_Ma_Code
	, nim.Remark
	FROM Nop_Mi_Master AS nim
	WHERE nim.Use_YN = 'Y' AND nim.Nop_Ma_Code = @macode; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@macode", macode);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMiMasterVO> list = Helper.DataReaderMapToList<NopMiMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<NopMiMasterVO> GetCombo() //PRM_PRF_008_1 비가동상세분류코드
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select Nop_Mi_Code,Nop_Mi_Name from Nop_Mi_Master where Use_YN='Y'";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<NopMiMasterVO> list = Helper.DataReaderMapToList<NopMiMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
