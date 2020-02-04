using Axxen.sangyoung;
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

namespace Axxen
{
    public partial class PPS_SCH_001_Report : Form
    {
        DataTable dt = new DataTable();
        public PPS_SCH_001_Report(DataTable data)
        {
            InitializeComponent();
            this.dt = data;
        }

        //public PPS_SCH_001_Report()
        //{
        //    InitializeComponent();
        //}

        private void PPS_SCH_001_Report_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStrip1, ((MainForm)this.MdiParent).toolStrip1);
        }

        private void PPS_SCH_001_Report_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).toolStrip1, toolStrip1);
        }

        private void TsbtnPrint_Click(object sender, EventArgs e)
        {
            ProductionRequest rpt = new ProductionRequest();
            rpt.DataSource = dt;
            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowRibbonPreviewDialog();
            }
        }
    }
}
