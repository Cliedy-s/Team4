namespace Axxen
{
    partial class MSS_SYS_009_1
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
            this.aPanel19 = new Axxen.CustomControls.APanel();
            this.aLabel8 = new Axxen.CustomControls.ALabel();
            this.aPanel20 = new Axxen.CustomControls.APanel();
            this.txttitle = new Axxen.CustomControls.ATextBox();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.txtstart = new Axxen.CustomControls.ATextBox();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.txtend = new Axxen.CustomControls.ATextBox();
            this.txtde = new Axxen.CustomControls.ATextBox();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.lblid = new Axxen.CustomControls.ALabel();
            this.aPanel19.SuspendLayout();
            this.aPanel20.SuspendLayout();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.aPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel19
            // 
            this.aPanel19.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel19.Controls.Add(this.aLabel8);
            this.aPanel19.Location = new System.Drawing.Point(9, 46);
            this.aPanel19.Name = "aPanel19";
            this.aPanel19.Size = new System.Drawing.Size(120, 35);
            this.aPanel19.TabIndex = 184;
            // 
            // aLabel8
            // 
            this.aLabel8.AutoSize = true;
            this.aLabel8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel8.Location = new System.Drawing.Point(38, 7);
            this.aLabel8.Name = "aLabel8";
            this.aLabel8.Size = new System.Drawing.Size(34, 17);
            this.aLabel8.TabIndex = 55;
            this.aLabel8.Text = "제목";
            // 
            // aPanel20
            // 
            this.aPanel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel20.Controls.Add(this.txttitle);
            this.aPanel20.Location = new System.Drawing.Point(129, 46);
            this.aPanel20.Name = "aPanel20";
            this.aPanel20.Size = new System.Drawing.Size(420, 35);
            this.aPanel20.TabIndex = 183;
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.White;
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttitle.Enabled = false;
            this.txttitle.errorp = null;
            this.txttitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txttitle.Location = new System.Drawing.Point(3, 3);
            this.txttitle.MaxLength = 20;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(410, 25);
            this.txttitle.TabIndex = 0;
            this.txttitle.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel1.Controls.Add(this.aLabel1);
            this.aPanel1.Location = new System.Drawing.Point(9, 82);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(120, 35);
            this.aPanel1.TabIndex = 186;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel1.Location = new System.Drawing.Point(30, 7);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(47, 17);
            this.aLabel1.TabIndex = 55;
            this.aLabel1.Text = "등록일";
            // 
            // aPanel2
            // 
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.txtstart);
            this.aPanel2.Location = new System.Drawing.Point(129, 82);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(157, 35);
            this.aPanel2.TabIndex = 185;
            // 
            // txtstart
            // 
            this.txtstart.BackColor = System.Drawing.Color.White;
            this.txtstart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstart.Enabled = false;
            this.txtstart.errorp = null;
            this.txtstart.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtstart.Location = new System.Drawing.Point(3, 3);
            this.txtstart.MaxLength = 20;
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(147, 25);
            this.txtstart.TabIndex = 0;
            this.txtstart.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel3.Controls.Add(this.aLabel2);
            this.aPanel3.Location = new System.Drawing.Point(286, 82);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(120, 35);
            this.aPanel3.TabIndex = 188;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel2.Location = new System.Drawing.Point(32, 7);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(47, 17);
            this.aLabel2.TabIndex = 55;
            this.aLabel2.Text = "마감일";
            // 
            // aPanel4
            // 
            this.aPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel4.Controls.Add(this.txtend);
            this.aPanel4.Location = new System.Drawing.Point(406, 82);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(144, 35);
            this.aPanel4.TabIndex = 187;
            // 
            // txtend
            // 
            this.txtend.BackColor = System.Drawing.Color.White;
            this.txtend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtend.Enabled = false;
            this.txtend.errorp = null;
            this.txtend.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtend.Location = new System.Drawing.Point(3, 3);
            this.txtend.MaxLength = 20;
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(134, 25);
            this.txtend.TabIndex = 0;
            this.txtend.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtde
            // 
            this.txtde.BackColor = System.Drawing.Color.White;
            this.txtde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtde.Enabled = false;
            this.txtde.errorp = null;
            this.txtde.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtde.Location = new System.Drawing.Point(9, 118);
            this.txtde.MaxLength = 2000;
            this.txtde.Multiline = true;
            this.txtde.Name = "txtde";
            this.txtde.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtde.Size = new System.Drawing.Size(541, 424);
            this.txtde.TabIndex = 189;
            this.txtde.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.Info;
            this.aButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aButton1.FlatAppearance.BorderSize = 0;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(475, 548);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(75, 23);
            this.aButton1.TabIndex = 190;
            this.aButton1.Text = "닫기";
            this.aButton1.UseVisualStyleBackColor = false;
            this.aButton1.Click += new System.EventHandler(this.AButton1_Click);
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(13, 13);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(58, 21);
            this.aLabel3.TabIndex = 191;
            this.aLabel3.Text = "번호 : ";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblid.Location = new System.Drawing.Point(67, 13);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(58, 21);
            this.lblid.TabIndex = 192;
            this.lblid.Text = "        ";
            // 
            // MSS_SYS_009_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(556, 584);
            this.ControlBox = false;
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.aLabel3);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.txtde);
            this.Controls.Add(this.aPanel3);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aPanel19);
            this.Controls.Add(this.aPanel20);
            this.Name = "MSS_SYS_009_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "공지사항";
            this.Load += new System.EventHandler(this.MSS_SYS_009_1_Load);
            this.aPanel19.ResumeLayout(false);
            this.aPanel19.PerformLayout();
            this.aPanel20.ResumeLayout(false);
            this.aPanel20.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.aPanel3.PerformLayout();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.APanel aPanel19;
        private CustomControls.ALabel aLabel8;
        private CustomControls.APanel aPanel20;
        private CustomControls.ATextBox txttitle;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel aLabel1;
        private CustomControls.APanel aPanel2;
        private CustomControls.ATextBox txtstart;
        private CustomControls.APanel aPanel3;
        private CustomControls.ALabel aLabel2;
        private CustomControls.APanel aPanel4;
        private CustomControls.ATextBox txtend;
        private CustomControls.ATextBox txtde;
        private CustomControls.AButton aButton1;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel lblid;
    }
}
