namespace Axxen
{
    partial class PRM_RPT_003
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRM_RPT_003));
            this.dtpDate = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.dtpDate.Location = new System.Drawing.Point(87, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(103, 23);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1148, 60);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.AutoSize = false;
            this.tsbtnPrint.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrint.Image")));
            this.tsbtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(50, 57);
            this.tsbtnPrint.Text = "출력";
            this.tsbtnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnPrint.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnPrint.ToolTipText = "조회";
            this.tsbtnPrint.Click += new System.EventHandler(this.TsbtnPrint_Click);
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
            // PRM_RPT_003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Name = "PRM_RPT_003";
            this.Activated += new System.EventHandler(this.PRM_RPT_003_Activated);
            this.Deactivate += new System.EventHandler(this.PRM_RPT_003_Deactivate);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aHeaderBox1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ADateTimePicker dtpDate;
        private CustomControls.ALabel aLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnPrint;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
    }
}
