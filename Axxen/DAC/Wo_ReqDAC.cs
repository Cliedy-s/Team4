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
    public class Wo_ReqDAC : DACParent
    {
        public List<Wo_Req_ItemVO> GetAllWoReq() //PPS_SCH_001 그리드뷰 사용
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "GetAllWoReq";
                comm.CommandType = CommandType.StoredProcedure;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Wo_Req_ItemVO> list = Helper.DataReaderMapToList<Wo_Req_ItemVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
