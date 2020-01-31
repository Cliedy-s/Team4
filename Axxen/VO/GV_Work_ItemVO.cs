using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class GV_Work_ItemVO //PRM_PRF_004
    {
        public string GV_Code { get; set; }//대차코드 
        public string GV_Name { get; set; } //대차명
        public string GV_Group { get; set; } //대차그룹명
        public string Workorderno { get; set; } //작업지시번호
        public string Item_Code { get; set; } //품목코드 
        public string Item_Name { get; set; } //품목명 
        public string GV_Status { get; set; } //대차상태 
        public int GV_Qty { get; set; } //대차수량
        public DateTime Loading_date { get; set; } //로딩일자
        public DateTime Loading_time { get; set; } //로딩시간 
        public string Loading_Wc { get; set; } //로딩작업장
        public DateTime Unloading_date { get; set; } //언로딩일자
        public DateTime Unloading_time { get; set; } //언로딩시간
        public string Unloading_Wc { get; set; }//언로딩작업장 
        public DateTime In_Time { get; set; }//요입시간 
        public DateTime Center_Time { get; set; }//중간시간 
        public DateTime Out_Time { get; set; }//요출시간 
    }
}
