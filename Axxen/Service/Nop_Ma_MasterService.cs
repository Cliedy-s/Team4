using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Nop_Ma_MasterService
    {
        Nop_Ma_MasterDAC dac;
        public Nop_Ma_MasterService()
        {
            dac = new Nop_Ma_MasterDAC();
        }
        public List<NopMaMasterVO> GetAllNopMA()
        {
            return dac.GetAllNopMA();
        }
        public bool InsertUpdateNop_Ma_Master(NopMaMasterVO item)
        {
            return dac.InsertUpdateNop_Ma_Master(item);
        }
        public bool GetUseNopservice(string groupcode, string used)
        {
            return dac.GetUseNopservice(groupcode, used);
        }
   
            /// <summary>
            /// 비가동대분류 삭제
            /// </summary>
            /// <returns></returns>
            public bool DeleteNopMaMasterVO(string macode)
        {
            return dac.DeleteNopMaMasterVO(macode);
        }
        }
}
