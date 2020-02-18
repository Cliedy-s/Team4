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
    public partial class POP_PRD_009 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_009()
        {
            InitializeComponent();
        }

        private void POP_PRD_009_Load(object sender, EventArgs e)
        {

            InitControls();
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvGVList);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "건조대차", "GV_Name", true, 110);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "품목코드", "Item_Code", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "품목명", "Item_Name", true, 200, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "수량", "Loading_Qty", true, 100, DataGridViewContentAlignment.MiddleLeft);

            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "품목이름", "Item_Name", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "품목이름", "Item_Code", false, 100); 
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "작업장코드", "Wc_Code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "작업장명", "Wc_Code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "공정코드", "Process_code", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "공정이름", "Process_name", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "작업지시일", "Plan_Date", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "계획수량", "Plan_Qty", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "계획단위", "Prd_Unit", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "생산의뢰번호", "Wo_Req_No", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "생산의뢰순서", "Req_Seq", false, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "대차이력 순서", "Hist_Seq", false);


            dgvGVList.Columns[10].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            List<GVStatusVO> list = service.GetGVCurrentStatus(gvStatus: "적재", gvGroup: "건조그룹");
            dgvGVList.DataSource =
                (from gv in list
                 where gv.Unloading_Qty == null
                 select gv).ToList();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            List<GVStatusVO> list = service.GetGVCurrentStatus(gvStatus: "적재", gvGroup: "건조그룹", gvName: txtGVSearch.TextBoxText);
            dgvGVList.DataSource =
                (from gv in list
                 where gv.Unloading_Qty == null
                 select gv).ToList();
            
        }
        private void dgvGVList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemSearch.TextBoxText =(dgvGVList.SelectedRows[0].Cells[2].Value ?? "").ToString();
            txtItemSearch.CodeText = (dgvGVList.SelectedRows[0].Cells[1].Value ?? "").ToString();
            txtProcessSearch.TextBoxText = (dgvGVList.SelectedRows[0].Cells[9].Value ?? "").ToString();
            txtProcessSearch.CodeText = (dgvGVList.SelectedRows[0].Cells[8].Value ?? "").ToString();
            txtWcSearch.TextBoxText = (dgvGVList.SelectedRows[0].Cells[7].Value ?? "").ToString();
            txtWcSearch.CodeText = (dgvGVList.SelectedRows[0].Cells[6].Value ?? "").ToString();
            txtPlanDate.TextBoxText = (dgvGVList.SelectedRows[0].Cells[10].Value ?? "").ToString();
            txtPlanQty.TextBoxText = (dgvGVList.SelectedRows[0].Cells[3].Value ?? "").ToString();
            lblUnit.Text = (dgvGVList.SelectedRows[0].Cells[12].Value ?? "").ToString();
            lblReqNo.Text = (dgvGVList.SelectedRows[0].Cells[13].Value ?? "").ToString();
            lblReqSeq.Text = (dgvGVList.SelectedRows[0].Cells[14].Value ?? "").ToString();
            lblHistSeq.Text = (dgvGVList.SelectedRows[0].Cells[15].Value ?? "").ToString();
        }
        private void btnCreateWorkOrder_Click(object sender, EventArgs e)
        {   // 작업지시 생성
            DateTime now = DateTime.Now;
            WorkOrder_Service service = new WorkOrder_Service();
            WorkOrderNewVO item = new WorkOrderNewVO();
            item.Ins_Emp = GlobalUsage.UserID;
            item.Item_Code = txtItemSearch.CodeText;
            item.Mat_LotNo = "MAT" + now.ToString("yyyyMMddHHmmss");
            item.Plan_Qty = Convert.ToInt32(txtPlanQty.TextBoxText);
            item.Plan_Unit = lblUnit.Text;
            item.Wo_Req_No = lblReqNo.Text;
            item.Req_Seq = Convert.ToInt32(lblReqSeq.Text);
            item.Wc_Code =GlobalUsage.WcCode;
            item.Wo_Order = "4";
            item.Wo_Status = "생산대기";
            item.Prd_Unit = lblUnit.Text;
            if (service.InsertWorkOrder(item, lblHistSeq.Text))
            {

                Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 생산지시({lblReqNo.Text})에 관한 작업장({GlobalUsage.WcCode})의 작업지시를 {now.ToString("yyyy-MM-dd HH:mm:ss")}에 생성하였음");
                this.Close();
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 생산지시({lblReqNo.Text})에 관한 작업장({GlobalUsage.WcCode})의 작업지시를 {now.ToString("yyyy-MM-dd HH:mm:ss")}에 생성하려했으나 실패하였음");
                MessageBox.Show("작업지시 생성에 실패하였습니다.");
            }

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
