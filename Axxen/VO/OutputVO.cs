using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class OutputVO
    {
        public string Process_Name { get; set; } //공정명
        public string Wc_Name { get; set; } //작업장명
        public string Item_Name { get; set; } //품목명
        public int laPlan_Oty { get; set; } //전월목표량
        public int laPrd_Qty { get; set; } //전월생산량
        public int laPrd_Time { get; set; } //전월생산시간
        public string laAttain { get; set; } //전월달성율
        public int Plan_Oty { get; set; } //당월목표량
        public int Prd_Qty { get; set; } //당월생산량
        public int Prd_Time { get; set; } //당월생산시간
        public string Attain { get; set; } //당월달성율
        public string Inde { get; set; } //증감율
    }

    public class BoxPackageVO
    {
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public int F_In_Qty { get; set; } //일일포장량
        public DateTime In_Date { get; set; } //포장일자
        public int Qty_Sum { get; set; } //누계포장량
    }
}
