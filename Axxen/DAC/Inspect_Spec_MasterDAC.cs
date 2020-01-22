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
    class Inspect_Spec_MasterDAC : DACParent
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
    }
}
