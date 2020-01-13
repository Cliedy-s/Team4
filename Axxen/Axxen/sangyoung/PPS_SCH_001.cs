using Axxen.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Axxen
{
    public partial class PPS_SCH_001 : Axxen.GridGridForm
    {
        public PPS_SCH_001()
        {
            InitializeComponent();
        }

        private void PPS_SCH_001_Load(object sender, EventArgs e)
        {
            MainDataLoad();
        }

        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰번호", "Wo_Req_No", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "의뢰순번", "Req_Req", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "의뢰수량", "Req_Qty", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산완료예정일", "Prd_Plan_Date", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "프로젝트명", "Project_Name", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "거래처명", "Cust_Name", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "영업담당", "Sale_Emp", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰상태", "Req_Status", true, 100);

            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생선된작업지시수", "Last_Setup_Time", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시생산수량", "Use_YN", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시계획수량", "Remark", true, 160);
        }

        private void SubDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰번호", "Wo_Req_No", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "의뢰순번", "Req_Req", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "의뢰수량", "Req_Qty", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산완료예정일", "Prd_Plan_Date", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "프로젝트명", "Project_Name", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "거래처명", "Cust_Name", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "영업담당", "Sale_Emp", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산의뢰상태", "Req_Status", true, 100);

            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생선된작업지시수", "Last_Setup_Time", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시생산수량", "Use_YN", true, 80);
        }
    }
}
