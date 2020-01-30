using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class GV_HistoryService
    {
        /// <summary>
        /// 언로딩
        /// </summary>
        public bool UpdateUnload(string username, string gvcode, string wccode, int qty)
        {
            GV_HistoryDAC dac = new GV_HistoryDAC();
            return dac.UpdateUnload(username, gvcode, wccode, qty);
        }
        /// <summary>
        /// 대차비우기
        /// </summary>
        public bool UpdateClearGV(GVClearVO item)
        {
            GV_HistoryDAC dac = new GV_HistoryDAC();
            return dac.UpdateClearGV(item);
        }
    }
}
