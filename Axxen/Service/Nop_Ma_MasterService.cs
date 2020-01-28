using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    class Nop_Ma_MasterService
    {
        /// <summary>
        /// 비가동 대분류 목록
        /// </summary>
        public List<NopMaMasterVO> GetAllNopMi()
        {
            Nop_Ma_MasterDAC dac = new Nop_Ma_MasterDAC();
            return dac.GetAllNopMi();
        }
    }
}
