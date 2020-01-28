using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    class Nop_HistoryService
    {
        /// <summary>
        /// 비가동 목록
        /// </summary>
        public List<NopHistoryVO> GetAllNop_History()
        {
            Nop_HistoryDAC dac = new Nop_HistoryDAC();
            return dac.GetAllNop_History();
        }
        /// <summary>
        /// 비가동 사유변경
        /// </summary>
        /// <param name="nopMiCode"></param>
        /// <param name="username"></param>
        /// <param name="nopseq"></param>
        /// <returns></returns>
        public bool UpdateNop_History(string nopMiCode, string username, int nopseq)
        {
            Nop_HistoryDAC dac = new Nop_HistoryDAC();
            return dac.UpdateNop_History(nopMiCode, username, nopseq);
        }
    }
}
