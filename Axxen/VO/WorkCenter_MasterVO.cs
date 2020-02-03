using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WorkCenter_MasterVO
    { 
        public string Wc_Code { get; set; }                 // 작업장코드
        public string Wc_Name { get; set; }                // 작업장명
        public string Wc_Group { get; set; }               // 작업장그룹  x
        public string Process_Code { get; set; }           // 공정코드
      public string Auto_Wo_YN { get; set; }            // 자동작업지시여부  x
    public string Auto_Start_YN { get; set; }          // 자동작업지시시작여부  x
   public string ERP_IF_YN { get; set; }               // ERP인터페이스여부  x
        public string Wo_Status { get; set; }               // 비가동상태  
  public string Nop_Auto_YN { get; set; }           // 비가동자동발생여부  x
  public DateTime Nop_Check_Time { get; set; }  // 비가동자동발생시간  x
   public DateTime Last_Cnt_Time { get; set; }      // 최종실적처리시간
  public string Gas_UseYN { get; set; }              // Gas사용여부 x
        public string Prd_Req_Type { get; set; }           // 실적등록유형
        public string Pallet_YN { get; set; }                 // 팔렛생성여부
        public string Item_Code { get; set; }               // 최종작업품목
        public string Prd_Unit { get; set; }                  // 실적단위
        public string Mold_Setup_YN { get; set; }        // 금형장착여부
    public string In_Qty_Auto_YN { get; set; }        // 투입수량자동처리여부 x
   public string Wo_Ini_Char { get; set; }             // 작업지시이니셜 x
        public string Use_YN { get; set; }                   // 사용여부
        public string Remark { get; set; }                   // 비고

        public string Process_name { get; set; } //공정이름

    }

    public class WorkCenter_Master2VO
    {
        public string Wc_Code { get; set; }                 // 작업장코드
        public string Wc_Name { get; set; }                // 작업장명
        public string Process_Code { get; set; }           // 공정코드
        public string Process_name { get; set; } //공정이름
        public string Wo_Status { get; set; }               // 비가동상태  
        public DateTime Last_Cnt_Time { get; set; }      // 최종실적처리시간
        public string Prd_Req_Type { get; set; }           // 실적등록유형
        public string Pallet_YN { get; set; }                 // 팔렛생성여부
        public string Item_Code { get; set; }               // 최종작업품목
        public string Prd_Unit { get; set; }                  // 실적단위
        public string Mold_Setup_YN { get; set; }        // 금형장착여부
        public string Use_YN { get; set; }                   // 사용여부
        public string Remark { get; set; }                   // 비고

        public string Ins_Emp { get; set; }


    }
}
