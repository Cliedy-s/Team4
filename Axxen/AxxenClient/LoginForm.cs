using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace AxxenClient
{
    public partial class LoginForm : AxxenClient.Templets.ClientFreeForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfo_Service service = new UserInfo_Service();
            UserInfoVO logininfo = service.GetLoginInfo(txtID.Text, txtPwd.Text);
            if(logininfo == null)
            {
                MessageBox.Show("아이디 비밀번호를 확인해주세요");
                return;
            }

            GlobalUsage.UserID = txtID.Text;
            GlobalUsage.UserName = logininfo.User_Name;
            this.DialogResult = DialogResult.OK;
        }
    }
}
