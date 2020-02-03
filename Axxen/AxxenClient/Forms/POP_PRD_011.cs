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
    public partial class POP_PRD_011 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_011()
        {
            InitializeComponent();
        }
        private void POP_PRD_011_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvGVList);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "대차코드", "GV_Code", false, 80);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "소성대차", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "적재시각", "Loading_time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "수량", "Loading_Qty", true, 50);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "요입시각", "Loading_Qty", true, 50);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "요출시각", "Loading_Qty", true, 50);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "소요시간", "Loading_Qty", true, 50);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "품목번호", "Item_Code", false, 50);
            dgvGVList.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            // 해당 작업지시에서 생성한 모든 대차
            // TODO - 조건에 맞게 변경하기
            //dgvGVFrom.DataSource = service.GetGVCurrentStatus(wccode:GlobalUsage.WcCode, workorderno:GlobalUsage.WorkOrderNo, gvStatus:"적재");
            dgvGVList.DataSource = service.GetGVCurrentStatus(gvStatus: "적재");
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            //GV_Current_StatusService service = new GV_Current_StatusService();
            //service.UpdateGVIn(GlobalUsage.UserID, );

            //if()
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
