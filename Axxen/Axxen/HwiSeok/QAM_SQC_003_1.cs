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
    public partial class QAM_SQC_003_1 : Axxen.BaseForm
    {
        Condition_Measure_HistoryService cmhService = new Condition_Measure_HistoryService();
        public string Item_code { get; set; }
        public string Wc_Code { get; set; }
        public string Condition_Code { get; set; }
        public string Workorderno { get; set; }
        public QAM_SQC_003_1()
        {
            InitializeComponent();
        }

        private void QAM_SQC_003_1_Load(object sender, EventArgs e)
        {
            lblManager.Text = UserInfo.User_Name;
            txtitem.Text = Item_code;
            txtwccode.Text = Wc_Code;
            txtCondition.Text = Condition_Code;
            txtwork.Text = Workorderno;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("추가하시겠습니까?", "추가여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ConditionMeasureVO item = new ConditionMeasureVO();
                item.Item_code = Item_code;
                item.Wc_Code = Wc_Code;
                item.Condition_Code = Condition_Code;
                item.Condition_Val = nudusl.Value;
                item.Workorderno = Workorderno;

                bool IsSuccess = cmhService.InsertConditionMeasure(item, lblManager.Text); //품질측정 추가 조회

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

        private void nudusl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리

            {
                e.Handled = true;
            }
        }
    }
}
