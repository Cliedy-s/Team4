namespace AxxenClient.Forms
{
    partial class POP_PRD_013
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
            this.btnDeallocateAll = new Axxen.CustomControls.AButton();
            this.dgvAllocatableWorker = new Axxen.CustomControls.ADataGridView();
            this.dgvAllocatedWorker = new Axxen.CustomControls.ADataGridView();
            this.btnDeallocate = new Axxen.CustomControls.AButton();
            this.btnAllocate = new Axxen.CustomControls.AButton();
            this.aBigHeaderBox1 = new Axxen.CustomControls.ABigHeaderBox();
            this.aBigHeaderBox2 = new Axxen.CustomControls.ABigHeaderBox();
            this.txtWc = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.txtWorkerCnt = new Axxen.CustomControls.ABigTextBox_LabeledBigTextBox();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatableWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatedWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(0, 593);
            this.panBottom.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aLabel_Header1
            // 
            this.lblHeaderHeader.Text = "작업자 할당";
            // 
            // btnDeallocateAll
            // 
            this.btnDeallocateAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeallocateAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnDeallocateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeallocateAll.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeallocateAll.Location = new System.Drawing.Point(519, 460);
            this.btnDeallocateAll.Name = "btnDeallocateAll";
            this.btnDeallocateAll.Size = new System.Drawing.Size(154, 123);
            this.btnDeallocateAll.TabIndex = 29;
            this.btnDeallocateAll.Text = "작업자\r\n전체 해제\r\n→";
            this.btnDeallocateAll.UseVisualStyleBackColor = false;
            this.btnDeallocateAll.Click += new System.EventHandler(this.btnDeallocateAll_Click);
            // 
            // dgvAllocatableWorker
            // 
            this.dgvAllocatableWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllocatableWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocatableWorker.Location = new System.Drawing.Point(679, 196);
            this.dgvAllocatableWorker.Name = "dgvAllocatableWorker";
            this.dgvAllocatableWorker.RowHeadersWidth = 51;
            this.dgvAllocatableWorker.RowTemplate.Height = 23;
            this.dgvAllocatableWorker.Size = new System.Drawing.Size(521, 389);
            this.dgvAllocatableWorker.TabIndex = 28;
            // 
            // dgvAllocatedWorker
            // 
            this.dgvAllocatedWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAllocatedWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocatedWorker.Location = new System.Drawing.Point(12, 196);
            this.dgvAllocatedWorker.Name = "dgvAllocatedWorker";
            this.dgvAllocatedWorker.RowHeadersWidth = 51;
            this.dgvAllocatedWorker.RowTemplate.Height = 23;
            this.dgvAllocatedWorker.Size = new System.Drawing.Size(501, 389);
            this.dgvAllocatedWorker.TabIndex = 27;
            // 
            // btnDeallocate
            // 
            this.btnDeallocate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeallocate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnDeallocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeallocate.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeallocate.Location = new System.Drawing.Point(519, 329);
            this.btnDeallocate.Name = "btnDeallocate";
            this.btnDeallocate.Size = new System.Drawing.Size(154, 123);
            this.btnDeallocate.TabIndex = 35;
            this.btnDeallocate.Text = "작업자\r\n해제\r\n→";
            this.btnDeallocate.UseVisualStyleBackColor = false;
            this.btnDeallocate.Click += new System.EventHandler(this.btnDeallocate_Click);
            // 
            // btnAllocate
            // 
            this.btnAllocate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAllocate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnAllocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllocate.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAllocate.Location = new System.Drawing.Point(519, 200);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(154, 123);
            this.btnAllocate.TabIndex = 36;
            this.btnAllocate.Text = "작업자\r\n할당\r\n←";
            this.btnAllocate.UseVisualStyleBackColor = false;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // aBigHeaderBox1
            // 
            this.aBigHeaderBox1.allfont = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aBigHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aBigHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox1.HeaderBoxText = "할당 작업자";
            this.aBigHeaderBox1.Location = new System.Drawing.Point(12, 150);
            this.aBigHeaderBox1.Name = "aBigHeaderBox1";
            this.aBigHeaderBox1.Size = new System.Drawing.Size(273, 50);
            this.aBigHeaderBox1.TabIndex = 37;
            // 
            // aBigHeaderBox2
            // 
            this.aBigHeaderBox2.allfont = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aBigHeaderBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aBigHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox2.HeaderBoxText = "할당 대상 작업자";
            this.aBigHeaderBox2.Location = new System.Drawing.Point(679, 150);
            this.aBigHeaderBox2.Name = "aBigHeaderBox2";
            this.aBigHeaderBox2.Size = new System.Drawing.Size(273, 50);
            this.aBigHeaderBox2.TabIndex = 38;
            // 
            // txtWc
            // 
            this.txtWc.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWc.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWc.LabelText = "작업장";
            this.txtWc.Location = new System.Drawing.Point(12, 106);
            this.txtWc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWc.Name = "txtWc";
            this.txtWc.Size = new System.Drawing.Size(469, 42);
            this.txtWc.TabIndex = 39;
            this.txtWc.TextBoxText = "";
            this.txtWc.TextBoxType = Axxen.CustomControls.TextType.ReadOnly;
            // 
            // txtWorkerCnt
            // 
            this.txtWorkerCnt.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerCnt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkerCnt.LabelText = "할당 작업자수";
            this.txtWorkerCnt.Location = new System.Drawing.Point(489, 106);
            this.txtWorkerCnt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtWorkerCnt.Name = "txtWorkerCnt";
            this.txtWorkerCnt.Size = new System.Drawing.Size(469, 42);
            this.txtWorkerCnt.TabIndex = 40;
            this.txtWorkerCnt.TextBoxText = "";
            this.txtWorkerCnt.TextBoxType = Axxen.CustomControls.TextType.ReadOnly;
            // 
            // POP_PRD_013
            // 
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.txtWorkerCnt);
            this.Controls.Add(this.txtWc);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.btnDeallocate);
            this.Controls.Add(this.btnDeallocateAll);
            this.Controls.Add(this.dgvAllocatableWorker);
            this.Controls.Add(this.dgvAllocatedWorker);
            this.Controls.Add(this.aBigHeaderBox2);
            this.Controls.Add(this.aBigHeaderBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_013";
            this.Load += new System.EventHandler(this.POP_PRD_013_Load);
            this.Controls.SetChildIndex(this.aBigHeaderBox1, 0);
            this.Controls.SetChildIndex(this.aBigHeaderBox2, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.dgvAllocatedWorker, 0);
            this.Controls.SetChildIndex(this.dgvAllocatableWorker, 0);
            this.Controls.SetChildIndex(this.btnDeallocateAll, 0);
            this.Controls.SetChildIndex(this.btnDeallocate, 0);
            this.Controls.SetChildIndex(this.btnAllocate, 0);
            this.Controls.SetChildIndex(this.txtWc, 0);
            this.Controls.SetChildIndex(this.txtWorkerCnt, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatableWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocatedWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.AButton btnDeallocateAll;
        private Axxen.CustomControls.ADataGridView dgvAllocatableWorker;
        private Axxen.CustomControls.ADataGridView dgvAllocatedWorker;
        private Axxen.CustomControls.AButton btnDeallocate;
        private Axxen.CustomControls.AButton btnAllocate;
        private Axxen.CustomControls.ABigHeaderBox aBigHeaderBox1;
        private Axxen.CustomControls.ABigHeaderBox aBigHeaderBox2;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtWc;
        private Axxen.CustomControls.ABigTextBox_LabeledBigTextBox txtWorkerCnt;
    }
}
