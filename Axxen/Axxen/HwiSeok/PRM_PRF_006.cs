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
    public partial class PRM_PRF_006 : Axxen.GridForm
    {
        List<GV_History_Work_ItemVO> gvhwi;
        List<GV_History_Work_ItemVO> gvhwiList;
        GV_Work_ItemService gvwiservice = new GV_Work_ItemService();
        public PRM_PRF_006()
        {
            InitializeComponent();
        }

        private void PRM_PRF_006_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            #region 그리드뷰 
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차코드", "GV_Code", true, 100, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차명", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 120, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩일자", "Loading_Date", true, 100, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩수량", "Loading_Qty", true, 100, DataGridViewContentAlignment.MiddleRight, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩시간", "Loading_time", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "로딩작업장", "Loading_Wc", true, 100, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "요입시간", "In_Time", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "중간시간", "Center_Time", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "요출시간", "Out_Time", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩수량", "Unloading_Qty", true, 100, DataGridViewContentAlignment.MiddleRight, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩일자", "Unloading_date", true, 100, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩일시", "Unloading_datetime", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "언로딩작업장", "Unloading_wc", true, 120, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대상대차코드", "Target_GV", true, 120, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차비우기일자", "Clear_Date", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차비우기일시", "Clear_Datetime", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차비우기수량", "Clear_Qty", true, 150, DataGridViewContentAlignment.MiddleRight, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대차비우기원인", "Clear_Cause", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대상작업장", "Clear_wc", true, 100, DataGridViewContentAlignment.MiddleCenter, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "대상작업장품목", "Clear_Item", true, 150, DataGridViewContentAlignment.MiddleCenter, false);
            #endregion

            gvhwi = gvwiservice.GetAllGV_History_Work_Item();
            dgvMainGrid.DataSource = gvhwi;
            
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    gvhwi = gvwiservice.GetAllGV_History_Work_Item();
                    dgvMainGrid.DataSource = gvhwi;

                    aTextBox_FindNameByCode1.txtCodeText = "";
                    aTextBox_FindNameByCode1.txtNameText = "";
                    aTextBox_FindNameByCode2.txtCodeText = "";
                    aTextBox_FindNameByCode2.txtNameText = "";
                    aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                }
            }
            catch (Exception err)
            {
            
                Program.Log.WriteError(err.Message);
            }
        }

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) //날짜별조회
        {
            gvhwi = gvwiservice.GetDatePicker_GV_History_Work_Item(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = gvhwi;

            aTextBox_FindNameByCode1.txtCodeText = "";
            aTextBox_FindNameByCode1.txtNameText = "";
            aTextBox_FindNameByCode2.txtCodeText = "";
            aTextBox_FindNameByCode2.txtNameText = "";
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //대차 코드별
        {         
            if (aTextBox_FindNameByCode2.txtCodeText == "")
            {
                gvhwiList = (from date in gvhwi
                             where date.GV_Code == aTextBox_FindNameByCode1.txtCodeText
                             select date).ToList();
                dgvMainGrid.DataSource = gvhwiList;
            }
            else if (aTextBox_FindNameByCode2.txtCodeText != "" && aTextBox_FindNameByCode1.txtCodeText != "")
            {
                gvhwiList = (from date in gvhwi
                             where date.GV_Code == aTextBox_FindNameByCode1.txtCodeText && date.Item_Code == aTextBox_FindNameByCode2.txtCodeText
                             select date).ToList();
                dgvMainGrid.DataSource = gvhwiList;
            }
        }

        private void aTextBox_FindNameByCode2_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //품목별
        {
            if (aTextBox_FindNameByCode1.txtCodeText == "")
            {
                gvhwiList = (from date in gvhwi
                         where date.Item_Code == aTextBox_FindNameByCode2.txtCodeText
                         select date).ToList();
            dgvMainGrid.DataSource = gvhwiList;
            }
            else if (aTextBox_FindNameByCode2.txtCodeText != "" && aTextBox_FindNameByCode1.txtCodeText != "")
            {
                gvhwiList = (from date in gvhwi
                             where date.GV_Code == aTextBox_FindNameByCode1.txtCodeText && date.Item_Code == aTextBox_FindNameByCode2.txtCodeText
                             select date).ToList();
                dgvMainGrid.DataSource = gvhwiList;
            }
        }

        private void PRM_PRF_006_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침
        }
    }
}
