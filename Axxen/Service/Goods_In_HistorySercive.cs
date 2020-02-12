using DAC;
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
        public List<Goods_In_HistoryVO> GetBoxingHistory(string date)
        {
            Goods_In_HistoryDAC dac = new Goods_In_HistoryDAC();
            return dac.GetBoxingHistory(date);
        }

        /// <summary>
        /// PRM_RPT_002 성형작업일지
        /// </summary>
        /// <returns></returns>
        public List<Goods_In_HistoryVO> GetFigurationHistory(string date)
        {
            Goods_In_HistoryDAC dac = new Goods_In_HistoryDAC();
            return dac.GetFigurationHistory(date);
        }

        /// <summary>
        /// PRM_RPT_001 건조작업일지
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<Goods_In_HistoryVO> GetDryingHistory(string date)
        {
            Goods_In_HistoryDAC dac = new Goods_In_HistoryDAC();
            return dac.GetDryingHistory(date);
        }
    }
}
