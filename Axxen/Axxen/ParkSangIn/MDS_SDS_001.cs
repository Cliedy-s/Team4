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
    public partial class MDS_SDS_001 : Axxen.BaseForm

    {
        ItemMaster_Service itemservice = new ItemMaster_Service();
        List<Item_Level_Master> itemgrouplist;

        public MDS_SDS_001()
        {
            InitializeComponent();
        }
        MainForm frm= new MainForm();
       
        private void MDS_SDS_001_Load(object sender, EventArgs e)
        {
         
            panelsetting.Enabled = false;
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);


            DatagridviewDesigns.SetDesign(dgvGroup);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "품목그룹코드", "Level_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "품목그룹명", "Level_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "팔렛당박스수", "Box_Qty", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "박스당pcs수", "Pcs_Qty", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "PCS당소재량", "Mat_Qty", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvGroup, "사용유무", "Use_YN", true, 210, default, true);

            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvGroup.Columns.Add(gridbtn);
            GetAllItemGroup();
            ///
            ControlSetting();
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
                    ResetUtillity.ResetPanelControl(panelsetting);
                    panelsetting.Enabled = true;
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
                    panelsetting.Enabled = true;
                    txtCode.Enabled = false;
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
                        // MessageBox.Show(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString());
                        if (itemservice.DeleteItem_Level_Master(dgvGroup.SelectedRows[0].Cells[0].Value.ToString()))
                        {
                            GetAllItemGroup();
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
                    GetAllItemGroup();
                    ControlSetting();//콤보박스
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {

            ///combobox
            Dictionary<string, string> cbblist = itemgrouplist.ToDictionary(item => item.Level_Code, item => item.Level_Name);
            cbbGroup.DisplayMember = "Value";
            cbbGroup.ValueMember = "Key";
            cbbGroup.DataSource = new BindingSource(cbblist, null);
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
            ///
        }
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllItemGroup()
        {

            itemgrouplist = new List<Item_Level_Master>();
            itemgrouplist = itemservice.GetAllItem_Level_Master();
            dgvGroup.DataSource = itemgrouplist;
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

        private void DgvGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvGroup.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvGroup.SelectedRows[0].Cells[5].Value).ToString() == "Y") //사용안함
                    {
                        itemservice.Use_YNItem_Level_Master((dgvGroup.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        itemservice.Use_YNItem_Level_Master((dgvGroup.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllItemGroup();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string level = null;

            if (cbbLevel.Text == "Level1")
            {
                level = "YNNNN";
            }
            else if (cbbLevel.Text == "Level2")
            {
                level = "NYNNN";
            }
            else if (cbbLevel.Text == "Level3")
            {
                level = "NNYNN";
            }
            else if (cbbLevel.Text == "Level4")
            {
                level = "NNNYN";
            }
            else if (cbbLevel.Text == "Level5")
            {
                level = "NNNNY";

            }

            Item_Level_Master additem = new Item_Level_Master()
            {
                Level_Code = txtCode.Text,
                Level_Name = txtName.Text,
                Item_lvl1 = level[0].ToString(),
                Item_lvl2 = level[1].ToString(),
                Item_lvl3 = level[2].ToString(),
                Item_lvl4 = level[3].ToString(),
                Item_lvl5 = level[4].ToString(),
                Box_Qty = Convert.ToInt32(nudBox_Qty.Value),
                Pcs_Qty = Convert.ToInt32(nudPcs_Qty.Value),
                Mat_Qty = nudMat_Qty.Value,
                Ins_Emp = UserInfo.User_Name,
            
            };
      
            if (itemservice.InsertUpdateItem_Level_Master(additem))
            {
                MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllItemGroup();
                ControlSetting();
                ResetUtillity.ResetPanelControl(panelsetting);
            }
            else
            {
                MessageBox.Show("db실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSave.Text == "수정")
            {
              var update =  itemgrouplist.Find(item => item.Level_Code == dgvGroup.SelectedRows[0].Cells[0].Value.ToString());

                txtCode.Text = update.Level_Code;
                txtName.Text = update.Level_Name;
                nudBox_Qty.Value = update.Box_Qty;
                nudPcs_Qty.Value = update.Pcs_Qty;
                nudMat_Qty.Value = update.Mat_Qty;

                if (update.Item_lvl1 == "Y")
                {
                    cbbLevel.SelectedIndex = 0;
                }
                else if (update.Item_lvl2 == "Y")
                {
                    cbbLevel.SelectedIndex = 1;
                }
                else if (update.Item_lvl3 == "Y")
                {
                    cbbLevel.SelectedIndex = 2;
                }
                else if (update.Item_lvl4 == "Y")
                {
                    cbbLevel.SelectedIndex = 3;
                }
                else if (update.Item_lvl5 == "Y")
                {
                    cbbLevel.SelectedIndex = 4;
                }

            }
        }

        private void MDS_SDS_001_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }
    }
   }
