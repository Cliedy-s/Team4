namespace Axxen
{
    partial class MDS_SDS_006
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDS_SDS_006));
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.cbbprocess = new Axxen.CustomControls.AComboBox();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.lblItem = new Axxen.CustomControls.ALabel();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.cbbItem = new Axxen.CustomControls.AComboBox();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.lblprocess = new Axxen.CustomControls.ALabel();
            this.dgvItem = new Axxen.CustomControls.ADataGridView();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.dgvinspect = new Axxen.CustomControls.ADataGridView();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aPanel2.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinspect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.aButton1);
            this.aPanel2.Controls.Add(this.cbbprocess);
            this.aPanel2.Controls.Add(this.aPanel3);
            this.aPanel2.Controls.Add(this.aLabel3);
            this.aPanel2.Controls.Add(this.aLabel2);
            this.aPanel2.Controls.Add(this.cbbItem);
            this.aPanel2.Controls.Add(this.aPanel1);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1248, 39);
            this.aPanel2.TabIndex = 45;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(812, 7);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(175, 23);
            this.aButton1.TabIndex = 51;
            this.aButton1.Text = "품질규격복사";
            this.aButton1.UseVisualStyleBackColor = false;
            this.aButton1.Click += new System.EventHandler(this.AButton1_Click);
            // 
            // cbbprocess
            // 
            this.cbbprocess.FormattingEnabled = true;
            this.cbbprocess.Location = new System.Drawing.Point(442, 7);
            this.cbbprocess.Name = "cbbprocess";
            this.cbbprocess.Size = new System.Drawing.Size(152, 23);
            this.cbbprocess.TabIndex = 51;
            this.cbbprocess.SelectedIndexChanged += new System.EventHandler(this.Cbbprocess_SelectedIndexChanged);
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.Color.White;
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel3.Controls.Add(this.lblItem);
            this.aPanel3.Location = new System.Drawing.Point(216, 6);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(165, 24);
            this.aPanel3.TabIndex = 7;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItem.Location = new System.Drawing.Point(9, 3);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(0, 17);
            this.lblItem.TabIndex = 0;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(402, 10);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(34, 17);
            this.aLabel3.TabIndex = 10;
            this.aLabel3.Text = "공정";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(15, 9);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(34, 17);
            this.aLabel2.TabIndex = 7;
            this.aLabel2.Text = "품목";
            // 
            // cbbItem
            // 
            this.cbbItem.FormattingEnabled = true;
            this.cbbItem.Location = new System.Drawing.Point(58, 6);
            this.cbbItem.Name = "cbbItem";
            this.cbbItem.Size = new System.Drawing.Size(152, 23);
            this.cbbItem.TabIndex = 3;
            this.cbbItem.SelectedIndexChanged += new System.EventHandler(this.CbbItem_SelectedIndexChanged);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.lblprocess);
            this.aPanel1.Location = new System.Drawing.Point(600, 7);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(165, 24);
            this.aPanel1.TabIndex = 6;
            // 
            // lblprocess
            // 
            this.lblprocess.AutoSize = true;
            this.lblprocess.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblprocess.Location = new System.Drawing.Point(10, 3);
            this.lblprocess.Name = "lblprocess";
            this.lblprocess.Size = new System.Drawing.Size(0, 17);
            this.lblprocess.TabIndex = 0;
            // 
            // dgvItem
            // 
            this.dgvItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(0, 68);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowTemplate.Height = 23;
            this.dgvItem.Size = new System.Drawing.Size(339, 628);
            this.dgvItem.TabIndex = 42;
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItem_CellDoubleClick);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel1.Location = new System.Drawing.Point(37, 41);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(42, 21);
            this.aLabel1.TabIndex = 43;
            this.aLabel1.Text = "품목";
            // 
            // dgvinspect
            // 
            this.dgvinspect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvinspect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvinspect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinspect.Location = new System.Drawing.Point(345, 68);
            this.dgvinspect.Name = "dgvinspect";
            this.dgvinspect.RowTemplate.Height = 23;
            this.dgvinspect.Size = new System.Drawing.Size(903, 628);
            this.dgvinspect.TabIndex = 47;
            this.dgvinspect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvinspect_CellContentClick);
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel4.Location = new System.Drawing.Point(372, 41);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(112, 21);
            this.aLabel4.TabIndex = 49;
            this.aLabel4.Text = "품질규격 설정";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(347, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // MDS_SDS_006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1248, 700);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.dgvinspect);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MDS_SDS_006";
            this.Text = "품질구격설정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDS_SDS_006_FormClosing);
            this.Load += new System.EventHandler(this.MDS_SDS_006_Load);
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.aPanel3.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinspect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel2;
        private CustomControls.AComboBox cbbItem;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel lblprocess;
        private CustomControls.ADataGridView dgvItem;
        private CustomControls.ALabel aLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.AComboBox cbbprocess;
        private CustomControls.APanel aPanel3;
        private CustomControls.ALabel lblItem;
        private CustomControls.ADataGridView dgvinspect;
        private CustomControls.ALabel aLabel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.AButton aButton1;
    }
}
