using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class Wo_J_Goods_In_HistoryVO
    { 
        public string Workorderno { get; set; }            // 작업지시번호
        public string Pallet_No { get; set; }                 // 팔레트번호
        public string Barcode_No { get; set; }             // 바코드번호
        public string Grade_Detail_Code { get; set; }     // 포장등급상세코드
        public string Grade_Detail_Name { get; set; }    // 등급상세명
        public string Boxing_Grade_Code { get; set; }   // 포장등급
        public string In_Qty { get; set; }                     // 생산수량
        public string CurrentQty { get; set; }               // 이용가능수량
        public string In_Date { get; set; }                   // 입고일자
        public string In_YN { get; set; }                      // 입고여부
        public string Item_Code { get; set; }               // 품목코드
        public string Wc_Code { get; set; }                 // 작업장코드
    }
}
