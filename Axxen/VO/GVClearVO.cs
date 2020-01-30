using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    /// <summary>
    /// 대차비우기vo
    /// </summary>
    public class GVClearVO
    { 
        public string GV_Code { get; set; }           // 대차코드
        public int Clear_Qty { get; set; }          // 대차비우기수량
        public string Clear_Cause { get; set; }       // 대차비우기원인
        public string Clear_wc { get; set; }           // 대상작업장
        public string Clear_Item { get; set; }         // 대상작업장품목
        public string Up_Emp { get; set; }            // 최종수정자
    }
}
