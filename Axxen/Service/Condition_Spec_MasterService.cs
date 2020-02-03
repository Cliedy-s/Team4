using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Condition_Spec_MasterService
    {
        Condition_Spec_MasterDAC dac;
        public Condition_Spec_MasterService()
        {
            dac = new Condition_Spec_MasterDAC();
        }

        /// <summary>
        /// 공정조건 측정항목 가져오기
        /// </summary>
        /// <returns></returns>
        public List<ConditionSpecVO> GetAll()
        {

            return dac.GetAll();
        }

        public bool InsertConditionSpec(List<ConditionSpecVO> condition)
        {
            return dac.InsertConditionSpec(condition);
        }
    }
}
