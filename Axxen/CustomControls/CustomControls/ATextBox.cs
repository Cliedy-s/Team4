using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axxen.CustomControls
{
    public enum TextType { Normal, Numeric, Required, ReadOnly }
    public partial class ATextBox : TextBox
    {

        private TextType txttype;
        public TextType txtType
        {
            get
            {
                return this.txttype;
            }
            set
            {
                txttype = value;
                this.KeyPress -= Team4TextBox_numberKeyPress;
                this.Validating -= Team4TextBox_Validating;
                switch (value)
                {
                    case TextType.Numeric:
                        //this.BackColor = Color.HotPink;
                        this.KeyPress += Team4TextBox_numberKeyPress;
                        break;
                    case TextType.Normal:
                        this.BackColor = Color.White;
                        break;
                    case TextType.Required:
                        this.BackColor = Color.FromArgb(255, 255, 190);
                        this.Validating += Team4TextBox_Validating;
                        break;
                    case TextType.ReadOnly:
                        this.ReadOnly = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public ErrorProvider errorp { get; set; }

        public ATextBox()
        {
            InitializeComponent();
            //Design
            txtType = TextType.Normal;
            this.BorderStyle = BorderStyle.FixedSingle;
            //
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void Team4TextBox_numberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
        private void Team4TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text.Trim()))
            {
                errorp.SetError(this, "값을 입력해주세요");
                e.Cancel = true;
            }
            else
            {
                errorp.Clear();
            }
        }
    }
}
