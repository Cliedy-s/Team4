using Axxen.Util;

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
    public partial class PPS_MLD_002 : Axxen.GridForm
    {
        List<Mold_J_Item_Wc_MuseVO> molditemList;

        //TODO - pps_mld_002 webapi이용
        //MoldService service = new MoldService();

        public PPS_MLD_002()
        {
            InitializeComponent();
        }

        private void PPS_MLD_002_Load(object sender, EventArgs e)
        {
            MainDataLoad();

            //TODO - mms_con_002 webapi이용
            //molditemList = service.SelectMold_Item_Wc_Muse();

            var molist = (from list in molditemList
                        select new {
                            Prd_Date = list.Prd_Date,
                            Mold_Code = list.Mold_Code,
                            Mold_Name = list.Mold_Name,
                            Workorderno = list.Workorderno,
                            Item_Code = list.Item_Code,
                            Item_Name = list.Item_Name,
                            Wc_Code = list.Wc_Code,
                            Wc_Name = list.Wc_Name,
                            Mold_Shot_Cnt = list.Mold_Shot_Cnt,
                            Mold_Prd_Qty = list.Mold_Prd_Qty,
                            Use_Starttime = list.Use_Starttime,
                            Use_Endtime = list.Use_Endtime,
                            Use_time =string.Format("{0}분",list.Use_Endtime.Subtract(list.Use_Starttime).Minutes)}).ToList();
            dgvMainGrid.DataSource = molist;
        }

        /// <summary>
        /// 데이터 그리드뷰 바인딩
        /// </summary>
        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일자", "Prd_Date", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형코드", "Mold_Code", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형명", "Mold_Name", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장코드", "Wc_Code", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장이름", "Wc_Name", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형타수", "Mold_Shot_Cnt", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형생산량", "Mold_Prd_Qty", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형사용시작시간", "Use_Starttime", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형사용종료시간", "Use_Endtime", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형사용시간", "Use_time", true, 110);
        }
    }
}
