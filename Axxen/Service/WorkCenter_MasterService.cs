using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using DAC;

namespace Service
{
    public class WorkCenter_MasterService
    {
        /// <summary>
        /// 모든 작업장정보를 가져오는 메소드
        /// </summary>
        /// <returns></returns>
        public List<WorkCenter_MasterVO> GetAll()
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.GetAll();
        }

        public List<WorkCenter_MasterVO> GetCombo1() //PRM_PRF_008_1 작업장명만 가지고오는쿼리
        {
            WorkCenter_MasterDAC dac = new WorkCenter_MasterDAC();
            return dac.GetCombo1();
        }
    }
}
