using Axxen.sangyoung;
using Axxen.Util;
using DevExpress.XtraReports.UI;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Axxen
{
    public partial class PPS_SCH_001 : Axxen.GridGridForm
    {
        List<Wo_Req_ItemVO> reqList;
        List<Wo_Req_ItemVO> reqSearchList;
        List<Wo_Req_ItemVO> reportList = new List<Wo_Req_ItemVO>();
        List<WorkOrder_WC_ItemVO> workList;
        List<WorkOrder_WC_ItemVO> addlist = new List<WorkOrder_WC_ItemVO>();
        Wo_ReqService service = new Wo_ReqService();
        WorkOrder_Service workservice = new WorkOrder_Service();
        PPS_SCH_001_Insert frm;
        bool cFlag = false;

        public PPS_SCH_001()
        {
            InitializeComponent();
        }

        private void PPS_SCH_001_Load(object sender, EventArgs e)
        {
            MainDataLoad();
            SubDataLoad();

            reqList = service.GetAllWoReq();
            workList = service.GetWorkOrder();
            dgvMainGrid.DataSource = reqList;

            btnPrFinish.Focus();
            dgvMainGrid.CellContentClick += DgvMainGrid_CellContentClick;
        }

        private void InsertFormShow(object sender, EventArgs e)
        {
            Wo_Req_ItemVO woitem = new Wo_Req_ItemVO();
            woitem.Req_Seq = Convert.ToInt32(dgvMainGrid[1, dgvMainGrid.CurrentRow.Index].Value);
            woitem.Wo_Req_No = dgvMainGrid[2, dgvMainGrid.CurrentRow.Index].Value.ToString();
            woitem.Item_Code = dgvMainGrid[4, dgvMainGrid.CurrentRow.Index].Value.ToString();
            woitem.Item_Name = dgvMainGrid[5, dgvMainGrid.CurrentRow.Index].Value.ToString();
            woitem.Req_Qty = Convert.ToInt32(dgvMainGrid[6, dgvMainGrid.CurrentRow.Index].Value);

            frm = new PPS_SCH_001_Insert(woitem.Req_Seq, woitem.Wo_Req_No, woitem.Item_Code, woitem.Item_Name, woitem.Req_Qty);
            frm.StartPosition = FormStartPosition.CenterScreen;
            cFlag = true;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                RefreshFormShow(null, null);
            }
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            reqList = service.GetAllWoReq();
            workList = service.GetWorkOrder();
            dgvMainGrid.DataSource = reqList;
        }

        private void DgvMainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool result = false;

            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                result = Convert.ToBoolean(dgvMainGrid.Rows[e.RowIndex].Cells[0].Value);
                dgvMainGrid.Rows[e.RowIndex].Cells[0].Value = !result;
                dgvMainGrid.EndEdit();
                Check_Wo_Req(dgvMainGrid.Rows[e.RowIndex].Cells[2].Value.ToString(), e.ColumnIndex, Convert.ToBoolean(dgvMainGrid.CurrentRow.Cells[0].Value));
            }
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "No.", "Req_Seq", true, 60, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰번호", "Wo_Req_No", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "의뢰일자", "Ins_Date", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "품목명", "Item_Name", true, 80, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "의뢰수량", "Req_Qty", true, 90, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "프로젝트명", "Project_Name", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "거래처명", "Cust_Name", true, 90, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "영업담당", "Sale_Emp", true, 90, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰상태", "Req_Status", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "생산완료예정일", "Prd_Plan_Date", true, 90, DataGridViewContentAlignment.MiddleCenter, true);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "선택";
            chk.Name = "check";
            chk.TrueValue = true;
            chk.FalseValue = false;
            chk.Width = 50;
            dgvMainGrid.Columns.Insert(0, chk);


        }

        private void SubDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvSubGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "No.", "Req_Seq", true, 60, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산의뢰번호", "Wo_Req_No", true, 120, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지시상태", "Wo_Status", true, 120, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지시번호", "Workorderno", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지시일자", "Prd_Date", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "품목코드", "Item_Code", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "품목명", "Item_Name", true, 120, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업장명", "Wc_Name", true, 120, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "계획수량", "Plan_Qty", true, 60, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "투입수량", "In_Qty_Main", true, 60, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "산출수량", "Out_Qty_Main", true, 60, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산수량", "Prd_Qty", true, 60, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvSubGrid, "비고", "Remark", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
        }

        private void BtnPrFinish_Click(object sender, EventArgs e)
        {
            bool result = false;
            string woNo = string.Empty;

            foreach (DataGridViewRow row in dgvMainGrid.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (Convert.ToBoolean(chk.Value))
                {
                    woNo = row.Cells[2].Value.ToString();
                    result = service.UpdateWoReq(woNo);
                }
                else
                {
                    continue;
                }
            }
            if (result)
                MessageBox.Show("의뢰가 마감되었습니다.", "작업지시관리", MessageBoxButtons.OK);
            else
                MessageBox.Show("의뢰가 마감되지 않았습니다.\n마감할 의뢰를 선택해 주세요.", "작업지시관리", MessageBoxButtons.OK, MessageBoxIcon.Error);

            RefreshFormShow(null, null);

        }

        /// <summary>
        /// 텍스트 입력 검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">키입력값</param>
        private void Text_TextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchList();
            }
        }

        /// <summary>
        /// 검색 조건 출력
        /// </summary>
        private void SearchList()
        {
            if (txtPrNum.TextBoxText.Length > 0 && txtProjectName.TextBoxText.Length <= 0)
            {
                reqSearchList = (from data in reqList
                                 where data.Wo_Req_No.Contains(txtPrNum.TextBoxText.Trim())
                                 select data).ToList();
                txtPrNum.TextBoxText = "";
            }
            else if (txtProjectName.TextBoxText.Length > 0 && txtPrNum.TextBoxText.Length <= 0)
            {
                reqSearchList = (from data in reqList
                                 where data.Wo_Req_No.Contains(txtProjectName.TextBoxText.Trim())
                                 select data).ToList();
                txtProjectName.TextBoxText = "";
            }
            else if (txtProjectName.TextBoxText.Length > 0 && txtPrNum.TextBoxText.Length > 0)
            {
                reqSearchList = (from data in reqList
                                 where data.Wo_Req_No.Contains(txtProjectName.TextBoxText.Trim()) || data.Wo_Req_No.Contains(txtPrNum.TextBoxText.Trim())
                                 select data).ToList();
                txtProjectName.TextBoxText = "";
                txtPrNum.TextBoxText = "";
            }
            else
            {
                MessageBox.Show("검색조건을 입력해 주세요.");
            }
            dgvMainGrid.DataSource = reqSearchList;
        }

        /// <summary>
        /// 그리드 뷰 체크박스 선택시 해당 의뢰의 작업지시 표시
        /// </summary>
        /// <param name="workorder">생산의뢰품목코드</param>
        /// <param name="colindex">체크박스선택</param>
        private void Check_Wo_Req(string reqno, int colindex, bool check)
        {
            var list = (from work in workList
                        where work.Wo_Req_No.Contains(reqno)
                        select work).ToList();
            if (check)
            {
                foreach (var item in list)
                {
                    addlist.Add(item);
                }
                dgvSubGrid.DataSource = null;
                dgvSubGrid.DataSource = addlist;
            }
            else
            {
                addlist.RemoveAll(x => x.Wo_Req_No.Contains(reqno));
                dgvSubGrid.DataSource = null;
                dgvSubGrid.DataSource = addlist;
            }
        }

        private void ADateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args)
        {
            DateTime startT = aDateTimePickerSearch1.ADateTimePickerValue1;
            DateTime endT = aDateTimePickerSearch1.ADateTimePickerValue2;
            var reqdateList = (from date in reqList
                               where date.Ins_Date >= startT && date.Ins_Date <= endT
                               select date).ToList();
            dgvMainGrid.DataSource = reqdateList;
        }

        private void BtnPrDown_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            DataTable dt = new DataTable();

            List<Wo_Req_ItemVO> list = dgvMainGrid.DataSource as List<Wo_Req_ItemVO>;
            for (int i = 0; i < list.Count; i++)
            {
                if (dgvMainGrid.Rows[i].Cells[0] is DataGridViewCheckBoxCell chk)
                {
                  
                    if (Convert.ToBoolean(chk.Value))
                    {
                        bFlag = true;
                        reportList.Add(list[i]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            dt = ListToDataTable.ToDataTable(reportList);
            ProductionRequest rpt = new ProductionRequest();
            rpt.DataSource = dt;
            if(bFlag)
            {
                PPS_SCH_001_Report frm = new PPS_SCH_001_Report(dt);
                frm.documentViewer1.DocumentSource = null;
                frm.documentViewer1.DocumentSource = rpt;
                frm.MdiParent = MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();

                TabPage newTab = new TabPage();
                newTab.Tag = frm.Name;
                newTab.Text = "생산의뢰목록";
                frm.Tag = frm.Name;
                ((MainForm)this.MdiParent).tabControl2.TabPages.Add(newTab);
            }
            else
            {
                MessageBox.Show("목록을 선택해 주세요.","작업지시관리",MessageBoxButtons.OK);
            }
        }

        private void PPS_SCH_001_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow); //추가
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow); //새로고침
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.DeleteFormShow); //삭제

            dgvMainGrid.ClearSelection();
            dgvSubGrid.ClearSelection();
            btnPrFinish.Focus();
        }

       
        private void PPS_SCH_001_Deactivate(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.DeleteFormShow); 
            reportList.Clear();
        }

        private void DeleteFormShow(object sender, EventArgs e)
        {
            if(dgvMainGrid.Focused)
            {
                string woreqno = dgvMainGrid[2, dgvMainGrid.CurrentRow.Index].Value.ToString();
                bool result = workservice.DeletePPSWoReq(woreqno);
                if(result)
                {
                    MessageBox.Show("생산의뢰가 삭제되었습니다.","작업지시관리");
                    dgvSubGrid.DataSource = null;
                }
                else
                    MessageBox.Show("생산의뢰가 삭제되지 않았습니다.","작업지시관리",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(dgvSubGrid.Focused)
            {
                string workno = dgvSubGrid[3, dgvSubGrid.CurrentRow.Index].Value.ToString();
                bool result = workservice.DeletePPSWorkorder(workno);
                if(result)
                    MessageBox.Show("작업지시가 삭제되었습니다.", "작업지시관리", MessageBoxButtons.OK);
                else
                    MessageBox.Show("작업지시가 삭제되지 않았습니다.", "작업지시관리", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택해 주세요.","작업지시관리",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
