namespace Axxen
{
    partial class QAM_SQC_003
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
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aTextBox_FindNameByCode2 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aDateTimePicker2 = new Axxen.CustomControls.ADateTimePicker();
            this.aDateTimePicker1 = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.aGroupBox2.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aSplitContainer1
            // 
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "작업지시";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "측정이력";
            // 
            // aGroupBox1
            // 
            this.aGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.aGroupBox1.Size = new System.Drawing.Size(203, 561);
            this.aGroupBox1.Text = "검사항목";
            // 
            // aGroupBox2
            // 
            this.aGroupBox2.Controls.Add(this.aButton2);
            this.aGroupBox2.Controls.Add(this.aButton1);
            this.aGroupBox2.Location = new System.Drawing.Point(206, 0);
            this.aGroupBox2.Size = new System.Drawing.Size(653, 561);
            this.aGroupBox2.Text = "측정값";
            this.aGroupBox2.Controls.SetChildIndex(this.aButton1, 0);
            this.aGroupBox2.Controls.SetChildIndex(this.aButton2, 0);
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.aDateTimePicker2);
            this.aPanel2.Controls.Add(this.aDateTimePicker1);
            this.aPanel2.Controls.Add(this.aLabel2);
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode2);
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode1);
            this.aPanel2.Controls.Add(this.aLabel1);
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Location = new System.Drawing.Point(127, 23);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(115, 23);
            this.aButton2.TabIndex = 4;
            this.aButton2.Text = "측정회차 삭제";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(6, 23);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(115, 23);
            this.aButton1.TabIndex = 3;
            this.aButton1.Text = "측정회차 추가";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aTextBox_FindNameByCode2
            // 
            this.aTextBox_FindNameByCode2.CodeType = Axxen.CustomControls.ATextBox_FindNameByCode.types.WorkCenters;
            this.aTextBox_FindNameByCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.lblNameText = "작업장";
            this.aTextBox_FindNameByCode2.Location = new System.Drawing.Point(656, 26);
            this.aTextBox_FindNameByCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode2.Name = "aTextBox_FindNameByCode2";
            this.aTextBox_FindNameByCode2.Size = new System.Drawing.Size(230, 27);
            this.aTextBox_FindNameByCode2.TabIndex = 33;
            this.aTextBox_FindNameByCode2.txtCodeText = "";
            this.aTextBox_FindNameByCode2.txtNameText = "";
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.ATextBox_FindNameByCode.types.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(420, 26);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(218, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 32;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 28;
            this.aLabel1.Text = "작업지시일자";
            // 
            // aDateTimePicker2
            // 
            this.aDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker2.Location = new System.Drawing.Point(243, 28);
            this.aDateTimePicker2.Name = "aDateTimePicker2";
            this.aDateTimePicker2.Size = new System.Drawing.Size(103, 23);
            this.aDateTimePicker2.TabIndex = 36;
            // 
            // aDateTimePicker1
            // 
            this.aDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker1.Location = new System.Drawing.Point(112, 28);
            this.aDateTimePicker1.Name = "aDateTimePicker1";
            this.aDateTimePicker1.Size = new System.Drawing.Size(103, 23);
            this.aDateTimePicker1.TabIndex = 35;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(222, 32);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(15, 15);
            this.aLabel2.TabIndex = 34;
            this.aLabel2.Text = "~";
            // 
            // QAM_SQC_003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "QAM_SQC_003";
            this.Text = "공정조건등록";
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.aGroupBox2.ResumeLayout(false);
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.AButton aButton2;
        private CustomControls.AButton aButton1;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode2;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ADateTimePicker aDateTimePicker2;
        private CustomControls.ADateTimePicker aDateTimePicker1;
        private CustomControls.ALabel aLabel2;
    }
}
