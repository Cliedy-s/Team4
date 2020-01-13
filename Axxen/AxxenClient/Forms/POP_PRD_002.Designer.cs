namespace AxxenClient.Forms
{
    partial class POP_PRD_002
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
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aTextBox_LabeledBigTextBox2 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_Searchable3 = new Axxen.CustomControls.ATextBox_Searchable();
            this.aTextBox_Searchable2 = new Axxen.CustomControls.ATextBox_Searchable();
            this.aTextBox_Searchable1 = new Axxen.CustomControls.ATextBox_Searchable();
            this.aTextBox_LabeledBigTextBox1 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Location = new System.Drawing.Point(237, 39);
            this.aLabel_Header1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.aLabel_Header1.Text = "작업지시 생성";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 791);
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.aButton1);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox2);
            this.aPanel4.Controls.Add(this.aTextBox_Searchable3);
            this.aPanel4.Controls.Add(this.aTextBox_Searchable2);
            this.aPanel4.Controls.Add(this.aTextBox_Searchable1);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox1);
            this.aPanel4.Location = new System.Drawing.Point(834, 140);
            this.aPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(706, 643);
            this.aPanel4.TabIndex = 7;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(118, 400);
            this.aButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(469, 140);
            this.aButton1.TabIndex = 16;
            this.aButton1.Text = "작업지시 생성";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aTextBox_LabeledBigTextBox2
            // 
            this.aTextBox_LabeledBigTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox2.LabelText = "계획수량";
            this.aTextBox_LabeledBigTextBox2.Location = new System.Drawing.Point(118, 305);
            this.aTextBox_LabeledBigTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aTextBox_LabeledBigTextBox2.Name = "aTextBox_LabeledBigTextBox2";
            this.aTextBox_LabeledBigTextBox2.Size = new System.Drawing.Size(469, 40);
            this.aTextBox_LabeledBigTextBox2.TabIndex = 15;
            this.aTextBox_LabeledBigTextBox2.TextBoxText = "";
            // 
            // aTextBox_Searchable3
            // 
            this.aTextBox_Searchable3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable3.LabelText = "작업장";
            this.aTextBox_Searchable3.Location = new System.Drawing.Point(118, 204);
            this.aTextBox_Searchable3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aTextBox_Searchable3.Name = "aTextBox_Searchable3";
            this.aTextBox_Searchable3.Size = new System.Drawing.Size(469, 40);
            this.aTextBox_Searchable3.TabIndex = 14;
            this.aTextBox_Searchable3.TextBoxText = "";
            // 
            // aTextBox_Searchable2
            // 
            this.aTextBox_Searchable2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable2.LabelText = "공정";
            this.aTextBox_Searchable2.Location = new System.Drawing.Point(118, 153);
            this.aTextBox_Searchable2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aTextBox_Searchable2.Name = "aTextBox_Searchable2";
            this.aTextBox_Searchable2.Size = new System.Drawing.Size(469, 40);
            this.aTextBox_Searchable2.TabIndex = 13;
            this.aTextBox_Searchable2.TextBoxText = "";
            // 
            // aTextBox_Searchable1
            // 
            this.aTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable1.LabelText = "품목";
            this.aTextBox_Searchable1.Location = new System.Drawing.Point(118, 103);
            this.aTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aTextBox_Searchable1.Name = "aTextBox_Searchable1";
            this.aTextBox_Searchable1.Size = new System.Drawing.Size(469, 40);
            this.aTextBox_Searchable1.TabIndex = 12;
            this.aTextBox_Searchable1.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox1
            // 
            this.aTextBox_LabeledBigTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox1.LabelText = "작업지시일";
            this.aTextBox_LabeledBigTextBox1.Location = new System.Drawing.Point(118, 255);
            this.aTextBox_LabeledBigTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aTextBox_LabeledBigTextBox1.Name = "aTextBox_LabeledBigTextBox1";
            this.aTextBox_LabeledBigTextBox1.Size = new System.Drawing.Size(469, 40);
            this.aTextBox_LabeledBigTextBox1.TabIndex = 11;
            this.aTextBox_LabeledBigTextBox1.TextBoxText = "";
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(9, 140);
            this.aDataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(818, 643);
            this.aDataGridView1.TabIndex = 6;
            // 
            // POP_PRD_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1556, 839);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aDataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "POP_PRD_002";
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton aButton1;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox2;
        private Axxen.CustomControls.ATextBox_Searchable aTextBox_Searchable3;
        private Axxen.CustomControls.ATextBox_Searchable aTextBox_Searchable2;
        private Axxen.CustomControls.ATextBox_Searchable aTextBox_Searchable1;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox1;
        private Axxen.CustomControls.ADataGridView aDataGridView1;
    }
}
