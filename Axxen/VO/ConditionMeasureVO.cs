using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class ConditionMeasureVO
    { 
        public string Condition_measure_seq { get; set; }         // 조건순번
        public string Item_code { get; set; }                          // 품목코드
        public string Wc_Code { get; set; }                           // 작업장코드
        public string Condition_Code { get; set; }                   // 조건항목코드
        public string Condition_Date { get; set; }                   // 측정일자
        public string Condition_Datetime { get; set; }              // 측정일시
        public string Condition_Val { get; set; }                     // 측정값
        public string Workorderno { get; set; }                      // 작업지시번호
        public DateTime Ins_Date { get; set; }                        // 최초입력일자
        public string Ins_Emp { get; set; }                             // 최초입력자
        public DateTime Up_Date { get; set; }                       // 최종수정일자
        public string Up_Emp { get; set; }                             // 최종수정자
    }
}
