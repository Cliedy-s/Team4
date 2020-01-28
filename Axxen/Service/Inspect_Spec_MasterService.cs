using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
   public class Inspect_Spec_MasterService
    {
        Inspect_Spec_MasterDAC dac;
        public Inspect_Spec_MasterService()
        {
             dac = new Inspect_Spec_MasterDAC();
        }

        /// <summary>
        /// 검사항목규격설정 가져오기
        /// </summary>
        /// <returns></returns>
        public List<InspectSpecVO> GetAll()
        {
          
            return dac.GetAll();
        }

        public bool InsertInspectSpec(InspectSpecVO inspctspec)
        {
            return dac.InsertInspectSpec(inspctspec);
        }
        }
}
