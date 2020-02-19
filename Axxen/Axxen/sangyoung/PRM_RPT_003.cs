using Axxen.sangyoung;
using Axxen.Util;
using DevExpress.XtraReports.UI;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class PRM_RPT_003 : Axxen.ReportForm
    {
        List<Goods_In_HistoryPackageVO> boxlist;
        Goods_In_HistorySercive service = new Goods_In_HistorySercive();
        DataTable dt = new DataTable();
        PackingLog rpt = new PackingLog();

        public delegate void threadDelegate();
        threadDelegate threadmethod;

        public PRM_RPT_003()
        {
            InitializeComponent();
        }

        private void PRM_RPT_003_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStrip1, ((MainForm)this.MdiParent).toolStrip1); //출력버튼추가
            toolStrip1.Visible = false;
        }

        private void PRM_RPT_003_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).toolStrip1);
        }


        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            documentViewer1.DocumentSource = null;
           
        }

        private void ReportBinding()
        {
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            boxlist = service.GetBoxingHistory(date);
            
            dt = ListToDataTable.ToDataTable(boxlist);
            rpt.DataSource = dt;
            rpt.Parameters["Ins_Date"].Value = dtpDate.Value.ToString("yyyy-MM-dd");
            rpt.Parameters["Ins_Date"].Visible = false; //파라미터 바로 넘기기
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }

      
        private void TsbtnPrint_Click(object sender, EventArgs e)
        {
            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowRibbonPreviewDialog();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            threadmethod += ReportBinding;
            using (WaitForm waitfrm = new WaitForm(() => { Thread.Sleep(2000); dtpDate.Invoke(threadmethod); }))
            {
                waitfrm.ShowDialog(this);
            }
        }
    }
}
