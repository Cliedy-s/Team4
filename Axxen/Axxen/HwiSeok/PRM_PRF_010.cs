using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class PRM_PRF_010 : Axxen.GridGridForm
    {
        DataTable dt;
        List<WorkHistory_Center_UserMasterVO> whcu;
        WorkHistory_Center_UserMasterService whcuservice = new WorkHistory_Center_UserMasterService();
        public PRM_PRF_010()
        {
            InitializeComponent();
        }

        private void PRM_PRF_010_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침
            dgvMainGrid.CellDoubleClick += DgvMainGrid_CellDoubleClick; //메인그리드뷰 더블클릭

            try
            {
                #region 메인그리드뷰
                DatagridviewDesigns.SetDesign(dgvMainGrid);
                dgvMainGrid.AutoGenerateColumns = true;
                dgvMainGrid.AllowUserToAddRows = false;
                dgvMainGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "사용자ID", "User_ID", true, 100, default, false);
                DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "사용자명", "User_Name", true, 100, default, false);

                dt = whcuservice.PickerWorkHistory_UserMaster(aDateTimePickerSearch2.ADateTimePickerValue1.ToShortDateString().Replace("-", ""), aDateTimePickerSearch2.ADateTimePickerValue2.ToShortDateString().Replace("-", "")); //전체 조회
                dgvMainGrid.DataSource = dt;
                #endregion

            }
            catch
            {
                MessageBox.Show("선택하신 날짜에 근무이력이 없습니다.","근무이력",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            #region 서브그리드뷰
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지시번호", "Workorderno", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업장코드", "Wc_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업장명", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "품목코드", "Item_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "품목명", "Item_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지삭일시", "Prd_Starttime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업종료일시", "Prd_Endtime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산수량", "Prd_Qty", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "할당작업자", "User_Name", true, 100, default, true);
            #endregion
        }

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //더블클릭
        {
            whcu = whcuservice.GetAllUserDetails((dgvMainGrid.SelectedRows[0].Cells[2].Value).ToString());
            dgvSubGrid.DataSource = whcu;
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    aDateTimePickerSearch2.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch2.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                    dt = whcuservice.PickerWorkHistory_UserMaster(aDateTimePickerSearch2.ADateTimePickerValue1.ToShortDateString().Replace("-", ""), aDateTimePickerSearch2.ADateTimePickerValue2.ToShortDateString().Replace("-", "")); //전체 조회
                    dgvMainGrid.DataSource = dt;

                    aTextBox_FindNameByCode1.txtCodeText = "";
                    aTextBox_FindNameByCode1.txtNameText = "";                 
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void PRM_PRF_010_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침 이벤트 삭제
        }

        private void aDateTimePickerSearch2_btnDateTimeSearch_Click(object sender, EventArgs args) //날짜별
        {
            try
            {
                dt = whcuservice.PickerWorkHistory_UserMaster(aDateTimePickerSearch2.ADateTimePickerValue1.ToShortDateString().Replace("-", ""), aDateTimePickerSearch2.ADateTimePickerValue2.ToShortDateString().Replace("-", "")); 
                dgvMainGrid.DataSource = dt;
                aTextBox_FindNameByCode1.txtCodeText = "";
                aTextBox_FindNameByCode1.txtNameText = "";
            }
            catch
            {
                MessageBox.Show("선택하신 날짜에 근무이력이 없습니다.", "근무이력", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //작업자별
        {
            dt = whcuservice.PickerWorkHistory_UserMaster_UserID(aDateTimePickerSearch2.ADateTimePickerValue1.ToShortDateString().Replace("-", ""), aDateTimePickerSearch2.ADateTimePickerValue2.ToShortDateString().Replace("-", ""),aTextBox_FindNameByCode1.txtCodeText); 
            dgvMainGrid.DataSource = dt;
        }
    }
}
