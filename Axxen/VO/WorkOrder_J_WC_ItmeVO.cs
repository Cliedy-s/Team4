using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WorkOrder_J_WC_ItmeVO//SCH_001_2 //PRM_PRF_001
    {
        public long Num { get; set; } //PRM_PRF_001 순번
        public string Workorderno { get; set; } //작업지시번호
        public int Plan_Qty { get; set; } //계획수량
        public DateTime Prd_Date { get; set; } //생산일자
        public string Wo_Status { get; set; } //작업지시상태
        public int In_Qty_Main { get; set; } //투입수량
        public int Out_Qty_Main { get; set; } //산출수량
        public int Prd_Qty { get; set; } //생산수량
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public string Wc_Code { get; set; } //작업장코드
        public string Wc_Name { get; set; } //작업장명
        public string Process_name { get; set; } //공정명     
        public string Remark { get; set; } //비고
        public string Wo_Req_No { get; set; } //생산의로번호  
        public int Req_Seq { get; set; } //의뢰순번
    }
}
