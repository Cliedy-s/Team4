using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class PRM_PRF_002_1 : Axxen.BaseForm
    {
        WorkOrder_Service woservice = new WorkOrder_Service();
        public string Workorderno { get; set; }
        public string Pallet_No { get; set; }
        public string Grade_Detail_Name { get; set; }
        public PRM_PRF_002_1()
        {
            InitializeComponent();
        }

        private void aButton3_Click(object sender, EventArgs e) // 폼 닫기
        {
            this.Close();
        }

        private void PRM_PRF_002_1_Load(object sender, EventArgs e)
        {
            aTextBox1.Text = Grade_Detail_Name;
        }

        private void aButton4_Click(object sender, EventArgs e) // 수정
        {
            bool IsSuccess = woservice.UPDATE_Grade_Detail_Name(Workorderno, Pallet_No, aTextBox1.Text);

            if (IsSuccess)
                MessageBox.Show("성공적으로 수정하였습니다.", "수정성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("수정에 실패하였습니다.", "수정오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult = DialogResult.OK;
        }
    }
}
