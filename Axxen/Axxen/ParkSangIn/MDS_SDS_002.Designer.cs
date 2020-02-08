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
            this.aLabel8 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.nudShot_Per_Qty = new System.Windows.Forms.NumericUpDown();
            this.nudLine_Per_Qty = new System.Windows.Forms.NumericUpDown();
            this.nudCavity = new System.Windows.Forms.NumericUpDown();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.aLabel6 = new Axxen.CustomControls.ALabel();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.aLabel7 = new Axxen.CustomControls.ALabel();
            this.aPanel7 = new Axxen.CustomControls.APanel();
            this.aLabel10 = new Axxen.CustomControls.ALabel();
            this.aLabel9 = new Axxen.CustomControls.ALabel();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.aPanel8 = new Axxen.CustomControls.APanel();
            this.aPanel9 = new Axxen.CustomControls.APanel();
            this.lblupdateCode = new Axxen.CustomControls.ALabel();
            this.lblupdateName = new Axxen.CustomControls.ALabel();
            this.aPanel10 = new Axxen.CustomControls.APanel();
            this.aPanel11 = new Axxen.CustomControls.APanel();
            this.aPanel12 = new Axxen.CustomControls.APanel();
            this.panelsetting = new Axxen.CustomControls.APanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShot_Per_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLine_Per_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCavity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aPanel4.SuspendLayout();
            this.aPanel5.SuspendLayout();
            this.aPanel6.SuspendLayout();
            this.aPanel7.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.aPanel8.SuspendLayout();
            this.aPanel9.SuspendLayout();
            this.aPanel10.SuspendLayout();
            this.aPanel11.SuspendLayout();
            this.aPanel12.SuspendLayout();
            this.panelsetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbItem
            // 
            this.cbbItem.FormattingEnabled = true;
            this.cbbItem.Location = new System.Drawing.Point(77, 9);
            this.cbbItem.Name = "cbbItem";
            this.cbbItem.Size = new System.Drawing.Size(152, 23);
            this.cbbItem.TabIndex = 0;
            this.cbbItem.SelectedIndexChanged += new System.EventHandler(this.CbbItem_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(472, 9);
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
            this.dgvItem.Location = new System.Drawing.Point(12, 257);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowTemplate.Height = 23;
            this.dgvItem.Size = new System.Drawing.Size(1188, 489);
            this.dgvItem.TabIndex = 10;
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItem_CellDoubleClick);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.lblCode);
            this.aPanel1.Location = new System.Drawing.Point(301, 8);
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
            this.aPanel2.Size = new System.Drawing.Size(1212, 52);
            this.aPanel2.TabIndex = 13;
            // 
            // rdoType
            // 
            this.rdoType.AutoSize = true;
            this.rdoType.Location = new System.Drawing.Point(642, 13);
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
            this.rdoName.Location = new System.Drawing.Point(10, 12);
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
            this.btnSearch2.FlatAppearance.BorderSize = 0;
            this.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch2.Location = new System.Drawing.Point(879, 8);
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
            this.cbbType.Location = new System.Drawing.Point(721, 10);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(152, 23);
            this.cbbType.TabIndex = 15;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(235, 12);
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
            // aLabel8
            // 
            this.aLabel8.AutoSize = true;
            this.aLabel8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel8.Location = new System.Drawing.Point(33, 230);
            this.aLabel8.Name = "aLabel8";
            this.aLabel8.Size = new System.Drawing.Size(74, 21);
            this.aLabel8.TabIndex = 14;
            this.aLabel8.Text = "품목정보";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel2.Location = new System.Drawing.Point(37, 55);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(74, 21);
            this.aLabel2.TabIndex = 16;
            this.aLabel2.Text = "품목수정";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1100, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // nudShot_Per_Qty
            // 
            this.nudShot_Per_Qty.Location = new System.Drawing.Point(17, 3);
            this.nudShot_Per_Qty.Name = "nudShot_Per_Qty";
            this.nudShot_Per_Qty.Size = new System.Drawing.Size(192, 23);
            this.nudShot_Per_Qty.TabIndex = 2;
            // 
            // nudLine_Per_Qty
            // 
            this.nudLine_Per_Qty.Location = new System.Drawing.Point(17, 3);
            this.nudLine_Per_Qty.Name = "nudLine_Per_Qty";
            this.nudLine_Per_Qty.Size = new System.Drawing.Size(192, 23);
            this.nudLine_Per_Qty.TabIndex = 1;
            // 
            // nudCavity
            // 
            this.nudCavity.Location = new System.Drawing.Point(17, 4);
            this.nudCavity.Name = "nudCavity";
            this.nudCavity.Size = new System.Drawing.Size(192, 23);
            this.nudCavity.TabIndex = 0;
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Location = new System.Drawing.Point(44, 7);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(43, 15);
            this.aLabel5.TabIndex = 32;
            this.aLabel5.Text = "품목명";
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(38, 7);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(55, 15);
            this.aLabel4.TabIndex = 31;
            this.aLabel4.Text = "품목코드";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
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
            // aPanel4
            // 
            this.aPanel4.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel4.Controls.Add(this.aLabel4);
            this.aPanel4.Location = new System.Drawing.Point(5, 3);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(140, 34);
            this.aPanel4.TabIndex = 29;
            // 
            // aPanel5
            // 
            this.aPanel5.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel5.Controls.Add(this.aLabel6);
            this.aPanel5.Location = new System.Drawing.Point(5, 36);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(140, 34);
            this.aPanel5.TabIndex = 33;
            // 
            // aLabel6
            // 
            this.aLabel6.AutoSize = true;
            this.aLabel6.Location = new System.Drawing.Point(38, 6);
            this.aLabel6.Name = "aLabel6";
            this.aLabel6.Size = new System.Drawing.Size(55, 15);
            this.aLabel6.TabIndex = 24;
            this.aLabel6.Text = "캐비티수";
            // 
            // aPanel6
            // 
            this.aPanel6.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel6.Controls.Add(this.aLabel7);
            this.aPanel6.Location = new System.Drawing.Point(5, 69);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(140, 34);
            this.aPanel6.TabIndex = 32;
            // 
            // aLabel7
            // 
            this.aLabel7.AutoSize = true;
            this.aLabel7.Location = new System.Drawing.Point(16, 8);
            this.aLabel7.Name = "aLabel7";
            this.aLabel7.Size = new System.Drawing.Size(103, 15);
            this.aLabel7.TabIndex = 25;
            this.aLabel7.Text = "성형줄당캐비티수";
            // 
            // aPanel7
            // 
            this.aPanel7.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel7.Controls.Add(this.aLabel10);
            this.aPanel7.Controls.Add(this.aLabel9);
            this.aPanel7.Location = new System.Drawing.Point(5, 103);
            this.aPanel7.Name = "aPanel7";
            this.aPanel7.Size = new System.Drawing.Size(140, 34);
            this.aPanel7.TabIndex = 32;
            // 
            // aLabel10
            // 
            this.aLabel10.AutoSize = true;
            this.aLabel10.Location = new System.Drawing.Point(29, 8);
            this.aLabel10.Name = "aLabel10";
            this.aLabel10.Size = new System.Drawing.Size(78, 15);
            this.aLabel10.TabIndex = 32;
            this.aLabel10.Text = "Shot당PCS수";
            // 
            // aLabel9
            // 
            this.aLabel9.AutoSize = true;
            this.aLabel9.Location = new System.Drawing.Point(26, 7);
            this.aLabel9.Name = "aLabel9";
            this.aLabel9.Size = new System.Drawing.Size(55, 15);
            this.aLabel9.TabIndex = 31;
            this.aLabel9.Text = "품목코드";
            // 
            // aPanel3
            // 
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel3.Controls.Add(this.nudCavity);
            this.aPanel3.Location = new System.Drawing.Point(142, 36);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(1053, 34);
            this.aPanel3.TabIndex = 37;
            // 
            // aPanel8
            // 
            this.aPanel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel8.Controls.Add(this.nudLine_Per_Qty);
            this.aPanel8.Location = new System.Drawing.Point(142, 69);
            this.aPanel8.Name = "aPanel8";
            this.aPanel8.Size = new System.Drawing.Size(1053, 34);
            this.aPanel8.TabIndex = 38;
            // 
            // aPanel9
            // 
            this.aPanel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel9.Controls.Add(this.nudShot_Per_Qty);
            this.aPanel9.Location = new System.Drawing.Point(142, 103);
            this.aPanel9.Name = "aPanel9";
            this.aPanel9.Size = new System.Drawing.Size(1053, 34);
            this.aPanel9.TabIndex = 38;
            // 
            // lblupdateCode
            // 
            this.lblupdateCode.AutoSize = true;
            this.lblupdateCode.Location = new System.Drawing.Point(14, 7);
            this.lblupdateCode.Name = "lblupdateCode";
            this.lblupdateCode.Size = new System.Drawing.Size(0, 15);
            this.lblupdateCode.TabIndex = 39;
            // 
            // lblupdateName
            // 
            this.lblupdateName.AutoSize = true;
            this.lblupdateName.Location = new System.Drawing.Point(23, 7);
            this.lblupdateName.Name = "lblupdateName";
            this.lblupdateName.Size = new System.Drawing.Size(0, 15);
            this.lblupdateName.TabIndex = 40;
            // 
            // aPanel10
            // 
            this.aPanel10.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel10.Controls.Add(this.aLabel5);
            this.aPanel10.Location = new System.Drawing.Point(254, 3);
            this.aPanel10.Name = "aPanel10";
            this.aPanel10.Size = new System.Drawing.Size(140, 34);
            this.aPanel10.TabIndex = 32;
            // 
            // aPanel11
            // 
            this.aPanel11.BackColor = System.Drawing.Color.White;
            this.aPanel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel11.Controls.Add(this.lblupdateCode);
            this.aPanel11.Location = new System.Drawing.Point(142, 3);
            this.aPanel11.Name = "aPanel11";
            this.aPanel11.Size = new System.Drawing.Size(112, 34);
            this.aPanel11.TabIndex = 41;
            // 
            // aPanel12
            // 
            this.aPanel12.BackColor = System.Drawing.Color.White;
            this.aPanel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel12.Controls.Add(this.lblupdateName);
            this.aPanel12.Location = new System.Drawing.Point(393, 3);
            this.aPanel12.Name = "aPanel12";
            this.aPanel12.Size = new System.Drawing.Size(112, 34);
            this.aPanel12.TabIndex = 42;
            // 
            // panelsetting
            // 
            this.panelsetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelsetting.Controls.Add(this.aPanel11);
            this.panelsetting.Controls.Add(this.aPanel12);
            this.panelsetting.Controls.Add(this.aPanel4);
            this.panelsetting.Controls.Add(this.aPanel5);
            this.panelsetting.Controls.Add(this.aPanel10);
            this.panelsetting.Controls.Add(this.aPanel7);
            this.panelsetting.Controls.Add(this.aPanel8);
            this.panelsetting.Controls.Add(this.aPanel6);
            this.panelsetting.Controls.Add(this.aPanel9);
            this.panelsetting.Controls.Add(this.btnSave);
            this.panelsetting.Controls.Add(this.aPanel3);
            this.panelsetting.Location = new System.Drawing.Point(12, 77);
            this.panelsetting.Name = "panelsetting";
            this.panelsetting.Size = new System.Drawing.Size(1200, 141);
            this.panelsetting.TabIndex = 43;
            // 
            // MDS_SDS_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1212, 758);
            this.Controls.Add(this.panelsetting);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDS_SDS_002_FormClosing);
            this.Load += new System.EventHandler(this.MDS_SDS_002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShot_Per_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLine_Per_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCavity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            this.aPanel5.ResumeLayout(false);
            this.aPanel5.PerformLayout();
            this.aPanel6.ResumeLayout(false);
            this.aPanel6.PerformLayout();
            this.aPanel7.ResumeLayout(false);
            this.aPanel7.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.aPanel8.ResumeLayout(false);
            this.aPanel9.ResumeLayout(false);
            this.aPanel10.ResumeLayout(false);
            this.aPanel10.PerformLayout();
            this.aPanel11.ResumeLayout(false);
            this.aPanel11.PerformLayout();
            this.aPanel12.ResumeLayout(false);
            this.aPanel12.PerformLayout();
            this.panelsetting.ResumeLayout(false);
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
        private CustomControls.ALabel aLabel5;
        private CustomControls.ALabel aLabel4;
        private System.Windows.Forms.NumericUpDown nudShot_Per_Qty;
        private System.Windows.Forms.NumericUpDown nudLine_Per_Qty;
        private System.Windows.Forms.NumericUpDown nudCavity;
        private CustomControls.APanel aPanel4;
        private CustomControls.APanel aPanel5;
        private CustomControls.ALabel aLabel6;
        private CustomControls.APanel aPanel6;
        private CustomControls.ALabel aLabel7;
        private CustomControls.APanel aPanel7;
        private CustomControls.ALabel aLabel10;
        private CustomControls.ALabel aLabel9;
        private CustomControls.APanel aPanel3;
        private CustomControls.APanel aPanel8;
        private CustomControls.APanel aPanel9;
        private CustomControls.ALabel lblupdateCode;
        private CustomControls.ALabel lblupdateName;
        private CustomControls.APanel aPanel10;
        private CustomControls.APanel aPanel11;
        private CustomControls.APanel aPanel12;
        private CustomControls.APanel panelsetting;
    }
}
