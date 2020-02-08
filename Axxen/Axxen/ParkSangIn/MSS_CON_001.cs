using Axxen.Util;
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
    public partial class MSS_CON_001 : BaseForm
    {
        List<UserGroup_MasterVO> grouplist;
        UserGroupService userservice = new UserGroupService();
        public MSS_CON_001()
        {
            InitializeComponent();
        }

        private void MSS_CON_001_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtCode.Enabled = false;
            btnSave.Enabled = false;

            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);

            ///gridview
            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹코드", "UserGroup_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹명", "UserGroup_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용여부", "Use_YN", true, 210, default, true);
            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvGroup.Columns.Add(gridbtn);
            GetAllUserGroup();
            ///
            ControlSetting();
        }
        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {  
            ///combobox
            Dictionary<string, string> cbblist = grouplist.ToDictionary(item => item.UserGroup_Code, item => item.UserGroup_Name);
            cbbGroup.DisplayMember = "Value";
            cbbGroup.ValueMember = "Key";
            cbbGroup.DataSource = new BindingSource(cbblist, null);
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
            ///
        }
        /// <summary>
        /// 입력 이벤트 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InsertFormShow(object sender, EventArgs e)
        {

            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    txtName.Enabled = true;
                    txtCode.Enabled = true;
                    btnSave.Enabled = true;
                    btnSave.Text = "저장";
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
                    if (MessageBox.Show(dgvGroup.SelectedRows[0].Cells[0].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //   MessageBox.Show(dgvParent.SelectedRows[0].Cells[0].Value.ToString());
                        if (userservice.DeleteUserGroup_MasterVO(dgvGroup.SelectedRows[0].Cells[0].Value.ToString()))
                        {
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
                Program.Log.WriteError(err.Message);
            }

        }
        /// <summary>
        /// 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MyUpdateShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    txtName.Enabled = true;
            txtCode.Enabled = false;
            btnSave.Enabled = true;
            btnSave.Text = "수정";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        /// <summary>
        /// 새로고침 이벤트 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    GetAllUserGroup();
                    ControlSetting();//콤보박스
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllUserGroup()
        {

            grouplist = new List<UserGroup_MasterVO>();
            grouplist = userservice.GetAllUserGroup();
            dgvGroup.DataSource = grouplist;
        }

        private void CbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGroup.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(lblGroup.Text))
                {
                    row.Cells[0].Selected = true;
                }
            }
        }

        /// <summary>
        /// 그리드뷰버튼클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvGroup.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvGroup.SelectedRows[0].Cells[3].Value).ToString() == "Y") //사용안함
                    {
                        userservice.GetUpdateUserGroup((dgvGroup.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        userservice.GetUpdateUserGroup((dgvGroup.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllUserGroup();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtCode.Text))
            {
                if (btnSave.Text == "저장")
                {
                    if (userservice.GetInsertUserGroup(txtCode.Text, txtName.Text, UserInfo.User_Name))
                    {
                        MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);                     
                    }
                    else
                    {
                        MessageBox.Show("이미등록된 코드 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    if (userservice.GetUpdateUserGroup(txtCode.Text, txtName.Text, UserInfo.User_Name))
                    {
                        MessageBox.Show("수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  
                }
                ResetUtillity.ResetPanelControl(aPanel3);
                GetAllUserGroup();
            }

            else
            {
                MessageBox.Show("필수 입력란을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void MSS_CON_001_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }

        private void DgvGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvGroup.SelectedRows[0].Cells[1].Value.ToString();
            txtCode.Text = dgvGroup.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
