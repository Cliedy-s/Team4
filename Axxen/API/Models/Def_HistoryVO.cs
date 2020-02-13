using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Def_HistoryVO
    {
        [DisplayName("작업지시번호")] //컬럼명변경
        public string Workorderno { get; set; } //작업지시
        public int Def_Seq { get; set; } //불량순번	

        [DisplayName("불량현상 상세분류명")] //컬럼명변경
        public string Def_Mi_Name { get; set; } //불량현상상세분류명

        [DisplayName("불량현상 상세분류코드")] //컬럼명변경
        public string Def_Mi_Code { get; set; } //불량현상상세분류코드

        [DisplayName("발생일시")] //컬럼명변경
        public DateTime Def_Date { get; set; } //발생일시

        [DisplayName("불량수량")] //컬럼명변경
        public int Def_Qty { get; set; } //불량수량	
        public string Def_Image_Name { get; set; } //불량사진명		
        public string Def_Image_Path { get; set; } //불량사진경로			
        public string Ins_Emp { get; set; } //최초입력자		
        public string Up_Emp { get; set; } //최종수정자		
    }
}