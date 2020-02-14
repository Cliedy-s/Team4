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
    public partial class ClientBaseForm : Form
    {
        public ClientBaseForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int NoticeLocation { get { return txtPronounce.Location.X; } set { txtPronounce.Location = new Point(value, txtPronounce.Location.Y); } }
        public int GetPronounceX()
        {
            return panBottom.Size.Width - 100;
            //return txtPronounce.Location.X;
        }
        public void MainTimerTick(int pronouncex, int originalx, bool runNotice)
        {
            // 위 패널 시간 설정
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss");

            if (runNotice)
            {
                // 아래 패널 공지사항 설정
                if (!txtPronounce.Visible) txtPronounce.Visible = true;
                if (pronouncex <= 0)
                {
                    MainForm parent = (this.MdiParent as MainForm);
                    txtPronounce.Text = parent.GetCurrentSysNotice();
                    parent.pronouncex = originalx;
                    parent.sysnoticeseq++;
                    NoticeLocation = originalx;
                    return;
                }
                txtPronounce.Location = new Point(pronouncex, txtPronounce.Location.Y);
            }
        }
        private void ClientBaseForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = GlobalUsage.UserName;
            if (this.MdiParent is MainForm parent)
            {
                txtPronounce.Text = parent.GetCurrentSysNotice();
            }
        }
        private void ClientBaseForm_FormClosing(object sender, FormClosingEventArgs e)
        { // 폼 종료시 첫번째 폼 데이터 다시 가져오기
            if (!(sender is POP_PRD_001))
            {
                foreach (var item in this.MdiParent.MdiChildren)
                {
                    if (item is POP_PRD_001 frm)
                    {
                        frm.GetDatas();
                        frm.NoticeLocation = (this.MdiParent as MainForm).pronouncex;
                        break;
                    }
                }
            }
        }

        private void btnNoActive_Click(object sender, EventArgs e)
        {
            POP_PRD_016 frm = new POP_PRD_016();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
