using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Goods_In_History_J_Pallet_BoxingVO
    {
        public string Pallet_No { get; set; } //팔렛트번호
        public string Grade_Code { get; set; } //등급
        public string Grade_Detail_Code { get; set; } //등급상세 코드
        public string Grade_Detail_Name { get; set; } //등급상세 명
        public int In_Qty { get; set; } //수량
        public string Use_YN { get; set; } //마감 여부
    }
}
