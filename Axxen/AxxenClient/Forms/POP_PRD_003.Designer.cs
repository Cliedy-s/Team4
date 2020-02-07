namespace AxxenClient.Forms
{
    partial class POP_PRD_003
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
            this.dgvPalletList = new Axxen.CustomControls.ADataGridView();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.txtPrintPallet = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtSizeCode = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtBoxingGrade = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtPalletNo = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.btnPalletPrint = new Axxen.CustomControls.AButton();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.txtUnit = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWcCode = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtQty = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtItemName = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderDate = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtWorkOrderno = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.txtBoxingGradeDetail = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).BeginInit();
            this.aPanel4.SuspendLayout();
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
            this.aLabel_Header1.Text = "팔레트 생성";
            // 
            // dgvPalletList
            // 
            this.dgvPalletList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletList.Location = new System.Drawing.Point(10, 212);
            this.dgvPalletList.Name = "dgvPalletList";
            this.dgvPalletList.RowHeadersWidth = 51;
            this.dgvPalletList.RowTemplate.Height = 23;
            this.dgvPalletList.Size = new System.Drawing.Size(636, 373);
            this.dgvPalletList.TabIndex = 5;
            this.dgvPalletList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletList_CellDoubleClick);
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.txtPrintPallet);
            this.aPanel4.Controls.Add(this.txtSizeCode);
            this.aPanel4.Controls.Add(this.txtBoxingGrade);
            this.aPanel4.Controls.Add(this.txtPalletNo);
            this.aPanel4.Controls.Add(this.btnPalletPrint);
            this.aPanel4.Controls.Add(this.txtBoxingGradeDetail);
            this.aPanel4.Location = new System.Drawing.Point(652, 212);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 373);
            this.aPanel4.TabIndex = 6;
            // 
            // txtPrintPallet
            // 
            this.txtPrintPallet.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrintPallet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrintPallet.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrintPallet.LabelText = "팔레트 수량";
            this.txtPrintPallet.Location = new System.Drawing.Point(39, 205);
            this.txtPrintPallet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPrintPallet.Name = "txtPrintPallet";
            this.txtPrintPallet.Size = new System.Drawing.Size(469, 42);
            this.txtPrintPallet.TabIndex = 35;
            this.txtPrintPallet.TextBoxText = "";
            this.txtPrintPallet.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // txtSizeCode
            // 
            this.txtSizeCode.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSizeCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSizeCode.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSizeCode.LabelText = "사이즈";
            this.txtSizeCode.Location = new System.Drawing.Point(39, 158);
            this.txtSizeCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSizeCode.Name = "txtSizeCode";
            this.txtSizeCode.Size = new System.Drawing.Size(469, 42);
            this.txtSizeCode.TabIndex = 34;
            this.txtSizeCode.TextBoxText = "";
            this.txtSizeCode.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtBoxingGrade
            // 
            this.txtBoxingGrade.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxingGrade.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGrade.LabelText = "등급";
            this.txtBoxingGrade.Location = new System.Drawing.Point(39, 64);
            this.txtBoxingGrade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBoxingGrade.Name = "txtBoxingGrade";
            this.txtBoxingGrade.Size = new System.Drawing.Size(469, 42);
            this.txtBoxingGrade.TabIndex = 32;
            this.txtBoxingGrade.TextBoxText = "";
            this.txtBoxingGrade.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtPalletNo
            // 
            this.txtPalletNo.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPalletNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPalletNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPalletNo.LabelText = "팔레트번호";
            this.txtPalletNo.Location = new System.Drawing.Point(39, 17);
            this.txtPalletNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPalletNo.Name = "txtPalletNo";
            this.txtPalletNo.Size = new System.Drawing.Size(469, 42);
            this.txtPalletNo.TabIndex = 31;
            this.txtPalletNo.TextBoxText = "";
            this.txtPalletNo.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // btnPalletPrint
            // 
            this.btnPalletPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPalletPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnPalletPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalletPrint.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPalletPrint.Location = new System.Drawing.Point(98, 255);
            this.btnPalletPrint.Name = "btnPalletPrint";
            this.btnPalletPrint.Size = new System.Drawing.Size(365, 105);
            this.btnPalletPrint.TabIndex = 22;
            this.btnPalletPrint.Text = "인쇄";
            this.btnPalletPrint.UseVisualStyleBackColor = false;
            this.btnPalletPrint.Click += new System.EventHandler(this.btnPalletPrint_Click);
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
            this.aPanel6.Location = new System.Drawing.Point(10, 106);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(1191, 100);
            this.aPanel6.TabIndex = 8;
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
            // txtBoxingGradeDetail
            // 
            this.txtBoxingGradeDetail.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGradeDetail.CodeText = null;
            this.txtBoxingGradeDetail.DataType = Axxen.CustomControls.DataType.BoxingDetail;
            this.txtBoxingGradeDetail.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGradeDetail.LabelText = "등급상세";
            this.txtBoxingGradeDetail.Location = new System.Drawing.Point(39, 111);
            this.txtBoxingGradeDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBoxingGradeDetail.Name = "txtBoxingGradeDetail";
            this.txtBoxingGradeDetail.Size = new System.Drawing.Size(469, 42);
            this.txtBoxingGradeDetail.TabIndex = 36;
            this.txtBoxingGradeDetail.TextBoxText = "";
            this.txtBoxingGradeDetail.TextBoxType = Axxen.CustomControls.TextType.Normal;
            this.txtBoxingGradeDetail.searchclick += new Axxen.CustomControls.ABigTextBox_Searchable.SearchClick(this.txtBoxingGradeDetail_searchclick);
            // 
            // POP_PRD_003
            // 
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aPanel6);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.dgvPalletList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_003";
            this.Text = "팔레트 생성";
            this.Load += new System.EventHandler(this.POP_PRD_003_Load);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.dgvPalletList, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aPanel6, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.aPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.ADataGridView dgvPalletList;
        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton btnPalletPrint;
        private Axxen.CustomControls.APanel aPanel6;
        private Axxen.CustomControls.ABigTextBox_Labeled txtUnit;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWcCode;
        private Axxen.CustomControls.ABigTextBox_Labeled txtQty;
        private Axxen.CustomControls.ABigTextBox_Labeled txtItemName;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderDate;
        private Axxen.CustomControls.ABigTextBox_Labeled txtWorkOrderno;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPrintPallet;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtSizeCode;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtBoxingGrade;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPalletNo;
        private Axxen.CustomControls.ABigTextBox_Searchable txtBoxingGradeDetail;
    }
}
