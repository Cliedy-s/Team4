namespace Axxen
{
    partial class MDS_CDS_003
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
            this.panTop = new Axxen.CustomControls.APanel();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.cbbGroup = new Axxen.CustomControls.AComboBox();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.lblGroup = new Axxen.CustomControls.ALabel();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aHeaderBox1 = new Axxen.CustomControls.AHeaderBox();
            this.dgvGroup = new Axxen.CustomControls.ADataGridView();
            this.panelNopMaMaste = new Axxen.CustomControls.APanel();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.txtCode = new Axxen.CustomControls.ATextBox();
            this.aPanel7 = new Axxen.CustomControls.APanel();
            this.aLabel10 = new Axxen.CustomControls.ALabel();
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.txtName = new Axxen.CustomControls.ATextBox();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.aLabel9 = new Axxen.CustomControls.ALabel();
            this.aHeaderBox2 = new Axxen.CustomControls.AHeaderBox();
            this.panTop.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.panelNopMaMaste.SuspendLayout();
            this.aPanel6.SuspendLayout();
            this.aPanel7.SuspendLayout();
            this.aPanel5.SuspendLayout();
            this.aPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panTop.Controls.Add(this.aLabel3);
            this.panTop.Controls.Add(this.aLabel2);
            this.panTop.Controls.Add(this.cbbGroup);
            this.panTop.Controls.Add(this.aPanel2);
            this.panTop.Controls.Add(this.btnSearch);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1148, 74);
            this.panTop.TabIndex = 5;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(17, 32);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(104, 17);
            this.aLabel3.TabIndex = 20;
            this.aLabel3.Text = "비가동대분류 명";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(319, 32);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(117, 17);
            this.aLabel2.TabIndex = 19;
            this.aLabel2.Text = "비가동대분류 코드";
            // 
            // cbbGroup
            // 
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(140, 30);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(152, 23);
            this.cbbGroup.TabIndex = 16;
            this.cbbGroup.SelectedIndexChanged += new System.EventHandler(this.CbbGroup_SelectedIndexChanged);
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.White;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel2.Controls.Add(this.lblGroup);
            this.aPanel2.Location = new System.Drawing.Point(455, 27);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(165, 24);
            this.aPanel2.TabIndex = 18;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroup.Location = new System.Drawing.Point(3, 2);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(53, 17);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "aLabel1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(641, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox1.HeaderBoxText = "비가동대분류 목록";
            this.aHeaderBox1.Location = new System.Drawing.Point(0, 80);
            this.aHeaderBox1.Name = "aHeaderBox1";
            this.aHeaderBox1.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox1.TabIndex = 8;
            // 
            // dgvGroup
            // 
            this.dgvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(-4, 110);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.Size = new System.Drawing.Size(1148, 556);
            this.dgvGroup.TabIndex = 15;
            this.dgvGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroup_CellContentClick);
            this.dgvGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroup_CellDoubleClick);
            // 
            // panelNopMaMaste
            // 
            this.panelNopMaMaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNopMaMaste.Controls.Add(this.btnSave);
            this.panelNopMaMaste.Controls.Add(this.aPanel6);
            this.panelNopMaMaste.Controls.Add(this.aPanel7);
            this.panelNopMaMaste.Controls.Add(this.aPanel5);
            this.panelNopMaMaste.Controls.Add(this.aPanel4);
            this.panelNopMaMaste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNopMaMaste.Location = new System.Drawing.Point(0, 701);
            this.panelNopMaMaste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNopMaMaste.Name = "panelNopMaMaste";
            this.panelNopMaMaste.Size = new System.Drawing.Size(1148, 76);
            this.panelNopMaMaste.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1055, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 33);
            this.btnSave.TabIndex = 210;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // aPanel6
            // 
            this.aPanel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel6.Controls.Add(this.txtCode);
            this.aPanel6.Location = new System.Drawing.Point(126, 6);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(172, 35);
            this.aPanel6.TabIndex = 212;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.errorp = null;
            this.txtCode.Location = new System.Drawing.Point(3, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(160, 23);
            this.txtCode.TabIndex = 24;
            this.txtCode.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel7
            // 
            this.aPanel7.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel7.Controls.Add(this.aLabel10);
            this.aPanel7.Location = new System.Drawing.Point(4, 6);
            this.aPanel7.Name = "aPanel7";
            this.aPanel7.Size = new System.Drawing.Size(120, 35);
            this.aPanel7.TabIndex = 211;
            // 
            // aLabel10
            // 
            this.aLabel10.AutoSize = true;
            this.aLabel10.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aLabel10.Location = new System.Drawing.Point(1, 8);
            this.aLabel10.Name = "aLabel10";
            this.aLabel10.Size = new System.Drawing.Size(118, 17);
            this.aLabel10.TabIndex = 55;
            this.aLabel10.Text = "*비가동대분류코드";
            // 
            // aPanel5
            // 
            this.aPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel5.Controls.Add(this.txtName);
            this.aPanel5.Location = new System.Drawing.Point(426, 6);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(172, 35);
            this.aPanel5.TabIndex = 214;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.errorp = null;
            this.txtName.Location = new System.Drawing.Point(4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 25;
            this.txtName.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel4
            // 
            this.aPanel4.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel4.Controls.Add(this.aLabel9);
            this.aPanel4.Location = new System.Drawing.Point(304, 6);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(120, 35);
            this.aPanel4.TabIndex = 213;
            // 
            // aLabel9
            // 
            this.aLabel9.AutoSize = true;
            this.aLabel9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aLabel9.Location = new System.Drawing.Point(3, 8);
            this.aLabel9.Name = "aLabel9";
            this.aLabel9.Size = new System.Drawing.Size(105, 17);
            this.aLabel9.TabIndex = 54;
            this.aLabel9.Text = "*비가동대분류명";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aHeaderBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox2.HeaderBoxText = "비가동 설정";
            this.aHeaderBox2.Location = new System.Drawing.Point(0, 672);
            this.aHeaderBox2.Name = "aHeaderBox2";
            this.aHeaderBox2.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox2.TabIndex = 10;
            // 
            // MDS_CDS_003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 777);
            this.Controls.Add(this.aHeaderBox2);
            this.Controls.Add(this.panelNopMaMaste);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.aHeaderBox1);
            this.Controls.Add(this.panTop);
            this.Name = "MDS_CDS_003";
            this.Text = "비가동대분류";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDS_CDS_003_FormClosing);
            this.Load += new System.EventHandler(this.MDS_CDS_003_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.panelNopMaMaste.ResumeLayout(false);
            this.aPanel6.ResumeLayout(false);
            this.aPanel6.PerformLayout();
            this.aPanel7.ResumeLayout(false);
            this.aPanel7.PerformLayout();
            this.aPanel5.ResumeLayout(false);
            this.aPanel5.PerformLayout();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected CustomControls.APanel panTop;
        protected CustomControls.AHeaderBox aHeaderBox1;
        private CustomControls.ADataGridView dgvGroup;
        protected CustomControls.APanel panelNopMaMaste;
        protected CustomControls.AHeaderBox aHeaderBox2;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel2;
        private CustomControls.AComboBox cbbGroup;
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel lblGroup;
        private CustomControls.AButton btnSearch;
        private CustomControls.AButton btnSave;
        private CustomControls.APanel aPanel6;
        private CustomControls.ATextBox txtCode;
        private CustomControls.APanel aPanel7;
        private CustomControls.ALabel aLabel10;
        private CustomControls.APanel aPanel5;
        private CustomControls.ATextBox txtName;
        private CustomControls.APanel aPanel4;
        private CustomControls.ALabel aLabel9;
    }
}
