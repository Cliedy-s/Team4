namespace AxxenClient.Forms
{
    partial class POP_PRD_007
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
            this.btnLoading = new Axxen.CustomControls.AButton();
            this.dgvGVFrom = new Axxen.CustomControls.ADataGridView();
            this.dgvGVTo = new Axxen.CustomControls.ADataGridView();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.txtUnit = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWcCode = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtQty = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtItemName = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderDate = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderno = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtLoading = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.btnFromSearch = new Axxen.CustomControls.AButton();
            this.btnToSearch = new Axxen.CustomControls.AButton();
            this.txtFromGVSearch = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtToGVSearch = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.btnKeypad = new Axxen.CustomControls.AButton();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVTo)).BeginInit();
            this.aPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(0, 593);
            this.panBottom.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aLabel_Header1
            // 
            this.lblHeaderHeader.Text = "성형 생산 대차 선택";
            // 
            // btnLoading
            // 
            this.btnLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoading.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoading.Location = new System.Drawing.Point(387, 312);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(306, 246);
            this.btnLoading.TabIndex = 22;
            this.btnLoading.Text = "로딩";
            this.btnLoading.UseVisualStyleBackColor = false;
            this.btnLoading.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvGVFrom
            // 
            this.dgvGVFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGVFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGVFrom.Location = new System.Drawing.Point(700, 247);
            this.dgvGVFrom.Name = "dgvGVFrom";
            this.dgvGVFrom.RowHeadersWidth = 51;
            this.dgvGVFrom.RowTemplate.Height = 23;
            this.dgvGVFrom.Size = new System.Drawing.Size(498, 338);
            this.dgvGVFrom.TabIndex = 19;
            this.dgvGVFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGVFrom_CellClick);
            // 
            // dgvGVTo
            // 
            this.dgvGVTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGVTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGVTo.Location = new System.Drawing.Point(7, 247);
            this.dgvGVTo.Name = "dgvGVTo";
            this.dgvGVTo.RowHeadersWidth = 51;
            this.dgvGVTo.RowTemplate.Height = 23;
            this.dgvGVTo.Size = new System.Drawing.Size(374, 338);
            this.dgvGVTo.TabIndex = 17;
            // 
            // aPanel6
            // 
            this.aPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aPanel6.Controls.Add(this.txtUnit);
            this.aPanel6.Controls.Add(this.txtWcCode);
            this.aPanel6.Controls.Add(this.txtQty);
            this.aPanel6.Controls.Add(this.txtItemName);
            this.aPanel6.Controls.Add(this.txtWorkOrderDate);
            this.aPanel6.Controls.Add(this.txtWorkOrderno);
            this.aPanel6.Location = new System.Drawing.Point(7, 105);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(1191, 100);
            this.aPanel6.TabIndex = 24;
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
            this.txtUnit.TextBoxType = Axxen.CustomControls.TextType.ReadOnly;
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
            this.txtWcCode.TextBoxType = Axxen.CustomControls.TextType.ReadOnly;
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
            this.txtQty.TextBoxType = Axxen.CustomControls.TextType.ReadOnly;
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
            this.txtItemName.TextBoxType = Axxen.CustomControls.TextType.ReadOnly;
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
            this.txtWorkOrderDate.TextBoxType = Axxen.CustomControls.TextType.ReadOnly;
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
            this.txtWorkOrderno.TextBoxType = Axxen.CustomControls.TextType.ReadOnly;
            // 
            // txtLoading
            // 
            this.txtLoading.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLoading.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLoading.LabelText = "옮겨타기 수량";
            this.txtLoading.Location = new System.Drawing.Point(387, 269);
            this.txtLoading.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLoading.Name = "txtLoading";
            this.txtLoading.Size = new System.Drawing.Size(306, 41);
            this.txtLoading.TabIndex = 27;
            this.txtLoading.TextBoxText = "";
            this.txtLoading.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // btnFromSearch
            // 
            this.btnFromSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnFromSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFromSearch.Location = new System.Drawing.Point(989, 212);
            this.btnFromSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFromSearch.Name = "btnFromSearch";
            this.btnFromSearch.Size = new System.Drawing.Size(69, 29);
            this.btnFromSearch.TabIndex = 39;
            this.btnFromSearch.Text = "검색";
            this.btnFromSearch.UseVisualStyleBackColor = false;
            this.btnFromSearch.Click += new System.EventHandler(this.btnFromSearch_Click);
            // 
            // btnToSearch
            // 
            this.btnToSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnToSearch.Location = new System.Drawing.Point(300, 212);
            this.btnToSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnToSearch.Name = "btnToSearch";
            this.btnToSearch.Size = new System.Drawing.Size(69, 29);
            this.btnToSearch.TabIndex = 38;
            this.btnToSearch.Text = "검색";
            this.btnToSearch.UseVisualStyleBackColor = false;
            this.btnToSearch.Click += new System.EventHandler(this.btnToSearch_Click);
            // 
            // txtFromGVSearch
            // 
            this.txtFromGVSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFromGVSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFromGVSearch.LabelText = "대차검색";
            this.txtFromGVSearch.Location = new System.Drawing.Point(700, 206);
            this.txtFromGVSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFromGVSearch.Name = "txtFromGVSearch";
            this.txtFromGVSearch.Size = new System.Drawing.Size(292, 41);
            this.txtFromGVSearch.TabIndex = 37;
            this.txtFromGVSearch.TextBoxText = "";
            this.txtFromGVSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtToGVSearch
            // 
            this.txtToGVSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtToGVSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtToGVSearch.LabelText = "대차검색";
            this.txtToGVSearch.Location = new System.Drawing.Point(10, 206);
            this.txtToGVSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtToGVSearch.Name = "txtToGVSearch";
            this.txtToGVSearch.Size = new System.Drawing.Size(292, 41);
            this.txtToGVSearch.TabIndex = 36;
            this.txtToGVSearch.TextBoxText = "";
            this.txtToGVSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // btnKeypad
            // 
            this.btnKeypad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnKeypad.BackColor = System.Drawing.SystemColors.Info;
            this.btnKeypad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnKeypad.Location = new System.Drawing.Point(618, 275);
            this.btnKeypad.Name = "btnKeypad";
            this.btnKeypad.Size = new System.Drawing.Size(70, 29);
            this.btnKeypad.TabIndex = 53;
            this.btnKeypad.Text = "키패드";
            this.btnKeypad.UseVisualStyleBackColor = false;
            this.btnKeypad.Click += new System.EventHandler(this.btnKeypad_Click);
            // 
            // POP_PRD_007
            // 
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.btnKeypad);
            this.Controls.Add(this.btnFromSearch);
            this.Controls.Add(this.btnToSearch);
            this.Controls.Add(this.txtFromGVSearch);
            this.Controls.Add(this.txtToGVSearch);
            this.Controls.Add(this.txtLoading);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.dgvGVFrom);
            this.Controls.Add(this.dgvGVTo);
            this.Controls.Add(this.aPanel6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_007";
            this.Load += new System.EventHandler(this.POP_PRD_007_Load);
            this.Controls.SetChildIndex(this.aPanel6, 0);
            this.Controls.SetChildIndex(this.dgvGVTo, 0);
            this.Controls.SetChildIndex(this.dgvGVFrom, 0);
            this.Controls.SetChildIndex(this.btnLoading, 0);
            this.Controls.SetChildIndex(this.txtLoading, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.txtToGVSearch, 0);
            this.Controls.SetChildIndex(this.txtFromGVSearch, 0);
            this.Controls.SetChildIndex(this.btnToSearch, 0);
            this.Controls.SetChildIndex(this.btnFromSearch, 0);
            this.Controls.SetChildIndex(this.btnKeypad, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVTo)).EndInit();
            this.aPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.AButton btnLoading;
        private Axxen.CustomControls.ADataGridView dgvGVFrom;
        private Axxen.CustomControls.ADataGridView dgvGVTo;
        private Axxen.CustomControls.APanel aPanel6;
        private Axxen.CustomControls.ABigTextBox_Labeled txtUnit;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWcCode;
        private Axxen.CustomControls.ABigTextBox_Labeled txtQty;
        private Axxen.CustomControls.ABigTextBox_Labeled txtItemName;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderDate;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderno;
        private Axxen.CustomControls.ABigTextBox_Labeled txtLoading;
        private Axxen.CustomControls.AButton btnFromSearch;
        private Axxen.CustomControls.AButton btnToSearch;
        private Axxen.CustomControls.ABigTextBox_Labeled txtFromGVSearch;
        private Axxen.CustomControls.ABigTextBox_Labeled txtToGVSearch;
        private Axxen.CustomControls.AButton btnKeypad;
    }
}
