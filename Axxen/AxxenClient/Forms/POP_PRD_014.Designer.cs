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
            this.btnInsertMeasure = new Axxen.CustomControls.AButton();
            this.dgvConditionMeasureList = new Axxen.CustomControls.ADataGridView();
            this.dgvConditionList = new Axxen.CustomControls.ADataGridView();
            this.btnDeleteMeasure = new Axxen.CustomControls.AButton();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.txtUnit = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWcCode = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtQty = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtItemName = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderDate = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderno = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.lblConditionCode = new Axxen.CustomControls.ALabel();
            this.lblItemCode = new Axxen.CustomControls.ALabel();
            this.lblWcCode = new Axxen.CustomControls.ALabel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.nudMeasure = new System.Windows.Forms.NumericUpDown();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditionMeasureList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditionList)).BeginInit();
            this.aPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeasure)).BeginInit();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(0, 593);
            this.panBottom.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "공정조건 등록";
            // 
            // btnInsertMeasure
            // 
            this.btnInsertMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnInsertMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertMeasure.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsertMeasure.Location = new System.Drawing.Point(626, 473);
            this.btnInsertMeasure.Name = "btnInsertMeasure";
            this.btnInsertMeasure.Size = new System.Drawing.Size(409, 112);
            this.btnInsertMeasure.TabIndex = 29;
            this.btnInsertMeasure.Text = "입력";
            this.btnInsertMeasure.UseVisualStyleBackColor = false;
            this.btnInsertMeasure.Click += new System.EventHandler(this.btnInsertMeasure_Click);
            // 
            // dgvConditionMeasureList
            // 
            this.dgvConditionMeasureList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConditionMeasureList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditionMeasureList.Location = new System.Drawing.Point(626, 211);
            this.dgvConditionMeasureList.Name = "dgvConditionMeasureList";
            this.dgvConditionMeasureList.RowHeadersWidth = 51;
            this.dgvConditionMeasureList.RowTemplate.Height = 23;
            this.dgvConditionMeasureList.Size = new System.Drawing.Size(574, 217);
            this.dgvConditionMeasureList.TabIndex = 26;
            // 
            // dgvConditionList
            // 
            this.dgvConditionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConditionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditionList.Location = new System.Drawing.Point(10, 211);
            this.dgvConditionList.Name = "dgvConditionList";
            this.dgvConditionList.RowHeadersWidth = 51;
            this.dgvConditionList.RowTemplate.Height = 23;
            this.dgvConditionList.Size = new System.Drawing.Size(610, 374);
            this.dgvConditionList.TabIndex = 24;
            this.dgvConditionList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConditionList_CellClick);
            // 
            // btnDeleteMeasure
            // 
            this.btnDeleteMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnDeleteMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMeasure.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeleteMeasure.Location = new System.Drawing.Point(1042, 473);
            this.btnDeleteMeasure.Name = "btnDeleteMeasure";
            this.btnDeleteMeasure.Size = new System.Drawing.Size(160, 112);
            this.btnDeleteMeasure.TabIndex = 31;
            this.btnDeleteMeasure.Text = "삭제";
            this.btnDeleteMeasure.UseVisualStyleBackColor = false;
            this.btnDeleteMeasure.Click += new System.EventHandler(this.btnDeleteMeasure_Click);
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
            // lblConditionCode
            // 
            this.lblConditionCode.AutoSize = true;
            this.lblConditionCode.Location = new System.Drawing.Point(12, 211);
            this.lblConditionCode.Name = "lblConditionCode";
            this.lblConditionCode.Size = new System.Drawing.Size(101, 12);
            this.lblConditionCode.TabIndex = 36;
            this.lblConditionCode.Text = "lblConditionCode";
            this.lblConditionCode.Visible = false;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(12, 239);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(72, 12);
            this.lblItemCode.TabIndex = 37;
            this.lblItemCode.Text = "lblItemCode";
            this.lblItemCode.Visible = false;
            // 
            // lblWcCode
            // 
            this.lblWcCode.AutoSize = true;
            this.lblWcCode.Location = new System.Drawing.Point(12, 271);
            this.lblWcCode.Name = "lblWcCode";
            this.lblWcCode.Size = new System.Drawing.Size(65, 12);
            this.lblWcCode.TabIndex = 38;
            this.lblWcCode.Text = "lblWcCode";
            this.lblWcCode.Visible = false;
            // 
            // aLabel1
            // 
            this.aLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.aLabel1.Location = new System.Drawing.Point(633, 440);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(58, 21);
            this.aLabel1.TabIndex = 48;
            this.aLabel1.Text = "측정값";
            // 
            // nudMeasure
            // 
            this.nudMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMeasure.DecimalPlaces = 4;
            this.nudMeasure.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.nudMeasure.Location = new System.Drawing.Point(711, 436);
            this.nudMeasure.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudMeasure.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.nudMeasure.Name = "nudMeasure";
            this.nudMeasure.Size = new System.Drawing.Size(342, 29);
            this.nudMeasure.TabIndex = 47;
            // 
            // aButton1
            // 
            this.aButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aButton1.BackColor = System.Drawing.SystemColors.Info;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(1059, 436);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(75, 29);
            this.aButton1.TabIndex = 49;
            this.aButton1.Text = "키패드";
            this.aButton1.UseVisualStyleBackColor = false;
            this.aButton1.Click += new System.EventHandler(this.AButton1_Click);
            // 
            // POP_PRD_014
            // 
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.nudMeasure);
            this.Controls.Add(this.lblWcCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.lblConditionCode);
            this.Controls.Add(this.btnDeleteMeasure);
            this.Controls.Add(this.btnInsertMeasure);
            this.Controls.Add(this.dgvConditionMeasureList);
            this.Controls.Add(this.dgvConditionList);
            this.Controls.Add(this.aPanel6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_014";
            this.Load += new System.EventHandler(this.POP_PRD_014_Load);
            this.Controls.SetChildIndex(this.aPanel6, 0);
            this.Controls.SetChildIndex(this.dgvConditionList, 0);
            this.Controls.SetChildIndex(this.dgvConditionMeasureList, 0);
            this.Controls.SetChildIndex(this.btnInsertMeasure, 0);
            this.Controls.SetChildIndex(this.btnDeleteMeasure, 0);
            this.Controls.SetChildIndex(this.lblConditionCode, 0);
            this.Controls.SetChildIndex(this.lblItemCode, 0);
            this.Controls.SetChildIndex(this.lblWcCode, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.nudMeasure, 0);
            this.Controls.SetChildIndex(this.aLabel1, 0);
            this.Controls.SetChildIndex(this.aButton1, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditionMeasureList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditionList)).EndInit();
            this.aPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMeasure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Axxen.CustomControls.AButton btnInsertMeasure;
        private Axxen.CustomControls.ADataGridView dgvConditionMeasureList;
        private Axxen.CustomControls.ADataGridView dgvConditionList;
        private Axxen.CustomControls.AButton btnDeleteMeasure;
        private Axxen.CustomControls.APanel aPanel6;
        private Axxen.CustomControls.ABigTextBox_Labeled txtUnit;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWcCode;
        private Axxen.CustomControls.ABigTextBox_Labeled txtQty;
        private Axxen.CustomControls.ABigTextBox_Labeled txtItemName;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderDate;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderno;
        private Axxen.CustomControls.ALabel lblConditionCode;
        private Axxen.CustomControls.ALabel lblItemCode;
        private Axxen.CustomControls.ALabel lblWcCode;
        private Axxen.CustomControls.ALabel aLabel1;
        private System.Windows.Forms.NumericUpDown nudMeasure;
        private Axxen.CustomControls.AButton aButton1;
    }
}
