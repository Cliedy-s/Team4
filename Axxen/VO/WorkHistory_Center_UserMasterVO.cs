using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WorkHistory_Center_UserMasterVO
    {
        public DateTime Work_Date { get; set; } //근무일
        public string Wc_Name { get; set; } //작업장명
        public string User_Name { get; set; } //작업자
        public DateTime Work_StartTime { get; set; } //근무시작시간
        public DateTime Work_EndTime { get; set; } //근무종료시간
        public decimal Work_Time { get; set; } // 근무시간
    }
}
