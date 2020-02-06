namespace AxxenClient.Forms
{
    partial class POP_PRD_004
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
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.txtCurrentQty = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtSizeCode = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtBoxingDetailGrade = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtBoxingGrade = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtPalletNo = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.btnDelete = new Axxen.CustomControls.AButton();
            this.btnPalletPrint = new Axxen.CustomControls.AButton();
            this.dgvPalletList = new Axxen.CustomControls.ADataGridView();
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.btnSearchByDate = new Axxen.CustomControls.AButton();
            this.dtpTodate = new System.Windows.Forms.DateTimePicker();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.dtpFromdate = new System.Windows.Forms.DateTimePicker();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).BeginInit();
            this.aPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "팔레트 바코드 재발행";
            // 
            // aPanel1
            // 
            this.panBottom.Location = new System.Drawing.Point(0, 593);
            this.panBottom.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.txtCurrentQty);
            this.aPanel4.Controls.Add(this.txtSizeCode);
            this.aPanel4.Controls.Add(this.txtBoxingDetailGrade);
            this.aPanel4.Controls.Add(this.txtBoxingGrade);
            this.aPanel4.Controls.Add(this.txtPalletNo);
            this.aPanel4.Controls.Add(this.btnDelete);
            this.aPanel4.Controls.Add(this.btnPalletPrint);
            this.aPanel4.Location = new System.Drawing.Point(649, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 7;
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCurrentQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCurrentQty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCurrentQty.LabelText = "팔레트 수량";
            this.txtCurrentQty.Location = new System.Drawing.Point(40, 220);
            this.txtCurrentQty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.Size = new System.Drawing.Size(469, 42);
            this.txtCurrentQty.TabIndex = 40;
            this.txtCurrentQty.TextBoxText = "";
            this.txtCurrentQty.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // txtSizeCode
            // 
            this.txtSizeCode.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSizeCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSizeCode.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSizeCode.LabelText = "사이즈";
            this.txtSizeCode.Location = new System.Drawing.Point(40, 173);
            this.txtSizeCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSizeCode.Name = "txtSizeCode";
            this.txtSizeCode.Size = new System.Drawing.Size(469, 42);
            this.txtSizeCode.TabIndex = 39;
            this.txtSizeCode.TextBoxText = "";
            this.txtSizeCode.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtBoxingDetailGrade
            // 
            this.txtBoxingDetailGrade.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingDetailGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxingDetailGrade.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingDetailGrade.LabelText = "등급상세";
            this.txtBoxingDetailGrade.Location = new System.Drawing.Point(40, 126);
            this.txtBoxingDetailGrade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBoxingDetailGrade.Name = "txtBoxingDetailGrade";
            this.txtBoxingDetailGrade.Size = new System.Drawing.Size(469, 42);
            this.txtBoxingDetailGrade.TabIndex = 38;
            this.txtBoxingDetailGrade.TextBoxText = "";
            this.txtBoxingDetailGrade.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtBoxingGrade
            // 
            this.txtBoxingGrade.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxingGrade.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGrade.LabelText = "등급";
            this.txtBoxingGrade.Location = new System.Drawing.Point(40, 79);
            this.txtBoxingGrade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBoxingGrade.Name = "txtBoxingGrade";
            this.txtBoxingGrade.Size = new System.Drawing.Size(469, 42);
            this.txtBoxingGrade.TabIndex = 37;
            this.txtBoxingGrade.TextBoxText = "";
            this.txtBoxingGrade.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtPalletNo
            // 
            this.txtPalletNo.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPalletNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPalletNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPalletNo.LabelText = "팔레트번호";
            this.txtPalletNo.Location = new System.Drawing.Point(40, 32);
            this.txtPalletNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPalletNo.Name = "txtPalletNo";
            this.txtPalletNo.Size = new System.Drawing.Size(469, 42);
            this.txtPalletNo.TabIndex = 36;
            this.txtPalletNo.TextBoxText = "";
            this.txtPalletNo.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(93, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(365, 81);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPalletPrint
            // 
            this.btnPalletPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPalletPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnPalletPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalletPrint.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPalletPrint.Location = new System.Drawing.Point(93, 288);
            this.btnPalletPrint.Name = "btnPalletPrint";
            this.btnPalletPrint.Size = new System.Drawing.Size(365, 81);
            this.btnPalletPrint.TabIndex = 16;
            this.btnPalletPrint.Text = "재발행";
            this.btnPalletPrint.UseVisualStyleBackColor = false;
            this.btnPalletPrint.Click += new System.EventHandler(this.btnBarcodeRecreate);
            // 
            // dgvPalletList
            // 
            this.dgvPalletList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletList.Location = new System.Drawing.Point(7, 165);
            this.dgvPalletList.Name = "dgvPalletList";
            this.dgvPalletList.RowHeadersWidth = 51;
            this.dgvPalletList.RowTemplate.Height = 23;
            this.dgvPalletList.Size = new System.Drawing.Size(636, 422);
            this.dgvPalletList.TabIndex = 6;
            this.dgvPalletList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletList_CellDoubleClick);
            // 
            // aPanel5
            // 
            this.aPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel5.Controls.Add(this.btnSearchByDate);
            this.aPanel5.Controls.Add(this.dtpTodate);
            this.aPanel5.Controls.Add(this.aLabel3);
            this.aPanel5.Controls.Add(this.dtpFromdate);
            this.aPanel5.Controls.Add(this.aLabel2);
            this.aPanel5.Location = new System.Drawing.Point(7, 105);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(636, 54);
            this.aPanel5.TabIndex = 8;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchByDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearchByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchByDate.Location = new System.Drawing.Point(465, 14);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(75, 29);
            this.btnSearchByDate.TabIndex = 16;
            this.btnSearchByDate.Text = "조회";
            this.btnSearchByDate.UseVisualStyleBackColor = false;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // dtpTodate
            // 
            this.dtpTodate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTodate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTodate.Location = new System.Drawing.Point(348, 14);
            this.dtpTodate.Name = "dtpTodate";
            this.dtpTodate.Size = new System.Drawing.Size(111, 29);
            this.dtpTodate.TabIndex = 15;
            // 
            // aLabel3
            // 
            this.aLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.Location = new System.Drawing.Point(308, 18);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(21, 21);
            this.aLabel3.TabIndex = 14;
            this.aLabel3.Text = "~";
            // 
            // dtpFromdate
            // 
            this.dtpFromdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFromdate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromdate.Location = new System.Drawing.Point(172, 14);
            this.dtpFromdate.Name = "dtpFromdate";
            this.dtpFromdate.Size = new System.Drawing.Size(121, 29);
            this.dtpFromdate.TabIndex = 13;
            // 
            // aLabel2
            // 
            this.aLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(92, 18);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(74, 21);
            this.aLabel2.TabIndex = 12;
            this.aLabel2.Text = "생산일자";
            // 
            // POP_PRD_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aPanel5);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.dgvPalletList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_004";
            this.Text = "팔레트 바코드 재발행";
            this.Load += new System.EventHandler(this.POP_PRD_004_Load);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.dgvPalletList, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aPanel5, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.aPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).EndInit();
            this.aPanel5.ResumeLayout(false);
            this.aPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton btnPalletPrint;
        private Axxen.CustomControls.ADataGridView dgvPalletList;
        private Axxen.CustomControls.AButton btnDelete;
        private Axxen.CustomControls.APanel aPanel5;
        private System.Windows.Forms.DateTimePicker dtpTodate;
        private Axxen.CustomControls.ALabel aLabel3;
        private System.Windows.Forms.DateTimePicker dtpFromdate;
        private Axxen.CustomControls.ALabel aLabel2;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtCurrentQty;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtSizeCode;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtBoxingDetailGrade;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtBoxingGrade;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPalletNo;
        private Axxen.CustomControls.AButton btnSearchByDate;
    }
}
