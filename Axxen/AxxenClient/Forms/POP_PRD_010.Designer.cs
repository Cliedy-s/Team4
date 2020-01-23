namespace AxxenClient.Forms
{
    partial class POP_PRD_010
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
            this.aDataGridView2 = new Axxen.CustomControls.ADataGridView();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.txtWorkOrderno = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderDate = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtItemName = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtQty = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWcCode = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtUnit = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.aBigTextBox_Searchable2 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.aBigTextBox_Searchable1 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.aBigTextBox_Labeled1 = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).BeginInit();
            this.aPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "적재 실적 등록";
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
            this.aDataGridView1.Location = new System.Drawing.Point(10, 247);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(448, 338);
            this.aDataGridView1.TabIndex = 8;
            // 
            // aDataGridView2
            // 
            this.aDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView2.Location = new System.Drawing.Point(774, 247);
            this.aDataGridView2.Name = "aDataGridView2";
            this.aDataGridView2.RowHeadersWidth = 51;
            this.aDataGridView2.RowTemplate.Height = 23;
            this.aDataGridView2.Size = new System.Drawing.Size(424, 338);
            this.aDataGridView2.TabIndex = 11;
            // 
            // aButton1
            // 
            this.aButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(464, 490);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(304, 95);
            this.aButton1.TabIndex = 14;
            this.aButton1.Text = "건조대차\r\n비우기";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton2.Location = new System.Drawing.Point(464, 288);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(304, 196);
            this.aButton2.TabIndex = 15;
            this.aButton2.Text = "옮겨타기";
            this.aButton2.UseVisualStyleBackColor = false;
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
            this.txtWorkOrderno.TextBoxType = Axxen.CustomControls.type.Normal;
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
            this.txtWorkOrderDate.TextBoxType = Axxen.CustomControls.type.Normal;
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
            this.txtItemName.TextBoxType = Axxen.CustomControls.type.Normal;
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
            this.txtQty.TextBoxType = Axxen.CustomControls.type.Normal;
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
            this.txtWcCode.TextBoxType = Axxen.CustomControls.type.Normal;
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
            this.txtUnit.TextBoxType = Axxen.CustomControls.type.Normal;
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
            this.aPanel6.TabIndex = 17;
            // 
            // aBigTextBox_Searchable2
            // 
            this.aBigTextBox_Searchable2.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aBigTextBox_Searchable2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable2.LabelText = "대차검색";
            this.aBigTextBox_Searchable2.Location = new System.Drawing.Point(774, 205);
            this.aBigTextBox_Searchable2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_Searchable2.Name = "aBigTextBox_Searchable2";
            this.aBigTextBox_Searchable2.Size = new System.Drawing.Size(428, 42);
            this.aBigTextBox_Searchable2.TabIndex = 28;
            this.aBigTextBox_Searchable2.TextBoxText = "";
            this.aBigTextBox_Searchable2.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // aBigTextBox_Searchable1
            // 
            this.aBigTextBox_Searchable1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable1.LabelText = "대차검색";
            this.aBigTextBox_Searchable1.Location = new System.Drawing.Point(11, 205);
            this.aBigTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_Searchable1.Name = "aBigTextBox_Searchable1";
            this.aBigTextBox_Searchable1.Size = new System.Drawing.Size(427, 42);
            this.aBigTextBox_Searchable1.TabIndex = 27;
            this.aBigTextBox_Searchable1.TextBoxText = "";
            this.aBigTextBox_Searchable1.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // aBigTextBox_Labeled1
            // 
            this.aBigTextBox_Labeled1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Labeled1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aBigTextBox_Labeled1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Labeled1.LabelText = "옮겨타기 수량";
            this.aBigTextBox_Labeled1.Location = new System.Drawing.Point(463, 247);
            this.aBigTextBox_Labeled1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_Labeled1.Name = "aBigTextBox_Labeled1";
            this.aBigTextBox_Labeled1.Size = new System.Drawing.Size(306, 41);
            this.aBigTextBox_Labeled1.TabIndex = 29;
            this.aBigTextBox_Labeled1.TextBoxText = "";
            this.aBigTextBox_Labeled1.TextBoxType = Axxen.CustomControls.type.Numeric;
            // 
            // POP_PRD_010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aBigTextBox_Labeled1);
            this.Controls.Add(this.aBigTextBox_Searchable2);
            this.Controls.Add(this.aBigTextBox_Searchable1);
            this.Controls.Add(this.aButton2);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aDataGridView2);
            this.Controls.Add(this.aDataGridView1);
            this.Controls.Add(this.aPanel6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_010";
            this.Controls.SetChildIndex(this.aPanel6, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aDataGridView2, 0);
            this.Controls.SetChildIndex(this.aButton1, 0);
            this.Controls.SetChildIndex(this.aButton2, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aBigTextBox_Searchable1, 0);
            this.Controls.SetChildIndex(this.aBigTextBox_Searchable2, 0);
            this.Controls.SetChildIndex(this.aBigTextBox_Labeled1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).EndInit();
            this.aPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.ADataGridView aDataGridView1;
        private Axxen.CustomControls.ADataGridView aDataGridView2;
        private Axxen.CustomControls.AButton aButton1;
        private Axxen.CustomControls.AButton aButton2;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderno;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderDate;
        private Axxen.CustomControls.ABigTextBox_Labeled txtItemName;
        private Axxen.CustomControls.ABigTextBox_Labeled txtQty;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWcCode;
        private Axxen.CustomControls.ABigTextBox_Labeled txtUnit;
        private Axxen.CustomControls.APanel aPanel6;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable2;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable1;
        private Axxen.CustomControls.ABigTextBox_Labeled aBigTextBox_Labeled1;
    }
}
