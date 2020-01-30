namespace Axxen
{
    partial class PPS_SCH_003
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.dotWorkCenter = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.cboStatus = new Axxen.CustomControls.AComboBox();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aHeaderBox1 = new Axxen.CustomControls.AHeaderBox();
            this.dgvMainGrid = new Axxen.CustomControls.ADataGridView();
            this.chartTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 5;
            this.aLabel1.Text = "작업지시일자";
            // 
            // aPanel1
            // 
            this.aPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aPanel1.Controls.Add(this.aDateTimePickerSearch1);
            this.aPanel1.Controls.Add(this.dotWorkCenter);
            this.aPanel1.Controls.Add(this.aTextBox_FindNameByCode1);
            this.aPanel1.Controls.Add(this.cboStatus);
            this.aPanel1.Controls.Add(this.aLabel3);
            this.aPanel1.Controls.Add(this.aLabel1);
            this.aPanel1.Location = new System.Drawing.Point(12, 15);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(1124, 74);
            this.aPanel1.TabIndex = 9;
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 1, 23, 14, 52, 18, 980);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 1, 30, 14, 52, 18, 980);
            this.aDateTimePickerSearch1.ButtonText = "조회";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(105, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch1.TabIndex = 14;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.ADateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // dotWorkCenter
            // 
            this.dotWorkCenter.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotWorkCenter.CodeType = Axxen.CustomControls.DataType.WorkCenters;
            this.dotWorkCenter.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotWorkCenter.lblNameText = "작업장";
            this.dotWorkCenter.Location = new System.Drawing.Point(696, 26);
            this.dotWorkCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dotWorkCenter.Name = "dotWorkCenter";
            this.dotWorkCenter.Size = new System.Drawing.Size(229, 27);
            this.dotWorkCenter.TabIndex = 13;
            this.dotWorkCenter.txtCodeText = "";
            this.dotWorkCenter.txtNameText = "";
            this.dotWorkCenter.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.DotWorkCenter_DotDotDotFormClosing);
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(456, 26);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(221, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 12;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(1021, 28);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(85, 23);
            this.cboStatus.TabIndex = 10;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.CboStatus_SelectedIndexChanged);
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Location = new System.Drawing.Point(940, 32);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(79, 15);
            this.aLabel3.TabIndex = 9;
            this.aLabel3.Text = "작업지시상태";
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aHeaderBox1.HeaderBoxText = "작업지시목록";
            this.aHeaderBox1.Location = new System.Drawing.Point(12, 97);
            this.aHeaderBox1.Name = "aHeaderBox1";
            this.aHeaderBox1.Size = new System.Drawing.Size(243, 30);
            this.aHeaderBox1.TabIndex = 11;
            // 
            // dgvMainGrid
            // 
            this.dgvMainGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainGrid.Location = new System.Drawing.Point(12, 126);
            this.dgvMainGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMainGrid.Name = "dgvMainGrid";
            this.dgvMainGrid.RowTemplate.Height = 23;
            this.dgvMainGrid.Size = new System.Drawing.Size(1124, 260);
            this.dgvMainGrid.TabIndex = 10;
            // 
            // chartTime
            // 
            this.chartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chartTime.BackColor = System.Drawing.Color.Gainsboro;
            chartArea3.Name = "ChartArea1";
            this.chartTime.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTime.Legends.Add(legend3);
            this.chartTime.Location = new System.Drawing.Point(12, 393);
            this.chartTime.Name = "chartTime";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTime.Series.Add(series3);
            this.chartTime.Size = new System.Drawing.Size(689, 295);
            this.chartTime.TabIndex = 12;
            this.chartTime.Text = "chart1";
            // 
            // chartDate
            // 
            this.chartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDate.BackColor = System.Drawing.Color.LightGray;
            chartArea4.Name = "ChartArea1";
            this.chartDate.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDate.Legends.Add(legend4);
            this.chartDate.Location = new System.Drawing.Point(735, 393);
            this.chartDate.Name = "chartDate";
            this.chartDate.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDate.Series.Add(series4);
            this.chartDate.Size = new System.Drawing.Size(400, 295);
            this.chartDate.TabIndex = 13;
            this.chartDate.Text = "chart2";
            // 
            // PPS_SCH_003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Controls.Add(this.chartDate);
            this.Controls.Add(this.chartTime);
            this.Controls.Add(this.aHeaderBox1);
            this.Controls.Add(this.dgvMainGrid);
            this.Controls.Add(this.aPanel1);
            this.Name = "PPS_SCH_003";
            this.Activated += new System.EventHandler(this.PPS_SCH_003_Activated);
            this.Deactivate += new System.EventHandler(this.PPS_SCH_003_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPS_SCH_003_FormClosed);
            this.Load += new System.EventHandler(this.PPS_SCH_003_Load);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.ALabel aLabel1;
        protected CustomControls.APanel aPanel1;
        protected CustomControls.AHeaderBox aHeaderBox1;
        protected CustomControls.ADataGridView dgvMainGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDate;
        private CustomControls.AComboBox cboStatus;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ATextBox_FindNameByCode dotWorkCenter;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
    }
}
