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
    public partial class PRM_PRF_001 : Axxen.GridForm
    {
        List<WorkOrder_J_WC_ItmeVO> wowc;
        WorkOrder_Service woservice = new WorkOrder_Service();

        public PRM_PRF_001()
        {
            InitializeComponent();
        }

        private void PRM_PRF_001_Load(object sender, EventArgs e)
        {
            #region 그리드뷰 설정
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "번호", "Num", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시상태", "Wo_Status", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "투입수량", "In_Qty_Main", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "산출수량", "Out_Qty_Main", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산수량", "Prd_Qty", true, 100, default, true);

            wowc = woservice.GetAll_WorkOrder_Item_WC();
            dgvMainGrid.DataSource = wowc;
            #endregion

            aDateTimePicker1.Value = DateTime.Now.AddDays(-7);
            aDateTimePicker2.MaxDate = DateTime.Now;          
        }
    }
}
