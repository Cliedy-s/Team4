using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Wo_ReqVO
    {
        [Display(Name = "생산의뢰번호")]
        public string Wo_Req_No { get; set; } //생산의뢰번호
        [Display(Name = "의뢰수량")]
        public int Req_Qty { get; set; } //의뢰수량
        [Display(Name = "생산완료예정일")]
        public DateTime Prd_Plan_Date { get; set; } //생산완료예정일
        [Display(Name = "거래처명")]
        public string Cust_Name { get; set; } //거래처명
        [Display(Name = "프로젝트명")]
        public string Project_Name { get; set; } //프로젝트명
        [Display(Name = "영업담당")]
        public string Sale_Emp { get; set; } //영업담당

        public string Req_Status { get; set; } //생산의뢰상태
    }
}