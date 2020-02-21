using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class MSS_SYS_009_1 : Axxen.BaseForm
    {
        public Sys_NoticeVO notice { get; set; }
        public MSS_SYS_009_1()
        {
            InitializeComponent();
        }

        private void MSS_SYS_009_1_Load(object sender, EventArgs e)
        {
            lblid.Text = notice.Req;
            txttitle.Text = notice.Title;
            txtstart.Text = notice.Notice_Date;
            txtend.Text = notice.Notice_End;
            txtde.Text = notice.Description;
        }

        private void AButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
