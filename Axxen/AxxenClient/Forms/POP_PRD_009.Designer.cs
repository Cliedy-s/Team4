namespace AxxenClient.Forms
{
    partial class POP_PRD_009
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
            this.aPanel5 = new AxxenClient.CustomControls.APanel();
            this.aTextBox_Searchable4 = new AxxenClient.CustomControls.ATextBox_Searchable();
            this.aPanel4 = new AxxenClient.CustomControls.APanel();
            this.aButton1 = new AxxenClient.CustomControls.AButton();
            this.aTextBox_LabeledBigTextBox2 = new AxxenClient.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_Searchable3 = new AxxenClient.CustomControls.ATextBox_Searchable();
            this.aTextBox_Searchable2 = new AxxenClient.CustomControls.ATextBox_Searchable();
            this.aTextBox_Searchable1 = new AxxenClient.CustomControls.ATextBox_Searchable();
            this.aTextBox_LabeledBigTextBox1 = new AxxenClient.CustomControls.ATextBox_LabeledBigTextBox();
            this.aDataGridView1 = new AxxenClient.CustomControls.ADataGridView();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel5.SuspendLayout();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "적재 작업지시 생성";
            // 
            // aPanel5
            // 
            this.aPanel5.Controls.Add(this.aTextBox_Searchable4);
            this.aPanel5.Location = new System.Drawing.Point(12, 105);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(636, 47);
            this.aPanel5.TabIndex = 11;
            // 
            // aTextBox_Searchable4
            // 
            this.aTextBox_Searchable4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable4.FontSize = 9F;
            this.aTextBox_Searchable4.LabelText = "대차 검색";
            this.aTextBox_Searchable4.Location = new System.Drawing.Point(136, 9);
            this.aTextBox_Searchable4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable4.Name = "aTextBox_Searchable4";
            this.aTextBox_Searchable4.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable4.TabIndex = 0;
            this.aTextBox_Searchable4.TextBoxText = "";
            // 
            // aPanel4
            // 
            this.aPanel4.Controls.Add(this.aButton1);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox2);
            this.aPanel4.Controls.Add(this.aTextBox_Searchable3);
            this.aPanel4.Controls.Add(this.aTextBox_Searchable2);
            this.aPanel4.Controls.Add(this.aTextBox_Searchable1);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox1);
            this.aPanel4.Location = new System.Drawing.Point(654, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 10;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(92, 300);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(365, 105);
            this.aButton1.TabIndex = 22;
            this.aButton1.Text = "작업지시 생성";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aTextBox_LabeledBigTextBox2
            // 
            this.aTextBox_LabeledBigTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox2.LabelText = "계획수량";
            this.aTextBox_LabeledBigTextBox2.Location = new System.Drawing.Point(92, 229);
            this.aTextBox_LabeledBigTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox2.Name = "aTextBox_LabeledBigTextBox2";
            this.aTextBox_LabeledBigTextBox2.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox2.TabIndex = 21;
            this.aTextBox_LabeledBigTextBox2.TextBoxText = "";
            // 
            // aTextBox_Searchable3
            // 
            this.aTextBox_Searchable3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable3.FontSize = 9F;
            this.aTextBox_Searchable3.LabelText = "작업장";
            this.aTextBox_Searchable3.Location = new System.Drawing.Point(92, 153);
            this.aTextBox_Searchable3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable3.Name = "aTextBox_Searchable3";
            this.aTextBox_Searchable3.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable3.TabIndex = 20;
            this.aTextBox_Searchable3.TextBoxText = "";
            // 
            // aTextBox_Searchable2
            // 
            this.aTextBox_Searchable2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable2.FontSize = 9F;
            this.aTextBox_Searchable2.LabelText = "공정";
            this.aTextBox_Searchable2.Location = new System.Drawing.Point(92, 115);
            this.aTextBox_Searchable2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable2.Name = "aTextBox_Searchable2";
            this.aTextBox_Searchable2.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable2.TabIndex = 19;
            this.aTextBox_Searchable2.TextBoxText = "";
            // 
            // aTextBox_Searchable1
            // 
            this.aTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable1.FontSize = 9F;
            this.aTextBox_Searchable1.LabelText = "품목";
            this.aTextBox_Searchable1.Location = new System.Drawing.Point(92, 77);
            this.aTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable1.Name = "aTextBox_Searchable1";
            this.aTextBox_Searchable1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable1.TabIndex = 18;
            this.aTextBox_Searchable1.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox1
            // 
            this.aTextBox_LabeledBigTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox1.LabelText = "작업지시일";
            this.aTextBox_LabeledBigTextBox1.Location = new System.Drawing.Point(92, 191);
            this.aTextBox_LabeledBigTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox1.Name = "aTextBox_LabeledBigTextBox1";
            this.aTextBox_LabeledBigTextBox1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox1.TabIndex = 17;
            this.aTextBox_LabeledBigTextBox1.TextBoxText = "";
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(12, 158);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(636, 429);
            this.aDataGridView1.TabIndex = 9;
            // 
            // POP_PRD_009
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aPanel5);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aDataGridView1);
            this.Name = "POP_PRD_009";
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aPanel5, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel5.ResumeLayout(false);
            this.aPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.APanel aPanel5;
        private CustomControls.APanel aPanel4;
        private CustomControls.ADataGridView aDataGridView1;
        private CustomControls.AButton aButton1;
        private CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox2;
        private CustomControls.ATextBox_Searchable aTextBox_Searchable3;
        private CustomControls.ATextBox_Searchable aTextBox_Searchable2;
        private CustomControls.ATextBox_Searchable aTextBox_Searchable1;
        private CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox1;
        private CustomControls.ATextBox_Searchable aTextBox_Searchable4;
    }
}
