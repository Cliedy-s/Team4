﻿using System;
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
            POP_PRD_001 childfrm = new POP_PRD_001(WorkType.Molding);
            childfrm.WindowState = FormWindowState.Maximized;
            childfrm.MdiParent = this;
            childfrm.Show();
        }
    }
}
