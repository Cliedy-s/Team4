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
        }  /// <summary>
           /// 비가동 소분류 목록
           /// </summary>
        public List<NopMiMasterVO> GetAllNopMi2()
        {
            Nop_Mi_MasterDAC dac = new Nop_Mi_MasterDAC();
            return dac.GetAllNopMi2();
        }
        public bool InsertUpdateNop_Mi_Masterservice(NopMiMasterVO item)
        {
            Nop_Mi_MasterDAC dac = new Nop_Mi_MasterDAC();
            return dac.InsertUpdateNop_Mi_Masterservice(item);
        }

            /// <summary>
            /// 비가동 소분류 사용 유무 
            /// </summary>
            public bool UsedNop_Mi_Masterservice(string code, string use)
        {
            Nop_Mi_MasterDAC dac = new Nop_Mi_MasterDAC();
            return dac.UsedNop_Mi_Masterservice(code, use);
        }

            public List<NopMiMasterVO> GetCombo() // PRM_PRF_008_1
        {
            Nop_Mi_MasterDAC dac = new Nop_Mi_MasterDAC();
            return dac.GetCombo();
        }
        
    }
}
