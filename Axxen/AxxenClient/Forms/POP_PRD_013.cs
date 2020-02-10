using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_013 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_013()
        {
            InitializeComponent();
        }
        private void POP_PRD_013_Load(object sender, EventArgs e)
        {
            InitControls();
            txtWc.TextBoxText = GlobalUsage.WcCode;
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvAllocatedWorker);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatedWorker, "작업자", "User_Name", true, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatedWorker, "할당시각", "Allocation_datetime", true, 200, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatedWorker, "ID", "User_ID", true, 80);
            dgvAllocatedWorker.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            InitControlUtil.SetPOPDGVDesign(dgvAllocatableWorker);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatableWorker, "작업자", "User_Name", true, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatableWorker, "현재 작업장", "NOWWC", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatableWorker, "ID", "User_ID", false, 80);
        }
        private void GetDatas()
        {   // 작업장에 할당된 작업자 목록 가져오기
            Emp_Wc_AllocationService service = new Emp_Wc_AllocationService();
            List<WorkerVO> list = service.GetAllocatedWorker(GlobalUsage.WcCode);
            // 할당된 작업자
            dgvAllocatedWorker.DataSource = list;
            // 할당대상 작업자
            dgvAllocatableWorker.DataSource = service.GetAllocatableWorker(GlobalUsage.WcCode);

            txtWorkerCnt.TextBoxText = list.Count.ToString();
        }
        private void btnAllocate_Click(object sender, EventArgs e)
        {
            if (dgvAllocatableWorker.SelectedRows.Count > 0)
            {
                Emp_Allocation_HistoryService service = new Emp_Allocation_HistoryService();
                if (service.InsertWorkerAllocate(dgvAllocatableWorker.SelectedRows[0].Cells[2].Value.ToString(), GlobalUsage.UserID, GlobalUsage.WcCode))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}가 작업장({GlobalUsage.WcCode})에 작업자({dgvAllocatableWorker.SelectedRows[0].Cells[2].Value.ToString()})를 할당에 성공함");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}가 작업장({GlobalUsage.WcCode})에 작업자({dgvAllocatableWorker.SelectedRows[0].Cells[2].Value.ToString()})를 할당하려 하였으나 실패함");
                    MessageBox.Show("작업자 할당에 실패하였습니다.");
                }
            }

        }
        private void btnDeallocate_Click(object sender, EventArgs e)
        {
            if (dgvAllocatedWorker.SelectedRows.Count > 0)
            {
                Emp_Allocation_HistoryService service = new Emp_Allocation_HistoryService();
                if (service.UpdateWorkerDeallocate(dgvAllocatedWorker.SelectedRows[0].Cells[2].Value.ToString(), GlobalUsage.UserID, GlobalUsage.WcCode))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}가 작업장({GlobalUsage.WcCode})에 작업자({dgvAllocatedWorker.SelectedRows[0].Cells[2].Value.ToString()})를 할당해제에 성공함");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}가 작업장({GlobalUsage.WcCode})에 작업자({dgvAllocatedWorker.SelectedRows[0].Cells[2].Value.ToString()})를 할당해제하려 하였으나 실패함");
                    MessageBox.Show("작업자 해제에 실패하였습니다.");
                }
            }
        }
        private void btnDeallocateAll_Click(object sender, EventArgs e)
        {
            if (dgvAllocatedWorker.Rows.Count>0)
            {
                List<string> strlist = new List<string>();
                foreach (DataGridViewRow item in dgvAllocatedWorker.Rows)
                {
                    strlist.Add(item.Cells[2].Value.ToString());
                }

                Emp_Allocation_HistoryService service = new Emp_Allocation_HistoryService();

                StringBuilder sb = new StringBuilder();
                foreach (var item in strlist)
                {
                    sb.Append(item + " ");
                }
                if (service.UpdateWorkerDeallocateAll(strlist, GlobalUsage.UserID, GlobalUsage.WcCode))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}가 작업장({GlobalUsage.WcCode})에 작업자({sb.ToString()})들의 할당해제에 성공함");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserID}가 작업장({GlobalUsage.WcCode})에 작업자({sb.ToString()})들의 할당해제에 실패함");
                    MessageBox.Show("작업자 전체 해제에 실패하였습니다.");
                }
            }
        }
    }
}
