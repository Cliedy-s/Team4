﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;
using Service;
using System.Linq;

namespace Axxen
{
    public partial class MDS_SDS_006_2 : Axxen.BaseForm
    {

        ItemMaster_Service itemservice = new ItemMaster_Service();
        List<Item_MasterVO> Itemlist;

        Inspect_Spec_MasterService inspectservice = new Inspect_Spec_MasterService();
        List<InspectSpecVO> inspectlist;

        CheckBox headerCheckBox = new CheckBox();
        public string itemCode { get; set; }
        public string Process_code { get; set; }
        public MDS_SDS_006_2()
        {
            InitializeComponent();
        }

        private void MDS_SDS_006_2_Load(object sender, EventArgs e)
        {
      

            DatagridviewDesigns.SetDesign(dgvinspect);
          
          
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "검사항목코드", "Inspect_code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "검사항목명", "Inspect_name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "규격상한값", "USL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "규격기준값", "SL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "규격하한값", "LSL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "샘플크기", "Sample_size", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "단위", "Inspect_Unit", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "비고", "Remark", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "사용여부", "Use_YN", true, 210, default, true);

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
         

                inspectlist = new List<InspectSpecVO>();
                inspectlist = inspectservice.GetAll();//품목규격전체
                var a = inspectlist.FindAll(item => item.Item_Code == itemCode && item.Process_code == Process_code); 
                dgvinspect.DataSource = a;
            }
            catch (Exception err)
            {
                Program.Log.WriteError(err.Message);
                
            }
        }
        /// <summary>
        ///  콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {

            DataGridViewCheckBoxColumn gridcheckbox = new DataGridViewCheckBoxColumn();
            gridcheckbox.HeaderText = "";
            gridcheckbox.Name = "checkbtn";
            gridcheckbox.Width = 30;
            dgvinspect.Columns.Insert(0, gridcheckbox);



            Point headerLocation = dgvinspect.GetCellDisplayRectangle(0, -1, true).Location;
            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 2);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Click);
            dgvinspect.Controls.Add(headerCheckBox);


            // combobox  품목명
            Itemlist.RemoveAll(item => item.Item_Code ==itemCode);
            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();
            Dictionary<string, string> cbblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbbItem.DisplayMember = "Value";
            cbbItem.ValueMember = "Key";
            cbbItem.DataSource = new BindingSource(cbblistname, null);
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            dgvinspect.EndEdit();

            foreach (DataGridViewRow row in dgvinspect.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["checkbtn"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }

        private void Dgvinspect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<InspectSpecVO> addlist = new List<InspectSpecVO>();
            try
            {
                Inspect_Spec_MasterService service = new Inspect_Spec_MasterService();

                foreach (DataGridViewRow row in dgvinspect.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true) //체크박스가 선택된 row들만
                    {
                        InspectSpecVO inspect = new InspectSpecVO {

                            Item_Code = lblItem.Text,
                            Process_code = Process_code,
                            Inspect_code = row.Cells[1].Value.ToString(),
                            Inspect_name = row.Cells[2].Value.ToString(),
                            //Spec_Desc    =                     ,
                            USL = Convert.ToInt32(row.Cells[3].Value),
                            SL = Convert.ToInt32(row.Cells[4].Value),
                            LSL = Convert.ToInt32(row.Cells[5].Value),
                            Sample_size = Convert.ToInt32(row.Cells[6].Value),
                            Inspect_Unit = row.Cells[7].Value.ToString(),
                            Remark = row.Cells[8].Value.ToString()
                        };

                        addlist.Add(inspect);

                    }
                }
                if (service.InsertInspectSpec(addlist))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Log.WriteError(err.Message);
            }
        }

        private void CbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }
    }
}
