using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class GV_Current_StatusService
    {
        /// <summary>
        /// 대차 현황 
        /// </summary>
        /// <param name="wccode"></param>
        /// <returns></returns>
        public List<GVStatusVO> GetGVCurrentStatus(string wccode = null, string ProcessName = null, string workorderno = null, string gvStatus = null, string gvName = null, string gvGroup = null)
        {
            GV_Current_StatusDAC dac = new GV_Current_StatusDAC();
            return dac.GetGVCurrentStatus( wccode ,  ProcessName ,  workorderno ,  gvStatus ,  gvName , gvGroup);
        }
        /// <summary>
        /// 요입현황
        /// </summary>
        /// <param name="woinichar"></param>
        /// <returns></returns>
        public List<GVInOutVO> GetGVCurrentInOut(string gvgroup, string wccode)
        { // 소성대차, 현재 작업장 코드
            GV_Current_StatusDAC dac = new GV_Current_StatusDAC();
            return dac.GetGVCurrentInOut(gvgroup, wccode);
        }
        /// <summary>
        /// 요입
        /// </summary>
        /// <param name="username"></param>
        /// <param name="gvcode"></param>
        /// <param name="workorderno"></param>
        /// <returns></returns>
        public bool UpdateGVIn(string username, string gvcode, string workorderno)
        {
            GV_Current_StatusDAC dac = new GV_Current_StatusDAC();
            return dac.UpdateGVIn(username, gvcode, workorderno);
        }
        /// <summary>
        /// 요출
        /// </summary>
        /// <param name="username"></param>
        /// <param name="gvcode"></param>
        /// <param name="workorderno"></param>
        /// <returns></returns>
        public bool UpdateGVOut(string username, string gvcode, string workorderno)
        {
            GV_Current_StatusDAC dac = new GV_Current_StatusDAC();
            return dac.UpdateGVOut(username, gvcode, workorderno);
        }
    }
}
