using Axxen.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axxen
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            // form.KeyPreView = True
            Form frm = sender as Form;
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(frm.ActiveControl, true, true, true, true);
        }

        private void BaseForm_Load(object sender, System.EventArgs e)
        {
            //Team4TextBox 컨트롤을 모두 찾아서 ErrorProvider를 설정해줌
            var controls = GetAll(this, typeof(ATextBox));
            foreach (ATextBox tb in controls)
            {
                tb.errorp = this.baseErrorProvider;
            }
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }
    }
}
