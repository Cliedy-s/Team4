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
    public partial class MDS_CDS_001 : Axxen.BaseForm
    {
        List<Def_MaVO> Defmalist; //불량 대분류
        Def_MaService Defservice = new Def_MaService();
        public MDS_CDS_001()
        {
            InitializeComponent();
        }

        private void MDS_CDS_001_1_Load(object sender, EventArgs e)
        {
            panelDefma.Enabled = false;
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);

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
                    ResetUtillity.ResetPanelControl(panelDefma);
                    panelDefma.Enabled = true;
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
                    panelDefma.Enabled = true;
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
                    if (MessageBox.Show(dgvMainGrid.SelectedRows[0].Cells[1].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // MessageBox.Show(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString());
                        if (Defservice.DeleteDef_MaVO(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString()))
                        {
                            GetAllDefMa();
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
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
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
                    GetAllDefMa();
                    ///
                    ControlSetting();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvMainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void CbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    Def_MaVO additem = new Def_MaVO()
                    {
                        Def_Ma_Code = txtCode.Text,
                        Def_Ma_Name = txtName.Text,
                        Ins_Emp = UserInfo.User_Name
                    };

                    if (Defservice.InsertUpdateDef_MaVO(additem))
                    {
                        MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllDefMa();
                        ControlSetting();
                        ResetUtillity.ResetPanelControl(panelDefma);

                    }
                    else
                    {
                        MessageBox.Show("저장실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSave.Text.Equals("수정"))
            {
                var taget = Defmalist.Find(item => item.Def_Ma_Code == dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString());
                txtName.Text = taget.Def_Ma_Name.ToString();
                txtCode.Text = taget.Def_Ma_Code.ToString();
            }
        }

        private void MDS_CDS_001_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }
    }
}
