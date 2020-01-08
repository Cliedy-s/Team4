using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
   public class ScreenItem_MasterVO
    {
        /// <summary>
        /// 화면코드
        /// </summary>
        public string Screen_Code { get; set; }
        /// <summary>
        /// 단어키
        /// </summary>
        public string Wordkey { get; set; }
        /// <summary>
        /// 정렬순서
        /// </summary>
        public int Sort_index { get; set; }
        /// <summary>
        /// 화면타입
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 화면경로
        /// </summary>
        public string Screen_Path { get; set; }
        /// <summary>
        /// 화면DLL명
        /// </summary>
        public string ContentDLL { get; set; }
        /// <summary>
        /// 모니터링화면여부
        /// </summary>
        public string Monitoring_YN { get; set; }
        /// <summary>
        /// 사용여부
        /// </summary>
        public string Use_YN { get; set; }
        /// <summary>
        /// 최초입력일자
        /// </summary>
        public DateTime Ins_Date { get; set; }
        /// <summary>
        /// 최초입력자
        /// </summary>
        public string Ins_Emp { get; set; }
        /// <summary>
        /// 최초입최종수정일자력자
        /// </summary>
        public DateTime Up_Date { get; set; }
        /// <summary>
        /// 수정자
        /// </summary>
        public string Up_Emp { get; set; }

    }
}
