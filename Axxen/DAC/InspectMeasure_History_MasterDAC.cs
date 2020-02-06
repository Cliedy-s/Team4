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
    public class InspectMeasure_History_MasterDAC : DACParent
    {      
            public List<InspectMeasure_History_MasterVO> GetAllInspectMeasure_History_Master()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select imh.Workorderno,Prd_Date , Process_name , Wc_Name , imh.Item_Code , Item_Name ,Inspect_name, USL , SL , LSL , Inspect_datetime ,Inspect_date , Inspect_measure_seq , Inspect_val
                                 from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								 INNER JOIN WorkOrder wo ON imh.Workorderno = wo.Workorderno
								 INNER JOIN Item_Master im ON imh.Item_Code = im.Item_Code
								 INNER JOIN Inspect_Spec_Master ism ON imh.Inspect_code = ism.Inspect_code
								 INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectMeasure_History_MasterVO> list = Helper.DataReaderMapToList<InspectMeasure_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<InspectMeasure_History_MasterVO> PickerInspectMeasure_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select imh.Workorderno,Prd_Date , Process_name , Wc_Name , imh.Item_Code , Item_Name ,Inspect_name, USL , SL , LSL , Inspect_datetime ,Inspect_date , Inspect_measure_seq , Inspect_val
                                 from Inspect_Measure_History imh INNER JOIN Process_Master pm ON imh.Process_code = pm.Process_code
								 INNER JOIN WorkOrder wo ON imh.Workorderno = wo.Workorderno
								 INNER JOIN Item_Master im ON imh.Item_Code = im.Item_Code
								 INNER JOIN Inspect_Spec_Master ism ON imh.Inspect_code = ism.Inspect_code
								 INNER JOIN WorkCenter_Master wcm ON wo.Wc_Code = wcm.Wc_Code
								 where Prd_Date BETWEEN @ADateTimePickerValue1 AND @ADateTimePickerValue2
								 Order by Prd_Date Desc";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ADateTimePickerValue1", ADateTimePickerValue1);
                comm.Parameters.AddWithValue("@ADateTimePickerValue2", ADateTimePickerValue2);
                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<InspectMeasure_History_MasterVO> list = Helper.DataReaderMapToList<InspectMeasure_History_MasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        
    }
}
