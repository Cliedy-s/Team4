using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class MSS_CON_003 : Axxen.BaseForm
    {

        List<UserInfoVO> userlist;
        List<UserInfoVO> groupuserlist; //권한부여받은 유저들
        UserInfo_Service userService = new UserInfo_Service();
        List<UserGroup_MasterVO> grouplist;
        List<UserGroup_MappingVO> groupMappinglist;
        List<UserGroup_MappingVO> subMappinglist;
        UserGroupService groupservice = new UserGroupService();
        public MSS_CON_003()
        {
            InitializeComponent();
        }

        private void MSS_CON_003_Load(object sender, EventArgs e)
        {

            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);

            DatagridviewDesigns.SetDesign(dgvUser);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvUser, "아이디", "User_ID", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvUser, "이름", "User_Name", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvUser, "사용유무", "Use_YN", true, 200, default, true);

            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "사용자그룹코드", "UserGroup_Code", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "사용자그룹명", "UserGroup_Name", true, 100, default, true);

            DatagridviewDesigns.SetDesign(dgvJoin);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvJoin, "아이디", "User_ID", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvJoin, "이름", "User_Name", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvJoin, "사용유무", "Use_YN", true, 200, default, true);


            DataGridViewCheckBoxColumn gridcheckbox = new DataGridViewCheckBoxColumn();
            gridcheckbox.HeaderText = "선택";
            gridcheckbox.Name = "checkbtn";
            gridcheckbox.FalseValue = "false";
            gridcheckbox.TrueValue = "true";
            dgvJoin.Columns.Insert(0, gridcheckbox);

            GetAllUser();
            GetAllUserGroup();
          
            ControlSetting();
        }
        /// <summary>
        /// 유저목록
        /// </summary>
        private void GetAllUser() //유저목록전체
        {
            userlist = new List<UserInfoVO>();
            userlist = userService.GetAllUser();
            dgvUser.DataSource = userlist;

           groupuserlist = userlist;//권한부여받은 유저들
           dgvJoin.DataSource = groupuserlist;

        }
        /// <summary>
        /// 사용자그룹목록, 사용자그룹멥핑목록
        /// </summary>
        private void GetAllUserGroup()// 사용자그룹목록
        {
            grouplist = new List<UserGroup_MasterVO>();
            grouplist = groupservice.GetAllUserGroup();
            dgvGroup.DataSource = grouplist.FindAll(item=>item.Use_YN =="Y");
            groupMappinglist = new List<UserGroup_MappingVO>();
            groupMappinglist = groupservice.GetAllUserGroup_Mapping();

            subMappinglist = new List<UserGroup_MappingVO>(); //맵핑된전체유저들중 선택그룹에해당하는 유저들
            subMappinglist = groupMappinglist.FindAll(item => item.UserGroup_Code == dgvGroup.SelectedRows[0].Cells[0].Value.ToString());//맵핑된전체유저들중 하나의그룹에해당하는 애들만

        }
        /// <summary>
        /// 콤보박스 세팅
        /// </summary>
        private void ControlSetting() // 콤보박스 세팅
        {

            Dictionary<string, string> cbblist = userlist.FindAll(item => item.Use_YN == "Y").ToDictionary(item => item.User_ID, item => item.User_Name);
            cbbUser.DisplayMember = "Value";
            cbbUser.ValueMember = "Key";
            cbbUser.DataSource = new BindingSource(cbblist, null);
            lblUser.Text = cbbUser.SelectedValue.ToString();
        }
        /// <summary>
        /// 인서트폼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InsertFormShow(object sender, EventArgs e) //인서트폼
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    MSS_CON_003_1 frm = new MSS_CON_003_1();

                  if(frm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("등록", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllUser();
                        GetAllUserGroup();
                        ControlSetting();//콤보박스
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void MyDelete(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    if (MessageBox.Show(dgvUser.SelectedRows[0].Cells[1].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //   MessageBox.Show(dgvParent.SelectedRows[0].Cells[0].Value.ToString());
                if (userService.DeleteUserInfoVO(dgvUser.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    GetAllUser();
                    GetAllUserGroup();
                    ControlSetting();//콤보박스

                }
                else
                {
                    MessageBox.Show("삭제실패");
                }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        /// <summary>
        /// 새로고침
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    GetAllUser();
                    GetAllUserGroup();
                    ControlSetting();//콤보박스
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             subMappinglist = new List<UserGroup_MappingVO>(); //맵핑된전체유저들중 선택그룹에해당하는 유저들
            subMappinglist = groupMappinglist.FindAll(item => item.UserGroup_Code == dgvGroup.SelectedRows[0].Cells[0].Value.ToString());//맵핑된전체유저들중 하나의그룹에해당하는 애들만

            foreach (DataGridViewRow row in dgvJoin.Rows)
            {
                row.Cells[0].Value = false;
            }


            for (int i = 0; i < groupuserlist.Count; i++)
            {
                for (int j = 0; j < subMappinglist.Count; j++)
                {
                    if (groupuserlist[i].User_ID == subMappinglist[j].User_ID)
                    {
                        dgvJoin.Rows[i].Cells[0].Value = true;
                    }
                }
            }

        }

        private void DgvJoin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvJoin.SelectedRows[0].Cells[0].Value = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<UserGroup_MappingVO> addlist = new List<UserGroup_MappingVO>();
  
            foreach ( DataGridViewRow row in dgvJoin.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true) //체크박스가 선택된 row들만
                {
                    UserGroup_MappingVO mapping = new UserGroup_MappingVO {

                        UserGroup_Code = dgvGroup.SelectedRows[0].Cells[0].Value.ToString(),
                        User_ID = row.Cells[1].Value.ToString(),
                        Ins_Date = DateTime.Now,
                        Ins_Emp = UserInfo.User_Name

                    };
                    addlist.Add(mapping);
                }
            }

            if (subMappinglist != null) //그룹에저장된 유저가 한명이라도있다면
            { 
       
               var deleteitem = from item in subMappinglist  //맵핑된전체유저들중 선택그룹에해당하는 유저들과 변경된 유저들중 권한을 더이상 주지않는 유저들 삭제하기위해
                                                        let comparison = from comitem in addlist select comitem.User_ID
                                                          where !comparison.Contains(item.User_ID)
                                                           select item;


                List<UserGroup_MappingVO> dad = new List<UserGroup_MappingVO>();
                dad.AddRange(deleteitem);
                groupservice.DeleteUserGroup_Mapping(dad);
            }
            groupservice.InsertUpdateUserGroup_Mapping(addlist); //그룹권한에 새롭게추가되거나 업데이트되는  유저들
            GetAllUser();
            GetAllUserGroup();
        }


        /// <summary>
        /// 이벤트해제
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSS_CON_003_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUser.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(lblUser.Text))
                {
                    row.Cells[0].Selected = true;
                }
            }
        }

        private void CbbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUser.Text = cbbUser.SelectedValue.ToString();
        }
    }
}
