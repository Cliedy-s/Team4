using AxxenClient.Forms;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace AxxenClient.Templets
{
    public partial class ClientBaseForm : BaseForm
    {
        int sysnoticeseq { get; set; }
        int pronouncex;
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
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss");
            txtPronounce.Location = new Point(txtPronounce.Location.X-30, txtPronounce.Location.Y);
            if (txtPronounce.Location.X <= 0)
            {
                txtPronounce.Location = new Point(pronouncex, txtPronounce.Location.Y);
                GetCurrentSysNotice(sysnoticeseq++);
            }
        }
        private void GetCurrentSysNotice(int seq)
        {
            Sys_NoticeService service = new Sys_NoticeService();
            Sys_NoticeVO notice = service.GetCurrentSysNotice(seq);
            if (notice != null)
                txtPronounce.Text = notice.Description;
            else
            {
                sysnoticeseq = 1;
                txtPronounce.Text = service.GetCurrentSysNotice(sysnoticeseq).Description;
            }
        }

        private void ClientBaseForm_FormClosing(object sender, FormClosingEventArgs e)
        { // 폼 종료시 첫번째 폼 데이터 다시 가져오기
            if(!(sender is POP_PRD_001))
            {
                foreach (var item in this.MdiParent.MdiChildren)
                {
                    if (item is POP_PRD_001 frm)
                    {
                        frm.GetDatas();
                        break;
                    }
                }
            }
        }

        private void ClientBaseForm_Load(object sender, EventArgs e)
        {
            sysnoticeseq = 1;
            GetCurrentSysNotice(sysnoticeseq++);
            pronouncex = txtPronounce.Location.X;
        }
    }
}
