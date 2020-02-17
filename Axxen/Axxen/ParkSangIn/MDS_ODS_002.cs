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
    public partial class MDS_ODS_002 : Axxen.BaseForm
    {
        List<WorkCenter_Master2VO> worklist; //작업장
        WorkCenter_MasterService Workservice = new WorkCenter_MasterService();


        public MDS_ODS_002()
        {
            InitializeComponent();
        }

        private void MDS_ODS_002_Load(object sender, EventArgs e)
        {
            aBigTextBox_FindNameByCode1.Enabled = false;
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);// 수정
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);
            ///gridview
            DatagridviewDesigns.SetDesign(dgvWork);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "작업장코드", "Wc_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "작업장명 명", "Wc_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "공정코드", "Process_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "공정이름", "Process_name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "비가동상태", "Wo_Status", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "최종실적처리시간", "Last_Cnt_Time", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "실적등록유형", "Prd_Req_Type", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "팔렛생성여부", "Pallet_YN", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "최종작업품목", "Item_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "실적단위", "Prd_Unit", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "금형장착여부", "Mold_Setup_YN", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "사용여부", "Use_YN", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvWork, "비고", "Remark", true, 210, default, true);

            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.White;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvWork.Columns.Add(gridbtn);
            GetAllWork();
            ControlSetting();
        }
        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///combobox
            Dictionary<string, string> cbblist = worklist.ToDictionary(item => item.Wc_Code, item => item.Wc_Name);
            cbbwork.DisplayMember = "Value";
            cbbwork.ValueMember = "Key";
            cbbwork.DataSource = new BindingSource(cbblist, null);
            lblwork.Text = cbbwork.SelectedValue.ToString();
            ///
        }
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllWork()
        {

            worklist = new List<WorkCenter_Master2VO>();
            worklist = Workservice.GetAll_WorkCenter_Master();
            dgvWork.DataSource = worklist;

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
                    if (dgvWork.SelectedRows[0].Cells[0].Value != null)
                    {
                        MDS_ODS_002_1 frm = new MDS_ODS_002_1();

                        frm.updateworkitem = worklist.Find(item => item.Wc_Code == dgvWork.SelectedRows[0].Cells[0].Value.ToString());


                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetAllWork();
                            ControlSetting();
                        }
                    }


                }
            }
            catch (Exception err)
            {
             
                Program.Log.WriteError(err.Message);
            }


        }
        private void MyDelete(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    if (MessageBox.Show(dgvWork.SelectedRows[0].Cells[1].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        // MessageBox.Show(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString());
                        if (Workservice.DeleteWorkCenter_Master2VO(dgvWork.SelectedRows[0].Cells[0].Value.ToString()))
                        {
                            GetAllWork();
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
             
                Program.Log.WriteError(err.Message);
            }

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
                    MDS_ODS_002_1 frm = new MDS_ODS_002_1();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllWork();
                        ControlSetting();

                    }
                }
            }
            catch (Exception err)
            {
      
                Program.Log.WriteError(err.Message);
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
                    GetAllWork();
                    ControlSetting();
                }
            }
            catch (Exception err)
            {
           
                Program.Log.WriteError(err.Message);
            }
        }

        private void Cbbwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblwork.Text = cbbwork.SelectedValue.ToString();
        }
        private void Rdoprocess_CheckedChanged(object sender, EventArgs e)
        {
            if (rdowork.Checked)
            {
                cbbwork.Enabled = true;
                lblwork.Enabled = true;
                aBigTextBox_FindNameByCode1.Enabled = false;
            }
            else if (rdoprocess.Checked)
            {
                aBigTextBox_FindNameByCode1.Enabled = true;
                cbbwork.Enabled = false;
                lblwork.Enabled = false;
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (rdowork.Checked)
            {
                dgvWork.DataSource = null;
                dgvWork.DataSource = worklist;
                foreach (DataGridViewRow row in dgvWork.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(lblwork.Text))
                    {
                        row.Cells[0].Selected = true;
                    }
                }
            }
            else
            {
                dgvWork.DataSource = null;
                dgvWork.DataSource = worklist.FindAll(item => item.Process_Code == aBigTextBox_FindNameByCode1.txtCodeText.ToString());
            }
        }

        private void DgvWork_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvWork.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvWork.SelectedRows[0].Cells[11].Value).ToString() == "Y") //사용안함
                    {
                        Workservice.UsedWorkCenter_Master2VO((dgvWork.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        Workservice.UsedWorkCenter_Master2VO((dgvWork.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllWork();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void MDS_ODS_002_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);// 수정
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }
    }
}
