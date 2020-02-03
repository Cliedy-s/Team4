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
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatedWorker, "할당시각", "Allocation_datetime", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            dgvAllocatedWorker.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            InitControlUtil.SetPOPDGVDesign(dgvAllocatableWorker);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatableWorker, "작업자", "User_Name", true, 100);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatableWorker, "현재 작업장", "Wc_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvAllocatableWorker, "ID", "User_ID", false, 80);
        }
        private void GetDatas()
        {   // 작업장에 할당된 작업자 목록 가져오기
            Emp_Wc_AllocationService service = new Emp_Wc_AllocationService();
            List<WorkerVO> list = service.GetAllocatedWorker(GlobalUsage.WcCode);
            dgvAllocatedWorker.DataSource = list;
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
                    GetDatas();
                }
                else
                    MessageBox.Show("작업자 할당에 실패하였습니다.");
            }

        }
        private void btnDeallocate_Click(object sender, EventArgs e)
        {
            if (dgvAllocatedWorker.SelectedRows.Count > 0)
            {
                Emp_Allocation_HistoryService service = new Emp_Allocation_HistoryService();
                if (service.UpdateWorkerDeallocate(dgvAllocatableWorker.SelectedRows[0].Cells[2].Value.ToString(), GlobalUsage.UserID, GlobalUsage.WcCode))
                {
                    GetDatas();
                }
                else
                    MessageBox.Show("작업자 해제에 실패하였습니다.");
            }
        }
        private void btnDeallocateAll_Click(object sender, EventArgs e)
        {
            if (dgvAllocatedWorker.Rows.Count>0)
            {
                List<string> strlist = new List<string>();
                foreach (DataGridViewRow item in dgvAllocatableWorker.Rows)
                {
                    strlist.Add(item.Cells[2].Value.ToString());
                }

                Emp_Allocation_HistoryService service = new Emp_Allocation_HistoryService();
                if (service.UpdateWorkerDeallocateAll(strlist, GlobalUsage.UserID, GlobalUsage.WcCode))
                {
                    GetDatas();
                }
                else
                    MessageBox.Show("작업자 전체 해제에 실패하였습니다.");
            }
        }
    }
}
