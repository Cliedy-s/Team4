using Axxen.Util;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class KPI_RPT_002 : Axxen.GridForm
    {
        

        OutputService service = new OutputService();
        List<OutputVO> outList = new List<OutputVO>(); 

        public KPI_RPT_002()
        {
            InitializeComponent();
        }

        private void KPI_RPT_002_Load(object sender, EventArgs e)
        {
            MainDataLoad();
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정명", "Process_Name", true, 100, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "품목명", "Item_Name", true, 100, DataGridViewContentAlignment.MiddleCenter,true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월목표량", "laPlan_Oty", true, 95, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월생산량", "laPrd_Qty", true, 95, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월생산시간(h)", "laPrd_Time", true, 120, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월달성률", "laAttain", true, 95, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "당월목표량", "Plan_Oty", true, 95, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "당월생산량", "Prd_Qty", true, 95, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "당월생산시간(h)", "Prd_Time", true, 120, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "당월달성률", "Attain", true, 95, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월대비증감량", "Inde", true, 90, DataGridViewContentAlignment.MiddleRight);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string month = dtpDate.Value.ToString("yyyyMM");
            string lmonth = dtpDate.Value.AddMonths(-1).ToString("yyyyMM");
            outList = service.GetOutput(month, lmonth);
            dgvMainGrid.DataSource = outList;
        }

        private void KPI_RPT_002_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow); //새로고침
        }

        private void KPI_RPT_002_Deactivate(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow); //새로고침
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            dgvMainGrid.DataSource = null;
        }
    }
}
