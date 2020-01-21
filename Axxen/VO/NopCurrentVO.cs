using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class NopCurrentVO
    {
        public long Nop_Seq { get; set; }               // 
        public DateTime Nop_Date { get; set; }              // 
        public DateTime Nop_Happentime { get; set; }    // 
        public DateTime Nop_Canceltime { get; set; }      // 
        public string Wc_Code { get; set; }               // 
        public string Nop_Mi_Code { get; set; }         // 
        public string Nop_Type { get; set; }              // 
        public decimal Nop_Time { get; set; }              // 
        public string Nop_Mi_Name { get; set; }        // 
        public string Nop_Ma_Name { get; set; }       // 
        public string Wc_Name { get; set; }              // 
    }

}
