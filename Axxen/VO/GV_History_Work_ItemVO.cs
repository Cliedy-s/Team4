using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class GV_History_Work_ItemVO // PRM_PRF_006 , PRM_PRF_007
    {
        public string GV_Code { get; set; } //대차코드 
        public string GV_Name { get; set; } //대차명
        public string GV_Status { get; set; } //대차상태 // PRM_PRF_007 만 사용  
        public string Use_YN { get; set; } //대차 사용여부 // PRM_PRF_007 만 사용
        public string Workorderno { get; set; } //작업지시번호 
        public string Item_Code { get; set; } //품목코드 
        public string Item_Name { get; set; } //품목명 
        public DateTime Loading_Date { get; set; } //로딩일자 
        public int Loading_Qty { get; set; } //로딩수량 
        public DateTime Loading_time { get; set; } //로딩시간 
        public string Loading_Wc { get; set; } //로딩작업장 
        public DateTime In_Time { get; set; } //요입시간 
        public int Center_Time { get; set; } //중간시간 
        public DateTime Out_Time { get; set; } //요출시간 
        public int Unloading_Qty { get; set; } //언로딩수량 
        public DateTime Unloading_date { get; set; } //언로딩일자 
        public DateTime Unloading_datetime { get; set; } //언로딩일시 
        public string Unloading_wc { get; set; } //언로딩작업장 
        public string Target_GV { get; set; } //대상대차코드 
        public DateTime Clear_Date { get; set; } //대차비우기일자 
        public DateTime Clear_Datetime { get; set; } //대차비우기일시 
        public int Clear_Qty { get; set; } //대차비우기수량 
        public string Clear_Cause { get; set; } //대차비우기원인 
        public string Clear_wc { get; set; } //대상작업장 
        public string Clear_Item { get; set; } //대상작업장품목 
    }
}
