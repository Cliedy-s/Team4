using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class ConditionSpecVO
    { 
        public string Item_Code { get; set; }              // 품목코드
        public string Wc_Code { get; set; }                // 작업장코드
        public string Condition_Code { get; set; }       // 조건항목코드
        public string Condition_Name { get; set; }      // 조건항목명
        public string Spec_Desc { get; set; }              // SpecDesc
        public decimal SL { get; set; }                         // 기준값
        public decimal USL { get; set; }                       // 상한값
        public decimal LSL { get; set; }                       // 하한값
        public string Condition_Unit { get; set; }         // 조건단위
        public string Condition_Group { get; set; }      // 공정조건그룹
        public string Remark { get; set; }                  // 비고
    }
}
