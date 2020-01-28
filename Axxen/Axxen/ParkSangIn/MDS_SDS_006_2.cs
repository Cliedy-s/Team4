using System;
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


        public string Code { get; set; }
        public MDS_SDS_006_2()
        {
            InitializeComponent();
        }

        private void MDS_SDS_006_2_Load(object sender, EventArgs e)
        {
      

            DatagridviewDesigns.SetDesign(dgvinspect);
          
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "공정코드", "Process_code", true, 210, default, true);  
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "검사항목코드", "Item_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "검사항목명", "Process_code", true, 210, default, true);
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
                dgvinspect.DataSource = inspectlist.FindAll(item => item.Item_Code == Code);
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
            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvinspect.Columns.Add(gridbtn);

            // combobox  품목명
            Itemlist.RemoveAll(item => item.Item_Code ==Code);
            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();
            Dictionary<string, string> cbblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbbItem.DisplayMember = "Value";
            cbbItem.ValueMember = "Key";
            cbbItem.DataSource = new BindingSource(cbblistname, null);
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }

        private void Dgvinspect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvinspect.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvinspect.SelectedRows[0].Cells[9].Value).ToString() == "Y") //사용안함
                    {
                        dgvinspect.SelectedRows[0].Cells[9].Value = "N";
                    }
                    else //사용함
                    {
                        dgvinspect.SelectedRows[0].Cells[9].Value = "Y";
                    }          
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Inspect_Spec_MasterService service = new Inspect_Spec_MasterService();

                foreach (DataGridViewRow row in dgvinspect.Rows)
                {
                    if ((row.Cells[9].Value).ToString() == "Y")
                    {                       
                        InspectSpecVO inspect = new InspectSpecVO {

                            Item_Code = lblItem.Text,
                            Process_code = row.Cells[0].Value.ToString(),
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

                        if (service.InsertInspectSpec(inspect))
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
            catch (Exception err)
            {
                MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Log.WriteError(err.Message);
            }
        }
    }
}
