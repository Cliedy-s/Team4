using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using VO;

namespace Axxen
{
    public partial class PRM_PRF_004 : Axxen.GridForm
    {
        List<GasUse_HistoryVO> guho;
        List<GasUse_HistoryVO> guhoList;
        GasUse_History_Service ghservice = new GasUse_History_Service();

        public PRM_PRF_004()
        {
            InitializeComponent();
        }

        private void PRM_PRF_004_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "이력순번", "Seq", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "기준일자", "Std_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업코드", "Wc_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "GAS사용량", "Gas_Val", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비고", "Remark", true, 100, default, true);

            guho = ghservice.GetAllGasUse_History();
            dgvMainGrid.DataSource = guho;
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            guho = ghservice.GetAllGasUse_History();
            dgvMainGrid.DataSource = guho;
            aTextBox_FindNameByCode1.txtCodeText = "";
            aTextBox_FindNameByCode1.txtNameText = "";
            aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
            aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) // 날짜별 조회
        {
            guho = ghservice.GetDatePicker_GasUse_History(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = guho;
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //작업장별 조회
        {
            guhoList = (from date in guho
                        where date.Wc_Name == aTextBox_FindNameByCode1.txtNameText
                       select date).ToList();
            dgvMainGrid.DataSource = guhoList;
        }
    }
}
