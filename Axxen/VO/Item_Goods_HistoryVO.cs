using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    class Item_Goods_HistoryVO //KPI_RPT_004
    {
        public string Item_Code { get; set; } //품목코드
        public string Item_Name { get; set; } //품목명
        public string In_Date { get; set; } //입고일자
        public string In_Qty { get; set; } //생산수량
    }
}
