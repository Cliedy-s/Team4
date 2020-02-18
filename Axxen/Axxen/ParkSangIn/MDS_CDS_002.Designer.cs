namespace Axxen
{
    partial class MDS_CDS_002
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
            this.aBigTextBox_FindNameByCode1 = new Axxen.CustomControls.ABigTextBox_FindNameByCode();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.txtDef_Micode = new Axxen.CustomControls.ATextBox();
            this.aPanel7 = new Axxen.CustomControls.APanel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.txtDef_Miname = new Axxen.CustomControls.ATextBox();
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.lblDefM = new Axxen.CustomControls.ALabel();
            this.aPanel8 = new Axxen.CustomControls.APanel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.aPanel9 = new Axxen.CustomControls.APanel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.aPanel10 = new Axxen.CustomControls.APanel();
            this.txtRemark = new Axxen.CustomControls.ATextBox();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer2)).BeginInit();
            this.aSplitContainer2.Panel1.SuspendLayout();
            this.aSplitContainer2.Panel2.SuspendLayout();
            this.aSplitContainer2.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel6.SuspendLayout();
            this.aPanel7.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.aPanel5.SuspendLayout();
            this.aPanel4.SuspendLayout();
            this.aPanel8.SuspendLayout();
            this.aPanel9.SuspendLayout();
            this.aPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.btnSearch);
            this.aPanel1.Controls.Add(this.aBigTextBox_FindNameByCode1);
            this.aPanel1.Size = new System.Drawing.Size(1233, 74);
            // 
            // aSplitContainer1
            // 
            this.aSplitContainer1.Size = new System.Drawing.Size(1233, 603);
            this.aSplitContainer1.SplitterDistance = 329;
            // 
            // aSplitContainer2
            // 
            this.aSplitContainer2.Size = new System.Drawing.Size(903, 603);
            this.aSplitContainer2.SplitterDistance = 507;
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.aPanel10);
            this.aPanel2.Controls.Add(this.aPanel9);
            this.aPanel2.Controls.Add(this.btnSave);
            this.aPanel2.Controls.Add(this.aPanel4);
            this.aPanel2.Controls.Add(this.aPanel8);
            this.aPanel2.Controls.Add(this.aPanel3);
            this.aPanel2.Controls.Add(this.aPanel5);
            this.aPanel2.Controls.Add(this.aPanel6);
            this.aPanel2.Controls.Add(this.aPanel7);
            this.aPanel2.Size = new System.Drawing.Size(903, 95);
            this.aPanel2.Controls.SetChildIndex(this.aHeaderBox3, 0);
            this.aPanel2.Controls.SetChildIndex(this.aPanel7, 0);
            this.aPanel2.Controls.SetChildIndex(this.aPanel6, 0);
            this.aPanel2.Controls.SetChildIndex(this.aPanel5, 0);
            this.aPanel2.Controls.SetChildIndex(this.aPanel3, 0);
            this.aPanel2.Controls.SetChildIndex(this.aPanel8, 0);
            this.aPanel2.Controls.SetChildIndex(this.aPanel4, 0);
            this.aPanel2.Controls.SetChildIndex(this.btnSave, 0);
            this.aPanel2.Controls.SetChildIndex(this.aPanel9, 0);
            this.aPanel2.Controls.SetChildIndex(this.aPanel10, 0);
            // 
            // aHeaderBox3
            // 
            this.aHeaderBox3.HeaderBoxText = "입력정보";
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "불량현상 대분류";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "불량현상 상세분류";
            // 
            // aBigTextBox_FindNameByCode1
            // 
            this.aBigTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Errors;
            this.aBigTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_FindNameByCode1.lblNameText = "불량현상 대분류";
            this.aBigTextBox_FindNameByCode1.Location = new System.Drawing.Point(27, 19);
            this.aBigTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_FindNameByCode1.Name = "aBigTextBox_FindNameByCode1";
            this.aBigTextBox_FindNameByCode1.Size = new System.Drawing.Size(376, 38);
            this.aBigTextBox_FindNameByCode1.TabIndex = 10;
            this.aBigTextBox_FindNameByCode1.txtCodeText = "";
            this.aBigTextBox_FindNameByCode1.txtNameText = "";
            // 
            // aPanel6
            // 
            this.aPanel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel6.Controls.Add(this.txtDef_Micode);
            this.aPanel6.Location = new System.Drawing.Point(107, 35);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(152, 31);
            this.aPanel6.TabIndex = 99;
            // 
            // txtDef_Micode
            // 
            this.txtDef_Micode.BackColor = System.Drawing.Color.White;
            this.txtDef_Micode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDef_Micode.errorp = null;
            this.txtDef_Micode.Location = new System.Drawing.Point(3, 2);
            this.txtDef_Micode.MaxLength = 20;
            this.txtDef_Micode.Name = "txtDef_Micode";
            this.txtDef_Micode.Size = new System.Drawing.Size(142, 23);
            this.txtDef_Micode.TabIndex = 11;
            this.txtDef_Micode.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel7
            // 
            this.aPanel7.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel7.Controls.Add(this.aLabel2);
            this.aPanel7.Location = new System.Drawing.Point(3, 35);
            this.aPanel7.Name = "aPanel7";
            this.aPanel7.Size = new System.Drawing.Size(102, 30);
            this.aPanel7.TabIndex = 98;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel2.Location = new System.Drawing.Point(6, 6);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(97, 17);
            this.aLabel2.TabIndex = 53;
            this.aLabel2.Text = "*상세분류코드 ";
            // 
            // aPanel3
            // 
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel3.Controls.Add(this.txtDef_Miname);
            this.aPanel3.Location = new System.Drawing.Point(369, 35);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(152, 31);
            this.aPanel3.TabIndex = 103;
            // 
            // txtDef_Miname
            // 
            this.txtDef_Miname.BackColor = System.Drawing.Color.White;
            this.txtDef_Miname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDef_Miname.errorp = null;
            this.txtDef_Miname.Location = new System.Drawing.Point(3, 2);
            this.txtDef_Miname.MaxLength = 30;
            this.txtDef_Miname.Name = "txtDef_Miname";
            this.txtDef_Miname.Size = new System.Drawing.Size(143, 23);
            this.txtDef_Miname.TabIndex = 11;
            this.txtDef_Miname.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aPanel5
            // 
            this.aPanel5.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel5.Controls.Add(this.aLabel3);
            this.aPanel5.Location = new System.Drawing.Point(265, 35);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(102, 30);
            this.aPanel5.TabIndex = 102;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel3.Location = new System.Drawing.Point(15, 6);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(79, 17);
            this.aLabel3.TabIndex = 53;
            this.aLabel3.Text = "*상세분류명";
            // 
            // aPanel4
            // 
            this.aPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel4.Controls.Add(this.lblDefM);
            this.aPanel4.Location = new System.Drawing.Point(369, 2);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(152, 31);
            this.aPanel4.TabIndex = 106;
            // 
            // lblDefM
            // 
            this.lblDefM.AutoSize = true;
            this.lblDefM.Location = new System.Drawing.Point(3, 7);
            this.lblDefM.Name = "lblDefM";
            this.lblDefM.Size = new System.Drawing.Size(48, 15);
            this.lblDefM.TabIndex = 0;
            this.lblDefM.Text = "aLabel4";
            // 
            // aPanel8
            // 
            this.aPanel8.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel8.Controls.Add(this.aLabel1);
            this.aPanel8.Location = new System.Drawing.Point(265, 2);
            this.aPanel8.Name = "aPanel8";
            this.aPanel8.Size = new System.Drawing.Size(102, 30);
            this.aPanel8.TabIndex = 105;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel1.Location = new System.Drawing.Point(2, 6);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(99, 17);
            this.aLabel1.TabIndex = 53;
            this.aLabel1.Text = "현상대분류코드";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(811, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // aPanel9
            // 
            this.aPanel9.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel9.Controls.Add(this.aLabel4);
            this.aPanel9.Location = new System.Drawing.Point(527, 3);
            this.aPanel9.Name = "aPanel9";
            this.aPanel9.Size = new System.Drawing.Size(102, 30);
            this.aPanel9.TabIndex = 107;
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel4.Location = new System.Drawing.Point(36, 5);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(34, 17);
            this.aLabel4.TabIndex = 53;
            this.aLabel4.Text = "비고";
            // 
            // aPanel10
            // 
            this.aPanel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel10.Controls.Add(this.txtRemark);
            this.aPanel10.Location = new System.Drawing.Point(631, 2);
            this.aPanel10.Name = "aPanel10";
            this.aPanel10.Size = new System.Drawing.Size(170, 86);
            this.aPanel10.TabIndex = 108;
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.White;
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.errorp = null;
            this.txtRemark.Location = new System.Drawing.Point(3, 2);
            this.txtRemark.MaxLength = 100;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(160, 77);
            this.txtRemark.TabIndex = 11;
            this.txtRemark.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(420, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 30);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // MDS_CDS_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1257, 713);
            this.ControlBox = false;
            this.Name = "MDS_CDS_002";
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDS_CDS_002_FormClosing);
            this.Load += new System.EventHandler(this.MDS_CDS_002_Load);
            this.aPanel1.ResumeLayout(false);
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.aSplitContainer2.Panel1.ResumeLayout(false);
            this.aSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer2)).EndInit();
            this.aSplitContainer2.ResumeLayout(false);
            this.aPanel2.ResumeLayout(false);
            this.aPanel6.ResumeLayout(false);
            this.aPanel6.PerformLayout();
            this.aPanel7.ResumeLayout(false);
            this.aPanel7.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.aPanel3.PerformLayout();
            this.aPanel5.ResumeLayout(false);
            this.aPanel5.PerformLayout();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            this.aPanel8.ResumeLayout(false);
            this.aPanel8.PerformLayout();
            this.aPanel9.ResumeLayout(false);
            this.aPanel9.PerformLayout();
            this.aPanel10.ResumeLayout(false);
            this.aPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ABigTextBox_FindNameByCode aBigTextBox_FindNameByCode1;
        private CustomControls.APanel aPanel6;
        private CustomControls.APanel aPanel7;
        private CustomControls.ALabel aLabel2;
        private CustomControls.APanel aPanel3;
        private CustomControls.APanel aPanel5;
        private CustomControls.ALabel aLabel3;
        private CustomControls.APanel aPanel4;
        private CustomControls.APanel aPanel8;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ALabel lblDefM;
        private CustomControls.ATextBox txtDef_Miname;
        private CustomControls.ATextBox txtDef_Micode;
        private CustomControls.AButton btnSave;
        private CustomControls.APanel aPanel10;
        private CustomControls.ATextBox txtRemark;
        private CustomControls.APanel aPanel9;
        private CustomControls.ALabel aLabel4;
        private CustomControls.AButton btnSearch;
    }
}
