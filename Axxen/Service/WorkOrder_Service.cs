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
            return dac.GetDatePicker_WorkOrder_Item_WC(ADateTimePickerValue1,ADateTimePickerValue2);
        }

        public List<Goods_In_History_J_Pallet_BoxingVO> GetGoodsIH_PalletM_Boxing(string Workorderno)
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetGoodsIH_PalletM_Boxing(Workorderno);
        }
    }
}
