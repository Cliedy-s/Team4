namespace Axxen
{
    partial class PPS_SCH_001
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
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aDateTimePicker1 = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aDateTimePicker2 = new Axxen.CustomControls.ADateTimePicker();
            this.aTextBox_Labeled1 = new Axxen.CustomControls.ATextBox_Labeled();
            this.aTextBox_Labeled2 = new Axxen.CustomControls.ATextBox_Labeled();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.aTextBox_Labeled2);
            this.aPanel1.Controls.Add(this.aTextBox_Labeled1);
            this.aPanel1.Controls.Add(this.aDateTimePicker2);
            this.aPanel1.Controls.Add(this.aLabel2);
            this.aPanel1.Controls.Add(this.aDateTimePicker1);
            this.aPanel1.Controls.Add(this.aLabel1);
            this.aPanel1.Controls.Add(this.aButton2);
            this.aPanel1.Controls.Add(this.aButton1);
            // 
            // aSplitContainer1
            // 
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(981, 14);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(125, 23);
            this.aButton1.TabIndex = 0;
            this.aButton1.Text = "생산의뢰 다운로드";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Location = new System.Drawing.Point(981, 43);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(125, 23);
            this.aButton2.TabIndex = 0;
            this.aButton2.Text = "생산의뢰 마감";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(35, 28);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 1;
            this.aLabel1.Text = "생산의뢰일자";
            // 
            // aDateTimePicker1
            // 
            this.aDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker1.Location = new System.Drawing.Point(120, 24);
            this.aDateTimePicker1.Name = "aDateTimePicker1";
            this.aDateTimePicker1.Size = new System.Drawing.Size(105, 23);
            this.aDateTimePicker1.TabIndex = 2;
            this.aDateTimePicker1.Value = new System.DateTime(2020, 1, 3, 15, 14, 0, 0);
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(232, 28);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(15, 15);
            this.aLabel2.TabIndex = 3;
            this.aLabel2.Text = "~";
            // 
            // aDateTimePicker2
            // 
            this.aDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker2.Location = new System.Drawing.Point(253, 24);
            this.aDateTimePicker2.Name = "aDateTimePicker2";
            this.aDateTimePicker2.Size = new System.Drawing.Size(105, 23);
            this.aDateTimePicker2.TabIndex = 4;
            this.aDateTimePicker2.Value = new System.DateTime(2020, 1, 3, 15, 14, 0, 0);
            // 
            // aTextBox_Labeled1
            // 
            this.aTextBox_Labeled1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Labeled1.FontSize = 9F;
            this.aTextBox_Labeled1.LabelText = "생산의뢰 번호";
            this.aTextBox_Labeled1.Location = new System.Drawing.Point(492, 4);
            this.aTextBox_Labeled1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Labeled1.Name = "aTextBox_Labeled1";
            this.aTextBox_Labeled1.Size = new System.Drawing.Size(313, 23);
            this.aTextBox_Labeled1.TabIndex = 5;
            this.aTextBox_Labeled1.TextBoxText = "";
            // 
            // aTextBox_Labeled2
            // 
            this.aTextBox_Labeled2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Labeled2.FontSize = 9F;
            this.aTextBox_Labeled2.LabelText = "프로젝트 명";
            this.aTextBox_Labeled2.Location = new System.Drawing.Point(497, 36);
            this.aTextBox_Labeled2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.aTextBox_Labeled2.Name = "aTextBox_Labeled2";
            this.aTextBox_Labeled2.Size = new System.Drawing.Size(308, 23);
            this.aTextBox_Labeled2.TabIndex = 6;
            this.aTextBox_Labeled2.TextBoxText = "";
            // 
            // PPS_SCH_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "PPS_SCH_001";
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.AButton aButton1;
        private CustomControls.AButton aButton2;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_Labeled aTextBox_Labeled2;
        private CustomControls.ATextBox_Labeled aTextBox_Labeled1;
        private CustomControls.ADateTimePicker aDateTimePicker2;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ADateTimePicker aDateTimePicker1;
    }
}
