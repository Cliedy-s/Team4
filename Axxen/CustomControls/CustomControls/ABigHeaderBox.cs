using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axxen.CustomControls
{
    public partial class ABigHeaderBox : UserControl
    {
        public string HeaderBoxText { get { return this.aLabel1.Text; } set { this.aLabel1.Text = value; } }
        public Font allfont
        {
            get { return this.Font; }
            set
            {
                this.Font = value;
                aLabel1.Font = value;
            }
        }
        public ABigHeaderBox()
        {
            InitializeComponent();
            aLabel2.Font = new Font("굴림", 14);
        }
    }
}
