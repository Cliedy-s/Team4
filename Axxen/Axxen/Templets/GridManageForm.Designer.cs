namespace Axxen
{
    partial class GridManageForm
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
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aSplitContainer1 = new Axxen.CustomControls.ASplitContainer();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel2
            // 
            this.aPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel2.Location = new System.Drawing.Point(12, 12);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(776, 59);
            this.aPanel2.TabIndex = 4;
            // 
            // aSplitContainer1
            // 
            this.aSplitContainer1.Location = new System.Drawing.Point(12, 77);
            this.aSplitContainer1.Name = "aSplitContainer1";
            this.aSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // aSplitContainer1.Panel1
            // 
            this.aSplitContainer1.Panel1.Controls.Add(this.aDataGridView1);
            this.aSplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // aSplitContainer1.Panel2
            // 
            this.aSplitContainer1.Panel2.Controls.Add(this.aPanel1);
            this.aSplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aSplitContainer1.Size = new System.Drawing.Size(776, 361);
            this.aSplitContainer1.SplitterDistance = 290;
            this.aSplitContainer1.TabIndex = 5;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(776, 290);
            this.aDataGridView1.TabIndex = 6;
            // 
            // aPanel1
            // 
            this.aPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanel1.Location = new System.Drawing.Point(0, 0);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(776, 67);
            this.aPanel1.TabIndex = 7;
            // 
            // GridManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aSplitContainer1);
            this.Name = "GridManageForm";
            this.Text = "GrieManageForm";
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected CustomControls.APanel aPanel2;
        protected CustomControls.ASplitContainer aSplitContainer1;
        protected CustomControls.ADataGridView aDataGridView1;
        protected CustomControls.APanel aPanel1;
    }
}