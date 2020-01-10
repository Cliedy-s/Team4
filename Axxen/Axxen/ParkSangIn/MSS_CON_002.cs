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
    public partial class MSS_CON_002 : Axxen.BaseForm
    {

        List<UserGroup_MasterVO> grouplist;
        List<ScreenItem_AuthorityVO> Screenlist;
        UserGroupService userservice = new UserGroupService();
        ScreenItemService screenservice = new ScreenItemService();
        public MSS_CON_002()
        {
            InitializeComponent();
        }

     
        private void MSS_CON_002_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록

            ///gridview
            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹코드", "UserGroup_Code", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹명", "UserGroup_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "입력일자", "Ins_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용여부", "Use_YN", true, 60, default, true);


            DatagridviewDesigns.SetDesign(dgvScreen);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "화면코드", "Screen_Code", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹명", "UserGroup_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "입력일자", "Ins_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용여부", "Use_YN", true, 60, default, true);

            GetAllUserGroup(); //유저그룹전체
            ///
            ControlSetting();//콤보박스
        }


        /// <summary>
        /// 입력 이벤트 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InsertFormShow(object sender, EventArgs e)
        {
            if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
            {
                MSS_CON_002_1 frm = new MSS_CON_002_1();
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
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
        #region 그룹그리드뷰 셀 클릭시
        private void DgvGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            GetGroupScreenItem(dgvGroup.SelectedRows[0].Cells[0].Value.ToString());
        }
        /// <summary>
        /// 선택한 그룹의 화면get
        /// </summary>
        private void GetGroupScreenItem(string groupCode)
        {

            Screenlist = new List<ScreenItem_AuthorityVO>();
            Screenlist = screenservice.GetGroupScreenItem(groupCode);
            dgvScreen.DataSource = grouplist;
        }
        #endregion

        private void MSS_CON_002_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
        }
    }
}
