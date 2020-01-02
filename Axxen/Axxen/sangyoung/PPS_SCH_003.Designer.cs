namespace Axxen.sangyoung
{
    partial class PPS_SCH_003
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.aDateTimePicker2 = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aDateTimePicker1 = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.aComboBox1 = new Axxen.CustomControls.AComboBox();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // aDateTimePicker2
            // 
            this.aDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker2.Location = new System.Drawing.Point(248, 22);
            this.aDateTimePicker2.Name = "aDateTimePicker2";
            this.aDateTimePicker2.Size = new System.Drawing.Size(119, 23);
            this.aDateTimePicker2.TabIndex = 10;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(227, 26);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(15, 15);
            this.aLabel2.TabIndex = 9;
            this.aLabel2.Text = "~";
            // 
            // aDateTimePicker1
            // 
            this.aDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker1.Location = new System.Drawing.Point(102, 21);
            this.aDateTimePicker1.Name = "aDateTimePicker1";
            this.aDateTimePicker1.Size = new System.Drawing.Size(119, 23);
            this.aDateTimePicker1.TabIndex = 8;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(13, 26);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 7;
            this.aLabel1.Text = "작업지시일자";
            // 
            // aPanel1
            // 
            this.aPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel1.Controls.Add(this.aComboBox1);
            this.aPanel1.Controls.Add(this.aLabel3);
            this.aPanel1.Controls.Add(this.aLabel1);
            this.aPanel1.Controls.Add(this.aDateTimePicker2);
            this.aPanel1.Controls.Add(this.aDateTimePicker1);
            this.aPanel1.Controls.Add(this.aLabel2);
            this.aPanel1.Location = new System.Drawing.Point(27, 22);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(956, 74);
            this.aPanel1.TabIndex = 11;
            // 
            // aComboBox1
            // 
            this.aComboBox1.FormattingEnabled = true;
            this.aComboBox1.Location = new System.Drawing.Point(850, 24);
            this.aComboBox1.Name = "aComboBox1";
            this.aComboBox1.Size = new System.Drawing.Size(101, 23);
            this.aComboBox1.TabIndex = 12;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Location = new System.Drawing.Point(767, 28);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(79, 15);
            this.aLabel3.TabIndex = 11;
            this.aLabel3.Text = "작업지시상태";
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(29, 112);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(950, 253);
            this.aDataGridView1.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(29, 371);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(583, 282);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(629, 371);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(349, 282);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // PPS_SCH_003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 665);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.aDataGridView1);
            this.Controls.Add(this.aPanel1);
            this.Name = "PPS_SCH_003";
            this.Text = "PPS_SCH_003";
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ADateTimePicker aDateTimePicker2;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ADateTimePicker aDateTimePicker1;
        private CustomControls.ALabel aLabel1;
        private CustomControls.APanel aPanel1;
        private CustomControls.ADataGridView aDataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private CustomControls.AComboBox aComboBox1;
        private CustomControls.ALabel aLabel3;
    }
}