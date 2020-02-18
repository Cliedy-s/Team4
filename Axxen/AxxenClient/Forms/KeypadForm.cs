using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class KeypadForm : AxxenClient.Templets.ClientFreeForm
    {
        public KeypadForm()
        {
            InitializeComponent();
        }

        public delegate void FormSendDataHandler(string sendstring);
        public event FormSendDataHandler FormSendEvent;

        bool cFlag = false;
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string num = btn.Text;
            if (txtNum.Text == "0" || !cFlag)
            {
                txtNum.Text = num;
                cFlag = true;
            }
            else
                txtNum.Text = txtNum.Text + num;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (txtNum.Text.Contains(".") == false)
                txtNum.Text += ".";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            txtNum.Text = txtNum.Text.Remove(txtNum.Text.Length - 1);
            if (txtNum.Text.Length == 0)
                txtNum.Text = "";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.FormSendEvent(txtNum.Text);
            this.Close();
        }
    }
}
