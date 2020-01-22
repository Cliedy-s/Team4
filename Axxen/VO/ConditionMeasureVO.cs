using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class ConditionMeasureVO
    { 
        public int Condition_measure_seq { get; set; }         // 조건순번
        public string Item_code { get; set; }                          // 품목코드
        public string Wc_Code { get; set; }                           // 작업장코드
        public string Condition_Code { get; set; }                   // 조건항목코드
        public DateTime Condition_Date { get; set; }                   // 측정일자
        public DateTime Condition_Datetime { get; set; }              // 측정일시
        public string Condition_Val { get; set; }                     // 측정값
        public string Workorderno { get; set; }                      // 작업지시번호
    }
}
