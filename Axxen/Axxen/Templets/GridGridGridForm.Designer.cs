namespace Axxen
{
    partial class GridGridGridForm
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
            this.aSplitContainer1 = new Axxen.CustomControls.ASplitContainer();
            this.dgvMainGrid = new Axxen.CustomControls.ADataGridView();
            this.aHeaderBox1 = new Axxen.CustomControls.AHeaderBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aGroupBox1 = new Axxen.CustomControls.AGroupBox();
            this.dgvSubGrid = new Axxen.CustomControls.ADataGridView();
            this.aGroupBox2 = new Axxen.CustomControls.AGroupBox();
            this.dgvSubSubGrid = new Axxen.CustomControls.ADataGridView();
            this.aHeaderBox2 = new Axxen.CustomControls.AHeaderBox();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.aGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrid)).BeginInit();
            this.aGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubSubGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // aSplitContainer1
            // 
            this.aSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aSplitContainer1.Location = new System.Drawing.Point(12, 97);
            this.aSplitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aSplitContainer1.Name = "aSplitContainer1";
            // 
            // aSplitContainer1.Panel1
            // 
            this.aSplitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.aSplitContainer1.Panel1.Controls.Add(this.dgvMainGrid);
            this.aSplitContainer1.Panel1.Controls.Add(this.aHeaderBox1);
            // 
            // aSplitContainer1.Panel2
            // 
            this.aSplitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.aSplitContainer1.Panel2.Controls.Add(this.panel1);
            this.aSplitContainer1.Panel2.Controls.Add(this.aHeaderBox2);
            this.aSplitContainer1.Size = new System.Drawing.Size(1125, 588);
            this.aSplitContainer1.SplitterDistance = 261;
            this.aSplitContainer1.SplitterWidth = 1;
            this.aSplitContainer1.TabIndex = 9;
            // 
            // dgvMainGrid
            // 
            this.dgvMainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainGrid.Location = new System.Drawing.Point(0, 29);
            this.dgvMainGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMainGrid.Name = "dgvMainGrid";
            this.dgvMainGrid.RowHeadersWidth = 51;
            this.dgvMainGrid.RowTemplate.Height = 23;
            this.dgvMainGrid.Size = new System.Drawing.Size(259, 559);
            this.dgvMainGrid.TabIndex = 0;
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox1.HeaderBoxText = "HeaderText";
            this.aHeaderBox1.Location = new System.Drawing.Point(0, 0);
            this.aHeaderBox1.Name = "aHeaderBox1";
            this.aHeaderBox1.Size = new System.Drawing.Size(192, 30);
            this.aHeaderBox1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.aGroupBox1);
            this.panel1.Controls.Add(this.aGroupBox2);
            this.panel1.Location = new System.Drawing.Point(4, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 559);
            this.panel1.TabIndex = 13;
            // 
            // aGroupBox1
            // 
            this.aGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.aGroupBox1.BackColor = System.Drawing.Color.White;
            this.aGroupBox1.Controls.Add(this.dgvSubGrid);
            this.aGroupBox1.Location = new System.Drawing.Point(3, 4);
            this.aGroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aGroupBox1.Name = "aGroupBox1";
            this.aGroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aGroupBox1.Size = new System.Drawing.Size(200, 551);
            this.aGroupBox1.TabIndex = 2;
            this.aGroupBox1.TabStop = false;
            this.aGroupBox1.Text = "aGroupBox1";
            // 
            // dgvSubGrid
            // 
            this.dgvSubGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubGrid.Location = new System.Drawing.Point(3, 20);
            this.dgvSubGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSubGrid.Name = "dgvSubGrid";
            this.dgvSubGrid.RowHeadersWidth = 51;
            this.dgvSubGrid.RowTemplate.Height = 23;
            this.dgvSubGrid.Size = new System.Drawing.Size(194, 527);
            this.dgvSubGrid.TabIndex = 0;
            // 
            // aGroupBox2
            // 
            this.aGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aGroupBox2.BackColor = System.Drawing.Color.White;
            this.aGroupBox2.Controls.Add(this.dgvSubSubGrid);
            this.aGroupBox2.Location = new System.Drawing.Point(206, 4);
            this.aGroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aGroupBox2.Name = "aGroupBox2";
            this.aGroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aGroupBox2.Size = new System.Drawing.Size(648, 551);
            this.aGroupBox2.TabIndex = 3;
            this.aGroupBox2.TabStop = false;
            this.aGroupBox2.Text = "aGroupBox2";
            // 
            // dgvSubSubGrid
            // 
            this.dgvSubSubGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubSubGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubSubGrid.Location = new System.Drawing.Point(3, 60);
            this.dgvSubSubGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSubSubGrid.Name = "dgvSubSubGrid";
            this.dgvSubSubGrid.RowHeadersWidth = 51;
            this.dgvSubSubGrid.RowTemplate.Height = 23;
            this.dgvSubSubGrid.Size = new System.Drawing.Size(642, 487);
            this.dgvSubSubGrid.TabIndex = 0;
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox2.HeaderBoxText = "HeaderText";
            this.aHeaderBox2.Location = new System.Drawing.Point(4, 0);
            this.aHeaderBox2.Name = "aHeaderBox2";
            this.aHeaderBox2.Size = new System.Drawing.Size(192, 30);
            this.aHeaderBox2.TabIndex = 12;
            // 
            // aPanel2
            // 
            this.aPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aPanel2.Location = new System.Drawing.Point(12, 15);
            this.aPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(1124, 74);
            this.aPanel2.TabIndex = 10;
            // 
            // GridGridGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aSplitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "GridGridGridForm";
            this.Text = "GridGridGridForm";
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.aGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubGrid)).EndInit();
            this.aGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubSubGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected CustomControls.ASplitContainer aSplitContainer1;
        protected CustomControls.ADataGridView dgvMainGrid;
        protected CustomControls.AHeaderBox aHeaderBox1;
        protected CustomControls.AHeaderBox aHeaderBox2;
        private System.Windows.Forms.Panel panel1;
        protected CustomControls.AGroupBox aGroupBox1;
        protected CustomControls.ADataGridView dgvSubGrid;
        protected CustomControls.AGroupBox aGroupBox2;
        protected CustomControls.ADataGridView dgvSubSubGrid;
        protected CustomControls.APanel aPanel2;
    }
}