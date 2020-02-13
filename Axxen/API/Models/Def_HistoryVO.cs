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
        public int Workorderno { get; set; } //작업지시

        public int Def_Seq { get; set; } //불량순번	

        [DisplayName("불량현상상세분류코드")] //컬럼명변경
        public int Def_Mi_Code { get; set; } //불량현상상세분류코드
        
        [DisplayName("발생일시")] //컬럼명변경
        public int Def_Date { get; set; } //발생일시

        [DisplayName("불량수량")] //컬럼명변경
        public int Def_Qty { get; set; } //불량수량	
        public int Def_Image_Name { get; set; } //불량사진명		
        public int Def_Image_Path { get; set; } //불량사진경로		
        public int Ins_Date { get; set; } //최초입력일자		
        public int Ins_Emp { get; set; } //최초입력자		
        public int Up_Date { get; set; } //최종수정일자		
        public int Up_Emp { get; set; } //최종수정자		
    }
}