﻿using Axxen.CustomControls;
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
            dgvGVList.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgvGVList.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgvGVList.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            // 해당 작업지시에서 생성한 모든 대차
            dgvGVList.DataSource = service.GetGVCurrentStatus(workorderno:GlobalUsage.WorkOrderNo, gvStatus: "적재");
        }
        private void btnInput_Click(object sender, EventArgs e)
        {   // 요입
            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if(dgvGVList.SelectedRows.Count > 0)
                {
                    GV_Current_StatusService service = new GV_Current_StatusService();
                    if (service.UpdateGVIn(GlobalUsage.UserID, dgvGVList.SelectedRows[0].Cells[0].Value.ToString(), GlobalUsage.WorkOrderNo))
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업지시({GlobalUsage.WorkOrderNo})에서 대차({dgvGVList.SelectedRows[0].Cells[0].Value.ToString()}) 요입에 성공하였음");
                        GetDatas();
                    }
                    else
                    {
                        Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업지시({GlobalUsage.WorkOrderNo})에서 대차({dgvGVList.SelectedRows[0].Cells[0].Value.ToString()}) 요입에 실패하였음");
                        MessageBox.Show("요입할 수 없는 대차 입니다.");
                    }
                }
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업시작을 하지않고 대차 요입을 하려하였음");
                MessageBox.Show("작업을 시작해주세요");
            }
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {   // 요출

            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                GV_Current_StatusService service = new GV_Current_StatusService();
                if (service.UpdateGVOut(GlobalUsage.UserID, dgvGVList.SelectedRows[0].Cells[0].Value.ToString(), GlobalUsage.WorkOrderNo))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업지시({GlobalUsage.WorkOrderNo})에서 대차({dgvGVList.SelectedRows[0].Cells[0].Value.ToString()}) 요출에 성공하였음");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업지시({GlobalUsage.WorkOrderNo})에서 대차({dgvGVList.SelectedRows[0].Cells[0].Value.ToString()}) 요출에 실패하였음");
                    MessageBox.Show("요출할 수 없는 대차 입니다.");
                }
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업시작을 하지않고 대차 요출을 하려하였음");
                MessageBox.Show("작업을 시작해주세요");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            dgvGVList.DataSource = service.GetGVCurrentStatus(workorderno: GlobalUsage.WorkOrderNo, gvStatus: "적재", gvName: txtGVSearch.TextBoxText);

        }
    }
}
