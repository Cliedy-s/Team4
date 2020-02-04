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
        private class Typesss{
            public Typesss(string value1, WorkType value2)
            {
                this.value1 = value1;
                this.value2 = value2;
            }
            public string value1 { get; set; }
            public WorkType value2 { get; set; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Typesss> dic = new List<Typesss>();
            dic.Add(new Typesss("Molding", WorkType.Molding));
            dic.Add(new Typesss("Load", WorkType.Load));
            dic.Add(new Typesss("Boxing", WorkType.Boxing));

            aComboBox1.DataSource = dic;
            aComboBox1.DisplayMember = "value1";
            aComboBox1.ValueMember = "value2";

            GlobalUsage.WoIniChar = "W";
            GlobalUsage.WorkType = WorkType.Boxing;
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

        private void aButton1_Click(object sender, EventArgs e)
        {
            GlobalUsage.WorkType = (WorkType)aComboBox1.SelectedValue;
            POP_PRD_001 childfrm = new POP_PRD_001();
            childfrm.WindowState = FormWindowState.Maximized;
            childfrm.MdiParent = this;
            childfrm.Show();
        }
    }
}
