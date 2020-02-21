using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAC;
using VO;

namespace Service
{
    public class Inspect_Measure_HistoryService
    {
        /// <summary>
        /// Inspect_Measure_History 목록 가져오기
        /// </summary>
        public List<InspectHistoryVO> GetAll(string itemcode, string processcode, string inspectcode, string workorderno)
        {
            Inspect_Measure_HistoryDAC dac = new Inspect_Measure_HistoryDAC();
            return dac.GetAll(itemcode, processcode, inspectcode, workorderno);
        }
        /// <summary>
        /// 품질측정값 등록
        /// </summary>
        /// <param name="item">Inspect_measure_seq를 제외하고 채워야함</param>
        public bool InsertInspect_Measure(InspectHistoryVO item, string userid)
        {
            Inspect_Measure_HistoryDAC dac = new Inspect_Measure_HistoryDAC();
            return dac.InsertInspect_Measure(item, userid);
        }
        /// <summary>
        /// 품질측정값 삭제
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public bool DeleteInspect_MeasureBySeq(int seq)
        {
            Inspect_Measure_HistoryDAC dac = new Inspect_Measure_HistoryDAC();
            return dac.DeleteInspect_MeasureBySeq(seq);
        }

        /// <summary>
        /// PRM_RPT_002 성형작업일지
        /// </summary>
        /// <param name="workno"></param>
        /// <returns></returns>
        public List<InspectMeasureHistoryVO> GetFiguration(List<string> workno)
        {
            Inspect_Measure_HistoryDAC dac = new Inspect_Measure_HistoryDAC();
            return dac.GetFiguration(workno);
        }

        /// <summary>
        /// PRM_RPT_001 건조작업일지
        /// </summary>
        /// <param name="workno"></param>
        /// <returns></returns>
        public List<InspectMeasureHistoryVO> GetDrying(List<string> workno)
        {
            Inspect_Measure_HistoryDAC dac = new Inspect_Measure_HistoryDAC();
            return dac.GetDrying(workno);
        }
    }
}
