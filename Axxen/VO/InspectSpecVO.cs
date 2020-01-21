using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class InspectSpecVO
    {
        public string Item_Code { get; set; }         // 품목코드
        public string Process_code { get; set; }      // 공정코드
        public string Inspect_code { get; set; }      // 항목코드
        public string Inspect_name { get; set; }     // 검사항목명
        public string Spec_Desc { get; set; }         // SpecDesc
        public decimal USL { get; set; }               // 규격상한값
        public decimal SL { get; set; }                 // 규격기준값
        public decimal LSL { get; set; }                // 규격하한값
        public int Sample_size { get; set; }           // 샘플크기
        public string Inspect_Unit { get; set; }       // 단위
        public char Use_YN { get; set; }               // 사용여부
        public string Remark { get; set; }             // 비고
    }
}
