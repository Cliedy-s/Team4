using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class GVStatusVO
    {
        public string GV_Code { get; set; }        // 대차번호
        public string GV_Name { get; set; }       // 대차명
        public string GV_Group { get; set; }       // 대차그룹
        public string GV_Status { get; set; }       // 대차상태
        public string Item_Code { get; set; }      // 품목코드
        public string Item_Name { get; set; }     // 품목명
	    public DateTime Loading_time { get; set; }  // 적재시간
	    public int Loading_Qty { get; set; }            // 적재수량
        public string Workorderno { get; set; }   // 작업지시번호
        public int Prd_Qty { get; set; }              // 생산수량
        public string Prd_Unit { get; set; }        // 생산수량단위
        public string Wc_Code { get; set; }        // 작업장코드
        public string Wo_Ini_Char { get; set; }    // 작업지시이니셜
    }
}
