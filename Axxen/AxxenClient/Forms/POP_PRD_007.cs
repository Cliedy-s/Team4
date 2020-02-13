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

            dgvGVFrom_CellClick(sender, null);
        }
        private void TopPanelSet()
        {
            txtWorkOrderno.TextBoxText = GlobalUsage.WorkOrderNo;
            txtItemName.TextBoxText = GlobalUsage.ItemName;
            txtQty.TextBoxText = GlobalUsage.Prd_Qty.ToString();
            txtUnit.TextBoxText = GlobalUsage.Prd_Unit.ToString();
            txtWcCode.TextBoxText = GlobalUsage.WcName;
            txtWorkOrderDate.TextBoxText = (GlobalUsage.WorkorderDate == null) ? "" : GlobalUsage.WorkorderDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvGVTo);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVTo, "코드", "GV_Code", true, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVTo, "대차명", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);

            InitControlUtil.SetPOPDGVDesign(dgvGVFrom);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "코드", "GV_Code", true, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "대차명", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "적재시각", "Loading_time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "수량", "Loading_Qty", true, 80, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "작업지시번호", "Workorderno", true, 80, DataGridViewContentAlignment.MiddleRight);
            dgvGVFrom.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            // 해당 작업지시에서 생성한 모든 대차
            dgvGVFrom.DataSource = service.GetGVCurrentStatus(workorderno: GlobalUsage.WorkOrderNo, gvStatus: "적재", gvGroup:"성형그룹");
            // 해당 작업장의 모든 빈대차를 가져온다.
            GV_MasterService mservice = new GV_MasterService();
            dgvGVTo.DataSource = mservice.GetGVs(gvStatus: "빈대차", gvGroup: "건조그룹");
        }
        private void btnToSearch_Click(object sender, EventArgs e)
        { // 검색
            GV_MasterService service = new GV_MasterService();
            dgvGVTo.DataSource = service.GetGVs(gvStatus: "빈대차", gvName: txtToGVSearch.TextBoxText, gvGroup: "건조그룹");
        }
        private void btnFromSearch_Click(object sender, EventArgs e)
        { // 검색
            GV_Current_StatusService service = new GV_Current_StatusService();
            dgvGVFrom.DataSource = service.GetGVCurrentStatus(workorderno: GlobalUsage.WorkOrderNo, gvStatus: "적재", gvName: txtFromGVSearch.TextBoxText, gvGroup: "성형그룹");
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(dgvGVTo.SelectedRows.Count > 0 && dgvGVFrom.SelectedRows.Count > 0)
            {
                string loadinggvcode = dgvGVTo.SelectedRows[0].Cells[0].Value.ToString();
                string unloadgvcode = dgvGVFrom.SelectedRows[0].Cells[0].Value.ToString();
                if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
                {
                    GV_HistoryService service = new GV_HistoryService();

                    // 옮겨타기
                    if (service.UpdateMoveGvItem(unloadgvcode, loadinggvcode, Convert.ToInt32(txtLoading.TextBoxText), GlobalUsage.UserID, GlobalUsage.WcCode, GlobalUsage.WorkOrderNo, dgvGVFrom.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        GetDatas();
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 대차({unloadgvcode})에서 대차({loadinggvcode})로 옮겨타기에 성공함");
                    }
                    else
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 대차({unloadgvcode})에서 대차({loadinggvcode})로 옮겨타기 하려했으나 GV_Current_Status와 GV_History에 언로딩할 대차가 존재하지 않음");
                        MessageBox.Show("옮길 수 없는 대차 입니다.");
                    }
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 대차({unloadgvcode})에서 대차({loadinggvcode})로 옮겨타기 하려했으나 작업을 시작하지 않음");
                    MessageBox.Show("작업을 시작해주세요");
                }
                dgvGVFrom_CellClick(sender, null);
            }
        }
        private void dgvGVFrom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGVFrom.SelectedRows.Count > 0)
            {
                txtLoading.TextBoxText = dgvGVFrom.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
