namespace Axxen
{
    partial class MSS_CON_001
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSS_CON_001));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aLabel7 = new Axxen.CustomControls.ALabel();
            this.panelusersetting = new Axxen.CustomControls.APanel();
            this.txtCode = new Axxen.CustomControls.ATextBox();
            this.txtName = new Axxen.CustomControls.ATextBox();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.cbbGroup = new Axxen.CustomControls.AComboBox();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.lblGroup = new Axxen.CustomControls.ALabel();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.dgvGroup = new Axxen.CustomControls.ADataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelusersetting.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 630);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // aLabel7
            // 
            this.aLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aLabel7.AutoSize = true;
            this.aLabel7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel7.Location = new System.Drawing.Point(26, 631);
            this.aLabel7.Name = "aLabel7";
            this.aLabel7.Size = new System.Drawing.Size(128, 21);
            this.aLabel7.TabIndex = 11;
            this.aLabel7.Text = "사용자 그룹설정";
            // 
            // panelusersetting
            // 
            this.panelusersetting.BackColor = System.Drawing.SystemColors.Info;
            this.panelusersetting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelusersetting.Controls.Add(this.txtCode);
            this.panelusersetting.Controls.Add(this.txtName);
            this.panelusersetting.Controls.Add(this.aLabel4);
            this.panelusersetting.Controls.Add(this.aLabel5);
            this.panelusersetting.Controls.Add(this.btnSave);
            this.panelusersetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelusersetting.Location = new System.Drawing.Point(0, 658);
            this.panelusersetting.Name = "panelusersetting";
            this.panelusersetting.Size = new System.Drawing.Size(1141, 107);
            this.panelusersetting.TabIndex = 10;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.errorp = null;
            this.txtCode.Location = new System.Drawing.Point(154, 19);
            this.txtCode.MaxLength = 20;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(196, 23);
            this.txtCode.TabIndex = 12;
            this.txtCode.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.errorp = null;
            this.txtName.Location = new System.Drawing.Point(480, 19);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 23);
            this.txtName.TabIndex = 11;
            this.txtName.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel4.Location = new System.Drawing.Point(15, 22);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(123, 17);
            this.aLabel4.TabIndex = 10;
            this.aLabel4.Text = "*사용자 그룹명코드";
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel5.Location = new System.Drawing.Point(377, 21);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(97, 17);
            this.aLabel5.TabIndex = 7;
            this.aLabel5.Text = "*사용자 그룹명";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1025, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.aLabel3);
            this.aPanel2.Controls.Add(this.aLabel2);
            this.aPanel2.Controls.Add(this.cbbGroup);
            this.aPanel2.Controls.Add(this.aPanel1);
            this.aPanel2.Controls.Add(this.btnSearch);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1141, 39);
            this.aPanel2.TabIndex = 9;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(332, 10);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(117, 17);
            this.aLabel3.TabIndex = 10;
            this.aLabel3.Text = "사용자 그룹명코드";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(15, 9);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(91, 17);
            this.aLabel2.TabIndex = 7;
            this.aLabel2.Text = "사용자 그룹명";
            // 
            // cbbGroup
            // 
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(109, 6);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(152, 23);
            this.cbbGroup.TabIndex = 3;
            this.cbbGroup.SelectedIndexChanged += new System.EventHandler(this.CbbGroup_SelectedIndexChanged);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.lblGroup);
            this.aPanel1.Location = new System.Drawing.Point(451, 6);
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
            this.btnSearch.Location = new System.Drawing.Point(649, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel1.Location = new System.Drawing.Point(37, 42);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(128, 21);
            this.aLabel1.TabIndex = 7;
            this.aLabel1.Text = "사용자 그룹목록";
            // 
            // dgvGroup
            // 
            this.dgvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(9, 66);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.Size = new System.Drawing.Size(1124, 558);
            this.dgvGroup.TabIndex = 5;
            this.dgvGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroup_CellContentClick);
            this.dgvGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroup_CellDoubleClick);
            // 
            // MSS_CON_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 765);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aLabel7);
            this.Controls.Add(this.panelusersetting);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.dgvGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MSS_CON_001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MSS_CON_001_FormClosing);
            this.Load += new System.EventHandler(this.MSS_CON_001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelusersetting.ResumeLayout(false);
            this.panelusersetting.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.AComboBox cbbGroup;
        private CustomControls.AButton btnSearch;
        private CustomControls.ADataGridView dgvGroup;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel lblGroup;
        private CustomControls.ALabel aLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel2;
        private CustomControls.APanel panelusersetting;
        private CustomControls.ALabel aLabel4;
        private CustomControls.ALabel aLabel5;
        private CustomControls.AButton btnSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ALabel aLabel7;
        private CustomControls.ATextBox txtCode;
        private CustomControls.ATextBox txtName;
    }
}