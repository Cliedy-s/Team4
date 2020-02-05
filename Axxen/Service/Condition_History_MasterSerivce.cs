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
