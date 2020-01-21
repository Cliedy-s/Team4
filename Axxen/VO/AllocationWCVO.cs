using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class AllocationWCVO
    { 
        public string Wc_Code { get; set; }                  // 작업장코드
        public string User_ID { get; set; }                    // 사용자ID
        public DateTime Allocation_datetime { get; set; }    // 할당일시
        public DateTime Release_datetime { get; set; }       // 해제일시
        public DateTime Ins_Date { get; set; }                   // 최초입력일자
        public string Ins_Emp { get; set; }                   // 최초입력자
        public DateTime Up_Date { get; set; }                   // 최종수정일자
        public string Up_Emp { get; set; }                   // 최종수정자
    }
}
