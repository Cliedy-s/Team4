using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class PalletVO
    {
        public string Pallet_No { get; set; }                // 팔레트번호
        public string WorkOrderNo { get; set; }         // 작업지시번호
        public string Barcode_No { get; set; }            // 바코드번호
        public string Grade_Detail_Code { get; set; }   // 포장등급상세코드
        public string Grade_Detail_Name { get; set; }   // 포장등급상세명
        public string Boxing_Grade_Code { get; set; }  // 포장등급
        public string Size_Code { get; set; }               // 사이즈
        public int In_Qty { get; set; }                   // 생산수량
        public int CurrentQty { get; set; }             // 이용가능수량
        public string Use_YN { get; set; }                  // 사용여부
        public string Item_Code { get; set; }              // 품목코드
        public string Item_Name { get; set; }             // 품목이름
    }
    public class PalletTodayInVO
    {
        public string Workorderno { get; set; }            // 작업지시번호
        public DateTime Plan_Date { get; set; }            // 계획날짜
        public string Pallet_No { get; set; }                 // 팔레트번호
        public string Barcode_No { get; set; }             // 바코드번호
        public string Grade_Detail_Code { get; set; }     // 포장등급상세코드
        public string Grade_Detail_Name { get; set; }    // 포장등급상세명
        public string Boxing_Grade_Code { get; set; }   // 포장등급
        public int In_Qty { get; set; }                         // 생산수량
        public int CurrentQty { get; set; }                   // 이용가능수량
        public DateTime In_Date { get; set; }              // 입고일자
        public string In_YN { get; set; }                      // 입고여부
        public string Item_Code { get; set; }                // 품목코드
        public string Wc_Code { get; set; }                 // 작업장코드
    }

}
