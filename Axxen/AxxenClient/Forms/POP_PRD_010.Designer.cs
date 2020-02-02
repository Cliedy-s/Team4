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
            this.dgvGVTo = new Axxen.CustomControls.ADataGridView();
            this.dgvGVFrom = new Axxen.CustomControls.ADataGridView();
            this.btnClearGV = new Axxen.CustomControls.AButton();
            this.btnMove = new Axxen.CustomControls.AButton();
            this.txtWorkOrderno = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderDate = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtItemName = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtQty = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWcCode = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtUnit = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.aBigTextBox_Searchable2 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.aBigTextBox_Searchable1 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.txtMove = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVFrom)).BeginInit();
            this.aPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "적재 실적 등록";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 791);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // dgvGVTo
            // 
            this.dgvGVTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGVTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGVTo.Location = new System.Drawing.Point(13, 329);
            this.dgvGVTo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGVTo.Name = "dgvGVTo";
            this.dgvGVTo.RowHeadersWidth = 51;
            this.dgvGVTo.RowTemplate.Height = 23;
            this.dgvGVTo.Size = new System.Drawing.Size(576, 451);
            this.dgvGVTo.TabIndex = 8;
            // 
            // dgvGVFrom
            // 
            this.dgvGVFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGVFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGVFrom.Location = new System.Drawing.Point(995, 329);
            this.dgvGVFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGVFrom.Name = "dgvGVFrom";
            this.dgvGVFrom.RowHeadersWidth = 51;
            this.dgvGVFrom.RowTemplate.Height = 23;
            this.dgvGVFrom.Size = new System.Drawing.Size(545, 451);
            this.dgvGVFrom.TabIndex = 11;
            this.dgvGVFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGVFrom_CellClick);
            // 
            // btnClearGV
            // 
            this.btnClearGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnClearGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearGV.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClearGV.Location = new System.Drawing.Point(597, 653);
            this.btnClearGV.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearGV.Name = "btnClearGV";
            this.btnClearGV.Size = new System.Drawing.Size(391, 127);
            this.btnClearGV.TabIndex = 14;
            this.btnClearGV.Text = "건조대차\r\n비우기";
            this.btnClearGV.UseVisualStyleBackColor = false;
            this.btnClearGV.Click += new System.EventHandler(this.btnClearGV_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMove.Location = new System.Drawing.Point(597, 384);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(391, 261);
            this.btnMove.TabIndex = 15;
            this.btnMove.Text = "옮겨타기";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // txtWorkOrderno
            // 
            this.txtWorkOrderno.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderno.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderno.LabelText = "작업지시번호";
            this.txtWorkOrderno.Location = new System.Drawing.Point(21, 8);
            this.txtWorkOrderno.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtWorkOrderno.Name = "txtWorkOrderno";
            this.txtWorkOrderno.Size = new System.Drawing.Size(469, 55);
            this.txtWorkOrderno.TabIndex = 0;
            this.txtWorkOrderno.TextBoxText = "";
            this.txtWorkOrderno.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWorkOrderDate
            // 
            this.txtWorkOrderDate.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderDate.LabelText = "작업지시일";
            this.txtWorkOrderDate.Location = new System.Drawing.Point(21, 71);
            this.txtWorkOrderDate.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtWorkOrderDate.Name = "txtWorkOrderDate";
            this.txtWorkOrderDate.Size = new System.Drawing.Size(469, 55);
            this.txtWorkOrderDate.TabIndex = 1;
            this.txtWorkOrderDate.TextBoxText = "";
            this.txtWorkOrderDate.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtItemName
            // 
            this.txtItemName.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.LabelText = "품목";
            this.txtItemName.Location = new System.Drawing.Point(531, 8);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(469, 55);
            this.txtItemName.TabIndex = 2;
            this.txtItemName.TextBoxText = "";
            this.txtItemName.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtQty
            // 
            this.txtQty.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.LabelText = "실적수량";
            this.txtQty.Location = new System.Drawing.Point(531, 71);
            this.txtQty.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(469, 55);
            this.txtQty.TabIndex = 3;
            this.txtQty.TextBoxText = "";
            this.txtQty.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWcCode
            // 
            this.txtWcCode.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcCode.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcCode.LabelText = "작업장";
            this.txtWcCode.Location = new System.Drawing.Point(1031, 8);
            this.txtWcCode.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtWcCode.Name = "txtWcCode";
            this.txtWcCode.Size = new System.Drawing.Size(469, 55);
            this.txtWcCode.TabIndex = 4;
            this.txtWcCode.TextBoxText = "";
            this.txtWcCode.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtUnit
            // 
            this.txtUnit.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUnit.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUnit.LabelText = "단위";
            this.txtUnit.Location = new System.Drawing.Point(1031, 71);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(469, 55);
            this.txtUnit.TabIndex = 5;
            this.txtUnit.TextBoxText = "";
            this.txtUnit.TextBoxType = Axxen.CustomControls.TextType.Normal;
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
            this.aPanel6.Location = new System.Drawing.Point(13, 140);
            this.aPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(1531, 133);
            this.aPanel6.TabIndex = 17;
            // 
            // aBigTextBox_Searchable2
            // 
            this.aBigTextBox_Searchable2.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aBigTextBox_Searchable2.CodeText = null;
            this.aBigTextBox_Searchable2.DataType = Axxen.CustomControls.DataType.Users;
            this.aBigTextBox_Searchable2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable2.LabelText = "대차검색";
            this.aBigTextBox_Searchable2.Location = new System.Drawing.Point(995, 273);
            this.aBigTextBox_Searchable2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.aBigTextBox_Searchable2.Name = "aBigTextBox_Searchable2";
            this.aBigTextBox_Searchable2.Size = new System.Drawing.Size(550, 56);
            this.aBigTextBox_Searchable2.TabIndex = 28;
            this.aBigTextBox_Searchable2.TextBoxText = "";
            this.aBigTextBox_Searchable2.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aBigTextBox_Searchable1
            // 
            this.aBigTextBox_Searchable1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable1.CodeText = null;
            this.aBigTextBox_Searchable1.DataType = Axxen.CustomControls.DataType.Users;
            this.aBigTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable1.LabelText = "대차검색";
            this.aBigTextBox_Searchable1.Location = new System.Drawing.Point(14, 273);
            this.aBigTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.aBigTextBox_Searchable1.Name = "aBigTextBox_Searchable1";
            this.aBigTextBox_Searchable1.Size = new System.Drawing.Size(549, 56);
            this.aBigTextBox_Searchable1.TabIndex = 27;
            this.aBigTextBox_Searchable1.TextBoxText = "";
            this.aBigTextBox_Searchable1.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtMove
            // 
            this.txtMove.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMove.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMove.LabelText = "옮겨타기 수량";
            this.txtMove.Location = new System.Drawing.Point(595, 329);
            this.txtMove.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtMove.Name = "txtMove";
            this.txtMove.Size = new System.Drawing.Size(393, 55);
            this.txtMove.TabIndex = 29;
            this.txtMove.TextBoxText = "";
            this.txtMove.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // POP_PRD_010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1556, 839);
            this.Controls.Add(this.txtMove);
            this.Controls.Add(this.aBigTextBox_Searchable2);
            this.Controls.Add(this.aBigTextBox_Searchable1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnClearGV);
            this.Controls.Add(this.dgvGVFrom);
            this.Controls.Add(this.dgvGVTo);
            this.Controls.Add(this.aPanel6);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "POP_PRD_010";
            this.Load += new System.EventHandler(this.POP_PRD_010_Load);
            this.Controls.SetChildIndex(this.aPanel6, 0);
            this.Controls.SetChildIndex(this.dgvGVTo, 0);
            this.Controls.SetChildIndex(this.dgvGVFrom, 0);
            this.Controls.SetChildIndex(this.btnClearGV, 0);
            this.Controls.SetChildIndex(this.btnMove, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aBigTextBox_Searchable1, 0);
            this.Controls.SetChildIndex(this.aBigTextBox_Searchable2, 0);
            this.Controls.SetChildIndex(this.txtMove, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVFrom)).EndInit();
            this.aPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.ADataGridView dgvGVTo;
        private Axxen.CustomControls.ADataGridView dgvGVFrom;
        private Axxen.CustomControls.AButton btnClearGV;
        private Axxen.CustomControls.AButton btnMove;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderno;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderDate;
        private Axxen.CustomControls.ABigTextBox_Labeled txtItemName;
        private Axxen.CustomControls.ABigTextBox_Labeled txtQty;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWcCode;
        private Axxen.CustomControls.ABigTextBox_Labeled txtUnit;
        private Axxen.CustomControls.APanel aPanel6;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable2;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable1;
        private Axxen.CustomControls.ABigTextBox_Labeled txtMove;
    }
}
