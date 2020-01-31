namespace AxxenClient.Forms
{
    partial class POP_PRD_009
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
            this.aPanel5 = new Axxen.CustomControls.APanel();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.txtGVSearch = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.dgvGVList = new Axxen.CustomControls.ADataGridView();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.txtPlanQty = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtPlanDate = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtWorkCenter = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.txtProcess = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.txtItem = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.btnCreateWorkOrder = new Axxen.CustomControls.AButton();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.aPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVList)).BeginInit();
            this.aPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "적재 작업지시 생성";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aPanel5
            // 
            this.aPanel5.Controls.Add(this.btnSearch);
            this.aPanel5.Controls.Add(this.txtGVSearch);
            this.aPanel5.Location = new System.Drawing.Point(12, 105);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(636, 47);
            this.aPanel5.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(517, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtGVSearch
            // 
            this.txtGVSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGVSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGVSearch.LabelText = "대차 검색";
            this.txtGVSearch.Location = new System.Drawing.Point(50, 3);
            this.txtGVSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGVSearch.Name = "txtGVSearch";
            this.txtGVSearch.Size = new System.Drawing.Size(469, 42);
            this.txtGVSearch.TabIndex = 12;
            this.txtGVSearch.TextBoxText = "";
            this.txtGVSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // dgvGVList
            // 
            this.dgvGVList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGVList.Location = new System.Drawing.Point(12, 158);
            this.dgvGVList.Name = "dgvGVList";
            this.dgvGVList.RowHeadersWidth = 51;
            this.dgvGVList.RowTemplate.Height = 23;
            this.dgvGVList.Size = new System.Drawing.Size(636, 429);
            this.dgvGVList.TabIndex = 9;
            this.dgvGVList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGVList_CellDoubleClick);
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.txtPlanQty);
            this.aPanel4.Controls.Add(this.txtPlanDate);
            this.aPanel4.Controls.Add(this.txtWorkCenter);
            this.aPanel4.Controls.Add(this.txtProcess);
            this.aPanel4.Controls.Add(this.txtItem);
            this.aPanel4.Controls.Add(this.btnCreateWorkOrder);
            this.aPanel4.Location = new System.Drawing.Point(654, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 8;
            // 
            // txtPlanQty
            // 
            this.txtPlanQty.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlanQty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.LabelText = "계획수량";
            this.txtPlanQty.Location = new System.Drawing.Point(42, 266);
            this.txtPlanQty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Size = new System.Drawing.Size(469, 42);
            this.txtPlanQty.TabIndex = 26;
            this.txtPlanQty.TextBoxText = "";
            this.txtPlanQty.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtPlanDate
            // 
            this.txtPlanDate.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlanDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanDate.LabelText = "작업지시일";
            this.txtPlanDate.Location = new System.Drawing.Point(42, 212);
            this.txtPlanDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPlanDate.Name = "txtPlanDate";
            this.txtPlanDate.Size = new System.Drawing.Size(469, 42);
            this.txtPlanDate.TabIndex = 25;
            this.txtPlanDate.TextBoxText = "";
            this.txtPlanDate.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWorkCenter
            // 
            this.txtWorkCenter.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWorkCenter.CodeText = null;
            this.txtWorkCenter.DataType = Axxen.CustomControls.DataType.WorkCenters;
            this.txtWorkCenter.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenter.LabelText = "작업장";
            this.txtWorkCenter.Location = new System.Drawing.Point(42, 158);
            this.txtWorkCenter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWorkCenter.Name = "txtWorkCenter";
            this.txtWorkCenter.Size = new System.Drawing.Size(469, 42);
            this.txtWorkCenter.TabIndex = 24;
            this.txtWorkCenter.TextBoxText = "";
            this.txtWorkCenter.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtProcess
            // 
            this.txtProcess.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcess.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProcess.CodeText = null;
            this.txtProcess.DataType = Axxen.CustomControls.DataType.Processes;
            this.txtProcess.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcess.LabelText = "공정";
            this.txtProcess.Location = new System.Drawing.Point(42, 104);
            this.txtProcess.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(469, 42);
            this.txtProcess.TabIndex = 23;
            this.txtProcess.TextBoxText = "";
            this.txtProcess.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtItem
            // 
            this.txtItem.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtItem.CodeText = null;
            this.txtItem.DataType = Axxen.CustomControls.DataType.Items;
            this.txtItem.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItem.LabelText = "품목";
            this.txtItem.Location = new System.Drawing.Point(42, 52);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(469, 42);
            this.txtItem.TabIndex = 22;
            this.txtItem.TextBoxText = "";
            this.txtItem.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // btnCreateWorkOrder
            // 
            this.btnCreateWorkOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateWorkOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnCreateWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateWorkOrder.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreateWorkOrder.Location = new System.Drawing.Point(92, 350);
            this.btnCreateWorkOrder.Name = "btnCreateWorkOrder";
            this.btnCreateWorkOrder.Size = new System.Drawing.Size(365, 105);
            this.btnCreateWorkOrder.TabIndex = 16;
            this.btnCreateWorkOrder.Text = "작업지시 생성";
            this.btnCreateWorkOrder.UseVisualStyleBackColor = false;
            this.btnCreateWorkOrder.Click += new System.EventHandler(this.btnCreateWorkOrder_Click);
            // 
            // POP_PRD_009
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.dgvGVList);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aPanel5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_009";
            this.Load += new System.EventHandler(this.POP_PRD_009_Load);
            this.Controls.SetChildIndex(this.aPanel5, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.dgvGVList, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.aPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVList)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.APanel aPanel5;
        private Axxen.CustomControls.ADataGridView dgvGVList;
        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPlanQty;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPlanDate;
        private Axxen.CustomControls.ABigTextBox_Searchable txtWorkCenter;
        private Axxen.CustomControls.ABigTextBox_Searchable txtProcess;
        private Axxen.CustomControls.ABigTextBox_Searchable txtItem;
        private Axxen.CustomControls.AButton btnCreateWorkOrder;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtGVSearch;
        private Axxen.CustomControls.AButton btnSearch;
    }
}
