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
            
        }

        private void InitControl()
        {
            txtInQty.Text = "0";
            txtPrdQty.Text = "0";
            txtOutQty.Text = "0";

            txtSeq.Text = seq;
            txtReqNo.Text = reqno;
            txtItemCode.Text = code;
            txtItemName.Text = name;
            txtPlanQty.Text = qty;

            txtSeq.Enabled = false;
            txtReqNo.Enabled = false;
            txtItemName.Enabled = false;
            txtItemCode.Enabled = false;
            txtPlanQty.Enabled = false;
            txtInQty.Enabled = false;
            txtOutQty.Enabled = false;
            txtPrdQty.Enabled = false;
           
            cboWorkCenter.ValueMember = "Wc_Code";
            cboWorkCenter.DisplayMember = "Wc_Name";
            cboWorkCenter.DataSource = namelist;
            cboWorkCenter.Text = "==선택==";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            WorkOrder_WC_ItemVO work = new WorkOrder_WC_ItemVO();
            work.Req_Seq = Convert.ToInt32(txtSeq.Text);
            work.Wo_Req_No = txtReqNo.Text;
            work.Workorderno = txtWoorderno.Text;
            work.Wo_Status = "생산대기";
            work.Wc_Code = cboWorkCenter.SelectedValue.ToString();
            work.Remark = txtRemark.Text;
            work.Plan_Qty = Convert.ToInt32(txtPlanQty.Text);
            work.Out_Qty_Main = Convert.ToInt32(txtOutQty.Text);
            work.In_Qty_Main = Convert.ToInt32(txtInQty.Text);
            work.Prd_Qty = Convert.ToInt32(txtPrdQty.Text);
            work.Prd_Date = dtpDate.Value;
            work.Item_Code = txtItemCode.Text;
            work.Paln_Unit = txtPlanUnit.Text;

        }
    }
}
