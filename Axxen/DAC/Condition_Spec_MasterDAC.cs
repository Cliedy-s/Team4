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
    public class Condition_Spec_MasterDAC : DACParent
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
        /// <summary>
        /// 공정조건insert
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public bool InsertConditionSpec(ConditionSpecVO condition)
        {        
                try
                {
                    using (SqlCommand com = new SqlCommand())
                    {
                        com.Connection = new SqlConnection(Connstr);
                        com.CommandText = "InsertConditionSpec";
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@Item_Code", condition.Item_Code);
                        com.Parameters.AddWithValue("@Wc_Code", condition.Wc_Code);
                        com.Parameters.AddWithValue("@Condition_Code", condition.Condition_Code);
                        com.Parameters.AddWithValue("@Condition_Name", condition.Condition_Name);
                        com.Parameters.AddWithValue("@USL", condition.USL);
                        com.Parameters.AddWithValue("@SL", condition.SL);
                        com.Parameters.AddWithValue("@LSL", condition.LSL);                 
                        com.Parameters.AddWithValue("@Condition_Unit", condition.Condition_Unit);
                        com.Parameters.AddWithValue("@Remark", condition.Remark);

                        com.Connection.Open();
                        int resault = Convert.ToInt32(com.ExecuteNonQuery());
                        com.Connection.Close();
                    if (resault > 0)
                        return true;
                    else
                        return false;
                }

                }
                catch (Exception)
                {
                  
                    throw;
                
            }
        }
    }
}
