using Axxen.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axxen
{
    public partial class KPI_RPT_003 : Axxen.GridForm
    {
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
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정명", "Process_Name", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월목표량", "", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월생산량", "", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월생산시간", "", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월달성률", "", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "당월목표량", "", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "당월생산량", "", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "당월생산시간", "", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "당월달성률", "", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "전월대비증감량", "", true, 90);
        }
    }
}
