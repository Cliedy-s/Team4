using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class Process_J_Nop_History_Gas_WC_Time_DayVO //KPI_RPT_001
    {
        public string Prd_Date { get; set; } //생산일자
        public string Process_Name { get; set; } //공정명
        public string Wc_Name { get; set; } //작업장명
        public string Item_Name { get; set; } //품목명
        public string Prd_Qty { get; set; } //생산량
        public string Prd_Starttime { get; set; } //작업시작시간
        public string Prd_Endtime { get; set; } //작업종료시간
        public string Dorm_Gas { get; set; } //가스사용량
        public string Nop_Time { get; set; } //비가동시간

    }
}
