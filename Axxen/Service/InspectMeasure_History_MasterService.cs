using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class InspectMeasure_History_MasterService
    {
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
