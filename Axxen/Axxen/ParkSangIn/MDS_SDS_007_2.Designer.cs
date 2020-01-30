namespace Axxen
{
    partial class MDS_SDS_007_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDS_SDS_007_2));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aPanel8 = new Axxen.CustomControls.APanel();
            this.lblItem = new Axxen.CustomControls.ALabel();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.cbbItem = new Axxen.CustomControls.AComboBox();
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aPanel9 = new Axxen.CustomControls.APanel();
            this.btnCencle = new Axxen.CustomControls.AButton();
            this.btnSave = new Axxen.CustomControls.AButton();
            this.dgvCondition = new Axxen.CustomControls.ADataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.aPanel4.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel8.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.aPanel5.SuspendLayout();
            this.aPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 133;
            this.pictureBox2.TabStop = false;
            // 
            // aPanel4
            // 
            this.aPanel4.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel4.Controls.Add(this.aLabel1);
            this.aPanel4.Location = new System.Drawing.Point(22, 47);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(120, 35);
            this.aPanel4.TabIndex = 136;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel1.Location = new System.Drawing.Point(29, 5);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(60, 17);
            this.aLabel1.TabIndex = 55;
            this.aLabel1.Text = "품목코드";
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel4.Location = new System.Drawing.Point(49, 85);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(112, 21);
            this.aLabel4.TabIndex = 132;
            this.aLabel4.Text = "품질규격 설정";
            // 
            // aPanel2
            // 
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel2.Controls.Add(this.aPanel8);
            this.aPanel2.Location = new System.Drawing.Point(144, 47);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(170, 35);
            this.aPanel2.TabIndex = 137;
            // 
            // aPanel8
            // 
            this.aPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel8.Controls.Add(this.lblItem);
            this.aPanel8.Location = new System.Drawing.Point(4, 3);
            this.aPanel8.Name = "aPanel8";
            this.aPanel8.Size = new System.Drawing.Size(160, 27);
            this.aPanel8.TabIndex = 151;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(11, 3);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(48, 15);
            this.lblItem.TabIndex = 150;
            this.lblItem.Text = "aLabel3";
            // 
            // aPanel3
            // 
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel3.Controls.Add(this.cbbItem);
            this.aPanel3.Location = new System.Drawing.Point(144, 12);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(170, 35);
            this.aPanel3.TabIndex = 135;
            // 
            // cbbItem
            // 
            this.cbbItem.FormattingEnabled = true;
            this.cbbItem.Location = new System.Drawing.Point(2, 4);
            this.cbbItem.Name = "cbbItem";
            this.cbbItem.Size = new System.Drawing.Size(160, 23);
            this.cbbItem.TabIndex = 154;
            this.cbbItem.SelectedIndexChanged += new System.EventHandler(this.CbbItem_SelectedIndexChanged);
            // 
            // aPanel5
            // 
            this.aPanel5.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel5.Controls.Add(this.aLabel2);
            this.aPanel5.Location = new System.Drawing.Point(22, 12);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(120, 35);
            this.aPanel5.TabIndex = 134;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aLabel2.Location = new System.Drawing.Point(26, 5);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(47, 17);
            this.aLabel2.TabIndex = 54;
            this.aLabel2.Text = "품목명";
            // 
            // aPanel9
            // 
            this.aPanel9.BackColor = System.Drawing.SystemColors.Info;
            this.aPanel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aPanel9.Controls.Add(this.btnCencle);
            this.aPanel9.Controls.Add(this.btnSave);
            this.aPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel9.Location = new System.Drawing.Point(0, 510);
            this.aPanel9.Name = "aPanel9";
            this.aPanel9.Size = new System.Drawing.Size(1003, 41);
            this.aPanel9.TabIndex = 139;
            // 
            // btnCencle
            // 
            this.btnCencle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCencle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCencle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCencle.FlatAppearance.BorderSize = 0;
            this.btnCencle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCencle.Location = new System.Drawing.Point(914, 11);
            this.btnCencle.Name = "btnCencle";
            this.btnCencle.Size = new System.Drawing.Size(75, 23);
            this.btnCencle.TabIndex = 45;
            this.btnCencle.Text = "취소";
            this.btnCencle.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(833, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dgvCondition
            // 
            this.dgvCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondition.Location = new System.Drawing.Point(10, 112);
            this.dgvCondition.Name = "dgvCondition";
            this.dgvCondition.RowTemplate.Height = 23;
            this.dgvCondition.Size = new System.Drawing.Size(987, 395);
            this.dgvCondition.TabIndex = 138;
            // 
            // MDS_SDS_007_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1003, 551);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aPanel3);
            this.Controls.Add(this.aPanel5);
            this.Controls.Add(this.aPanel9);
            this.Controls.Add(this.dgvCondition);
            this.Name = "MDS_SDS_007_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "공정조건복사";
            this.Load += new System.EventHandler(this.MDS_SDS_007_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel8.ResumeLayout(false);
            this.aPanel8.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.aPanel5.ResumeLayout(false);
            this.aPanel5.PerformLayout();
            this.aPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.APanel aPanel4;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ALabel aLabel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.APanel aPanel2;
        private CustomControls.APanel aPanel8;
        private CustomControls.ALabel lblItem;
        private CustomControls.APanel aPanel3;
        private CustomControls.AComboBox cbbItem;
        private CustomControls.APanel aPanel5;
        private CustomControls.ALabel aLabel2;
        private CustomControls.APanel aPanel9;
        private CustomControls.AButton btnCencle;
        private CustomControls.AButton btnSave;
        private CustomControls.ADataGridView dgvCondition;
    }
}
