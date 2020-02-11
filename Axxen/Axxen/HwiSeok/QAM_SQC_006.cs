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
    public partial class QAM_SQC_006 : Axxen.GridForm
    {
        List<MatLotMaster_ItemLevelMasterVO> mlmilm;
        MatLotMaster_ItemLevelMasterSerivce mlmilmservice = new MatLotMaster_ItemLevelMasterSerivce();
        public QAM_SQC_006()
        {
            InitializeComponent();
        }

        private void QAM_SQC_006_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            #region 그리드뷰
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "생산년도", "YYYY", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "레벨코드", "Level_Code", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "레벨명", "Level_Name", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "차수", "Prd_Order", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "원자재LOT번호", "Mat_LotNo", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            #endregion

            mlmilm = mlmilmservice.GetAllMatLotMaster_ItemLevelMaster(); //전체 조회
            dgvMainGrid.DataSource = mlmilm;
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    mlmilm = mlmilmservice.GetAllMatLotMaster_ItemLevelMaster(); //전체 조회
                    dgvMainGrid.DataSource = mlmilm;
                    aDateTimePicker1.Value = DateTime.Now;                   
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void aButton1_Click(object sender, EventArgs e)
        {
            mlmilm = mlmilmservice.PickerMatLotMaster_ItemLevelMaster(aDateTimePicker1.Text);
            dgvMainGrid.DataSource = mlmilm;
        }
    }
}
