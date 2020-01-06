using Axxen.Util;
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
    public partial class GridForm : BaseForm
    {
        public GridForm()
        {
            InitializeComponent();
        }

        private void GridForm_Load(object sender, EventArgs e)
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
        }
    }
}
