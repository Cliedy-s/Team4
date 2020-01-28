﻿using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    class GV_MasterService
    {
        /// <summary>
        /// 대차리스트 작업장별로 가져오기
        /// </summary>
        public List<GVWorkItemVO> GetAllByWC(string wccode, string woinichar)
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetAllByWC(wccode, woinichar);
        } // TODO : 프로시저로 빼기
        /// <summary>
        /// 대차리스트 대차그룹, 대차상태 따라 가져오기
        /// </summary>
        /// <param name="gvgroup"></param>
        /// <param name="gvstatus"></param>
        /// <returns></returns>
        public List<GVVO> GetAllByGV(string gvgroup, string gvstatus)
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetAllByGV(gvgroup, gvstatus);
        }
        /// <summary>
        /// 적재시간을 포함한 대차리스트
        /// </summary>
        /// <returns></returns>
        public List<GVLoadingTimeVO> GetAllWithLoadingTime(string gvgroup, string workorderno)
        {
            GV_MasterDAC dac = new GV_MasterDAC();
            return dac.GetAllWithLoadingTime(gvgroup, workorderno);
        }
    }
}