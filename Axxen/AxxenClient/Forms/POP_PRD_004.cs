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
    public partial class POP_PRD_004 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_004()
        {
            InitializeComponent();
        }

        private void POP_PRD_004_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvPalletList);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "작업지시번호", "WorkOrderNo", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "팔레트번호", "Pallet_No", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "제품", "Item_Name", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "등급", "Boxing_Grade_Code", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "수량", "CurrentQty", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "등급상세", "Grade_Detail_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "사이즈", "Size_Code", false);

        }
        private void GetDatas()
        {
            Pallet_MasterService service = new Pallet_MasterService();
            dgvPalletList.DataSource = service.GetAll();
        }

        private void dgvPalletList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtPalletNo.TextBoxText = dgvPalletList.SelectedRows[0].Cells[1].Value.ToString();
                txtBoxingGrade.TextBoxText = dgvPalletList.SelectedRows[0].Cells[3].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[3].Value.ToString();
                txtBoxingDetailGrade.TextBoxText = dgvPalletList.SelectedRows[0].Cells[5].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[5].Value.ToString();
                txtSizeCode.TextBoxText = dgvPalletList.SelectedRows[0].Cells[6].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[6].Value.ToString();
                txtCurrentQty.TextBoxText = dgvPalletList.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
        private void btnPalletPrint_Click(object sender, EventArgs e)
        {
            Pallet_MasterService service = new Pallet_MasterService();
            if (!service.IsExistPallet(txtPalletNo.TextBoxText))
            {
                MessageBox.Show("팔레트 번호를 확인해주세요");
                return;
            }
            string barcodeno = txtPalletNo.TextBoxText + (new Random(DateTime.Now.Millisecond)).Next(0, 36546).ToString("00000");
            if (!service.UpdateBarcodeNo(txtPalletNo.TextBoxText, barcodeno))
            {
                MessageBox.Show("바코드 생성에 실패했습니다.");
                return;
            }

            PrintPallet(barcodeno, Convert.ToInt32(txtCurrentQty.TextBoxText));
        }
        /// <summary>
        /// 팔레트 바코드 출력
        /// </summary>
        /// <param name="palletno"></param>
        /// <param name="count"></param>
        public void PrintPallet(string palletno, int count)
        {
            // TODO - 팔레트 출력하기
            MessageBox.Show("팔레트 출력합니다..");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Pallet_MasterService service = new Pallet_MasterService();
            //service.DeletePallet(txtPalletNo);
        }
    }
}
