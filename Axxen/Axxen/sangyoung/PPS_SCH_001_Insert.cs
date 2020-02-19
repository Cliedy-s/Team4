using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VO;

namespace Axxen.sangyoung
{
    public partial class PPS_SCH_001_Insert : Form
    {
        List<WorkOrder_J_WC_ItmeVO> namelist = new List<WorkOrder_J_WC_ItmeVO>();
        WorkOrder_Service workservice = new WorkOrder_Service();

        string code = string.Empty;
        string name = string.Empty;
        string qty = string.Empty;
        string reqno = string.Empty;
        string seq = string.Empty;

        public PPS_SCH_001_Insert()
        {
            InitializeComponent();
        }

        public PPS_SCH_001_Insert(int seq, string reqno, string code, string name, int qty) : this()
        {
            this.seq = seq.ToString();
            this.reqno = reqno;
            this.code = code;
            this.name = name;
            this.qty = qty.ToString();
        }

        private void PPS_SCH_001_Insert_Load(object sender, EventArgs e)
        {
            Wo_ReqService service = new Wo_ReqService();
            namelist = service.GetWorkCenterName();
            InitControl();

            this.Icon = 
        }

        private void InitControl()
        {
            txtSeq.Text = seq;
            txtReqNo.Text = reqno;
            txtItemCode.Text = code;
            txtItemName.Text = name;
            txtPlanQty.Text = qty;
            txtPlanUnit.Text = "EA";

            txtPlanUnit.Enabled = false;
            txtSeq.Enabled = false;
            txtReqNo.Enabled = false;
            txtItemName.Enabled = false;
            txtItemCode.Enabled = false;
            txtPlanQty.Enabled = false;

            cboWorkCenter.DataSource = namelist;
            cboWorkCenter.DisplayMember = "Wc_Name";
            cboWorkCenter.ValueMember = "Wc_Code";
            cboWorkCenter.Text = "==선택==";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            WorkOrderAllVO order = new WorkOrderAllVO();
            order.Req_Seq = Convert.ToInt32(txtSeq.Text);
            order.Wo_Req_No = txtReqNo.Text;
            order.Wo_Status = "생산대기";
            order.Wc_Code = cboWorkCenter.SelectedValue.ToString();
            order.Remark = txtRemark.Text;
            order.Plan_Qty = Convert.ToInt32(txtPlanQty.Text);
            order.Out_Qty_Main = 0;
            order.In_Qty_Main = 0;
            order.Prd_Qty = 0;
            order.Plan_Date = dtpDate.Value;
            order.Item_Code = txtItemCode.Text;
            order.Plan_Unit = txtPlanUnit.Text;
            order.Prd_Unit = txtPlanUnit.Text;
            try
            {
                bool result = workservice.InsertPPSWorkorder(order, UserInfo.User_ID);
                if (result)
                {
                    MessageBox.Show("작업지시가 생성되었습니다.", "작업지시관리", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("작업지시가 생성되지 않았습니다.", "작업지시관리", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                Program.Log.WriteError(err.Message);
            }
        }
    }
}
