﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Def_MaVO
    {
        /// <summary>
        /// 불량현상대분류코드
        /// </summary>
        public string Def_Ma_Code { get; set; }
        /// <summary>
        /// 불량현상대분류명
        /// </summary>
        public string Def_Ma_Name { get; set; }
        public string Use_YN { get; set; }
        public DateTime Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public DateTime Up_Date { get; set; }
        public string Up_Emp { get; set; }

    }
}
