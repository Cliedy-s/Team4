using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class WorkOrder_J_WC_Time_DayVO //KPI_RPT_005
    {
        public DateTime Prd_Date { get; set; } //생산일자(기준일)
        public string Item_Name { get; set; } //품목명
        public string Wc_Name { get; set; } //작업장명
        public string Prd_Unit { get; set; } //생산단위
        public int Prd_Qty { get; set; } //생산수량
        public DateTime Prd_Starttime { get; set; } //계획시작시간
        public DateTime Prd_Endtime { get; set; } //계획종료시간(목표생산시간)
        public DateTime Plan_Starttime { get; set; } //작업시작시간
        public DateTime Plan_Endtime { get; set; } //작업종료시간(작업시간)
        public string Remark { get; set; } //비고
    }
}
