using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;
using System.Linq;

namespace Axxen
{
    public partial class PRM_PRF_002 : Axxen.GridGridForm
    {
        CheckBox headerCheckBox = new CheckBox();
        CheckBox headerCheckBox1 = new CheckBox();
        List<WorkOrder_J_WC_ItmeVO> wowc;
        List<Goods_In_History_J_Pallet_BoxingVO> ghpb;
        List<Goods_In_History_J_Pallet_BoxingVO> ghpbList;

        WorkOrder_Service woservice = new WorkOrder_Service();
        public PRM_PRF_002()
        {
            InitializeComponent();
        }  

        private void PRM_PRF_002_Load(object sender, EventArgs e) // 메인 그리드뷰
        {
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//수정 이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            dgvMainGrid.CellDoubleClick += DgvMainGrid_CellDoubleClick; //메인그리드뷰 더블클릭
            dgvSubGrid.CellDoubleClick += DgvSubGrid_CellDoubleClick; //서브그리드뷰 더블클릭
            dgvMainGrid.CellContentClick += dgvMainGrid_CellContentClick; //체크박스
            dgvSubGrid.CellContentClick += dgvSubGrid_CellContentClick; //체크박스


            #region 메인 그리드뷰 체크박스
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "";
            chk.Name = "chk";
            chk.Width = 30;
            dgvMainGrid.Columns.Add(chk);

            Point headerLocation = dgvMainGrid.GetCellDisplayRectangle(0, -1, true).Location;

            headerCheckBox.Location = new Point(headerLocation.X + 8, headerLocation.Y + 2);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(headerCheckBox_Click);

            dgvMainGrid.Controls.Add(headerCheckBox);
            #endregion

            #region 서브 그리드뷰 체크박스
            DataGridViewCheckBoxColumn chkSub = new DataGridViewCheckBoxColumn();
            chkSub.HeaderText = "";
            chkSub.Name = "Subchk";
            chkSub.Width = 30;
            dgvSubGrid.Columns.Add(chkSub);

            Point headerLocationSub = dgvSubGrid.GetCellDisplayRectangle(0, -1, true).Location;

            headerCheckBox1.Location = new Point(headerLocationSub.X + 8, headerLocationSub.Y + 2);
            headerCheckBox1.BackColor = Color.White;
            headerCheckBox1.Size = new Size(18, 18);
            headerCheckBox1.Click += new EventHandler(SubheaderCheckBox_Click);

            dgvSubGrid.Controls.Add(headerCheckBox1);
            #endregion

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
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "등급", "Grade_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "등급상세 코드", "Grade_Detail_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "등급상세명", "Grade_Detail_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "수량", "In_Qty", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "팔렛트 마감 여부", "Use_YN", true, 100, default, true);
            #endregion

            DataLoad(); // 그리드뷰
        }

        private void dgvMainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) //메인 체크박스
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dgvMainGrid.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["chk"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }

        private void dgvSubGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) //서브 체크박스
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool isChecked = true;
                foreach (DataGridViewRow row in dgvSubGrid.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Subchk"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox1.Checked = isChecked;
            }
        }

        private void headerCheckBox_Click(object sender, EventArgs e) // 메인 체크박스
        {
            dgvMainGrid.EndEdit();

            foreach (DataGridViewRow row in dgvMainGrid.Rows)
            {
                DataGridViewCheckBoxCell chkBox = row.Cells["chk"] as DataGridViewCheckBoxCell;
                chkBox.Value = headerCheckBox.Checked;
            }
        }

        private void SubheaderCheckBox_Click(object sender, EventArgs e) //서브 체크박스
        {
            dgvSubGrid.EndEdit();

            foreach (DataGridViewRow row1 in dgvSubGrid.Rows)
            {
                DataGridViewCheckBoxCell chkBox1 = row1.Cells["Subchk"] as DataGridViewCheckBoxCell;
                chkBox1.Value = headerCheckBox1.Checked;
            }
        }

        private void DgvSubGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //서브 그리드뷰 클릭 등급상세 수정
        {
            if (dgvSubGrid.SelectedRows[0].Cells[6].Value.ToString() == "N")
            {
                UPDATE_Grade_Detail_Name();
            }
        }

        public void MyUpdateShow(object sender, EventArgs e) //등급상세 수정
        {

            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    if (dgvSubGrid.SelectedRows.Count > 0)
                    {
                        if (dgvSubGrid.SelectedRows[0].Cells[6].Value.ToString() == "N")
                        {
                            UPDATE_Grade_Detail_Name();
                        }
                    }
                    else
                    {
                        MessageBox.Show("등급상세명을 수정 할 팔렛트 목록을 클릭해주세요.", "수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

                    DataLoad();

                    ghpb = woservice.GetGoodsIH_PalletM_Boxing((dgvMainGrid.SelectedRows[0].Cells[3].Value).ToString());
                    dgvSubGrid.DataSource = ghpb; ;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void UPDATE_Grade_Detail_Name() //수정이랑 모든 데이터 가지고 오는소스
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    PRM_PRF_002_1 frm = new PRM_PRF_002_1();
                    frm.Workorderno = dgvMainGrid.SelectedRows[0].Cells[3].Value.ToString();
                    frm.Pallet_No = dgvSubGrid.SelectedRows[0].Cells[1].Value.ToString();
                    frm.Grade_Detail_Name = dgvSubGrid.SelectedRows[0].Cells[4].Value.ToString();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ghpb = woservice.GetGoodsIH_PalletM_Boxing((dgvMainGrid.SelectedRows[0].Cells[3].Value).ToString());
                        dgvSubGrid.DataSource = ghpb;
                    }
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
            ghpb = woservice.GetGoodsIH_PalletM_Boxing((dgvMainGrid.SelectedRows[0].Cells[3].Value).ToString());
            dgvSubGrid.DataSource = ghpb;
        }

        private void aDateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args) //날짜별로 조회
        {
            wowc = woservice.GetDatePicker_WorkOrder_Item_WC(aDateTimePickerSearch1.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch1.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = wowc;

            ghpb = woservice.GetGoodsIH_PalletM_Boxing((dgvMainGrid.SelectedRows[0].Cells[3].Value).ToString());
            dgvSubGrid.DataSource = ghpb;

        }

        private void btnPallet_Click(object sender, EventArgs e) //팔렛트 마감
        {
                List<string> chkPalletNo = new List<string>();

                 bool bFlag = false;

                 foreach (DataGridViewRow row in dgvSubGrid.Rows)
                {
                        bool isCellChecked = Convert.ToBoolean(row.Cells["Subchk"].EditedFormattedValue);

                        if (isCellChecked)
                        {
                         bFlag = true;
                         chkPalletNo.Add(row.Cells[1].Value.ToString());
                        }
                    
                }

                if (!bFlag)
                {
                    MessageBox.Show("마감 할 팔렛트 목록을 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                 bool IsSuccess = woservice.UpdatePalletUse(chkPalletNo);

                if (IsSuccess)
                {
                    MessageBox.Show("성공적으로 마감하였습니다.", "팔렛트마감 성공",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ghpb = woservice.GetGoodsIH_PalletM_Boxing((dgvMainGrid.SelectedRows[0].Cells[3].Value).ToString());
                    dgvSubGrid.DataSource = ghpb;
                }
                else
                {
                    MessageBox.Show("선택하신 팔렛트 목록 중에 이미 마감처리된 목록이 있습니다.", "팔렛트마감 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
        }

        private void btnWorkorderno_Click(object sender, EventArgs e) //작업지시 마감
        {       
            List<WorkOrder_J_WC_ItmeVO> chkWorkorderno = new List<WorkOrder_J_WC_ItmeVO>();

            bool bFlag = false;

            foreach (DataGridViewRow row in dgvMainGrid.Rows)
            {
                bool isCellChecked = Convert.ToBoolean(row.Cells["chk"].EditedFormattedValue);

                if (isCellChecked)
                {
                    bFlag = true;

                    WorkOrder_J_WC_ItmeVO list = wowc.Find(item => item.Workorderno == row.Cells[3].Value.ToString());
                    chkWorkorderno.Add(list);
                }            
            }

            if (!bFlag)
            {                
                MessageBox.Show("마감 할 작업지시 목록을 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             string msg = woservice.UpdateWo_Status(chkWorkorderno);

              if (msg=="OK")
              {                  
                 MessageBox.Show("성공적으로 마감하였습니다.", "작업지시마감 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 DataLoad();
              }
              else
              {
                  MessageBox.Show($"{msg}", "작업지시마감 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }                
        }

        private void PRM_PRF_002_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//수정 이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침
        }
    }
}
