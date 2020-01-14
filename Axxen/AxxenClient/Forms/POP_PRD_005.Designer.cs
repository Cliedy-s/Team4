namespace AxxenClient.Forms
{
    partial class POP_PRD_005
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
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.aTextBox_LabeledBigTextBox5 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox6 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox3 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox4 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aTextBox_LabeledBigTextBox2 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_Searchable1 = new Axxen.CustomControls.ATextBox_Searchable();
            this.aTextBox_LabeledBigTextBox1 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aLabel_SubHeader1 = new Axxen.CustomControls.ALabel_SubHeader();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.aPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "포장 입고등록";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(7, 158);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(636, 429);
            this.aDataGridView1.TabIndex = 4;
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox5);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox6);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox3);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox4);
            this.aPanel4.Controls.Add(this.aButton1);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox2);
            this.aPanel4.Controls.Add(this.aTextBox_Searchable1);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox1);
            this.aPanel4.Location = new System.Drawing.Point(649, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 5;
            this.aPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.aPanel4_Paint);
            // 
            // aTextBox_LabeledBigTextBox5
            // 
            this.aTextBox_LabeledBigTextBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_LabeledBigTextBox5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox5.LabelText = "작업지시일";
            this.aTextBox_LabeledBigTextBox5.Location = new System.Drawing.Point(92, 171);
            this.aTextBox_LabeledBigTextBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox5.Name = "aTextBox_LabeledBigTextBox5";
            this.aTextBox_LabeledBigTextBox5.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox5.TabIndex = 20;
            this.aTextBox_LabeledBigTextBox5.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox6
            // 
            this.aTextBox_LabeledBigTextBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_LabeledBigTextBox6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox6.LabelText = "작업지시번호";
            this.aTextBox_LabeledBigTextBox6.Location = new System.Drawing.Point(92, 133);
            this.aTextBox_LabeledBigTextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox6.Name = "aTextBox_LabeledBigTextBox6";
            this.aTextBox_LabeledBigTextBox6.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox6.TabIndex = 19;
            this.aTextBox_LabeledBigTextBox6.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox3
            // 
            this.aTextBox_LabeledBigTextBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_LabeledBigTextBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox3.LabelText = "작업장";
            this.aTextBox_LabeledBigTextBox3.Location = new System.Drawing.Point(92, 247);
            this.aTextBox_LabeledBigTextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox3.Name = "aTextBox_LabeledBigTextBox3";
            this.aTextBox_LabeledBigTextBox3.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox3.TabIndex = 18;
            this.aTextBox_LabeledBigTextBox3.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox4
            // 
            this.aTextBox_LabeledBigTextBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_LabeledBigTextBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox4.LabelText = "품목";
            this.aTextBox_LabeledBigTextBox4.Location = new System.Drawing.Point(92, 209);
            this.aTextBox_LabeledBigTextBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox4.Name = "aTextBox_LabeledBigTextBox4";
            this.aTextBox_LabeledBigTextBox4.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox4.TabIndex = 17;
            this.aTextBox_LabeledBigTextBox4.TextBoxText = "";
            // 
            // aButton1
            // 
            this.aButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(92, 383);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(365, 74);
            this.aButton1.TabIndex = 16;
            this.aButton1.Text = "입고";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aTextBox_LabeledBigTextBox2
            // 
            this.aTextBox_LabeledBigTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_LabeledBigTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox2.LabelText = "팔레트수량";
            this.aTextBox_LabeledBigTextBox2.Location = new System.Drawing.Point(92, 323);
            this.aTextBox_LabeledBigTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox2.Name = "aTextBox_LabeledBigTextBox2";
            this.aTextBox_LabeledBigTextBox2.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox2.TabIndex = 15;
            this.aTextBox_LabeledBigTextBox2.TextBoxText = "";
            // 
            // aTextBox_Searchable1
            // 
            this.aTextBox_Searchable1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable1.LabelText = "팔레트 번호";
            this.aTextBox_Searchable1.Location = new System.Drawing.Point(92, 95);
            this.aTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable1.Name = "aTextBox_Searchable1";
            this.aTextBox_Searchable1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable1.TabIndex = 12;
            this.aTextBox_Searchable1.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox1
            // 
            this.aTextBox_LabeledBigTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_LabeledBigTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox1.LabelText = "등급";
            this.aTextBox_LabeledBigTextBox1.Location = new System.Drawing.Point(92, 285);
            this.aTextBox_LabeledBigTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox1.Name = "aTextBox_LabeledBigTextBox1";
            this.aTextBox_LabeledBigTextBox1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox1.TabIndex = 11;
            this.aTextBox_LabeledBigTextBox1.TextBoxText = "";
            // 
            // aLabel_SubHeader1
            // 
            this.aLabel_SubHeader1.AutoSize = true;
            this.aLabel_SubHeader1.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold);
            this.aLabel_SubHeader1.Location = new System.Drawing.Point(226, 120);
            this.aLabel_SubHeader1.Name = "aLabel_SubHeader1";
            this.aLabel_SubHeader1.Size = new System.Drawing.Size(199, 23);
            this.aLabel_SubHeader1.TabIndex = 6;
            this.aLabel_SubHeader1.Text = "금일 입고 팔레트 목록";
            // 
            // POP_PRD_005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aLabel_SubHeader1);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aDataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_005";
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aLabel_SubHeader1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Axxen.CustomControls.ADataGridView aDataGridView1;
        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton aButton1;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox2;
        private Axxen.CustomControls.ATextBox_Searchable aTextBox_Searchable1;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox1;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox5;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox6;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox3;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox4;
        private Axxen.CustomControls.ALabel_SubHeader aLabel_SubHeader1;
    }
}
