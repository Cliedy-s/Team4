using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class GVStatusVO
    {
        public string GV_Code { get; set; }        // 대차번호
        public string GV_Name { get; set; }       // 대차명
        public string GV_Group { get; set; }       // 대차그룹
        public string GV_Status { get; set; }       // 대차상태
        public string Item_Code { get; set; }      // 품목코드
        public string Item_Name { get; set; }     // 품목명
        public int Box_Qty { get; set; }            // 팔렛당 박스수
        public int Pcs_Qty { get; set; }            // 박스당 pcs수
        public DateTime? Loading_time { get; set; }  // 적재시간
        public int Loading_Qty { get; set; }            // 적재수량
        public string Workorderno { get; set; }   // 작업지시번호
        public int Prd_Qty { get; set; }              // 생산수량
        public string Prd_Unit { get; set; }        // 생산수량단위
        public string Wo_Req_No { get; set; }   // 생산의뢰 번호
        public int Req_Seq { get; set; }         // 생산의뢰 순서
        public DateTime? Prd_Endtime { get; set; }  // 작업지시종료날짜
        public string Wc_Code { get; set; }        // 작업장코드
        public string Wo_Ini_Char { get; set; }    // 작업지시이니셜
        public string Wc_Name { get; set; }         // 작업장명
        public DateTime? Plan_Date { get; set; }    // 계획날짜
        public int Plan_Qty { get; set; }               // 계획수량
        public string Process_code { get; set; }    // 공정코드
        public string Process_name { get; set; }    // 공정이름
        public long Hist_Seq { get; set; }               // 대차이력 순서
        public int Status_Seq { get; set; }            // 대차 현황순서
        public DateTime? In_Time { get; set; }       // 요입시간
        public DateTime? Out_Time { get; set; }      // 요출시간
        public int Center_Time { get; set; }            // 중간시간
        public int? Unloading_Qty { get; set; }               // 언로딩 수량
    }
}
