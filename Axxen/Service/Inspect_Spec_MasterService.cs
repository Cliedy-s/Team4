using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    class Inspect_Spec_MasterService
    {
        /// <summary>
        /// 검사항목규격설정 가져오기
        /// </summary>
        /// <returns></returns>
        public List<InspectSpecVO> GetAll()
        {
            Inspect_Spec_MasterDAC dac = new Inspect_Spec_MasterDAC();
            return dac.GetAll();
        }
    }
}
