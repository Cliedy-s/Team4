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
        public type TextBoxType { get { return txtValue.txtType; } set { txtValue.txtType = value; } }
        public Font allfont
        {
            get { return this.Font; }
            set
            {
                this.Font = value;
                foreach (Control item in this.Controls)
                    item.Font = value;
            }
        }
        //public txttype 
        public float FontSize { 
            set {
                Font lblfont = new Font(lblName.Font.FontFamily, value, lblName.Font.Style);
                lblName.Font = lblfont;
                Font txtfont = new Font(txtValue.Font.FontFamily, value, txtValue.Font.Style);
                txtValue.Font = txtfont;
            }
            get { return txtValue.Font.Size; }
        }
        public ATextBox_Labeled()
        {
            InitializeComponent();
        }
    }
}
