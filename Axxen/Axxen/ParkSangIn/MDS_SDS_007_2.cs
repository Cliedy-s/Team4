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
    public partial class MDS_SDS_007_2 : Axxen.BaseForm
    {
        ItemMaster_Service itemservice = new ItemMaster_Service(); //품목
        List<Item_MasterVO> Itemlist;

        Condition_Spec_MasterService conditionservice = new Condition_Spec_MasterService(); //공정조건
        List<ConditionSpecVO> inspectlist;

        public string itemCode { get; set; }
        public string WorkCode { get; set; }
        public MDS_SDS_007_2()
        {
            InitializeComponent();
        }

        private void MDS_SDS_007_2_Load(object sender, EventArgs e)
        {

            DatagridviewDesigns.SetDesign(dgvCondition);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "품목코드", "Item_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "작어장코드", "Wc_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "검사항목코드", "Condition_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "검사항목명", "Condition_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "규격상한값", "USL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "규격기준값", "SL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "규격하한값", "LSL", true, 210, default, true);

            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "단위", "Condition_Unit", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "비고", "Remark", true, 210, default, true);


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
                Itemlist = new List<Item_MasterVO>(); //품목전체
                Itemlist = itemservice.GetAllItem_Master();


                inspectlist = new List<ConditionSpecVO>();
                inspectlist = conditionservice.GetAll();//공정규격전체


               //var inspectlist2 = from item in inspectlist
               //                               where item.Item_Code == itemCode && item.Wc_Code == WorkCode
               //                               select item;
              
                dgvCondition.DataSource = inspectlist.FindAll(item => item.Item_Code == itemCode && item.Wc_Code == WorkCode);
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
            DataGridViewCheckBoxColumn gridcheckbox = new DataGridViewCheckBoxColumn();
            gridcheckbox.HeaderText = "선택";
            gridcheckbox.Name = "checkbtn";
            dgvCondition.Columns.Insert(0, gridcheckbox);

            // combobox  품목명
            Itemlist.RemoveAll(item => item.Item_Code == itemCode);
            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();
            Dictionary<string, string> cbblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbbItem.DisplayMember = "Value";
            cbbItem.ValueMember = "Key";
            cbbItem.DataSource = new BindingSource(cbblistname, null);
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }

        private void CbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItem.Text = cbbItem.SelectedValue.ToString();

            //dgvCondition.DataSource = null;
            //var a = from item in inspectlist
            //        let ss = from p in inspectlist
            //                 where p.Item_Code == lblItem.Text
            //                 select p
            //        where !ss.Contains(item)
            //        select item;

            //inspectlist.FindAll(item=>item.)
            //dgvCondition.DataSource = a;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCondition.Rows)
            {

                if (Convert.ToBoolean(row.Cells[0].Value) == true) //체크박스가 선택된 row들만
                {
                
                    ConditionSpecVO inspect = new ConditionSpecVO
                    {
                        Item_Code = lblItem.Text,
                        Wc_Code = row.Cells[0].Value.ToString(),
                        Condition_Code = row.Cells[1].Value.ToString(),
                        Condition_Name = row.Cells[2].Value.ToString(),
                        //Spec_Desc    =                     ,
                        USL =Convert.ToInt32( row.Cells[0].Value),
                        SL = Convert.ToInt32(row.Cells[0].Value),
                        LSL = Convert.ToInt32(row.Cells[0].Value),
                        Condition_Unit = row.Cells[6].Value.ToString(),
                        Remark = row.Cells[7].Value.ToString(),

                    };
                


                    if (conditionservice.InsertConditionSpec(inspect))
                    {
                        MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
