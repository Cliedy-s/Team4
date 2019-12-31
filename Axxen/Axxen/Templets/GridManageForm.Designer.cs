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
            this.aHeaderBox2 = new Axxen.CustomControls.AHeaderBox();
            this.aHeaderBox1 = new Axxen.CustomControls.AHeaderBox();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel2
            // 
            this.aPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel2.Location = new System.Drawing.Point(12, 15);
            this.aPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(776, 74);
            this.aPanel2.TabIndex = 4;
            // 
            // aSplitContainer1
            // 
            this.aSplitContainer1.Location = new System.Drawing.Point(12, 129);
            this.aSplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.aSplitContainer1.Size = new System.Drawing.Size(776, 418);
            this.aSplitContainer1.SplitterDistance = 335;
            this.aSplitContainer1.SplitterWidth = 1;
            this.aSplitContainer1.TabIndex = 5;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.aDataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(776, 362);
            this.aDataGridView1.TabIndex = 6;
            // 
            // aPanel1
            // 
            this.aPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel1.Controls.Add(this.aHeaderBox2);
            this.aPanel1.Location = new System.Drawing.Point(0, 3);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(776, 84);
            this.aPanel1.TabIndex = 7;
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox2.HeaderBoxText = "HeaderText";
            this.aHeaderBox2.Location = new System.Drawing.Point(1, 1);
            this.aHeaderBox2.Name = "aHeaderBox2";
            this.aHeaderBox2.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox2.TabIndex = 10;
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox1.HeaderBoxText = "HeaderText";
            this.aHeaderBox1.Location = new System.Drawing.Point(13, 100);
            this.aHeaderBox1.Name = "aHeaderBox1";
            this.aHeaderBox1.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox1.TabIndex = 9;
            // 
            // GridManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aSplitContainer1);
            this.Controls.Add(this.aHeaderBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "GridManageForm";
            this.Text = "GrieManageForm";
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected CustomControls.APanel aPanel2;
        protected CustomControls.ASplitContainer aSplitContainer1;
        protected CustomControls.ADataGridView aDataGridView1;
        protected CustomControls.APanel aPanel1;
        protected CustomControls.AHeaderBox aHeaderBox1;
        protected CustomControls.AHeaderBox aHeaderBox2;
    }
}