﻿using Axxen.CustomControls;
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
    public partial class POP_PRD_003 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_003()
        {
            InitializeComponent();
        }
        private void POP_PRD_003_Load(object sender, EventArgs e)
        {
            TopPanelSet();
            InitControls();
            GetDatas();
        }
        private void TopPanelSet()
        {
            txtWorkOrderno.TextBoxText = GlobalUsage.WorkOrderNo;
            txtItemName.TextBoxText = GlobalUsage.ItemName;
            txtQty.TextBoxText = GlobalUsage.Prd_Qty.ToString();
            txtUnit.TextBoxText = GlobalUsage.Prd_Unit.ToString();
            txtWcCode.TextBoxText = GlobalUsage.WcCode;
            txtWorkOrderDate.TextBoxText = (GlobalUsage.WorkorderDate == null) ? "": GlobalUsage.WorkorderDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvPalletList);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "팔레트번호", "Pallet_No", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "제품", "Item_Name", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "등급", "Boxing_Grade_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "수량", "CurrentQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "등급상세", "Grade_Detail_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "사이즈", "Size_Code", false);

        }
        private void GetDatas()
        {
            Pallet_MasterService service = new Pallet_MasterService();
            dgvPalletList.DataSource = service.GetAll();
        }
        private void btnPalletPrint_Click(object sender, EventArgs e)
        {
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                DateTime now = DateTime.Now;
                Random rand = new Random(now.Millisecond);
                Pallet_MasterService service = new Pallet_MasterService();
                if (!service.IsExistPallet(txtPalletNo.TextBoxText))
                {
                    bool IsSuccess = service.InsertPallet(
                        new VO.PalletVO()
                        {
                            Pallet_No = txtPalletNo.TextBoxText,
                            Barcode_No = DateTime.Now.Date.ToString("yyyyMMddHHmmssffffff"),
                            WorkOrderNo = GlobalUsage.WorkOrderNo,
                            CurrentQty = Convert.ToInt32(txtPrintPallet.TextBoxText),
                            Grade_Detail_Code = txtBoxingDegailGrade.TextBoxText,
                            Boxing_Grade_Code = txtBoxingGrade.TextBoxText,
                            Size_Code = "3",
                        });
                    if (IsSuccess)
                    {
                        MessageBox.Show("팔레트가 생성되었습니다.");
                        GetDatas();
                    }
                    else
                    {
                        MessageBox.Show("팔레트 생성에 실패하였습니다.");
                        return;
                    }
                }
                PrintPallet(txtPalletNo.TextBoxText, Convert.ToInt32(txtPrintPallet.TextBoxText));
            }
            else
            {
                MessageBox.Show("작업을 시작해주세요");
            }
        }
        /// <summary>
        /// 팔레트 바코드 출력
        /// </summary>
        /// <param name="palletno"></param>
        /// <param name="count"></param>
        public void PrintPallet(string palletno, int count)
        {
            Pallet_MasterService service = new Pallet_MasterService();
            DataTable table = service.GetPalletToDT(palletno);
            if (table != null)
            {
                for (int i = 0; i < count; i++)
                {
                    DataRow dr = table.NewRow();
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        dr[k] = table.Rows[0][k];
                    }
                    table.Rows.Add(dr);
                }

                BarcodeReport rpt = new BarcodeReport();
                rpt.DataSource = table;

                ReportPreview frm = new ReportPreview(rpt);
            }

        }
        private void dgvPalletList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtPalletNo.TextBoxText = dgvPalletList.SelectedRows[0].Cells[0].Value.ToString();
                txtBoxingGrade.TextBoxText = dgvPalletList.SelectedRows[0].Cells[2].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[2].Value.ToString();
                txtBoxingDegailGrade.TextBoxText = dgvPalletList.SelectedRows[0].Cells[4].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[4].Value.ToString();
                txtSizeCode.TextBoxText = dgvPalletList.SelectedRows[0].Cells[5].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[5].Value.ToString();
                txtPrintPallet.TextBoxText = dgvPalletList.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
