using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VO;

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
            GV_Current_StatusService service = new GV_Current_StatusService();
            List<GVStatusVO> list  = service.GetGVCurrentStatus(gvGroup: "소성그룹", gvStatus: "적재");
            dgvWoReq.DataSource = 
                (from gv in list
                 where gv.Unloading_Qty == null
                 select gv).ToList();
        }
        /// <summary>
        /// 컨트롤 설정
        /// </summary>
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvWoReq);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "의뢰순번", "Req_Seq", false, 100, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "생산의뢰번호", "Wo_Req_No", false, 160, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "생산수량단위", "Prd_Unit", false, 200, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "소성대차", "GV_Name", true, 130, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "품목코드", "Item_Code", true, 130, DataGridViewContentAlignment.MiddleLeft, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "품목명", "Item_Name", true, 200, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "수량", "Loading_Qty", true, 130, DataGridViewContentAlignment.MiddleRight, false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "대차이력 순서", "Hist_Seq", false);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "박스당PCS", "Pcs_Qty", true, 120, DataGridViewContentAlignment.MiddleRight);
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
                    }, Convert.ToInt64(lblHistReq.Text));
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
            int qty = Convert.ToInt32(dgvWoReq.SelectedRows[0].Cells[6].Value);
            int boxqty = Convert.ToInt32(dgvWoReq.SelectedRows[0].Cells[8].Value);

            lblHistReq.Text = dgvWoReq.SelectedRows[0].Cells[7].Value.ToString();
            txtPlanQty.TextBoxText = dgvWoReq.SelectedRows[0].Cells[6].Value.ToString();
            txtItemSearch.TextBoxText = dgvWoReq.SelectedRows[0].Cells[5].Value.ToString();
            txtItemSearch.CodeText = dgvWoReq.SelectedRows[0].Cells[4].Value.ToString();
            txtReqNo.TextBoxText = dgvWoReq.SelectedRows[0].Cells[1].Value.ToString();
            lblReq_Seq.Text = dgvWoReq.SelectedRows[0].Cells[0].Value.ToString();
            lblItem_Unit.Text = dgvWoReq.SelectedRows[0].Cells[2].Value.ToString();
            txtProcessSearch.TextBoxText = GlobalUsage.ProcessName;
            txtProcessSearch.CodeText = GlobalUsage.ProcessCode;
            txtWcSearch.TextBoxText = GlobalUsage.WcName;
            txtWcSearch.CodeText = GlobalUsage.WcCode;
        }

        private void btnKeypad_Click(object sender, EventArgs e)
        {
            KeypadForm frm = new KeypadForm();
            frm.FormSendEvent += new KeypadForm.FormSendDataHandler(DieaseUpdateEventMethod);
            frm.Show();
        }
        private void DieaseUpdateEventMethod(object sender)
        {
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call
            txtPlanQty.TextBoxText = sender.ToString();
        }
    }
}
