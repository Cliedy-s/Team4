using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class NopMiMasterVO
    { 
        public string Nop_Mi_Code { get; set; }        // 비가동상세분류코드
        public string Nop_Mi_Name { get; set; }       // 비가동상세분류명
        public string Nop_Ma_Code { get; set; }       // 비가동대분류코드
        public string Remark { get; set; }                // 비고
        public DateTime Ins_Date { get; set; }          // 최초입력일자
        public string Ins_Emp { get; set; }               // 최초입력자
        public DateTime Up_Date { get; set; }          // 최초수정일자
        public string Up_Emp { get; set; }               // 최초수정자
    }
}
