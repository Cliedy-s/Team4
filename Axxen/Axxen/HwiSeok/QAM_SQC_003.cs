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
    public partial class QAM_SQC_003 : Axxen.GridGridGridForm
    {
        DataTable dt;
        List<Condition_History_MasterVO> chm1;
        List<Condition_History_MasterVO> chm2;
        List<Condition_History_MasterVO> chmList;
        Condition_Measure_HistoryService cmhService = new Condition_Measure_HistoryService();
        Condition_History_MasterSerivce chmservice = new Condition_History_MasterSerivce();
        public QAM_SQC_003()
        {
            InitializeComponent();
        }

        private void QAM_SQC_003_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow); // 추가
            ((MainForm)this.MdiParent).MyDeleteEvent += new System.EventHandler(this.MyDeleteShow); // 삭제
            dgvMainGrid.CellDoubleClick += DgvMainGrid_CellDoubleClick; //메인그리드뷰 더블클릭
            dgvSubGrid.CellDoubleClick += DgvSubGrid_CellDoubleClick; //서브그리드뷰 더블클릭
            dgvSubSubGrid.CellDoubleClick += DgvSubSubGrid_CellDoubleClick; //서브서브그리드뷰 더블클릭

            #region 메인그리드뷰
            DatagridviewDesigns.SetDesign(dgvMainGrid);            
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 120, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일", "Prd_Date", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정코드", "Process_code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정명", "Process_name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "항목코드", "Condition_Code", true, 100, default, false);
            #endregion

            chm1 = chmservice.GetMainCondition_History_Master(); //메인그리드뷰 조회
            dgvMainGrid.DataSource = chm1;

            #region 서브그리드뷰
            DatagridviewDesigns.SetDesign(dgvSubGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "측정항목", "Condition_Name", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "기준값", "SL", true, 100, default, false);
            #endregion


            #region 서브서브그리드뷰
            DatagridviewDesigns.SetDesign(dgvSubSubGrid);
            dgvSubSubGrid.AutoGenerateColumns = true;
            dgvSubSubGrid.AllowUserToAddRows = false;
            dgvSubSubGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
            #endregion
        }

        private void MyDeleteShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    if (lblnum.Text == "")
                    {
                        MessageBox.Show("삭제 할 측정횟차를 선택해주세요.", "선택", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bool IsSuccess = cmhService.DeleteConditionMeasure(Convert.ToInt32(lblnum.Text));
                            if (IsSuccess)
                            {
                                MessageBox.Show("성공적으로 삭제하였습니다.", "삭제성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                chm1 = chmservice.GetMainCondition_History_Master(); //메인그리드뷰 조회
                                dgvMainGrid.DataSource = chm1;
                                lblnum.Text = "";

                                dgvSubGrid.DataSource = null;
                                dgvSubSubGrid.DataSource = null;
                                if (dgvSubSubGrid.Columns.Count == 0)
                                {
                                    DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
                                    DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 100, default, false);
                                    DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                                    DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                                    DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
                                }
                                lblnum.Text = "";
                            }
                            else
                                MessageBox.Show("삭제에 실패하였습니다.", "삭제오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                  
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void InsertFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    QAM_SQC_003_1 frm = new QAM_SQC_003_1();

                    frm.Item_code = dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString();
                    frm.Wc_Code = dgvMainGrid.SelectedRows[0].Cells[5].Value.ToString();
                    frm.Condition_Code = dgvMainGrid.SelectedRows[0].Cells[9].Value.ToString();
                    frm.Workorderno = dgvMainGrid.SelectedRows[0].Cells[1].Value.ToString();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        chm1 = chmservice.GetMainCondition_History_Master(); //추가
                        dgvMainGrid.DataSource = chm1;
                        lblnum.Text = "";
                    }
                    dgvSubGrid.DataSource = null;
                    dgvSubSubGrid.DataSource = null;
                    if (dgvSubSubGrid.Columns.Count == 0)
                    {
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 100, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
                    }                
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void DgvSubSubGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //서브서브 그리드뷰 더블클릭
        {
            lblnum.Text = dgvSubSubGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //메인 그리드뷰 더블클릭
        {
            lblnum.Text = "";
            chm2 = chmservice.GetSubCondition_History_Master(dgvMainGrid.SelectedRows[0].Cells[1].Value.ToString(), dgvMainGrid.SelectedRows[0].Cells[3].Value.ToString()
               , dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString(), dgvMainGrid.SelectedRows[0].Cells[9].Value.ToString()); //서브그리드뷰 조회
            dgvSubGrid.DataSource = chm2;
        }

        private void DgvSubGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //서브 그리드뷰 더블클릭
        {
            lblnum.Text = "";
            dt = chmservice.GetSubSubCondition_History_Master(dgvMainGrid.SelectedRows[0].Cells[1].Value.ToString(), dgvMainGrid.SelectedRows[0].Cells[3].Value.ToString()
               , dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString(), dgvMainGrid.SelectedRows[0].Cells[9].Value.ToString()); //서브그리드뷰 조회
            dgvSubSubGrid.DataSource = dt;
        }
       
        private void RefreshFormShow(object sender, EventArgs e) //새로고침
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    chm1 = chmservice.GetMainCondition_History_Master(); //메인그리드뷰 조회
                    dgvMainGrid.DataSource = chm1;

                    aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    aTextBox_FindNameByCode1.txtCodeText = "";
                    aTextBox_FindNameByCode1.txtNameText = "";
                    aTextBox_FindNameByCode2.txtCodeText = "";
                    aTextBox_FindNameByCode2.txtNameText = "";

                    dgvSubGrid.DataSource = null;

                    dgvSubSubGrid.DataSource = null;
                    if (dgvSubSubGrid.Columns.Count == 0)
                    {
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 100, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                        DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
                    }


                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
            lblnum.Text = "";
        }

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) //날짜조회
        {
            chm1 = chmservice.PickerMainCondition_History_Master(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString()); //메인그리드뷰 조회
            dgvMainGrid.DataSource = chm1;
            lblnum.Text = "";
            dgvSubGrid.DataSource = null;
            dgvSubSubGrid.DataSource = null;
            if (dgvSubSubGrid.Columns.Count == 0)
            {
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
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
                chmList = (from date in chm1
                           where date.Process_name == aTextBox_FindNameByCode1.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = chmList;
            }
            else
            {
                chmList = (from date in chm1
                           where date.Process_name == aTextBox_FindNameByCode1.txtNameText && date.Wc_Name == aTextBox_FindNameByCode2.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = chmList;
            }
            lblnum.Text = "";
            dgvSubGrid.DataSource = null;
            dgvSubSubGrid.DataSource = null;
            if (dgvSubSubGrid.Columns.Count == 0)
            {
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
            }
        }

        private void aTextBox_FindNameByCode2_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args)
        {
            if (aTextBox_FindNameByCode1.txtCodeText == "")
            {
                chmList = (from date in chm1
                           where date.Wc_Name == aTextBox_FindNameByCode2.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = chmList;
            }
            else
            {
                chmList = (from date in chm1
                           where date.Wc_Name == aTextBox_FindNameByCode2.txtNameText && date.Process_name == aTextBox_FindNameByCode1.txtNameText
                           select date).ToList();
                dgvMainGrid.DataSource = chmList;
            }
            lblnum.Text = "";
            dgvSubGrid.DataSource = null;
            dgvSubSubGrid.DataSource = null;
            if (dgvSubSubGrid.Columns.Count == 0)
            {
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
            }
        }

        private void QAM_SQC_003_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침
        }

        private void btnadd_Click(object sender, EventArgs e) //추가
        {
            QAM_SQC_003_1 frm = new QAM_SQC_003_1();

            frm.Item_code = dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString();
            frm.Wc_Code = dgvMainGrid.SelectedRows[0].Cells[5].Value.ToString();
            frm.Condition_Code = dgvMainGrid.SelectedRows[0].Cells[9].Value.ToString();
            frm.Workorderno = dgvMainGrid.SelectedRows[0].Cells[1].Value.ToString();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                chm1 = chmservice.GetMainCondition_History_Master(); //추가
                dgvMainGrid.DataSource = chm1;
            }
            dgvSubGrid.DataSource = null;
            dgvSubSubGrid.DataSource = null;
            if (dgvSubSubGrid.Columns.Count == 0)
            {
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
            }
            lblnum.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e) //삭제
        {
            if (lblnum.Text == "")
            {
                MessageBox.Show("삭제 할 측정횟차를 선택해주세요.", "선택", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool IsSuccess = cmhService.DeleteConditionMeasure(Convert.ToInt32(lblnum.Text));
                    if (IsSuccess)
                    {
                        MessageBox.Show("성공적으로 삭제하였습니다.", "삭제성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        chm1 = chmservice.GetMainCondition_History_Master(); //메인그리드뷰 조회
                        dgvMainGrid.DataSource = chm1;
                        lblnum.Text = "";

                        dgvSubGrid.DataSource = null;
                        dgvSubSubGrid.DataSource = null;
                        if (dgvSubSubGrid.Columns.Count == 0)
                        {
                            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "조건순번", "Condition_measure_seq", true, 100, default, false);
                            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일시", "Condition_Datetime", true, 100, default, false);
                            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목코드", "Item_code", true, 100, default, false);
                            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "품목명", "Item_Name", true, 150, default, false);
                            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubSubGrid, "측정일자", "Condition_Date", true, 100, default, false);
                        }
                    }
                    else
                        MessageBox.Show("삭제에 실패하였습니다.", "삭제오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            lblnum.Text = "";
        }
    }
}
