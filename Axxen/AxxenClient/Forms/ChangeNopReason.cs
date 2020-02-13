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
    public partial class ChangeNopReason : AxxenClient.Templets.ClientFreeForm
    {
        public string NopMiCode { get; set; }
        string WcName;
        public ChangeNopReason(string wcname)
        {
            InitializeComponent();
            this.WcName = wcname;
        }
        private void ChangeNopReason_Load(object sender, EventArgs e)
        {
            lblWcName.Text = WcName;
            GetDatas();
        }
        private void GetDatas()
        {
            Nop_Ma_MasterService service = new Nop_Ma_MasterService();
            cboNopMa.DataSource = service.GetAllNopMA();
            cboNopMa.ValueMember = "Nop_Ma_Code";
            cboNopMa.DisplayMember = "Nop_Ma_Name";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboNopMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nop_Mi_MasterService service = new Nop_Mi_MasterService();
            cboNopMi.DataSource = service.GetAllNopMi(cboNopMa.SelectedValue.ToString());
            cboNopMi.ValueMember = "Nop_Mi_Code";
            cboNopMi.DisplayMember = "Nop_Mi_Name";
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            NopMiCode = cboNopMi.SelectedValue.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
