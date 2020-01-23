using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    class Condition_Spec_MasterService
    {
        /// <summary>
        /// 공정조건 측정항목 가져오기
        /// </summary>
        /// <returns></returns>
        public List<ConditionSpecVO> GetAll()
        {
            Condition_Spec_MasterDAC dac = new Condition_Spec_MasterDAC();
            return dac.GetAll();
        }
    }
}
