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
    public partial class PPS_MLD_001 : Axxen.GridManageForm
    {
        List<MoldVO> moldList;
        MoldService service = new MoldService();
        public PPS_MLD_001()
        {
            InitializeComponent();
        }

        private void PPS_MLD_001_Load(object sender, EventArgs e)
        {
            DataLoad();
            moldList = service.GetAllMold();
            dgvMainGrid.DataSource = moldList;
        }

        /// <summary>
        /// 데이터 그리드뷰 바인딩
        /// </summary>
        private void DataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형코드", "Mold_Code", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형명", "Mold_Name", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형그룹", "Mold_Group", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형상태", "Mold_Status", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적타수", "Cum_Shot_Cnt", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적생산량", "Cum_Prd_Qty", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적사용시간", "Cum_Time", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "보장타수", "Guar_Shot_Cnt", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "구입금액", "Purchase_Amt", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "입고일자", "In_Date", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "최종장착일시", "Last_Setup_Time", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "장착작업장코드", "Wc_Code", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "사용여부", "Use_YN", true, 60);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비고", "Remark", true, 60);
        }
    }
}
