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
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "근무일", "Work_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업자", "User_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "근무시작시간", "Work_StartTime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "근무종료시간", "Work_EndTime", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "근무시간", "Work_Time", true, 100, default, true);
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
                MessageBox.Show(err.Message);
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
                        where date.Wc_Name == aTextBox_FindNameByCode1.txtNameText
                        select date).ToList();
            dgvMainGrid.DataSource = whcuList;
        }
    }
}
