using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class NopHistoryVO
    {
        public long Nop_Seq { get; set; }                    //     발생순번
        public DateTime Nop_Date { get; set; }              // 발생일자
        public DateTime Nop_Happentime { get; set; }    // 발생일시
        public DateTime Nop_Canceltime { get; set; }      // 해제일시
        public string Wc_Code { get; set; }                    // 작업장코드
        public string Nop_Mi_Code { get; set; }              // 비가동상세분류코드
        public string Nop_Type { get; set; }              // 발생유형
        public decimal Nop_Time { get; set; }              // 비가동시간
        public string Nop_Mi_Name { get; set; }        // 비가동상세분류명
        public string Nop_Ma_Name { get; set; }       // 비가동대분류명
        public string Wc_Name { get; set; }              // 작업장명
    }

}
