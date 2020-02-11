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
    public partial class QAM_SQC_002 : Axxen.GridGridGridForm
    {
        DataTable dt;
        List<InspectMeasure_History_MasterVO> lhm1;
        List<InspectMeasure_History_MasterVO> lhm2;
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
            dgvSubGrid.CellDoubleClick += DgvSubGrid_CellDoubleClick; //서브그리드뷰 더블클릭

            #region 메인그리드뷰
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 120, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일", "Prd_Date", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정코드", "Process_code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정명", "Process_name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "항목코드", "Inspect_code", true, 100, default, false);
            #endregion

            lhm1 = lhmservice.GetMainInspectMeasure_History_Master(); //메인그리드뷰 조회
            dgvMainGrid.DataSource = lhm1;

            #region 서브그리드뷰
            DatagridviewDesigns.SetDesign(dgvSubGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "측정항목", "Inspect_name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "기준값", "SL", true, 100, default, false);
            #endregion


            #region 서브서브그리드뷰
            DatagridviewDesigns.SetDesign(dgvSubSubGrid);
            dgvSubSubGrid.AutoGenerateColumns = true;
            dgvSubSubGrid.AllowUserToAddRows = false;
            dgvSubSubGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Inspect_datetime", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Inspect_date", true, 100, default, false);
            #endregion

        }

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //메인그리드뷰 더블클릭
        {
            lhm2 = lhmservice.GetSubInspectMeasure_History_Master(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString() , dgvMainGrid.SelectedRows[0].Cells[2].Value.ToString()
                , dgvMainGrid.SelectedRows[0].Cells[5].Value.ToString(), dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString()); //서브그리드뷰 조회
            dgvSubGrid.DataSource = lhm2;
        }
        private void DgvSubGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //서브그리드뷰 더블클릭
        {
            dt = lhmservice.GetSubSubInspectMeasure_History_Master(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString(), dgvMainGrid.SelectedRows[0].Cells[2].Value.ToString()
                , dgvMainGrid.SelectedRows[0].Cells[5].Value.ToString(), dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString()); //서브서브그리드뷰 조회
            dgvSubSubGrid.DataSource = dt;
        }
        private void RefreshFormShow(object sender, EventArgs e) //새로고침
        {        
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    lhm1 = lhmservice.GetMainInspectMeasure_History_Master(); //메인그리드뷰 조회
                    dgvMainGrid.DataSource = lhm1;

                    aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    aTextBox_FindNameByCode1.txtCodeText = "";
                    aTextBox_FindNameByCode1.txtNameText = "";
                    aTextBox_FindNameByCode2.txtCodeText = "";
                    aTextBox_FindNameByCode2.txtNameText = "";

                    dgvSubGrid.DataSource = null;

                    dgvSubSubGrid.DataSource = null;
                    if (dgvSubSubGrid.Columns.Count==0)
                    {
                      
                    
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Inspect_datetime", true, 100, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Inspect_date", true, 100, default, false);
                    }
                   

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) //날짜별 조회
        {

            lhm1 = lhmservice.PickerMainInspectMeasure_History_Master(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString()); //메인그리드뷰 조회
            dgvMainGrid.DataSource = lhm1;

            dgvSubGrid.DataSource = null;
            dgvSubSubGrid.DataSource = null;
            if (dgvSubSubGrid.Columns.Count == 0)
            {


                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Inspect_datetime", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Inspect_date", true, 100, default, false);
            }
            aTextBox_FindNameByCode1.txtCodeText = "";
            aTextBox_FindNameByCode1.txtNameText = "";
            aTextBox_FindNameByCode2.txtCodeText = "";
            aTextBox_FindNameByCode2.txtNameText = "";
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args)
        {
            if (aTextBox_FindNameByCode2.txtCodeText == "")
            {
                lhmList = (from date in lhm1
                           where date.Process_name == aTextBox_FindNameByCode1.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = lhmList;
            }
            else
            {
                lhmList = (from date in lhm1
                           where date.Process_name == aTextBox_FindNameByCode1.txtNameText && date.Wc_Name == aTextBox_FindNameByCode2.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = lhmList;
            }
            dgvSubGrid.DataSource = null;
            dgvSubSubGrid.DataSource = null;
            if (dgvSubSubGrid.Columns.Count == 0)
            {


                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Inspect_datetime", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Inspect_date", true, 100, default, false);
            }
        }

        private void aTextBox_FindNameByCode2_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args)
        {
            if (aTextBox_FindNameByCode1.txtCodeText == "")
            {
                lhmList = (from date in lhm1
                           where date.Wc_Name == aTextBox_FindNameByCode2.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = lhmList;
            }
            else
            {
                lhmList = (from date in lhm1
                           where date.Wc_Name == aTextBox_FindNameByCode2.txtNameText && date.Process_name == aTextBox_FindNameByCode1.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = lhmList;
            }
            dgvSubGrid.DataSource = null;
            dgvSubSubGrid.DataSource = null;
            if (dgvSubSubGrid.Columns.Count == 0)
            {


                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Inspect_datetime", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Inspect_date", true, 100, default, false);
            }
        }

        private void QAM_SQC_002_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침
        }
    }
}
