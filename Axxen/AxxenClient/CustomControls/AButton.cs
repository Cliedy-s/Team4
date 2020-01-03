﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxxenClient.CustomControls
{
    public partial class AButton : Button
    {
        public AButton()
        {
            InitializeComponent();
            //Design
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
