﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class WorkerVO
    { 
        public string Wc_Code { get; set; }                     // 작업장코드
        public string User_ID { get; set; }                       // 사용자ID
        public DateTime Allocation_datetime { get; set; }   // 할당일시
        public string User_Name { get; set; }                  // 사용자명
    }
    public class WorkerAllocatableVO
    {
        public string Wc_Code { get; set; }                      // 작업장코드
        public string User_ID { get; set; }                        // 사용자ID
        public string User_Name { get; set; }                   // 사용자명
        public string Default_Process_Code { get; set; }      // 기본공정코드
        public string Wc_Name { get; set; }                     // 작업장명
    }
}