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
    public partial class PRM_PRF_004 : Axxen.GridForm
    {
        List<GasUse_HistoryVO> guho;
        GasUse_History_Service ghservice = new GasUse_History_Service();

        public PRM_PRF_004()
        {
            InitializeComponent();
        }

        private void PRM_PRF_004_Load(object sender, EventArgs e)
        {
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

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args)
        {
            guho = ghservice.GetDatePicker_GasUse_History(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = guho;
        }
    }
}
