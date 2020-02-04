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
    public partial class Progressbar : Form
    {
        public Action Worker;
        public Progressbar(Action worker)
        {
            InitializeComponent();
            InitializeComponent();
            this.Worker = worker;
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void Progressbar_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(Worker).ContinueWith((t) => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
