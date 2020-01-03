using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.CustomControls
{
    public partial class AHeaderBox : UserControl
    {
        public string HeaderBoxText { get { return this.aLabel1.Text; } set { this.aLabel1.Text = value; } }
        public AHeaderBox()
        {
            InitializeComponent();
            aLabel2.Font = new Font("굴림", 9);
        }
    }
}
