using Axxen.CustomControls;
using AxxenClient.Templets;
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
    public partial class POP_PRD_016 : ClientBaseForm
    {
        public POP_PRD_016()
        {
            InitializeComponent();
        }

        private void POP_PRD_016_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvNopList);
            InitControlUtil.AddNewColumnToDataGridView(dgvNopList, "작업장", "Wc_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvNopList, "주원인", "Nop_Ma_Name", true, 130, DataGridViewContentAlignment.MiddleCenter);
            InitControlUtil.AddNewColumnToDataGridView(dgvNopList, "상세원인", "Nop_Mi_Name", true, 130, DataGridViewContentAlignment.MiddleCenter);
            InitControlUtil.AddNewColumnToDataGridView(dgvNopList, "발생시각", "Nop_Happentime", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvNopList, "해제시각", "Nop_Canceltime", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvNopList, "비가동시간(분)", "Nop_Time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvNopList, "작업장코드", "Wc_Code", true, 120);
            InitControlUtil.AddNewColumnToDataGridView(dgvNopList, "발생순번", "Nop_Seq", true, 120);
            dgvNopList.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgvNopList.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

        }
        private void GetDatas()
        {
            Nop_HistoryService sservice = new Nop_HistoryService();
            dgvNopList.DataSource = sservice.GetAllNop_History();
        }

        private void btnChangeReason_Click(object sender, EventArgs e)
        {
            if(dgvNopList.SelectedRows.Count > 0)
            {
                ChangeNopReason frm = new ChangeNopReason(dgvNopList.SelectedRows[0].Cells[0].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(frm.NopMiCode))
                    {
                        Nop_HistoryService service = new Nop_HistoryService();
                        dgvNopList.DataSource = service.UpdateNop_History(frm.NopMiCode, GlobalUsage.UserID, Convert.ToInt32(dgvNopList.SelectedRows[0].Cells[7].Value));
                    }
                }
            }
        }
    }
}
