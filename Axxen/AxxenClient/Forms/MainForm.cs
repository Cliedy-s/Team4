using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class MainForm : AxxenClient.Templets.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GlobalUsage.WoIniChar = "W";
            GlobalUsage.WorkType = WorkType.Load;
            GlobalUsage.UserID = "master";
            GlobalUsage.WcCode = "WC1";

            POP_PRD_001 childfrm = new POP_PRD_001();
            childfrm.WindowState = FormWindowState.Maximized;
            childfrm.MdiParent = this;
            childfrm.Show();

            //foreach (Form item in this.MdiChildren)
            //{
            //    item.FormBorderStyle = FormBorderStyle.None;
            //} 
        }
    }
}
