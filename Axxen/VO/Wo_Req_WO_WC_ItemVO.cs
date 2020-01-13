using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Wo_Req_WO_WC_ItemVO //SCH_002
    {
        public string Wo_Status { get; set; } //작업지시상태
        public string Workorderno { get; set; } //작업지시번호
        public DateTime Plan_Date { get; set; } //계획일자
        public int Plan_Qty { get; set; } //계획수량
        public string Plan_Unit { get; set; } //계획수량단위
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public string Wc_Name { get; set; } //작업장명
        public DateTime Prd_Date { get; set; } //생산일자
        public DateTime Prd_Starttime { get; set; } //작업시작시간
        public DateTime Prd_Endtime { get; set; } //작업종료시간
        public int In_Qty_Main { get; set; } //투입수량
        public int Out_Qty_Main { get; set; } //산출수량
        public int Prd_Qty { get; set; } //생산수량
        public string Wo_Req_No { get; set; } //생산의뢰번호
        public int Req_Req { get; set; } //생산의뢰순번
        public string Project_Name { get; set; } //프로젝트명
        
    }
}
