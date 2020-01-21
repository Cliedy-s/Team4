using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class Pallet_Master_J_BoxingGrade_Detail_MasterVO
    { 
        public string Pallet_No { get; set; }                // 팔레트번호
        public string Barcode_No { get; set; }             // 바코드번호
        public string Grade_Detail_Code { get; set; }    // 포장등급상세코드
        public string Grade_Detail_Name { get; set; }   // 포장등급상세명
        public string Boxing_Grade_Code { get; set; }  // 포장등급
        public string In_Qty { get; set; }                    // 생산수량
    }
}
