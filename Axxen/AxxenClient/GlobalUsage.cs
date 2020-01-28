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
        static public WorkType worktype { get; set; }
        static public string woinichar { get; set; }
        static public string workorderno { get; set; }
        static public string username { get; set; }
    }
}
