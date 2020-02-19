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
    }
}
