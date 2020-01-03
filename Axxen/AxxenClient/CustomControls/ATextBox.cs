using System;
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
    public enum textboxType { Normal, Numeric, Required }
    public partial class ATextBox : TextBox
    {
        private textboxType txttype;
        public textboxType txtType
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
                    case textboxType.Numeric:
                        this.BackColor = Color.HotPink;
                        this.KeyPress += Team4TextBox_numberKeyPress;
                        break;
                    case textboxType.Normal:
                        this.BackColor = Color.White;
                        break;
                    case textboxType.Required:
                        this.BackColor = Color.Yellow;
                        this.Validating += Team4TextBox_Validating;
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
            txtType = textboxType.Normal;
            this.BorderStyle = BorderStyle.FixedSingle;
            //
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        private void Team4TextBox_numberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
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
