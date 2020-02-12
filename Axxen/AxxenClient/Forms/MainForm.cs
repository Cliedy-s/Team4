using AxxenClient.Templets;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace AxxenClient.Forms
{
    public partial class MainForm : ClientFreeForm
    {
        public int sysnoticeseq = 1;
        public int pronouncex = 0;
        public int originalx = 0;
        public bool runNotice = true;
        public MainForm()
        {
            InitializeComponent();
        }
        private class Typesss
        {
            public Typesss(string value1, WorkType value2)
            {
                this.value1 = value1;
                this.value2 = value2;
            }
            public string value1 { get; set; }
            public WorkType value2 { get; set; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if(login.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                return;
            }
            
            // 개발자용 콤보박스 설정
            List<Typesss> dic = new List<Typesss>();
            dic.Add(new Typesss("Molding", WorkType.Molding));
            dic.Add(new Typesss("Load", WorkType.Load));
            dic.Add(new Typesss("Boxing", WorkType.Boxing));

            aComboBox1.DataSource = dic;
            aComboBox1.DisplayMember = "value1";
            aComboBox1.ValueMember = "value2";

            // 초반 값 
            GlobalUsage.WcCode = ConfigurationManager.AppSettings["WcCode"];

            WorkCenter_MasterService service = new WorkCenter_MasterService();
            WorkCenter_Master2VO item = service.GetAll_WorkCenter_Master(GlobalUsage.WcCode);

            GlobalUsage.WcName = item.Wc_Name;
            GlobalUsage.WorkType = WorkType.Molding;
            GlobalUsage.ProcessCode = item.Process_Code;
            GlobalUsage.ProcessName = item.Process_name;

            POP_PRD_001 childfrm = new POP_PRD_001();
            childfrm.WindowState = FormWindowState.Maximized;
            childfrm.MdiParent = this;
            childfrm.Show();

            // 공지를 위한 라벨 로케이션
            childfrm.NoticeLocation = originalx = pronouncex = childfrm.GetPronounceX();
            timetimer.Start();
        }

        private void aButton1_Click(object sender, EventArgs e)
        { // 열기 버튼
            // 열려있는 폼들 닫기
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }   

            WorkType work = (WorkType)aComboBox1.SelectedValue;
            // 일 설정
            GlobalUsage.WorkType = work;

            // 작업장 설정
           switch (work)
            {
                case WorkType.Molding:
                    GlobalUsage.WcCode = "WC20001";
                    break;
                case WorkType.Load:
                    GlobalUsage.WcCode = "WC40001";
                    break;
                case WorkType.Boxing:
                    GlobalUsage.WcCode = "WC50001";
                    break;
                default:
                    break;
            }

            // 폼 열기
            POP_PRD_001 childfrm = new POP_PRD_001();
            childfrm.WindowState = FormWindowState.Maximized;
            childfrm.MdiParent = this;
            childfrm.Show();
        }

        private void timetimer_Tick(object sender, EventArgs e)
        {
            if (ActiveMdiChild is ClientBaseForm activatedchild)
            {
                activatedchild.MainTimerTick(pronouncex, originalx, runNotice);
                pronouncex = pronouncex - 30;
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timetimer.Stop();
        }

        public string GetCurrentSysNotice()
        {
            Sys_NoticeService service = new Sys_NoticeService();
            Sys_NoticeVO notice = service.GetCurrentSysNotice(sysnoticeseq);
            if (notice != null)
                return notice.Description;
            else
            {
                if (sysnoticeseq == 1)
                {
                    runNotice = false;
                    return "~공지사항~";
                }
                sysnoticeseq = 1;
                return service.GetCurrentSysNotice(1).Description;
            }
        }
    }
}
