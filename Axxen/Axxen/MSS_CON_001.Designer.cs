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
            this.dgvUserGroup = new Axxen.CustomControls.ADataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserGroup
            // 
            this.dgvUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserGroup.Location = new System.Drawing.Point(12, 46);
            this.dgvUserGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUserGroup.Name = "dgvUserGroup";
            this.dgvUserGroup.RowTemplate.Height = 23;
            this.dgvUserGroup.Size = new System.Drawing.Size(1117, 706);
            this.dgvUserGroup.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 15);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 2;
            // 
            // MSS_CON_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 765);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvUserGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MSS_CON_001";
            this.Text = "MSS_CON_001";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ADataGridView dgvUserGroup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}