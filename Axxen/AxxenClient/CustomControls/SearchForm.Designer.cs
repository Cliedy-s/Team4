namespace Axxen.CustomControls
{
    partial class SearchForm
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
            this.dgvSearchResult = new System.Windows.Forms.DataGridView();
            this.aLabel_Header1 = new Axxen.CustomControls.ALabel_Header();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchResult
            // 
            this.dgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResult.Location = new System.Drawing.Point(12, 51);
            this.dgvSearchResult.Name = "dgvSearchResult";
            this.dgvSearchResult.RowTemplate.Height = 23;
            this.dgvSearchResult.Size = new System.Drawing.Size(438, 389);
            this.dgvSearchResult.TabIndex = 0;
            this.dgvSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_CellDoubleClick);
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.AutoSize = true;
            this.aLabel_Header1.Font = new System.Drawing.Font("나눔고딕", 25F, System.Drawing.FontStyle.Bold);
            this.aLabel_Header1.Location = new System.Drawing.Point(12, 9);
            this.aLabel_Header1.Name = "aLabel_Header1";
            this.aLabel_Header1.Size = new System.Drawing.Size(160, 39);
            this.aLabel_Header1.TabIndex = 1;
            this.aLabel_Header1.Text = "lblSearch";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(462, 452);
            this.Controls.Add(this.aLabel_Header1);
            this.Controls.Add(this.dgvSearchResult);
            this.Name = "SearchForm";
            this.Text = "찾기";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchResult;
        private ALabel_Header aLabel_Header1;
    }
}
