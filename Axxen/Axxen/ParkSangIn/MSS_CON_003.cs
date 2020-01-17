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
    public partial class MSS_CON_003 : Axxen.BaseForm
    {
        UserInfo_Service userService = new UserInfo_Service();
        List<UserInfoVO> userlist;
        public MSS_CON_003()
        {
            InitializeComponent();
        }

        private void MSS_CON_003_Load(object sender, EventArgs e)
        {

            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            DatagridviewDesigns.SetDesign(dgvUser);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvUser, "아이디", "User_ID", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvUser, "이름", "User_Name", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvUser, "사용유무", "Use_YN", true, 200, default, true);

            //DatagridviewDesigns.SetDesign(dgvUseScreen);
            //DatagridviewDesigns.AddNewColumnToDataGridView(dgvUseScreen, "화면코드", "Screen_Code", true, 200, default, true);
            //DatagridviewDesigns.AddNewColumnToDataGridView(dgvUseScreen, "화면명", "Type", true, 200, default, true);
            //DatagridviewDesigns.AddNewColumnToDataGridView(dgvNotUseScreen, "화면경로", "Screen_Path", true, 200, default, true);
            //DatagridviewDesigns.AddNewColumnToDataGridView(dgvUseScreen, "설정자", "Ins_Emp", true, 200, default, true);
            //DatagridviewDesigns.AddNewColumnToDataGridView(dgvUseScreen, "입력일", "Ins_Date", true, 200, default, true);
            GetAllUser();
        }
        private void GetAllUser()
        {
            userlist = new List<UserInfoVO>();
            userlist = userService.GetAllUser();
            dgvUser.DataSource = userlist;

        }
        public void InsertFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    MSS_CON_003_1 frm = new MSS_CON_003_1();

                    frm.ShowDialog();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void MSS_CON_003_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
        }
    }
}
