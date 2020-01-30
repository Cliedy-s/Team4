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
        ProductionRequest rpt = new ProductionRequest();
        public PPS_SCH_001_Report(XtraReport rpt)
        {
            InitializeComponent();

            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowRibbonPreviewDialog();
            }
        }

        public PPS_SCH_001_Report()
        {
            InitializeComponent();
        }

        private void PPS_SCH_001_Report_Load(object sender, EventArgs e)
        {
            
        }

        private void PrintFormShow(object sender, EventArgs e)
        {
            
        }

        private void PPS_SCH_001_Report_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).MyPrintEvent += new EventHandler(this.PrintFormShow);
            ToolStripManager.Merge(toolStrip1, ((MainForm)this.MdiParent).toolStrip1);
        }

        private void PPS_SCH_001_Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).toolStrip1, toolStrip1);
        }

        private void PPS_SCH_001_Report_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).toolStrip1, toolStrip1);
        }
    }
}
