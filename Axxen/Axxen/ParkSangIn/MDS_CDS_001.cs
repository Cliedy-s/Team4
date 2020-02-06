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
    public partial class MDS_CDS_001 : Axxen.GridForm
    {
        List<Def_MaVO> Defmalist; //비가동 대분류
        Def_MaService Defservice = new Def_MaService();
        public MDS_CDS_001()
        {
            InitializeComponent();
        }

        private void MDS_CDS_001_Load(object sender, EventArgs e)
        {

            dgvMainGrid.CellContentClick += DgvMainGrid_CellContentClick;

            ///gridview
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "불량현상대분류코드", "Def_Ma_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "불량현상대분류 명", "Def_Ma_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "사용여부", "Use_YN", true, 210, default, true);



            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvMainGrid.Columns.Add(gridbtn);
            GetAllDefMa();
            ///
            ControlSetting();
        }
        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///combobox
            Dictionary<string, string> cbblist = Defmalist.ToDictionary(item => item.Def_Ma_Code, item => item.Def_Ma_Name);
            cbbGroup.DisplayMember = "Value";
            cbbGroup.ValueMember = "Key";
            cbbGroup.DataSource = new BindingSource(cbblist, null);
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
            ///
        }
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllDefMa()
        {

            Defmalist = new List<Def_MaVO>();
            Defmalist = Defservice.GetAllDef_Ma_Master();
            dgvMainGrid.DataSource = Defmalist;
        }

        private void CbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMainGrid.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(lblGroup.Text))
                {
                    row.Cells[0].Selected = true;
                }
            }
        }
        private void DgvMainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            try
            {

                if (e.ColumnIndex == dgvMainGrid.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvMainGrid.SelectedRows[0].Cells[3].Value).ToString() == "Y") //사용안함
                    {
                        Defservice.GetUpdateDef_Ma_Master((dgvMainGrid.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        Defservice.GetUpdateDef_Ma_Master((dgvMainGrid.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllDefMa();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

    }
}
