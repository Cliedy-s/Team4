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
    public partial class MDS_SDS_001 : Axxen.BaseForm
    {
        List<Item_Level_MasterVO> itemgrouplist;
        ItemMaster_Service itemservice = new ItemMaster_Service();
        public MDS_SDS_001()
        {
            InitializeComponent();
        }

        private void MDS_SDS_001_Load(object sender, EventArgs e)
        {
            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "품목그룹코드", "Level_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "품목그룹명", "Level_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "팔렛당박스수", "Box_Qty", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "박스당pcs수", "Pcs_Qty", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "PCS당소재량", "Mat_Qty", true, 210, default, true);

            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용유무", "Use_YN", true, 210, default, true);
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
            Dictionary<string, string> cbblist = itemgrouplist.ToDictionary(item => item.Level_Code, item => item.Level_Name);
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

            itemgrouplist = new List<Item_Level_MasterVO>();
            itemgrouplist = itemservice.GetAllItem_Level_Master();
            dgvGroup.DataSource = itemgrouplist;
        }

    }
}
