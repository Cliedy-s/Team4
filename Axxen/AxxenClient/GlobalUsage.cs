using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxxenClient
{
    public enum WorkType { Molding, Load, Boxing }
    static class GlobalUsage
    {
        static public WorkType worktype { get; set; } = WorkType.Molding;
        static public string woinichar { get; set; } = "설정안됨";
        static public string workorderno { get; set; } = "설정안됨";
        static public DateTime? WorkorderDate { get; set; } = null;
        static public string ItemName { get; set; } = "설정안됨";
        static public string username { get; set; } = "관리자";
        static public int Prd_Qty { get; set; } = 0;
        static public string Prd_Unit { get; set; } = "설정안됨";

    }
}
