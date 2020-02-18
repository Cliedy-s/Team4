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
    public class Item_Level_Master
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
    /// <summary>
    /// 품목정보
    /// </summary>
    public class Item_MasterVO
    {
        /// <summary>
        /// 품목코드
        /// </summary>
        public string Item_Code { get; set; }
        /// <summary>
        /// 품목명
        /// </summary>
        public string Item_Name { get; set; }
        /// <summary>
        /// 품목명(영어)
        /// </summary>
        public string Item_Name_Eng { get; set; }
        /// <summary>
        /// 품목명(영어약어)
        /// </summary>
        public string Item_Name_Eng_Alias { get; set; }
        /// <summary>
        /// 품목유형
        /// </summary>
        public string Item_Type { get; set; }
        /// <summary>
        /// 사양
        /// </summary>
        public string Item_Spec { get; set; }
        /// <summary>
        /// 단위
        /// </summary>
        public string Item_Unit { get; set; }
        /// <summary>
        /// 품목레벨1
        /// </summary>
        public string Level_1 { get; set; }
        /// <summary>
        /// 품목레벨2
        /// </summary>
        public string Level_2 { get; set; }
        /// <summary>
        /// 품목레벨3
        /// </summary>
        public string Level_3 { get; set; }
        /// <summary>
        /// 품목레벨4
        /// </summary>
        public string Level_4 { get; set; }
        /// <summary>
        /// 품목레벨5
        /// </summary>
        public string Level_5 { get; set; }
        /// <summary>
        /// 안전재고
        /// </summary>
        public decimal Item_Stock { get; set; }
        /// <summary>
        /// 리드타임
        /// </summary>
        public string Lead_Time { get; set; }
        /// <summary>
        /// LotSize
        /// </summary>
        public decimal LotSize { get; set; }
        /// <summary>
        /// 시간당생산수
        /// </summary>
        public decimal PrdQty_Per_Hour { get; set; }
        /// <summary>
        /// 배치당생산수
        /// </summary>
        public decimal PrdQTy_Per_Batch { get; set; }
        /// <summary>
        /// 캐비티수
        /// </summary>
        public int Cavity { get; set; }
        /// <summary>
        /// 성형줄당PCS수
        /// </summary>
        public int Line_Per_Qty { get; set; }
        /// <summary>
        /// 포장Shot당PCS수
        /// </summary>
        public int Shot_Per_Qty { get; set; }
        /// <summary>
        /// 건조대차기본수량
        /// </summary>
        public int Dry_GV_Qty { get; set; }
        /// <summary>
        /// 소성대차기본수량
        /// </summary>
        public int Heat_GV_Qty { get; set; }
        /// <summary>
        /// 비고
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 사용유무
        /// </summary>
       public string Use_YN { get; set; }
        /// <summary>
        /// 
        /// </summary>
       public DateTime Ins_Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
       public string Ins_Emp { get; set; }
        /// <summary>
        /// 
        /// </summary>
       public DateTime Up_Date { get; set; }
        /// <summary>
        /// 
        /// </summary>
       public string Up_Emp { get; set; }


    }

}
