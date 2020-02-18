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
        public int In_Qty { get; set; }                   // 입고수량
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
        public string Size_Code { get; set; }               // 사이즈 코드
        public DateTime? In_Date { get; set; }              // 입고일자
        public string In_YN { get; set; }                      // 입고여부
        public string Item_Code { get; set; }                // 품목코드
        public string Wc_Code { get; set; }                 // 작업장코드
    }
    public class PalletGoodsVO
    {
        public string Pallet_No { get; set; }
        public string Workorderno { get; set; }
        public string Barcode_No { get; set; }
        public DateTime? Barcode_PublishDate { get; set; }
        public string Grade_Code { get; set; }
        public string Grade_Detail_Code { get; set; }
        public string Size_Code { get; set; }
        public int palin { get; set; }
        public int CurrentQty { get; set; }
        public string Use_YN { get; set; }
        public string Pal_Seq { get; set; }
        public DateTime? In_Date { get; set; }
        public string Upload_Flag { get; set; }
        public string Update_YN { get; set; }
        public int Contain_Qty { get; set; }
        public int goodsin { get; set; }
        public int F_In_Qty { get; set; }
        public DateTime? Closed_Time { get; set; }
        public DateTime? Cancel_Time { get; set; }
        public DateTime? Print_Date { get; set; }
        public string In_YN { get; set; }
        public string Remark { get; set; }
        public DateTime? Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public DateTime? Up_Date { get; set; }
        public string Up_Emp { get; set; }
    }

}
