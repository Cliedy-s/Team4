using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ChartOutputVO
    {
        public string Item_Name { get; set; } //품목명
        public string Prd_Date { get; set; } //생산일자
        public int Plan_Qty { get; set; } //목표량
        public int Prd_Qty { get; set; } //생산량
        public decimal Attain { get; set; } //달성율
    }

    public class ChartBoxPackageVO
    {
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public int F_In_Qty { get; set; } //포장량
        public int Qty_Sum { get; set; } //누계포장량
        public DateTime In_Date { get; set; } //생산일자
    }
}