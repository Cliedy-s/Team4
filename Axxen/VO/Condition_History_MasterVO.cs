using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Condition_History_MasterVO
    {
        public string Workorderno { get; set; } //작업지시번호
        public DateTime Prd_Date { get; set; } //생산일
        public string Process_name { get; set; } //공정
        public string Wc_Name { get; set; } //작업장
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public string Inspect_name { get; set; } //측정항목
        public decimal USL { get; set; } //USL
        public decimal SL { get; set; } //SL 
        public decimal LSL { get; set; } //LSL
        public DateTime Inspect_datetime { get; set; } //측정일시
        public DateTime Inspect_date { get; set; } //측정회차
        public decimal Inspect_val { get; set; } //측정값
    }
}
