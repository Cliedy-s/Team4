using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Condition_History_MasterSerivce
    {

        public List<Condition_History_MasterVO> GetMainCondition_History_Master() // QAM_SQC_003 메인그리드뷰조회
        {
            Condition_History_MasterDAC dac = new Condition_History_MasterDAC();
            return dac.GetMainCondition_History_Master();
        }

        public List<Condition_History_MasterVO> GetSubCondition_History_Master(string Workorderno, string Process_code, string Item_Code, string Inspect_code) // QAM_SQC_003 서브그리드뷰조회
        {
            Condition_History_MasterDAC dac = new Condition_History_MasterDAC();
            return dac.GetSubCondition_History_Master(Workorderno, Process_code, Item_Code, Inspect_code);
        }

        public List<Condition_History_MasterVO> PickerMainCondition_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2) // QAM_SQC_002 날짜별 조회
        {
            Condition_History_MasterDAC dac = new Condition_History_MasterDAC();
            return dac.PickerMainCondition_History_Master(ADateTimePickerValue1, ADateTimePickerValue2);
        }
        
        public List<Condition_History_MasterVO> GetAllCondition_History_Master() // QAM_SQC_005 전체 조회
        {
            Condition_History_MasterDAC dac = new Condition_History_MasterDAC();
            return dac.GetAllCondition_History_Master();
        }

        public List<Condition_History_MasterVO> PickerCondition_History_Master(string ADateTimePickerValue1, string ADateTimePickerValue2) // QAM_SQC_005 날짜 조회
        {
            Condition_History_MasterDAC dac = new Condition_History_MasterDAC();
            return dac.PickerCondition_History_Master(ADateTimePickerValue1, ADateTimePickerValue2);
        }
        
    }
}
