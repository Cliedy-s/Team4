﻿using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VO;

namespace Axxen
{
   


    public partial class LoginForm : Form
    {
      
        Login_History logininfo;
        List<UserInfoVO> userlist = new List<UserInfoVO>();
        UserInfoVO uservo = new UserInfoVO();
        UserInfo_Service service = new UserInfo_Service();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            //using (WaitForm frm = new WaitForm(wait))
            //{
            //    frm.ShowDialog(this);
            //}
            wait();
        }
        private void wait()
        {

            UserInfo_Service service = new UserInfo_Service();
            UserInfoVO userinfo = service.GetLoginInfo(txtID.Text, txtPwd.Text);
            if (userinfo == null)
            {
                MessageBox.Show("아이디 비밀번호를 확인해주세요");
                return;
            }

            UserInfo.User_ID = userinfo.User_ID;
            UserInfo.User_Name = userinfo.User_Name;
            UserInfo.User_PW = userinfo.User_PW;
            UserInfo.Customer_Code = userinfo.Customer_Code;
            UserInfo.DefaultLanguage = userinfo.DefaultLanguage;
            UserInfo.User_Type = userinfo.User_Type;
            UserInfo.Price_Visible_YN = userinfo.Price_Visible_YN;
            UserInfo.IP_Security_YN = userinfo.IP_Security_YN;
            UserInfo.Pw_Reset_Count = userinfo.Pw_Reset_Count;
            UserInfo.Default_Screen_Code = userinfo.Default_Screen_Code;
            UserInfo.Default_Process_Code = userinfo.Default_Process_Code;
            UserInfo.Monitoring_YN = userinfo.Monitoring_YN;
            UserInfo.Use_YN = userinfo.Use_YN;
            UserInfo.S01 = userinfo.S01;
            UserInfo.S02 = userinfo.S02;
            UserInfo.S03 = userinfo.S03;
            UserInfo.S04 = userinfo.S04;
            UserInfo.S05 = userinfo.S05;
            UserInfo.S06 = userinfo.S06;
            UserInfo.S07 = userinfo.S07;
            UserInfo.S08 = userinfo.S08;
            UserInfo.S09 = userinfo.S09;
            UserInfo.S10 = userinfo.S10;
            UserInfo.S11 = userinfo.S11;
            UserInfo.S12 = userinfo.S12;
            UserInfo.Ins_Date = userinfo.Ins_Date;
            UserInfo.Ins_Emp = userinfo.Ins_Emp;
            UserInfo.Up_Date = userinfo.Up_Date;
            UserInfo.Up_Emp = userinfo.Up_Emp;

            Random r = new Random();
            //신규비밀번호 = 랜덤8자리(영문대문자 + 숫자)
            string pwd = string.Empty;

            for (int i = 0; i < 12; i++)
            {
                int rndVal = r.Next(0, 36);
                if (rndVal < 10) //숫자
                {
                    pwd += rndVal;
                }
                else
                {
                    pwd += (char)(rndVal + 55); //65~90 : 영어대문자
                }
            }
            UserInfo.Session_ID = pwd;

            logininfo = new Login_History()
            {
                Session_ID = pwd,
                User_ID = userinfo.User_ID,
                Login_Day = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                Login_Date = DateTime.Now,
                Login_Success = "Y"

            };

            service.InsertLogin_History(logininfo);
            this.DialogResult = DialogResult.OK;



            //userlist = service.GetAllUser();

            //try 
            //{
            //    if (userlist.Count(item => item.User_ID == txtID.Text) > 0)
            //    {
            //        if (userlist.Count(item => item.User_PW == txtPwd.Text) > 0)
            //        {
            //            uservo = userlist.Find(item => item.User_ID == txtID.Text && item.User_PW == txtPwd.Text);

            //            UserInfo.User_ID = uservo.User_ID;
            //            UserInfo.User_Name = uservo.User_Name;
            //            UserInfo.User_PW = uservo.User_PW;
            //            UserInfo.Customer_Code = uservo.Customer_Code;
            //            UserInfo.DefaultLanguage = uservo.DefaultLanguage;
            //            UserInfo.User_Type = uservo.User_Type;
            //            UserInfo.Price_Visible_YN = uservo.Price_Visible_YN;
            //            UserInfo.IP_Security_YN = uservo.IP_Security_YN;
            //            UserInfo.Pw_Reset_Count = uservo.Pw_Reset_Count;
            //            UserInfo.Default_Screen_Code = uservo.Default_Screen_Code;
            //            UserInfo.Default_Process_Code = uservo.Default_Process_Code;
            //            UserInfo.Monitoring_YN = uservo.Monitoring_YN;
            //            UserInfo.Use_YN = uservo.Use_YN;
            //            UserInfo.S01 = uservo.S01;
            //            UserInfo.S02 = uservo.S02;
            //            UserInfo.S03 = uservo.S03;
            //            UserInfo.S04 = uservo.S04;
            //            UserInfo.S05 = uservo.S05;
            //            UserInfo.S06 = uservo.S06;
            //            UserInfo.S07 = uservo.S07;
            //            UserInfo.S08 = uservo.S08;
            //            UserInfo.S09 = uservo.S09;
            //            UserInfo.S10 = uservo.S10;
            //            UserInfo.S11 = uservo.S11;
            //            UserInfo.S12 = uservo.S12;
            //            UserInfo.Ins_Date = uservo.Ins_Date;
            //            UserInfo.Ins_Emp = uservo.Ins_Emp;
            //            UserInfo.Up_Date = uservo.Up_Date;
            //            UserInfo.Up_Emp = uservo.Up_Emp;



            //            Random r = new Random();
            //            //신규비밀번호 = 랜덤8자리(영문대문자 + 숫자)
            //            string pwd = string.Empty;

            //            for (int i = 0; i < 12; i++)
            //            {
            //                int rndVal = r.Next(0, 36);
            //                if (rndVal < 10) //숫자
            //                {
            //                    pwd += rndVal;
            //                }
            //                else
            //                {
            //                    pwd += (char)(rndVal + 55); //65~90 : 영어대문자
            //                }
            //            }
            //            UserInfo.Session_ID = pwd;

            //            logininfo = new Login_History()
            //            {
            //                Session_ID = pwd,
            //                User_ID = uservo.User_ID,
            //                Login_Day = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
            //                Login_Date = DateTime.Now,
            //                Login_Success = "Y"

            //            };

            //            service.InsertLogin_History(logininfo);
            //            this.DialogResult = DialogResult.OK;
            //        }
            //        else
            //        {
            //            MessageBox.Show("비밀번호가 올바르지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("등록되지 않은아이디입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        return;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    
    }
}
