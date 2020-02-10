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
    public partial class PRM_PRF_008 : Axxen.GridForm
    {
        List<Nop_History_Mi_MaVO> nohm;
        List<Nop_History_Mi_MaVO> nohmList;
        Nop_History_Mi_MaService nohmservice = new Nop_History_Mi_MaService();
        
        Nop_HistoryService Nop_HistoryService = new Nop_HistoryService();
        public PRM_PRF_008()
        {
            InitializeComponent();
        }

        private void PRM_PRF_008_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow); // 추가
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.UpdateFormShow); // 수정
            dgvMainGrid.CellDoubleClick += DgvMainGrid_CellDoubleClick; //메인그리드뷰 더블클릭

            #region 그리드뷰
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "발생순번", "Nop_Seq", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "비가동일자", "Nop_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "작업장코드", "Wc_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "작업장명", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "비가동대분류", "Nop_Ma_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "비가동상세분류", "Nop_Mi_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "비가동발생시각", "Nop_Happentime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "비가동종료시각", "Nop_Canceltime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "비가동시간", "Nop_Time", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "비고", "Remark", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "발생유형", "Nop_Type", true, 100, default, true);
            #endregion

            nohm = nohmservice.GetAllNop_History_Mi_Ma();
            dgvMainGrid.DataSource = nohm;
        }

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("비동기 해제하시겠습니까?", "비동기 해제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString().Substring(0, 10) == "0001-01-01")
                {
                    string msg = Nop_HistoryService.DeleteNop_Histroy((dgvMainGrid.SelectedRows[0].Cells[2].Value).ToString(), (dgvMainGrid.SelectedRows[0].Cells[0].Value).ToString());

                    if (msg == "OK")
                    {
                        MessageBox.Show("성공적으로 해제하였습니다.", "비동기 해제 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        nohm = nohmservice.GetAllNop_History_Mi_Ma();
                        dgvMainGrid.DataSource = nohm;
                    }
                    else
                    {
                        MessageBox.Show($"{msg}", "비동기 삭제 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("비가동 중 입니다.", "비동기 해제 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateFormShow(object sender, EventArgs e) // 수정
        {
            if (dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString().Substring(0, 10) == "0001-01-01")
            {
                string msg = Nop_HistoryService.DeleteNop_Histroy((dgvMainGrid.SelectedRows[0].Cells[2].Value).ToString(), (dgvMainGrid.SelectedRows[0].Cells[0].Value).ToString());

                if (msg == "OK")
                {
                    MessageBox.Show("성공적으로 해제하였습니다.", "비동기 해제 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nohm = nohmservice.GetAllNop_History_Mi_Ma();
                    dgvMainGrid.DataSource = nohm;
                }
                else
                {
                    MessageBox.Show($"{msg}", "비동기 삭제 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("비가동 중 입니다.", "비동기 해제 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertFormShow(object sender, EventArgs e) //비가동 등록
        {        
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    PRM_PRF_008_1 frm = new PRM_PRF_008_1();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        nohm = nohmservice.GetAllNop_History_Mi_Ma();
                        dgvMainGrid.DataSource = nohm;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void RefreshFormShow(object sender, EventArgs e) //새로고침
        {

            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    nohm = nohmservice.GetAllNop_History_Mi_Ma();
                    dgvMainGrid.DataSource = nohm;

                    aTextBox_FindNameByCode2.txtCodeText = "";
                    aTextBox_FindNameByCode2.txtNameText = "";
                    aDateTimePickerSearch2.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch2.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void ADateTimePickerSearch2_btnDateTimeSearch_Click(object sender, EventArgs args) //날짜별
        {
            nohm = nohmservice.GetDatePicker_Nop_History_Mi_Ma(aDateTimePickerSearch2.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch2.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = nohm;

            aTextBox_FindNameByCode2.txtCodeText = "";
            aTextBox_FindNameByCode2.txtNameText = "";
        }

        private void aTextBox_FindNameByCode2_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //작업장별
        {
            nohmList = (from date in nohm
                        where date.Wc_Code == aTextBox_FindNameByCode2.txtCodeText
                        select date).ToList();
            dgvMainGrid.DataSource = nohmList;
        }

        private void PRM_PRF_008_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow); // 추가
            ((MainForm)this.MdiParent).MyDeleteEvent -= new System.EventHandler(this.UpdateFormShow); // 삭제
        }
    }
}
