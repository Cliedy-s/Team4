namespace Axxen.HwiSeok
{
    partial class QAM_SQC_002
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
            this.aComboBox2 = new Axxen.CustomControls.AComboBox();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aComboBox1 = new Axxen.CustomControls.AComboBox();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aTextBox_FindNameByCode2 = new Axxen.CustomControls.ATextBox_FindNameByCode();
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
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode2);
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode1);
            this.aPanel2.Controls.Add(this.aComboBox2);
            this.aPanel2.Controls.Add(this.aLabel2);
            this.aPanel2.Controls.Add(this.aComboBox1);
            this.aPanel2.Controls.Add(this.aLabel1);
            // 
            // aComboBox2
            // 
            this.aComboBox2.FormattingEnabled = true;
            this.aComboBox2.Location = new System.Drawing.Point(256, 28);
            this.aComboBox2.Name = "aComboBox2";
            this.aComboBox2.Size = new System.Drawing.Size(121, 23);
            this.aComboBox2.TabIndex = 25;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(235, 32);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(15, 15);
            this.aLabel2.TabIndex = 24;
            this.aLabel2.Text = "~";
            // 
            // aComboBox1
            // 
            this.aComboBox1.FormattingEnabled = true;
            this.aComboBox1.Location = new System.Drawing.Point(108, 28);
            this.aComboBox1.Name = "aComboBox1";
            this.aComboBox1.Size = new System.Drawing.Size(121, 23);
            this.aComboBox1.TabIndex = 23;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 22;
            this.aLabel1.Text = "작업지시일자";
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(6, 23);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(115, 23);
            this.aButton1.TabIndex = 1;
            this.aButton1.Text = "측정회차 추가";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Location = new System.Drawing.Point(127, 23);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(115, 23);
            this.aButton2.TabIndex = 2;
            this.aButton2.Text = "측정회차 삭제";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.ATextBox_FindNameByCode.types.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(421, 26);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(218, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 26;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            // 
            // aTextBox_FindNameByCode2
            // 
            this.aTextBox_FindNameByCode2.CodeType = Axxen.CustomControls.ATextBox_FindNameByCode.types.WorkCenters;
            this.aTextBox_FindNameByCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.lblNameText = "작업장";
            this.aTextBox_FindNameByCode2.Location = new System.Drawing.Point(659, 26);
            this.aTextBox_FindNameByCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode2.Name = "aTextBox_FindNameByCode2";
            this.aTextBox_FindNameByCode2.Size = new System.Drawing.Size(230, 27);
            this.aTextBox_FindNameByCode2.TabIndex = 27;
            this.aTextBox_FindNameByCode2.txtCodeText = "";
            this.aTextBox_FindNameByCode2.txtNameText = "";
            // 
            // QAM_SQC_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "QAM_SQC_002";
            this.Text = "품질측정값등록";
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
        private CustomControls.AComboBox aComboBox2;
        private CustomControls.ALabel aLabel2;
        private CustomControls.AComboBox aComboBox1;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode2;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
    }
}
