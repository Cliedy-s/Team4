using Axxen.HwiSeok;
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
    public partial class PRM_PRF_001 : Axxen.GridForm
    {
        List<WorkOrder_J_WC_ItmeVO> wowc;
        List<WorkOrder_J_WC_ItmeVO> reqdateList;
        WorkOrder_Service woservice = new WorkOrder_Service();
        bool check = false;
        public PRM_PRF_001()
        {
            InitializeComponent();
        }

        private void PRM_PRF_001_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//수정 이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            #region 그리드뷰 설정
            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "번호", "Num", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시일자", "Prd_Date", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시상태", "Wo_Status", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장", "Wc_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "공정명", "Process_name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "투입수량", "In_Qty_Main", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "산출수량", "Out_Qty_Main", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산수량", "Prd_Qty", true, 100, default, true);
            #endregion

            DataLoad(); //메인 초기화
        }

        /// <summary>
        /// 입력 이벤트 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MyUpdateShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    PRM_PRF_001_1 frm = new PRM_PRF_001_1();
                    frm.ShowDialog();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        public void RefreshFormShow(object sender, EventArgs e) // 새로고침 // 초기화
        {
            aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
            aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            aTextBox_FindNameByCode1.txtCodeText = "";
            aTextBox_FindNameByCode1.txtNameText = "";
            aTextBox_FindNameByCode2.txtCodeText = "";
            aTextBox_FindNameByCode2.txtNameText = "";

            DataLoad();         
        }

        private void DataLoad() // 그리드뷰 불러오기
        {      
            wowc = woservice.GetAll_WorkOrder_Item_WC();
            dgvMainGrid.DataSource = null;
            dgvMainGrid.DataSource = wowc;
        }

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) // 날짜별 조회
        {
            aTextBox_FindNameByCode1.txtCodeText = "";
            aTextBox_FindNameByCode1.txtNameText = "";
            aTextBox_FindNameByCode2.txtCodeText = "";
            aTextBox_FindNameByCode2.txtNameText = "";

            wowc = woservice.GetDatePicker_WorkOrder_Item_WC(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(),aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = wowc;         
        }

        private void PRM_PRF_001_FormClosing(object sender, FormClosingEventArgs e) //이벤트 종료
        {
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.MyUpdateShow); //수정 이벤트 등록         
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) //공정별 검색
        {
            reqdateList = (from date in wowc
                               where date.Process_name == aTextBox_FindNameByCode1.txtNameText
                               select date).ToList();
            dgvMainGrid.DataSource = reqdateList;

            aTextBox_FindNameByCode2.txtCodeText = "";
            aTextBox_FindNameByCode2.txtNameText = "";
        }

        private void aTextBox_FindNameByCode2_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args) // 작업장별 검색
        {
            if (aTextBox_FindNameByCode1.txtCodeText == "")
            {
                    reqdateList = (from date in wowc
                                   where date.Wc_Name == aTextBox_FindNameByCode2.txtNameText
                                   select date).ToList();
                    dgvMainGrid.DataSource = reqdateList;            
            }
            else
            {
                    var reqdateList1 = (from date in reqdateList
                                        where date.Wc_Name == aTextBox_FindNameByCode2.txtNameText
                                        select date).ToList();
                    dgvMainGrid.DataSource = reqdateList1;
            }
        }
    }
}
