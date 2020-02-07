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
    public class Condition_History_MasterDAC : DACParent
    {

        
            public List<Condition_History_MasterVO> GetMainCondition_History_Master() // 003 메인
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select cmh.Workorderno,Prd_Date ,pm.Process_code, Process_name,  Wc_Name , cmh.Item_Code , Item_Name ,cmh.Condition_Code
                                   from Condition_Measure_History cmh INNER JOIN Condition_Spec_Master csm ON cmh.Condition_Code = csm.Condition_Code
								   INNER JOIN WorkOrder wo ON cmh.Workorderno = wo.Workorderno
								   INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
							       INNER JOIN Process_Master pm ON wcm.Process_code = pm.Process_code
								   INNER JOIN Item_Master im ON cmh.Item_Code = im.Item_Code";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Condition_History_MasterVO> list = Helper.DataReaderMapToList<Condition_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<Condition_History_MasterVO> GetSubCondition_History_Master(string Workorderno, string Process_code, string Item_Code, string Inspect_code) //QAM 003 서브 그리드뷰
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select Condition_Name, SL 
                                   from Condition_Measure_History cmh INNER JOIN Condition_Spec_Master csm ON cmh.Condition_Code = csm.Condition_Code
								   INNER JOIN WorkOrder wo ON cmh.Workorderno = wo.Workorderno
								   INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
							       INNER JOIN Process_Master pm ON wcm.Process_code = pm.Process_code
								   INNER JOIN Item_Master im ON cmh.Item_Code = im.Item_Code
								   where cmh.Workorderno = @Workorderno AND cmh.Item_code = @Item_Code AND pm.Process_code=@Process_code AND cmh.Condition_Code=Condition_Code";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Workorderno", Workorderno);
                comm.Parameters.AddWithValue("@Process_code", Process_code);
                comm.Parameters.AddWithValue("@Item_Code", Item_Code);
                comm.Parameters.AddWithValue("@Inspect_code", Inspect_code);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Condition_History_MasterVO> list = Helper.DataReaderMapToList<Condition_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<Condition_History_MasterVO> PickerMainCondition_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2) //QAM 002 날짜별
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select cmh.Workorderno,Prd_Date ,pm.Process_code, Process_name,  Wc_Name , cmh.Item_Code , Item_Name ,cmh.Condition_Code
                                   from Condition_Measure_History cmh INNER JOIN Condition_Spec_Master csm ON cmh.Condition_Code = csm.Condition_Code
								   INNER JOIN WorkOrder wo ON cmh.Workorderno = wo.Workorderno
								   INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
							       INNER JOIN Process_Master pm ON wcm.Process_code = pm.Process_code
								   INNER JOIN Item_Master im ON cmh.Item_Code = im.Item_Code
								 where Prd_Date BETWEEN @ADateTimePickerValue1 AND @ADateTimePickerValue2
								 Order by Prd_Date Desc;";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ADateTimePickerValue1", ADateTimePickerValue1);
                comm.Parameters.AddWithValue("@ADateTimePickerValue2", ADateTimePickerValue2);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Condition_History_MasterVO> list = Helper.DataReaderMapToList<Condition_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<Condition_History_MasterVO> GetAllCondition_History_Master() // 005 메인
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select cmh.Workorderno,Prd_Date , Process_name,  Wc_Name , cmh.Item_Code , Item_Name ,Condition_Name, USL , SL , LSL , Condition_Datetime , Condition_Date , Condition_Val
                                   from Condition_Measure_History cmh INNER JOIN Condition_Spec_Master csm ON cmh.Condition_Code = csm.Condition_Code
								   INNER JOIN WorkOrder wo ON cmh.Workorderno = wo.Workorderno
								   INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
							       INNER JOIN Process_Master pm ON wcm.Process_code = pm.Process_code
								   INNER JOIN Item_Master im ON cmh.Item_Code = im.Item_Code";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Condition_History_MasterVO> list = Helper.DataReaderMapToList<Condition_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<Condition_History_MasterVO> PickerCondition_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2) //005 날짜
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select cmh.Workorderno,Prd_Date , Process_name,  Wc_Name , cmh.Item_Code , Item_Name ,Condition_Name, USL , SL , LSL , Condition_Datetime , Condition_Date , Condition_Val
                                   from Condition_Measure_History cmh INNER JOIN Condition_Spec_Master csm ON cmh.Condition_Code = csm.Condition_Code
								   INNER JOIN WorkOrder wo ON cmh.Workorderno = wo.Workorderno
								   INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
							       INNER JOIN Process_Master pm ON wcm.Process_code = pm.Process_code
								   INNER JOIN Item_Master im ON cmh.Item_Code = im.Item_Code
								   where Prd_Date BETWEEN @ADateTimePickerValue1 AND @ADateTimePickerValue2
								   Order by Prd_Date Desc";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ADateTimePickerValue1", ADateTimePickerValue1);
                comm.Parameters.AddWithValue("@ADateTimePickerValue2", ADateTimePickerValue2);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<Condition_History_MasterVO> list = Helper.DataReaderMapToList<Condition_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        
    }
}
