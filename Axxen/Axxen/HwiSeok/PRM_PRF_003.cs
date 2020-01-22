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
    public partial class PRM_PRF_003 : Axxen.GridForm
    {
        List<Item_Goods_HistoryVO> igh;
        ItemMaster_Service imservice = new ItemMaster_Service();
        public PRM_PRF_003()
        {
            InitializeComponent();
        }

        private void PRM_PRF_003_Load(object sender, EventArgs e)
        {
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일자", "Prd_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시상태", "Wo_Status", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "팔레트번호", "Pallet_No", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "입고수량", "Plan_Qty", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "마감시각", "Worker_CloseTime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "취소시각", "Close_CancelTime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "ERP 업로드여부", "Upload_Flag", true, 100, default, true);

            igh = imservice.GetworkOrder_Item_Goods();
            dgvMainGrid.DataSource = igh;

        }

        private void aDateTimePickerSearch2_btnDateTimeSearch_Click(object sender, EventArgs args)
        {
            igh = imservice.GetDatePicker_work_ltem_Goods(aDateTimePickerSearch2.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch2.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = igh;
        }
    }
}
