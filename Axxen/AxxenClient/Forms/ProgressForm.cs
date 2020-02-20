using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxxenClient
{
    public partial class ProgressForm : Form
    {
        public Action Worker;
        public ProgressForm(Action worker)
        {
            InitializeComponent();
            this.Worker = worker;
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }
        private void frmWaitForm_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(Worker).ContinueWith((t) => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
