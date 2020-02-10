using Axxen.CustomControls;
using AxxenClient.Util;
using log4net.Core;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VO;
using System.Timers;
using System.IO;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_001 : AxxenClient.Templets.ClientBaseForm
    {
        bool isMachineRun = false;
        string selectedrowwono { get; set; }
        int columnno { get; set; }
        public Color runningDefaultColor { get; set; }
        public MachineType machinet = MachineType.Molding;
        public POP_PRD_001()
        {
            InitializeComponent();
            panBoxing.Location = panLoad.Location = panMolding.Location;
        }
        /// <summary>
        /// 컨트롤들 기본설정
        /// </summary>
        private void InitControl()
        {
            // 화면 set
            SetButtonForms();
            SetDGV();
            btnClose.Visible = false;

            // 공정별 화면
            switch (GlobalUsage.WorkType)
            {
                case WorkType.Molding:
                    panMolding.Visible = true;
                    machinet = MachineType.Molding;
                    break;
                case WorkType.Load:
                    panLoad.Visible = true;
                    btnMachineRun.Enabled = false;
                    btnMachineRun.BackColor = Color.FromArgb(188, 209, 215);
                    break;
                case WorkType.Boxing:
                    machinet = MachineType.Boxing;
                    panBoxing.Visible = true;
                    break;
            }

            //데이터 읽어오기
            GetDatas();
        }
        /// <summary>
        /// 데이터 그리드뷰 설정
        /// </summary>
        private void SetDGV()
        {
            InitControlUtil.SetPOPDGVDesign(dgvMain);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "상태", "Wo_Status", true, 80, DataGridViewContentAlignment.MiddleCenter, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "작업지시번호", "Workorderno", true, 200, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "할당작업자", "User_ID", true, 130, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "품목코드", "Item_Code", true, 110, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "품목명", "Item_Name", true, 80, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "단위", "Prd_Unit", true, 70, DataGridViewContentAlignment.MiddleCenter, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "계획수량", "Prd_Qty", true, 110, DataGridViewContentAlignment.MiddleRight, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "실적수량", "Prd_Qty", true, 110, DataGridViewContentAlignment.MiddleRight, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "생산시작시간", "Prd_Starttime", true, 200, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "생산종료시간", "Prd_Endtime", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "계획 날짜", "Plan_Date", false, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "계획수량", "Prd_Qty", false, 200, DataGridViewContentAlignment.MiddleRight, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "성형 줄 수", "Line_Per_Qty", false, 200, DataGridViewContentAlignment.MiddleRight, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "포장 샷당 pcs수", "Shot_Per_Qty", false, 200, DataGridViewContentAlignment.MiddleRight, false);

            dgvMain.Columns[8].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgvMain.Columns[9].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }
        /// <summary>
        /// 데이터를 DB에서 가져온다
        /// </summary>
        public void GetDatas()
        {
            // 데이터를 가져온다.
            WorkOrder_Service service = new WorkOrder_Service();
            dgvMain.DataSource = service.GetAllWorkOrder_AlloHisDetail_Item_Wc(GlobalUsage.WcCode);

            // 실행중인 작업 및 선택했던 로우를 선택한다
            if (!GlobalUsage.WorkOrderNo.Equals("설정안함"))
                SetColor(GlobalUsage.WorkOrderNo);
            if (!string.IsNullOrEmpty(selectedrowwono))
            {
                for (int i = 0; i < dgvMain.Rows.Count; i++)
                {
                    if (dgvMain.Rows[i].Cells[1].Value.ToString().Equals(selectedrowwono))
                    {
                        dgvMain.CurrentCell = dgvMain.Rows[i].Cells[columnno];
                    }
                }
            }
        }
        /// <summary>
        /// 버튼에 폼을 연결한다.
        /// </summary>
        private void SetButtonForms()
        {
            btnWorkOrderCreate1.Tag = typeof(POP_PRD_002);
            btnCreatePallet.Tag = typeof(POP_PRD_003);
            btnBarcordeRecreate.Tag = typeof(POP_PRD_004);
            btnWarehousing.Tag = typeof(POP_PRD_005);
            btnUnload.Tag = typeof(POP_PRD_006);
            btnDryGVLoad.Tag = typeof(POP_PRD_007);
            btnSetMold.Tag = typeof(POP_PRD_008);
            btnWorkOrderCreate2.Tag = typeof(POP_PRD_009);
            btnLoadRecordRegister.Tag = typeof(POP_PRD_010);
            btnFiringInOut.Tag = typeof(POP_PRD_011);
            btnClearDryGV.Tag = typeof(POP_PRD_012);
            btnSetWorker1.Tag = btnSetWorker2.Tag = btnSetWorker3.Tag = typeof(POP_PRD_013);
            btnSetPressCondition1.Tag = btnSetPressCondition2.Tag = typeof(POP_PRD_014);
            btnQualityMeasure1.Tag = btnQualityMeasure2.Tag = btnQualityMeasure3.Tag = typeof(POP_PRD_015);
            btnNoActive.Tag = typeof(POP_PRD_016);
        }
        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            InitControl();
            btnMachineRun.Visible = true;
        }
        private void btnClick(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Form frm = Activator.CreateInstance((Type)btn.Tag) as Form;
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }
        /// <summary>
        /// 작업지시 토글
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkOrderToggle(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count <= 0)
            { // 선택한 작업지시가 없을 경우
                MessageBox.Show("작업지시를 선택해주세요.");
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업지시를 선택하지 않고 작업지시를 실행하려함.");
                return;
            }
            // 시작한 작업지시가 있을 경우 - 작업지시를 끝냄
            if (GlobalUsage.WorkOrderNo != "설정안됨")
            {
                WorkOrderEnd();
                return;
            }
            // 시작한 작업지시가 없을 때 - 작업지시 시작
            WorkOrderStart();
        }
        /// <summary>
        /// 작업지시 시작
        /// </summary>
        private void WorkOrderStart()
        {
            DataGridViewRow row = dgvMain.SelectedRows[0];
            WorkOrder_Service service = new WorkOrder_Service();
            // 작업지시 시작하기
            if (service.UpdateWorkOrderStart(row.Cells[1].Value.ToString(), row.Cells[5].Value.ToString(), GlobalUsage.UserID))
            { // 성공
                //해당 프로그램의 전역에 설정해줌
                GlobalUsage.WorkOrderNo = row.Cells[1].Value.ToString();
                GlobalUsage.WorkorderDate = Convert.ToDateTime(row.Cells[10].Value);
                GlobalUsage.ItemName = row.Cells[4].Value.ToString();
                GlobalUsage.Prd_Qty = 0;
                GlobalUsage.Out_Qty = 0;
                GlobalUsage.Prd_Unit = row.Cells[5].Value.ToString();

                GetDatas();
                SetColor(GlobalUsage.WorkOrderNo);
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업지시 {GlobalUsage.WorkOrderNo}를 실행함");

                // 전역 할당
                selectedrowwono = GlobalUsage.WorkOrderNo;
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 존재하지 않는 작업지시를 실행하려함");
                MessageBox.Show("존재하지 않는 작업지시 입니다.");
            }
        }
        private void SetColor(string wokrorderno)
        {
            //색상 변경
            for (int i = 0; i < dgvMain.RowCount; i++)
            {
                DataGridViewRow row2 = dgvMain.Rows[i];
                if (row2.Cells[1].Value.ToString().Equals(wokrorderno))
                {
                    runningDefaultColor = row2.DefaultCellStyle.BackColor;
                    row2.DefaultCellStyle.BackColor = Color.FromArgb(188, 220, 244);
                    break;
                }
            }
        }
        /// <summary>
        /// 작업지시 중지
        /// </summary>
        private void WorkOrderEnd()
        {
            WorkOrder_Service service = new WorkOrder_Service();
            // 작업지시 끝내기
            if (service.UpdateWorkOrderEnd(GlobalUsage.WorkOrderNo, GlobalUsage.Out_Qty, GlobalUsage.Prd_Qty, GlobalUsage.UserID))
            { // 성공
              //해당 프로그램의 전역에 설정해줌
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업지시 {GlobalUsage.WorkOrderNo}를 종료함");
                GlobalUsage.WorkOrderNo = "설정안됨";
                GlobalUsage.WorkorderDate = null;
                GlobalUsage.ItemName = "설정안됨";
                GlobalUsage.Prd_Qty = 0;
                GlobalUsage.Out_Qty = 0;
                GlobalUsage.Prd_Unit = "설정안됨";

                // 전역 할당
                selectedrowwono = "설정안됨";
                GetDatas();
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 존재하지 않는 작업지시를 중지하려함");
                MessageBox.Show("존재하지 않는 작업지시 입니다.");
            }

            // 기계 종료
            if(isMachineRun) MachineStop(machinet);
            return;
        }
        /// <summary>
        /// 작업지시 마감
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkOrderClose(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count <= 0)
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업지시를 선택하지 않고 마감하려함");
                MessageBox.Show("작업지시를 선택해주세요.");
                return;
            }
            if (!(dgvMain.SelectedRows[0].Cells[0].Value.ToString().Equals("생산중지")))
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 중지되지 않는 작업지시를 마감하려함");
                MessageBox.Show("생산중인 작업지시입니다.");
                return;
            }

            WorkOrder_Service service = new WorkOrder_Service();
            if (service.UpdateWorkOrderClose(GlobalUsage.UserID, dgvMain.SelectedRows[0].Cells[1].Value.ToString()))
            { // 성공
                GetDatas();
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 존재하지 않는 작업지시를 마감하려함");
                MessageBox.Show("마감할 수 없는 작업지시입니다.");
            }
        }
        /// <summary>
        /// 매 초마다 작업 현황 가져오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timetimer_Tick(object sender, EventArgs e)
        {
            selectedrowwono = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
            columnno = dgvMain.CurrentCell.ColumnIndex;
            GetDatas();
        }
        private void btnMachineRun_Click(object sender, EventArgs e)
        { // 토글 기계
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
                machine0.MachineStop(machinet);
            }
        }
        /// <summary>
        /// 기계 시작
        /// </summary>
        /// <param name="work"></param>
        Machine machine0 = new Machine(0);
        private void MachineStart(MachineType machinet)
        {
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if (!isMachineRun)
                {
                    // 공통
                    btnMachineRun.BackColor = Color.FromArgb(188, 220, 244);
                    isMachineRun = true;

                    WorkOrderVO workorder = (dgvMain.DataSource as List<WorkOrderVO>).Find(x => x.Workorderno == GlobalUsage.WorkOrderNo);
                    switch (machinet)
                    {
                        case MachineType.Molding: // 성형일경우
                            MoldService service = new MoldService();
                            List<MoldVO> moldlist = service.GetMoldList(wccode: GlobalUsage.WcCode);
                            if (moldlist.Count < 1)
                            {
                                MessageBox.Show("작업장에 장착된 금형이 없습니다.");
                                btnMachineRun.BackColor = Color.FromArgb(218, 239, 245);
                                isMachineRun = false;
                                return;
                            }
                            MoldVO mold = moldlist[0];
                            Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업({GlobalUsage.WorkOrderNo})의 성형기계로 금형({mold.Mold_Code})을 이용해 품목({workorder.Item_Code})을 생산함");
                            machine0.MachineStartMold(GlobalUsage.WorkOrderNo, new Item_MoldPair(workorder.Item_Code, mold.Mold_Code, workorder.Line_Per_Qty));
                            break;
                        case MachineType.Boxing: // 포장일경우
                            Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업({GlobalUsage.WorkOrderNo})의 포장기계로 품목({workorder.Item_Code})을 생산함");
                            machine0.MachineStartBoxing(GlobalUsage.WorkOrderNo, workorder.Item_Code, workorder.Shot_Per_Qty);
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


        private void POP_PRD_001_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 작업 종료
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                WorkOrderEnd();
            }
        }
    }
}