namespace Axxen
{
    partial class MDS_ODS_002
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDS_ODS_002));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.dgvWork = new Axxen.CustomControls.ADataGridView();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.rdoprocess = new System.Windows.Forms.RadioButton();
            this.rdowork = new System.Windows.Forms.RadioButton();
            this.aBigTextBox_FindNameByCode1 = new Axxen.CustomControls.ABigTextBox_FindNameByCode();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.cbbwork = new Axxen.CustomControls.AComboBox();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.lblwork = new Axxen.CustomControls.ALabel();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.aPanel2.SuspendLayout();
            this.aPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel4.Location = new System.Drawing.Point(35, 47);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(96, 21);
            this.aLabel4.TabIndex = 16;
            this.aLabel4.Text = "작업장 목록";
            // 
            // dgvWork
            // 
            this.dgvWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Location = new System.Drawing.Point(3, 74);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.RowTemplate.Height = 23;
            this.dgvWork.Size = new System.Drawing.Size(1182, 685);
            this.dgvWork.TabIndex = 10;
            this.dgvWork.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvWork_CellContentClick);
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.rdoprocess);
            this.aPanel2.Controls.Add(this.rdowork);
            this.aPanel2.Controls.Add(this.aBigTextBox_FindNameByCode1);
            this.aPanel2.Controls.Add(this.aLabel3);
            this.aPanel2.Controls.Add(this.aLabel2);
            this.aPanel2.Controls.Add(this.cbbwork);
            this.aPanel2.Controls.Add(this.aPanel1);
            this.aPanel2.Controls.Add(this.btnSearch);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1185, 44);
            this.aPanel2.TabIndex = 13;
            // 
            // rdoprocess
            // 
            this.rdoprocess.AutoSize = true;
            this.rdoprocess.Location = new System.Drawing.Point(642, 16);
            this.rdoprocess.Name = "rdoprocess";
            this.rdoprocess.Size = new System.Drawing.Size(14, 13);
            this.rdoprocess.TabIndex = 20;
            this.rdoprocess.UseVisualStyleBackColor = true;
            this.rdoprocess.CheckedChanged += new System.EventHandler(this.Rdoprocess_CheckedChanged);
            // 
            // rdowork
            // 
            this.rdowork.AutoSize = true;
            this.rdowork.Checked = true;
            this.rdowork.Location = new System.Drawing.Point(55, 15);
            this.rdowork.Name = "rdowork";
            this.rdowork.Size = new System.Drawing.Size(14, 13);
            this.rdowork.TabIndex = 19;
            this.rdowork.TabStop = true;
            this.rdowork.UseVisualStyleBackColor = true;
            this.rdowork.CheckedChanged += new System.EventHandler(this.Rdoprocess_CheckedChanged);
            // 
            // aBigTextBox_FindNameByCode1
            // 
            this.aBigTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Processes;
            this.aBigTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_FindNameByCode1.lblNameText = "공정";
            this.aBigTextBox_FindNameByCode1.Location = new System.Drawing.Point(662, 1);
            this.aBigTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_FindNameByCode1.Name = "aBigTextBox_FindNameByCode1";
            this.aBigTextBox_FindNameByCode1.Size = new System.Drawing.Size(303, 38);
            this.aBigTextBox_FindNameByCode1.TabIndex = 18;
            this.aBigTextBox_FindNameByCode1.txtCodeText = "";
            this.aBigTextBox_FindNameByCode1.txtNameText = "";
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(309, 12);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(73, 17);
            this.aLabel3.TabIndex = 10;
            this.aLabel3.Text = "작업장코드";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(75, 12);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(60, 17);
            this.aLabel2.TabIndex = 7;
            this.aLabel2.Text = "작업장명";
            // 
            // cbbwork
            // 
            this.cbbwork.FormattingEnabled = true;
            this.cbbwork.Location = new System.Drawing.Point(141, 10);
            this.cbbwork.Name = "cbbwork";
            this.cbbwork.Size = new System.Drawing.Size(152, 23);
            this.cbbwork.TabIndex = 3;
            this.cbbwork.SelectedIndexChanged += new System.EventHandler(this.Cbbwork_SelectedIndexChanged);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.lblwork);
            this.aPanel1.Location = new System.Drawing.Point(388, 8);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(165, 24);
            this.aPanel1.TabIndex = 6;
            // 
            // lblwork
            // 
            this.lblwork.AutoSize = true;
            this.lblwork.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblwork.Location = new System.Drawing.Point(3, 3);
            this.lblwork.Name = "lblwork";
            this.lblwork.Size = new System.Drawing.Size(53, 17);
            this.lblwork.TabIndex = 0;
            this.lblwork.Text = "aLabel1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1096, 8);
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
            this.aLabel1.Location = new System.Drawing.Point(37, 13);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(128, 21);
            this.aLabel1.TabIndex = 11;
            this.aLabel1.Text = "사용자 그룹목록";
            // 
            // MDS_ODS_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1185, 762);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.dgvWork);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MDS_ODS_002";
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDS_ODS_002_FormClosing);
            this.Load += new System.EventHandler(this.MDS_ODS_002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ADataGridView dgvWork;
        private CustomControls.AComboBox cbbwork;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel lblwork;
        private CustomControls.AButton btnSearch;
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ALabel aLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ALabel aLabel4;
        private System.Windows.Forms.RadioButton rdoprocess;
        private System.Windows.Forms.RadioButton rdowork;
        private CustomControls.ABigTextBox_FindNameByCode aBigTextBox_FindNameByCode1;
    }
}
