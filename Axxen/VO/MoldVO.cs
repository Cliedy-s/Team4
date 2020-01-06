using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class MoldVO
    {
        public string Mold_Code { get; set; } //금형코드
        public string Mold_Name { get; set; } //금형명
        public string Mold_Group { get; set; } //금형그룹
        public string Mold_Status { get; set; } //금형상태
        public int Cum_Shot_Cnt { get; set; } //금형누적타수
        public int Cum_Prd_Qty { get; set; } //금형누적생산량
        public decimal Cum_Time { get; set; } //금형누적사용시간
        public int Guar_Shot_Cnt { get; set; } //보장타수
        public int Purchase_Amt { get; set; } //구입금액
        public DateTime In_Date { get; set; } //입고일자
        public DateTime Last_Setup_Time { get; set; } //최종장착일시
        public string Wc_Code { get; set; } //장착작업장코드
        public string Remark { get; set; } //비고
        public string Use_YN { get; set; } //사용여부
        public DateTime Ins_Date { get; set; } //최초입력일자
        public string Ins_Emp { get; set; } //최초입력자
        public DateTime Up_Date { get; set; } //최종수정일자
        public string Up_Emp { get; set; } //최종수정자
    }

    public class Mold_Item_Wc_MuseVO
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
