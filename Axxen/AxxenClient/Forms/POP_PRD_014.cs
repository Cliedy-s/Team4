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
    public partial class POP_PRD_014 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_014()
        {
            InitializeComponent();
        }

        private void POP_PRD_014_Load(object sender, EventArgs e)
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
            txtWcCode.TextBoxText = GlobalUsage.WcName;
            txtWorkOrderDate.TextBoxText = (GlobalUsage.WorkorderDate == null) ? "" : GlobalUsage.WorkorderDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private void InitControls()
        {
            lblConditionCode.Text = lblItemCode.Text = lblWcCode.Text = "";
            lblConditionCode.Visible = lblItemCode.Visible = lblWcCode.Visible = false;
            InitControlUtil.SetPOPDGVDesign(dgvConditionList);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionList, "측정항목", "Condition_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionList, "USL", "USL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionList, "SL", "SL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionList, "LSL", "LSL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionList, "품목코드", "Item_Code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionList, "코드", "Condition_Code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionList, "작업장코드", "Wc_Code", false, 100);


            InitControlUtil.SetPOPDGVDesign(dgvConditionMeasureList);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionMeasureList, "그룹", "Condition_Name", true, 80);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionMeasureList, "측정값", "Condition_Val", true, 120, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionMeasureList, "측정일시", "Condition_Datetime", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvConditionMeasureList, "조건순번", "Condition_measure_seq", false, 200);

            dgvConditionMeasureList.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }
        private void GetDatas()
        {
            Condition_Spec_MasterService sservice = new Condition_Spec_MasterService();
            dgvConditionList.DataSource = sservice.GetAll();
        }
        private void SearchData()
        {
            Condition_Measure_HistoryService mservice = new Condition_Measure_HistoryService();
            dgvConditionMeasureList.DataSource = mservice.GetAll(lblConditionCode.Text, lblWcCode.Text, lblItemCode.Text);
        }

        private void btnInsertMeasure_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(lblConditionCode.Text))
            {
                Condition_Measure_HistoryService service = new Condition_Measure_HistoryService();
                ConditionMeasureVO item = new ConditionMeasureVO();
                item.Item_code = lblItemCode.Text;
                item.Wc_Code = lblWcCode.Text;
                item.Condition_Code = lblConditionCode.Text;
                item.Condition_Val = nudMeasure.Value;
                item.Workorderno = GlobalUsage.WorkOrderNo;
                if (service.InsertConditionMeasure(item, GlobalUsage.UserID))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 공정조건({lblConditionCode.Text})에 값({nudMeasure.Value})을 넣는데에 성공하였음");
                    SearchData();
                    nudMeasure.Value = 0;
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 공정조건({lblConditionCode.Text})에 값({nudMeasure.Value})을 넣으려 하였으나 실패하였음");
                    MessageBox.Show("입력할 수 없는 항목입니다.");
                }
            }
        }

        private void btnDeleteMeasure_Click(object sender, EventArgs e)
        {
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if (dgvConditionMeasureList.SelectedRows.Count > 0)
                {
                    Condition_Measure_HistoryService service = new Condition_Measure_HistoryService();
                    if (service.DeleteConditionMeasure(Convert.ToInt32(dgvConditionMeasureList.SelectedRows[0].Cells[3].Value)))
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 공정조건({lblConditionCode.Text})의 값({nudMeasure.Value})을 삭제에 성공함");
                    }
                    else
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 공정조건({lblConditionCode.Text})의 값({nudMeasure.Value})을 삭제에 하려했으나 실패함");
                        MessageBox.Show("삭제할 수 없는 항목입니다.");
                    }
                    SearchData();
                }
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업시작을 하지않고 공정조건에 값을 등록 하려하였음");
                MessageBox.Show("작업을 시작해주세요");
            }
        }

        private void dgvConditionList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblItemCode.Text = dgvConditionList.SelectedRows[0].Cells[4].Value.ToString();
            lblConditionCode.Text = dgvConditionList.SelectedRows[0].Cells[5].Value.ToString();
            lblWcCode.Text = dgvConditionList.SelectedRows[0].Cells[6].Value.ToString();

            decimal usl, sl, lsl;
            usl = Convert.ToDecimal(dgvConditionList.SelectedRows[0].Cells[1].Value);
            sl = Convert.ToDecimal(dgvConditionList.SelectedRows[0].Cells[2].Value);
            if (usl - sl <= 0) nudMeasure.Increment = 1;
            else nudMeasure.Increment = (usl - sl) / 10m;

            nudMeasure.Value = sl;

            SearchData();
        }

        private void AButton1_Click(object sender, EventArgs e)
        {
            KeypadForm frm = new KeypadForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.FormSendEvent += new KeypadForm.FormSendDataHandler(DieaseUpdateEventMethod);

            frm.Show();
        }
        private void DieaseUpdateEventMethod(object sender)
        {
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call
            nudMeasure.Text = sender.ToString();
        }
    }
}
