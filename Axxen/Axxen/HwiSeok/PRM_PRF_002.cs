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
    public partial class PRM_PRF_002 : Axxen.GridGridForm
    {

        List<WorkOrder_J_WC_ItmeVO> wowc;
        List<Goods_In_History_J_Pallet_BoxingVO> ghpb;
        
        WorkOrder_Service woservice = new WorkOrder_Service();
        public PRM_PRF_002()
        {
            InitializeComponent();
        }  

        private void PRM_PRF_002_Load(object sender, EventArgs e) // 메인 그리드뷰
        {
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//수정 이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            dgvMainGrid.CellDoubleClick += DgvMainGrid_CellDoubleClick;
            dgvSubGrid.CellDoubleClick += DgvSubGrid_CellDoubleClick;

            #region 메인그리드뷰
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일자", "Prd_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시상태", "Wo_Status", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "투입수량", "In_Qty_Main", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "산출수량", "Out_Qty_Main", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산수량", "Prd_Qty", true, 100, default, true);
            #endregion

            #region 서브그리드뷰
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "팔렛트번호", "Pallet_No", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "등급", "Boxing_Grade_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "등급상세 코드", "Grade_Detail_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "등급상세 명", "Grade_Detail_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "수량", "In_Qty", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "ERP 업로드 여부", "Upload_Flag", true, 100, default, true);
            #endregion

            DataLoad(); // 그리드뷰
        }

        private void DgvSubGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //서브 그리드뷰 클릭 등급상세 수정
        {
            UPDATE_Grade_Detail_Name();
        }

        public void MyUpdateShow(object sender, EventArgs e) //등급상세 수정
        {
            UPDATE_Grade_Detail_Name();
        }

        public void RefreshFormShow(object sender, EventArgs e) // 새로고침 // 초기화
        {
            aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
            aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            DataLoad();
        }

        private void UPDATE_Grade_Detail_Name() //수정이랑 모든 데이터 가지고 오는소스
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    PRM_PRF_002_1 frm = new PRM_PRF_002_1();
                    frm.Ghpb= ghpb.FindAll(item => item.Pallet_No == dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString() && item.Grade_Detail_Code == dgvMainGrid.SelectedRows[0].Cells[2].Value.ToString());
                    
                    frm.ShowDialog();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void DataLoad() //전체 데이터
        {
            wowc = woservice.GetAll_WorkOrder_Item_WC();
            dgvMainGrid.DataSource = wowc;
        }

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //서브 그리드뷰
        {
            ghpb = woservice.GetGoodsIH_PalletM_Boxing((dgvMainGrid.SelectedRows[0].Cells[2].Value).ToString());
            dgvSubGrid.DataSource = ghpb;
        }

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) //날짜별로 조회
        {
            wowc = woservice.GetDatePicker_WorkOrder_Item_WC(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = wowc;
        }
    }
}
