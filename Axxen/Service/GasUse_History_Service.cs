using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class GasUse_History_Service
    { 
        public List<GasUse_HistoryVO> GetAllGasUse_History() //PRM_PRF_004 전체 컬럼 가지고오기
        {
            GasUse_HistoryDAC dac = new GasUse_HistoryDAC();

            return dac.GetAllGasUse_History();
        }

        public List<GasUse_HistoryVO> GetDatePicker_GasUse_History(string Adatetimepicker1 , string Adatetimepicker2) //PRM_PRF_004 전체 컬럼 가지고오기
        {
            GasUse_HistoryDAC dac = new GasUse_HistoryDAC();

            return dac.GetDatePicker_GasUse_History(Adatetimepicker1, Adatetimepicker2);
        }
    }
}
