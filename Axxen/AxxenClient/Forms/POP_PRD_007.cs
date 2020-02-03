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
    public partial class POP_PRD_007 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_007()
        {
            InitializeComponent();
        }

        private void POP_PRD_007_Load(object sender, EventArgs e)
        {
            InitControls();
            TopPanelSet();
            GetDatas();

            txtLoading.TextBoxText = dgvGVFrom.SelectedRows[0].Cells[3].Value.ToString();
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
            InitControlUtil.SetPOPDGVDesign(dgvGVTo);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVTo, "대차코드", "GV_Code", true, 80);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVTo, "대차명", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);

            InitControlUtil.SetPOPDGVDesign(dgvGVFrom);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "대차코드", "GV_Code", true, 80);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "대차명", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "적재시각", "Loading_time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "수량", "Loading_Qty", true, 50);
            dgvGVFrom.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            // 해당 작업지시에서 생성한 모든 대차
            // TODO - 조건에 맞게 변경하기
            //dgvGVFrom.DataSource = service.GetGVCurrentStatus(wccode:GlobalUsage.WcCode, workorderno:GlobalUsage.WorkOrderNo, gvStatus:"적재");
            dgvGVFrom.DataSource = service.GetGVCurrentStatus(gvStatus: "적재");
            // 해당 작업장의 모든 빈대차를 가져온다.
            //dgvGVTo.DataSource = service.GetGVCurrentStatus(wccode: GlobalUsage.WcCode, gvStatus: "빈대차");
            dgvGVTo.DataSource = service.GetGVCurrentStatus(gvStatus: "빈대차");
        }
        private void btnToSearch_Click(object sender, EventArgs e)
        { // 검색
            GV_Current_StatusService service = new GV_Current_StatusService();
            // TODO - 조건에 맞게 변경하기
            dgvGVTo.DataSource = service.GetGVCurrentStatus(gvStatus: "빈대차", gvName:txtToGVSearch.TextBoxText);
        }
        private void btnFromSearch_Click(object sender, EventArgs e)
        { // 검색
            GV_Current_StatusService service = new GV_Current_StatusService();
            // TODO - 조건에 맞게 변경하기
            dgvGVFrom.DataSource = service.GetGVCurrentStatus(gvStatus: "적재", gvName:txtFromGVSearch.TextBoxText);
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string loadinggvcode = dgvGVTo.SelectedRows[0].Cells[0].Value.ToString();
            string unloadgvcode = dgvGVFrom.SelectedRows[0].Cells[0].Value.ToString();
            GV_HistoryService service = new GV_HistoryService();

            // 옮겨타기
            if (service.UpdateMoveGvItem(unloadgvcode, loadinggvcode, Convert.ToInt32(txtLoading.TextBoxText), GlobalUsage.UserID, GlobalUsage.WcCode, GlobalUsage.WorkOrderNo))
            {
                GetDatas();
            }
            else
                MessageBox.Show("옮길 수 없는 대차 입니다.");
        }
        private void dgvGVFrom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                txtLoading.TextBoxText = dgvGVFrom.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
