using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Mold_J_Item_Wc_MuseVO //MLD_002
    {
        public string Mold_Code { get; set; } //금형코드
        public string Mold_Name { get; set; } //금형명
        public string Workorderno { get; set; } //작업지시번호
        public int Mold_Shot_Cnt { get; set; } //금형타수
        public int Mold_Prd_Qty { get; set; } //금형생산량
        public DateTime Use_Starttime { get; set; } //금형사용시작시간
        public DateTime Use_Endtime { get; set; } //금형사용종료시간
        public string Wc_Code { get; set; } //작업장코드
        public string Wc_Name { get; set; } //작업장이름
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
    }
}
