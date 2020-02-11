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
    public partial class QAM_SQC_004 : Axxen.GridForm
    {
        List<InspectMeasure_History_MasterVO> lhm;
        List<InspectMeasure_History_MasterVO> lhmList;
        InspectMeasure_History_MasterService lhmservice = new InspectMeasure_History_MasterService();

        public QAM_SQC_004()
        {
            InitializeComponent();
        }

        private void QAM_SQC_004_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            #region 그리드뷰
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 150, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일", "Prd_Date", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정", "Process_name", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Name", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 150, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "측정항목", "Inspect_name", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "USL", "USL", true, 100, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "SL", "SL", true, 100, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "LSL", "LSL", true, 100, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "측정일시", "Inspect_datetime", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "측정회차", "Inspect_date", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "측정순번", "Inspect_measure_seq", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "측정값", "Inspect_val", true, 100, DataGridViewContentAlignment.MiddleRight, true);
            #endregion

            lhm = lhmservice.GetAllInspectMeasure_History_Master(); //전체 조회
            dgvMainGrid.DataSource = lhm;
        }

        private void RefreshFormShow(object sender, EventArgs e) //새로고침 
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                    lhm = lhmservice.GetAllInspectMeasure_History_Master(); //전체 조회
                    dgvMainGrid.DataSource = lhm;

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

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) // 날짜별 조회
        {
            lhm = lhmservice.PickerInspectMeasure_History_Master(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString()); //전체 조회
            dgvMainGrid.DataSource = lhm;

            aTextBox_FindNameByCode1.txtCodeText = "";
            aTextBox_FindNameByCode1.txtNameText = "";
            aTextBox_FindNameByCode2.txtCodeText = "";
            aTextBox_FindNameByCode2.txtNameText = "";
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) // 공정별 조회
        {
            if (aTextBox_FindNameByCode2.txtCodeText == "")
            {
                lhmList = (from date in lhm
                           where date.Process_name == aTextBox_FindNameByCode1.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = lhmList;
            }
            else
            {
                lhmList = (from date in lhm
                           where date.Process_name == aTextBox_FindNameByCode1.txtNameText && date.Wc_Name == aTextBox_FindNameByCode2.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = lhmList;
            }
        }

        private void aTextBox_FindNameByCode2_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //작업장별
        {
            if (aTextBox_FindNameByCode1.txtCodeText == "")
            {
                lhmList = (from date in lhm
                           where date.Wc_Name == aTextBox_FindNameByCode2.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = lhmList;
            }
            else
            {
                lhmList = (from date in lhm
                           where date.Wc_Name == aTextBox_FindNameByCode2.txtNameText && date.Process_name == aTextBox_FindNameByCode1.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = lhmList;
            }
        }

        private void QAM_SQC_004_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침
        }
    }
}
