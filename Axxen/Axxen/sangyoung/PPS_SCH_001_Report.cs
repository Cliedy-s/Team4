using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axxen.sangyoung
{
    public partial class PPS_SCH_001_Report : Form
    {
        public PPS_SCH_001_Report(XtraReport rpt)
        {
            InitializeComponent();

            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowRibbonPreviewDialog();
            }
        }
    }
}
