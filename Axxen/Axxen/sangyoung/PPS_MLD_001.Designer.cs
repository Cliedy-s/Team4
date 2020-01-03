namespace Axxen.sangyoung
{
    partial class PPS_MLD_001
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.aTextBox_Labeled2 = new Axxen.CustomControls.ATextBox_Labeled();
            this.aTextBox_Labeled1 = new Axxen.CustomControls.ATextBox_Labeled();
            this.aComboBox1 = new Axxen.CustomControls.AComboBox();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.aTextBox_Labeled2);
            this.aPanel1.Controls.Add(this.aTextBox_Labeled1);
            this.aPanel1.Controls.Add(this.aComboBox1);
            this.aPanel1.Controls.Add(this.aLabel1);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aTextBox_Labeled2
            // 
            this.aTextBox_Labeled2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Labeled2.FontSize = 9F;
            this.aTextBox_Labeled2.LabelText = "금형 명";
            this.aTextBox_Labeled2.Location = new System.Drawing.Point(294, 32);
            this.aTextBox_Labeled2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.aTextBox_Labeled2.Name = "aTextBox_Labeled2";
            this.aTextBox_Labeled2.Size = new System.Drawing.Size(205, 23);
            this.aTextBox_Labeled2.TabIndex = 14;
            this.aTextBox_Labeled2.TextBoxText = "";
            // 
            // aTextBox_Labeled1
            // 
            this.aTextBox_Labeled1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Labeled1.FontSize = 9F;
            this.aTextBox_Labeled1.LabelText = "금형 코드";
            this.aTextBox_Labeled1.Location = new System.Drawing.Point(27, 32);
            this.aTextBox_Labeled1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Labeled1.Name = "aTextBox_Labeled1";
            this.aTextBox_Labeled1.Size = new System.Drawing.Size(212, 23);
            this.aTextBox_Labeled1.TabIndex = 13;
            this.aTextBox_Labeled1.TextBoxText = "";
            // 
            // aComboBox1
            // 
            this.aComboBox1.FormattingEnabled = true;
            this.aComboBox1.Location = new System.Drawing.Point(638, 32);
            this.aComboBox1.Name = "aComboBox1";
            this.aComboBox1.Size = new System.Drawing.Size(106, 23);
            this.aComboBox1.TabIndex = 12;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(589, 36);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(43, 15);
            this.aLabel1.TabIndex = 11;
            this.aLabel1.Text = "생산월";
            // 
            // PPS_MLD_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "PPS_MLD_001";
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ATextBox_Labeled aTextBox_Labeled2;
        private CustomControls.ATextBox_Labeled aTextBox_Labeled1;
        private CustomControls.AComboBox aComboBox1;
        private CustomControls.ALabel aLabel1;
    }
}
