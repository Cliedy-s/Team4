using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WorkerVO
    {
        public string Wc_Code { get; set; }                     // 작업장코드
        public string User_ID { get; set; }                       // 사용자ID
        public DateTime Allocation_datetime { get; set; }   // 할당일시
        public string User_Name { get; set; }                  // 사용자명
    }
    public class WorkerAllocatableVO
    {
        public string User_ID { get; set; }                        // 사용자ID
        public string User_Name { get; set; }                   // 사용자명
        public string NOWWC { get; set; }                      // 현재작업장코드
    }
}
