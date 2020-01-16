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
    public partial class PPS_SCH_002 : Axxen.GridManageForm
    {
        public PPS_SCH_002()
        {
            InitializeComponent();
        }

        private void PPS_SCH_002_Load(object sender, EventArgs e)
        {
            MainDataLoad();
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시상태", "Wo_Status", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획일자", "Plan_Date", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획수량", "Plan_Qty", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획수량단위", "Plan_Unit", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일자", "Prd_Date", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업시작시간", "Prd_Starttime", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업종료시간", "Prd_Endtime", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "투입수량", "In_Qty_Main", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "산출수량", "Out_Qty_Main", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산수량", "Prd_Qty", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰번호", "Wo_Req_No", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰순번", "In_Qty_Main", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "프로젝트명", "Project_Name", true, 100);
        }
    }
}
