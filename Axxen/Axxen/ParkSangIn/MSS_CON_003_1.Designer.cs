namespace Axxen
{
    partial class MSS_CON_003_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSS_CON_003_1));
            this.txtPwd = new CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox();
            this.txtID = new CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox();
            this.txtName = new CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox();
            this.lblDay = new Axxen.CustomControls.ALabel();
            this.lblManager = new Axxen.CustomControls.ALabel();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.aLabel7 = new Axxen.CustomControls.ALabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aLabel9 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.aPanel9 = new Axxen.CustomControls.APanel();
            this.btnCencle = new Axxen.CustomControls.AButton();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.aPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic);
            this.txtPwd.ForeColor = System.Drawing.Color.Gray;
            this.txtPwd.Location = new System.Drawing.Point(15, 265);
            this.txtPwd.MaxLength = 50;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PlaceHolderText = "비밀번호를 입력하세요.";
            this.txtPwd.Size = new System.Drawing.Size(300, 29);
            this.txtPwd.TabIndex = 52;
            this.txtPwd.Text = "비밀번호를 입력하세요.";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic);
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.Location = new System.Drawing.Point(13, 187);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.PlaceHolderText = "아이디를 입력하세요.";
            this.txtID.Size = new System.Drawing.Size(300, 29);
            this.txtID.TabIndex = 51;
            this.txtID.Text = "아이디를 입력하세요.";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic);
            this.txtName.ForeColor = System.Drawing.Color.Gray;
            this.txtName.Location = new System.Drawing.Point(12, 116);
            this.txtName.MaxLength = 1000;
            this.txtName.Name = "txtName";
            this.txtName.PlaceHolderText = "이름을 입력하세요.";
            this.txtName.Size = new System.Drawing.Size(300, 29);
            this.txtName.TabIndex = 50;
            this.txtName.Text = "아이디를 입력하세요.";
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(232, 44);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(48, 15);
            this.lblDay.TabIndex = 49;
            this.lblDay.Text = "aLabel8";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(65, 44);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(48, 15);
            this.lblManager.TabIndex = 48;
            this.lblManager.Text = "aLabel6";
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.aLabel7);
            this.aPanel1.Controls.Add(this.pictureBox2);
            this.aPanel1.Controls.Add(this.aLabel9);
            this.aPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel1.Location = new System.Drawing.Point(0, 0);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(327, 41);
            this.aPanel1.TabIndex = 47;
            // 
            // aLabel7
            // 
            this.aLabel7.AutoSize = true;
            this.aLabel7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel7.Location = new System.Drawing.Point(43, 10);
            this.aLabel7.Name = "aLabel7";
            this.aLabel7.Size = new System.Drawing.Size(0, 21);
            this.aLabel7.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // aLabel9
            // 
            this.aLabel9.AutoSize = true;
            this.aLabel9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel9.Location = new System.Drawing.Point(49, 9);
            this.aLabel9.Name = "aLabel9";
            this.aLabel9.Size = new System.Drawing.Size(90, 21);
            this.aLabel9.TabIndex = 35;
            this.aLabel9.Text = "사용자등록";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(12, 242);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(135, 21);
            this.aLabel2.TabIndex = 3;
            this.aLabel2.Text = "*사용자 비밀번호";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.Location = new System.Drawing.Point(12, 164);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(113, 21);
            this.aLabel1.TabIndex = 3;
            this.aLabel1.Text = "*사용자아이디";
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel4.Location = new System.Drawing.Point(12, 90);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(81, 21);
            this.aLabel4.TabIndex = 3;
            this.aLabel4.Text = "*사용자명";
            // 
            // aPanel9
            // 
            this.aPanel9.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel9.Controls.Add(this.btnCencle);
            this.aPanel9.Controls.Add(this.btnSave);
            this.aPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel9.Location = new System.Drawing.Point(0, 442);
            this.aPanel9.Name = "aPanel9";
            this.aPanel9.Size = new System.Drawing.Size(327, 41);
            this.aPanel9.TabIndex = 46;
            // 
            // btnCencle
            // 
            this.btnCencle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCencle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCencle.Location = new System.Drawing.Point(246, 8);
            this.btnCencle.Name = "btnCencle";
            this.btnCencle.Size = new System.Drawing.Size(75, 23);
            this.btnCencle.TabIndex = 45;
            this.btnCencle.Text = "취소";
            this.btnCencle.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(165, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Location = new System.Drawing.Point(16, 44);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(43, 15);
            this.aLabel5.TabIndex = 43;
            this.aLabel5.Text = "담당자";
            // 
            // MSS_CON_003_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(327, 483);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.aLabel2);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.aPanel9);
            this.Controls.Add(this.aLabel5);
            this.Name = "MSS_CON_003_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사용자등록";
            this.Load += new System.EventHandler(this.MSS_CON_003_1_Load);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.aPanel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.ALabel aLabel1;
        private CustomControls.ALabel aLabel9;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ALabel aLabel4;
        private CustomControls.ALabel aLabel5;
        private CustomControls.AButton btnCencle;
        private CustomControls.APanel aPanel9;
        private CustomControls.AButton btnSave;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel aLabel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ALabel lblManager;
        private CustomControls.ALabel lblDay;
        private CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox txtName;
        private CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox txtID;
        private CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox txtPwd;
    }
}
