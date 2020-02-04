using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class ChangeNopReason : AxxenClient.Templets.FreeForm
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
            // TODO - 데이터 가져오기 (2020-02-04)
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
