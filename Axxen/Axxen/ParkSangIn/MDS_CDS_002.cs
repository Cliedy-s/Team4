using Axxen.Util;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class MDS_CDS_002 : Axxen.GridGridManageForm
    {
        List<Def_MaVO> Defmalist; //불량 대분류
        Def_MaService maservice = new Def_MaService();

        List<Def_MiVO> defmilist;//불량 상세
        Def_MiService miservice = new Def_MiService();

        public MDS_CDS_002()
        {
            InitializeComponent();
        }

        private void MDS_CDS_002_Load(object sender, EventArgs e)
        {

            aPanel2.Enabled = false;

            aDataGridView1.CellDoubleClick += DgvMainGrid_CellDoubleClick;
            aDataGridView2.CellDoubleClick += aDataGridView2_CellDoubleClick;
            aDataGridView2.CellContentClick += aDataGridView2_CellContentClick;

            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);

            ///gridview
            DatagridviewDesigns.SetDesign(aDataGridView1);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView1, "불량현상대분류코드", "Def_Ma_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView1, "불량현상대분류 명", "Def_Ma_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView1, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView1, "사용여부", "Use_YN", true, 210, default, true);




            DatagridviewDesigns.SetDesign(aDataGridView2);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView2, "불량현상상세분류코드", "Def_Mi_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView2, "불량현상상세분류 명", "Def_Mi_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView2, "비고", "Remark", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView2, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(aDataGridView2, "사용여부", "Use_YN", true, 210, default, true);
            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;
            aDataGridView2.Columns.Add(gridbtn);

            GetAllUserGroup();
        }

        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllUserGroup()
        {
            Defmalist = new List<Def_MaVO>();
            Defmalist = maservice.GetAllDef_Ma_Master();
            aDataGridView1.DataSource = Defmalist;

            defmilist = new List<Def_MiVO>();
            defmilist = miservice.GetAllDef_Mi_Master();
            
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
                    aPanel2.Enabled = true;
                    txtDef_Micode.Enabled = false;
                    btnSave.Text = "수정";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
                    aPanel2.Enabled = true;
                    btnSave.Text = "저장";
                    ResetUtillity.ResetPanelControl(aPanel2);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
            GetAllUserGroup();
        }

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            aDataGridView2.DataSource = null;
     
            aDataGridView2.DataSource = defmilist.FindAll(item => item.Def_Ma_Code == aDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            lblDefM.Text = aDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtDef_Micode.Text = "";
            txtDef_Miname.Text = "";
            txtRemark.Text = "";
        }
        private void aDataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (btnSave.Text.Equals("수정"))
            {

                txtDef_Micode.Text = aDataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                txtDef_Miname.Text = aDataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                txtRemark.Text = aDataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
        private void aDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == aDataGridView2.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((aDataGridView2.SelectedRows[0].Cells[4].Value).ToString() == "Y") //사용안함
                    {
                        miservice.UsedDef_Mi_Master((aDataGridView2.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        miservice.UsedDef_Mi_Master((aDataGridView2.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllUserGroup();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDef_Micode.Text) && !string.IsNullOrEmpty(txtDef_Miname.Text))
            {

                Def_MiVO additem = new Def_MiVO()
                {
                    Def_Mi_Code = txtDef_Micode.Text,
                    Def_Ma_Code = lblDefM.Text,
                    Def_Mi_Name = txtDef_Miname.Text,
                    Remark = txtRemark.Text,
                    Ins_Emp = UserInfo.User_Name

                };
                if (miservice.InsertUpdateDef_Mi_Master(additem))
                {
                    MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllUserGroup();
                    ResetUtillity.ResetPanelControl(aPanel2);
                }
                else
                {
                    MessageBox.Show("저장에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("필수 항목을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MDS_CDS_002_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);

            aDataGridView1.CellDoubleClick -= DgvMainGrid_CellDoubleClick;
            aDataGridView2.CellDoubleClick -= aDataGridView2_CellDoubleClick;
            aDataGridView2.CellContentClick -= aDataGridView2_CellContentClick;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //aBigTextBox_FindNameByCode1.txtCodeText

            foreach (DataGridViewRow row in aDataGridView1.Rows)
            {
                if(row.Cells[0].Value.ToString() == aBigTextBox_FindNameByCode1.txtCodeText)
                {
                    row.Selected=true;
                }
            }
        }
    }
}
