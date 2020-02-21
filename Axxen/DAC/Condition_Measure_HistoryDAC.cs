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
    public class Condition_Measure_HistoryDAC :DACParent
    {
        /// <summary>
        /// 공정조건 측정그룹
        /// </summary>
        /// <returns></returns>
        public List<ConditionMeasureVO> GetAll(string conditioncode, string wccode, string itemcode, string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"SELECT 
	cmh.Condition_measure_seq
	, cmh.Item_code
	, cmh.Wc_Code
	, cmh.Condition_Code
	, cmh.Condition_Date
	, cmh.Condition_Datetime
	, cmh.Condition_Val
	, cmh.Workorderno
    , csm.Condition_Name
	FROM Condition_Measure_History AS cmh
       JOIN Condition_Spec_Master AS csm ON csm.Condition_Code = cmh.Condition_Code AND csm.Wc_Code =cmh.Wc_Code AND csm.Item_code = cmh.Item_code
	WHERE cmh.Condition_Code = @Condition_Code AND cmh.Wc_Code = @Wc_Code AND cmh.Item_Code = @Item_Code and cmh.Workorderno = @workorderno ; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Condition_Code", conditioncode);
                comm.Parameters.AddWithValue("@Wc_Code", wccode);
                comm.Parameters.AddWithValue("@Item_Code", itemcode);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<ConditionMeasureVO> list = Helper.DataReaderMapToList<ConditionMeasureVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 입력
        /// </summary>
        /// <param name="item">itemcode, wccode, conditioncode, conditionval, workorderno</param>
        /// <returns></returns>
        public bool InsertConditionMeasure(ConditionMeasureVO item, string editor)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" INSERT INTO Condition_Measure_History (
		Item_code
		,Wc_Code
		,Condition_Code
		,Condition_Date
		,Condition_Datetime
		,Condition_Val
		,Workorderno
		,Ins_Date
		,Ins_Emp
		,Up_Date
		,Up_Emp
	)
	VALUES (
		@Item_code
		,@Wc_Code
		,@Condition_Code
		,getdate()
		,getdate()
		,@Condition_Val
		,@Workorderno
		,getdate()
		,@username
		,getdate()
		,@username
	);  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Item_code", item.Item_code);
                comm.Parameters.AddWithValue("@Wc_Code", item.Wc_Code);
                comm.Parameters.AddWithValue("@Condition_Code", item.Condition_Code);
                comm.Parameters.AddWithValue("@Condition_Val", item.Condition_Val);
                comm.Parameters.AddWithValue("@Workorderno", item.Workorderno);
                comm.Parameters.AddWithValue("@username", editor);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        ///  삭제
        /// </summary>
        /// <param name="item">itemcode, wccode, conditioncode, conditionval, workorderno</param>
        /// <returns></returns>
        public bool DeleteConditionMeasure(int measureSeq)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" DELETE FROM Condition_Measure_History
 WHERE Condition_measure_seq = @Condition_measure_seq;  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Condition_measure_seq", measureSeq);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }

    }
}
