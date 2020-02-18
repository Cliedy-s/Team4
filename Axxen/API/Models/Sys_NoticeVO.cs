using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Sys_NoticeVO
    {
        [Display(Name = "번호")]
        public int Seq { get; set; }
        [Display(Name = "시작일")]
        public DateTime Notice_Date { get; set; }
        [Display(Name = "종료일")]
        public DateTime Notice_End { get; set; }
        [Display(Name = "제목")]
        public string Title { get; set; }
        [Display(Name = "공지내역")]
        public string Description { get; set; }        
        [Display(Name ="입력자")]
        public string Ins_Emp { get; set; }
    }
}