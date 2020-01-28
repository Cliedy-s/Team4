namespace AxxenClient.Forms
{
    partial class POP_PRD_014
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
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aDataGridView2 = new Axxen.CustomControls.ADataGridView();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.txtUnit = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWcCode = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtQty = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtItemName = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderDate = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderno = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.aBigTextBox_LabeledBigTextBox1 = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.aPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "공정조건 등록";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aButton2
            // 
            this.aButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton2.Location = new System.Drawing.Point(626, 473);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(409, 112);
            this.aButton2.TabIndex = 29;
            this.aButton2.Text = "입력";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aDataGridView2
            // 
            this.aDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView2.Location = new System.Drawing.Point(626, 211);
            this.aDataGridView2.Name = "aDataGridView2";
            this.aDataGridView2.RowHeadersWidth = 51;
            this.aDataGridView2.RowTemplate.Height = 23;
            this.aDataGridView2.Size = new System.Drawing.Size(574, 217);
            this.aDataGridView2.TabIndex = 26;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(10, 211);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(610, 374);
            this.aDataGridView1.TabIndex = 24;
            // 
            // aButton1
            // 
            this.aButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(1042, 473);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(160, 112);
            this.aButton1.TabIndex = 31;
            this.aButton1.Text = "삭제";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aPanel6
            // 
            this.aPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel6.Controls.Add(this.txtUnit);
            this.aPanel6.Controls.Add(this.txtWcCode);
            this.aPanel6.Controls.Add(this.txtQty);
            this.aPanel6.Controls.Add(this.txtItemName);
            this.aPanel6.Controls.Add(this.txtWorkOrderDate);
            this.aPanel6.Controls.Add(this.txtWorkOrderno);
            this.aPanel6.Location = new System.Drawing.Point(10, 105);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(1191, 100);
            this.aPanel6.TabIndex = 34;
            // 
            // txtUnit
            // 
            this.txtUnit.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUnit.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUnit.LabelText = "단위";
            this.txtUnit.Location = new System.Drawing.Point(802, 53);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(365, 41);
            this.txtUnit.TabIndex = 5;
            this.txtUnit.TextBoxText = "";
            this.txtUnit.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWcCode
            // 
            this.txtWcCode.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcCode.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcCode.LabelText = "작업장";
            this.txtWcCode.Location = new System.Drawing.Point(802, 6);
            this.txtWcCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWcCode.Name = "txtWcCode";
            this.txtWcCode.Size = new System.Drawing.Size(365, 41);
            this.txtWcCode.TabIndex = 4;
            this.txtWcCode.TextBoxText = "";
            this.txtWcCode.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtQty
            // 
            this.txtQty.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.LabelText = "실적수량";
            this.txtQty.Location = new System.Drawing.Point(413, 53);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(365, 41);
            this.txtQty.TabIndex = 3;
            this.txtQty.TextBoxText = "";
            this.txtQty.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtItemName
            // 
            this.txtItemName.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.LabelText = "품목";
            this.txtItemName.Location = new System.Drawing.Point(413, 6);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(365, 41);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.TextBoxText = "";
            this.txtItemName.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWorkOrderDate
            // 
            this.txtWorkOrderDate.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderDate.LabelText = "작업지시일";
            this.txtWorkOrderDate.Location = new System.Drawing.Point(16, 53);
            this.txtWorkOrderDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWorkOrderDate.Name = "txtWorkOrderDate";
            this.txtWorkOrderDate.Size = new System.Drawing.Size(365, 41);
            this.txtWorkOrderDate.TabIndex = 1;
            this.txtWorkOrderDate.TextBoxText = "";
            this.txtWorkOrderDate.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWorkOrderno
            // 
            this.txtWorkOrderno.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderno.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderno.LabelText = "작업지시번호";
            this.txtWorkOrderno.Location = new System.Drawing.Point(16, 6);
            this.txtWorkOrderno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWorkOrderno.Name = "txtWorkOrderno";
            this.txtWorkOrderno.Size = new System.Drawing.Size(365, 41);
            this.txtWorkOrderno.TabIndex = 0;
            this.txtWorkOrderno.TextBoxText = "";
            this.txtWorkOrderno.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aBigTextBox_LabeledBigTextBox1
            // 
            this.aBigTextBox_LabeledBigTextBox1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aBigTextBox_LabeledBigTextBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox1.LabelText = "측정값";
            this.aBigTextBox_LabeledBigTextBox1.Location = new System.Drawing.Point(628, 430);
            this.aBigTextBox_LabeledBigTextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_LabeledBigTextBox1.Name = "aBigTextBox_LabeledBigTextBox1";
            this.aBigTextBox_LabeledBigTextBox1.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_LabeledBigTextBox1.TabIndex = 35;
            this.aBigTextBox_LabeledBigTextBox1.TextBoxText = "";
            this.aBigTextBox_LabeledBigTextBox1.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // POP_PRD_014
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aBigTextBox_LabeledBigTextBox1);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aButton2);
            this.Controls.Add(this.aDataGridView2);
            this.Controls.Add(this.aDataGridView1);
            this.Controls.Add(this.aPanel6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_014";
            this.Controls.SetChildIndex(this.aPanel6, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aDataGridView2, 0);
            this.Controls.SetChildIndex(this.aButton2, 0);
            this.Controls.SetChildIndex(this.aButton1, 0);
            this.Controls.SetChildIndex(this.aBigTextBox_LabeledBigTextBox1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.aPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.AButton aButton2;
        private Axxen.CustomControls.ADataGridView aDataGridView2;
        private Axxen.CustomControls.ADataGridView aDataGridView1;
        private Axxen.CustomControls.AButton aButton1;
        private Axxen.CustomControls.APanel aPanel6;
        private Axxen.CustomControls.ABigTextBox_Labeled txtUnit;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWcCode;
        private Axxen.CustomControls.ABigTextBox_Labeled txtQty;
        private Axxen.CustomControls.ABigTextBox_Labeled txtItemName;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderDate;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderno;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox aBigTextBox_LabeledBigTextBox1;
    }
}
