namespace Axxen
{
    partial class MDS_SDS_002
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDS_SDS_002));
            this.cbbItem = new Axxen.CustomControls.AComboBox();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.dgvItem = new Axxen.CustomControls.ADataGridView();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.lblCode = new Axxen.CustomControls.ALabel();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.rdoType = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.btnSearch2 = new Axxen.CustomControls.AButton();
            this.cbbType = new Axxen.CustomControls.AComboBox();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aLabel8 = new Axxen.CustomControls.ALabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.lblCavity = new Axxen.CustomControls.ALabel();
            this.lblLine_Per_Qty = new Axxen.CustomControls.ALabel();
            this.lblShot_Per_Qty = new Axxen.CustomControls.ALabel();
            this.lblupdateCode = new Axxen.CustomControls.ALabel();
            this.lblupdateName = new Axxen.CustomControls.ALabel();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.nudCavity = new System.Windows.Forms.NumericUpDown();
            this.nudLine_Per_Qty = new System.Windows.Forms.NumericUpDown();
            this.nudShot_Per_Qty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.aPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCavity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLine_Per_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShot_Per_Qty)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbItem
            // 
            this.cbbItem.FormattingEnabled = true;
            this.cbbItem.Location = new System.Drawing.Point(77, 5);
            this.cbbItem.Name = "cbbItem";
            this.cbbItem.Size = new System.Drawing.Size(152, 23);
            this.cbbItem.TabIndex = 3;
            this.cbbItem.SelectedIndexChanged += new System.EventHandler(this.CbbItem_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(472, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(12, 74);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowTemplate.Height = 23;
            this.dgvItem.Size = new System.Drawing.Size(1188, 492);
            this.dgvItem.TabIndex = 10;
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItem_CellDoubleClick);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.lblCode);
            this.aPanel1.Location = new System.Drawing.Point(301, 4);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(165, 24);
            this.aPanel1.TabIndex = 6;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCode.Location = new System.Drawing.Point(3, 3);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 17);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "aLabel1";
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.rdoType);
            this.aPanel2.Controls.Add(this.rdoName);
            this.aPanel2.Controls.Add(this.btnSearch2);
            this.aPanel2.Controls.Add(this.cbbType);
            this.aPanel2.Controls.Add(this.aLabel3);
            this.aPanel2.Controls.Add(this.cbbItem);
            this.aPanel2.Controls.Add(this.aPanel1);
            this.aPanel2.Controls.Add(this.btnSearch);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1212, 44);
            this.aPanel2.TabIndex = 13;
            // 
            // rdoType
            // 
            this.rdoType.AutoSize = true;
            this.rdoType.Location = new System.Drawing.Point(642, 9);
            this.rdoType.Name = "rdoType";
            this.rdoType.Size = new System.Drawing.Size(73, 19);
            this.rdoType.TabIndex = 18;
            this.rdoType.TabStop = true;
            this.rdoType.Text = "품목유형";
            this.rdoType.UseVisualStyleBackColor = true;
            this.rdoType.CheckedChanged += new System.EventHandler(this.RdoType_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Checked = true;
            this.rdoName.Location = new System.Drawing.Point(10, 8);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(61, 19);
            this.rdoName.TabIndex = 17;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "품목명";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.RdoName_CheckedChanged);
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch2.Location = new System.Drawing.Point(879, 4);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(75, 23);
            this.btnSearch2.TabIndex = 16;
            this.btnSearch2.Text = "조회";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.BtnSearch2_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(721, 6);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(152, 23);
            this.cbbType.TabIndex = 15;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(235, 8);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(60, 17);
            this.aLabel3.TabIndex = 10;
            this.aLabel3.Text = "품목코드";
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
            this.pictureBox2.Location = new System.Drawing.Point(12, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // aLabel8
            // 
            this.aLabel8.AutoSize = true;
            this.aLabel8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel8.Location = new System.Drawing.Point(37, 47);
            this.aLabel8.Name = "aLabel8";
            this.aLabel8.Size = new System.Drawing.Size(74, 21);
            this.aLabel8.TabIndex = 14;
            this.aLabel8.Text = "품목정보";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 572);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel2.Location = new System.Drawing.Point(37, 573);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(74, 21);
            this.aLabel2.TabIndex = 16;
            this.aLabel2.Text = "품목수정";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1123, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblCavity
            // 
            this.lblCavity.AutoSize = true;
            this.lblCavity.Location = new System.Drawing.Point(10, 66);
            this.lblCavity.Name = "lblCavity";
            this.lblCavity.Size = new System.Drawing.Size(55, 15);
            this.lblCavity.TabIndex = 23;
            this.lblCavity.Text = "캐비티수";
            // 
            // lblLine_Per_Qty
            // 
            this.lblLine_Per_Qty.AutoSize = true;
            this.lblLine_Per_Qty.Location = new System.Drawing.Point(172, 66);
            this.lblLine_Per_Qty.Name = "lblLine_Per_Qty";
            this.lblLine_Per_Qty.Size = new System.Drawing.Size(103, 15);
            this.lblLine_Per_Qty.TabIndex = 24;
            this.lblLine_Per_Qty.Text = "성형줄당캐비티수";
            // 
            // lblShot_Per_Qty
            // 
            this.lblShot_Per_Qty.AutoSize = true;
            this.lblShot_Per_Qty.Location = new System.Drawing.Point(334, 66);
            this.lblShot_Per_Qty.Name = "lblShot_Per_Qty";
            this.lblShot_Per_Qty.Size = new System.Drawing.Size(78, 15);
            this.lblShot_Per_Qty.TabIndex = 25;
            this.lblShot_Per_Qty.Text = "Shot당PCS수";
            // 
            // lblupdateCode
            // 
            this.lblupdateCode.AutoSize = true;
            this.lblupdateCode.Location = new System.Drawing.Point(71, 13);
            this.lblupdateCode.Name = "lblupdateCode";
            this.lblupdateCode.Size = new System.Drawing.Size(0, 15);
            this.lblupdateCode.TabIndex = 26;
            // 
            // lblupdateName
            // 
            this.lblupdateName.AutoSize = true;
            this.lblupdateName.Location = new System.Drawing.Point(211, 13);
            this.lblupdateName.Name = "lblupdateName";
            this.lblupdateName.Size = new System.Drawing.Size(0, 15);
            this.lblupdateName.TabIndex = 27;
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel3.Controls.Add(this.nudShot_Per_Qty);
            this.aPanel3.Controls.Add(this.nudLine_Per_Qty);
            this.aPanel3.Controls.Add(this.nudCavity);
            this.aPanel3.Controls.Add(this.aLabel5);
            this.aPanel3.Controls.Add(this.aLabel4);
            this.aPanel3.Controls.Add(this.btnSave);
            this.aPanel3.Controls.Add(this.lblupdateName);
            this.aPanel3.Controls.Add(this.lblupdateCode);
            this.aPanel3.Controls.Add(this.lblShot_Per_Qty);
            this.aPanel3.Controls.Add(this.lblLine_Per_Qty);
            this.aPanel3.Controls.Add(this.lblCavity);
            this.aPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel3.Location = new System.Drawing.Point(0, 600);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(1212, 158);
            this.aPanel3.TabIndex = 28;
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(10, 13);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(55, 15);
            this.aLabel4.TabIndex = 31;
            this.aLabel4.Text = "품목코드";
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Location = new System.Drawing.Point(151, 13);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(43, 15);
            this.aLabel5.TabIndex = 32;
            this.aLabel5.Text = "품목명";
            // 
            // nudCavity
            // 
            this.nudCavity.Location = new System.Drawing.Point(13, 96);
            this.nudCavity.Name = "nudCavity";
            this.nudCavity.Size = new System.Drawing.Size(120, 23);
            this.nudCavity.TabIndex = 34;
            // 
            // nudLine_Per_Qty
            // 
            this.nudLine_Per_Qty.Location = new System.Drawing.Point(172, 96);
            this.nudLine_Per_Qty.Name = "nudLine_Per_Qty";
            this.nudLine_Per_Qty.Size = new System.Drawing.Size(120, 23);
            this.nudLine_Per_Qty.TabIndex = 35;
            // 
            // nudShot_Per_Qty
            // 
            this.nudShot_Per_Qty.Location = new System.Drawing.Point(320, 96);
            this.nudShot_Per_Qty.Name = "nudShot_Per_Qty";
            this.nudShot_Per_Qty.Size = new System.Drawing.Size(120, 23);
            this.nudShot_Per_Qty.TabIndex = 36;
            // 
            // MDS_SDS_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1212, 758);
            this.Controls.Add(this.aPanel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.aLabel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aLabel8);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MDS_SDS_002";
            this.Text = "품목정보";
            this.Load += new System.EventHandler(this.MDS_SDS_002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.aPanel3.ResumeLayout(false);
            this.aPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCavity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLine_Per_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShot_Per_Qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.AComboBox cbbItem;
        private CustomControls.AButton btnSearch;
        private CustomControls.ADataGridView dgvItem;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel lblCode;
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ALabel aLabel8;
        private System.Windows.Forms.RadioButton rdoType;
        private System.Windows.Forms.RadioButton rdoName;
        private CustomControls.AButton btnSearch2;
        private CustomControls.AComboBox cbbType;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.ALabel aLabel2;
        private CustomControls.AButton btnSave;
        private CustomControls.ALabel lblCavity;
        private CustomControls.ALabel lblLine_Per_Qty;
        private CustomControls.ALabel lblShot_Per_Qty;
        private CustomControls.ALabel lblupdateCode;
        private CustomControls.ALabel lblupdateName;
        private CustomControls.APanel aPanel3;
        private CustomControls.ALabel aLabel5;
        private CustomControls.ALabel aLabel4;
        private System.Windows.Forms.NumericUpDown nudShot_Per_Qty;
        private System.Windows.Forms.NumericUpDown nudLine_Per_Qty;
        private System.Windows.Forms.NumericUpDown nudCavity;
    }
}
