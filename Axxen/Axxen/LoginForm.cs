using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            using (Progressbar frm = new Progressbar(aaa))
            {
                frm.ShowDialog(this);
            }

          

        }
        private void aaa()
        {
            UserInfo_Service service = new UserInfo_Service();

            UserInfoVO uservo = service.GetUserInfo(txtID.Text, txtPwd.Text);
            if (uservo.User_ID == null)
            {
                MessageBox.Show("등록되지 않은아이디");
                return;
            }
            else
            {
                UserInfo.User_ID = uservo.User_ID;
                UserInfo.User_Name = uservo.User_Name;
                UserInfo.User_PW = uservo.User_PW;
                UserInfo.Customer_Code = uservo.Customer_Code;
                UserInfo.DefaultLanguage = uservo.DefaultLanguage;
                UserInfo.User_Type = uservo.User_Type;
                UserInfo.Price_Visible_YN = uservo.Price_Visible_YN;
                UserInfo.IP_Security_YN = uservo.IP_Security_YN;
                UserInfo.Pw_Reset_Count = uservo.Pw_Reset_Count;
                UserInfo.Default_Screen_Code = uservo.Default_Screen_Code;
                UserInfo.Default_Process_Code = uservo.Default_Process_Code;
                UserInfo.Monitoring_YN = uservo.Monitoring_YN;
                UserInfo.Use_YN = uservo.Use_YN;
                UserInfo.S01 = uservo.S01;
                UserInfo.S02 = uservo.S02;
                UserInfo.S03 = uservo.S03;
                UserInfo.S04 = uservo.S04;
                UserInfo.S05 = uservo.S05;
                UserInfo.S06 = uservo.S06;
                UserInfo.S07 = uservo.S07;
                UserInfo.S08 = uservo.S08;
                UserInfo.S09 = uservo.S09;
                UserInfo.S10 = uservo.S10;
                UserInfo.S11 = uservo.S11;
                UserInfo.S12 = uservo.S12;
                UserInfo.Ins_Date = uservo.Ins_Date;
                UserInfo.Ins_Emp = uservo.Ins_Emp;
                UserInfo.Up_Date = uservo.Up_Date;
                UserInfo.Up_Emp = uservo.Up_Emp;
            }
        }

    }
}
