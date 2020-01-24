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
    public partial class MDS_ODS_001 : Axxen.BaseForm
    {
        List<Process_MasterVO> processlist;
        ProcessService userservice = new ProcessService();

        public MDS_ODS_001()
        {
            InitializeComponent();


        }

        private void MDS_ODS_001_Load(object sender, EventArgs e)
        {
            ///gridview
            DatagridviewDesigns.SetDesign(dgvProcess);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProcess, "공정코드", "Process_code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProcess, "공정이름", "Process_name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProcess, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProcess, "사용여부", "Use_YN", true, 210, default, true);
            GetAllProcess();
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
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;


            gridbtn.UseColumnTextForButtonValue = true;
            dgvProcess.Columns.Add(gridbtn);

            ///combobox
            Dictionary<string, string> cbblist = processlist.ToDictionary(item => item.Process_code, item => item.Process_name);
            cbbProcess.DisplayMember = "Value";
            cbbProcess.ValueMember = "Key";
            cbbProcess.DataSource = new BindingSource(cbblist, null);
            lblProcess.Text = cbbProcess.SelectedValue.ToString();
            ///
        }
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllProcess()
        {

            processlist = new List<Process_MasterVO>();
            processlist = userservice.GetAllProcess_Master();
            dgvProcess.DataSource = processlist;
        }

        private void CbbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProcess.Text = cbbProcess.SelectedValue.ToString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProcess.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(lblProcess.Text))
                {
                    row.Cells[0].Selected = true;
                }
            }
        }

        private void DgvProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvProcess.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvProcess.SelectedRows[0].Cells[3].Value).ToString() == "Y") //사용안함
                    {
                        userservice.GetUpdateProcessMaster((dgvProcess.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        userservice.GetUpdateProcessMaster((dgvProcess.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllProcess();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
