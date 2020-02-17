namespace Axxen
{
    partial class MSS_SYS_004
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSS_SYS_004));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.cbbScreen = new Axxen.CustomControls.AComboBox();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.dtpEnd = new Axxen.CustomControls.ADateTimePicker();
            this.dtpstart = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.cbbUser = new Axxen.CustomControls.AComboBox();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.dgvGroup = new Axxen.CustomControls.ADataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.aLabel5);
            this.aPanel2.Controls.Add(this.cbbScreen);
            this.aPanel2.Controls.Add(this.aLabel1);
            this.aPanel2.Controls.Add(this.dtpEnd);
            this.aPanel2.Controls.Add(this.dtpstart);
            this.aPanel2.Controls.Add(this.aLabel2);
            this.aPanel2.Controls.Add(this.cbbUser);
            this.aPanel2.Controls.Add(this.btnSearch);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1148, 51);
            this.aPanel2.TabIndex = 16;
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel5.Location = new System.Drawing.Point(709, 16);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(47, 17);
            this.aLabel5.TabIndex = 20;
            this.aLabel5.Text = "화면명";
            // 
            // cbbScreen
            // 
            this.cbbScreen.FormattingEnabled = true;
            this.cbbScreen.Location = new System.Drawing.Point(762, 13);
            this.cbbScreen.Name = "cbbScreen";
            this.cbbScreen.Size = new System.Drawing.Size(149, 23);
            this.cbbScreen.TabIndex = 19;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.Location = new System.Drawing.Point(229, 15);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(17, 17);
            this.aLabel1.TabIndex = 17;
            this.aLabel1.Text = "~";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(248, 12);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 23);
            this.dtpEnd.TabIndex = 18;
            this.dtpEnd.Value = new System.DateTime(2020, 2, 17, 13, 56, 25, 0);
            // 
            // dtpstart
            // 
            this.dtpstart.Location = new System.Drawing.Point(25, 12);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(200, 23);
            this.dtpstart.TabIndex = 17;
            this.dtpstart.Value = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(482, 16);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(60, 17);
            this.aLabel2.TabIndex = 7;
            this.aLabel2.Text = "사용자명";
            // 
            // cbbUser
            // 
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(543, 13);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(149, 23);
            this.cbbUser.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1056, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel4.Location = new System.Drawing.Point(33, 56);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(128, 21);
            this.aLabel4.TabIndex = 14;
            this.aLabel4.Text = "로그인 이력목록";
            // 
            // dgvGroup
            // 
            this.dgvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(8, 83);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.Size = new System.Drawing.Size(1128, 614);
            this.dgvGroup.TabIndex = 10;
            // 
            // MSS_SYS_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.dgvGroup);
            this.Name = "MSS_SYS_004";
            this.Text = "";
            this.Load += new System.EventHandler(this.MSS_SYS_004_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ADataGridView dgvGroup;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ALabel aLabel4;
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel5;
        private CustomControls.AComboBox cbbScreen;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ADateTimePicker dtpEnd;
        private CustomControls.ADateTimePicker dtpstart;
        private CustomControls.ALabel aLabel2;
        private CustomControls.AComboBox cbbUser;
        private CustomControls.AButton btnSearch;
    }
}
