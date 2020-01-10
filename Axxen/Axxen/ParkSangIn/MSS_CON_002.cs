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
        UserGroupService userservice = new UserGroupService();
        public MSS_CON_002()
        {
            InitializeComponent();
        }

     
        private void MSS_CON_002_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);

            ///gridview
            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹코드", "UserGroup_Code", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹명", "UserGroup_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "입력일자", "Ins_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용여부", "Use_YN", true, 60, default, true);
            GetAllUserGroup();
            ///
            ControlSetting();
        }
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
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MSS_CON_002_1 frm = new MSS_CON_002_1();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

    }
}
