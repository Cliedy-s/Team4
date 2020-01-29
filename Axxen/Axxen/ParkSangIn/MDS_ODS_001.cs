using Axxen.Util;
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
        ProcessService processservice = new ProcessService();

        public MDS_ODS_001()
        {
            InitializeComponent();


        }

        private void MDS_ODS_001_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtCode.Enabled = false;
            btnSave.Enabled = false;
            txtremark.Enabled = false;
          ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ///gridview
            DatagridviewDesigns.SetDesign(dgvProcess);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProcess, "공정코드", "Process_code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProcess, "공정이름", "Process_name", true, 210, default, true);

            DatagridviewDesigns.AddNewColumnToDataGridView(dgvProcess, "비고", "Remark", true, 210, default, true);
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
            processlist = processservice.GetAllProcess_Master();
            dgvProcess.DataSource = processlist;
        }

        private void CbbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProcess.Text = cbbProcess.SelectedValue.ToString();
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
                    txtremark.Enabled = true;
                    btnSave.Text = "저장";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        /// <summary>
        /// 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MyUpdateShow(object sender, EventArgs e)
        {

            txtName.Enabled = true;
            txtCode.Enabled = false;
            txtremark.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Text = "수정";
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
                    GetAllProcess();
                    ControlSetting();//콤보박스
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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
                        processservice.GetUpdateProcessMaster((dgvProcess.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        processservice.GetUpdateProcessMaster((dgvProcess.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllProcess();
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
           
                    if (processservice.GetInsertUpdateProcess(btnSave.Text,txtCode.Text, txtName.Text,txtremark.Text ,UserInfo.User_Name))
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
                    if (processservice.GetInsertUpdateProcess(btnSave.Text, txtCode.Text, txtName.Text, txtremark.Text, UserInfo.User_Name))
                    {
                        MessageBox.Show("수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                ResetUtillity.ResetPanelControl(aPanel3);
                GetAllProcess();
            }

            else
            {
                MessageBox.Show("필수 입력란을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void MDS_ODS_001_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
        }

        private void DgvProcess_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvProcess.SelectedRows[0].Cells[1].Value.ToString();
            txtCode.Text = dgvProcess.SelectedRows[0].Cells[0].Value.ToString();

            if (dgvProcess.SelectedRows[0].Cells[2].Value!=null) { 
            txtremark.Text = dgvProcess.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
