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
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.panTop = new Axxen.CustomControls.APanel();
            this.aHeaderBox1 = new Axxen.CustomControls.AHeaderBox();
            this.dgvMainGrid = new Axxen.CustomControls.ADataGridView();
            this.aHeaderBox2 = new Axxen.CustomControls.AHeaderBox();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.aHeaderBox3 = new Axxen.CustomControls.AHeaderBox();
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
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.panelNopMaMaste.SuspendLayout();
            this.aPanel6.SuspendLayout();
            this.aPanel7.SuspendLayout();
            this.aPanel5.SuspendLayout();
            this.aPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Users;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "사용자 그룹";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(23, 22);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(293, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 9;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
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
            this.panTop.Size = new System.Drawing.Size(1204, 74);
            this.panTop.TabIndex = 6;
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox1.HeaderBoxText = "HeaderText";
            this.aHeaderBox1.Location = new System.Drawing.Point(0, 79);
            this.aHeaderBox1.Name = "aHeaderBox1";
            this.aHeaderBox1.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox1.TabIndex = 8;
            // 
            // dgvMainGrid
            // 
            this.dgvMainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMainGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainGrid.Location = new System.Drawing.Point(0, 108);
            this.dgvMainGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMainGrid.Name = "dgvMainGrid";
            this.dgvMainGrid.RowTemplate.Height = 23;
            this.dgvMainGrid.Size = new System.Drawing.Size(334, 474);
            this.dgvMainGrid.TabIndex = 7;
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox2.HeaderBoxText = "HeaderText";
            this.aHeaderBox2.Location = new System.Drawing.Point(340, 80);
            this.aHeaderBox2.Name = "aHeaderBox2";
            this.aHeaderBox2.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox2.TabIndex = 10;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(340, 109);
            this.aDataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(850, 473);
            this.aDataGridView1.TabIndex = 9;
            // 
            // aHeaderBox3
            // 
            this.aHeaderBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aHeaderBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox3.HeaderBoxText = "비가동 설정";
            this.aHeaderBox3.Location = new System.Drawing.Point(0, 585);
            this.aHeaderBox3.Name = "aHeaderBox3";
            this.aHeaderBox3.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox3.TabIndex = 17;
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
            this.panelNopMaMaste.Location = new System.Drawing.Point(0, 614);
            this.panelNopMaMaste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNopMaMaste.Name = "panelNopMaMaste";
            this.panelNopMaMaste.Size = new System.Drawing.Size(1204, 76);
            this.panelNopMaMaste.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1111, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 33);
            this.btnSave.TabIndex = 210;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
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
            // MDS_CDS_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1204, 690);
            this.Controls.Add(this.aHeaderBox3);
            this.Controls.Add(this.panelNopMaMaste);
            this.Controls.Add(this.aHeaderBox2);
            this.Controls.Add(this.aDataGridView1);
            this.Controls.Add(this.aHeaderBox1);
            this.Controls.Add(this.dgvMainGrid);
            this.Controls.Add(this.panTop);
            this.Name = "MDS_CDS_004";
            this.Text = "비가동상세분류";
            this.panTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
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

        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.AButton btnSearch;
        protected CustomControls.APanel panTop;
        protected CustomControls.AHeaderBox aHeaderBox1;
        protected CustomControls.ADataGridView dgvMainGrid;
        protected CustomControls.AHeaderBox aHeaderBox2;
        protected CustomControls.ADataGridView aDataGridView1;
        protected CustomControls.AHeaderBox aHeaderBox3;
        protected CustomControls.APanel panelNopMaMaste;
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
