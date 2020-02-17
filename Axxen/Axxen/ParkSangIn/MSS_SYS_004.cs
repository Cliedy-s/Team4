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
    public partial class MSS_SYS_004 : Axxen.BaseForm
    {
        List<UserInfoVO> userlist;
        UserInfo_Service userservice = new UserInfo_Service();
        List<ScreenItem_MasterVO> screenitemlist; //모든 스크린 
        ScreenItemService screenservice = new ScreenItemService();

        public MSS_SYS_004()
        {
            InitializeComponent();
        }

        private void MSS_SYS_004_Load(object sender, EventArgs e)
        {
            dtpEnd.MaxDate = DateTime.Now;
          
          

            userlist = new List<UserInfoVO>();
            userlist = userservice.GetAllUser();
            screenitemlist = new List<ScreenItem_MasterVO>();
            screenitemlist = screenservice.GetALLScreenItem(); //모든스크린

            UserInfoVO ufirst = new UserInfoVO();

            userlist.Insert(0, ufirst);
            cbbUser.DisplayMember = "User_Name";
            cbbUser.ValueMember = "User_ID";
            cbbUser.DataSource = userlist;

            ScreenItem_MasterVO sfirst = new ScreenItem_MasterVO();
            screenitemlist.Insert(0, sfirst);
            cbbScreen.DisplayMember = "Type";
            cbbScreen.ValueMember = "Screen_Code";
            cbbScreen.DataSource = screenitemlist;

   
        DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "이름", "User_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "세션아이디", "Session_ID", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "화면명", "Type", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "로그인", "Login_Date", true, 210, default, true);
     DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "화면오픈", "Open_Date", true, 210, default, true);
            }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            int dayresult = DateTime.Compare(dtpstart.Value, dtpEnd.Value);
            if (dayresult>0)
            { 
                MessageBox.Show("날짜가 올바르지 않습니다.","알림",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }



               if (cbbUser.SelectedValue == null && cbbScreen.SelectedValue == null) //날짜만골랏을때
            {
                dgvGroup.DataSource = userservice.GetUser_Screen_Login(dtpstart.Value, dtpEnd.Value.AddDays(1), "0", "0");
            }

            else if (cbbScreen.SelectedValue == null) //유저만골랏을떄
            {
         

            dgvGroup.DataSource= userservice.GetUser_Screen_Login(dtpstart.Value, dtpEnd.Value.AddDays(1), "0", cbbUser.SelectedValue.ToString());
            }

          else  if (cbbUser.SelectedValue == null) //스크린만골랏을떄
            {


                dgvGroup.DataSource = userservice.GetUser_Screen_Login(dtpstart.Value, dtpEnd.Value.AddDays(1), cbbScreen.SelectedValue.ToString(), "0");
            }
          
            else
            {
                dgvGroup.DataSource = userservice.GetUser_Screen_Login(dtpstart.Value, dtpEnd.Value.AddDays(1), cbbScreen.SelectedValue.ToString(), cbbUser.SelectedValue.ToString());
            }

            //   dgvGroup.DataSource = userservice.GetUser_Screen_Login(dtpstart.Value, dtpEnd.Value, cbbScreen.SelectedValue.ToString(), cbbUser.SelectedValue.ToString());
        }
    }
}
