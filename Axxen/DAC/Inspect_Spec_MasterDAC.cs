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
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = "SELECT ism.Item_Code, ism.Process_code, ism.Inspect_code, ism.Inspect_name," +
                    " ism.Spec_Desc, ism.USL, ism.SL, ism.LSL, ism.Sample_size, ism.Inspect_Unit, ism.Use_YN," +
                    " ism.Remark FROM Inspect_Spec_Master AS ism ; ";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<InspectSpecVO> list = Helper.DataReaderMapToList<InspectSpecVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<InspectSpecVO> GetAll(string itemcode, string wccode)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText =
                @"
SELECT ism.Item_Code, ism.Process_code, ism.Inspect_code, ism.Inspect_name, 
                     ism.Spec_Desc, ism.USL, ism.SL, ism.LSL, ism.Sample_size, ism.Inspect_Unit, ism.Use_YN, 
                     ism.Remark 
					 FROM Inspect_Spec_Master AS ism
					 JOIN (SELECT * FROM WorkCenter_Master WHERE Wc_Code = @wccode) AS wcm ON wcm.Process_Code = ism.Process_code AND wcm.Use_YN = 'Y'
					 WHERE ism.Use_YN = 'Y' AND ism.Item_Code = @itemcode ; 
";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@wccode", wccode);
                cmd.Parameters.AddWithValue("@itemcode", itemcode);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<InspectSpecVO> list = Helper.DataReaderMapToList<InspectSpecVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 작업장 별로 검색
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public List<InspectSpecVO> GetAllByWcCode(string wccode, string itemcode)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText =
                    @"
SELECT ism.Item_Code, ism.Process_code, ism.Inspect_code, ism.Inspect_name, 
                     ism.Spec_Desc, ism.USL, ism.SL, ism.LSL, ism.Sample_size, ism.Inspect_Unit, ism.Use_YN, 
                     ism.Remark 
FROM Inspect_Spec_Master AS ism 
	JOIN WorkCenter_Master AS WCM ON WCM.Process_Code = ism.Process_code
WHERE WCM.Wc_Code = @wccode AND ism.Item_Code = @itemcode ;
";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@wccode", wccode);
                cmd.Parameters.AddWithValue("@itemcode", itemcode);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<InspectSpecVO> list = Helper.DataReaderMapToList<InspectSpecVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 품목규격 설정 
        /// </summary>
        /// <param name="inspctspec"></param>
        public bool InsertInspectSpec(List<InspectSpecVO> inspctspec)
        {

            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                using (SqlCommand cmd = new SqlCommand("InsertInspectSpec", conn))
                {
                    cmd.Transaction = tran;
                   
                    try
                    {
                        foreach (var item in inspctspec)
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Item_Code", item.Item_Code);
                            cmd.Parameters.AddWithValue("@Process_code", item.Process_code);
                            cmd.Parameters.AddWithValue("@Inspect_code", item.Inspect_code);
                            cmd.Parameters.AddWithValue("@Inspect_name", item.Inspect_name);
                            cmd.Parameters.AddWithValue("@USL", item.USL);
                            cmd.Parameters.AddWithValue("@SL", item.SL);
                            cmd.Parameters.AddWithValue("@LSL", item.LSL);
                            cmd.Parameters.AddWithValue("@Sample_size", item.Sample_size);
                            cmd.Parameters.AddWithValue("@Inspect_Unit", item.Inspect_Unit);
                            cmd.Parameters.AddWithValue("@Remark", item.Remark);
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
                   
                        throw;
                    }

                }
            }
        }
        public bool DeleteInspectSpecVO(string Item_Code, string Process_code, string Inspect_code)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(Connstr);
                    cmd.CommandText = $"delete from Inspect_Spec_Master where Item_Code=@Item_Code and Process_code=@Process_code and Inspect_code=@Inspect_code";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection.Open();
                    cmd.Parameters.AddWithValue("@Item_Code", Item_Code);
                    cmd.Parameters.AddWithValue("@Process_code", Process_code);
                    cmd.Parameters.AddWithValue("@Inspect_code", Inspect_code);
                    int resualt = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    return resualt > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
            /// <summary>
            /// 검사항목규격설정 사용
            /// </summary>
            /// <returns></returns>
            public bool UseInspectSpec(InspectSpecVO inspect,string use)
        {
            try
            { 
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Connstr);
                cmd.CommandText = $"UPDATE Inspect_Spec_Master SET Use_YN ='{use}'  WHERE Item_Code =@Item_Code AND Process_code=@Process_code AND Inspect_code=@Inspect_code";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@Item_Code", inspect.Item_Code);
                cmd.Parameters.AddWithValue("@Process_code", inspect.Process_code);
                cmd.Parameters.AddWithValue("@Inspect_code", inspect.Inspect_code);
              int resualt= cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return resualt > 0;
            }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
