﻿using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Goods_In_HistorySercive
    {
        /// <summary>
        /// PRM_RPT_004 포장작업일지
        /// </summary>
        /// <returns></returns>
        public List<Goods_In_HistoryVO> GetBoxingHistory()
        {
            Goods_In_HistoryDAC dac = new Goods_In_HistoryDAC();
            return dac.GetBoxingHistory();
        }

        /// <summary>
        /// PRM_RPT_002 성형작업일지
        /// </summary>
        /// <returns></returns>
        public List<Goods_In_HistoryVO> GetFigurationHistory()
        {
            Goods_In_HistoryDAC dac = new Goods_In_HistoryDAC();
            return dac.GetFigurationHistory();
        }
    }
}