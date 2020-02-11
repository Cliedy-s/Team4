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
            switch (GlobalUsage.WorkType) // TODO - 개발용 지우기
            {
                case WorkType.Molding:
                    dgvInspect.DataSource = sservice.GetAllByWcCode("WC20001");
                    break;
                case WorkType.Load:
                    dgvInspect.DataSource = sservice.GetAllByWcCode("WC40001");
                    break;
                case WorkType.Boxing:
                    dgvInspect.DataSource = sservice.GetAllByWcCode("WC50001");
                    break;
            }

            //dgvInspect.DataSource = sservice.GetAllByWcCode(GlobalUsage.WcCode);
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
                    item.Inspect_val = Convert.ToDecimal(txtMeasure.TextBoxText);
                    item.Process_code = lblProcesscode.Text;
                    item.Workorderno = GlobalUsage.WorkOrderNo;
                    if (service.InsertInspect_Measure(item, GlobalUsage.UserID))
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 품질측정 조건({lblInspectcode.Text})에 값({txtMeasure.TextBoxText})를 넣는데에 성공하였음");
                        txtMeasure.TextBoxText = "";
                        SearchData();
                    }
                    else
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 품질측정 조건({lblInspectcode.Text})에 값({txtMeasure.TextBoxText})를 넣는데에 실패하였음");
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
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 품질측정 조건({lblInspectcode.Text})의 값({txtMeasure.TextBoxText})을 삭제하는데 성공하였음");
                    SearchData();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 품질측정 조건({lblInspectcode.Text})의 값({txtMeasure.TextBoxText})을 삭제하는데 실패하였음");
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
                //btnMachineRun.BackColor = Color.FromArgb(218, 239, 245);
                //isMachineRun = false;
                //machine0.MachineStop(machinet);
            }
        }
        /// <summary>
        /// 기계 시작
        /// </summary>
        /// <param name="work"></param>
        Machine machine1 = new Machine(1);
        private void MachineStart(MachineType machinet)
        {
            //if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            //{
            //    if (!isMachineRun)
            //    {
            //        btnMachineRun.BackColor = Color.FromArgb(188, 220, 244);
            //        isMachineRun = true;

            //        switch (machinet)
            //        {
            //            case MachineType.Inspect_Measure:
            //                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업({GlobalUsage.WorkOrderNo})의 성형기계로 금형({mold.Mold_Code})을 이용해 품목({workorder.Item_Code})을 생산함");
            //                machine1.MachineStartInspectMeasure(GlobalUsage.WorkOrderNo, new Item_MoldPair(workorder.Item_Code, mold.Mold_Code, workorder.Line_Per_Qty));
            //                break;
            //        }
            //    }
            //}
            //else
            //{
            //    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업지시를 시작하지 않고 기계를 시작하려함");
            //    MessageBox.Show("작업지시를 시작해주세요");
            //}
        }

    }
}
