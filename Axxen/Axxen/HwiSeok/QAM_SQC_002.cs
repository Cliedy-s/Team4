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
    public partial class QAM_SQC_002 : Axxen.GridGridGridForm
    {

        List<InspectMeasure_History_MasterVO> lhm;
        List<InspectMeasure_History_MasterVO> lhmList;
        InspectMeasure_History_MasterService lhmservice = new InspectMeasure_History_MasterService();
        public QAM_SQC_002()
        {
            InitializeComponent();
        }

        private void QAM_SQC_002_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침
            dgvMainGrid.CellDoubleClick += DgvMainGrid_CellDoubleClick; //메인그리드뷰 더블클릭

            #region 그리드뷰
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일", "Prd_Date", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정코드", "Process_code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정명", "Process_name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "항목코드", "Inspect_code", true, 100, default, false);
            #endregion

            lhm = lhmservice.GetMainInspectMeasure_History_Master(); //메인그리드뷰 조회
            dgvMainGrid.DataSource = lhm;

            #region 서브그리드뷰
            DatagridviewDesigns.SetDesign(dgvSubGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "측정항목", "Inspect_name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "기준값", "SL", true, 100, default, false);
            #endregion
        }

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lhm = lhmservice.GetSubInspectMeasure_History_Master(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString() , dgvMainGrid.SelectedRows[0].Cells[2].Value.ToString()
                , dgvMainGrid.SelectedRows[0].Cells[5].Value.ToString(), dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString()); //서브그리드뷰 조회
            dgvSubGrid.DataSource = lhm;
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
