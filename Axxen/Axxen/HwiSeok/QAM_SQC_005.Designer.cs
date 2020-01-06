namespace Axxen
{
    partial class QAM_SQC_005
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
            this.aTextBox_FindNameByCode2 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aComboBox2 = new Axxen.CustomControls.AComboBox();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aComboBox1 = new Axxen.CustomControls.AComboBox();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.panTop.Controls.Add(this.aTextBox_FindNameByCode2);
            this.panTop.Controls.Add(this.aTextBox_FindNameByCode1);
            this.panTop.Controls.Add(this.aComboBox2);
            this.panTop.Controls.Add(this.aLabel2);
            this.panTop.Controls.Add(this.aComboBox1);
            this.panTop.Controls.Add(this.aLabel1);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aTextBox_FindNameByCode2
            // 
            this.aTextBox_FindNameByCode2.CodeType = Axxen.CustomControls.ATextBox_FindNameByCode.types.WorkCenters;
            this.aTextBox_FindNameByCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.lblNameText = "작업장";
            this.aTextBox_FindNameByCode2.Location = new System.Drawing.Point(652, 26);
            this.aTextBox_FindNameByCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode2.Name = "aTextBox_FindNameByCode2";
            this.aTextBox_FindNameByCode2.Size = new System.Drawing.Size(230, 27);
            this.aTextBox_FindNameByCode2.TabIndex = 45;
            this.aTextBox_FindNameByCode2.txtCodeText = "";
            this.aTextBox_FindNameByCode2.txtNameText = "";
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.ATextBox_FindNameByCode.types.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(416, 26);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(218, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 44;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            // 
            // aComboBox2
            // 
            this.aComboBox2.FormattingEnabled = true;
            this.aComboBox2.Location = new System.Drawing.Point(257, 28);
            this.aComboBox2.Name = "aComboBox2";
            this.aComboBox2.Size = new System.Drawing.Size(121, 23);
            this.aComboBox2.TabIndex = 43;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(236, 32);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(15, 15);
            this.aLabel2.TabIndex = 42;
            this.aLabel2.Text = "~";
            // 
            // aComboBox1
            // 
            this.aComboBox1.FormattingEnabled = true;
            this.aComboBox1.Location = new System.Drawing.Point(109, 28);
            this.aComboBox1.Name = "aComboBox1";
            this.aComboBox1.Size = new System.Drawing.Size(121, 23);
            this.aComboBox1.TabIndex = 41;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 40;
            this.aLabel1.Text = "작업지시일자";
            // 
            // QAM_SQC_005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "QAM_SQC_005";
            this.Text = "공정조건 조회";
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode2;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.AComboBox aComboBox2;
        private CustomControls.ALabel aLabel2;
        private CustomControls.AComboBox aComboBox1;
        private CustomControls.ALabel aLabel1;
    }
}
