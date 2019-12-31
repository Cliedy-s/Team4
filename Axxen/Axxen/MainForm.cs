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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 사용자그룹관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSS_CON_001 frm = new MSS_CON_001();
            frm.Show();
        }
    }
}
