using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace AxxenClient.Forms
{
    public partial class LoginForm : AxxenClient.Templets.ClientFreeForm
    {
        public string Username {get;set; }
        public string UserID { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfo_Service uservice = new UserInfo_Service();
            UserInfoVO logininfo = uservice.GetLoginInfo(txtID.Text, txtPwd.Text);
            if(logininfo == null)
            {
                MessageBox.Show("아이디 비밀번호를 확인해주세요");
                return;
            }
            Emp_Wc_AllocationService service = new Emp_Wc_AllocationService();
            if((!service.IsAllocated(logininfo.User_ID, GlobalUsage.WcCode)) && !logininfo.User_ID.Equals("master"))
            {
                MessageBox.Show("할당되지 않은 작업자입니다.");
                return;
            }

            GlobalUsage.UserID = txtID.Text;
            GlobalUsage.UserName = logininfo.User_Name;

            // 세션 set
            Random r = new Random();
                // 신규비밀번호 = 랜덤8자리(영문대문자 + 숫자)
            StringBuilder session = new StringBuilder();
            for (int i = 0; i < 12; i++)
            {
                int rndVal = r.Next(0, 36);
                if (rndVal < 10) //숫자
                {
                    session.Append(rndVal);
                }
                else
                {
                    session.Append((char)(rndVal + 55)); //65~90 : 영어대문자
                }
            }

            Login_History loginhistory = new Login_History()
            {
                Session_ID = session.ToString(),
                User_ID = logininfo.User_ID,
                Login_Day = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                Login_Date = DateTime.Now,
                Login_Success = "Y"
            };

            uservice.InsertLogin_History(loginhistory);
            this.DialogResult = DialogResult.OK;


        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
