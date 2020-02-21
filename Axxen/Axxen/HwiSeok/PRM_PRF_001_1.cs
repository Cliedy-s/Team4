using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen.HwiSeok
{
    public partial class PRM_PRF_001_1 : BaseForm
    {

            WorkOrder_Service woservice = new WorkOrder_Service();

            public string Num { get; set; } //번호
            public string Prd_Date { get; set; } //작업지시일자
            public string Wo_Status { get; set; } //작업지시상태
            public string Workorderno { get; set; } //작업지시번호
            public string Item_Code { get; set; } //품목코드
            public string Item_Name { get; set; } //품목명
            public string Wc_Name { get; set; } //작업장
            public string Process_name { get; set; } //공정명
            public string In_Qty_Main { get; set; } //투입수량
            public string Out_Qty_Main { get; set; } //산출수량
            public string Prd_Qty { get; set; } //생산수량
      

        public PRM_PRF_001_1()
        {
            InitializeComponent();
        }

        private void aButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PRM_PRF_001_1_Load(object sender, EventArgs e)
        {
            txtNum.Text = Num;
            txtPrd_Date.Text = Prd_Date;
            txtWo_Status.Text = Wo_Status;
            txtWorkorderno.Text = Workorderno;
            txtItem_Code.Text = Item_Code;
            txtItem_Name.Text = Item_Name;
            txtWc_Name.Text = Wc_Name;
            txtProcess_name.Text = Process_name;
            txtIn_Qty_Main.Text = In_Qty_Main;
            txtOut_Qty_Main.Text = Out_Qty_Main;
            txtPrd_Qty.Text = Prd_Qty;

            panel1.Enabled = false;
        }

        private void aButton1_Click(object sender, EventArgs e)
        {
            bool IsSuccess = woservice.UPDATE_Prd_Qty(txtPrd_Qty.Text, Num, Wo_Status, Workorderno, Item_Code);

            if (IsSuccess)
                MessageBox.Show("성공적으로 수정하였습니다.", "수정성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("수정에 실패하였습니다.", "수정오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.DialogResult=DialogResult.OK;
        }

        private void txtPrd_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리

            {
                e.Handled = true;
            }           
        }
    }
}
