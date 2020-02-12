using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class WorkOrder_Service
    {
        public List<WorkOrder_J_WC_ItmeVO> GetAll_WorkOrder_Item_WC() //PRM_PRF_001 전체 컬럼 가지고오기
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetAll_WorkOrder_Item_WC();
        }
        public List<WorkOrder_J_WC_ItmeVO> GetDatePicker_WorkOrder_Item_WC(string ADateTimePickerValue1, string ADateTimePickerValue2) //PRM_PRF_001 DateTimePicker 날짜별 조회
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetDatePicker_WorkOrder_Item_WC(ADateTimePickerValue1, ADateTimePickerValue2);
        }
        public List<Goods_In_History_J_Pallet_BoxingVO> GetGoodsIH_PalletM_Boxing(string Workorderno) //서브 그리드뷰 불러오기
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetGoodsIH_PalletM_Boxing(Workorderno);
        }

        public bool UPDATE_Prd_Qty(string Prd_Qty, string Num, string Wo_Status, string Workorderno, string Item_Code) //PRM_PRF_001_1 생산수량 업데이트
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UPDATE_Prd_Qty(Prd_Qty, Num, Wo_Status, Workorderno, Item_Code);
        }

        public bool UPDATE_Grade_Detail_Name(string Grade_Detail_Name, string Grade_Detail_Code) //PRM_PRF_002_1 등급상세명 업데이트
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UPDATE_Grade_Detail_Name(Grade_Detail_Name, Grade_Detail_Code);
        }

        public bool UpdatePalletUse(List<string> chkPalletNo) //PRM_PRF_002 팔렛트 마감 업데이트
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdatePalletUse(chkPalletNo);
        }

        public string UpdateWo_Status(List<WorkOrder_J_WC_ItmeVO> list) //PRM_PRF_002 작업지시 마감 업데이트
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateWo_Status(list);
        }

        /// <summary>
        /// PPS_SCH_003 시간대별 실적조회
        /// </summary>
        /// <param name="wono">조회하고싶은작업지시번호</param>
        /// <returns></returns>
        public List<WO_WC_Time_ItemVO> GetTimeWork(string wono) 
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetTimeWork(wono);
        }

        /// <summary>
        /// PPS_SCH_001 작업지시생성하기
        /// </summary>
        /// <param name="order">작업지시입력정보VO</param>
        /// <returns></returns>
        public bool InsertPPSWorkorder(WorkOrderAllVO order,string user)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.InsertPPSWorkorder(order,user);
        }

        /// <summary>
        /// PPS_SCH_001 생산의뢰삭제
        /// </summary>
        /// <param name="woreqno"></param>
        /// <returns></returns>
        public bool DeletePPSWoReq(string woreqno)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.DeletePPSWoReq(woreqno);
        }

        /// <summary>
        /// PPS_SCH_001 작업지시삭제
        /// </summary>
        /// <param name="workno"></param>
        /// <returns></returns>
        public bool DeletePPSWorkorder(string workno)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.DeletePPSWorkorder(workno);
        }

        /// <summary>
        /// PPS_SCH_002 작업지시계획변경
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool UpdatePPSWorkorder(WorkOrderAllVO order)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdatePPSWorkorder(order);
        }

        //pop
        /// <summary>
        /// 작업장으로 작업지시현황 가져오기
        /// </summary>
        /// <param name="woinichar"></param>
        /// <returns></returns>
        public List<WorkOrderVO> GetAllWorkOrder_AlloHisDetail_Item_Wc(string woinichar)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetAllWorkOrder_AlloHisDetail_Item_Wc(woinichar);
        }
        /// <summary>
        /// 작업지시등록
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool InsertWorkOrder(WorkOrderNewVO item)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.InsertWorkOrder(item);
        }
        /// <summary>
        /// 작업지시 시작
        /// </summary>
        /// <returns></returns>
        public bool UpdateWorkOrderStart(string workorderno, string prdunit, string username)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateWorkOrderStart(workorderno, prdunit, username);
        }
        /// <summary>
        /// 작업지시 종료
        /// </summary>
        /// <returns></returns>
        public bool UpdateWorkOrderEnd(string workorderno, int outqty, int prdqty, string username)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateWorkOrderEnd(workorderno, outqty, prdqty, username);
        }
        /// <summary>
        /// 작업지시 마감
        /// </summary>
        /// <returns></returns>
        public bool UpdateWorkOrderClose(string username, string workorderno, bool isBoxing)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateWorkOrderClose( username,  workorderno, isBoxing);
        }

    }
}
