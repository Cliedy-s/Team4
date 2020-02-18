using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Def_History2VO
    {
        [DisplayName("작업지시번호")] //컬럼명변경
        public string Workorderno { get; set; } //작업지시
        [DisplayName("불량순번")] //컬럼명변경
        public int Def_Seq { get; set; } //불량순번
        [DisplayName("불량명")] //컬럼명변경
        public string Def_Mi_Name { get; set; } //불량현상상세분류명
        [DisplayName("불량코드")] //컬럼명변경
        public string Def_Mi_Code { get; set; } //불량현상상세분류코드
        [DisplayName("발생일")] //컬럼명변경
        public string Def_Date { get; set; } //발생일
        [DisplayName("불량수량")] //컬럼명변경
        public int Def_Qty { get; set; } //불량수량
        [DisplayName("사진 업로드")] //컬럼명변경
        public string Def_Image_Name { get; set; } //다운로드
        [DisplayName("작성날짜")] //컬럼명변경
        public string Ins_Date { get; set; } //최초생성날짜
        [DisplayName("작성자")] //컬럼명변경
        public string Ins_Emp { get; set; } //최초입력자
    }
}