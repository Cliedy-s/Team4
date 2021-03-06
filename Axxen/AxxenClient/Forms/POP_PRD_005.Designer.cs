﻿namespace AxxenClient.Forms
{
    partial class POP_PRD_005
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
            this.dgvInPallet = new Axxen.CustomControls.ADataGridView();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.btnKeypad = new Axxen.CustomControls.AButton();
            this.lblPalSeq = new Axxen.CustomControls.ALabel();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.lblBarcodeNo = new Axxen.CustomControls.ALabel();
            this.txtBoxingGrade = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtBoxingGradeDatail = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtSize = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.btnIn = new Axxen.CustomControls.AButton();
            this.txtBFour = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtPalletNo = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.aLabel_SubHeader1 = new Axxen.CustomControls.ALabel_SubHeader();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInPallet)).BeginInit();
            this.aPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(0, 593);
            this.panBottom.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aLabel_Header1
            // 
            this.lblHeaderHeader.Text = "포장 입고등록";
            // 
            // dgvInPallet
            // 
            this.dgvInPallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInPallet.Location = new System.Drawing.Point(7, 158);
            this.dgvInPallet.Name = "dgvInPallet";
            this.dgvInPallet.RowHeadersWidth = 51;
            this.dgvInPallet.RowTemplate.Height = 23;
            this.dgvInPallet.Size = new System.Drawing.Size(636, 429);
            this.dgvInPallet.TabIndex = 4;
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.btnKeypad);
            this.aPanel4.Controls.Add(this.lblPalSeq);
            this.aPanel4.Controls.Add(this.btnSearch);
            this.aPanel4.Controls.Add(this.lblBarcodeNo);
            this.aPanel4.Controls.Add(this.txtBoxingGrade);
            this.aPanel4.Controls.Add(this.txtBoxingGradeDatail);
            this.aPanel4.Controls.Add(this.txtSize);
            this.aPanel4.Controls.Add(this.btnIn);
            this.aPanel4.Controls.Add(this.txtBFour);
            this.aPanel4.Controls.Add(this.txtPalletNo);
            this.aPanel4.Location = new System.Drawing.Point(649, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 5;
            this.aPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.aPanel4_Paint);
            // 
            // btnKeypad
            // 
            this.btnKeypad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKeypad.BackColor = System.Drawing.SystemColors.Info;
            this.btnKeypad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnKeypad.Location = new System.Drawing.Point(437, 226);
            this.btnKeypad.Name = "btnKeypad";
            this.btnKeypad.Size = new System.Drawing.Size(70, 29);
            this.btnKeypad.TabIndex = 53;
            this.btnKeypad.Text = "키패드";
            this.btnKeypad.UseVisualStyleBackColor = false;
            this.btnKeypad.Click += new System.EventHandler(this.btnKeypad_Click);
            // 
            // lblPalSeq
            // 
            this.lblPalSeq.AutoSize = true;
            this.lblPalSeq.Location = new System.Drawing.Point(126, 21);
            this.lblPalSeq.Name = "lblPalSeq";
            this.lblPalSeq.Size = new System.Drawing.Size(58, 12);
            this.lblPalSeq.TabIndex = 39;
            this.lblPalSeq.Text = "lblPalSeq";
            this.lblPalSeq.Visible = false;
            this.lblPalSeq.TextChanged += new System.EventHandler(this.lblPalSeq_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(439, 36);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 29);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "찾기";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBarcodeNo
            // 
            this.lblBarcodeNo.AutoSize = true;
            this.lblBarcodeNo.Location = new System.Drawing.Point(39, 21);
            this.lblBarcodeNo.Name = "lblBarcodeNo";
            this.lblBarcodeNo.Size = new System.Drawing.Size(81, 12);
            this.lblBarcodeNo.TabIndex = 35;
            this.lblBarcodeNo.Text = "lblBarcodeNo";
            this.lblBarcodeNo.Visible = false;
            // 
            // txtBoxingGrade
            // 
            this.txtBoxingGrade.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxingGrade.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGrade.LabelText = "등급";
            this.txtBoxingGrade.Location = new System.Drawing.Point(42, 174);
            this.txtBoxingGrade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBoxingGrade.Name = "txtBoxingGrade";
            this.txtBoxingGrade.Size = new System.Drawing.Size(469, 42);
            this.txtBoxingGrade.TabIndex = 33;
            this.txtBoxingGrade.TextBoxText = "";
            this.txtBoxingGrade.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtBoxingGradeDatail
            // 
            this.txtBoxingGradeDatail.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGradeDatail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxingGradeDatail.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBoxingGradeDatail.LabelText = "등급상세";
            this.txtBoxingGradeDatail.Location = new System.Drawing.Point(42, 126);
            this.txtBoxingGradeDatail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBoxingGradeDatail.Name = "txtBoxingGradeDatail";
            this.txtBoxingGradeDatail.Size = new System.Drawing.Size(469, 42);
            this.txtBoxingGradeDatail.TabIndex = 32;
            this.txtBoxingGradeDatail.TextBoxText = "";
            this.txtBoxingGradeDatail.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtSize
            // 
            this.txtSize.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSize.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSize.LabelText = "사이즈";
            this.txtSize.Location = new System.Drawing.Point(42, 220);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(469, 42);
            this.txtSize.TabIndex = 30;
            this.txtSize.TextBoxText = "";
            this.txtSize.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIn.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnIn.Location = new System.Drawing.Point(92, 376);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(365, 74);
            this.btnIn.TabIndex = 16;
            this.btnIn.Text = "입고";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtBFour
            // 
            this.txtBFour.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBFour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBFour.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBFour.LabelText = "B뒤 4자리";
            this.txtBFour.Location = new System.Drawing.Point(42, 78);
            this.txtBFour.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtBFour.Name = "txtBFour";
            this.txtBFour.Size = new System.Drawing.Size(469, 42);
            this.txtBFour.TabIndex = 36;
            this.txtBFour.TextBoxText = "";
            this.txtBFour.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtPalletNo
            // 
            this.txtPalletNo.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPalletNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPalletNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPalletNo.LabelText = "팔레트 번호";
            this.txtPalletNo.Location = new System.Drawing.Point(42, 30);
            this.txtPalletNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPalletNo.Name = "txtPalletNo";
            this.txtPalletNo.Size = new System.Drawing.Size(469, 42);
            this.txtPalletNo.TabIndex = 38;
            this.txtPalletNo.TextBoxText = "";
            this.txtPalletNo.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // aLabel_SubHeader1
            // 
            this.aLabel_SubHeader1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aLabel_SubHeader1.AutoSize = true;
            this.aLabel_SubHeader1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel_SubHeader1.Location = new System.Drawing.Point(200, 116);
            this.aLabel_SubHeader1.Name = "aLabel_SubHeader1";
            this.aLabel_SubHeader1.Size = new System.Drawing.Size(240, 28);
            this.aLabel_SubHeader1.TabIndex = 6;
            this.aLabel_SubHeader1.Text = "금일 입고 팔레트 목록";
            // 
            // POP_PRD_005
            // 
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aLabel_SubHeader1);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.dgvInPallet);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_005";
            this.Activated += new System.EventHandler(this.POP_PRD_005_Activated);
            this.Deactivate += new System.EventHandler(this.POP_PRD_005_Deactivate);
            this.Load += new System.EventHandler(this.POP_PRD_005_Load);
            this.Controls.SetChildIndex(this.dgvInPallet, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aLabel_SubHeader1, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInPallet)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Axxen.CustomControls.ADataGridView dgvInPallet;
        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton btnIn;
        private Axxen.CustomControls.ALabel_SubHeader aLabel_SubHeader1;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtBoxingGrade;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtBoxingGradeDatail;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtSize;
        private Axxen.CustomControls.ALabel lblBarcodeNo;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtBFour;
        private Axxen.CustomControls.AButton btnSearch;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPalletNo;
        private Axxen.CustomControls.ALabel lblPalSeq;
        private Axxen.CustomControls.AButton btnKeypad;
    }
}
