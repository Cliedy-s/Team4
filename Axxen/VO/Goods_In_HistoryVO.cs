using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class Goods_In_HistoryVO
    {
        public string Workorderno { get; set; }    // 작업지시번호
        public string Pallet_No { get; set; }         // 팔레트번호
        public DateTime In_Date { get; set; }      // 입고일자
        public string In_YN { get; set; }              // 입고여부
        public DateTime Up_Date { get; set; }     // 최종수정일자
        public string Up_Emp { get; set; }          // 최종수정자
    }
}
