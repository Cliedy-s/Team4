using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    class Condition_Measure_HistoryService
    {
        /// <summary>
        /// 공정조건 측정그룹
        /// </summary>
        /// <returns></returns>
        public List<ConditionMeasureVO> GetAll(string conditioncode)
        {
            Condition_Measure_HistoryDAC dac = new Condition_Measure_HistoryDAC();
            return dac.GetAll(conditioncode);
        }
        /// <summary>
        /// 입력
        /// </summary>
        /// <param name="item">itemcode, wccode, conditioncode, conditionval, workorderno</param>
        /// <returns></returns>
        public bool InsertConditionMeasure(ConditionMeasureVO item, string editor)
        {
            Condition_Measure_HistoryDAC dac = new Condition_Measure_HistoryDAC();
            return dac.InsertConditionMeasure(item, editor);
        }
        /// <summary>
        ///  삭제
        /// </summary>
        /// <param name="item">itemcode, wccode, conditioncode, conditionval, workorderno</param>
        /// <returns></returns>
        public bool DeleteConditionMeasure(int measureSeq)
        {
            Condition_Measure_HistoryDAC dac = new Condition_Measure_HistoryDAC();
            return dac.DeleteConditionMeasure(measureSeq);
        }
    }
}
