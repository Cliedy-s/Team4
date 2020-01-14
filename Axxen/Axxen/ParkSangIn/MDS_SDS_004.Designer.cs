namespace Axxen
{
    partial class MDS_SDS_004
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDS_SDS_004));
            this.dgvGroup = new Axxen.CustomControls.ADataGridView();
            this.cbbGroup = new Axxen.CustomControls.AComboBox();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.lblGroup = new Axxen.CustomControls.ALabel();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.aLabel6 = new Axxen.CustomControls.ALabel();
            this.aLabel7 = new Axxen.CustomControls.ALabel();
            this.aLabel8 = new Axxen.CustomControls.ALabel();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroup
            // 
            this.dgvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(0, 45);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.Size = new System.Drawing.Size(1148, 291);
            this.dgvGroup.TabIndex = 24;
            // 
            // cbbGroup
            // 
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(109, 6);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(152, 23);
            this.cbbGroup.TabIndex = 3;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.lblGroup);
            this.aPanel1.Location = new System.Drawing.Point(316, 6);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(165, 24);
            this.aPanel1.TabIndex = 6;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGroup.Location = new System.Drawing.Point(3, 3);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(53, 17);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "aLabel1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(784, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.aLabel5);
            this.aPanel2.Controls.Add(this.aLabel3);
            this.aPanel2.Controls.Add(this.aPanel3);
            this.aPanel2.Controls.Add(this.aLabel2);
            this.aPanel2.Controls.Add(this.cbbGroup);
            this.aPanel2.Controls.Add(this.aPanel1);
            this.aPanel2.Controls.Add(this.btnSearch);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1148, 39);
            this.aPanel2.TabIndex = 27;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(263, 10);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(60, 17);
            this.aLabel3.TabIndex = 10;
            this.aLabel3.Text = "사용유무";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(15, 9);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(72, 17);
            this.aLabel2.TabIndex = 7;
            this.aLabel2.Text = "EtherIO 명";
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(68, 148);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(735, 15);
            this.aLabel4.TabIndex = 28;
            this.aLabel4.Text = "GRID : 그룹코드 / 그룹명 / Level 1 / Level 2 / Level 3 / Level 4 / Level 5 / Level 6 / P" +
    "/L당 BOX 수량 / BOX당 PCS 수량 / PCS당 소재량";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel1.Location = new System.Drawing.Point(37, 3);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(128, 21);
            this.aLabel1.TabIndex = 25;
            this.aLabel1.Text = "사용자 그룹목록";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel5.Location = new System.Drawing.Point(495, 12);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(71, 17);
            this.aLabel5.TabIndex = 30;
            this.aLabel5.Text = "EtherIO IP";
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.Color.White;
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel3.Controls.Add(this.aLabel6);
            this.aPanel3.Location = new System.Drawing.Point(548, 8);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(165, 24);
            this.aPanel3.TabIndex = 29;
            // 
            // aLabel6
            // 
            this.aLabel6.AutoSize = true;
            this.aLabel6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel6.Location = new System.Drawing.Point(12, 3);
            this.aLabel6.Name = "aLabel6";
            this.aLabel6.Size = new System.Drawing.Size(53, 17);
            this.aLabel6.TabIndex = 0;
            this.aLabel6.Text = "aLabel1";
            // 
            // aLabel7
            // 
            this.aLabel7.AutoSize = true;
            this.aLabel7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel7.Location = new System.Drawing.Point(38, 109);
            this.aLabel7.Name = "aLabel7";
            this.aLabel7.Size = new System.Drawing.Size(398, 17);
            this.aLabel7.TabIndex = 31;
            this.aLabel7.Text = "GRID : EtherIO 코드 / EtherIO 명 / EtherIO IP / 사용유무 / 비고";
            // 
            // aLabel8
            // 
            this.aLabel8.AutoSize = true;
            this.aLabel8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel8.Location = new System.Drawing.Point(38, 418);
            this.aLabel8.Name = "aLabel8";
            this.aLabel8.Size = new System.Drawing.Size(398, 17);
            this.aLabel8.TabIndex = 33;
            this.aLabel8.Text = "GRID : EtherIO 코드 / EtherIO 명 / EtherIO IP / 사용유무 / 비고";
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(0, 354);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(1148, 291);
            this.aDataGridView1.TabIndex = 32;
            // 
            // MDS_SDS_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Controls.Add(this.aLabel8);
            this.Controls.Add(this.aDataGridView1);
            this.Controls.Add(this.aLabel7);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MDS_SDS_004";
            this.Text = "EtherIO 정보";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aPanel3.ResumeLayout(false);
            this.aPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ADataGridView dgvGroup;
        private CustomControls.AComboBox cbbGroup;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel lblGroup;
        private CustomControls.AButton btnSearch;
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ALabel aLabel4;
        private CustomControls.ALabel aLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.ALabel aLabel5;
        private CustomControls.APanel aPanel3;
        private CustomControls.ALabel aLabel6;
        private CustomControls.ALabel aLabel7;
        private CustomControls.ALabel aLabel8;
        private CustomControls.ADataGridView aDataGridView1;
    }
}
