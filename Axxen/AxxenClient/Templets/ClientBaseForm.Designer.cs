namespace AxxenClient.Templets
{
    partial class ClientBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientBaseForm));
            this.panBottom = new Axxen.CustomControls.APanel();
            this.btnNoActive = new Axxen.CustomControls.AButton();
            this.btnConfig = new Axxen.CustomControls.AButton();
            this.txtPronounce = new Axxen.CustomControls.ALabel();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.lblTime = new Axxen.CustomControls.ALabel();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.lblUserName = new Axxen.CustomControls.ALabel();
            this.btnMachineRun = new Axxen.CustomControls.AButton();
            this.aLabel_Header1 = new Axxen.CustomControls.ALabel_Header();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panBottom.Controls.Add(this.btnNoActive);
            this.panBottom.Controls.Add(this.btnConfig);
            this.panBottom.Controls.Add(this.txtPronounce);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 681);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1210, 36);
            this.panBottom.TabIndex = 2;
            // 
            // btnNoActive
            // 
            this.btnNoActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoActive.BackColor = System.Drawing.Color.White;
            this.btnNoActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoActive.Location = new System.Drawing.Point(1019, 0);
            this.btnNoActive.Name = "btnNoActive";
            this.btnNoActive.Size = new System.Drawing.Size(96, 36);
            this.btnNoActive.TabIndex = 4;
            this.btnNoActive.Text = "비가동 등록";
            this.btnNoActive.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.White;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(1114, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(96, 36);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // txtPronounce
            // 
            this.txtPronounce.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPronounce.AutoSize = true;
            this.txtPronounce.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPronounce.ForeColor = System.Drawing.Color.Yellow;
            this.txtPronounce.Location = new System.Drawing.Point(8, 10);
            this.txtPronounce.Name = "txtPronounce";
            this.txtPronounce.Size = new System.Drawing.Size(78, 17);
            this.txtPronounce.TabIndex = 5;
            this.txtPronounce.Text = "~공지사항~";
            this.txtPronounce.Visible = false;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.Gray;
            this.aPanel2.Controls.Add(this.lblTime);
            this.aPanel2.Controls.Add(this.aPanel3);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1210, 99);
            this.aPanel2.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.ForeColor = System.Drawing.Color.Orange;
            this.lblTime.Location = new System.Drawing.Point(25, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(127, 60);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "2020-01-13\r\n18:26:32";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.Color.White;
            this.aPanel3.Controls.Add(this.aLabel2);
            this.aPanel3.Controls.Add(this.lblUserName);
            this.aPanel3.Controls.Add(this.btnMachineRun);
            this.aPanel3.Controls.Add(this.aLabel_Header1);
            this.aPanel3.Controls.Add(this.btnClose);
            this.aPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel3.Location = new System.Drawing.Point(0, 0);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(1210, 97);
            this.aPanel3.TabIndex = 4;
            // 
            // aLabel2
            // 
            this.aLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(1038, 41);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(26, 21);
            this.aLabel2.TabIndex = 19;
            this.aLabel2.Text = "님";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserName.Location = new System.Drawing.Point(863, 40);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(172, 23);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "lblUserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMachineRun
            // 
            this.btnMachineRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnMachineRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMachineRun.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMachineRun.Location = new System.Drawing.Point(176, 2);
            this.btnMachineRun.Name = "btnMachineRun";
            this.btnMachineRun.Size = new System.Drawing.Size(95, 92);
            this.btnMachineRun.TabIndex = 17;
            this.btnMachineRun.Text = "기계\r\n시작/종료";
            this.btnMachineRun.UseVisualStyleBackColor = false;
            this.btnMachineRun.Visible = false;
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel_Header1.BackColor = System.Drawing.Color.White;
            this.aLabel_Header1.Font = new System.Drawing.Font("나눔고딕", 25F, System.Drawing.FontStyle.Bold);
            this.aLabel_Header1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aLabel_Header1.Location = new System.Drawing.Point(169, 28);
            this.aLabel_Header1.Name = "aLabel_Header1";
            this.aLabel_Header1.Size = new System.Drawing.Size(946, 39);
            this.aLabel_Header1.TabIndex = 1;
            this.aLabel_Header1.Text = "aLabel_Header1";
            this.aLabel_Header1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::AxxenClient.Properties.Resources.X;
            this.btnClose.Location = new System.Drawing.Point(1129, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 65);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ClientBaseForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1210, 717);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.aPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ClientBaseForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientBaseForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientBaseForm_Load);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.aPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected Axxen.CustomControls.APanel panBottom;
        protected Axxen.CustomControls.AButton btnNoActive;
        protected Axxen.CustomControls.AButton btnConfig;
        protected Axxen.CustomControls.ALabel txtPronounce;
        protected Axxen.CustomControls.APanel aPanel2;
        private Axxen.CustomControls.APanel aPanel3;
        protected System.Windows.Forms.PictureBox btnClose;
        protected Axxen.CustomControls.ALabel lblTime;
        protected Axxen.CustomControls.ALabel_Header aLabel_Header1;
        protected Axxen.CustomControls.AButton btnMachineRun;
        private Axxen.CustomControls.ALabel aLabel2;
        private Axxen.CustomControls.ALabel lblUserName;
    }
}
