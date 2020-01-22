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

        public PPS_SCH_001_Insert()
        {
            InitializeComponent();
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

            txtItemName.Enabled = false;
            txtxItemCode.Enabled = false;
            txtInQty.Enabled = false;
            txtOutQty.Enabled = false;
            txtPrdQty.Enabled = false;

            foreach (var name in namelist)
            {
                cboWorkCenter.Items.Add(name.Wc_Name);
            };
        }
    }
}
