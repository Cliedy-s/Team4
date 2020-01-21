using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class GVUnloadVO
    {
        public string Unloading_Qty { get; set; }             // 언로딩수량
        public DateTime Unloading_date { get; set; }       // 언로딩일자
        public DateTime Unloading_datetime { get; set; } // 언로딩일시
        public string Unloading_wc { get; set; }              // 언로딩작업장
        public string GV_Code { get; set; }                    // 대차코드
        public string Workorderno { get; set; }               // 작업지시번호
        public DateTime Up_Date { get; set; }                // 최종수정일자
        public string Up_Emp { get; set; }                      // 최종수정자
    }
}
