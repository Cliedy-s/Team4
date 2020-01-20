using Service;
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
    public partial class MSS_CON_003_1 : Axxen.BaseForm
    {
        public MSS_CON_003_1()
        {
            InitializeComponent();
        }

        private void MSS_CON_003_1_Load(object sender, EventArgs e)
        {
            lblManager.Text = UserInfo.User_Name;
            lblDay.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UserInfoVO user = new UserInfoVO
            {
                User_Name = txtName.Text,
                User_ID = txtID.Text,
                User_PW = txtPwd.Text,
                Ins_Emp = lblManager.Text,
                Ins_Date = Convert.ToDateTime(lblDay.Text)

            };
            UserInfo_Service service = new UserInfo_Service();
         bool bFlag =   service.InsertUser(user);
            if (bFlag)
            {
                MessageBox.Show("등록");
            }
            else
            {

                MessageBox.Show("등록실패");
            }
        }
    }
}
