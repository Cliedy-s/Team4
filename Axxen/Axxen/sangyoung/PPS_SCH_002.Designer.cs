namespace Axxen
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
            this.btnNameChange = new Axxen.CustomControls.AButton();
            this.dtpWorkFinish = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.dtpWorkStart = new Axxen.CustomControls.ADateTimePicker();
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
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode2);
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode1);
            this.aPanel2.Controls.Add(this.btnWorkCancle);
            this.aPanel2.Controls.Add(this.btnWoFinish);
            this.aPanel2.Controls.Add(this.btnNameChange);
            this.aPanel2.Controls.Add(this.dtpWorkFinish);
            this.aPanel2.Controls.Add(this.aLabel2);
            this.aPanel2.Controls.Add(this.dtpWorkStart);
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
            this.aTextBox_FindNameByCode2.CodeType = Axxen.CustomControls.ATextBox_FindNameByCode.types.WorkCenters;
            this.aTextBox_FindNameByCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.lblNameText = "작업장";
            this.aTextBox_FindNameByCode2.Location = new System.Drawing.Point(625, 26);
            this.aTextBox_FindNameByCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode2.Name = "aTextBox_FindNameByCode2";
            this.aTextBox_FindNameByCode2.Size = new System.Drawing.Size(229, 27);
            this.aTextBox_FindNameByCode2.TabIndex = 20;
            this.aTextBox_FindNameByCode2.txtCodeText = "";
            this.aTextBox_FindNameByCode2.txtNameText = "";
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.ATextBox_FindNameByCode.types.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(387, 26);
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
            this.btnWorkCancle.Location = new System.Drawing.Point(970, 40);
            this.btnWorkCancle.Name = "btnWorkCancle";
            this.btnWorkCancle.Size = new System.Drawing.Size(130, 23);
            this.btnWorkCancle.TabIndex = 16;
            this.btnWorkCancle.Text = "작업지시 마감취소";
            this.btnWorkCancle.UseVisualStyleBackColor = false;
            // 
            // btnWoFinish
            // 
            this.btnWoFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWoFinish.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWoFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWoFinish.Location = new System.Drawing.Point(970, 11);
            this.btnWoFinish.Name = "btnWoFinish";
            this.btnWoFinish.Size = new System.Drawing.Size(130, 23);
            this.btnWoFinish.TabIndex = 17;
            this.btnWoFinish.Text = "작업지시 마감";
            this.btnWoFinish.UseVisualStyleBackColor = false;
            // 
            // btnNameChange
            // 
            this.btnNameChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameChange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNameChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameChange.Location = new System.Drawing.Point(878, 28);
            this.btnNameChange.Name = "btnNameChange";
            this.btnNameChange.Size = new System.Drawing.Size(75, 23);
            this.btnNameChange.TabIndex = 18;
            this.btnNameChange.Text = "품명변경";
            this.btnNameChange.UseVisualStyleBackColor = false;
            // 
            // dtpWorkFinish
            // 
            this.dtpWorkFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkFinish.Location = new System.Drawing.Point(254, 28);
            this.dtpWorkFinish.Name = "dtpWorkFinish";
            this.dtpWorkFinish.Size = new System.Drawing.Size(105, 23);
            this.dtpWorkFinish.TabIndex = 15;
            this.dtpWorkFinish.Value = new System.DateTime(2020, 1, 3, 15, 14, 0, 0);
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(233, 32);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(15, 15);
            this.aLabel2.TabIndex = 14;
            this.aLabel2.Text = "~";
            // 
            // dtpWorkStart
            // 
            this.dtpWorkStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkStart.Location = new System.Drawing.Point(121, 28);
            this.dtpWorkStart.Name = "dtpWorkStart";
            this.dtpWorkStart.Size = new System.Drawing.Size(105, 23);
            this.dtpWorkStart.TabIndex = 13;
            this.dtpWorkStart.Value = new System.DateTime(2020, 1, 3, 15, 14, 0, 0);
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
            this.txtWorkNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkNum.FontSize = 9F;
            this.txtWorkNum.LabelText = "작업지시번호";
            this.txtWorkNum.Location = new System.Drawing.Point(283, 20);
            this.txtWorkNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWorkNum.Name = "txtWorkNum";
            this.txtWorkNum.Size = new System.Drawing.Size(229, 29);
            this.txtWorkNum.TabIndex = 11;
            this.txtWorkNum.TextBoxText = "";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemCode.FontSize = 9F;
            this.txtItemCode.LabelText = "품목코드";
            this.txtItemCode.Location = new System.Drawing.Point(553, 20);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(209, 29);
            this.txtItemCode.TabIndex = 12;
            this.txtItemCode.TextBoxText = "";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.FontSize = 9F;
            this.txtItemName.LabelText = "품목명";
            this.txtItemName.Location = new System.Drawing.Point(553, 57);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(209, 29);
            this.txtItemName.TabIndex = 13;
            this.txtItemName.TextBoxText = "";
            // 
            // aLabel3
            // 
            this.aLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel3.AutoSize = true;
            this.aLabel3.Location = new System.Drawing.Point(851, 16);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(55, 15);
            this.aLabel3.TabIndex = 14;
            this.aLabel3.Text = "계획일자";
            // 
            // dtpPlanDate
            // 
            this.dtpPlanDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanDate.Location = new System.Drawing.Point(936, 12);
            this.dtpPlanDate.Name = "dtpPlanDate";
            this.dtpPlanDate.Size = new System.Drawing.Size(94, 23);
            this.dtpPlanDate.TabIndex = 15;
            // 
            // aLabel4
            // 
            this.aLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(851, 46);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(55, 15);
            this.aLabel4.TabIndex = 16;
            this.aLabel4.Text = "계획수량";
            // 
            // txtPlanUnit
            // 
            this.txtPlanUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlanUnit.BackColor = System.Drawing.Color.White;
            this.txtPlanUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanUnit.errorp = null;
            this.txtPlanUnit.Location = new System.Drawing.Point(936, 72);
            this.txtPlanUnit.Name = "txtPlanUnit";
            this.txtPlanUnit.Size = new System.Drawing.Size(94, 23);
            this.txtPlanUnit.TabIndex = 17;
            this.txtPlanUnit.txtType = Axxen.CustomControls.type.Normal;
            // 
            // aLabel5
            // 
            this.aLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel5.AutoSize = true;
            this.aLabel5.Location = new System.Drawing.Point(851, 76);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(79, 15);
            this.aLabel5.TabIndex = 18;
            this.aLabel5.Text = "계획수량단위";
            // 
            // numPlanQuantity
            // 
            this.numPlanQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPlanQuantity.Location = new System.Drawing.Point(936, 42);
            this.numPlanQuantity.Name = "numPlanQuantity";
            this.numPlanQuantity.Size = new System.Drawing.Size(94, 23);
            this.numPlanQuantity.TabIndex = 19;
            // 
            // txtWorkCenter
            // 
            this.txtWorkCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkCenter.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenter.FontSize = 9F;
            this.txtWorkCenter.LabelText = "작업장";
            this.txtWorkCenter.Location = new System.Drawing.Point(283, 60);
            this.txtWorkCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWorkCenter.Name = "txtWorkCenter";
            this.txtWorkCenter.Size = new System.Drawing.Size(229, 29);
            this.txtWorkCenter.TabIndex = 20;
            this.txtWorkCenter.TextBoxText = "";
            // 
            // PPS_SCH_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "PPS_SCH_002";
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
        private CustomControls.AButton btnNameChange;
        private CustomControls.ADateTimePicker dtpWorkFinish;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ADateTimePicker dtpWorkStart;
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
    }
}
