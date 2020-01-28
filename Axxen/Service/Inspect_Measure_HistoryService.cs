﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAC;
using VO;

namespace Service
{
    class Inspect_Measure_HistoryService
    {
        /// <summary>
        /// Inspect_Measure_History 목록 가져오기
        /// </summary>
        public List<InspectHistoryVO> GetAll()
        {
            Inspect_Measure_HistoryDAC dac = new Inspect_Measure_HistoryDAC();
            return dac.GetAll();
        }
        /// <summary>
        /// 품질측정값 등록
        /// </summary>
        /// <param name="item">Inspect_measure_seq를 제외하고 채워야함</param>
        public bool InsertInspect_Measure(InspectHistoryVO item)
        {
            Inspect_Measure_HistoryDAC dac = new Inspect_Measure_HistoryDAC();
            return dac.InsertInspect_Measure(item);
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
    }
}