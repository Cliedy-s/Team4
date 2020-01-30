using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_007 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_007()
        {
            InitializeComponent();
        }

        private void POP_PRD_007_Load(object sender, EventArgs e)
        {
            InitControls();
            TopPanelSet();
            GetDatas();
        }
        private void TopPanelSet()
        {
            txtWorkOrderno.TextBoxText = GlobalUsage.WorkOrderNo;
            txtItemName.TextBoxText = GlobalUsage.ItemName;
            txtQty.TextBoxText = GlobalUsage.Prd_Qty.ToString();
            txtUnit.TextBoxText = GlobalUsage.Prd_Unit.ToString();
            txtWcCode.TextBoxText = GlobalUsage.WoIniChar;
            txtWorkOrderDate.TextBoxText = GlobalUsage.WorkorderDate.ToString();
        }
        private void InitControls()
        {
            //InitControlUtil.SetPOPDGVDesign(dgvGVTo);
            //InitControlUtil.AddNewColumnToDataGridView(dgvGVTo, "대차코드", "GV_Code", true, 110);
            //InitControlUtil.AddNewColumnToDataGridView(dgvGVTo, "대차명", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);

            //InitControlUtil.SetPOPDGVDesign(dgvGVFrom);
            //InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "대차코드", "GV_Code", true, 110);
            //InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "대차명", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            //InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "적재시각", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            //InitControlUtil.AddNewColumnToDataGridView(dgvGVFrom, "수량", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            // 해당 작업지시에서 생성한 모든 대차
            dgvGVFrom.DataSource = service.GetGVCurrentStatusByWorkOrderno(GlobalUsage.WoIniChar, GlobalUsage.WorkOrderNo);
            // 해당 작업장의 모든 빈대차를 가져온다.
            dgvGVTo.DataSource = service.GetGVCurrentStatusByGvStatus(GlobalUsage.WoIniChar, "빈대차"); 
        }
    }
}
