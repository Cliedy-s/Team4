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
            this.btnPrDown = new Axxen.CustomControls.AButton();
            this.btnPrFinish = new Axxen.CustomControls.AButton();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.dtpPrstart = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.dtpPrFinish = new Axxen.CustomControls.ADateTimePicker();
            this.txtPrNum = new Axxen.CustomControls.ATextBox_Labeled();
            this.txtProjectName = new Axxen.CustomControls.ATextBox_Labeled();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.txtProjectName);
            this.aPanel1.Controls.Add(this.txtPrNum);
            this.aPanel1.Controls.Add(this.dtpPrFinish);
            this.aPanel1.Controls.Add(this.aLabel2);
            this.aPanel1.Controls.Add(this.dtpPrstart);
            this.aPanel1.Controls.Add(this.aLabel1);
            this.aPanel1.Controls.Add(this.btnPrFinish);
            this.aPanel1.Controls.Add(this.btnPrDown);
            // 
            // aSplitContainer1
            // 
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "생산의뢰";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "작업지시";
            // 
            // btnPrDown
            // 
            this.btnPrDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrDown.Location = new System.Drawing.Point(981, 14);
            this.btnPrDown.Name = "btnPrDown";
            this.btnPrDown.Size = new System.Drawing.Size(125, 23);
            this.btnPrDown.TabIndex = 0;
            this.btnPrDown.Text = "생산의뢰 다운로드";
            this.btnPrDown.UseVisualStyleBackColor = false;
            // 
            // btnPrFinish
            // 
            this.btnPrFinish.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrFinish.Location = new System.Drawing.Point(981, 43);
            this.btnPrFinish.Name = "btnPrFinish";
            this.btnPrFinish.Size = new System.Drawing.Size(125, 23);
            this.btnPrFinish.TabIndex = 0;
            this.btnPrFinish.Text = "생산의뢰 마감";
            this.btnPrFinish.UseVisualStyleBackColor = false;
            this.btnPrFinish.Click += new System.EventHandler(this.BtnPrFinish_Click);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 1;
            this.aLabel1.Text = "생산의뢰일자";
            // 
            // dtpPrstart
            // 
            this.dtpPrstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrstart.Location = new System.Drawing.Point(112, 28);
            this.dtpPrstart.Name = "dtpPrstart";
            this.dtpPrstart.Size = new System.Drawing.Size(105, 23);
            this.dtpPrstart.TabIndex = 2;
            this.dtpPrstart.Value = new System.DateTime(2020, 1, 3, 15, 14, 0, 0);
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(224, 32);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(15, 15);
            this.aLabel2.TabIndex = 3;
            this.aLabel2.Text = "~";
            // 
            // dtpPrFinish
            // 
            this.dtpPrFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrFinish.Location = new System.Drawing.Point(245, 28);
            this.dtpPrFinish.Name = "dtpPrFinish";
            this.dtpPrFinish.Size = new System.Drawing.Size(105, 23);
            this.dtpPrFinish.TabIndex = 4;
            this.dtpPrFinish.Value = new System.DateTime(2020, 1, 3, 15, 14, 0, 0);
            // 
            // txtPrNum
            // 
            this.txtPrNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrNum.FontSize = 9F;
            this.txtPrNum.LabelText = "생산의뢰 번호";
            this.txtPrNum.Location = new System.Drawing.Point(413, 28);
            this.txtPrNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrNum.Name = "txtPrNum";
            this.txtPrNum.Size = new System.Drawing.Size(237, 23);
            this.txtPrNum.TabIndex = 5;
            this.txtPrNum.TextBoxText = "";
            this.txtPrNum.TextKeyPress += new Axxen.CustomControls.ATextBox_Labeled.TextEnterKeyPress(this.Text_TextKeyPress);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProjectName.FontSize = 9F;
            this.txtProjectName.LabelText = "프로젝트 명";
            this.txtProjectName.Location = new System.Drawing.Point(685, 28);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(228, 23);
            this.txtProjectName.TabIndex = 6;
            this.txtProjectName.TextBoxText = "";
            this.txtProjectName.TextKeyPress += new Axxen.CustomControls.ATextBox_Labeled.TextEnterKeyPress(this.Text_TextKeyPress);
            // 
            // PPS_SCH_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "PPS_SCH_001";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPS_SCH_001_FormClosed);
            this.Load += new System.EventHandler(this.PPS_SCH_001_Load);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.AButton btnPrDown;
        private CustomControls.AButton btnPrFinish;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_Labeled txtProjectName;
        private CustomControls.ATextBox_Labeled txtPrNum;
        private CustomControls.ADateTimePicker dtpPrFinish;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ADateTimePicker dtpPrstart;
    }
}
