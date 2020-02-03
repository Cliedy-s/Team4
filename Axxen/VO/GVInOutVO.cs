using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class GVInOutVO
    {
        public string Status_Seq { get; set; }                  // 대차순번
        public string GV_Code { get; set; }                    // 대차코드
        public string Workorderno { get; set; }               // 작업지시번호
        public DateTime Loading_date { get; set; }               // 로딩일자
        public DateTime Loading_time { get; set; }               // 로딩시간
        public string Loading_Wc { get; set; }                // 로딩작업장
        public DateTime In_Time { get; set; }                      // 요입시간
        public int Center_Time { get; set; }                // 중간시간
        public DateTime Out_Time { get; set; }                    // 요출시간
        public string GV_Name { get; set; }                   // 대차명
        public string Wc_Code { get; set; }                    // 작업장코드
        public int In_Qty_Main { get; set; }                // workorder.투입수량
    }
}
