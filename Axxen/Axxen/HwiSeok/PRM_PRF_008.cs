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
    public partial class PRM_PRF_008 : Axxen.GridForm
    {
        List<Nop_History_Mi_MaVO> nohm;
        Nop_History_Mi_MaService nohmservice = new Nop_History_Mi_MaService();
        public PRM_PRF_008()
        {
            InitializeComponent();
        }

        private void PRM_PRF_008_Load(object sender, EventArgs e)
        {
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비가동일자", "Nop_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장코드", "Wc_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비가동대분류", "Nop_Ma_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비가동상세분류", "Nop_Mi_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비가동발생시각", "Nop_Happentime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비가동종료시각", "Nop_Canceltime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비가동시간", "Nop_Time", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비고", "Remark", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "발생유형", "Nop_Type", true, 100, default, true);

            nohm = nohmservice.GetAllNop_History_Mi_Ma();
            dgvMainGrid.DataSource = nohm;
        }

        private void ADateTimePickerSearch2_btnDateTimeSearch_Click(object sender, EventArgs args)
        {
            nohm = nohmservice.GetDatePicker_Nop_History_Mi_Ma(aDateTimePickerSearch2.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch2.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = nohm;
        }
    }
}
