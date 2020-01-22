using Axxen.sangyoung;
using Axxen.Util;
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
//체크박스 클릭 작업지시목록처리하기..
namespace Axxen
{
    public partial class PPS_SCH_001 : Axxen.GridGridForm
    {
        List<Wo_Req_ItemVO> reqList;
        List<WorkOrder_J_WC_ItmeVO> workList;
        Wo_ReqService service = new Wo_ReqService();
        bool bFlag = false;

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

            dgvMainGrid.CellContentClick += DgvMainGrid_CellContentClick;
            //dgvMainGrid.CellDoubleClick += DgvMainGrid_CellContentClick;

            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
        }

        private void InsertFormShow(object sender, EventArgs e)
        {
            PPS_SCH_001_Insert frm = new PPS_SCH_001_Insert();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            reqList = service.GetAllWoReq();
            dgvMainGrid.DataSource = reqList;
        }

        private void DgvMainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString());
            MessageBox.Show("Test");
            if (Convert.ToInt32(e.RowIndex) < 0)
            {
                return;
            }
            //Check_Wo_Req(dgvMainGrid.Rows[e.RowIndex].Cells[2].Value.ToString(), e.ColumnIndex, (bool)dgvMainGrid.CurrentRow.Cells[0].Value);
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰순번", "Req_Seq", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰번호", "Wo_Req_No", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 80, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "의뢰수량", "Req_Qty", true, 90, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산완료예정일", "Prd_Plan_Date", true, 90, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "프로젝트명", "Project_Name", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "거래처명", "Cust_Name", true, 90, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "영업담당", "Sale_Emp", true, 90, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰상태", "Req_Status", true, 110, default, true);

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "선택";
            chk.Name = "check";
            chk.FalseValue = "false";
            chk.Width = 50;

            dgvMainGrid.Columns.Insert(0, chk);
            GridCheckSetting();
        }


        private void SubDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvSubGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "순번", "Num", false, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "순번", "Wc_Code", false, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산의뢰순번", "Req_Seq", true, 120, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산의뢰번호", "Wo_Req_No", true, 120, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지시상태", "Wo_Status", true, 120, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지시번호", "Workorderno", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산일자", "Prd_Date", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "품목코드", "Item_Code", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "품목명", "Item_Name", true, 120, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업장명", "Wc_Name", true, 120, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "계획수량", "Plan_Qty", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "투입수량", "In_Qty_Main", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "산출수량", "Out_Qty_Main", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산수량", "Prd_Qty", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "비고", "Remark", true, 110, default, true);
        }

        private void BtnPrFinish_Click(object sender, EventArgs e)
        {
            bool result = false;
            string woNo = dgvMainGrid[2, dgvMainGrid.CurrentRow.Index].Value.ToString();
            result = service.UpdateWoReq(woNo);
            if (result)
                MessageBox.Show("의뢰가 마감되었습니다.", "생산의뢰관리", MessageBoxButtons.OK);
            else
                MessageBox.Show("의뢰가 마감되지 않았습니다.", "생산의뢰관리", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                reqList = (from data in reqList
                           where data.Wo_Req_No == txtPrNum.TextBoxText
                           select data).ToList();
                txtPrNum.TextBoxText = "";
            }
            else if (txtProjectName.TextBoxText.Length > 0 && txtPrNum.TextBoxText.Length <= 0)
            {
                reqList = (from data in reqList
                           where data.Wo_Req_No.Contains(txtProjectName.TextBoxText.ToString().Trim())
                           select data).ToList();
                txtProjectName.TextBoxText = "";
            }
            else
            {
                txtProjectName.TextBoxText = "";
                txtPrNum.TextBoxText = "";
                MessageBox.Show("검색조건을 입력해 주세요.");
            }
            dgvMainGrid.DataSource = reqList;
        }

        /// <summary>
        /// 그리드 뷰 체크박스 선택시 해당 의뢰의 작업지시 표시
        /// </summary>
        /// <param name="workorder">생산의뢰품목코드</param>
        /// <param name="colindex">체크박스선택</param>
        private void Check_Wo_Req(string reqno, int colindex, bool check)
        {
            if (colindex == dgvMainGrid.Columns["check"].Index)
            {
                //var list = (from work in workList
                //            where work.Wo_Req_No.Contains(reqno)
                //            select work).ToList();
                workList = (from work in workList
                            where work.Wo_Req_No.Contains(reqno)
                            select work).ToList();
                if (check)
                {
                    List<WorkOrder_J_WC_ItmeVO> list = new List<WorkOrder_J_WC_ItmeVO>();
                    foreach (var item in workList)
                    {
                        list.Add(item);
                    }
                    dgvSubGrid.DataSource = list;
                    //foreach (var item in list)
                    //{
                    //    dgvSubGrid.Rows.Add(null, null, item.Req_Seq, item.Wo_Req_No, item.Wo_Status, item.Workorderno, item.Prd_Date, item.Item_Code, item.Item_Name, item.Wc_Name,
                    //        item.Plan_Qty, item.In_Qty_Main, item.Out_Qty_Main, item.Prd_Qty, item.Remark);
                    //}
                }
                else
                {
                    var item = workList.FirstOrDefault(x => x.Wo_Req_No.Contains(reqno));
                    workList.Remove(item);
                    dgvSubGrid.DataSource = null;
                    dgvSubGrid.DataSource = workList;
                }
            }
        }

        //private void UnCheck_Wo_Req(string reqno, int colindex)
        //{
        //    if (colindex == dgvMainGrid.Columns["check"].Index)
        //    {
        //        var list = (from work in workList
        //                    where work.Wo_Req_No.Contains(reqno)
        //                    select work).ToList();

        //        foreach (var item in list)
        //        {
        //            //dgvSubGrid.Rows.Remove();
        //        }
        //    }
        //}

        private void GridCheckSetting()
        {
            for (int i = 0; i < dgvMainGrid.RowCount; i++)
            {
                dgvMainGrid.Rows[i].Cells[0].Value = true;
            }
        }

        private void PPS_SCH_001_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);
        }
    }
}
