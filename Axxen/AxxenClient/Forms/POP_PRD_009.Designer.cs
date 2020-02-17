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
            this.txtGVSearch = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.dgvGVList = new Axxen.CustomControls.ADataGridView();
            this.aPanel4 = new Axxen.CustomControls.APanel();
            this.lblHistSeq = new Axxen.CustomControls.ALabel();
            this.txtPlanQty = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtPlanDate = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtWcSearch = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.txtProcessSearch = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.txtItemSearch = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.lblReqSeq = new Axxen.CustomControls.ALabel();
            this.lblReqNo = new Axxen.CustomControls.ALabel();
            this.lblUnit = new Axxen.CustomControls.ALabel();
            this.btnCreateWorkOrder = new Axxen.CustomControls.AButton();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.aPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVList)).BeginInit();
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
            this.aLabel_Header1.Text = "적재 작업지시 생성";
            // 
            // aPanel5
            // 
            this.aPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel5.Controls.Add(this.txtGVSearch);
            this.aPanel5.Controls.Add(this.btnSearch);
            this.aPanel5.Location = new System.Drawing.Point(12, 105);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.Size = new System.Drawing.Size(636, 47);
            this.aPanel5.TabIndex = 11;
            // 
            // txtGVSearch
            // 
            this.txtGVSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGVSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGVSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGVSearch.LabelText = "대차검색";
            this.txtGVSearch.Location = new System.Drawing.Point(39, 2);
            this.txtGVSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtGVSearch.Name = "txtGVSearch";
            this.txtGVSearch.Size = new System.Drawing.Size(469, 42);
            this.txtGVSearch.TabIndex = 35;
            this.txtGVSearch.TextBoxText = "";
            this.txtGVSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(509, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 29);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.aPanel4.Controls.Add(this.lblHistSeq);
            this.aPanel4.Controls.Add(this.txtPlanQty);
            this.aPanel4.Controls.Add(this.txtPlanDate);
            this.aPanel4.Controls.Add(this.txtWcSearch);
            this.aPanel4.Controls.Add(this.txtProcessSearch);
            this.aPanel4.Controls.Add(this.txtItemSearch);
            this.aPanel4.Controls.Add(this.lblReqSeq);
            this.aPanel4.Controls.Add(this.lblReqNo);
            this.aPanel4.Controls.Add(this.lblUnit);
            this.aPanel4.Controls.Add(this.btnCreateWorkOrder);
            this.aPanel4.Location = new System.Drawing.Point(654, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 8;
            // 
            // lblHistSeq
            // 
            this.lblHistSeq.AutoSize = true;
            this.lblHistSeq.Location = new System.Drawing.Point(236, 309);
            this.lblHistSeq.Name = "lblHistSeq";
            this.lblHistSeq.Size = new System.Drawing.Size(72, 15);
            this.lblHistSeq.TabIndex = 35;
            this.lblHistSeq.Text = "lblHistSeq";
            this.lblHistSeq.Visible = false;
            // 
            // txtPlanQty
            // 
            this.txtPlanQty.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlanQty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.LabelText = "계획수량";
            this.txtPlanQty.Location = new System.Drawing.Point(42, 267);
            this.txtPlanQty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Size = new System.Drawing.Size(469, 42);
            this.txtPlanQty.TabIndex = 34;
            this.txtPlanQty.TextBoxText = "";
            this.txtPlanQty.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // txtPlanDate
            // 
            this.txtPlanDate.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlanDate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanDate.LabelText = "작업지시일";
            this.txtPlanDate.Location = new System.Drawing.Point(42, 213);
            this.txtPlanDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPlanDate.Name = "txtPlanDate";
            this.txtPlanDate.Size = new System.Drawing.Size(469, 42);
            this.txtPlanDate.TabIndex = 33;
            this.txtPlanDate.TextBoxText = "";
            this.txtPlanDate.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWcSearch
            // 
            this.txtWcSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWcSearch.CodeText = null;
            this.txtWcSearch.DataType = Axxen.CustomControls.DataType.WorkCenters;
            this.txtWcSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcSearch.LabelText = "작업장";
            this.txtWcSearch.Location = new System.Drawing.Point(42, 159);
            this.txtWcSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWcSearch.Name = "txtWcSearch";
            this.txtWcSearch.Size = new System.Drawing.Size(469, 42);
            this.txtWcSearch.TabIndex = 32;
            this.txtWcSearch.TextBoxText = "";
            this.txtWcSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtProcessSearch
            // 
            this.txtProcessSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcessSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProcessSearch.CodeText = null;
            this.txtProcessSearch.DataType = Axxen.CustomControls.DataType.Processes;
            this.txtProcessSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcessSearch.LabelText = "공정";
            this.txtProcessSearch.Location = new System.Drawing.Point(42, 105);
            this.txtProcessSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtProcessSearch.Name = "txtProcessSearch";
            this.txtProcessSearch.Size = new System.Drawing.Size(469, 42);
            this.txtProcessSearch.TabIndex = 31;
            this.txtProcessSearch.TextBoxText = "";
            this.txtProcessSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtItemSearch.CodeText = null;
            this.txtItemSearch.DataType = Axxen.CustomControls.DataType.Items;
            this.txtItemSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemSearch.LabelText = "품목";
            this.txtItemSearch.Location = new System.Drawing.Point(42, 53);
            this.txtItemSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(469, 42);
            this.txtItemSearch.TabIndex = 30;
            this.txtItemSearch.TextBoxText = "";
            this.txtItemSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // lblReqSeq
            // 
            this.lblReqSeq.AutoSize = true;
            this.lblReqSeq.Location = new System.Drawing.Point(158, 306);
            this.lblReqSeq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReqSeq.Name = "lblReqSeq";
            this.lblReqSeq.Size = new System.Drawing.Size(73, 15);
            this.lblReqSeq.TabIndex = 29;
            this.lblReqSeq.Text = "lblReqSeq";
            this.lblReqSeq.Visible = false;
            // 
            // lblReqNo
            // 
            this.lblReqNo.AutoSize = true;
            this.lblReqNo.Location = new System.Drawing.Point(89, 306);
            this.lblReqNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReqNo.Name = "lblReqNo";
            this.lblReqNo.Size = new System.Drawing.Size(65, 15);
            this.lblReqNo.TabIndex = 28;
            this.lblReqNo.Text = "lblReqNo";
            this.lblReqNo.Visible = false;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(39, 306);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(46, 15);
            this.lblUnit.TabIndex = 27;
            this.lblUnit.Text = "lblUnit";
            this.lblUnit.Visible = false;
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
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.dgvGVList);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.aPanel5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_009";
            this.Load += new System.EventHandler(this.POP_PRD_009_Load);
            this.Controls.SetChildIndex(this.aPanel5, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.dgvGVList, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.aPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGVList)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.APanel aPanel5;
        private Axxen.CustomControls.ADataGridView dgvGVList;
        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton btnCreateWorkOrder;
        private Axxen.CustomControls.ALabel lblUnit;
        private Axxen.CustomControls.ALabel lblReqSeq;
        private Axxen.CustomControls.ALabel lblReqNo;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPlanQty;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPlanDate;
        private Axxen.CustomControls.ABigTextBox_Searchable txtWcSearch;
        private Axxen.CustomControls.ABigTextBox_Searchable txtProcessSearch;
        private Axxen.CustomControls.ABigTextBox_Searchable txtItemSearch;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtGVSearch;
        private Axxen.CustomControls.AButton btnSearch;
        private Axxen.CustomControls.ALabel lblHistSeq;
    }
}
