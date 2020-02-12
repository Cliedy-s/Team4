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
    public partial class POP_PRD_006 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_006()
        {
            InitializeComponent();
        }
        private void POP_PRD_006_Load(object sender, EventArgs e)
        {
            InitControls();
            TopPanelSet();
            GetDatas();
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
            InitControlUtil.SetPOPDGVDesign(dgvBoxing);
            InitControlUtil.AddNewColumnToDataGridView(dgvBoxing, "대차코드", "GV_Code", true, 110);
            InitControlUtil.AddNewColumnToDataGridView(dgvBoxing, "대차명", "GV_Name", true, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvBoxing, "작업지시번호", "Workorderno", true, 200, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvBoxing, "품목코드", "Item_Code", true, 120);
            InitControlUtil.AddNewColumnToDataGridView(dgvBoxing, "품목명", "Item_Name", true);
            InitControlUtil.AddNewColumnToDataGridView(dgvBoxing, "수량", "Prd_Qty", true, 100, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvBoxing, "대차상태", "GV_Status", true, 110, DataGridViewContentAlignment.MiddleCenter);
        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            dgvBoxing.DataSource = service.GetGVCurrentStatus(gvStatus: "적재", workorderno: GlobalUsage.WorkOrderNo);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            dgvBoxing.DataSource = service.GetGVCurrentStatus(gvStatus: "적재", gvName: txtSearch.TextBoxText, workorderno: GlobalUsage.WorkOrderNo);
        }
        private void btnUnload_Click(object sender, EventArgs e)
        {
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if (dgvBoxing.SelectedRows.Count < 1)
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 언로딩하려 했지만 대차를 선택하지 않음");
                    MessageBox.Show("대차를 선택해주세요");
                    return;
                }
                GV_HistoryService service = new GV_HistoryService();
                if (service.UpdateUnload(GlobalUsage.WorkOrderNo,GlobalUsage.UserID, dgvBoxing.SelectedRows[0].Cells[0].Value.ToString(), null, GlobalUsage.WcCode, Convert.ToInt32(dgvBoxing.SelectedRows[0].Cells[5].Value)))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차({dgvBoxing.SelectedRows[0].Cells[0].Value.ToString()}) 언로딩에 성공함");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차({dgvBoxing.SelectedRows[0].Cells[0].Value.ToString()}) 언로딩에 실패함");
                    MessageBox.Show("언로딩에 실패하였습니다.");
                }
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차({ dgvBoxing.SelectedRows[0].Cells[0].Value.ToString()})를 언로딩 하려했으나 작업을 시작하지 않음");
                MessageBox.Show("작업을 시작해주세요");
            }
        }
        private void btnGVClear_Click(object sender, EventArgs e)
        {
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if (dgvBoxing.SelectedRows.Count < 1)
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차를 선택하지 않고 대차 비우기를 시도함");
                    MessageBox.Show("대차를 선택해주세요");
                    return;
                }
                GV_HistoryService service = new GV_HistoryService();
                GVClearVO clearvo = new GVClearVO()
                {
                    Clear_Cause = "포장문제",
                    Clear_Item = dgvBoxing.SelectedRows[0].Cells[3].Value == null ? "" : dgvBoxing.SelectedRows[0].Cells[3].Value.ToString(),
                    Clear_Qty = dgvBoxing.SelectedRows[0].Cells[5].Value == null ? 0 : Convert.ToInt32(dgvBoxing.SelectedRows[0].Cells[5].Value),
                    Clear_wc = GlobalUsage.WcCode,
                    GV_Code = dgvBoxing.SelectedRows[0].Cells[0].Value.ToString(),
                    Up_Emp = GlobalUsage.UserID
                };
                if (service.UpdateClearGV(clearvo))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차({clearvo.GV_Code}) 대차비우기에 성공함");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차({clearvo.GV_Code})를 비우려고 하였으나 모종의 이유로 실패함");
                    MessageBox.Show("대차 비우기에 실패하였습니다.");
                }
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차({ dgvBoxing.SelectedRows[0].Cells[0].Value.ToString()})를 비우려고 하였으나 작업을 시작하지 않음");
                MessageBox.Show("작업을 시작해주세요");
            }

        }
    }
}
