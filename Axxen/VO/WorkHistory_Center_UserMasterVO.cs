using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WorkHistory_Center_UserMasterVO
    {
        public DateTime Work_Date { get; set; }
        public string Wc_Name { get; set; }
        public string User_Name { get; set; }
        public DateTime Work_StartTime { get; set; }
        public DateTime Work_EndTime { get; set; }
        public decimal Work_Time { get; set; }
    }
}
