namespace Axxen
{
    partial class MSS_CON_003
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSS_CON_003));
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.cbbUser = new Axxen.CustomControls.AComboBox();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.lblUser = new Axxen.CustomControls.ALabel();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.dgvGroup = new Axxen.CustomControls.ADataGridView();
            this.dgvUser = new Axxen.CustomControls.ADataGridView();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvJoin = new Axxen.CustomControls.ADataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.aLabel6 = new Axxen.CustomControls.ALabel();
            this.aLabel7 = new Axxen.CustomControls.ALabel();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.aPanel2.SuspendLayout();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.aLabel3);
            this.aPanel2.Controls.Add(this.aLabel4);
            this.aPanel2.Controls.Add(this.cbbUser);
            this.aPanel2.Controls.Add(this.aPanel1);
            this.aPanel2.Controls.Add(this.btnSearch);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1288, 38);
            this.aPanel2.TabIndex = 21;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(307, 10);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(78, 17);
            this.aLabel3.TabIndex = 10;
            this.aLabel3.Text = "사용자 코드";
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel4.Location = new System.Drawing.Point(15, 9);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(60, 17);
            this.aLabel4.TabIndex = 7;
            this.aLabel4.Text = "사용자명";
            // 
            // cbbUser
            // 
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(109, 6);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(179, 23);
            this.cbbUser.TabIndex = 3;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel1.Controls.Add(this.lblUser);
            this.aPanel1.Location = new System.Drawing.Point(426, 6);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(220, 24);
            this.aPanel1.TabIndex = 6;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUser.Location = new System.Drawing.Point(3, 3);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "aLabel1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(655, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel2.Location = new System.Drawing.Point(440, 52);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(0, 21);
            this.aLabel2.TabIndex = 19;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel1.Location = new System.Drawing.Point(42, 52);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(90, 21);
            this.aLabel1.TabIndex = 17;
            this.aLabel1.Text = "사용자목록";
            // 
            // dgvGroup
            // 
            this.dgvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(412, 79);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.Size = new System.Drawing.Size(320, 509);
            this.dgvGroup.TabIndex = 16;
            this.dgvGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroup_CellDoubleClick);
            // 
            // dgvUser
            // 
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(12, 79);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(394, 509);
            this.dgvUser.TabIndex = 15;
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel5.Location = new System.Drawing.Point(444, 51);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(122, 21);
            this.aLabel5.TabIndex = 22;
            this.aLabel5.Text = "사용자그룹목록";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dgvJoin
            // 
            this.dgvJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJoin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJoin.Location = new System.Drawing.Point(738, 79);
            this.dgvJoin.Name = "dgvJoin";
            this.dgvJoin.RowTemplate.Height = 23;
            this.dgvJoin.Size = new System.Drawing.Size(550, 509);
            this.dgvJoin.TabIndex = 23;
            this.dgvJoin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJoin_CellDoubleClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(765, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // aLabel6
            // 
            this.aLabel6.AutoSize = true;
            this.aLabel6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel6.Location = new System.Drawing.Point(790, 52);
            this.aLabel6.Name = "aLabel6";
            this.aLabel6.Size = new System.Drawing.Size(0, 21);
            this.aLabel6.TabIndex = 24;
            // 
            // aLabel7
            // 
            this.aLabel7.AutoSize = true;
            this.aLabel7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel7.Location = new System.Drawing.Point(794, 51);
            this.aLabel7.Name = "aLabel7";
            this.aLabel7.Size = new System.Drawing.Size(192, 21);
            this.aLabel7.TabIndex = 26;
            this.aLabel7.Text = "사용자그룹별 사용자목록";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1201, 49);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // MSS_CON_003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1288, 594);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.aLabel6);
            this.Controls.Add(this.aLabel7);
            this.Controls.Add(this.dgvJoin);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.aLabel5);
            this.Name = "MSS_CON_003";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MSS_CON_003_FormClosed);
            this.Load += new System.EventHandler(this.MSS_CON_003_Load);
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel4;
        private CustomControls.AComboBox cbbUser;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel lblUser;
        private CustomControls.AButton btnSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ALabel aLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ADataGridView dgvGroup;
        private CustomControls.ADataGridView dgvUser;
        private CustomControls.ALabel aLabel5;
        private CustomControls.ADataGridView dgvJoin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.ALabel aLabel6;
        private CustomControls.ALabel aLabel7;
        private CustomControls.AButton btnSave;
    }
}
