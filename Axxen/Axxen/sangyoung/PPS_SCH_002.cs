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

namespace Axxen
{
    public partial class PPS_SCH_002 : Axxen.GridManageForm
    {
        List<Wo_Req_WO_WC_ItemVO> woList = new List<Wo_Req_WO_WC_ItemVO>();
        Wo_ReqService service = new Wo_ReqService();

        public PPS_SCH_002()
        {
            InitializeComponent();
        }

        private void PPS_SCH_002_Load(object sender, EventArgs e)
        {
            MainDataLoad();
            woList = service.GetWoReqOrder();
            dgvMainGrid.DataSource = woList;
            dgvMainGrid.CellDoubleClick += dgvMainGrid_CellDoubleClick;
            aSplitContainer1.Panel2.Enabled = false;
        }

        private void dgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWorkNum.TextBoxText = dgvMainGrid[1, dgvMainGrid.CurrentRow.Index].Value.ToString();
            txtItemCode.TextBoxText = dgvMainGrid[5, dgvMainGrid.CurrentRow.Index].Value.ToString();
            txtItemName.TextBoxText = dgvMainGrid[6, dgvMainGrid.CurrentRow.Index].Value.ToString();
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            woList = service.GetWoReqOrder();
            dgvMainGrid.DataSource = woList;

            aDateTimePickerSearch1.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
            aDateTimePickerSearch1.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dotWorkCenter.txtCodeText = "";
            dotWorkCenter.txtNameText = "";
        }

        private void MyUpdateShow(object sender, EventArgs e)
        {
            aSplitContainer1.Panel2.Enabled = true;
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시상태", "Wo_Status", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획일자", "Plan_Date", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획수량", "Plan_Qty", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획수량단위", "Plan_Unit", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업일자", "Prd_Date", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업시작시간", "Prd_Starttime", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업종료시간", "Prd_Endtime", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "투입수량", "In_Qty_Main", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "산출수량", "Out_Qty_Main", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산수량", "Prd_Qty", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰순번", "Req_Seq", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰번호", "Wo_Req_No", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "프로젝트명", "Project_Name", true, 100);
        }

        private void PPS_SCH_002_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
        }

        private void BtnWoFinish_Click(object sender, EventArgs e)
        {
            string wono = dgvMainGrid[1, dgvMainGrid.CurrentRow.Index].Value.ToString();
            bool result = service.UpdateWoReqOrder(wono);
            if (result)
                MessageBox.Show("작업이 마감되었습니다.","작업지시관리",MessageBoxButtons.OK);
            else
                MessageBox.Show("마감을 할 수 없습니다.", "작업지시관리", MessageBoxButtons.OK,MessageBoxIcon.Error);
            RefreshFormShow(null, null);
        }

        private void BtnWorkCancle_Click(object sender, EventArgs e)
        {
            string wono = dgvMainGrid[1, dgvMainGrid.CurrentRow.Index].Value.ToString();
            bool result = service.CancleWoReqOrder(wono);
            if (result)
                MessageBox.Show("작업이 마감취소되었습니다.", "작업지시관리", MessageBoxButtons.OK);
            else
                MessageBox.Show("취소가 되지 않았습니다.", "작업지시관리", MessageBoxButtons.OK, MessageBoxIcon.Error);
            RefreshFormShow(null, null);
        }

        private void ADateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args)
        {
            DateTime startT = aDateTimePickerSearch1.ADateTimePickerValue1;
            DateTime endT = aDateTimePickerSearch1.ADateTimePickerValue2;
            endT = endT.AddDays(10);
            var wodateList = (from date in woList
                              where date.Prd_Date >= startT && date.Prd_Date <= endT
                              select date).ToList();
            dgvMainGrid.DataSource = wodateList;
        }

        private void ATextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args)
        {
            string pcode = dotProcess.txtCodeText;
            string wName = dotWorkCenter.txtNameText;

            if(wName.Length > 0)
            {
                var colist = (from list in woList
                              where list.Wc_Name.Contains(wName)
                              select list).ToList();
                dgvMainGrid.DataSource = colist;
            }
        }

        private void PPS_SCH_002_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow); //수정이벤트
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow); //새로고침
            ToolStripManager.Merge(toolStrip1, ((MainForm)this.MdiParent).toolStrip1); //저장버튼 추가
        }

        private void PPS_SCH_002_Deactivate(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow); //수정이벤트
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow); //새로고침
            ToolStripManager.RevertMerge(toolStrip1, ((MainForm)this.MdiParent).toolStrip1); //저장버튼 추가
        }

        private void TsbtnSave_Click(object sender, EventArgs e)
        {
            WorkOrderAllVO order = new WorkOrderAllVO();
            order.Workorderno = txtWorkNum.TextBoxText;
            order.Plan_Qty = Convert.ToInt32(numPlanQuantity.Value);
            order.Plan_Unit = txtPlanUnit.Text;
            order.Plan_Date = dtpPlanDate.Value;

           
        }
    }
}
