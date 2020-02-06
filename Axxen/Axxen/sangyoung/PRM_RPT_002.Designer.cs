namespace Axxen
{
    partial class PRM_RPT_002
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
            this.dtpDate = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.dtpDate);
            this.aPanel1.Controls.Add(this.aLabel1);
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.documentViewer1);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(88, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(103, 23);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.ValueChanged += new System.EventHandler(this.ADateTimePicker1_ValueChanged);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(55, 15);
            this.aLabel1.TabIndex = 13;
            this.aLabel1.Text = "생산일자";
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = true;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(1122, 555);
            this.documentViewer1.TabIndex = 0;
            // 
            // PRM_RPT_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "PRM_RPT_002";
            this.Load += new System.EventHandler(this.PRM_RPT_002_Load);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ADateTimePicker dtpDate;
        private CustomControls.ALabel aLabel1;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
    }
}
