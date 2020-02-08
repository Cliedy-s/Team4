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
        public bool InsertConditionSpec(List<ConditionSpecVO> condition)
        {

            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("InsertConditionSpec", conn))
                {       
                    cmd.Transaction = tran;
                    try
                    {
                        for (int i = 0; i < condition.Count; i++)
                        {                                           
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Item_Code", condition[i].Item_Code);
                            cmd.Parameters.AddWithValue("@Wc_Code", condition[i].Wc_Code);
                            cmd.Parameters.AddWithValue("@Condition_Code", condition[i].Condition_Code);
                            cmd.Parameters.AddWithValue("@Condition_Name", condition[i].Condition_Name);
                            cmd.Parameters.AddWithValue("@USL", condition[i].USL);
                            cmd.Parameters.AddWithValue("@SL", condition[i].SL);
                            cmd.Parameters.AddWithValue("@LSL", condition[i].LSL);
                            cmd.Parameters.AddWithValue("@Condition_Unit", condition[i].Condition_Unit);
                            cmd.Parameters.AddWithValue("@Remark", condition[i].Remark);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                                      
                        tran.Commit();
                        conn.Close();
                        return true;
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        return false;
                    }
                }     
            }
        }
        /// <summary>
        /// 공정조건 설정
        /// </summary>
        /// <param name="Item_Code"></param>
        /// <param name="Wc_Code"></param>
        /// <param name="Condition_Code"></param>
        /// <returns></returns>
        public bool DeleteConditionSpecVO(string Item_Code, string Wc_Code, string Condition_Code)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "delete from Condition_Spec_Master where Item_Code=@Item_Code and Wc_Code=@Wc_Code and Condition_Code=@Condition_Code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Item_Code", Item_Code);
                comm.Parameters.AddWithValue("@Wc_Code", Wc_Code);
                comm.Parameters.AddWithValue("@Condition_Code", Condition_Code);
                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
            
                comm.Connection.Close();

                if (result > 0)
                    return true;
                else
                    return false;
             
            }
        }
        }
}
