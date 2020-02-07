using DAC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class InspectMeasure_History_MasterService
    {
        public List<InspectMeasure_History_MasterVO> GetMainInspectMeasure_History_Master() // QAM_SQC_002 메인그리드뷰 조회
        {
            InspectMeasure_History_MasterDAC dac = new InspectMeasure_History_MasterDAC();
            return dac.GetMainInspectMeasure_History_Master();
        }

        public List<InspectMeasure_History_MasterVO> PickerMainInspectMeasure_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2) // QAM_SQC_002 날짜별 조회
        {
            InspectMeasure_History_MasterDAC dac = new InspectMeasure_History_MasterDAC();
            return dac.PickerMainInspectMeasure_History_Master(ADateTimePickerValue1, ADateTimePickerValue2);
        }

        public List<InspectMeasure_History_MasterVO> GetSubInspectMeasure_History_Master(string Workorderno, string Process_code, string Item_Code, string Inspect_code) // QAM_SQC_002 서브그리드뷰 조회
        {
            InspectMeasure_History_MasterDAC dac = new InspectMeasure_History_MasterDAC();
            return dac.GetSubInspectMeasure_History_Master(Workorderno, Process_code, Item_Code, Inspect_code);
        }

        public DataTable GetSubSubInspectMeasure_History_Master(string Workorderno, string Process_code, string Item_Code, string Inspect_code) // QAM_SQC_002 서브서브그리드뷰 조회
        {
            InspectMeasure_History_MasterDAC dac = new InspectMeasure_History_MasterDAC();
            return dac.GetSubSubInspectMeasure_History_Master(Workorderno, Process_code, Item_Code, Inspect_code);
        }

        public List<InspectMeasure_History_MasterVO> GetAllInspectMeasure_History_Master() // QAM_SQC_004 전체 조회
        {
            InspectMeasure_History_MasterDAC dac = new InspectMeasure_History_MasterDAC();
            return dac.GetAllInspectMeasure_History_Master();
        }

        public List<InspectMeasure_History_MasterVO> PickerInspectMeasure_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2) // QAM_SQC_004 날짜 조회
        {
            InspectMeasure_History_MasterDAC dac = new InspectMeasure_History_MasterDAC();
            return dac.PickerInspectMeasure_History_Master(ADateTimePickerValue1, ADateTimePickerValue2);
        }


    }
}
