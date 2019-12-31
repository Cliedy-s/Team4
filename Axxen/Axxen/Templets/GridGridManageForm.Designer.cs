namespace Axxen
{
    partial class GridGridManageForm
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
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.aSplitContainer1 = new Axxen.CustomControls.ASplitContainer();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.aSplitContainer2 = new Axxen.CustomControls.ASplitContainer();
            this.aDataGridView2 = new Axxen.CustomControls.ADataGridView();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer2)).BeginInit();
            this.aSplitContainer2.Panel1.SuspendLayout();
            this.aSplitContainer2.Panel2.SuspendLayout();
            this.aSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel1.Location = new System.Drawing.Point(12, 12);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(776, 59);
            this.aPanel1.TabIndex = 3;
            // 
            // aSplitContainer1
            // 
            this.aSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aSplitContainer1.Location = new System.Drawing.Point(12, 77);
            this.aSplitContainer1.Name = "aSplitContainer1";
            // 
            // aSplitContainer1.Panel1
            // 
            this.aSplitContainer1.Panel1.Controls.Add(this.aDataGridView1);
            // 
            // aSplitContainer1.Panel2
            // 
            this.aSplitContainer1.Panel2.Controls.Add(this.aSplitContainer2);
            this.aSplitContainer1.Size = new System.Drawing.Size(776, 361);
            this.aSplitContainer1.SplitterDistance = 298;
            this.aSplitContainer1.TabIndex = 4;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(298, 361);
            this.aDataGridView1.TabIndex = 7;
            // 
            // aSplitContainer2
            // 
            this.aSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.aSplitContainer2.Name = "aSplitContainer2";
            this.aSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // aSplitContainer2.Panel1
            // 
            this.aSplitContainer2.Panel1.Controls.Add(this.aDataGridView2);
            // 
            // aSplitContainer2.Panel2
            // 
            this.aSplitContainer2.Panel2.Controls.Add(this.aPanel2);
            this.aSplitContainer2.Size = new System.Drawing.Size(474, 361);
            this.aSplitContainer2.SplitterDistance = 279;
            this.aSplitContainer2.TabIndex = 0;
            // 
            // aDataGridView2
            // 
            this.aDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.aDataGridView2.Name = "aDataGridView2";
            this.aDataGridView2.RowTemplate.Height = 23;
            this.aDataGridView2.Size = new System.Drawing.Size(474, 279);
            this.aDataGridView2.TabIndex = 7;
            // 
            // aPanel2
            // 
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(474, 78);
            this.aPanel2.TabIndex = 8;
            // 
            // GridGridManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aSplitContainer1);
            this.Controls.Add(this.aPanel1);
            this.Name = "GridGridManageForm";
            this.Text = "GridGridManageForm";
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.aSplitContainer2.Panel1.ResumeLayout(false);
            this.aSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer2)).EndInit();
            this.aSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.APanel aPanel1;
        private CustomControls.ASplitContainer aSplitContainer1;
        private CustomControls.ADataGridView aDataGridView1;
        private CustomControls.ASplitContainer aSplitContainer2;
        private CustomControls.ADataGridView aDataGridView2;
        private CustomControls.APanel aPanel2;
    }
}