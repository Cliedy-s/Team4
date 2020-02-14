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
    public partial class KPI_RPT_003 : Axxen.GridForm
    {
        OutputService service = new OutputService();
        List<BoxPackageVO> boxList = new List<BoxPackageVO>();

        public KPI_RPT_003()
        {
            InitializeComponent();
        }

        private void KPI_RPT_003_Load(object sender, EventArgs e)
        {
            MainDataLoad();
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 250,DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "품목명", "Item_Name", true, 100,DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "포장일자", "In_Date", true, 250, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "일일 포장량", "F_In_Qty", true, 170, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "누계 포장량", "Qty_Sum", true, 170, DataGridViewContentAlignment.MiddleRight);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string month = dtpDate.Value.ToString("yyyyMM");
            boxList = service.GetBoxPackage(month);
            dgvMainGrid.DataSource = boxList;
        }

        private void KPI_RPT_003_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow); //새로고침
        }

        private void KPI_RPT_003_Deactivate(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow); //새로고침
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            dgvMainGrid.DataSource = null;
        }
    }
}
