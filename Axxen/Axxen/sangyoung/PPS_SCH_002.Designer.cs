namespace Axxen
{ 
    partial class PPS_SCH_002
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
            this.aTextBox_FindNameByCode2 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.btnWorkCancle = new Axxen.CustomControls.AButton();
            this.btnWoFinish = new Axxen.CustomControls.AButton();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.txtWorkNum = new Axxen.CustomControls.ATextBox_Labeled();
            this.txtItemCode = new Axxen.CustomControls.ATextBox_Labeled();
            this.txtItemName = new Axxen.CustomControls.ATextBox_Labeled();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.dtpPlanDate = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.txtPlanUnit = new Axxen.CustomControls.ATextBox();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.numPlanQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtWorkCenter = new Axxen.CustomControls.ATextBox_Labeled();
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlanQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.aDateTimePickerSearch1);
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode2);
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode1);
            this.aPanel2.Controls.Add(this.btnWorkCancle);
            this.aPanel2.Controls.Add(this.btnWoFinish);
            this.aPanel2.Controls.Add(this.aLabel1);
            // 
            // aSplitContainer1
            // 
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.txtWorkCenter);
            this.aPanel1.Controls.Add(this.numPlanQuantity);
            this.aPanel1.Controls.Add(this.aLabel5);
            this.aPanel1.Controls.Add(this.txtPlanUnit);
            this.aPanel1.Controls.Add(this.aLabel4);
            this.aPanel1.Controls.Add(this.dtpPlanDate);
            this.aPanel1.Controls.Add(this.aLabel3);
            this.aPanel1.Controls.Add(this.txtItemName);
            this.aPanel1.Controls.Add(this.txtItemCode);
            this.aPanel1.Controls.Add(this.txtWorkNum);
            this.aPanel1.Controls.SetChildIndex(this.aHeaderBox2, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtWorkNum, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtItemCode, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtItemName, 0);
            this.aPanel1.Controls.SetChildIndex(this.aLabel3, 0);
            this.aPanel1.Controls.SetChildIndex(this.dtpPlanDate, 0);
            this.aPanel1.Controls.SetChildIndex(this.aLabel4, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtPlanUnit, 0);
            this.aPanel1.Controls.SetChildIndex(this.aLabel5, 0);
            this.aPanel1.Controls.SetChildIndex(this.numPlanQuantity, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtWorkCenter, 0);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "입력정보";
            // 
            // aTextBox_FindNameByCode2
            // 
            this.aTextBox_FindNameByCode2.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.CodeType = Axxen.CustomControls.DataType.WorkCenters;
            this.aTextBox_FindNameByCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.lblNameText = "작업장";
            this.aTextBox_FindNameByCode2.Location = new System.Drawing.Point(702, 26);
            this.aTextBox_FindNameByCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode2.Name = "aTextBox_FindNameByCode2";
            this.aTextBox_FindNameByCode2.Size = new System.Drawing.Size(229, 27);
            this.aTextBox_FindNameByCode2.TabIndex = 20;
            this.aTextBox_FindNameByCode2.txtCodeText = "";
            this.aTextBox_FindNameByCode2.txtNameText = "";
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(454, 26);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(221, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 19;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            // 
            // btnWorkCancle
            // 
            this.btnWorkCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkCancle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWorkCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkCancle.Location = new System.Drawing.Point(963, 42);
            this.btnWorkCancle.Name = "btnWorkCancle";
            this.btnWorkCancle.Size = new System.Drawing.Size(130, 23);
            this.btnWorkCancle.TabIndex = 16;
            this.btnWorkCancle.Text = "작업지시 마감취소";
            this.btnWorkCancle.UseVisualStyleBackColor = false;
            this.btnWorkCancle.Click += new System.EventHandler(this.BtnWorkCancle_Click);
            // 
            // btnWoFinish
            // 
            this.btnWoFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWoFinish.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWoFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWoFinish.Location = new System.Drawing.Point(963, 13);
            this.btnWoFinish.Name = "btnWoFinish";
            this.btnWoFinish.Size = new System.Drawing.Size(130, 23);
            this.btnWoFinish.TabIndex = 17;
            this.btnWoFinish.Text = "작업지시 마감";
            this.btnWoFinish.UseVisualStyleBackColor = false;
            this.btnWoFinish.Click += new System.EventHandler(this.BtnWoFinish_Click);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 12;
            this.aLabel1.Text = "작업지시일자";
            // 
            // txtWorkNum
            // 
            this.txtWorkNum.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWorkNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkNum.LabelText = "작업지시번호";
            this.txtWorkNum.Location = new System.Drawing.Point(283, 14);
            this.txtWorkNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWorkNum.Name = "txtWorkNum";
            this.txtWorkNum.Size = new System.Drawing.Size(229, 29);
            this.txtWorkNum.TabIndex = 11;
            this.txtWorkNum.TextBoxText = "";
            this.txtWorkNum.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtItemCode
            // 
            this.txtItemCode.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtItemCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemCode.LabelText = "품목코드";
            this.txtItemCode.Location = new System.Drawing.Point(553, 14);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(209, 29);
            this.txtItemCode.TabIndex = 12;
            this.txtItemCode.TextBoxText = "";
            this.txtItemCode.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtItemName
            // 
            this.txtItemName.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtItemName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.LabelText = "품목명";
            this.txtItemName.Location = new System.Drawing.Point(553, 51);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(209, 29);
            this.txtItemName.TabIndex = 13;
            this.txtItemName.TextBoxText = "";
            this.txtItemName.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aLabel3
            // 
            this.aLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aLabel3.AutoSize = true;
            this.aLabel3.Location = new System.Drawing.Point(851, 10);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(55, 15);
            this.aLabel3.TabIndex = 14;
            this.aLabel3.Text = "계획일자";
            // 
            // dtpPlanDate
            // 
            this.dtpPlanDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanDate.Location = new System.Drawing.Point(936, 6);
            this.dtpPlanDate.Name = "dtpPlanDate";
            this.dtpPlanDate.Size = new System.Drawing.Size(94, 23);
            this.dtpPlanDate.TabIndex = 15;
            // 
            // aLabel4
            // 
            this.aLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(851, 40);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(55, 15);
            this.aLabel4.TabIndex = 16;
            this.aLabel4.Text = "계획수량";
            // 
            // txtPlanUnit
            // 
            this.txtPlanUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPlanUnit.BackColor = System.Drawing.Color.White;
            this.txtPlanUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanUnit.errorp = null;
            this.txtPlanUnit.Location = new System.Drawing.Point(936, 66);
            this.txtPlanUnit.Name = "txtPlanUnit";
            this.txtPlanUnit.Size = new System.Drawing.Size(94, 23);
            this.txtPlanUnit.TabIndex = 17;
            this.txtPlanUnit.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aLabel5
            // 
            this.aLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aLabel5.AutoSize = true;
            this.aLabel5.Location = new System.Drawing.Point(851, 70);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(79, 15);
            this.aLabel5.TabIndex = 18;
            this.aLabel5.Text = "계획수량단위";
            // 
            // numPlanQuantity
            // 
            this.numPlanQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numPlanQuantity.Location = new System.Drawing.Point(936, 36);
            this.numPlanQuantity.Name = "numPlanQuantity";
            this.numPlanQuantity.Size = new System.Drawing.Size(94, 23);
            this.numPlanQuantity.TabIndex = 19;
            // 
            // txtWorkCenter
            // 
            this.txtWorkCenter.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWorkCenter.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenter.LabelText = "작업장";
            this.txtWorkCenter.Location = new System.Drawing.Point(283, 54);
            this.txtWorkCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWorkCenter.Name = "txtWorkCenter";
            this.txtWorkCenter.Size = new System.Drawing.Size(229, 29);
            this.txtWorkCenter.TabIndex = 20;
            this.txtWorkCenter.TextBoxText = "";
            this.txtWorkCenter.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 1, 21, 14, 0, 26, 886);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 1, 28, 13, 56, 27, 894);
            this.aDateTimePickerSearch1.ButtonText = "조회";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(107, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch1.TabIndex = 21;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.ADateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // PPS_SCH_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "PPS_SCH_002";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPS_SCH_002_FormClosed);
            this.Load += new System.EventHandler(this.PPS_SCH_002_Load);
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlanQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode2;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.AButton btnWorkCancle;
        private CustomControls.AButton btnWoFinish;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_Labeled txtItemName;
        private CustomControls.ATextBox_Labeled txtItemCode;
        private CustomControls.ATextBox_Labeled txtWorkNum;
        private System.Windows.Forms.NumericUpDown numPlanQuantity;
        private CustomControls.ALabel aLabel5;
        private CustomControls.ATextBox txtPlanUnit;
        private CustomControls.ALabel aLabel4;
        private CustomControls.ADateTimePicker dtpPlanDate;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ATextBox_Labeled txtWorkCenter;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
    }
}
