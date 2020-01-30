namespace Axxen.sangyoung
{
    partial class PPS_SCH_001_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPS_SCH_001_Report));
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.IsMetric = true;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(800, 450);
            this.documentViewer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 60);
            this.toolStrip1.TabIndex = 1;
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
            // 
            // PPS_SCH_001_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.documentViewer1);
            this.Name = "PPS_SCH_001_Report";
            this.Text = "PPS_SCH_001_Report";
            this.Activated += new System.EventHandler(this.PPS_SCH_001_Report_Activated);
            this.Deactivate += new System.EventHandler(this.PPS_SCH_001_Report_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPS_SCH_001_Report_FormClosed);
            this.Load += new System.EventHandler(this.PPS_SCH_001_Report_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private System.Windows.Forms.ToolStripButton tsbtnPrint;
        public System.Windows.Forms.ToolStrip toolStrip1;
    }
}