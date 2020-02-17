using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace AxxenClient
{
    public enum WorkType { Molding, Load, Boxing }
    static class GlobalUsage
    {
        static public string UserName { get; set; }
        static public string UserID { get; set; }
        static public WorkType WorkType { get; set; } = WorkType.Molding;
        static string wccode;
        static public string WcCode { get { return wccode; } set {
                try
                {
                    wccode = value;
                    WorkCenter_MasterService service = new WorkCenter_MasterService();
                    WorkCenter_Master2VO item = service.GetAll_WorkCenter_Master(GlobalUsage.WcCode);

                    GlobalUsage.WcName = item.Wc_Name;
                    GlobalUsage.ProcessCode = item.Process_Code;
                    GlobalUsage.ProcessName = item.Process_name;
                    switch (item.Wc_Code.Substring(item.Wc_Code.Length-1))
                    {
                        case "2":
                            GlobalUsage.WorkType = WorkType.Molding;
                            break;
                        case "4":
                            GlobalUsage.WorkType = WorkType.Load;
                            break;
                        case "5":
                            GlobalUsage.WorkType = WorkType.Boxing;
                            break;
                    }
                }
                catch
                {
                    Environment.Exit(0);
                }
            } }
        static public string WcName { get; set; } = null;
        static public string ProcessCode { get; set; } = null;
        static public string ProcessName { get; set; } = null;

        static public string WorkOrderNo { get; set; } = "설정안됨";
        static public DateTime? WorkorderDate { get; set; } = null;
        static public string ItemName { get; set; } = "설정안됨";
        static public string ItemCode { get; set; } = null;
        static public int Prd_Qty { get; set; } = 0;
        static public int Out_Qty { get; set; } = 0;
        static public string Prd_Unit { get; set; } = "설정안됨";
    }
}
