using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    /// <summary>
    /// 공정 마스터
    /// </summary>
    public class Process_MasterVO
    {
        /// <summary>
        /// 공정코드
        /// </summary>
        public string Process_code { get; set; }
        /// <summary>
        /// 공정명
        /// </summary>
        public string Process_name { get; set; }

        /// <summary>
        /// 사용여부
        /// </summary>
        public string Use_YN { get; set; }
        /// <summary>
        /// 비고
        /// </summary>
        public string Remark { get; set; }

        public DateTime Ins_Date { get; set; }

        public string Ins_Emp { get; set; }

        public DateTime Up_Date { get; set; }

        public string Up_Emp { get; set; }



    }
}
