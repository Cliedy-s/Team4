using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class UserInfoVO
    {
        /// <summary>
        /// 사용자ID
        /// </summary>
        public string User_ID { get; set; }
        /// <summary>
        /// 사용자명
        /// </summary>
        public string User_Name { get; set; }
        /// <summary>
        /// 사용자패스워드
        public string User_PW { get; set; }
        /// <summary>
        /// 거래처코드
        /// </summary>
        public string Customer_Code { get; set; }
        /// <summary>
        /// 기본언어
        /// </summary>
        public string DefaultLanguage { get; set; }
        /// <summary>
        /// 사용자구분
        /// </summary>
        public string User_Type { get; set; }
        /// <summary>
        /// 가격컬럼Visible여부
        /// </summary>
        public string Price_Visible_YN { get; set; }
        /// <summary>
        /// IP보안적용여부
        /// </summary>
        public string IP_Security_YN { get; set; }
        /// <summary>
        /// 패스워드리셋 회수
        /// </summary>
        public int Pw_Reset_Count { get; set; }
        /// <summary>
        /// 기본화면코드
        /// </summary>
        public string Default_Screen_Code { get; set; }
        /// <summary>
        /// 기본공정코드
        /// </summary>
        public string Default_Process_Code { get; set; }
        /// <summary>
        /// 모니터링사용여부
        /// </summary>
        public string Monitoring_YN { get; set; }
        /// <summary>
        /// 사용여부
        /// </summary>
        public string Use_YN { get; set; }
        /// <summary>
        ///  단축기
        /// </summary>
        public string S01 { get; set; }
        public string S02 { get; set; }
        public string S03 { get; set; }
        public string S04 { get; set; }
        public string S05 { get; set; }
        public string S06 { get; set; }
        public string S07 { get; set; }
        public string S08 { get; set; }
        public string S09 { get; set; }
        public string S10 { get; set; }
        public string S11 { get; set; }
        public string S12 { get; set; }
        /// <summary>
        /// 최초입력일자
        /// </summary>
        public DateTime Ins_Date { get; set; }
        /// <summary>
        /// 최초입력자
        /// </summary>
        public string Ins_Emp { get; set; }
        /// <summary>
        /// 최종수정일자
        /// </summary>
        public DateTime Up_Date { get; set; }
        /// <summary>
        /// 최종수정자
        /// </summary>
        public string Up_Emp { get; set; }

    }
}
