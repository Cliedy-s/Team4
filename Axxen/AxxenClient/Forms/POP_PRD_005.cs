using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_005 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_005()
        {
            InitializeComponent();
        }
        private void POP_PRD_005_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvInPallet);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "작업지시번호", "WorkOrderNo", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "팔레트번호", "Pallet_No", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "제품", "Item_Name", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "등급", "Boxing_Grade_Code", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "수량", "CurrentQty", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "등급상세", "Grade_Detail_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "사이즈", "Size_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "계획날짜", "Plan_Date", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "제품", "Item_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvInPallet, "작업장코드", "Wc_Code", false);
        }
        private void GetDatas()
        {
            Pallet_MasterService service = new Pallet_MasterService();
            dgvInPallet.DataSource = service.GetPalletTodayIn();
        }
        private void dgvInPallet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtPalletNo.TextBoxText = dgvInPallet.SelectedRows[0].Cells[1].Value.ToString();
                txtWorkorderNo.TextBoxText = dgvInPallet.SelectedRows[0].Cells[0].Value.ToString();
                txtWorkorderDate.TextBoxText = dgvInPallet.SelectedRows[0].Cells[7].Value.ToString();
                txtItemCode.TextBoxText = dgvInPallet.SelectedRows[0].Cells[8].Value.ToString();
                txtWcCode.TextBoxText = dgvInPallet.SelectedRows[0].Cells[9].Value.ToString();
                txtBoxingGrade.TextBoxText = dgvInPallet.SelectedRows[0].Cells[3].Value == null ? "" : dgvInPallet.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            Pallet_MasterService service = new Pallet_MasterService();
            if (!service.IsExistPallet(txtPalletNo.TextBoxText))
            {
                MessageBox.Show("팔레트 번호를 확인해주세요");
                return;
            }
            bool isSuccess = service.InputPallet(GlobalUsage.username, txtWorkorderNo.TextBoxText, txtPalletNo.TextBoxText);
            if (!isSuccess)
            {
                MessageBox.Show("입고에 실패하였습니다.");
                return;
            }
            GetDatas();

        }
    }
}
