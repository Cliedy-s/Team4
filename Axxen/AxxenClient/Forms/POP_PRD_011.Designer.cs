namespace AxxenClient.Forms
{
    partial class POP_PRD_011
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
            this.btnInput = new Axxen.CustomControls.AButton();
            this.dgvGVList = new Axxen.CustomControls.ADataGridView();
            this.btnOutput = new Axxen.CustomControls.AButton();
            this.txtGVSearch = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVList)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "요입/ 요출 관리";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btnInput
            // 
            this.btnInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInput.Location = new System.Drawing.Point(960, 203);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(238, 165);
            this.btnInput.TabIndex = 31;
            this.btnInput.Text = "요입";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // dgvGVList
            // 
            this.dgvGVList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGVList.Location = new System.Drawing.Point(12, 157);
            this.dgvGVList.Name = "dgvGVList";
            this.dgvGVList.RowHeadersWidth = 51;
            this.dgvGVList.RowTemplate.Height = 23;
            this.dgvGVList.Size = new System.Drawing.Size(942, 430);
            this.dgvGVList.TabIndex = 27;
            // 
            // btnOutput
            // 
            this.btnOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutput.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOutput.Location = new System.Drawing.Point(960, 374);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(238, 165);
            this.btnOutput.TabIndex = 33;
            this.btnOutput.Text = "요출";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtGVSearch
            // 
            this.txtGVSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGVSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGVSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGVSearch.LabelText = "대차검색";
            this.txtGVSearch.Location = new System.Drawing.Point(12, 108);
            this.txtGVSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGVSearch.Name = "txtGVSearch";
            this.txtGVSearch.Size = new System.Drawing.Size(469, 42);
            this.txtGVSearch.TabIndex = 37;
            this.txtGVSearch.TextBoxText = "";
            this.txtGVSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(481, 114);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 29);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // POP_PRD_011
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.txtGVSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.dgvGVList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_011";
            this.Load += new System.EventHandler(this.POP_PRD_011_Load);
            this.Controls.SetChildIndex(this.dgvGVList, 0);
            this.Controls.SetChildIndex(this.btnInput, 0);
            this.Controls.SetChildIndex(this.btnOutput, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.txtGVSearch, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.AButton btnInput;
        private Axxen.CustomControls.ADataGridView dgvGVList;
        private Axxen.CustomControls.AButton btnOutput;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtGVSearch;
        private Axxen.CustomControls.AButton btnSearch;
    }
}
