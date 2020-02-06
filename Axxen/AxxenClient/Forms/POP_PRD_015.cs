using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_015 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_015()
        {
            InitializeComponent();
        }

        private void POP_PRD_015_Load(object sender, EventArgs e)
        {
            InitControls();
            TopPanelSet();
            GetDatas();
        }
        private void TopPanelSet()
        {
            txtWorkOrderno.TextBoxText = GlobalUsage.WorkOrderNo;
            txtItemName.TextBoxText = GlobalUsage.ItemName;
            txtQty.TextBoxText = GlobalUsage.Prd_Qty.ToString();
            txtUnit.TextBoxText = GlobalUsage.Prd_Unit.ToString();
            txtWcCode.TextBoxText = GlobalUsage.WcCode;
            txtWorkOrderDate.TextBoxText = (GlobalUsage.WorkorderDate == null) ? "" : GlobalUsage.WorkorderDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void InitControls()
        {
            lblInspectcode.Text = lblItemCode.Text = lblProcesscode.Text = "";
            //lblInspectcode.Visible = lblItemCode.Visible = lblProcesscode.Visible = false;
            InitControlUtil.SetPOPDGVDesign(dgvInspect);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "측정항목", "Inspect_name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "USL", "USL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "SL", "SL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "LSL", "LSL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "품목코드", "Item_Code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "공정코드", "Process_code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "항목코드", "Inspect_code", false, 100);


            InitControlUtil.SetPOPDGVDesign(dgvInspectMeasure);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspectMeasure, "측정값", "Inspect_val", true, 120, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspectMeasure, "측정일시", "Inspect_datetime", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspectMeasure, "조건순번", "Inspect_measure_seq", false, 200);
            dgvInspectMeasure.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }
        private void GetDatas()
        {
            Inspect_Spec_MasterService sservice = new Inspect_Spec_MasterService();
            dgvInspect.DataSource = sservice.GetAll();
        }
        private void SearchData()
        {
            Inspect_Measure_HistoryService mservice = new Inspect_Measure_HistoryService();
            dgvInspectMeasure.DataSource = mservice.GetAll(lblItemCode.Text, lblProcesscode.Text, lblInspectcode.Text);
        }

        private void dgvInspect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblItemCode.Text = dgvInspect.SelectedRows[0].Cells[4].Value.ToString();
            lblProcesscode.Text = dgvInspect.SelectedRows[0].Cells[5].Value.ToString();
            lblInspectcode.Text = dgvInspect.SelectedRows[0].Cells[6].Value.ToString();

            SearchData();
        }

        private void btnInsertMeasure_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblInspectcode.Text))
            {
                Inspect_Measure_HistoryService service = new Inspect_Measure_HistoryService();
                InspectHistoryVO item = new InspectHistoryVO();
                item.Inspect_code = lblInspectcode.Text;
                item.Item_code = lblItemCode.Text;
                item.Inspect_val = Convert.ToDecimal(txtMeasure.TextBoxText);
                item.Process_code = lblProcesscode.Text;
                item.Workorderno = GlobalUsage.WorkOrderNo;
                if (service.InsertInspect_Measure(item, GlobalUsage.UserID))
                {
                    txtMeasure.TextBoxText = "";
                    SearchData();
                }
                else MessageBox.Show("입력할 수 없는 항목입니다.");
            }
        }

        private void btnDeleteMeasure_Click(object sender, EventArgs e)
        {
            if (dgvInspectMeasure.SelectedRows.Count > 0)
            {
                Inspect_Measure_HistoryService service = new Inspect_Measure_HistoryService();
                if (service.DeleteInspect_MeasureBySeq(Convert.ToInt32(dgvInspectMeasure.SelectedRows[0].Cells[2].Value))) SearchData();
                else MessageBox.Show("삭제할 수 없는 항목입니다.");
            }
        }
    }
}
