namespace AxxenClient.Forms
{
    partial class POP_PRD_002
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
            this.lblItem_Unit = new Axxen.CustomControls.ALabel();
            this.lblReq_Seq = new Axxen.CustomControls.ALabel();
            this.txtReqNo = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtPlanQty = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtWcSearch = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.txtProcessSearch = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.txtItemSearch = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.btnCreateWorkOrder = new Axxen.CustomControls.AButton();
            this.dgvWoReq = new Axxen.CustomControls.ADataGridView();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWoReq)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Location = new System.Drawing.Point(184, 29);
            this.aLabel_Header1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabel_Header1.Text = "작업지시 생성";
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
            this.aPanel4.Controls.Add(this.lblItem_Unit);
            this.aPanel4.Controls.Add(this.lblReq_Seq);
            this.aPanel4.Controls.Add(this.txtReqNo);
            this.aPanel4.Controls.Add(this.txtPlanQty);
            this.aPanel4.Controls.Add(this.txtWcSearch);
            this.aPanel4.Controls.Add(this.txtProcessSearch);
            this.aPanel4.Controls.Add(this.txtItemSearch);
            this.aPanel4.Controls.Add(this.btnCreateWorkOrder);
            this.aPanel4.Location = new System.Drawing.Point(649, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 7;
            // 
            // lblItem_Unit
            // 
            this.lblItem_Unit.AutoSize = true;
            this.lblItem_Unit.Location = new System.Drawing.Point(109, 314);
            this.lblItem_Unit.Name = "lblItem_Unit";
            this.lblItem_Unit.Size = new System.Drawing.Size(58, 15);
            this.lblItem_Unit.TabIndex = 28;
            this.lblItem_Unit.Text = "Item_Unit";
            this.lblItem_Unit.Visible = false;
            // 
            // lblReq_Seq
            // 
            this.lblReq_Seq.AutoSize = true;
            this.lblReq_Seq.Location = new System.Drawing.Point(39, 314);
            this.lblReq_Seq.Name = "lblReq_Seq";
            this.lblReq_Seq.Size = new System.Drawing.Size(52, 15);
            this.lblReq_Seq.TabIndex = 27;
            this.lblReq_Seq.Text = "Req_Seq";
            this.lblReq_Seq.Visible = false;
            // 
            // txtReqNo
            // 
            this.txtReqNo.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReqNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReqNo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReqNo.LabelText = "생산의뢰 번호";
            this.txtReqNo.Location = new System.Drawing.Point(42, 266);
            this.txtReqNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtReqNo.Name = "txtReqNo";
            this.txtReqNo.Size = new System.Drawing.Size(469, 42);
            this.txtReqNo.TabIndex = 26;
            this.txtReqNo.TextBoxText = "";
            this.txtReqNo.TextBoxType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtPlanQty
            // 
            this.txtPlanQty.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlanQty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.LabelText = "계획수량";
            this.txtPlanQty.Location = new System.Drawing.Point(42, 212);
            this.txtPlanQty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Size = new System.Drawing.Size(469, 42);
            this.txtPlanQty.TabIndex = 25;
            this.txtPlanQty.TextBoxText = "";
            this.txtPlanQty.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // txtWcSearch
            // 
            this.txtWcSearch.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWcSearch.CodeText = null;
            this.txtWcSearch.DataType = Axxen.CustomControls.DataType.WorkCenters;
            this.txtWcSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcSearch.LabelText = "작업장";
            this.txtWcSearch.Location = new System.Drawing.Point(42, 158);
            this.txtWcSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWcSearch.Name = "txtWcSearch";
            this.txtWcSearch.Size = new System.Drawing.Size(469, 42);
            this.txtWcSearch.TabIndex = 24;
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
            this.txtProcessSearch.Location = new System.Drawing.Point(42, 104);
            this.txtProcessSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtProcessSearch.Name = "txtProcessSearch";
            this.txtProcessSearch.Size = new System.Drawing.Size(469, 42);
            this.txtProcessSearch.TabIndex = 23;
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
            this.txtItemSearch.Location = new System.Drawing.Point(42, 52);
            this.txtItemSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(469, 42);
            this.txtItemSearch.TabIndex = 22;
            this.txtItemSearch.TextBoxText = "";
            this.txtItemSearch.TextBoxType = Axxen.CustomControls.TextType.Normal;
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
            // dgvWoReq
            // 
            this.dgvWoReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWoReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWoReq.Location = new System.Drawing.Point(7, 105);
            this.dgvWoReq.Name = "dgvWoReq";
            this.dgvWoReq.RowHeadersWidth = 51;
            this.dgvWoReq.RowTemplate.Height = 23;
            this.dgvWoReq.Size = new System.Drawing.Size(636, 482);
            this.dgvWoReq.TabIndex = 6;
            this.dgvWoReq.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkOrder_CellDoubleClick);
            // 
            // POP_PRD_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.dgvWoReq);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_002";
            this.Text = "작업지시생성";
            this.Load += new System.EventHandler(this.POP_PRD_002_Load);
            this.Controls.SetChildIndex(this.dgvWoReq, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.aPanel4.ResumeLayout(false);
            this.aPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWoReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton btnCreateWorkOrder;
        private Axxen.CustomControls.ADataGridView dgvWoReq;
        private Axxen.CustomControls.ABigTextBox_Searchable txtWcSearch;
        private Axxen.CustomControls.ABigTextBox_Searchable txtProcessSearch;
        private Axxen.CustomControls.ABigTextBox_Searchable txtItemSearch;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtReqNo;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtPlanQty;
        private Axxen.CustomControls.ALabel lblReq_Seq;
        private Axxen.CustomControls.ALabel lblItem_Unit;
    }
}
