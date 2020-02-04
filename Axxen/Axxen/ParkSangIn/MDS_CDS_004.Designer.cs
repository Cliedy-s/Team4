namespace Axxen
{
    partial class MDS_CDS_004
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
            this.aHeaderBox3 = new Axxen.CustomControls.AHeaderBox();
            this.panelNopMaMaste = new Axxen.CustomControls.APanel();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.txtremark = new Axxen.CustomControls.ATextBox();
            this.aPanel8 = new Axxen.CustomControls.APanel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.txtName = new Axxen.CustomControls.ATextBox();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aLabel9 = new Axxen.CustomControls.ALabel();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.txtACode = new Axxen.CustomControls.ATextBox();
            this.aPanel7 = new Axxen.CustomControls.APanel();
            this.aLabel10 = new Axxen.CustomControls.ALabel();
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.txtICode = new Axxen.CustomControls.ATextBox();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aHeaderBox2 = new Axxen.CustomControls.AHeaderBox();
            this.dgvMi = new Axxen.CustomControls.ADataGridView();
            this.aHeaderBox1 = new Axxen.CustomControls.AHeaderBox();
            this.dgvMa = new Axxen.CustomControls.ADataGridView();
            this.panTop = new Axxen.CustomControls.APanel();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.panelNopMaMaste.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.aPanel8.SuspendLayout();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel6.SuspendLayout();
            this.aPanel7.SuspendLayout();
            this.aPanel5.SuspendLayout();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMa)).BeginInit();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // aHeaderBox3
            // 
            this.aHeaderBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aHeaderBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox3.HeaderBoxText = "비가동 설정";
            this.aHeaderBox3.Location = new System.Drawing.Point(0, 671);
            this.aHeaderBox3.Name = "aHeaderBox3";
            this.aHeaderBox3.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox3.TabIndex = 17;
            // 
            // panelNopMaMaste
            // 
            this.panelNopMaMaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNopMaMaste.Controls.Add(this.aPanel3);
            this.panelNopMaMaste.Controls.Add(this.aPanel8);
            this.panelNopMaMaste.Controls.Add(this.aPanel1);
            this.panelNopMaMaste.Controls.Add(this.aPanel2);
            this.panelNopMaMaste.Controls.Add(this.btnSave);
            this.panelNopMaMaste.Controls.Add(this.aPanel6);
            this.panelNopMaMaste.Controls.Add(this.aPanel7);
            this.panelNopMaMaste.Controls.Add(this.aPanel5);
            this.panelNopMaMaste.Controls.Add(this.aPanel4);
            this.panelNopMaMaste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNopMaMaste.Location = new System.Drawing.Point(0, 700);
            this.panelNopMaMaste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNopMaMaste.Name = "panelNopMaMaste";
            this.panelNopMaMaste.Size = new System.Drawing.Size(1228, 118);
            this.panelNopMaMaste.TabIndex = 18;
            // 
            // aPanel3
            // 
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel3.Controls.Add(this.txtremark);
            this.aPanel3.Location = new System.Drawing.Point(422, 6);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(428, 98);
            this.aPanel3.TabIndex = 218;
            // 
            // txtremark
            // 
            this.txtremark.BackColor = System.Drawing.Color.White;
            this.txtremark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtremark.errorp = null;
            this.txtremark.Location = new System.Drawing.Point(4, 4);
            this.txtremark.MaxLength = 100;
            this.txtremark.Multiline = true;
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(417, 87);
            this.txtremark.TabIndex = 25;
            this.txtremark.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel8
            // 
            this.aPanel8.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel8.Controls.Add(this.aLabel2);
            this.aPanel8.Location = new System.Drawing.Point(300, 6);
            this.aPanel8.Name = "aPanel8";
            this.aPanel8.Size = new System.Drawing.Size(120, 35);
            this.aPanel8.TabIndex = 217;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aLabel2.Location = new System.Drawing.Point(8, 8);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(34, 17);
            this.aLabel2.TabIndex = 54;
            this.aLabel2.Text = "비고";
            // 
            // aPanel1
            // 
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel1.Controls.Add(this.txtName);
            this.aPanel1.Location = new System.Drawing.Point(126, 78);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(172, 35);
            this.aPanel1.TabIndex = 216;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.errorp = null;
            this.txtName.Location = new System.Drawing.Point(4, 4);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 23);
            this.txtName.TabIndex = 25;
            this.txtName.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.aLabel9);
            this.aPanel2.Location = new System.Drawing.Point(4, 78);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(120, 35);
            this.aPanel2.TabIndex = 215;
            // 
            // aLabel9
            // 
            this.aLabel9.AutoSize = true;
            this.aLabel9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aLabel9.Location = new System.Drawing.Point(0, 7);
            this.aLabel9.Name = "aLabel9";
            this.aLabel9.Size = new System.Drawing.Size(118, 17);
            this.aLabel9.TabIndex = 54;
            this.aLabel9.Text = "*비가동상세분류명";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1134, 72);
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
            this.aPanel6.Controls.Add(this.txtACode);
            this.aPanel6.Location = new System.Drawing.Point(126, 6);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(172, 35);
            this.aPanel6.TabIndex = 212;
            // 
            // txtACode
            // 
            this.txtACode.BackColor = System.Drawing.Color.White;
            this.txtACode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtACode.Enabled = false;
            this.txtACode.errorp = null;
            this.txtACode.Location = new System.Drawing.Point(3, 5);
            this.txtACode.MaxLength = 20;
            this.txtACode.Name = "txtACode";
            this.txtACode.Size = new System.Drawing.Size(160, 23);
            this.txtACode.TabIndex = 24;
            this.txtACode.txtType = Axxen.CustomControls.TextType.Normal;
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
            this.aPanel5.Controls.Add(this.txtICode);
            this.aPanel5.Location = new System.Drawing.Point(126, 42);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(172, 35);
            this.aPanel5.TabIndex = 214;
            // 
            // txtICode
            // 
            this.txtICode.BackColor = System.Drawing.Color.White;
            this.txtICode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtICode.errorp = null;
            this.txtICode.Location = new System.Drawing.Point(4, 4);
            this.txtICode.MaxLength = 20;
            this.txtICode.Name = "txtICode";
            this.txtICode.Size = new System.Drawing.Size(160, 23);
            this.txtICode.TabIndex = 25;
            this.txtICode.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel4
            // 
            this.aPanel4.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel4.Controls.Add(this.aLabel1);
            this.aPanel4.Location = new System.Drawing.Point(4, 42);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(120, 35);
            this.aPanel4.TabIndex = 213;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aLabel1.Location = new System.Drawing.Point(8, 8);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(105, 17);
            this.aLabel1.TabIndex = 54;
            this.aLabel1.Text = "*비가동상세코드";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox2.HeaderBoxText = "비가동상세분류";
            this.aHeaderBox2.Location = new System.Drawing.Point(457, 79);
            this.aHeaderBox2.Name = "aHeaderBox2";
            this.aHeaderBox2.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox2.TabIndex = 10;
            // 
            // dgvMi
            // 
            this.dgvMi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMi.BackgroundColor = System.Drawing.Color.White;
            this.dgvMi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMi.Location = new System.Drawing.Point(457, 109);
            this.dgvMi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMi.Name = "dgvMi";
            this.dgvMi.RowTemplate.Height = 23;
            this.dgvMi.Size = new System.Drawing.Size(757, 560);
            this.dgvMi.TabIndex = 9;
            this.dgvMi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMi_CellContentClick);
            this.dgvMi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMi_CellDoubleClick);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox1.HeaderBoxText = "비가동대분류";
            this.aHeaderBox1.Location = new System.Drawing.Point(0, 79);
            this.aHeaderBox1.Name = "aHeaderBox1";
            this.aHeaderBox1.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox1.TabIndex = 8;
            // 
            // dgvMa
            // 
            this.dgvMa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMa.BackgroundColor = System.Drawing.Color.White;
            this.dgvMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMa.Location = new System.Drawing.Point(0, 108);
            this.dgvMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMa.Name = "dgvMa";
            this.dgvMa.RowTemplate.Height = 23;
            this.dgvMa.Size = new System.Drawing.Size(451, 561);
            this.dgvMa.TabIndex = 7;
            this.dgvMa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMa_CellDoubleClick);
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panTop.Controls.Add(this.btnSearch);
            this.panTop.Controls.Add(this.aTextBox_FindNameByCode1);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1228, 74);
            this.panTop.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(341, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 30);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.NonOperations;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "비가동 대분류";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(23, 22);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(293, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 9;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            // 
            // MDS_CDS_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1228, 818);
            this.Controls.Add(this.aHeaderBox3);
            this.Controls.Add(this.panelNopMaMaste);
            this.Controls.Add(this.aHeaderBox2);
            this.Controls.Add(this.dgvMi);
            this.Controls.Add(this.aHeaderBox1);
            this.Controls.Add(this.dgvMa);
            this.Controls.Add(this.panTop);
            this.Name = "MDS_CDS_004";
            this.Text = "비가동상세분류";
            this.Load += new System.EventHandler(this.MDS_CDS_004_Load);
            this.panelNopMaMaste.ResumeLayout(false);
            this.aPanel3.ResumeLayout(false);
            this.aPanel3.PerformLayout();
            this.aPanel8.ResumeLayout(false);
            this.aPanel8.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel6.ResumeLayout(false);
            this.aPanel6.PerformLayout();
            this.aPanel7.ResumeLayout(false);
            this.aPanel7.PerformLayout();
            this.aPanel5.ResumeLayout(false);
            this.aPanel5.PerformLayout();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMa)).EndInit();
            this.panTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.AButton btnSearch;
        protected CustomControls.APanel panTop;
        protected CustomControls.AHeaderBox aHeaderBox1;
        protected CustomControls.ADataGridView dgvMa;
        protected CustomControls.AHeaderBox aHeaderBox2;
        protected CustomControls.ADataGridView dgvMi;
        protected CustomControls.AHeaderBox aHeaderBox3;
        protected CustomControls.APanel panelNopMaMaste;
        private CustomControls.AButton btnSave;
        private CustomControls.APanel aPanel6;
        private CustomControls.ATextBox txtACode;
        private CustomControls.APanel aPanel7;
        private CustomControls.ALabel aLabel10;
        private CustomControls.APanel aPanel5;
        private CustomControls.ATextBox txtICode;
        private CustomControls.APanel aPanel4;
        private CustomControls.ALabel aLabel9;
        private CustomControls.APanel aPanel1;
        private CustomControls.ATextBox txtName;
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel1;
        private CustomControls.APanel aPanel3;
        private CustomControls.ATextBox txtremark;
        private CustomControls.APanel aPanel8;
        private CustomControls.ALabel aLabel2;
    }
}
