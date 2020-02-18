using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VO;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_010 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_010()
        {
            InitializeComponent();
        }
        private void POP_PRD_010_Load(object sender, EventArgs e)
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
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "코드", "GV_Code", true, 150);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "대차명", "GV_Name", true, 120, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "적재시각", "Loading_time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "수량", "Loading_Qty", true, 80, DataGridViewContentAlignment.MiddleCenter);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "", "Item_Code", false, 50);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "작업지시번호", "Workorderno", true, 200);
            dgvGVFrom.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            // 해당 작업지시에서 생성한 모든 대차
            List<GVStatusVO> list = service.GetGVCurrentStatus(gvGroup: "건조그룹", workorderno:GlobalUsage.WorkOrderNo);
            dgvGVFrom.DataSource =
                (from item in list
                 where (item.GV_Status == "적재" || item.GV_Status == "언로딩")
                 select item).ToList();
            // 소성대차의 모든 빈대차를 가져온다.
            GV_MasterService mservice = new GV_MasterService();
            dgvGVTo.DataSource = mservice.GetGVs(gvStatus: "빈대차", gvGroup: "소성그룹");
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (dgvGVTo.SelectedRows.Count > 0 && dgvGVFrom.SelectedRows.Count > 0)
            {
                if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
                {
                    if (Convert.ToInt32(txtMove.TextBoxText) == 0)
                    {
                        MessageBox.Show("0개를 로딩할 수는 없습니다.");
                    }
                    string loadinggvcode = dgvGVTo.SelectedRows[0].Cells[0].Value.ToString();
                    string unloadgvcode = dgvGVFrom.SelectedRows[0].Cells[0].Value.ToString();
                    GV_HistoryService service = new GV_HistoryService();

                    // 옮겨타기
                    if (service.UpdateMoveGvItem(unloadgvcode, loadinggvcode, Convert.ToInt32(txtMove.TextBoxText), GlobalUsage.UserID, GlobalUsage.WcCode, GlobalUsage.WorkOrderNo, dgvGVFrom.SelectedRows[0].Cells[5].Value.ToString(), true))
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업지시({GlobalUsage.WorkOrderNo})에서 대차({unloadgvcode})에서 대차({loadinggvcode})로 {txtMove.TextBoxText}개 대차 옮겨타기를 하였음");
                        GetDatas();
                    }
                    else
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업지시({GlobalUsage.WorkOrderNo})에서 대차({unloadgvcode})에서 대차({loadinggvcode})로 {txtMove.TextBoxText}개 대차 옮겨타기를 하려했으나 실패하였음");
                        MessageBox.Show("옮길 수 없는 대차 입니다.");
                    }
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업시작을 하지않고 대차 옮겨타기를 하려하였음");
                    MessageBox.Show("작업을 시작해주세요");
                }
                dgvGVFrom_CellClick(sender, null);
            }
        }
        private void dgvGVFrom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGVFrom.SelectedRows.Count > 0)
            {
                txtMove.TextBoxText = dgvGVFrom.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        private void btnClearGV_Click(object sender, EventArgs e)
        {   // 대차 비우기
            string clear_cause = "적재문제";
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if (dgvGVFrom.SelectedRows.Count < 1)
                {
                    MessageBox.Show("대차를 선택해주세요");
                    return;
                }
                GV_HistoryService service = new GV_HistoryService();
                GVClearVO clearvo = new GVClearVO()
                {
                    Clear_Cause = clear_cause,
                    Clear_Item = dgvGVFrom.SelectedRows[0].Cells[4].Value == null ? "" : dgvGVFrom.SelectedRows[0].Cells[4].Value.ToString(),
                    Clear_Qty = dgvGVFrom.SelectedRows[0].Cells[3].Value == null ? 0 : Convert.ToInt32(dgvGVFrom.SelectedRows[0].Cells[3].Value),
                    Clear_wc = GlobalUsage.WcCode,
                    GV_Code = dgvGVFrom.SelectedRows[0].Cells[0].Value.ToString(),
                    Up_Emp = GlobalUsage.UserID
                };
                if (service.UpdateClearGV(clearvo))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업지시({GlobalUsage.WorkOrderNo})에서 대차({dgvGVFrom.SelectedRows[0].Cells[0].Value.ToString()})를 이유({clear_cause})로 비움");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업지시({GlobalUsage.WorkOrderNo})에서 대차({dgvGVFrom.SelectedRows[0].Cells[0].Value.ToString()})를 이유({clear_cause})로 비우려 하였으나 실패하였음");
                    MessageBox.Show("대차 비우기에 실패하였습니다.");
                }
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업시작을 하지않고 대차 비우기를 하려하였음");
                MessageBox.Show("작업을 시작해주세요");
            }
        }
        private void btnToSearch_Click(object sender, EventArgs e)
        {   // 빈대차 목록 검색
            GV_MasterService mservice = new GV_MasterService();
            dgvGVTo.DataSource = mservice.GetGVs(gvStatus: "빈대차", gvGroup: "소성그룹", gvName: txtToGVSearch.TextBoxText);
        }
        private void btnFromSearch_Click(object sender, EventArgs e)
        {   // 적재된 목록 검색
            GV_Current_StatusService service = new GV_Current_StatusService();
            List<GVStatusVO> list = service.GetGVCurrentStatus(gvGroup: "건조그룹", workorderno: GlobalUsage.WorkOrderNo, gvName: txtFromGVSearch.TextBoxText);
            dgvGVFrom.DataSource =
                (from item in list
                 where (item.GV_Status == "적재" || item.GV_Status == "언로딩")
                 select item).ToList();
        }

        private void AButton1_Click(object sender, EventArgs e)
        {
            KeypadForm frm = new KeypadForm();
            frm.FormSendEvent += new KeypadForm.FormSendDataHandler(DieaseUpdateEventMethod);

            frm.Show();
        }

        private void DieaseUpdateEventMethod(object sender)
        {
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call
            txtMove.TextBoxText = sender.ToString();
        }
    }
}
