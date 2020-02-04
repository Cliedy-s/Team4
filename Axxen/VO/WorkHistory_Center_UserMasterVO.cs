using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WorkHistory_Center_UserMasterVO
    {
        public string User_ID { get; set; } //사용자ID //PRM_PRF_010
        public string User_Name { get; set; } //작업자,사용자명 //PRM_PRF_009 //PRM_PRF_010
        public string Workorderno { get; set; } //작업지시번호 //PRM_PRF_010
        public string Wc_Name { get; set; } //작업장명 //PRM_PRF_009  
        public string Wc_Code { get; set; } //작업장코드  //PRM_PRF_010
        public string Item_Code { get; set; } //품목코드 //PRM_PRF_010
        public string Item_Name { get; set; } //품목명 //PRM_PRF_010
        public DateTime Prd_Starttime { get; set; } //작업시작시간 //PRM_PRF_010
        public DateTime Prd_Endtime { get; set; } //작업종료시간 //PRM_PRF_010
        public int Prd_Qty { get; set; } //작업수량 //PRM_PRF_010
        public DateTime Work_Date { get; set; } //근무일 //PRM_PRF_009        
        public DateTime Work_StartTime { get; set; } //근무시작시간 //PRM_PRF_009
        public DateTime Work_EndTime { get; set; } //근무종료시간 //PRM_PRF_009
        public decimal Work_Time { get; set; } // 근무시간 //PRM_PRF_009
    }
}
