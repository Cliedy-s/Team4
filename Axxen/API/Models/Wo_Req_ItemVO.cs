using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models
{
    public class Wo_Req_ItemVO //SCH_001
    {
        public string Wo_Req_No { get; set; } //생산의뢰번호
        public int Req_Req { get; set; } //의뢰순번
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public int Req_Qty { get; set; } //의뢰수량
        public DateTime Prd_Plan_Date { get; set; } //생산완료예정일
        public string Project_Name { get; set; } //프로젝트명
        public string Cust_Name { get; set; } //거래처명
        public string Sale_Emp { get; set; } //영업담당
        public string Req_Status { get; set; } //생산의뢰상태
    }
}
