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
        /// <param name="woinichar"></param>
        /// <returns></returns>
        public List<GVStatusVO> GetGVCurrentStatus(string woinichar, string ProcessName)
        {
            GV_Current_StatusDAC dac = new GV_Current_StatusDAC();
            return dac.GetGVCurrentStatus(woinichar, ProcessName);
        }
        public List<GVStatusVO> GetGVCurrentStatus(string woinichar)
        {
            GV_Current_StatusDAC dac = new GV_Current_StatusDAC();
            return dac.GetGVCurrentStatus(woinichar);
        }
        /// <summary>
        /// 대차 현황 상태따라
        /// </summary>
        /// <param name="woinichar"></param>
        /// <param name="gvStatus"></param>
        /// <returns></returns>
        public List<GVStatusVO> GetGVCurrentStatusByGvStatus(string woinichar, string ProcessName, string gvStatus)
        {
            GV_Current_StatusDAC dac = new GV_Current_StatusDAC();
            return dac.GetGVCurrentStatusByGvStatus( woinichar, ProcessName,  gvStatus);
        }
        /// <summary>
        /// 대차 이름 검색
        /// </summary>
        /// <param name="GVName"></param>
        /// <returns></returns>
        public List<GVStatusVO> GetGVCurrentStatusByName(string woinichar, string ProcessName, string GVName)
        {
            GV_Current_StatusDAC dac = new GV_Current_StatusDAC();
            return dac.GetGVCurrentStatusByName(woinichar, ProcessName, GVName);
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
