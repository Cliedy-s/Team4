using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class GasUse_HistoryVO
    {
        public long Seq { get; set; } //이력순번
        public DateTime Std_Date { get; set; } //기준일자
        public string Wc_Code { get; set; } //작업장코드
        public string Wc_Name { get; set; } //작업장명
        public int Gas_Val { get; set; } //가스계량치
        public string Remark { get; set; } //비고
        public DateTime Ins_Date { get; set; } //최초입력일자
        public string Ins_Emp { get; set; } //최초입력자
        public DateTime Up_Date { get; set; } //최종수정일자
        public string Up_Emp { get; set; } //최종수정자

    }
}
