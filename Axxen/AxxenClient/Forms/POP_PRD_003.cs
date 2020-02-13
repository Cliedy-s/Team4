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
            txtWcCode.TextBoxText = GlobalUsage.WcName;
            txtWorkOrderDate.TextBoxText = (GlobalUsage.WorkorderDate == null) ? "": GlobalUsage.WorkorderDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvPalletList);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "팔레트번호", "Pallet_No", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "제품", "Item_Name", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvPalletList, "등급", "Grade_Detail_Name", true, 200, DataGridViewContentAlignment.MiddleCenter);
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
                { // 팔레트가 존재하지않으면
                    // insert 시도
                    bool IsSuccess = service.InsertPallet(
                        new VO.PalletVO()
                        {
                            Pallet_No = txtPalletNo.TextBoxText,
                            Barcode_No = DateTime.Now.Date.ToString("yyyyMMddHHmmssffffff"),
                            WorkOrderNo = GlobalUsage.WorkOrderNo,
                            CurrentQty = Convert.ToInt32(txtPrintPallet.TextBoxText),
                            Grade_Detail_Code = txtBoxingGradeDetail.CodeText,
                            Boxing_Grade_Code = txtBoxingGrade.TextBoxText,
                            Size_Code = txtSizeCode.TextBoxText,
                        });
                    if (IsSuccess)
                    { // 성공
                        Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 팔레트를 생성함");
                        MessageBox.Show("팔레트가 생성되었습니다.");
                        GetDatas();
                    }
                    else
                    { // 실패
                        Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 팔레트 생성에 실패함");
                        MessageBox.Show("팔레트 생성에 실패하였습니다.");
                        return;
                    }
                }
                else
                { // 팔레트가 존재하면
                    service.UpdatePallet(txtPalletNo.TextBoxText, Convert.ToInt32(txtPrintPallet.TextBoxText));
                    GetDatas();
                }
                PrintPallet(txtPalletNo.TextBoxText, Convert.ToInt32(txtPrintPallet.TextBoxText));
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업을 시작하지 않고 팔레트 생성하려함");
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
            Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 팔레트({palletno}) 바코드 {count}개를 인쇄함");
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
                txtBoxingGradeDetail.TextBoxText = dgvPalletList.SelectedRows[0].Cells[4].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[4].Value.ToString();
                txtSizeCode.TextBoxText = dgvPalletList.SelectedRows[0].Cells[5].Value == null ? "" : dgvPalletList.SelectedRows[0].Cells[5].Value.ToString();
                txtPrintPallet.TextBoxText = dgvPalletList.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void txtBoxingGradeDetail_searchclick(object sender, SearchFormClosingArgs e)
        {
            txtBoxingGradeDetail.CodeText = e.ResultCode;
            txtBoxingGradeDetail.TextBoxText = e.ResultName;
            BoxingGrade_Detail_MasterService service = new BoxingGrade_Detail_MasterService();
            txtBoxingGrade.TextBoxText = service.GellBoxing_Grade(e.ResultCode);
        }

        private void txtBoxingGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
