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
    public partial class PPS_MLD_002 : Axxen.GridForm
    {
        List<Mold_J_Item_Wc_MuseVO> molditemList;
        List<Mold_J_Item_Wc_MuseVO> moldSearchList;
        MoldService service = new MoldService();

        public PPS_MLD_002()
        {
            InitializeComponent();
        }

        private void PPS_MLD_002_Load(object sender, EventArgs e)
        {
            MainGridLoad();
            molditemList = service.SelectMold_Item_Wc_Muse();
            DataLoad(molditemList);
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            molditemList = service.SelectMold_Item_Wc_Muse();
            DataLoad(molditemList);
            dotItem.txtNameText = "";
            dotItem.txtCodeText = "";
            dotWorkCenter.txtNameText = "";
            dotWorkCenter.txtCodeText = "";

        }//새로고침버튼클릭

        /// <summary>
        /// 데이터 그리드뷰 바인딩
        /// </summary>
        private void MainGridLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업지시번호", "Workorderno", true, 110, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목코드", "Item_Code", true, 85, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "품목명", "Item_Name", true, 85, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "생산일자", "Prd_Date", true, 95, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장코드", "Wc_Code", true, 95, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "작업장이름", "Wc_Name", true, 95, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형코드", "Mold_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형명", "Mold_Name", true, 90, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형타수", "Mold_Shot_Cnt", true, 80, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형생산량", "Mold_Prd_Qty", true, 90, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형사용시작시간", "Use_Starttime", true, 145, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형사용종료시간", "Use_Endtime", true, 145, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "금형사용시간", "Use_time", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
        }

        /// <summary>
        /// 조건 검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ATextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args)
        {
            string iName = dotItem.txtNameText;
            string wName = dotWorkCenter.txtNameText;

            if(iName.Length > 0 && wName.Length <= 0)
            {
                moldSearchList = (from name in molditemList
                                  where name.Item_Name.Contains(iName)
                                  select name).ToList();
            }
            else if(wName.Length > 0 && iName.Length <= 0)
            {
                moldSearchList = (from name in molditemList
                                  where name.Wc_Name.Contains(wName)
                                  select name).ToList();
            }
            else if(wName.Length > 0 && iName.Length > 0)
            {
                moldSearchList = (from name in molditemList
                                  where name.Item_Name.Contains(iName) || name.Wc_Name.Contains(wName)
                                  select name).ToList();

                dotItem.txtNameText = "";
                dotWorkCenter.txtNameText = "";
            }
            DataLoad(moldSearchList);
        }


        /// <summary>
        /// 기간조건검색
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ADateTimePickerSearch1_btnDateTimeSearch_Click(object sender, EventArgs args)
        {
            DateTime startT = aDateTimePickerSearch1.ADateTimePickerValue1;
            DateTime endT = aDateTimePickerSearch1.ADateTimePickerValue2;
            endT = endT.AddDays(10);
            moldSearchList = (from date in molditemList
                            where date.Prd_Date >= startT && date.Prd_Date <= endT
                        select date).ToList();

            DataLoad(moldSearchList);
        }

        /// <summary>
        /// 그리드뷰 데이터 바인딩
        /// </summary>
        /// <param name="molditemList">리스트</param>
        private void DataLoad(List<Mold_J_Item_Wc_MuseVO> molditemList)
        {
            var molist = (from list in molditemList
                          select new
                          {
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
                              Use_time = string.Format("{0}분", list.Use_Endtime.Subtract(list.Use_Starttime).Minutes)
                          }).ToList();
            dgvMainGrid.DataSource = molist;
        }

        private void PPS_MLD_002_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow); //새로고침
        }

        private void PPS_MLD_002_Deactivate(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
        }
    }
}
