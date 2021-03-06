﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class GVVO
    {
        public string GV_Code { get; set; }        // 대차코드
        public string GV_Name { get; set; }       // 대차명
        public string GV_Group { get; set; }       // 대차그룹
        public string GV_Status { get; set; }       // 대차상태
        public string Unloading_Wc { get; set; } // 언로딩작업장
    }

    public class GVMasterVO

    {
        public string GV_Code { get; set; }        // 대차코드
        public string GV_Name { get; set; }       // 대차명
        public string GV_GroupCode { get; set; }       // 대차그룹코드
        public string GV_Group { get; set; }       // 대차그룹 명
        public string GV_Status { get; set; } //대차상태

        public string Unloading_Wc { get; set; } //언로딩작업장

        public string Use_YN { get; set; }
        public DateTime Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public DateTime Up_Date { get; set; }
        public string Up_Emp { get; set; }

    }

    public class GVWorkItemVO
    {
        public string GV_Code { get; set; }        // 대차코드
        public string GV_Name { get; set; }       // 대차명
        public string GV_Group { get; set; }       // 대차그룹
        public string GV_Status { get; set; }       // 대차상태
        public string Unloading_Wc { get; set; } // 언로딩작업장
        public string WorkOrderNo { get; set; } // 현재작업지시
        public int Prd_Qty { get; set; }              // 생산수량
        public string Prd_Unit { get; set; }         // 생산수량단위
        public string Item_Code { get; set; }      // 품목코드
        public string Item_Name { get; set; }     // 픔목명
    }
    public class GVWorkVO
    {
        public string GV_Code { get; set; }        // 대차코드
        public string GV_Name { get; set; }       // 대차명
        public string GV_Group { get; set; }       // 대차그룹
        public string GV_Status { get; set; }       // 대차상태
        public string Unloading_Wc { get; set; } // 언로딩작업장
        public string WorkOrderNo { get; set; } // 현재작업지시
        public int Prd_Qty { get; set; }              // 생산수량
        public string Prd_Unit { get; set; }         // 생산수량단위
    }
    public class GVLoadingTimeVO
    {
        public string GV_Code { get; set; }        // 대차코드
        public string GV_Name { get; set; }       // 대차명
        public string GV_Group { get; set; }       // 대차그룹
        public string GV_Status { get; set; }       // 대차상태
        public string Unloading_Wc { get; set; } // 언로딩작업장
        public string WorkOrderNo { get; set; } // 현재작업지시
        public int Prd_Qty { get; set; }              // 생산수량
        public string Prd_Unit { get; set; }         // 생산수량단위
        public DateTime Loading_time { get; set; } // 로딩시간
    }


}
