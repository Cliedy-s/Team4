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
        public MDS_SDS_002()
        {
            InitializeComponent();
        }

        private void MDS_SDS_002_Load(object sender, EventArgs e)
        {
            cbbType.Enabled = false;
            btnSearch2.Enabled = false;

            nudCavity.Enabled = false;
            nudLine_Per_Qty.Enabled = false;
            nudShot_Per_Qty.Enabled = false;
            btnSave.Enabled = false;

            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록

            DatagridviewDesigns.SetDesign(dgvItem);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "품목코드", "Item_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "품목명", "Item_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "영문명", "Item_Name_Eng", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "약어", "Item_Name_Eng_Alias", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "유형", "Item_Type", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "규격", "Item_Spec", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "단위", "Item_Unit", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "안전재고", "Item_Stock", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "갯수", "LotSize", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "시간당생산수", "PrdQty_Per_Hour", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "배치당생산수", "PrdQTy_Per_Batch", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "캐비티수", "Cavity", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "성형줄당PCS수", "Line_Per_Qty", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "포장Shot당PCS수", "Shot_Per_Qty", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "건조대차기본수량", "Dry_GV_Qty", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "소성대차기본수량", "Heat_GV_Qty", true, 210, default, true);

            GetAllItem();
            ///
            ControlSetting();
        }

      
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllItem()
        {

            Itemlist = new List<Item_MasterVO>();
            Itemlist = itemservice.GetAllItem_Master();
            dgvItem.DataSource = Itemlist;
        }
        /// <summary>
        ///  콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            // combobox  품목명
             List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();

            Dictionary<string, string> cbblistname = dictionname.ToDictionary(code => code.Item_Code,name=>name.Item_Name);
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
        public void MyUpdateShow(object sender, EventArgs e)
        {

            nudCavity.Enabled = true;
            nudLine_Per_Qty.Enabled = true;
            nudShot_Per_Qty.Enabled = true;
            btnSave.Enabled = true;
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
             List<Item_MasterVO> typelist =  Itemlist.FindAll(item => item.Item_Type == cbbType.Text);
         
            dgvItem.DataSource = typelist;
        }

        private void CbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCode.Text = cbbItem.SelectedValue.ToString();
        }

        private void DgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Item_MasterVO upitem = Itemlist.Find(item => item.Item_Code == dgvItem.SelectedRows[0].Cells[0].Value.ToString());

            lblupdateCode.Text = upitem.Item_Code;
            lblupdateName.Text = upitem.Item_Name;
            nudCavity.Text=(upitem.Cavity).ToString();

            nudLine_Per_Qty.Text = upitem.Line_Per_Qty.ToString();
            nudShot_Per_Qty.Text = upitem.Shot_Per_Qty.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
