using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Item_Goods_HistoryVO //KPI_RPT_004 , PRM_PRF_003
    {
        public DateTime Prd_Date { get; set; } //생산일자 PRM_PRF_003
        public string Workorderno { get; set; } //작업지시번호 PRM_PRF_003
        public string Wo_Status { get; set; } //작업지시상태 PRM_PRF_003
        public string Item_Code { get; set; } //품목코드 KPI_RPT_004 , PRM_PRF_003
        public string Item_Name { get; set; } //품목명 KPI_RPT_004 ,  PRM_PRF_003
        public string Pallet_No { get; set; } //팔렛트번호 PRM_PRF_003
        public string Wc_Name { get; set; } //작업장 PRM_PRF_003
        public int Plan_Qty { get; set; } //입고수량 PRM_PRF_003
        public DateTime Closed_Time { get; set; } //마감시각 PRM_PRF_003
        public DateTime Cancel_Time { get; set; } //취소시각 PRM_PRF_003
        public string Upload_Flag { get; set; } //업로드여부 PRM_PRF_003
        public string In_Date { get; set; } //입고일자 KPI_RPT_004
        public string In_Qty { get; set; } //생산수량 KPI_RPT_004
    }
}
