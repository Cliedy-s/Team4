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
       
            ///gridview
            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹코드", "UserGroup_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용자그룹명", "UserGroup_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용여부", "Use_YN", true, 210, default, true);
            GetAllUserGroup();
            ///
            ControlSetting();
        }
        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {

            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            gridbtn.DefaultCellStyle = dataGridViewCellStyle1;
           

            gridbtn.UseColumnTextForButtonValue = true;
            dgvGroup.Columns.Add(gridbtn);

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
                if((dgvGroup.SelectedRows[0].Cells[3].Value).ToString() == "Y") //사용안함
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
    }
}
