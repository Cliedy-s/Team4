using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axxen.CustomControls
{
    public partial class ATextBox_Labeled : UserControl
    {
        public string LabelText { get { return lblName.Text; } set { lblName.Text = value; } }
        public string TextBoxText { get { return txtValue.Text; } set { txtValue.Text = value; } }
        public textboxType TxtType { get { return txtValue.txtType; } set { txtValue.txtType = value; } }
        public float FontSize { 
            set {
                Font lblfont = new Font(lblName.Font.FontFamily, value, lblName.Font.Style);
                lblName.Font = lblfont;
                Font txtfont = new Font(txtValue.Font.FontFamily, value, txtValue.Font.Style);
                txtValue.Font = txtfont;
            }
            get { return txtValue.Font.Size; }
        }
        public int SplitDistance { get { return splitContainer1.SplitterDistance; } set { splitContainer1.SplitterDistance = value; } }
        public ATextBox_Labeled()
        {
            InitializeComponent();
        }
    }
}
