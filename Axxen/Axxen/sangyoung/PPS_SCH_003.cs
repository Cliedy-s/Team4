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
using System.Windows.Forms.DataVisualization.Charting;
using VO;

namespace Axxen
{
    public partial class PPS_SCH_003 : Axxen.FreeForm
    {
        List<WO_WC_Production_ItemVO> wowclist;
        List<WorkOrderVO> statuslist;
        Wo_ReqService service = new Wo_ReqService();
        WorkOrder_Service woservice = new WorkOrder_Service();

        public PPS_SCH_003()
        {
            InitializeComponent();
        }

        private void PPS_SCH_003_Load(object sender, EventArgs e)
        {
            MainDataLoad();
            ComboBinding();
            wowclist = service.GetWO_WC_Production_Items();
            dgvMainGrid.DataSource = wowclist;
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            wowclist = service.GetWO_WC_Production_Items();
            dgvMainGrid.DataSource = wowclist;
            cboStatus.SelectedIndex = 0;
            chartDate.Series.Clear();
        }

        private void ComboBinding()
        {
            statuslist = service.GetWoStatus();

            cboStatus.Items.Add("==선택==");
            foreach (var item in statuslist)
            {
                cboStatus.Items.Add(item.Wo_Status);
            }
            cboStatus.SelectedIndex = 0;
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시상태", "Wo_Status", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획일자", "Plan_Date", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획수량", "Plan_Qty", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "계획수량단위", "Plan_Unit", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 90, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장명", "Wc_Name", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일자", "Prd_Date", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산시작시간", "Prd_Starttime", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산종료시간", "Prd_Endtime", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "투입수량", "In_Qty_Main", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "산출수량", "Out_Qty_Main", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산수량", "Prd_Qty", true, 100);
        }

        /// <summary>
        /// 선택한 조건의 일자별 차트 그리기
        /// </summary>
        private void DateChartLoad()
        {
            chartDate.Series.Clear();
            chartDate.Series.Add("생산량");
            chartDate.Series["생산량"].ChartType = SeriesChartType.Column;
            chartDate.Series["생산량"].IsValueShownAsLabel = true;
            //foreach (var item in wowclist)
            //{

            //    chartDate.Series.Add(item.Item_Name);

            //    if(chartDate.Series.FindByName(item.Item_Name))
            //    {
            //        chartDate.Series[item.Item_Name].Points.AddXY(item.Prd_Date.ToString().Substring(0, 10), item.Prd_Qty);
            //    }
            //    else
            //    {
            //        chartDate.Series.Add(item.Item_Name);
            //        chartDate.Series[item.Item_Name].Points.AddXY(item.Prd_Date.ToString().Substring(0, 10), item.Prd_Qty);
            //    }
            //}
            foreach (var item in wowclist)
            {
                chartDate.Series["생산량"].Points.AddXY(item.Prd_Date.ToString().Substring(0, 10), item.Prd_Qty);
            }

            chartDate.Legends.Clear();
            chartDate.ChartAreas[0].AxisX.MajorGrid.Enabled = false;// 그래프선 보이기 안보이기
            chartDate.Titles.Add("생산 일자별 생산량");
        }

        private void ADateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args)
        {
            DateTime startT = aDateTimePickerSearch1.ADateTimePickerValue1;
            DateTime endT = aDateTimePickerSearch1.ADateTimePickerValue2;
            wowclist = (from date in wowclist
                                where date.Prd_Date >= startT && date.Prd_Date <= endT
                                select date).ToList();
            dgvMainGrid.DataSource = wowclist;
            DateChartLoad();
        }

        private void CboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStatus.SelectedIndex == 0)
            {
                RefreshFormShow(null, null);
            }
            else
            {
                var wostatuslist = (from status in wowclist
                                    where status.Wo_Status.Contains(cboStatus.SelectedItem.ToString())
                                    select status).ToList();
                dgvMainGrid.DataSource = wostatuslist;
            }
        }

        private void PPS_SCH_003_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
        }

        private void DotWorkCenter_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args)
        {
            string wName = dotWorkCenter.txtNameText;
            if(wName.Length > 0)
            {
                var wlist = (from list in wowclist
                             where list.Wc_Name.Contains(wName)
                             select list).ToList();
                dgvMainGrid.DataSource = wlist;
            }
        }

        private void PPS_SCH_003_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow); //새로고침
        }

        private void PPS_SCH_003_Deactivate(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
        }

        private void DgvMainGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string wono = dgvMainGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            List<WO_WC_Time_ItemVO> list = woservice.GetTimeWork(wono);

            //시간대별 차트그리기

        }
    }
}
