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
    class Condition_Spec_MasterDAC : DACParent
    {
        /// <summary>
        /// 공정조건 측정항목 가져오기
        /// </summary>
        /// <returns></returns>
        public List<ConditionSpecVO> GetAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = 
 @"SELECT 
	 csm.Item_Code
	, csm.Wc_Code
	, csm.Condition_Code
	, csm.Condition_Name
	, csm.Spec_Desc
	, csm.SL 
	, csm.USL 
	, csm.LSL 
	, csm.Condition_Unit
	, csm.Condition_Group
	, csm.Remark
	FROM Condition_Spec_Master	AS csm; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ConditionSpecVO> list = Helper.DataReaderMapToList<ConditionSpecVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
    }
}
