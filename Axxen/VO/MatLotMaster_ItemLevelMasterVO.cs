using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class MatLotMaster_ItemLevelMasterVO
    {
        public string YYYY { get; set; } //생산년도
        public string Level_Code { get; set; } //레벨코드
        public string Level_Name { get; set; } //레벨명
        public int Prd_Order { get; set; } //차수
        public string Mat_LotNo { get; set; } //원자재LOT 번호
    }
}
