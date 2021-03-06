﻿using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using VO;

namespace Axxen
{
    public partial class PRM_PRF_003 : Axxen.GridForm
    {
        List<Item_Goods_HistoryVO> igh;
        List<Item_Goods_HistoryVO> ighList;
        ItemMaster_Service imservice = new ItemMaster_Service();
        public PRM_PRF_003()
        {
            InitializeComponent();
        }

        private void PRM_PRF_003_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침

            DatagridviewDesigns.SetDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "생산일자", "Prd_Date", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "작업지시번호", "Workorderno", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "작업지시상태", "Wo_Status", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "품목코드", "Item_Code", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "품목명", "Item_Name", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "팔레트번호", "Pallet_No", true, 100, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "입고수량", "Plan_Qty", true, 100, DataGridViewContentAlignment.MiddleRight, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "마감시각", "Closed_Time", true, 100, DataGridViewContentAlignment.MiddleCenter, true);

            igh = imservice.GetworkOrder_Item_Goods();
            dgvMainGrid.DataSource = igh;

        }

        private void RefreshFormShow(object sender, EventArgs e) //새로고침
        {          
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    igh = imservice.GetworkOrder_Item_Goods();
                    dgvMainGrid.DataSource = igh;
                    aTextBox_FindNameByCode1.txtCodeText = "";
                    aTextBox_FindNameByCode1.txtNameText = "";
                    aDateTimePickerSearch2.ADateTimePickerValue1 = Convert.ToDateTime(DateTime.Now.AddDays(-7).ToShortDateString());
                    aDateTimePickerSearch2.ADateTimePickerValue2 = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                }
            }
            catch (Exception err)
            {
            
                Program.Log.WriteError(err.Message);
            }
        }

        private void aDateTimePickerSearch2_btnDateTimeSearch_Click(object sender, EventArgs args) // 날짜별 조회
        {
            igh = imservice.GetDatePicker_work_ltem_Goods(aDateTimePickerSearch2.ADateTimePickerValue1.ToShortDateString(), aDateTimePickerSearch2.ADateTimePickerValue2.ToShortDateString());
            dgvMainGrid.DataSource = igh;
            aTextBox_FindNameByCode1.txtCodeText = "";
            aTextBox_FindNameByCode1.txtNameText = "";
        }

        private void aTextBox_FindNameByCode1_DotDotDotFormClosing(object sender, CustomControls.SearchFormClosingArgs args)
        {
            ighList = (from date in igh
                       where date.Item_Code == aTextBox_FindNameByCode1.txtCodeText
                       select date).ToList();
            dgvMainGrid.DataSource = ighList;
        }

        private void PRM_PRF_003_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent -= new System.EventHandler(this.RefreshFormShow); // 새로고침
        }
    }
}
