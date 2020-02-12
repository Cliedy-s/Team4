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
    public partial class QAM_SQC_002_1 : Axxen.BaseForm
    {
        List<InspectHistoryVO> ihvo;
        Inspect_Measure_HistoryService ihService = new Inspect_Measure_HistoryService();
        public string Item_code { get; set; }
        public string Process_code { get; set; }
        public string Inspect_code { get; set; }
        public string Workorderno { get; set; }
        public QAM_SQC_002_1()
        {
            InitializeComponent();
        }

        private void QAM_SQC_002_1_Load(object sender, EventArgs e)
        {
            lblManager.Text = UserInfo.User_Name;
            txtitem.Text = Item_code;
            txtprocess.Text = Process_code;
            txtinspect.Text = Inspect_code;
            txtwork.Text = Workorderno;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("추가하시겠습니까?", "추가여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InspectHistoryVO item = new InspectHistoryVO();
                item.Item_code = Item_code;
                item.Process_code = Process_code;
                item.Inspect_code = Inspect_code;
                item.Inspect_val = nudusl.Value;
                item.Workorderno = Workorderno;

                bool IsSuccess = ihService.InsertInspect_Measure(item, lblManager.Text); //품질측정 추가 조회

                if (IsSuccess)
                {
                    MessageBox.Show("성공적으로 추가하였습니다.", "추가성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("추가에 실패하였습니다.", "추가오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
