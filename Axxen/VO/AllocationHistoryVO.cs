using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class AllocationHistoryVO
    {
        public string User_ID { get; set; }                    // 사용자ID
        public DateTime Allocation_date { get; set; }          // 할당일자
        public DateTime Allocation_datetime { get; set; }    // 할당일시
        public DateTime Release_datetime { get; set; }       // 해제일시
        public DateTime Ins_Date { get; set; }                   // 최초입력일자
        public string Ins_Emp { get; set; }                   // 최초입력자
        public DateTime Up_Date { get; set; }                   // 최초수정일자
        public string Up_Emp { get; set; }                   // 최초수정자
    }
    public class AllocationHistoryDetailVO
    {
        public int Detail_Seq { get; set; }
        public string User_ID { get; set; }
        public string Workorderno { get; set; }
        public DateTime Prd_Starttime { get; set; }
        public DateTime Prd_Endtime { get; set; }
        public string Prd_Qty { get; set; }
        public DateTime Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public DateTime Up_Date { get; set; }
        public string Up_Emp { get; set; }
    }
}
