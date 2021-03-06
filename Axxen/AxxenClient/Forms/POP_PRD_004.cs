﻿using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
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
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "제품", "Item_Name", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "등급", "Boxing_Grade_Code", true, 200, DataGridViewContentAlignment.MiddleCenter);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "수량", "CurrentQty", true, 100, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "등급상세", "Grade_Detail_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "사이즈", "Size_Code", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "등급상세명", "Grade_Detail_Name", false);

            dtpTodate.Value = DateTime.Now;
            dtpFromdate.Value = DateTime.Now.AddDays(-7);
        }
        private void GetDatas()
        {
            Pallet_MasterService service = new Pallet_MasterService();
            dgvPalletList.DataSource = service.GetNotInputed(GlobalUsage.WorkOrderNo);
        }
        private void dgvPalletList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtPalletNo.TextBoxText = dgvPalletList.SelectedRows[0].Cells[1].Value.ToString();
                txtBoxingGrade.TextBoxText = dgvPalletList.SelectedRows[0].Cells[3].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[3].Value.ToString();
                txtBoxingGradeDetail.TextBoxText = dgvPalletList.SelectedRows[0].Cells[7].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[7].Value.ToString();
                txtBoxingGradeDetail.CodeText = dgvPalletList.SelectedRows[0].Cells[5].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[5].Value.ToString();
                txtSizeCode.TextBoxText = dgvPalletList.SelectedRows[0].Cells[6].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[6].Value.ToString();
                txtCurrentQty.TextBoxText = dgvPalletList.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
        /// <summary>
        /// 팔레트 바코드 재발행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBarcodeRecreate(object sender, EventArgs e)
        {
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                Pallet_MasterService service = new Pallet_MasterService();
                if (!service.IsExistPallet(txtPalletNo.TextBoxText, GlobalUsage.WorkOrderNo))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 존재하지 않는 팔레트({txtPalletNo.TextBoxText})의 바코드를 재발행하려함");
                    MessageBox.Show("팔레트 번호를 확인해주세요");
                    GetDatas();
                    return;
                }
                if (service.IsPalletInput(txtPalletNo.TextBoxText, GlobalUsage.WorkOrderNo))
                {
                    Program.Log.WriteWarn($"{GlobalUsage.UserName}이(가) 이미 입고한 팔레트를 재발행하려함");
                    MessageBox.Show("이미 입고한 팔레트입니다.");
                    return;
                }

                string barcodeno = DateTime.Now.ToString("yyyyMMddHHmmss") + "B";
                if (!service.UpdateBarcodeNo(txtPalletNo.TextBoxText, GlobalUsage.WorkOrderNo, barcodeno))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 팔레트({txtPalletNo.TextBoxText})의 바코드를 {barcodeno}로재발행 하려했지만 실패함");
                    MessageBox.Show("바코드 재발행에 실패했습니다.");
                    return;
                }

                GetDatas();
                PrintPallet(txtPalletNo.TextBoxText, Convert.ToInt32(txtCurrentQty.TextBoxText));
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업을 시작하지 않아 팔레트 재발행에 실패함");
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
            Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 팔레트({palletno})의 바코드를 ({count})개 재발행함");
            MessageBox.Show("팔레트 출력합니다..");
            Pallet_MasterService service = new Pallet_MasterService();
            DataTable table = service.GetPalletToDT(palletno, GlobalUsage.WorkOrderNo, count);
            if (table != null)
            {
                BarcodeReport rpt = new BarcodeReport();
                rpt.DataSource = table;

                ReportPreview frm = new ReportPreview(rpt);
            }
        }
        /// <summary>
        /// 팔레트 삭제 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 삭제하시겠습니까?", "팔레트삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Pallet_MasterService service = new Pallet_MasterService();
                if (service.IsPalletInput(txtPalletNo.TextBoxText, GlobalUsage.WorkOrderNo))
                {
                    Program.Log.WriteWarn($"{GlobalUsage.UserName}이(가) 이미 입고한 팔레트를 삭제하려함");
                    MessageBox.Show("이미 입고한 팔레트입니다.");
                    return;
                }

                if (service.DeletePallet(txtPalletNo.TextBoxText, GlobalUsage.WorkOrderNo))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 팔레트({txtPalletNo.TextBoxText}) 삭제에 성공함");
                    MessageBox.Show("팔레트 제거에 성공하였습니다.");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 존재하지 않는 팔레트({txtPalletNo.TextBoxText})를 삭제하려함");
                    MessageBox.Show("팔레트 제거에 실패하였습니다.");
                }
            }
        }
        /// <summary>
        /// 팔레트 조회
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            ProgressForm frm = new ProgressForm(() => { btnSearchByDate.Invoke(new Action(() => { Thread.Sleep(500); GetSearch(); })); });
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
        private void GetSearch()
        {
            Pallet_MasterService service = new Pallet_MasterService();
            dgvPalletList.DataSource = service.GetAllByDateTime(GlobalUsage.WorkOrderNo ,dtpFromdate.Value, dtpTodate.Value);
        }

        private void txtBoxingGradeDetail_searchclick(object sender, SearchFormClosingArgs e)
        {
            txtBoxingGradeDetail.CodeText = e.ResultCode;
            txtBoxingGradeDetail.TextBoxText = e.ResultName;
            BoxingGrade_Detail_MasterService service = new BoxingGrade_Detail_MasterService();
            txtBoxingGrade.TextBoxText = service.GellBoxing_Grade(e.ResultCode);
        }

        private void btnKeypad_Click(object sender, EventArgs e)
        {
            KeypadForm frm = new KeypadForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormSendEvent += new KeypadForm.FormSendDataHandler(DieaseUpdateEventMethod);
            frm.Show();
        }
        private void DieaseUpdateEventMethod(object sender)
        {
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call
            txtCurrentQty.TextBoxText = sender.ToString();
        }
    }
}
