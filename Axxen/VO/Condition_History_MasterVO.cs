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
        public string Process_code { get; set; } //공정코드
        public string Process_name { get; set; } //공정명
        public string Wc_Code { get; set; } //작업장
        public string Wc_Name { get; set; } //작업장명
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public string Condition_Code { get; set; } //측정항목코드
        public string Condition_Name { get; set; } //측정항목
        public decimal USL { get; set; } //USL
        public decimal SL { get; set; } //SL 
        public decimal LSL { get; set; } //LSL
        public DateTime Condition_Datetime { get; set; } //측정일시
        public DateTime Condition_Date { get; set; } //측정일자
        public long Condition_measure_seq { get; set; } //측정순번
        public decimal Condition_Val { get; set; } //측정값
    }
}
