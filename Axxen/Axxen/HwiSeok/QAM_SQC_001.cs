using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axxen
{
    public partial class QAM_SQC_001 : Axxen.FreeForm
    {
        public QAM_SQC_001()
        {
            InitializeComponent();
        }

        private void QAM_SQC_001_Load(object sender, EventArgs e)
        {
            Process.Start("https://team4webserver.azurewebsites.net/DefHistory/DefectiveDetails");
        }
    }
}
