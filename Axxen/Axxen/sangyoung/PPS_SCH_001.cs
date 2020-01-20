using Axxen.Util;
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
    public partial class PPS_SCH_001 : Axxen.GridGridForm
    {
        List<Wo_Req_ItemVO> reqList;
        Wo_ReqService service = new Wo_ReqService();


        public PPS_SCH_001()
        {
            InitializeComponent();
        }

        private void PPS_SCH_001_Load(object sender, EventArgs e)
        {
            MainDataLoad();
            SubDataLoad();
            reqList = service.GetAllWoReq();
            dgvMainGrid.DataSource = reqList;
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
        }

        private void SubDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvSubGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지시상태", "Wo_Status", true, 120);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업지시번호", "Workorderno", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산일자", "Prd_Date", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "품목코드", "Item_Code", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "품목명", "Item_Name", true, 120);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "작업장명", "Wc_Name", true, 120);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "계획수량", "Plan_Qty", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "투입수량", "In_Qty_Main", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "산출수량", "Out_Qty_Main", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "생산수량", "Prd_Qty", true, 110);

            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSubGrid, "비고", "Remark", true, 110,default, true);
        }
    }
}
