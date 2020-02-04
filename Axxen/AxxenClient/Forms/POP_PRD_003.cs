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
            txtWcCode.TextBoxText = GlobalUsage.WcCode;
            txtWorkOrderDate.TextBoxText = (GlobalUsage.WorkorderDate == null) ? "": GlobalUsage.WorkorderDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvPalletList);
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
        private void btnPalletPrint_Click(object sender, EventArgs e)
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
            PrintPallet(service.GetBarcodeNo(txtPalletNo.TextBoxText), Convert.ToInt32(txtPrintPallet.TextBoxText));
        }
        /// <summary>
        /// 팔레트 바코드 출력
        /// </summary>
        /// <param name="palletno"></param>
        /// <param name="count"></param>
        public void PrintPallet(string palletno, int count)
        {
//            Pallet_MasterService service = new Pallet_MasterService();
//            List<PalletTodayInVO> list =  service.GetPalletInfo(palletno);
//            DataSet ds = new DataSet();
//            using (SqlConnection conn = new SqlConnection(connstr))
//            {
//                conn.Open();
//                SqlDataAdapter adapter = new SqlDataAdapter(
//@"SELECT Right('00000' + cast([BarcodeID] as varchar), '5') BarcodeID, ProductName, QuantityPerUnit, Qty
//from BarcodeOutput bo, Products p
//where bo.ProductID = p.ProductID
//	and BarcodeID in (" + chkbarcodeid + ") ORDER BY BarcodeID desc; ", conn);
//                adapter.Fill(ds, "BarcodeList");
//            }

//            BarcodeReport rpt = new BarcodeReport();
//            rpt.DataSource = ds.Tables["BarcodeList"];
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
