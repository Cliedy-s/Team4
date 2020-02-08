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
    public partial class MDS_CDS_008 : Axxen.BaseForm
    {

        List<GVMasterVO> GVlist; //대차
        GV_MasterService GVservice = new GV_MasterService();
        RadioButton rdbgroup;
        public MDS_CDS_008()
        {
            InitializeComponent();
        }

        private void MDS_CDS_008_Load(object sender, EventArgs e)
        {
            panelGVMaste.Enabled = false;
            rdbgroup = rdogroup1;

            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);

            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "대차코드", "GV_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "대차명", "GV_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "대차그룹명", "GV_Group", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "대차그룹코드", "GV_Group", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "대차상태", "GV_Status", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "언로딩작업장", "Unloading_Wc", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvGroup, "사용여부", "Use_YN", true, 210, default, true);

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
            Dictionary<string, string> cbblist = GVlist.ToDictionary(item => item.GV_Code, item => item.GV_Name);
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
            GVlist = new List<GVMasterVO>();
            GVlist = GVservice.GetALLGVMaster();
            dgvGroup.DataSource = GVlist;
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
                    ResetUtillity.ResetPanelControl(panelGVMaste);
                    panelGVMaste.Enabled = true;
                    txtCode.Enabled = true;
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
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    panelGVMaste.Enabled = true;
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
        private void MyDelete(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    if (MessageBox.Show(dgvGroup.SelectedRows[0].Cells[1].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
             
                //    MessageBox.Show(dgvMi.SelectedRows[0].Cells[0].Value.ToString());
                if (GVservice.DeleteGVMasterVO(dgvGroup.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    GetAllUserGroup();
                    ControlSetting();
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
                    ///
                    ControlSetting();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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

        private void MDS_CDS_008_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }

        private void DgvGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSave.Text.Equals("수정"))
            {
                var taget = GVlist.Find(item => item.GV_Code == dgvGroup.SelectedRows[0].Cells[0].Value.ToString());
                txtName.Text = taget.GV_Name.ToString();
                txtCode.Text = taget.GV_Code.ToString();

                if (taget.GV_Group == "소성") { rdogroup1.Checked = true; }
                else if (taget.GV_Group == "건조")
                {
                    rdogroup2.Checked = true;
                }
                else if (taget.GV_Group == "성형")
                {
                    rdogroup3.Checked = true;
                }


            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    GVMasterVO additem = new GVMasterVO()
                    {
                        GV_Code = txtCode.Text,
                        GV_Name = txtName.Text,
                        GV_GroupCode = rdbgroup.Tag.ToString(),
                        GV_Group = rdbgroup.Text,
                        GV_Status = "빈대차",
                        Ins_Emp = UserInfo.User_Name

                    };

                    if (GVservice.InsertUpdateGV_Master(additem))
                    {
                        MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllUserGroup();
                        ControlSetting();
                        ResetUtillity.ResetPanelControl(panelGVMaste);

                    }
                    else
                    {
                        MessageBox.Show("db실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("필수항목을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "db", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Rdogroup1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            if (radio.Checked)
            {
                rdbgroup = radio;

            }
        }

        private void DgvGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvGroup.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvGroup.SelectedRows[0].Cells[7].Value).ToString() == "Y") //사용안함
                    {
                        GVservice.UsedGV_Master((dgvGroup.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        GVservice.UsedGV_Master((dgvGroup.SelectedRows[0].Cells[0].Value).ToString(), "Y");
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
