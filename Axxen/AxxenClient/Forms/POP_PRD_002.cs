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
            dgvWoReq.DataSource = service.GetAllWoReqUnit();
        }
        /// <summary>
        /// 컨트롤 설정
        /// </summary>
        private void InitControls()
        {
            InitControlUtil.SetDGVDesign(dgvWoReq);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "의뢰순번", "Req_Seq", false, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "생산의뢰번호", "Wo_Req_No", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "품목코드", "Item_Code", false, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "품목명", "Item_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "의뢰수량", "Req_Qty", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "날짜", "Prd_Plan_Date", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "거래처", "Cust_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvWoReq, "상태", "Req_Status", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
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
                        Ins_Emp = GlobalUsage.Username,
                        Item_Code = txtItemSearch.CodeText,
                        Mat_LotNo = now.ToString("yyyyMMddhh"),
                        Plan_Qty = Convert.ToInt32(txtPlanQty.TextBoxText),
                        Plan_Unit = "Kg",
                        Wo_Req_No = txtReqNo.TextBoxText,
                        Req_Seq = Convert.ToInt32(lblReq_Seq.Text),
                        Wc_Code = txtWcSearch.CodeText,
                        Workorderno = "WO" + now.ToString("yyyyMMddhhmm"),
                        Wo_Status = "대기",
                        Wo_Order = "1"
                    });
                if (IsSuccess)
                    MessageBox.Show("성공적으로 생성하였습니다.", "작업지시생성");
                else
                    MessageBox.Show("생성에 실패하였습니다.", "작업지시생성");
                this.Close();
            }
            catch(Exception ee)
            {
                Debug.WriteLine(ee.ToString());
                MessageBox.Show("다시 입력해주세요");
            }

        }// 작업지시생성버튼
        private void dgvWorkOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemSearch.TextBoxText = dgvWoReq.SelectedRows[0].Cells[3].Value.ToString();
            txtItemSearch.CodeText = dgvWoReq.SelectedRows[0].Cells[2].Value.ToString();
            txtReqNo.TextBoxText = dgvWoReq.SelectedRows[0].Cells[1].Value.ToString();
            lblReq_Seq.Text = dgvWoReq.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void POP_PRD_002_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in this.MdiParent.MdiChildren)
            {
                if(item is POP_PRD_001 frm)
                {
                    frm.GetDatas();
                    break;
                }
            } 
        } // 폼 종료시 첫번째 폼 데이터 다시 가져오기
    }
}
