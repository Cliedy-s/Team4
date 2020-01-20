using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Wo_ReqService
    {
        public List<Wo_Req_ItemVO> GetAllWoReq()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetAllWoReq();
        }
    }
}
