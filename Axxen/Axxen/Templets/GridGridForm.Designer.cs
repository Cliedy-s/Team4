namespace Axxen
{
    partial class GridGridForm
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
            this.aHeaderBox1 = new Axxen.CustomControls.AHeaderBox();
            this.aDataGridView2 = new Axxen.CustomControls.ADataGridView();
            this.aHeaderBox2 = new Axxen.CustomControls.AHeaderBox();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel1.Location = new System.Drawing.Point(15, 20);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(1749, 99);
            this.aPanel1.TabIndex = 6;
            // 
            // aSplitContainer1
            // 
            this.aSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aSplitContainer1.Location = new System.Drawing.Point(15, 129);
            this.aSplitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aSplitContainer1.Name = "aSplitContainer1";
            this.aSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // aSplitContainer1.Panel1
            // 
            this.aSplitContainer1.Panel1.Controls.Add(this.aDataGridView1);
            this.aSplitContainer1.Panel1.Controls.Add(this.aHeaderBox1);
            // 
            // aSplitContainer1.Panel2
            // 
            this.aSplitContainer1.Panel2.Controls.Add(this.aDataGridView2);
            this.aSplitContainer1.Panel2.Controls.Add(this.aHeaderBox2);
            this.aSplitContainer1.Size = new System.Drawing.Size(1749, 732);
            this.aSplitContainer1.SplitterDistance = 354;
            this.aSplitContainer1.SplitterWidth = 1;
            this.aSplitContainer1.TabIndex = 7;
            this.aSplitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.aSplitContainer1_SplitterMoved);
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(0, 43);
            this.aDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(1749, 310);
            this.aDataGridView1.TabIndex = 6;
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox1.HeaderBoxText = "HeaderText";
            this.aHeaderBox1.Location = new System.Drawing.Point(1, 3);
            this.aHeaderBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aHeaderBox1.Name = "aHeaderBox1";
            this.aHeaderBox1.Size = new System.Drawing.Size(312, 40);
            this.aHeaderBox1.TabIndex = 7;
            // 
            // aDataGridView2
            // 
            this.aDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView2.Location = new System.Drawing.Point(0, 43);
            this.aDataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aDataGridView2.Name = "aDataGridView2";
            this.aDataGridView2.RowHeadersWidth = 51;
            this.aDataGridView2.RowTemplate.Height = 23;
            this.aDataGridView2.Size = new System.Drawing.Size(1749, 330);
            this.aDataGridView2.TabIndex = 7;
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox2.HeaderBoxText = "HeaderText";
            this.aHeaderBox2.Location = new System.Drawing.Point(1, 1);
            this.aHeaderBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aHeaderBox2.Name = "aHeaderBox2";
            this.aHeaderBox2.Size = new System.Drawing.Size(312, 40);
            this.aHeaderBox2.TabIndex = 9;
            // 
            // GridGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 881);
            this.Controls.Add(this.aSplitContainer1);
            this.Controls.Add(this.aPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "GridGridForm";
            this.Text = "GridGridForm";
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected CustomControls.APanel aPanel1;
        protected CustomControls.ASplitContainer aSplitContainer1;
        protected CustomControls.ADataGridView aDataGridView1;
        protected CustomControls.ADataGridView aDataGridView2;
        protected CustomControls.AHeaderBox aHeaderBox1;
        protected CustomControls.AHeaderBox aHeaderBox2;
    }
}