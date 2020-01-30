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
    public partial class POP_PRD_001 : AxxenClient.Templets.ClientBaseForm
    {
        public Color runningDefaultColor { get; set; }
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
                    break;
                case WorkType.Load:
                    panLoad.Visible = true;
                    break;
                case WorkType.Boxing:
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
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "상태", "Wo_Status", true, 70, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "작업지시번호", "Workorderno", true, 175, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "할당작업자", "User_ID", true, 100, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "품목코드", "Item_Code", true, 80, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "품목명", "Item_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "단위", "Prd_Unit", true, 60, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "실적수량", "Prd_Qty", true, 110, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "생산시작시간", "Prd_Starttime", true, 200, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "생산종료시간", "Prd_Endtime", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvMain, "계획 날짜", "Plan_Date", false, 200);

            dgvMain.Columns[7].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
            dgvMain.Columns[8].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
        }
        /// <summary>
        /// 데이터를 DB에서 가져온다
        /// </summary>
        public void GetDatas()
        {
            WorkOrder_Service service = new WorkOrder_Service();
            string woinichar = string.Empty;
            dgvMain.DataSource = service.GetAllWorkOrder_AlloHisDetail_Item_Wc(woinichar);
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
        }
        private void btnClick(object sender, EventArgs e)
        {
            if(sender is Button btn)
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
            if(dgvMain.SelectedRows.Count <= 0)
            { // 선택한 작업지시가 없을 경우
                MessageBox.Show("작업지시를 선택해주세요.");
                return;
            }

            // 시작한 작업지시가 있을 경우 - 작업지시를 끝냄
            if (GlobalUsage.WorkOrderNo != "설정안됨")
            {
                WorkOrder_Service service = new WorkOrder_Service();
                // 작업지시 끝내기
                if (service.UpdateWorkOrderEnd(GlobalUsage.WorkOrderNo, GlobalUsage.Out_Qty, GlobalUsage.Prd_Qty, GlobalUsage.Username))
                { // 성공
                    for (int i = 0; i < dgvMain.RowCount; i++) // 작업지시의 배경 색상 원래색상으로 변경
                    {
                        if (dgvMain.Rows[i].Cells[1].Value.ToString() == GlobalUsage.WorkOrderNo)
                        {
                            dgvMain.Rows[i].DefaultCellStyle.BackColor = runningDefaultColor;
                            break;
                        }
                    }
                    GetDatas();
                }
                else //실패
                    MessageBox.Show("작업지시 종료에 실패하였습니다.");
                return;
            }

            // 시작한 작업지시가 없을 때
            // 작업지시가 시작되지 않았을 때 - 작업지시를 시작함
            if (dgvMain.SelectedRows[0].Cells[7].Value == null) 
            {
                DataGridViewRow row = dgvMain.SelectedRows[0];
                WorkOrder_Service service = new WorkOrder_Service();
                // 작업지시 시작하기
                //service.UpdateWorkOrderStart(row.Cells[1].Value.ToString(), );

                //색상 변경
                runningDefaultColor = row.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.BackColor = Color.FromArgb(100, 200, 255);
            }

            //else if(dgvMain.SelectedRows[0].Cells[8].Value == null) // 시작하고 종료 안한 작업지시 일 경우
            //{

            //}
            // 시작 // dgvMain.SelectedRows[0].Cells[7]
            // 종료 // dgvMain.SelectedRows[0].Cells[8]

            // 해당 프로그램의 전역에 설정해줌
            //GlobalUsage.WorkOrderNo = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
            //GlobalUsage.WorkorderDate = Convert.ToDateTime(dgvMain.SelectedRows[0].Cells[9].Value);
            //GlobalUsage.ItemName = dgvMain.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEndWorkOrder(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count <= 0)
            {
                MessageBox.Show("작업지시를 선택해주세요.");
                return;
            }

            // TODO - 현장 마감 // dgvMain.SelectedRows[0].Cells[1].Value.ToString()
        }
    }
}
