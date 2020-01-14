using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class Process_J_WC_Item_WO_Time_DayVO //KPI_RPT_002
    {
        public string Process_Name { get; set; } //공정명
        public string Wc_Name { get; set; } //작업장명
        public string Item_Name { get; set; } //품목명
        public int Plan_Qty { get; set; } //계획수량
        public int Prd_Qty { get; set; } //생산수량
        public DateTime Prd_Starttime { get; set; } //작업시작시간
        public DateTime Prd_Endtime { get; set; } //작업종료시간

    }
}
