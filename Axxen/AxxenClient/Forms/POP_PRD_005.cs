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
        private void btnIn_Click(object sender, EventArgs e)
        {
            Pallet_MasterService service = new Pallet_MasterService();
            if (!service.IsExistPallet(txtPalletNo.TextBoxText))
            {
                MessageBox.Show("팔레트 번호를 확인해주세요");
                return;
            }
            bool isSuccess = service.InputPallet(GlobalUsage.Username, txtWorkorderNo.TextBoxText, txtPalletNo.TextBoxText);
            if (!isSuccess)
            {
                MessageBox.Show("입고에 실패하였습니다.");
                return;
            }
            GetDatas();

        }

        private void txtPalletNo_searchclick(object sender, EventArgs e)
        {
            Pallet_MasterService service = new Pallet_MasterService();
            PalletTodayInVO item = service.GetPalletInfo(txtPalletNo.TextBoxText);

            txtPalletNo.TextBoxText = item.Pallet_No;
            txtWorkorderNo.TextBoxText = item.Workorderno;
            txtWorkorderDate.TextBoxText = item.Plan_Date.ToString("yyyy-MM-dd hh:mm:ss");
            txtItemCode.TextBoxText = item.Item_Code;
            txtWcCode.TextBoxText = item.Wc_Code;
            txtBoxingGrade.TextBoxText = item.Boxing_Grade_Code;
        }
    }
}
