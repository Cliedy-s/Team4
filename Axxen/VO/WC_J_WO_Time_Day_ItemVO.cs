using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class WC_J_WO_Time_Day_ItemVO //KPI_RPT_003
    {
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public int In_Qty_Main { get; set; } //투입수량
        public int Prd_Qty { get; set; } //생산수량
        public string Process_Code { get; set; } //공정코드
        public string Process_Name { get; set; } //공정명
        public DateTime Prd_Date { get; set; } //생산일자
    }
}
  