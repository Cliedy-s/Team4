namespace Axxen
{
    partial class MSS_CON_002_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSS_CON_002_1));
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aPanel3 = new Axxen.CustomControls.APanel();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aTextBox1 = new Axxen.CustomControls.ATextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dgvScreenItem = new Axxen.CustomControls.ADataGridView();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.aButton3 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenItem)).BeginInit();
            this.aPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aLabel5.Location = new System.Drawing.Point(47, 9);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(80, 21);
            this.aLabel5.TabIndex = 17;
            this.aLabel5.Text = "화면 조회";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel2.Location = new System.Drawing.Point(43, 10);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(0, 21);
            this.aLabel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.PowderBlue;
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.aLabel5);
            this.aPanel1.Controls.Add(this.aLabel2);
            this.aPanel1.Controls.Add(this.pictureBox2);
            this.aPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel1.Location = new System.Drawing.Point(0, 0);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(559, 41);
            this.aPanel1.TabIndex = 18;
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.Linen;
            this.aPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel2.Controls.Add(this.aLabel1);
            this.aPanel2.Location = new System.Drawing.Point(6, 57);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(128, 36);
            this.aPanel2.TabIndex = 19;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(48, 11);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(31, 15);
            this.aLabel1.TabIndex = 23;
            this.aLabel1.Text = "화면";
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.aPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel3.Controls.Add(this.aButton1);
            this.aPanel3.Controls.Add(this.aTextBox1);
            this.aPanel3.Controls.Add(this.radioButton2);
            this.aPanel3.Controls.Add(this.radioButton1);
            this.aPanel3.Location = new System.Drawing.Point(133, 57);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.Size = new System.Drawing.Size(426, 36);
            this.aPanel3.TabIndex = 20;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(346, 3);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(75, 23);
            this.aButton1.TabIndex = 3;
            this.aButton1.Text = "조회";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aTextBox1
            // 
            this.aTextBox1.BackColor = System.Drawing.Color.White;
            this.aTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTextBox1.errorp = null;
            this.aTextBox1.Location = new System.Drawing.Point(135, 3);
            this.aTextBox1.Name = "aTextBox1";
            this.aTextBox1.Size = new System.Drawing.Size(165, 23);
            this.aTextBox1.TabIndex = 2;
            this.aTextBox1.txtType = Axxen.CustomControls.type.Normal;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "화면코드";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "화면명";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dgvScreenItem
            // 
            this.dgvScreenItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvScreenItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreenItem.Location = new System.Drawing.Point(6, 99);
            this.dgvScreenItem.Name = "dgvScreenItem";
            this.dgvScreenItem.RowTemplate.Height = 23;
            this.dgvScreenItem.Size = new System.Drawing.Size(549, 395);
            this.dgvScreenItem.TabIndex = 21;
            // 
            // aPanel4
            // 
            this.aPanel4.BackColor = System.Drawing.Color.PowderBlue;
            this.aPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel4.Controls.Add(this.aButton3);
            this.aPanel4.Controls.Add(this.aButton2);
            this.aPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel4.Location = new System.Drawing.Point(0, 512);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(559, 41);
            this.aPanel4.TabIndex = 22;
            // 
            // aButton3
            // 
            this.aButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Location = new System.Drawing.Point(473, 8);
            this.aButton3.Name = "aButton3";
            this.aButton3.Size = new System.Drawing.Size(75, 23);
            this.aButton3.TabIndex = 5;
            this.aButton3.Text = "저장";
            this.aButton3.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Location = new System.Drawing.Point(392, 8);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(75, 23);
            this.aButton2.TabIndex = 4;
            this.aButton2.Text = "확인";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // MSS_CON_002_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(559, 553);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.dgvScreenItem);
            this.Controls.Add(this.aPanel3);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aPanel1);
            this.Name = "MSS_CON_002_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "화면조회";
            this.Load += new System.EventHandler(this.MSS_CON_002_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.aPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenItem)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ALabel aLabel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ALabel aLabel2;
        private CustomControls.APanel aPanel1;
        private CustomControls.APanel aPanel2;
        private CustomControls.ALabel aLabel1;
        private CustomControls.APanel aPanel3;
        private CustomControls.AButton aButton1;
        private CustomControls.ATextBox aTextBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private CustomControls.ADataGridView dgvScreenItem;
        private CustomControls.APanel aPanel4;
        private CustomControls.AButton aButton3;
        private CustomControls.AButton aButton2;
    }
}
