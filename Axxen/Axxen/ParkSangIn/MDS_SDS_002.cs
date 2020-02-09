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
    public partial class MDS_SDS_002 : Axxen.BaseForm
    {

        ItemMaster_Service itemservice = new ItemMaster_Service();
        List<Item_MasterVO> Itemlist;
        Item_MasterVO upitem = new Item_MasterVO();
        public MDS_SDS_002()
        {
            InitializeComponent();
        }

        private void MDS_SDS_002_Load(object sender, EventArgs e)
        {
            panelsetting.Enabled = false;

            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);

            DatagridviewDesigns.SetDesign(dgvItem);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "품목코드", "Item_Code", true, 75, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "품목명", "Item_Name", true, 150, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "영문명", "Item_Name_Eng", true, 150, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "약어", "Item_Name_Eng_Alias", true, 65, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "유형", "Item_Type", true, 65, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "규격", "Item_Spec", true, 130, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "단위", "Item_Unit", true, 65, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "안전재고", "Item_Stock", true, 75, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "시간당생산수", "PrdQty_Per_Hour", true, 110, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "배치당생산수", "PrdQTy_Per_Batch", true, 110, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "캐비티수", "Cavity", true, 75, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "성형줄당갯수", "Line_Per_Qty", true, 110, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "포장샷당갯수", "Shot_Per_Qty", true, 110, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "건조대차수량", "Dry_GV_Qty", true, 110, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "소성대차수량", "Heat_GV_Qty", true, 110, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "Level1", "Level_1", true, 80, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "Level2", "Level_2", true, 80, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "Level3", "Level_3", true, 80, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "Level4", "Level_4", true, 80, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "Level5", "Level_5", true, 80, default, true);

            GetAllItem();
            ControlSetting();
        }


        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllItem()
        {
            try
            {

            Itemlist = new List<Item_MasterVO>();
            Itemlist = itemservice.GetAllItem_Master();
            dgvItem.DataSource = Itemlist;

            }
            catch (Exception err)
            {
                Program.Log.WriteError(err.Message);
                throw;
            }
        }
        /// <summary>
        ///  콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            // combobox  품목명
            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();

            Dictionary<string, string> cbblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbbItem.DisplayMember = "Value";
            cbbItem.ValueMember = "Key";
            cbbItem.DataSource = new BindingSource(cbblistname, null);
            lblCode.Text = cbbItem.SelectedValue.ToString();

            List<Item_MasterVO> dictiontype = Itemlist.GroupBy(name => name.Item_Type).Select(grp => grp.First()).ToList();
            // combobox  품목타입
            Dictionary<string, string> cbblistype = dictiontype.ToDictionary(type => type.Item_Type, type => type.Item_Type);
            cbbType.DisplayMember = "Value";
            cbbType.ValueMember = "Key";
            cbbType.DataSource = new BindingSource(cbblistype, null);


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
            
                    if (MessageBox.Show(dgvItem.SelectedRows[0].Cells[1].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // MessageBox.Show(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString());
                        if (itemservice.DeleteItem_MasterVO(dgvItem.SelectedRows[0].Cells[0].Value.ToString()))
                        {
                            GetAllItem();
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
                    MDS_SDS_002_1 frm = new MDS_SDS_002_1();

                    if (frm.ShowDialog() == DialogResult.OK) { 

                    MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllItem();
                        ControlSetting();
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
                    GetAllItem();
                    ///
                    ControlSetting();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void RdoName_CheckedChanged(object sender, EventArgs e)
        {
            cbbItem.Enabled = true;
            lblCode.Enabled = true;
            btnSearch.Enabled = true;

            cbbType.Enabled = false;
            btnSearch2.Enabled = false;
        }

        private void RdoType_CheckedChanged(object sender, EventArgs e)
        {
            cbbItem.Enabled = false;
            btnSearch.Enabled = false;
            cbbType.Enabled = true;
            btnSearch2.Enabled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dgvItem.DataSource = null;
            dgvItem.DataSource = Itemlist;
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(lblCode.Text.Trim()))
                {
                    row.Selected = true;
                }
            }
        }

        private void BtnSearch2_Click(object sender, EventArgs e)
        {
            List<Item_MasterVO> typelist = Itemlist.FindAll(item => item.Item_Type == cbbType.Text);

            dgvItem.DataSource = typelist;
        }

        private void CbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCode.Text = cbbItem.SelectedValue.ToString();
        }

        private void DgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            upitem = Itemlist.Find(item => item.Item_Code == dgvItem.SelectedRows[0].Cells[0].Value.ToString());

            lblupdateCode.Text = upitem.Item_Code;
            lblupdateName.Text = upitem.Item_Name;
            nudCavity.Text = (upitem.Cavity).ToString();

            nudLine_Per_Qty.Text = upitem.Line_Per_Qty.ToString();
            nudShot_Per_Qty.Text = upitem.Shot_Per_Qty.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            upitem.Cavity = Convert.ToInt32(nudCavity.Value);
            upitem.Line_Per_Qty = Convert.ToInt32(nudLine_Per_Qty.Value);
            upitem.Shot_Per_Qty = Convert.ToInt32(nudShot_Per_Qty.Value);
            upitem.Ins_Date = DateTime.Now;
            upitem.Ins_Emp = UserInfo.User_Name;

            try
            {
                if (itemservice.InsertUpdateAllItem_Master(upitem))
                {
                    MessageBox.Show(upitem.Item_Name + "이 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllItem();
                    ControlSetting();
                }
                else
                {
                    MessageBox.Show(upitem.Item_Name + "의 수정에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception err)
            {
                Program.Log.WriteError(err.Message);
                throw;
            }
        }

        private void MDS_SDS_002_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }
    }
}
