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
    public partial class MDS_CDS_004 : Axxen.BaseForm
    {
        List<NopMaMasterVO> NopMalist; //비가동 대분류
        Nop_Ma_MasterService MApservice = new Nop_Ma_MasterService();


        List<NopMiMasterVO> NopMilist; //비가동 상세분류
        Nop_Mi_MasterService MIservice = new Nop_Mi_MasterService();

        public MDS_CDS_004()
        {
            InitializeComponent();
        }

        private void MDS_CDS_004_Load(object sender, EventArgs e)
        {
            panelNopMaMaste.Enabled = false;

            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);


            DatagridviewDesigns.SetDesign(dgvMa);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMa, "대분류코드", "Nop_Ma_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMa, "대분류명", "Nop_Ma_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMa, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMa, "사용여부", "Use_YN", true, 210, default, true);

            DatagridviewDesigns.SetDesign(dgvMi);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMi, "대분류코드", "Nop_Ma_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMi, "상세코드", "Nop_Mi_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMi, "상세명", "Nop_Mi_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMi, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMi, "비고", "Remark", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMi, "사용여부", "Use_YN", true, 210, default, true);

         
            GetAllUserGroup();
            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvMi.Columns.Add(gridbtn);
        }


    
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllUserGroup()
        {
            NopMalist = new List<NopMaMasterVO>();
            NopMalist = MApservice.GetAllNopMA();
            dgvMa.DataSource = NopMalist;

            NopMilist = new List<NopMiMasterVO>();
            NopMilist = MIservice.GetAllNopMi2();
            dgvMi.DataSource = NopMilist;
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
                    //ResetUtillity.ResetPanelControl(panelNopMaMaste);
                    //panelNopMaMaste.Enabled = true;
                    //txtCode.Enabled = true;
                    //btnSave.Text = "저장";
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
                    txtICode.Enabled = true;
                    txtACode.Enabled = false;
                    btnSave.Enabled = true;
                    btnSave.Text = "수정";
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
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DgvMi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvMi.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvMi.SelectedRows[0].Cells[5].Value).ToString() == "Y") //사용안함
                    {
                        MIservice.UsedNop_Mi_Masterservice((dgvMi.SelectedRows[0].Cells[1].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        MIservice.UsedNop_Mi_Masterservice((dgvMi.SelectedRows[0].Cells[1].Value).ToString(), "Y");
                    }
                    GetAllUserGroup();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void DgvMa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtACode.Text = dgvMa.SelectedRows[0].Cells[0].Value.ToString();


            if (btnSave.Text.Equals("수정"))
            {
                //var taget = NopMalist.Find(item => item.Nop_Ma_Code == dgvGroup.SelectedRows[0].Cells[0].Value.ToString());
                //txtName.Text = taget.Nop_Ma_Name.ToString();
                //txtCode.Text = taget.Nop_Ma_Code.ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
          

                  try
            {

                if (!string.IsNullOrEmpty(txtICode.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    NopMiMasterVO additem = new NopMiMasterVO()
                    {
                        Nop_Ma_Code = txtACode.Text,
                      Nop_Mi_Code  = txtICode.Text ,
                Nop_Mi_Name= txtName.Text ,
                  
                    };

                    if (MIservice.InsertUpdateNop_MI_Master(additem))
                    {
                        MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllUserGroup();
                        
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
    }
}
