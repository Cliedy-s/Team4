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
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "수량", "Loading_Qty", true, 150, DataGridViewContentAlignment.MiddleCenter);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "요입시각", "In_Time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "요출시각", "Out_Time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "소요시간", "Center_Time", true, 110);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "소요시간", "Center_Time", true, 110);
            dgvGVList.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgvGVList.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
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
        {   // 요입
            GV_Current_StatusService service = new GV_Current_StatusService();
            if (service.UpdateGVIn(GlobalUsage.UserID, dgvGVList.SelectedRows[0].Cells[0].Value.ToString(), GlobalUsage.WorkOrderNo))
            {
                GetDatas();
            }
            else
                MessageBox.Show("요입할 수 없는 대차 입니다.");
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {   // 요출
            GV_Current_StatusService service = new GV_Current_StatusService();
            if (service.UpdateGVOut(GlobalUsage.UserID, dgvGVList.SelectedRows[0].Cells[0].Value.ToString(), GlobalUsage.WorkOrderNo))
            {
                GetDatas();
            }
            else
                MessageBox.Show("요입할 수 없는 대차 입니다.");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            // TODO - 조건에 맞게 변경하기
            //dgvGVFrom.DataSource = service.GetGVCurrentStatus(wccode:GlobalUsage.WcCode, workorderno:GlobalUsage.WorkOrderNo, gvStatus:"적재");
            dgvGVList.DataSource = service.GetGVCurrentStatus(gvStatus: "적재", gvName: txtGVSearch.TextBoxText);
            
        }
    }
}
