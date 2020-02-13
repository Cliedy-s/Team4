using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class InputBox : AxxenClient.Templets.ClientFreeForm
    {
        public int? Qty { get; set; } = null;
        public InputBox()
        {
            InitializeComponent();
        }

        private void btnToSearch_Click(object sender, EventArgs e)
        {
            this.Qty = Convert.ToInt32(txtQty.TextBoxText);
            this.DialogResult = DialogResult.OK;
        }

        private void aButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
