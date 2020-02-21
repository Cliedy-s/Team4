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
    public partial class MDS_CDS_007 : Axxen.BaseForm
    {
        List<BoxingGrade_Detail_MasterVO> boxlist = new List<BoxingGrade_Detail_MasterVO>();
        BoxingGrade_Detail_MasterService boxservice = new BoxingGrade_Detail_MasterService();
        RadioButton rdbgroup;
        public MDS_CDS_007()
        {
            InitializeComponent();
        }

        private void MDS_CDS_007_Load(object sender, EventArgs e)
        {
            rdbgroup = radioButton1 ;

            panelbox.Enabled = false;
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);
            ///gridview
            DatagridviewDesigns.SetDesign(dgvbox);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvbox, "포장등급", "Boxing_Grade_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvbox, "포장등급상세코드", "Grade_Detail_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvbox, "포장등급상세명", "Grade_Detail_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvbox, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvbox, "사용여부", "Use_YN", true, 210, default, true);

            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.White;
            gridbtn.UseColumnTextForButtonValue = true;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvbox.Columns.Add(gridbtn);
            GetAllbox();
        }

        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllbox()
        {
            boxlist = new List<BoxingGrade_Detail_MasterVO>();
            boxlist = boxservice.GetAll();
            dgvbox.DataSource = boxlist;
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
                    ResetUtillity.ResetPanelControl(panelbox);
                    panelbox.Enabled = true;
                    txtCode.Enabled = true;
                    btnSave.Text = "저장";

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

                    if (MessageBox.Show(dgvbox.SelectedRows[0].Cells[2].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // MessageBox.Show(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString());
                        if (boxservice.DeleteBoxingGrade_Detail_MasterVO(dgvbox.SelectedRows[0].Cells[1].Value.ToString()))
                        {
                            GetAllbox();
                        


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
                    panelbox.Enabled = true;        
                    txtCode.Enabled = false;
                    btnSave.Text = "수정";
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
                    GetAllbox();                
                }
            }
            catch (Exception err)
            {
                Program.Log.WriteError(err.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
    


            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtCode.Text))
            {
                if (btnSave.Text == "저장")
                {

                    if (boxservice.GetInsertUpdateBoxingGrade_Detail_MasterVO(btnSave.Text, txtCode.Text, txtName.Text, rdbgroup.Tag.ToString(), UserInfo.User_Name))
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
                    if (boxservice.GetInsertUpdateBoxingGrade_Detail_MasterVO(btnSave.Text, txtCode.Text, txtName.Text, rdbgroup.Tag.ToString(), UserInfo.User_Name))
                    {
                        MessageBox.Show("수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                ResetUtillity.ResetPanelControl(panelbox);
                GetAllbox();
            }

            else
            {
                MessageBox.Show("필수 입력란을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MDS_CDS_007_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvbox.Rows)
            {
                if (row.Cells[1].Value.ToString() == aTextBox_FindNameByCode1.txtCodeText.ToString())
                {
                    row.Selected = true;
                }
            }      
        }

        private void Dgvbox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSave.Text.Equals("수정"))
            {
                var taget = boxlist.Find(item => item.Grade_Detail_Code == dgvbox.SelectedRows[0].Cells[1].Value.ToString());
                txtName.Text = taget.Grade_Detail_Name.ToString();
                txtCode.Text = taget.Grade_Detail_Code.ToString();

                if (taget.Boxing_Grade_Code.Equals("포장등급1"))
                {
                    radioButton1.Checked=true;
                }
                else if (taget.Boxing_Grade_Code.Equals("포장등급2"))
                {
                    radioButton2.Checked = true;
                }
                else if (taget.Boxing_Grade_Code.Equals("포장등급3"))
                {
                    radioButton3.Checked = true;
                }
            }
        }

        private void Dgvbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (e.ColumnIndex == dgvbox.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvbox.SelectedRows[0].Cells[4].Value).ToString() == "Y") //사용안함
                    {
                        boxservice.UsedBoxingGrade_Detail_MasterVO((dgvbox.SelectedRows[0].Cells[1].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        boxservice.UsedBoxingGrade_Detail_MasterVO((dgvbox.SelectedRows[0].Cells[1].Value).ToString(), "Y");
                    }
                    GetAllbox();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            if (radio.Checked)
            {
                rdbgroup = radio;

            }
        }
    }
}
