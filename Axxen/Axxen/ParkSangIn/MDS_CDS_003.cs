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
    public partial class MDS_CDS_003 : Axxen.BaseForm
    {
        List<NopMaMasterVO> NopMalist; //비가동 대분류
        Nop_Ma_MasterService Nopservice = new Nop_Ma_MasterService();
        public MDS_CDS_003()
        {
            InitializeComponent();
        }

        private void MDS_CDS_003_Load(object sender, EventArgs e)
        {
          
            panelNopMaMaste.Enabled = false;

            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);

            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "비가동대분류코드", "Nop_Ma_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "비가동대분류 명", "Nop_Ma_Name", true, 210, default, true);
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
            GetAllNopMa();
            ///
            ControlSetting();
        }

        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///combobox
            Dictionary<string, string> cbblist = NopMalist.ToDictionary(item => item.Nop_Ma_Code, item => item.Nop_Ma_Name);
            cbbGroup.DisplayMember = "Value";
            cbbGroup.ValueMember = "Key";
            cbbGroup.DataSource = new BindingSource(cbblist, null);
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
            ///
        }
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllNopMa()
        {
            NopMalist = new List<NopMaMasterVO>();
            NopMalist = Nopservice.GetAllNopMA();
            dgvGroup.DataSource = NopMalist;
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
                    ResetUtillity.ResetPanelControl(panelNopMaMaste);
                    panelNopMaMaste.Enabled = true;
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
                    panelNopMaMaste.Enabled = true;
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
            if (MessageBox.Show(dgvGroup.SelectedRows[0].Cells[0].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //   MessageBox.Show(dgvParent.SelectedRows[0].Cells[0].Value.ToString());
                if (Nopservice.DeleteNopMaMasterVO(dgvGroup.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    GetAllNopMa();
                    ControlSetting();//콤보박스

                }
                else
                {
                    MessageBox.Show("삭제실패");
                }
            }

        }
        /// <summary>
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
                    GetAllNopMa();
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

        private void MDS_CDS_003_FormClosing(object sender, FormClosingEventArgs e)
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
                var taget = NopMalist.Find(item => item.Nop_Ma_Code == dgvGroup.SelectedRows[0].Cells[0].Value.ToString());
                txtName.Text = taget.Nop_Ma_Name.ToString();
                txtCode.Text = taget.Nop_Ma_Code.ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

            if(!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtName.Text)) { 
            NopMaMasterVO additem = new NopMaMasterVO()
            {
                Nop_Ma_Code = txtCode.Text,
                Nop_Ma_Name = txtName.Text,
                Ins_Emp = UserInfo.User_Name
            };

              if(Nopservice.InsertUpdateNop_Ma_Master(additem))
                {
                    MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllNopMa();
                        ControlSetting();
                        ResetUtillity.ResetPanelControl(panelNopMaMaste);

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

        private void DgvGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvGroup.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvGroup.SelectedRows[0].Cells[3].Value).ToString() == "Y") //사용안함
                    {
                        Nopservice.GetUseNopservice((dgvGroup.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        Nopservice.GetUseNopservice((dgvGroup.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllNopMa();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
