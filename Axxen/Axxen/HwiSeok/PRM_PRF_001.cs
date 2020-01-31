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

            dgvMainGrid.CellDoubleClick += DgvMainGrid_CellDoubleClick;

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

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //그리드뷰 더블클릭 이벤트
        {
            UPDATE_Prd_Qtys();
        }
        public void MyUpdateShow(object sender, EventArgs e) //생산 수량 수정
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    UPDATE_Prd_Qtys();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }    
        }

        public void RefreshFormShow(object sender, EventArgs e) // 새로고침 // 초기화
        {       
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    aTextBox_FindNameByCode1.txtCodeText = "";
                    aTextBox_FindNameByCode1.txtNameText = "";
                    aTextBox_FindNameByCode2.txtCodeText = "";
                    aTextBox_FindNameByCode2.txtNameText = "";

                    DataLoad();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void DataLoad() //전체 데이터 그리드뷰 불러오기
        {      
            wowc = woservice.GetAll_WorkOrder_Item_WC();
            dgvMainGrid.DataSource = null;
            dgvMainGrid.DataSource = wowc;
        }

        private void UPDATE_Prd_Qtys() //수정이랑 모든 데이터 가지고 오는소스
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    PRM_PRF_001_1 frm = new PRM_PRF_001_1();
                    frm.Num = dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString();
                    frm.Prd_Date = dgvMainGrid.SelectedRows[0].Cells[1].Value.ToString();
                    frm.Wo_Status = dgvMainGrid.SelectedRows[0].Cells[2].Value.ToString();
                    frm.Workorderno = dgvMainGrid.SelectedRows[0].Cells[3].Value.ToString();
                    frm.Item_Code = dgvMainGrid.SelectedRows[0].Cells[4].Value.ToString();
                    frm.Item_Name = dgvMainGrid.SelectedRows[0].Cells[5].Value.ToString();
                    frm.Wc_Name = dgvMainGrid.SelectedRows[0].Cells[6].Value.ToString();
                    frm.Process_name = dgvMainGrid.SelectedRows[0].Cells[7].Value.ToString();
                    frm.In_Qty_Main = dgvMainGrid.SelectedRows[0].Cells[8].Value.ToString();
                    frm.Out_Qty_Main = dgvMainGrid.SelectedRows[0].Cells[9].Value.ToString();
                    frm.Prd_Qty = dgvMainGrid.SelectedRows[0].Cells[10].Value.ToString();

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        DataLoad();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//수정 이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침     
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
