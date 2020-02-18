using Axxen.CustomControls;
using AxxenClient.Templets;
using DAC;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using VO;
using static Axxen.CustomControls.ATextBox_FindNameByCode;

namespace AxxenClient.Forms
{
    public partial class SearchForm : ClientFreeForm
    {
        public string ResultCode { get; set; }
        public string ResultName { get; set; }

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            InitControlUtil.SetDGVDesign(dgvSearchResult);
            InitControlUtil.AddNewColumnToDataGridView(dgvSearchResult, "등급상세", "Grade_Detail_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvSearchResult, "팔레트번호", "Pallet_No", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            Pallet_MasterService service = new Pallet_MasterService();
            dgvSearchResult.DataSource = service.GetAll(GlobalUsage.WorkOrderNo);
            lblSearch.Text = "팔레트 목록";
        }
        private void dgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.ResultCode = dgvSearchResult.SelectedRows[0].Cells[0].Value==null ? "" : dgvSearchResult.SelectedRows[0].Cells[0].Value.ToString();
                this.ResultName = dgvSearchResult.SelectedRows[0].Cells[1].Value == null ? "" : dgvSearchResult.SelectedRows[0].Cells[1].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
