﻿namespace AxxenClient.Forms
{
    partial class POP_PRD_011
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
            this.aButton2 = new AxxenClient.CustomControls.AButton();
            this.aDataGridView1 = new AxxenClient.CustomControls.ADataGridView();
            this.aTextBox_Searchable1 = new AxxenClient.CustomControls.ATextBox_Searchable();
            this.aButton1 = new AxxenClient.CustomControls.AButton();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "요입/ 요출 관리";
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton2.Location = new System.Drawing.Point(960, 175);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(238, 165);
            this.aButton2.TabIndex = 31;
            this.aButton2.Text = "요입";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(12, 143);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(942, 444);
            this.aDataGridView1.TabIndex = 27;
            // 
            // aTextBox_Searchable1
            // 
            this.aTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable1.FontSize = 9F;
            this.aTextBox_Searchable1.LabelText = "대차 검색";
            this.aTextBox_Searchable1.Location = new System.Drawing.Point(12, 106);
            this.aTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable1.Name = "aTextBox_Searchable1";
            this.aTextBox_Searchable1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable1.TabIndex = 32;
            this.aTextBox_Searchable1.TextBoxText = "";
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(960, 346);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(238, 165);
            this.aButton1.TabIndex = 33;
            this.aButton1.Text = "요출";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // POP_PRD_011
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aTextBox_Searchable1);
            this.Controls.Add(this.aButton2);
            this.Controls.Add(this.aDataGridView1);
            this.Name = "POP_PRD_011";
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aButton2, 0);
            this.Controls.SetChildIndex(this.aTextBox_Searchable1, 0);
            this.Controls.SetChildIndex(this.aButton1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.AButton aButton2;
        private CustomControls.ADataGridView aDataGridView1;
        private CustomControls.ATextBox_Searchable aTextBox_Searchable1;
        private CustomControls.AButton aButton1;
    }
}