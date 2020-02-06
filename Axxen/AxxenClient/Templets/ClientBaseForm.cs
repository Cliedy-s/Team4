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
        public int GetPronounceX()
        {
            return panBottom.Size.Width-100;
            //return txtPronounce.Location.X;
        }
        public void MainTimerTick(int pronouncex, int originalx)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd\nHH:mm:ss");
            if (pronouncex <= 0)
            {
                MainForm parent = (this.MdiParent as MainForm);
                parent.pronouncex = originalx;
                parent.sysnoticeseq++;
                txtPronounce.Text = parent.GetCurrentSysNotice();
                txtPronounce.Location = new Point(originalx, txtPronounce.Location.Y);
                return;
            }
            txtPronounce.Location = new Point(pronouncex, txtPronounce.Location.Y);
        }
        private void ClientBaseForm_Load(object sender, EventArgs e)
        {
            if (this.MdiParent is MainForm parent)
            {
                txtPronounce.Location = new Point(panBottom.Size.Width - 100, txtPronounce.Location.Y);
                txtPronounce.Text = parent.GetCurrentSysNotice();
                txtPronounce.Visible = true;
                parent.sysnoticeseq++;
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
                        break;
                    }
                }
            }
        }

    }
}
