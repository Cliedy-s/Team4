using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxxenClient.CustomControls
{
    public partial class ATextBox_LabeledBigTextBox : UserControl
    {
        public string LabelText { get { return lblName.Text; } set { lblName.Text = value; } }
        public string TextBoxText { get { return txtValue.Text; } set { txtValue.Text = value; } }
        public ATextBox_LabeledBigTextBox()
        {
            InitializeComponent();
        }
    }
}
