namespace Axxen
{
    partial class PPS_SCH_001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPS_SCH_001));
            this.btnPrDown = new Axxen.CustomControls.AButton();
            this.btnPrFinish = new Axxen.CustomControls.AButton();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.txtPrNum = new Axxen.CustomControls.ATextBox_Labeled();
            this.txtProjectName = new Axxen.CustomControls.ATextBox_Labeled();
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.aDateTimePickerSearch1);
            this.aPanel1.Controls.Add(this.txtProjectName);
            this.aPanel1.Controls.Add(this.txtPrNum);
            this.aPanel1.Controls.Add(this.aLabel1);
            this.aPanel1.Controls.Add(this.btnPrFinish);
            this.aPanel1.Controls.Add(this.btnPrDown);
            this.aPanel1.Location = new System.Drawing.Point(15, 17);
            // 
            // aSplitContainer1
            // 
            this.aSplitContainer1.SplitterDistance = 283;
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "생산의뢰";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "작업지시";
            // 
            // btnPrDown
            // 
            this.btnPrDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrDown.Location = new System.Drawing.Point(981, 14);
            this.btnPrDown.Name = "btnPrDown";
            this.btnPrDown.Size = new System.Drawing.Size(125, 23);
            this.btnPrDown.TabIndex = 0;
            this.btnPrDown.Text = "생산의뢰 다운로드";
            this.btnPrDown.UseVisualStyleBackColor = false;
            this.btnPrDown.Click += new System.EventHandler(this.BtnPrDown_Click);
            // 
            // btnPrFinish
            // 
            this.btnPrFinish.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrFinish.Location = new System.Drawing.Point(981, 43);
            this.btnPrFinish.Name = "btnPrFinish";
            this.btnPrFinish.Size = new System.Drawing.Size(125, 23);
            this.btnPrFinish.TabIndex = 0;
            this.btnPrFinish.Text = "생산의뢰 마감";
            this.btnPrFinish.UseVisualStyleBackColor = false;
            this.btnPrFinish.Click += new System.EventHandler(this.BtnPrFinish_Click);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 1;
            this.aLabel1.Text = "생산의뢰일자";
            // 
            // txtPrNum
            // 
            this.txtPrNum.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrNum.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrNum.LabelText = "생산의뢰 번호";
            this.txtPrNum.Location = new System.Drawing.Point(452, 28);
            this.txtPrNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrNum.Name = "txtPrNum";
            this.txtPrNum.Size = new System.Drawing.Size(237, 23);
            this.txtPrNum.TabIndex = 5;
            this.txtPrNum.TextBoxText = "";
            this.txtPrNum.TextBoxType = Axxen.CustomControls.TextType.Normal;
            this.txtPrNum.TextKeyPress += new Axxen.CustomControls.ATextBox_Labeled.TextEnterKeyPress(this.Text_TextKeyPress);
            // 
            // txtProjectName
            // 
            this.txtProjectName.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProjectName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProjectName.LabelText = "프로젝트 명";
            this.txtProjectName.Location = new System.Drawing.Point(712, 28);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(228, 23);
            this.txtProjectName.TabIndex = 6;
            this.txtProjectName.TextBoxText = "";
            this.txtProjectName.TextBoxType = Axxen.CustomControls.TextType.Normal;
            this.txtProjectName.TextKeyPress += new Axxen.CustomControls.ATextBox_Labeled.TextEnterKeyPress(this.Text_TextKeyPress);
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 2, 3, 14, 1, 26, 46);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 2, 10, 14, 1, 26, 46);
            this.aDateTimePickerSearch1.ButtonText = "조회";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(112, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch1.TabIndex = 7;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.ADateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1148, 60);
            this.toolStrip1.TabIndex = 9;
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
            this.tsbtnSave.ToolTipText = "조회";
            this.tsbtnSave.Click += new System.EventHandler(this.TsbtnSave_Click);
            // 
            // PPS_SCH_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Name = "PPS_SCH_001";
            this.Activated += new System.EventHandler(this.PPS_SCH_001_Activated);
            this.Deactivate += new System.EventHandler(this.PPS_SCH_001_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPS_SCH_001_FormClosed);
            this.Load += new System.EventHandler(this.PPS_SCH_001_Load);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aSplitContainer1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.AButton btnPrDown;
        private CustomControls.AButton btnPrFinish;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_Labeled txtProjectName;
        private CustomControls.ATextBox_Labeled txtPrNum;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
    }
}
