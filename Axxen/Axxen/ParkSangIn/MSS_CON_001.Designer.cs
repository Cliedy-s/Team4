namespace Axxen
{
    partial class MSS_CON_001
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
            this.cbbGroup = new Axxen.CustomControls.AComboBox();
            this.btnSearch = new Axxen.CustomControls.AButton();
            this.dgvGroup = new Axxen.CustomControls.ADataGridView();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.lblGroup = new Axxen.CustomControls.ALabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbGroup
            // 
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(16, 12);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(152, 23);
            this.cbbGroup.TabIndex = 3;
            this.cbbGroup.SelectedIndexChanged += new System.EventHandler(this.CbbGroup_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(345, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dgvGroup
            // 
            this.dgvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(12, 42);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.RowTemplate.Height = 23;
            this.dgvGroup.Size = new System.Drawing.Size(1124, 719);
            this.dgvGroup.TabIndex = 5;
            this.dgvGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGroup_CellClick);
            // 
            // aPanel1
            // 
            this.aPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aPanel1.Controls.Add(this.lblGroup);
            this.aPanel1.Location = new System.Drawing.Point(174, 12);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(165, 24);
            this.aPanel1.TabIndex = 6;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(3, 3);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(48, 15);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "aLabel1";
            // 
            // MSS_CON_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 765);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.dgvGroup);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MSS_CON_001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사용자그룹관리";
            this.Load += new System.EventHandler(this.MSS_CON_001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.AComboBox cbbGroup;
        private CustomControls.AButton btnSearch;
        private CustomControls.ADataGridView dgvGroup;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel lblGroup;
    }
}