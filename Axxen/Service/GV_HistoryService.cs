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
        /// 로딩
        /// </summary>
        public bool UpdateLoad(string username, string gvcode, int qty, string wccode, string workorderno)
        {
            GV_HistoryDAC dac = new GV_HistoryDAC();
            return dac.UpdateLoad(username, gvcode, qty, wccode, workorderno);
        }
        /// <summary>
        /// 언로딩
        /// </summary>
        public bool UpdateUnload(string workorderno, string username, string gvcode, string targetgvcode, string wccode, int qty)
        {
            GV_HistoryDAC dac = new GV_HistoryDAC();
            return dac.UpdateUnload(workorderno, username, gvcode, targetgvcode, wccode, qty);
        }
        /// <summary>
        /// 대차비우기
        /// </summary>
        public bool UpdateClearGV(GVClearVO item)
        {
            GV_HistoryDAC dac = new GV_HistoryDAC();
            return dac.UpdateClearGV(item);
        }
        /// <summary>
        /// 옮겨타기
        /// </summary>
        /// <param name="unloadgvcode"></param>
        /// <param name="loadgvcode"></param>
        /// <param name="unloadqty"></param>
        /// <param name="userid"></param>
        /// <param name="wccode"></param>
        /// <param name="workorderno"></param>
        /// <returns></returns>
        public bool UpdateMoveGvItem(string unloadgvcode, string loadgvcode, int unloadqty, string userid, string wccode, string workorderno)
        {
            GV_HistoryDAC dac = new GV_HistoryDAC();
            return dac.UpdateMoveGvItem( unloadgvcode,  loadgvcode,  unloadqty,  userid,  wccode,  workorderno);
        }
    }
}
