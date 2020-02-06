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
    public partial class PRM_PRF_005 : Axxen.GridForm
    {
        List<GV_Work_ItemVO> gvwi;
        List<GV_Work_ItemVO> gvwiList;
        GV_Work_ItemService gvwiservice = new GV_Work_ItemService();
        public PRM_PRF_005()
        {
            InitializeComponent();
        }

        private void PRM_PRF_005_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차코드", "GV_Code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차명", "GV_Name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차그룹명", "GV_Group", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 120, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차상태", "GV_Status", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차수량", "GV_Qty", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩일자", "Loading_date", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩시간", "Loading_time", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩작업장", "Loading_Wc", true, 120, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩일자", "Unloading_date", true, 120, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩시간", "Unloading_time", true, 120, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩작업장", "Unloading_Wc", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "요입시간", "In_Time", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "중간시간", "Center_Time", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "요출시간", "Out_Time", true, 150, default, false);

            gvwi = gvwiservice.GetAllGV_Work_Item();
            dgvMainGrid.DataSource = gvwi;
        }

        private void RefreshFormShow(object sender, EventArgs e) //새로고침
        {          
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    gvwi = gvwiservice.GetAllGV_Work_Item();
                    dgvMainGrid.DataSource = gvwi;

                    aTextBox_FindNameByCode1.txtCodeText = "";
                    aTextBox_FindNameByCode1.txtNameText = "";
                    aTextBox_FindNameByCode2.txtCodeText = "";
                    aTextBox_FindNameByCode2.txtNameText = "";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //대차그룹별
        {
            if (aTextBox_FindNameByCode2.txtCodeText == "")
            {
                gvwiList = (from date in gvwi
                             where date.GV_Group == aTextBox_FindNameByCode1.txtNameText
                             select date).ToList();
                dgvMainGrid.DataSource = gvwiList;
            }
            else if(aTextBox_FindNameByCode2.txtCodeText != "" && aTextBox_FindNameByCode1.txtCodeText != "")
            {
                gvwiList = (from date in gvwi
                             where date.GV_Group == aTextBox_FindNameByCode1.txtNameText && date.Item_Code == aTextBox_FindNameByCode2.txtCodeText
                             select date).ToList();
                dgvMainGrid.DataSource = gvwiList;
            }
        }

        private void aTextBox_FindNameByCode2_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //품목별
        {
            if (aTextBox_FindNameByCode1.txtCodeText == "")
            {
                gvwiList = (from date in gvwi
                             where date.Item_Code == aTextBox_FindNameByCode2.txtCodeText
                             select date).ToList();
                dgvMainGrid.DataSource = gvwiList;
            }
            else if (aTextBox_FindNameByCode2.txtCodeText != "" && aTextBox_FindNameByCode1.txtCodeText != "")
            {
                gvwiList = (from date in gvwi
                             where date.GV_Group == aTextBox_FindNameByCode1.txtNameText && date.Item_Code == aTextBox_FindNameByCode2.txtCodeText
                             select date).ToList();
                dgvMainGrid.DataSource = gvwiList;

            }
        }

        private void PRM_PRF_005_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침
        }
    }
}
