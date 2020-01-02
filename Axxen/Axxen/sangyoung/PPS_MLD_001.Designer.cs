namespace Axxen.sangyoung
{
    partial class PPS_MLD_001
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
            this.aTextBox_Labeled1 = new Axxen.CustomControls.ATextBox_Labeled();
            this.aTextBox_Labeled2 = new Axxen.CustomControls.ATextBox_Labeled();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aComboBox1 = new Axxen.CustomControls.AComboBox();
            this.aPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.aComboBox1);
            this.aPanel1.Controls.Add(this.aLabel1);
            this.aPanel1.Controls.Add(this.aTextBox_Labeled2);
            this.aPanel1.Controls.Add(this.aTextBox_Labeled1);
            // 
            // aTextBox_Labeled1
            // 
            this.aTextBox_Labeled1.FontSize = 9F;
            this.aTextBox_Labeled1.LabelText = "금형코드";
            this.aTextBox_Labeled1.Location = new System.Drawing.Point(35, 27);
            this.aTextBox_Labeled1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_Labeled1.Name = "aTextBox_Labeled1";
            this.aTextBox_Labeled1.Size = new System.Drawing.Size(210, 23);
            this.aTextBox_Labeled1.SplitDistance = 69;
            this.aTextBox_Labeled1.TabIndex = 0;
            this.aTextBox_Labeled1.TextBoxText = "";
            // 
            // aTextBox_Labeled2
            // 
            this.aTextBox_Labeled2.FontSize = 9F;
            this.aTextBox_Labeled2.LabelText = "금형명";
            this.aTextBox_Labeled2.Location = new System.Drawing.Point(261, 27);
            this.aTextBox_Labeled2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.aTextBox_Labeled2.Name = "aTextBox_Labeled2";
            this.aTextBox_Labeled2.Size = new System.Drawing.Size(210, 23);
            this.aTextBox_Labeled2.SplitDistance = 69;
            this.aTextBox_Labeled2.TabIndex = 1;
            this.aTextBox_Labeled2.TextBoxText = "";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(561, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(55, 15);
            this.aLabel1.TabIndex = 2;
            this.aLabel1.Text = "금형그룹";
            // 
            // aComboBox1
            // 
            this.aComboBox1.FormattingEnabled = true;
            this.aComboBox1.Location = new System.Drawing.Point(634, 29);
            this.aComboBox1.Name = "aComboBox1";
            this.aComboBox1.Size = new System.Drawing.Size(109, 23);
            this.aComboBox1.TabIndex = 3;
            // 
            // PPS_MLD_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "PPS_MLD_001";
            this.Text = "PPS_MLD_001";
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ATextBox_Labeled aTextBox_Labeled1;
        private CustomControls.AComboBox aComboBox1;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_Labeled aTextBox_Labeled2;
    }
}