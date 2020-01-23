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
            this.aTextBox_LabeledBigTextBox1 = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.btnCreateWorkOrder = new Axxen.CustomControls.AButton();
            this.txtPlanQty = new Axxen.CustomControls.ATextBox_LabeledBigTextBox();
            this.txtWcCode = new Axxen.CustomControls.ATextBox_Searchable();
            this.txtProcessCode = new Axxen.CustomControls.ATextBox_Searchable();
            this.dgvWorkOrder = new Axxen.CustomControls.ADataGridView();
            this.aTextBox_Searchable1 = new Axxen.CustomControls.ATextBox_Searchable();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).BeginInit();
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
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aPanel4
            // 
            this.aPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel4.Controls.Add(this.aTextBox_Searchable1);
            this.aPanel4.Controls.Add(this.aTextBox_LabeledBigTextBox1);
            this.aPanel4.Controls.Add(this.btnCreateWorkOrder);
            this.aPanel4.Controls.Add(this.txtPlanQty);
            this.aPanel4.Controls.Add(this.txtWcCode);
            this.aPanel4.Controls.Add(this.txtProcessCode);
            this.aPanel4.Location = new System.Drawing.Point(649, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 7;
            // 
            // aTextBox_LabeledBigTextBox1
            // 
            this.aTextBox_LabeledBigTextBox1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_LabeledBigTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_LabeledBigTextBox1.LabelText = "생산의뢰 번호";
            this.aTextBox_LabeledBigTextBox1.Location = new System.Drawing.Point(92, 229);
            this.aTextBox_LabeledBigTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_LabeledBigTextBox1.Name = "aTextBox_LabeledBigTextBox1";
            this.aTextBox_LabeledBigTextBox1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_LabeledBigTextBox1.TabIndex = 17;
            this.aTextBox_LabeledBigTextBox1.TextBoxText = "";
            this.aTextBox_LabeledBigTextBox1.TextBoxType = Axxen.CustomControls.type.Normal;
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
            // txtPlanQty
            // 
            this.txtPlanQty.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPlanQty.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlanQty.LabelText = "계획수량";
            this.txtPlanQty.Location = new System.Drawing.Point(92, 191);
            this.txtPlanQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlanQty.Name = "txtPlanQty";
            this.txtPlanQty.Size = new System.Drawing.Size(365, 30);
            this.txtPlanQty.TabIndex = 15;
            this.txtPlanQty.TextBoxText = "";
            this.txtPlanQty.TextBoxType = Axxen.CustomControls.type.Numeric;
            // 
            // txtWcCode
            // 
            this.txtWcCode.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWcCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWcCode.LabelText = "작업장";
            this.txtWcCode.Location = new System.Drawing.Point(92, 153);
            this.txtWcCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWcCode.Name = "txtWcCode";
            this.txtWcCode.Size = new System.Drawing.Size(365, 30);
            this.txtWcCode.TabIndex = 14;
            this.txtWcCode.TextBoxText = "";
            this.txtWcCode.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // txtProcessCode
            // 
            this.txtProcessCode.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcessCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProcessCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcessCode.LabelText = "공정";
            this.txtProcessCode.Location = new System.Drawing.Point(92, 115);
            this.txtProcessCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcessCode.Name = "txtProcessCode";
            this.txtProcessCode.Size = new System.Drawing.Size(365, 30);
            this.txtProcessCode.TabIndex = 13;
            this.txtProcessCode.TextBoxText = "";
            this.txtProcessCode.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // dgvWorkOrder
            // 
            this.dgvWorkOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrder.Location = new System.Drawing.Point(7, 105);
            this.dgvWorkOrder.Name = "dgvWorkOrder";
            this.dgvWorkOrder.RowHeadersWidth = 51;
            this.dgvWorkOrder.RowTemplate.Height = 23;
            this.dgvWorkOrder.Size = new System.Drawing.Size(636, 482);
            this.dgvWorkOrder.TabIndex = 6;
            this.dgvWorkOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkOrder_CellDoubleClick);
            // 
            // aTextBox_Searchable1
            // 
            this.aTextBox_Searchable1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_Searchable1.LabelText = "품목";
            this.aTextBox_Searchable1.Location = new System.Drawing.Point(92, 77);
            this.aTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Searchable1.Name = "aTextBox_Searchable1";
            this.aTextBox_Searchable1.Size = new System.Drawing.Size(365, 30);
            this.aTextBox_Searchable1.TabIndex = 18;
            this.aTextBox_Searchable1.TextBoxText = "";
            this.aTextBox_Searchable1.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // POP_PRD_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.dgvWorkOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_002";
            this.Load += new System.EventHandler(this.POP_PRD_002_Load);
            this.Controls.SetChildIndex(this.dgvWorkOrder, 0);
            this.Controls.SetChildIndex(this.aPanel4, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.APanel aPanel4;
        private Axxen.CustomControls.AButton btnCreateWorkOrder;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox txtPlanQty;
        private Axxen.CustomControls.ATextBox_Searchable txtWcCode;
        private Axxen.CustomControls.ATextBox_Searchable txtProcessCode;
        private Axxen.CustomControls.ADataGridView dgvWorkOrder;
        private Axxen.CustomControls.ATextBox_LabeledBigTextBox aTextBox_LabeledBigTextBox1;
        private Axxen.CustomControls.ATextBox_Searchable aTextBox_Searchable1;
    }
}
