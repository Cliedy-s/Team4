namespace AxxenClient.Forms
{
    partial class POP_PRD_016
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
            this.dgvNopList = new Axxen.CustomControls.ADataGridView();
            this.btnChangeReason = new Axxen.CustomControls.AButton();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNopList)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "비가동 등록";
            // 
            // aPanel1
            // 
            this.panBottom.Location = new System.Drawing.Point(0, 593);
            this.panBottom.Margin = new System.Windows.Forms.Padding(2);
            // 
            // dgvNopList
            // 
            this.dgvNopList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNopList.Location = new System.Drawing.Point(12, 105);
            this.dgvNopList.Name = "dgvNopList";
            this.dgvNopList.RowHeadersWidth = 51;
            this.dgvNopList.RowTemplate.Height = 23;
            this.dgvNopList.Size = new System.Drawing.Size(1001, 482);
            this.dgvNopList.TabIndex = 7;
            // 
            // btnChangeReason
            // 
            this.btnChangeReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnChangeReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeReason.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChangeReason.Location = new System.Drawing.Point(1019, 105);
            this.btnChangeReason.Name = "btnChangeReason";
            this.btnChangeReason.Size = new System.Drawing.Size(179, 482);
            this.btnChangeReason.TabIndex = 38;
            this.btnChangeReason.Text = "비가동\r\n사유변경";
            this.btnChangeReason.UseVisualStyleBackColor = false;
            this.btnChangeReason.Click += new System.EventHandler(this.btnChangeReason_Click);
            // 
            // POP_PRD_016
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.btnChangeReason);
            this.Controls.Add(this.dgvNopList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_016";
            this.Load += new System.EventHandler(this.POP_PRD_016_Load);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.dgvNopList, 0);
            this.Controls.SetChildIndex(this.btnChangeReason, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNopList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.ADataGridView dgvNopList;
        private Axxen.CustomControls.AButton btnChangeReason;
    }
}
