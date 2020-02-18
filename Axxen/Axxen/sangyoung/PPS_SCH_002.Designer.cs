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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPS_SCH_002));
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
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dotProcess = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.dotWorkCenter = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlanQuantity)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.dotWorkCenter);
            this.aPanel2.Controls.Add(this.aDateTimePickerSearch1);
            this.aPanel2.Controls.Add(this.dotProcess);
            this.aPanel2.Controls.Add(this.btnWorkCancle);
            this.aPanel2.Controls.Add(this.btnWoFinish);
            this.aPanel2.Controls.Add(this.aLabel1);
            // 
            // aSplitContainer1
            // 
            // 
            // aPanel1
            // 
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
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "입력정보";
            // 
            // btnWorkCancle
            // 
            this.btnWorkCancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkCancle.BackColor = System.Drawing.SystemColors.Info;
            this.btnWorkCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkCancle.Location = new System.Drawing.Point(990, 42);
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
            this.btnWoFinish.BackColor = System.Drawing.SystemColors.Info;
            this.btnWoFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWoFinish.Location = new System.Drawing.Point(990, 13);
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
            this.aLabel1.Location = new System.Drawing.Point(3, 33);
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
            this.txtWorkNum.Location = new System.Drawing.Point(312, 5);
            this.txtWorkNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWorkNum.Name = "txtWorkNum";
            this.txtWorkNum.Size = new System.Drawing.Size(253, 29);
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
            this.txtItemCode.Location = new System.Drawing.Point(332, 38);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(233, 29);
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
            this.txtItemName.Location = new System.Drawing.Point(332, 71);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(233, 29);
            this.txtItemName.TabIndex = 13;
            this.txtItemName.TextBoxText = "";
            this.txtItemName.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // aLabel3
            // 
            this.aLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aLabel3.AutoSize = true;
            this.aLabel3.Location = new System.Drawing.Point(683, 14);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(55, 15);
            this.aLabel3.TabIndex = 14;
            this.aLabel3.Text = "계획일자";
            // 
            // dtpPlanDate
            // 
            this.dtpPlanDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanDate.Location = new System.Drawing.Point(768, 10);
            this.dtpPlanDate.Name = "dtpPlanDate";
            this.dtpPlanDate.Size = new System.Drawing.Size(94, 23);
            this.dtpPlanDate.TabIndex = 15;
            // 
            // aLabel4
            // 
            this.aLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(683, 44);
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
            this.txtPlanUnit.Location = new System.Drawing.Point(768, 70);
            this.txtPlanUnit.Name = "txtPlanUnit";
            this.txtPlanUnit.Size = new System.Drawing.Size(94, 23);
            this.txtPlanUnit.TabIndex = 17;
            this.txtPlanUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPlanUnit.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aLabel5
            // 
            this.aLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aLabel5.AutoSize = true;
            this.aLabel5.Location = new System.Drawing.Point(683, 74);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(79, 15);
            this.aLabel5.TabIndex = 18;
            this.aLabel5.Text = "계획수량단위";
            // 
            // numPlanQuantity
            // 
            this.numPlanQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numPlanQuantity.Location = new System.Drawing.Point(768, 40);
            this.numPlanQuantity.Name = "numPlanQuantity";
            this.numPlanQuantity.Size = new System.Drawing.Size(94, 23);
            this.numPlanQuantity.TabIndex = 19;
            this.numPlanQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 2, 11, 0, 0, 0, 0);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 2, 18, 0, 0, 0, 0);
            this.aDateTimePickerSearch1.ButtonText = "";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(82, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(278, 32);
            this.aDateTimePickerSearch1.TabIndex = 21;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.ADateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 637);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1148, 63);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.AutoSize = false;
            this.tsbtnSave.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(50, 57);
            this.tsbtnSave.Text = "저장";
            this.tsbtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnSave.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnSave.ToolTipText = "저장";
            this.tsbtnSave.Click += new System.EventHandler(this.TsbtnSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 60);
            this.toolStripButton1.Text = "다운로드";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "엑셀 다운로드";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
            // 
            // dotProcess
            // 
            this.dotProcess.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotProcess.CodeType = Axxen.CustomControls.DataType.Processes;
            this.dotProcess.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotProcess.lblNameText = "공정";
            this.dotProcess.Location = new System.Drawing.Point(364, 28);
            this.dotProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dotProcess.Name = "dotProcess";
            this.dotProcess.Size = new System.Drawing.Size(310, 27);
            this.dotProcess.TabIndex = 11;
            this.dotProcess.txtCodeText = "";
            this.dotProcess.txtNameText = "";
            this.dotProcess.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.ATextBox_FindNameByCode1_DotDotDotFormClosing);
            // 
            // dotWorkCenter
            // 
            this.dotWorkCenter.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotWorkCenter.CodeType = Axxen.CustomControls.DataType.WorkCenters;
            this.dotWorkCenter.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotWorkCenter.lblNameText = "작업장";
            this.dotWorkCenter.Location = new System.Drawing.Point(680, 28);
            this.dotWorkCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dotWorkCenter.Name = "dotWorkCenter";
            this.dotWorkCenter.Size = new System.Drawing.Size(322, 27);
            this.dotWorkCenter.TabIndex = 7;
            this.dotWorkCenter.txtCodeText = "";
            this.dotWorkCenter.txtNameText = "";
            this.dotWorkCenter.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.ATextBox_FindNameByCode1_DotDotDotFormClosing);
            // 
            // PPS_SCH_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Name = "PPS_SCH_002";
            this.Text = "작업지시마감관리";
            this.Activated += new System.EventHandler(this.PPS_SCH_002_Activated);
            this.Deactivate += new System.EventHandler(this.PPS_SCH_002_Deactivate);
            this.Load += new System.EventHandler(this.PPS_SCH_002_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.aHeaderBox1, 0);
            this.Controls.SetChildIndex(this.aSplitContainer1, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlanQuantity)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private CustomControls.ATextBox_FindNameByCode dotProcess;
        private CustomControls.ATextBox_FindNameByCode dotWorkCenter;
    }
}
