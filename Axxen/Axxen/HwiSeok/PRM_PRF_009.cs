﻿using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using VO;

namespace Axxen
{
    public partial class PRM_PRF_009 : Axxen.GridForm
    {
        List<WorkHistory_Center_UserMasterVO> whcu;
        List<WorkHistory_Center_UserMasterVO> whcuList;
        WorkHistory_Center_UserMasterService whcuservice = new WorkHistory_Center_UserMasterService();
        public PRM_PRF_009()
        {
            InitializeComponent();
        }

        private void PRM_PRF_009_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            #region 그리드뷰
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "근무일", "Work_Date", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "작업장", "Wc_Name", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "작업자", "User_Name", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "근무시작시간", "Work_StartTime", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "근무종료시간", "Work_EndTime", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "근무시간", "Work_Time", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            #endregion

            whcu = whcuservice.GetAllWorkHistory_Center_UserMaster(); //전체 조회
            dgvMainGrid.DataSource = whcu;
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    whcu = whcuservice.GetAllWorkHistory_Center_UserMaster();
                    dgvMainGrid.DataSource = whcu;

                    aTextBox_FindNameByCode1.txtCodeText = "";
                    aTextBox_FindNameByCode1.txtNameText = "";
                    aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                }
            }
            catch (Exception err)
            {
         
                Program.Log.WriteError(err.Message);
            }
        }

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) //날짜별 조회
        {
            whcu = whcuservice.PickerWorkHistory_Center_UserMaster(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = whcu;

            aTextBox_FindNameByCode1.txtCodeText = "";
            aTextBox_FindNameByCode1.txtNameText = "";
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args)
        {
            whcuList = (from date in whcu
                        where date.User_Name == aTextBox_FindNameByCode1.txtNameText
                        select date).ToList();
            dgvMainGrid.DataSource = whcuList;
        }

        private void PRM_PRF_009_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침

        }

        private void btnExecl_Click(object sender, EventArgs e) //엑셀 저장
        {
            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (WaitForm frm = new WaitForm(ExportOrderList))
                {
                    frm.ShowDialog(this);
                }

                MessageBox.Show("엑셀 저장 완료", "엑셀 저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportOrderList()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            int i, j;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add();
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 2] = "근무일";
            xlWorkSheet.Cells[1, 3] = "작업장";
            xlWorkSheet.Cells[1, 4] = "작업자";
            xlWorkSheet.Cells[1, 5] = "근무시작시간";
            xlWorkSheet.Cells[1, 6] = "근무종료시간";
            xlWorkSheet.Cells[1, 7] = "근무시간";

            for (i = 0; i <= dgvMainGrid.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvMainGrid.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 2] = dgvMainGrid[j, i].Value.ToString();
                }
            }

            xlWorkSheet.Columns.AutoFit();
            xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal);
            xlWorkBook.Close(true);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


    }
}