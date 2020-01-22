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
    public partial class PRM_PRF_005 : Axxen.GridForm
    {
        List<GV_Work_ItemVO> gvwi;
        GV_Work_ItemService gvwiservice = new GV_Work_ItemService();
        public PRM_PRF_005()
        {
            InitializeComponent();
        }

        private void PRM_PRF_005_Load(object sender, EventArgs e)
        {
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차코드", "GV_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차명", "GV_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차상태", "GV_Status", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차수량", "GV_Qty", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩일자", "Loading_date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩시간", "Loading_time", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩작업장", "Loading_Wc", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩일자", "Unloading_date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩시간", "Unloading_time", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩작업장", "Unloading_Wc", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "요입시간", "In_Time", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "중간시간", "Center_Time", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "요출시간", "Out_Time", true, 100, default, true);

            gvwi = gvwiservice.GetAllGV_Work_Item();
            dgvMainGrid.DataSource = gvwi;
        }
    }
}
