using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    /// <summary>
    /// 품목그룹정보
    /// </summary>
    public class Item_Level_MasterVO
    {
        /// <summary>
        /// 레벨코드
        /// </summary>
        public string Level_Code { get; set; }
        /// <summary>
        /// 그룹명
        /// </summary>
        public string Level_Name { get; set; }
        /// <summary>
        /// 품목레벨1
        /// </summary>
        public string Item_lvl1 { get; set; }
        /// <summary>
        /// 품목레벨2
        /// </summary>
        public string Item_lvl2 { get; set; }
        /// <summary>
        /// 품목레벨3
        /// </summary>
        public string Item_lvl3 { get; set; }
        /// <summary>
        /// 품목레벨4
        /// </summary>
        public string Item_lvl4 { get; set; }
        /// <summary>
        /// 품목레벨5
        /// </summary>
        public string Item_lvl5 { get; set; }
        /// <summary>
        /// 팔렛당박스수
        /// </summary>
        public int Box_Qty { get; set; }
        /// <summary>
        /// 박스당PCS수
        /// </summary>
        public int Pcs_Qty { get; set; }
        /// <summary>
        /// PCS당소재량
        /// </summary>
        public decimal Mat_Qty { get; set; }
        /// <summary>
        /// 사용여부
        /// </summary>
        public string Use_YN { get; set; }
        public DateTime Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public DateTime Up_Date { get; set; }
        public string Up_Emp { get; set; }

    }
}
