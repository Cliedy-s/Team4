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

        public bool UPDATE_Grade_Detail_Name(string Workorderno,string Pallet_No, string Grade_Detail_Name) //PRM_PRF_002_1 생산수량 업데이트
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UPDATE_Grade_Detail_Name(Workorderno, Pallet_No, Grade_Detail_Name);
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

        public List<WO_WC_Time_ItemVO> GetTimeWork(string wono) //PPS_SCH_003 chart
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetTimeWork(wono);
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
        public bool UpdateWorkOrderClose(string username, string workorderno)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateWorkOrderClose( username,  workorderno);
        }
        /// <summary>
        /// 옮겨타기
        /// </summary>
        /// <param name="workorderno"></param>
        /// <param name="qty"></param>
        /// <returns></returns>
        public bool UpdateTransferQty(string togvcode, string fromgvcode, int qty, string workorderno, string wccode, string username)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.UpdateTransferQty(togvcode, fromgvcode, qty, workorderno, wccode, username);
        }
        /// <summary>
        /// 로딩
        /// </summary>
        /// <param name="togvcode"></param>
        /// <param name="fromgvcode"></param>
        /// <param name="qty"></param>
        /// <param name="workorderno"></param>
        /// <param name="wccode"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool InsertLoadQty(string togvcode, int qty, string workorderno, string wccode, string username)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.InsertLoadQty(togvcode, qty, workorderno, wccode, username);
        }

    }
}
