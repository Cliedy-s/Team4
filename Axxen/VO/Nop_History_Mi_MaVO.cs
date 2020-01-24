using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Nop_History_Mi_MaVO //PRM_PRF_008
    {
        public DateTime Nop_Date { get; set; } //비가동일자
        public string Wc_Code { get; set; } // 작업장코드
        public string Wc_Name { get; set; } // 작업장명
        public string Nop_Ma_Name { get; set; } //비가동대분류
        public string Nop_Mi_Name { get; set; } //비가동상세분류
        public DateTime Nop_Happentime { get; set; } //비가동발생시각
        public DateTime Nop_Canceltime { get; set; } //비가동종료시각
        public decimal Nop_Time { get; set; } //비가동시간
        public string Remark { get; set; } //비고
        public string Nop_Type { get; set; } //발생유형
        
    }
}
