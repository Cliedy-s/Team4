﻿namespace AxxenClient.Forms
{
    partial class POP_PRD_006
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
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.aTextBox_LabeledBigTextBox10 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox11 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox8 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox9 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox7 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox6 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_Searchable1 = new Axxen.CustomControls.ATextBox_Searchable();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.aPanel4.SuspendLayout();
            this.aPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "포장 언로딩";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(10, 247);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(722, 338);
            this.aDataGridView1.TabIndex = 17;
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.aButton1);
            this.aPanel4.Controls.Add(this.aButton2);
            this.aPanel4.Location = new System.Drawing.Point(737, 247);
            this.aPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(472, 338);
            this.aPanel4.TabIndex = 21;
            // 
            // aButton1
            // 
            this.aButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(5, 3);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(463, 202);
            this.aButton1.TabIndex = 25;
            this.aButton1.Text = "언로딩";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton2.Location = new System.Drawing.Point(5, 211);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(463, 124);
            this.aButton2.TabIndex = 24;
            this.aButton2.Text = "대차 비우기";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aPanel5
            // 
            this.aPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel5.Controls.Add(this.aTextBox_LabeledBigTextBox10);
            this.aPanel5.Controls.Add(this.aTextBox_LabeledBigTextBox11);
            this.aPanel5.Controls.Add(this.aTextBox_LabeledBigTextBox8);
            this.aPanel5.Controls.Add(this.aTextBox_LabeledBigTextBox9);
            this.aPanel5.Controls.Add(this.aTextBox_LabeledBigTextBox7);
            this.aPanel5.Controls.Add(this.aTextBox_LabeledBigTextBox6);
            this.aPanel5.Location = new System.Drawing.Point(12, 105);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(1191, 100);
            this.aPanel5.TabIndex = 26;
            // 
            // aTextBox_LabeledBigTextBox10
            // 
            this.aTextBox_LabeledBigTextBox10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox10.LabelText = "단위";
            this.aTextBox_LabeledBigTextBox10.Location = new System.Drawing.Point(802, 54);
            this.aTextBox_LabeledBigTextBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox10.Name = "aTextBox_LabeledBigTextBox10";
            this.aTextBox_LabeledBigTextBox10.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox10.TabIndex = 5;
            this.aTextBox_LabeledBigTextBox10.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox11
            // 
            this.aTextBox_LabeledBigTextBox11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox11.LabelText = "작업장";
            this.aTextBox_LabeledBigTextBox11.Location = new System.Drawing.Point(802, 16);
            this.aTextBox_LabeledBigTextBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox11.Name = "aTextBox_LabeledBigTextBox11";
            this.aTextBox_LabeledBigTextBox11.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox11.TabIndex = 4;
            this.aTextBox_LabeledBigTextBox11.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox8
            // 
            this.aTextBox_LabeledBigTextBox8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox8.LabelText = "실적수량";
            this.aTextBox_LabeledBigTextBox8.Location = new System.Drawing.Point(413, 54);
            this.aTextBox_LabeledBigTextBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox8.Name = "aTextBox_LabeledBigTextBox8";
            this.aTextBox_LabeledBigTextBox8.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox8.TabIndex = 3;
            this.aTextBox_LabeledBigTextBox8.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox9
            // 
            this.aTextBox_LabeledBigTextBox9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox9.LabelText = "품목";
            this.aTextBox_LabeledBigTextBox9.Location = new System.Drawing.Point(413, 16);
            this.aTextBox_LabeledBigTextBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox9.Name = "aTextBox_LabeledBigTextBox9";
            this.aTextBox_LabeledBigTextBox9.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox9.TabIndex = 2;
            this.aTextBox_LabeledBigTextBox9.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox7
            // 
            this.aTextBox_LabeledBigTextBox7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox7.LabelText = "작업지시일";
            this.aTextBox_LabeledBigTextBox7.Location = new System.Drawing.Point(16, 54);
            this.aTextBox_LabeledBigTextBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox7.Name = "aTextBox_LabeledBigTextBox7";
            this.aTextBox_LabeledBigTextBox7.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox7.TabIndex = 1;
            this.aTextBox_LabeledBigTextBox7.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox6
            // 
            this.aTextBox_LabeledBigTextBox6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox6.LabelText = "작업지시번호";
            this.aTextBox_LabeledBigTextBox6.Location = new System.Drawing.Point(16, 16);
            this.aTextBox_LabeledBigTextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox6.Name = "aTextBox_LabeledBigTextBox6";
            this.aTextBox_LabeledBigTextBox6.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox6.TabIndex = 0;
            this.aTextBox_LabeledBigTextBox6.TextBoxText = "";
            // 
            // aTextBox_Searchable1
            // 
            this.aTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable1.LabelText = "대차검색";
            this.aTextBox_Searchable1.Location = new System.Drawing.Point(12, 212);
            this.aTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable1.Name = "aTextBox_Searchable1";
            this.aTextBox_Searchable1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable1.TabIndex = 21;
            this.aTextBox_Searchable1.TextBoxText = "";
            // 
            // POP_PRD_006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aTextBox_Searchable1);
            this.Controls.Add(this.aPanel5);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aDataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_006";
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aPanel5, 0);
            this.Controls.SetChildIndex(this.aTextBox_Searchable1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.aPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.ADataGridView aDataGridView1;
        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton aButton1;
        private Axxen.CustomControls.AButton aButton2;
        private Axxen.CustomControls.APanel aPanel5;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox10;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox11;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox8;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox9;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox7;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox6;
        private Axxen.CustomControls.ATextBox_Searchable aTextBox_Searchable1;
    }
}
