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
            this.aHeaderBox1 = new Axxen.CustomControls.AHeaderBox();
            this.aSplitContainer2 = new Axxen.CustomControls.ASplitContainer();
            this.aDataGridView2 = new Axxen.CustomControls.ADataGridView();
            this.aHeaderBox2 = new Axxen.CustomControls.AHeaderBox();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.aHeaderBox3 = new Axxen.CustomControls.AHeaderBox();
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
            this.aPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel1.Location = new System.Drawing.Point(15, 20);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(1495, 99);
            this.aPanel1.TabIndex = 3;
            // 
            // aSplitContainer1
            // 
            this.aSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aSplitContainer1.Location = new System.Drawing.Point(15, 129);
            this.aSplitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aSplitContainer1.Name = "aSplitContainer1";
            // 
            // aSplitContainer1.Panel1
            // 
            this.aSplitContainer1.Panel1.Controls.Add(this.aDataGridView1);
            this.aSplitContainer1.Panel1.Controls.Add(this.aHeaderBox1);
            // 
            // aSplitContainer1.Panel2
            // 
            this.aSplitContainer1.Panel2.Controls.Add(this.aSplitContainer2);
            this.aSplitContainer1.Size = new System.Drawing.Size(1495, 659);
            this.aSplitContainer1.SplitterDistance = 400;
            this.aSplitContainer1.SplitterWidth = 1;
            this.aSplitContainer1.TabIndex = 4;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(0, 40);
            this.aDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(399, 619);
            this.aDataGridView1.TabIndex = 7;
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox1.HeaderBoxText = "HeaderText";
            this.aHeaderBox1.Location = new System.Drawing.Point(1, 1);
            this.aHeaderBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aHeaderBox1.Name = "aHeaderBox1";
            this.aHeaderBox1.Size = new System.Drawing.Size(312, 40);
            this.aHeaderBox1.TabIndex = 8;
            // 
            // aSplitContainer2
            // 
            this.aSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.aSplitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aSplitContainer2.Name = "aSplitContainer2";
            this.aSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // aSplitContainer2.Panel1
            // 
            this.aSplitContainer2.Panel1.Controls.Add(this.aDataGridView2);
            this.aSplitContainer2.Panel1.Controls.Add(this.aHeaderBox2);
            // 
            // aSplitContainer2.Panel2
            // 
            this.aSplitContainer2.Panel2.Controls.Add(this.aPanel2);
            this.aSplitContainer2.Size = new System.Drawing.Size(1094, 659);
            this.aSplitContainer2.SplitterDistance = 556;
            this.aSplitContainer2.SplitterWidth = 1;
            this.aSplitContainer2.TabIndex = 0;
            // 
            // aDataGridView2
            // 
            this.aDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView2.Location = new System.Drawing.Point(0, 40);
            this.aDataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aDataGridView2.Name = "aDataGridView2";
            this.aDataGridView2.RowHeadersWidth = 51;
            this.aDataGridView2.RowTemplate.Height = 23;
            this.aDataGridView2.Size = new System.Drawing.Size(1094, 515);
            this.aDataGridView2.TabIndex = 7;
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox2.HeaderBoxText = "HeaderText";
            this.aHeaderBox2.Location = new System.Drawing.Point(3, 0);
            this.aHeaderBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aHeaderBox2.Name = "aHeaderBox2";
            this.aHeaderBox2.Size = new System.Drawing.Size(312, 40);
            this.aHeaderBox2.TabIndex = 9;
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.aHeaderBox3);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aPanel2.Location = new System.Drawing.Point(0, 0);
            this.aPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1094, 102);
            this.aPanel2.TabIndex = 8;
            // 
            // aHeaderBox3
            // 
            this.aHeaderBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aHeaderBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox3.HeaderBoxText = "HeaderText";
            this.aHeaderBox3.Location = new System.Drawing.Point(0, 1);
            this.aHeaderBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aHeaderBox3.Name = "aHeaderBox3";
            this.aHeaderBox3.Size = new System.Drawing.Size(312, 40);
            this.aHeaderBox3.TabIndex = 10;
            // 
            // GridGridManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 806);
            this.Controls.Add(this.aSplitContainer1);
            this.Controls.Add(this.aPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
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
            this.aPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected CustomControls.APanel aPanel1;
        protected CustomControls.ASplitContainer aSplitContainer1;
        protected CustomControls.ADataGridView aDataGridView1;
        protected CustomControls.ASplitContainer aSplitContainer2;
        protected CustomControls.ADataGridView aDataGridView2;
        protected CustomControls.APanel aPanel2;
        protected CustomControls.AHeaderBox aHeaderBox3;
        protected CustomControls.AHeaderBox aHeaderBox1;
        protected CustomControls.AHeaderBox aHeaderBox2;
    }
}