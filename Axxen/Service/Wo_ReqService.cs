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
        public List<Wo_Req_ItemVO> GetAllWoReq() //POP_PRD_002
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetAllWoReq();
        }

        /// <summary>
        /// 생산의뢰마감
        /// </summary>
        /// <param name="woNo"></param>
        /// <returns></returns>
        public bool UpdateWoReq(string woNo)
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.UpdateWoReq(woNo);
        }

        public List<WorkOrder_WC_ItemVO> GetWorkOrder()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetWorkOrder();
        }

        public List<WorkOrderVO> GetWoStatus()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetWoStatus();
        }

        public List<Wo_Req_WO_WC_ItemVO> GetWoReqOrder()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetWoReqOrder();
        }

        /// <summary>
        /// 작업지시마감
        /// </summary>
        /// <param name="wono"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool UpdateWoReqOrder(string wono, string code, string woreqno)
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.UpdateWoReqOrder(wono, code ,woreqno);
        }

        public bool CancleWoReqOrder(string wono)
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.CancleWoReqOrder(wono);
        }

        public List<WO_WC_Production_ItemVO> GetWO_WC_Production_Items()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetWO_WC_Production_Items();
        }

        /// <summary>
        /// 작업장조회
        /// </summary>
        /// <returns></returns>
        public List<WorkOrder_J_WC_ItmeVO> GetWorkCenterName()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetWorkCenterName();
        }
        
        //POP
        /// <summary>
        /// 생산의뢰목록 가져오기
        /// </summary>
        /// <returns></returns>
        public List<Wo_Req_ItemUnitVO> GetAllWoReqUnit()
        {
            Wo_ReqDAC dac = new Wo_ReqDAC();
            return dac.GetAllWoReqUnit();
        }


    }
}
