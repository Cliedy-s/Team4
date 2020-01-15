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
    public partial class KPI_RPT_001 : Axxen.GridForm
    {
        public KPI_RPT_001()
        {
            InitializeComponent();
        }

        private void KPI_RPT_001_Load(object sender, EventArgs e)
        {
            MainDataLoad();
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일자", "Prd_Date", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정명", "Process_Name", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산시간", "", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "시간당생산량", "", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "가스사용량", "Dorm_Gas", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비가동시간", "Nop_Time", true, 90);
            
        }
    }
}
