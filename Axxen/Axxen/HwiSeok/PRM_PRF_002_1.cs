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
        public  List<Goods_In_History_J_Pallet_BoxingVO> Ghpb { get; set; }
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
            
            
        }

        private void aButton4_Click(object sender, EventArgs e) // 수정
        {
            Ghpb.Find(item => item.Grade_Detail_Name == aTextBox1.Text);

            bool IsSuccess = woservice.UPDATE_Grade_Detail_Name(Ghpb);

            if (IsSuccess)
                MessageBox.Show("성공적으로 수정하였습니다.", "수정성공");
            else
                MessageBox.Show("수정에 실패하였습니다.", "수정오류");
            this.DialogResult = DialogResult.OK;
        }
    }
}
