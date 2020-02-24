namespace Axxen
{
    partial class PRM_PRF_007
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components 
            ;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aLabel_SubHeader1 = new Axxen.CustomControls.ALabel_SubHeader();
            this.aLabel_SubHeader2 = new Axxen.CustomControls.ALabel_SubHeader();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(851, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(277, 576);
            this.dataGridView1.TabIndex = 2;
            // 
            // aLabel_SubHeader1
            // 
            this.aLabel_SubHeader1.AutoSize = true;
            this.aLabel_SubHeader1.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold);
            this.aLabel_SubHeader1.Location = new System.Drawing.Point(925, 21);
            this.aLabel_SubHeader1.Name = "aLabel_SubHeader1";
            this.aLabel_SubHeader1.Size = new System.Drawing.Size(117, 23);
            this.aLabel_SubHeader1.TabIndex = 3;
            this.aLabel_SubHeader1.Text = "빈 대차 현황";
            // 
            // aLabel_SubHeader2
            // 
            this.aLabel_SubHeader2.AutoSize = true;
            this.aLabel_SubHeader2.Font = new System.Drawing.Font("나눔고딕", 15F, System.Drawing.FontStyle.Bold);
            this.aLabel_SubHeader2.Location = new System.Drawing.Point(21, 21);
            this.aLabel_SubHeader2.Name = "aLabel_SubHeader2";
            this.aLabel_SubHeader2.Size = new System.Drawing.Size(174, 23);
            this.aLabel_SubHeader2.TabIndex = 5;
            this.aLabel_SubHeader2.Text = "사용중인 대차 현황";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(823, 576);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // PRM_PRF_007
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Controls.Add(this.aLabel_SubHeader2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.aLabel_SubHeader1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PRM_PRF_007";
            this.Text = "대차현황모니터링";
            this.Load += new System.EventHandler(this.PRM_PRF_007_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.ALabel_SubHeader aLabel_SubHeader1;
        private CustomControls.ALabel_SubHeader aLabel_SubHeader2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
