using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Nop_Mi_MasterService
    {
        /// <summary>
        /// 비가동 소분류 목록
        /// </summary>
        public List<NopMiMasterVO> GetAllNopMi()
        {
            Nop_Mi_MasterDAC dac = new Nop_Mi_MasterDAC();
            return dac.GetAllNopMi();
        }

        public List<NopMiMasterVO> GetCombo() // PRM_PRF_008_1
        {
            Nop_Mi_MasterDAC dac = new Nop_Mi_MasterDAC();
            return dac.GetCombo();
        }
        
    }
}
