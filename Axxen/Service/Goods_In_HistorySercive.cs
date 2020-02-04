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
        public List<Goods_In_HistoryVO> GetBoxingHistory()
        {
            Goods_In_HistoryDAC dac = new Goods_In_HistoryDAC();
            return dac.GetBoxingHistory();
        }
    }
}
