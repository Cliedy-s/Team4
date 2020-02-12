using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_002 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_002()
        {
            InitializeComponent();
        }
        private void POP_PRD_002_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDatas();
        }
        /// <summary>
        /// 데이터 설정
        /// </summary>
        private void GetDatas()
        {
            Wo_ReqService service = new Wo_ReqService();
            dgvWoReq.DataSource = service.GetAllWoReqUnit("5");
        }
        /// <summary>
        /// 컨트롤 설정
        /// </summary>
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvWoReq);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "의뢰순번", "Req_Seq", false, 100, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "생산의뢰번호", "Wo_Req_No", true, 160, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "품목코드", "Item_Code", false, 100, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "품목명", "Item_Name", true, 200, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "수량", "Req_Qty", true, 80, DataGridViewContentAlignment.MiddleRight, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "날짜", "Prd_Plan_Date", true, 120, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "거래처", "Cust_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "상태", "Req_Status", true, 100, DataGridViewContentAlignment.MiddleCenter, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "품목 단위", "Item_Unit", false);
        }
        private void btnCreateWorkOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                WorkOrder_Service service = new WorkOrder_Service();
                bool IsSuccess = service.InsertWorkOrder(
                    new VO.WorkOrderNewVO()
                    {
                        Ins_Emp = GlobalUsage.UserID,
                        Item_Code = txtItemSearch.CodeText,
                        Mat_LotNo = "MAT"+now.ToString("yyyyMMddHHmmss"),
                        Plan_Qty = Convert.ToInt32(txtPlanQty.TextBoxText),
                        Plan_Unit = lblItem_Unit.Text,
                        Wo_Req_No = txtReqNo.TextBoxText,
                        Req_Seq = Convert.ToInt32(lblReq_Seq.Text),
                        Wc_Code = txtWcSearch.CodeText,
                        Wo_Status = "생산대기",
                        Wo_Order = "5",
                        Prd_Unit = lblItem_Unit.Text
                    });
                if (IsSuccess)
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업지시를 생성함");
                }
                else
                {
                    MessageBox.Show("생성실패", "작업지시생성");
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 작업지시 생성에 실패함");
                }
                this.Close();
            }
            catch(Exception ee)
            {
                Program.Log.WriteFatal($"{GlobalUsage.UserName}이(가) 작업지시 생성에 실패함", ee);
                MessageBox.Show("생성실패", "작업지시생성");
            }

        }// 작업지시생성버튼
        private void dgvWorkOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlanQty.TextBoxText = dgvWoReq.SelectedRows[0].Cells[4].Value.ToString();
            txtItemSearch.TextBoxText = dgvWoReq.SelectedRows[0].Cells[3].Value.ToString();
            txtItemSearch.CodeText = dgvWoReq.SelectedRows[0].Cells[2].Value.ToString();
            txtReqNo.TextBoxText = dgvWoReq.SelectedRows[0].Cells[1].Value.ToString();
            lblReq_Seq.Text = dgvWoReq.SelectedRows[0].Cells[0].Value.ToString();
            lblItem_Unit.Text = dgvWoReq.SelectedRows[0].Cells[8].Value.ToString();
            txtProcessSearch.TextBoxText = GlobalUsage.ProcessName;
            txtProcessSearch.CodeText = GlobalUsage.ProcessCode;
            txtWcSearch.TextBoxText = GlobalUsage.WcName;
            txtWcSearch.CodeText = GlobalUsage.WcCode;
        }

    }
}
