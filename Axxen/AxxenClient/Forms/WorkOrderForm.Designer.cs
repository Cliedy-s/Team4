namespace AxxenClient.Forms
{
    partial class WorkOrderForm
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
            this.aDataGridView1 = new AxxenClient.CustomControls.ADataGridView();
            this.aTextBox_Searchable1 = new AxxenClient.CustomControls.ATextBox_Searchable();
            this.aTextBox_Searchable2 = new AxxenClient.CustomControls.ATextBox_Searchable();
            this.aTextBox_Searchable3 = new AxxenClient.CustomControls.ATextBox_Searchable();
            this.aTextBox_LabeledBigTextBox1 = new AxxenClient.CustomControls.ATextBox_LabeledBigTextBox();
            this.aTextBox_LabeledBigTextBox2 = new AxxenClient.CustomControls.ATextBox_LabeledBigTextBox();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "작업지시 생성";
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(7, 105);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(636, 482);
            this.aDataGridView1.TabIndex = 4;
            // 
            // aTextBox_Searchable1
            // 
            this.aTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable1.FontSize = 9F;
            this.aTextBox_Searchable1.LabelText = "lblName";
            this.aTextBox_Searchable1.Location = new System.Drawing.Point(681, 130);
            this.aTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable1.Name = "aTextBox_Searchable1";
            this.aTextBox_Searchable1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable1.TabIndex = 5;
            this.aTextBox_Searchable1.TextBoxText = "";
            // 
            // aTextBox_Searchable2
            // 
            this.aTextBox_Searchable2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable2.FontSize = 9F;
            this.aTextBox_Searchable2.LabelText = "lblName";
            this.aTextBox_Searchable2.Location = new System.Drawing.Point(681, 168);
            this.aTextBox_Searchable2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable2.Name = "aTextBox_Searchable2";
            this.aTextBox_Searchable2.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable2.TabIndex = 6;
            this.aTextBox_Searchable2.TextBoxText = "";
            // 
            // aTextBox_Searchable3
            // 
            this.aTextBox_Searchable3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable3.FontSize = 9F;
            this.aTextBox_Searchable3.LabelText = "lblName";
            this.aTextBox_Searchable3.Location = new System.Drawing.Point(681, 206);
            this.aTextBox_Searchable3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable3.Name = "aTextBox_Searchable3";
            this.aTextBox_Searchable3.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable3.TabIndex = 7;
            this.aTextBox_Searchable3.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox1
            // 
            this.aTextBox_LabeledBigTextBox1.LabelText = "lblName";
            this.aTextBox_LabeledBigTextBox1.Location = new System.Drawing.Point(681, 244);
            this.aTextBox_LabeledBigTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox1.Name = "aTextBox_LabeledBigTextBox1";
            this.aTextBox_LabeledBigTextBox1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox1.TabIndex = 8;
            this.aTextBox_LabeledBigTextBox1.TextBoxText = "";
            // 
            // aTextBox_LabeledBigTextBox2
            // 
            this.aTextBox_LabeledBigTextBox2.LabelText = "lblName";
            this.aTextBox_LabeledBigTextBox2.Location = new System.Drawing.Point(681, 283);
            this.aTextBox_LabeledBigTextBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.aTextBox_LabeledBigTextBox2.Name = "aTextBox_LabeledBigTextBox2";
            this.aTextBox_LabeledBigTextBox2.Size = new System.Drawing.Size(365, 38);
            this.aTextBox_LabeledBigTextBox2.TabIndex = 9;
            this.aTextBox_LabeledBigTextBox2.TextBoxText = "";
            // 
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aTextBox_LabeledBigTextBox2);
            this.Controls.Add(this.aTextBox_LabeledBigTextBox1);
            this.Controls.Add(this.aTextBox_Searchable3);
            this.Controls.Add(this.aTextBox_Searchable2);
            this.Controls.Add(this.aTextBox_Searchable1);
            this.Controls.Add(this.aDataGridView1);
            this.Name = "WorkOrderForm";
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aTextBox_Searchable1, 0);
            this.Controls.SetChildIndex(this.aTextBox_Searchable2, 0);
            this.Controls.SetChildIndex(this.aTextBox_Searchable3, 0);
            this.Controls.SetChildIndex(this.aTextBox_LabeledBigTextBox1, 0);
            this.Controls.SetChildIndex(this.aTextBox_LabeledBigTextBox2, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ADataGridView aDataGridView1;
        private CustomControls.ATextBox_Searchable aTextBox_Searchable1;
        private CustomControls.ATextBox_Searchable aTextBox_Searchable2;
        private CustomControls.ATextBox_Searchable aTextBox_Searchable3;
        private CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox1;
        private CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox2;
    }
}
