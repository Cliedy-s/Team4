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

        public bool UpdateWoReq(string woNo)
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.UpdateWoReq(woNo);
        }

        public List<WorkOrder_J_WC_ItmeVO> GetWorkOrder()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetWorkOrder();
        }

        public List<WO_WC_Production_ItemVO> GetWO_WC_Production_Items()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetWO_WC_Production_Items();
        }
    }
}
