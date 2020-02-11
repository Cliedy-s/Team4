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
    public partial class POP_PRD_015 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_015()
        {
            InitializeComponent();
        }

        private void POP_PRD_015_Load(object sender, EventArgs e)
        {
            InitControls();
            TopPanelSet();
            GetDatas();
            btnMachineRun.Visible = true;
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
            lblInspectcode.Text = lblItemCode.Text = lblProcesscode.Text = "";
            //lblInspectcode.Visible = lblItemCode.Visible = lblProcesscode.Visible = false;
            InitControlUtil.SetPOPDGVDesign(dgvInspect);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "측정항목", "Inspect_name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "USL", "USL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "SL", "SL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "LSL", "LSL", true, 140, DataGridViewContentAlignment.MiddleRight);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "품목코드", "Item_Code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "공정코드", "Process_code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspect, "항목코드", "Inspect_code", false, 100);


            InitControlUtil.SetPOPDGVDesign(dgvInspectMeasure);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspectMeasure, "측정값", "Inspect_val", true, 120, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspectMeasure, "측정일시", "Inspect_datetime", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvInspectMeasure, "조건순번", "Inspect_measure_seq", false, 200);
            dgvInspectMeasure.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }
        private void GetDatas()
        {
            Inspect_Spec_MasterService sservice = new Inspect_Spec_MasterService();
            if (!(GlobalUsage.WorkOrderNo == "설정안됨"))
            {
                //switch (GlobalUsage.WorkType) // TODO - 개발용 지우기
                //{
                //    case WorkType.Molding:
                //        dgvInspect.DataSource = sservice.GetAllByWcCode("WC20001", GlobalUsage.ItemCode);
                //        break;
                //    case WorkType.Load:
                //        dgvInspect.DataSource = sservice.GetAllByWcCode("WC40001", GlobalUsage.ItemCode);
                //        break;
                //    case WorkType.Boxing:
                //        dgvInspect.DataSource = sservice.GetAllByWcCode("WC50001", GlobalUsage.ItemCode);
                //        break;
                //}
                dgvInspect.DataSource = sservice.GetAllByWcCode(GlobalUsage.WcCode, GlobalUsage.ItemCode);
            }
            else
            {

            }
        }
        private void SearchData()
        {
            Inspect_Measure_HistoryService mservice = new Inspect_Measure_HistoryService();
            dgvInspectMeasure.DataSource = mservice.GetAll(lblItemCode.Text, lblProcesscode.Text, lblInspectcode.Text);
        }

        private void dgvInspect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblItemCode.Text = dgvInspect.SelectedRows[0].Cells[4].Value.ToString();
            lblProcesscode.Text = dgvInspect.SelectedRows[0].Cells[5].Value.ToString();
            lblInspectcode.Text = dgvInspect.SelectedRows[0].Cells[6].Value.ToString();

            decimal usl, sl, lsl;
            usl = Convert.ToDecimal(dgvInspect.SelectedRows[0].Cells[1].Value);
            sl = Convert.ToDecimal(dgvInspect.SelectedRows[0].Cells[2].Value);
            if (usl - sl <= 0) nudMeasure.Increment = 1;
            else nudMeasure.Increment = (usl - sl) / 10m;

            nudMeasure.Value = sl;

            SearchData();
        }

        private void btnInsertMeasure_Click(object sender, EventArgs e)
        {
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if (!string.IsNullOrEmpty(lblInspectcode.Text))
                {
                    Inspect_Measure_HistoryService service = new Inspect_Measure_HistoryService();
                    InspectHistoryVO item = new InspectHistoryVO();
                    item.Inspect_code = lblInspectcode.Text;
                    item.Item_code = lblItemCode.Text;
                    item.Inspect_val = Convert.ToDecimal(nudMeasure.Value);
                    item.Process_code = lblProcesscode.Text;
                    item.Workorderno = GlobalUsage.WorkOrderNo;
                    if (service.InsertInspect_Measure(item, GlobalUsage.UserID))
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 품질측정 조건({lblInspectcode.Text})에 값({nudMeasure.Value})를 넣는데에 성공하였음");
                        nudMeasure.Value = 0;
                        SearchData();
                    }
                    else
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 품질측정 조건({lblInspectcode.Text})에 값({nudMeasure.Value})를 넣는데에 실패하였음");
                        MessageBox.Show("입력할 수 없는 항목입니다.");
                    }
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업시작을 하지않고 품질측정값을 등록하려하였음");
                    MessageBox.Show("작업을 시작해주세요");
                }
            }
        }

        private void btnDeleteMeasure_Click(object sender, EventArgs e)
        {
            if (dgvInspectMeasure.SelectedRows.Count > 0)
            {
                Inspect_Measure_HistoryService service = new Inspect_Measure_HistoryService();
                if (service.DeleteInspect_MeasureBySeq(Convert.ToInt32(dgvInspectMeasure.SelectedRows[0].Cells[2].Value)))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 품질측정 조건({lblInspectcode.Text})의 값({nudMeasure.Value})을 삭제하는데 성공하였음");
                    SearchData();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 품질측정 조건({lblInspectcode.Text})의 값({nudMeasure.Value})을 삭제하는데 실패하였음");
                    MessageBox.Show("입력할 수 없는 항목입니다.");
                }
            }
        }

        bool isMachineRun = false;
        MachineType machinet = MachineType.Inspect_Measure;
        private void btnMachineRun_Click(object sender, EventArgs e)
        {// 토글 기계
            if (isMachineRun) MachineStop(machinet);
            else MachineStart(machinet);
        }
        /// <summary>
        /// 기계 종료
        /// </summary>
        private void MachineStop(MachineType machinet)
        {
            if (isMachineRun)
            {
                btnMachineRun.BackColor = Color.FromArgb(218, 239, 245);
                isMachineRun = false;
                machine2.MachineStop(machinet);
            }
        }
        /// <summary>
        /// 기계 시작
        /// </summary>
        /// <param name="work"></param>
        Machine machine2 = new Machine(2);
        private void MachineStart(MachineType machinet)
        {
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if (!isMachineRun)
                {
                    btnMachineRun.BackColor = Color.FromArgb(188, 220, 244);
                    isMachineRun = true;
                    List<InspectSpecVO> list = (new Inspect_Spec_MasterService()).GetAll(GlobalUsage.ItemCode, GlobalUsage.WcCode);
                    List<Item_inspectPair> pairlist = new List<Item_inspectPair>();
                    StringBuilder forlog = new StringBuilder();
                    foreach (var item in list)
                    {
                        pairlist.Add(new Item_inspectPair(item.Item_Code, item.Inspect_code, item.USL, item.LSL));
                        forlog.Append(item.Inspect_name + " ");
                    }

                    if (pairlist == null) {
                        MessageBox.Show("항목이 없습니다.");
                        return;
                    }

                    switch (machinet)
                    {
                        case MachineType.Inspect_Measure:
                            Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업({GlobalUsage.WorkOrderNo})의 품질 측정기계로 품목({pairlist[0].Itemcode})에 대한 항목({forlog.ToString()})들을 측정함");
                            machine2.MachineStart(GlobalUsage.WorkOrderNo, pairlist, MachineStop);
                            break;
                    }
                }
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업지시를 시작하지 않고 기계를 시작하려함");
                MessageBox.Show("작업지시를 시작해주세요");
            }
        }

    }
}
