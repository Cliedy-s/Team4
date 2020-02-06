using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axxen
{
  public static class UserInfo
    {
        /// <summary>
        /// 사용자ID
        /// </summary>
        public static string User_ID { get; set; }
        /// <summary>
        /// 사용자명
        /// </summary>
        public static string User_Name { get; set; }
        /// <summary>
        /// 사용자패스워드
        public static string User_PW { get; set; }
        /// <summary>
        /// 거래처코드
        /// </summary>
        public static string Customer_Code { get; set; }
        /// <summary>
        /// 기본언어
        /// </summary>
        public static string DefaultLanguage { get; set; }
        /// <summary>
        /// 사용자구분
        /// </summary>
        public static string User_Type { get; set; }
        /// <summary>
        /// 가격컬럼Visible여부
        /// </summary>
        public static string Price_Visible_YN { get; set; }
        /// <summary>
        /// IP보안적용여부
        /// </summary>
        public static string IP_Security_YN { get; set; }
        /// <summary>
        /// 패스워드리셋 회수
        /// </summary>
        public static int Pw_Reset_Count { get; set; }
        /// <summary>
        /// 기본화면코드
        /// </summary>
        public static string Default_Screen_Code { get; set; }
        /// <summary>
        /// 기본공정코드
        /// </summary>
        public static string Default_Process_Code { get; set; }
        /// <summary>
        /// 모니터링사용여부
        /// </summary>
        public static string Monitoring_YN { get; set; }
        /// <summary>
        /// 사용여부
        /// </summary>
        public static string Use_YN { get; set; }
        /// <summary>
        ///  단축기
        /// </summary>
        public static string S01 { get; set; }
        public static string S02 { get; set; }
        public static string S03 { get; set; }
        public static string S04 { get; set; }
        public static string S05 { get; set; }
        public static string S06 { get; set; }
        public static string S07 { get; set; }
        public static string S08 { get; set; }
        public static string S09 { get; set; }
        public static string S10 { get; set; }
        public static string S11 { get; set; }
        public static string S12 { get; set; }
        /// <summary>
        /// 최초입력일자
        /// </summary>
        public static DateTime Ins_Date { get; set; }
        /// <summary>
        /// 최초입력자
        /// </summary>
        public static string Ins_Emp { get; set; }
        /// <summary>
        /// 최종수정일자
        /// </summary>
        public static DateTime Up_Date { get; set; }
        /// <summary>
        /// 최종수정자
        /// </summary>
        public static string Up_Emp { get; set; }

        public static string Session_ID { get; set; }
    }
}
