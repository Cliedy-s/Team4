using AxxenClient.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Templets
{
    public partial class ClientBaseForm : BaseForm
    {
        public ClientBaseForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClientBaseForm_Activated(object sender, EventArgs e)
        {
            timetimer.Start();
        }

        private void ClientBaseForm_Deactivate(object sender, EventArgs e)
        {
            timetimer.Stop();
        }

        private void timetimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
