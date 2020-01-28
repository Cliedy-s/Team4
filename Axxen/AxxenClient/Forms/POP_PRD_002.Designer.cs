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
            this.aBigTextBox_Searchable3 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.aBigTextBox_Searchable2 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.aBigTextBox_Searchable1 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.btnCreateWorkOrder = new Axxen.CustomControls.AButton();
            this.dgvWorkOrder = new Axxen.CustomControls.ADataGridView();
            this.aBigTextBox_LabeledBigTextBox1 = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.aBigTextBox_LabeledBigTextBox2 = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
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
            this.aPanel4.Controls.Add(this.aBigTextBox_LabeledBigTextBox2);
            this.aPanel4.Controls.Add(this.aBigTextBox_LabeledBigTextBox1);
            this.aPanel4.Controls.Add(this.aBigTextBox_Searchable3);
            this.aPanel4.Controls.Add(this.aBigTextBox_Searchable2);
            this.aPanel4.Controls.Add(this.aBigTextBox_Searchable1);
            this.aPanel4.Controls.Add(this.btnCreateWorkOrder);
            this.aPanel4.Location = new System.Drawing.Point(649, 105);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.Size = new System.Drawing.Size(549, 482);
            this.aPanel4.TabIndex = 7;
            // 
            // aBigTextBox_Searchable3
            // 
            this.aBigTextBox_Searchable3.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_Searchable3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable3.LabelText = "작업장";
            this.aBigTextBox_Searchable3.Location = new System.Drawing.Point(42, 158);
            this.aBigTextBox_Searchable3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_Searchable3.Name = "aBigTextBox_Searchable3";
            this.aBigTextBox_Searchable3.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_Searchable3.TabIndex = 24;
            this.aBigTextBox_Searchable3.TextBoxText = "";
            this.aBigTextBox_Searchable3.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // aBigTextBox_Searchable2
            // 
            this.aBigTextBox_Searchable2.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_Searchable2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable2.LabelText = "공정";
            this.aBigTextBox_Searchable2.Location = new System.Drawing.Point(42, 104);
            this.aBigTextBox_Searchable2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_Searchable2.Name = "aBigTextBox_Searchable2";
            this.aBigTextBox_Searchable2.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_Searchable2.TabIndex = 23;
            this.aBigTextBox_Searchable2.TextBoxText = "";
            this.aBigTextBox_Searchable2.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // aBigTextBox_Searchable1
            // 
            this.aBigTextBox_Searchable1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable1.LabelText = "품목";
            this.aBigTextBox_Searchable1.Location = new System.Drawing.Point(42, 52);
            this.aBigTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_Searchable1.Name = "aBigTextBox_Searchable1";
            this.aBigTextBox_Searchable1.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_Searchable1.TabIndex = 22;
            this.aBigTextBox_Searchable1.TextBoxText = "";
            this.aBigTextBox_Searchable1.TextBoxType = Axxen.CustomControls.type.Normal;
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
            // aBigTextBox_LabeledBigTextBox1
            // 
            this.aBigTextBox_LabeledBigTextBox1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_LabeledBigTextBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox1.LabelText = "계획수량";
            this.aBigTextBox_LabeledBigTextBox1.Location = new System.Drawing.Point(42, 212);
            this.aBigTextBox_LabeledBigTextBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_LabeledBigTextBox1.Name = "aBigTextBox_LabeledBigTextBox1";
            this.aBigTextBox_LabeledBigTextBox1.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_LabeledBigTextBox1.TabIndex = 25;
            this.aBigTextBox_LabeledBigTextBox1.TextBoxText = "";
            this.aBigTextBox_LabeledBigTextBox1.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // aBigTextBox_LabeledBigTextBox2
            // 
            this.aBigTextBox_LabeledBigTextBox2.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aBigTextBox_LabeledBigTextBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_LabeledBigTextBox2.LabelText = "생산의뢰 번호";
            this.aBigTextBox_LabeledBigTextBox2.Location = new System.Drawing.Point(42, 266);
            this.aBigTextBox_LabeledBigTextBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_LabeledBigTextBox2.Name = "aBigTextBox_LabeledBigTextBox2";
            this.aBigTextBox_LabeledBigTextBox2.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_LabeledBigTextBox2.TabIndex = 26;
            this.aBigTextBox_LabeledBigTextBox2.TextBoxText = "";
            this.aBigTextBox_LabeledBigTextBox2.TextBoxType = Axxen.CustomControls.type.Normal;
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
        private Axxen.CustomControls.ADataGridView dgvWorkOrder;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable3;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable2;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable1;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox aBigTextBox_LabeledBigTextBox2;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox aBigTextBox_LabeledBigTextBox1;
    }
}
