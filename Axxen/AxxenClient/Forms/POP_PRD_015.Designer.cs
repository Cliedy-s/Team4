namespace AxxenClient.Forms
{
    partial class POP_PRD_015
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
            this.btnDeleteMeasure = new Axxen.CustomControls.AButton();
            this.btnInsertMeasure = new Axxen.CustomControls.AButton();
            this.dgvInspectMeasure = new Axxen.CustomControls.ADataGridView();
            this.dgvInspect = new Axxen.CustomControls.ADataGridView();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.txtUnit = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWcCode = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtQty = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtItemName = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderDate = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderno = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtMeasure = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.lblProcesscode = new Axxen.CustomControls.ALabel();
            this.lblItemCode = new Axxen.CustomControls.ALabel();
            this.lblInspectcode = new Axxen.CustomControls.ALabel();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspect)).BeginInit();
            this.aPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "품질 측정값 등록";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnDeleteMeasure.TabIndex = 37;
            this.btnDeleteMeasure.Text = "삭제";
            this.btnDeleteMeasure.UseVisualStyleBackColor = false;
            this.btnDeleteMeasure.Click += new System.EventHandler(this.btnDeleteMeasure_Click);
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
            this.btnInsertMeasure.TabIndex = 35;
            this.btnInsertMeasure.Text = "입력";
            this.btnInsertMeasure.UseVisualStyleBackColor = false;
            this.btnInsertMeasure.Click += new System.EventHandler(this.btnInsertMeasure_Click);
            // 
            // dgvInspectMeasure
            // 
            this.dgvInspectMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInspectMeasure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspectMeasure.Location = new System.Drawing.Point(626, 211);
            this.dgvInspectMeasure.Name = "dgvInspectMeasure";
            this.dgvInspectMeasure.RowHeadersWidth = 51;
            this.dgvInspectMeasure.RowTemplate.Height = 23;
            this.dgvInspectMeasure.Size = new System.Drawing.Size(574, 218);
            this.dgvInspectMeasure.TabIndex = 34;
            // 
            // dgvInspect
            // 
            this.dgvInspect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInspect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspect.Location = new System.Drawing.Point(10, 211);
            this.dgvInspect.Name = "dgvInspect";
            this.dgvInspect.RowHeadersWidth = 51;
            this.dgvInspect.RowTemplate.Height = 23;
            this.dgvInspect.Size = new System.Drawing.Size(610, 374);
            this.dgvInspect.TabIndex = 32;
            this.dgvInspect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInspect_CellClick);
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
            this.aPanel6.Location = new System.Drawing.Point(9, 105);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(1191, 100);
            this.aPanel6.TabIndex = 40;
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
            // txtMeasure
            // 
            this.txtMeasure.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeasure.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMeasure.LabelText = "측정값";
            this.txtMeasure.Location = new System.Drawing.Point(628, 430);
            this.txtMeasure.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMeasure.Name = "txtMeasure";
            this.txtMeasure.Size = new System.Drawing.Size(469, 42);
            this.txtMeasure.TabIndex = 41;
            this.txtMeasure.TextBoxText = "";
            this.txtMeasure.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // lblProcesscode
            // 
            this.lblProcesscode.AutoSize = true;
            this.lblProcesscode.Location = new System.Drawing.Point(12, 271);
            this.lblProcesscode.Name = "lblProcesscode";
            this.lblProcesscode.Size = new System.Drawing.Size(86, 15);
            this.lblProcesscode.TabIndex = 44;
            this.lblProcesscode.Text = "lblProcesscode";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(12, 239);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(72, 15);
            this.lblItemCode.TabIndex = 43;
            this.lblItemCode.Text = "lblItemCode";
            // 
            // lblInspectcode
            // 
            this.lblInspectcode.AutoSize = true;
            this.lblInspectcode.Location = new System.Drawing.Point(12, 211);
            this.lblInspectcode.Name = "lblInspectcode";
            this.lblInspectcode.Size = new System.Drawing.Size(84, 15);
            this.lblInspectcode.TabIndex = 42;
            this.lblInspectcode.Text = "lblInspectcode";
            // 
            // POP_PRD_015
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.lblProcesscode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.lblInspectcode);
            this.Controls.Add(this.txtMeasure);
            this.Controls.Add(this.btnDeleteMeasure);
            this.Controls.Add(this.btnInsertMeasure);
            this.Controls.Add(this.dgvInspectMeasure);
            this.Controls.Add(this.dgvInspect);
            this.Controls.Add(this.aPanel6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_015";
            this.Load += new System.EventHandler(this.POP_PRD_015_Load);
            this.Controls.SetChildIndex(this.aPanel6, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.dgvInspect, 0);
            this.Controls.SetChildIndex(this.dgvInspectMeasure, 0);
            this.Controls.SetChildIndex(this.btnInsertMeasure, 0);
            this.Controls.SetChildIndex(this.btnDeleteMeasure, 0);
            this.Controls.SetChildIndex(this.txtMeasure, 0);
            this.Controls.SetChildIndex(this.lblInspectcode, 0);
            this.Controls.SetChildIndex(this.lblItemCode, 0);
            this.Controls.SetChildIndex(this.lblProcesscode, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspectMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspect)).EndInit();
            this.aPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Axxen.CustomControls.AButton btnDeleteMeasure;
        private Axxen.CustomControls.AButton btnInsertMeasure;
        private Axxen.CustomControls.ADataGridView dgvInspectMeasure;
        private Axxen.CustomControls.ADataGridView dgvInspect;
        private Axxen.CustomControls.APanel aPanel6;
        private Axxen.CustomControls.ABigTextBox_Labeled txtUnit;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWcCode;
        private Axxen.CustomControls.ABigTextBox_Labeled txtQty;
        private Axxen.CustomControls.ABigTextBox_Labeled txtItemName;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderDate;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderno;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtMeasure;
        private Axxen.CustomControls.ALabel lblProcesscode;
        private Axxen.CustomControls.ALabel lblItemCode;
        private Axxen.CustomControls.ALabel lblInspectcode;
    }
}
