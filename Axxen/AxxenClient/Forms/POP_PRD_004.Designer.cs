namespace AxxenClient.Forms
{
    partial class POP_PRD_004
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
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.aButton3 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aBigTextBox_LabeledBigTextBox5 = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.aBigTextBox_LabeledBigTextBox4 = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.aBigTextBox_LabeledBigTextBox3 = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.aBigTextBox_LabeledBigTextBox2 = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.aBigTextBox_LabeledBigTextBox1 = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.aPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "팔레트 바코드 재발행";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.aBigTextBox_LabeledBigTextBox5);
            this.aPanel4.Controls.Add(this.aBigTextBox_LabeledBigTextBox4);
            this.aPanel4.Controls.Add(this.aBigTextBox_LabeledBigTextBox3);
            this.aPanel4.Controls.Add(this.aBigTextBox_LabeledBigTextBox2);
            this.aPanel4.Controls.Add(this.aBigTextBox_LabeledBigTextBox1);
            this.aPanel4.Controls.Add(this.aButton3);
            this.aPanel4.Controls.Add(this.aButton2);
            this.aPanel4.Controls.Add(this.aButton1);
            this.aPanel4.Location = new System.Drawing.Point(649, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 7;
            // 
            // aButton3
            // 
            this.aButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton3.Location = new System.Drawing.Point(280, 375);
            this.aButton3.Name = "aButton3";
            this.aButton3.Size = new System.Drawing.Size(178, 81);
            this.aButton3.TabIndex = 18;
            this.aButton3.Text = "삭제";
            this.aButton3.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton2.Location = new System.Drawing.Point(93, 375);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(178, 81);
            this.aButton2.TabIndex = 17;
            this.aButton2.Text = "수정";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aButton1
            // 
            this.aButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(93, 288);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(365, 81);
            this.aButton1.TabIndex = 16;
            this.aButton1.Text = "재발행";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(7, 165);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(636, 422);
            this.aDataGridView1.TabIndex = 6;
            // 
            // aPanel5
            // 
            this.aPanel5.Controls.Add(this.dateTimePicker2);
            this.aPanel5.Controls.Add(this.aLabel3);
            this.aPanel5.Controls.Add(this.dateTimePicker1);
            this.aPanel5.Controls.Add(this.aLabel2);
            this.aPanel5.Location = new System.Drawing.Point(7, 105);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(636, 54);
            this.aPanel5.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(386, 14);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 29);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(346, 18);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(21, 21);
            this.aLabel3.TabIndex = 14;
            this.aLabel3.Text = "~";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 29);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(130, 18);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(74, 21);
            this.aLabel2.TabIndex = 12;
            this.aLabel2.Text = "생산일자";
            // 
            // aBigTextBox_LabeledBigTextBox5
            // 
            this.aBigTextBox_LabeledBigTextBox5.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_LabeledBigTextBox5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox5.LabelText = "팔레트 수량";
            this.aBigTextBox_LabeledBigTextBox5.Location = new System.Drawing.Point(40, 220);
            this.aBigTextBox_LabeledBigTextBox5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_LabeledBigTextBox5.Name = "aBigTextBox_LabeledBigTextBox5";
            this.aBigTextBox_LabeledBigTextBox5.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_LabeledBigTextBox5.TabIndex = 40;
            this.aBigTextBox_LabeledBigTextBox5.TextBoxText = "";
            this.aBigTextBox_LabeledBigTextBox5.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aBigTextBox_LabeledBigTextBox4
            // 
            this.aBigTextBox_LabeledBigTextBox4.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_LabeledBigTextBox4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox4.LabelText = "사이즈";
            this.aBigTextBox_LabeledBigTextBox4.Location = new System.Drawing.Point(40, 173);
            this.aBigTextBox_LabeledBigTextBox4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_LabeledBigTextBox4.Name = "aBigTextBox_LabeledBigTextBox4";
            this.aBigTextBox_LabeledBigTextBox4.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_LabeledBigTextBox4.TabIndex = 39;
            this.aBigTextBox_LabeledBigTextBox4.TextBoxText = "";
            this.aBigTextBox_LabeledBigTextBox4.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aBigTextBox_LabeledBigTextBox3
            // 
            this.aBigTextBox_LabeledBigTextBox3.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_LabeledBigTextBox3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox3.LabelText = "등급상세";
            this.aBigTextBox_LabeledBigTextBox3.Location = new System.Drawing.Point(40, 126);
            this.aBigTextBox_LabeledBigTextBox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_LabeledBigTextBox3.Name = "aBigTextBox_LabeledBigTextBox3";
            this.aBigTextBox_LabeledBigTextBox3.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_LabeledBigTextBox3.TabIndex = 38;
            this.aBigTextBox_LabeledBigTextBox3.TextBoxText = "";
            this.aBigTextBox_LabeledBigTextBox3.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aBigTextBox_LabeledBigTextBox2
            // 
            this.aBigTextBox_LabeledBigTextBox2.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_LabeledBigTextBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox2.LabelText = "등급";
            this.aBigTextBox_LabeledBigTextBox2.Location = new System.Drawing.Point(40, 79);
            this.aBigTextBox_LabeledBigTextBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_LabeledBigTextBox2.Name = "aBigTextBox_LabeledBigTextBox2";
            this.aBigTextBox_LabeledBigTextBox2.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_LabeledBigTextBox2.TabIndex = 37;
            this.aBigTextBox_LabeledBigTextBox2.TextBoxText = "";
            this.aBigTextBox_LabeledBigTextBox2.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aBigTextBox_LabeledBigTextBox1
            // 
            this.aBigTextBox_LabeledBigTextBox1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_LabeledBigTextBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox1.LabelText = "팔레트번호";
            this.aBigTextBox_LabeledBigTextBox1.Location = new System.Drawing.Point(40, 32);
            this.aBigTextBox_LabeledBigTextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_LabeledBigTextBox1.Name = "aBigTextBox_LabeledBigTextBox1";
            this.aBigTextBox_LabeledBigTextBox1.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_LabeledBigTextBox1.TabIndex = 36;
            this.aBigTextBox_LabeledBigTextBox1.TextBoxText = "";
            this.aBigTextBox_LabeledBigTextBox1.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // POP_PRD_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aPanel5);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aDataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_004";
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aPanel5, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.aPanel5.ResumeLayout(false);
            this.aPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton aButton1;
        private Axxen.CustomControls.ADataGridView aDataGridView1;
        private Axxen.CustomControls.AButton aButton3;
        private Axxen.CustomControls.AButton aButton2;
        private Axxen.CustomControls.APanel aPanel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Axxen.CustomControls.ALabel aLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Axxen.CustomControls.ALabel aLabel2;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox aBigTextBox_LabeledBigTextBox5;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox aBigTextBox_LabeledBigTextBox4;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox aBigTextBox_LabeledBigTextBox3;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox aBigTextBox_LabeledBigTextBox2;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox aBigTextBox_LabeledBigTextBox1;
    }
}
