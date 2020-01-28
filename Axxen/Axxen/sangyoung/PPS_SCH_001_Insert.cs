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
        public PPS_SCH_001_Insert()
        {
            InitializeComponent();
        }

        public PPS_SCH_001_Insert(string code, string name, int qty) : this()
        {
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

            txtItemCode.Text = code;
            txtItemName.Text = name;
            txtPlanQty.Text = qty;

            txtItemName.Enabled = false;
            txtItemCode.Enabled = false;
            txtPlanQty.Enabled = false;
            txtInQty.Enabled = false;
            txtOutQty.Enabled = false;
            txtPrdQty.Enabled = false;

            cboWorkCenter.Items.Add("==선택==");
            foreach (var name in namelist)
            {
                cboWorkCenter.Items.Add(name.Wc_Name);
            };
            cboWorkCenter.SelectedIndex = 0;
        }
    }
}
