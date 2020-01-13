namespace AxxenClient.Forms
{
    partial class WorkOrderForm
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
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.panMolding = new Axxen.CustomControls.APanel();
            this.btnWorkOrderOnOff3 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderQuit3 = new Axxen.CustomControls.AButton();
            this.btnDryGVLoad = new Axxen.CustomControls.AButton();
            this.btnSetWorker3 = new Axxen.CustomControls.AButton();
            this.btnSetMold = new Axxen.CustomControls.AButton();
            this.btnSetPressCondition2 = new Axxen.CustomControls.AButton();
            this.btnQualityMeasure3 = new Axxen.CustomControls.AButton();
            this.panLoad = new Axxen.CustomControls.APanel();
            this.btnWorkOrderOnOff2 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderQuit2 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderCreate2 = new Axxen.CustomControls.AButton();
            this.btnSetWorker2 = new Axxen.CustomControls.AButton();
            this.btnLoadRecordRegister = new Axxen.CustomControls.AButton();
            this.btnFiringInOut = new Axxen.CustomControls.AButton();
            this.btnClearDryGV = new Axxen.CustomControls.AButton();
            this.btnSetPressCondition1 = new Axxen.CustomControls.AButton();
            this.btnQualityMeasure2 = new Axxen.CustomControls.AButton();
            this.aPanel6 = new Axxen.CustomControls.APanel();
            this.aButton17 = new Axxen.CustomControls.AButton();
            this.aButton18 = new Axxen.CustomControls.AButton();
            this.aButton19 = new Axxen.CustomControls.AButton();
            this.aButton20 = new Axxen.CustomControls.AButton();
            this.aButton21 = new Axxen.CustomControls.AButton();
            this.aButton22 = new Axxen.CustomControls.AButton();
            this.aButton23 = new Axxen.CustomControls.AButton();
            this.aButton24 = new Axxen.CustomControls.AButton();
            this.aButton25 = new Axxen.CustomControls.AButton();
            this.panBoxing = new Axxen.CustomControls.APanel();
            this.btnWorkOrderOnOff1 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderQuit1 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderCreate1 = new Axxen.CustomControls.AButton();
            this.btnSetWorker1 = new Axxen.CustomControls.AButton();
            this.btnCreatePallet = new Axxen.CustomControls.AButton();
            this.btnBarcordeRecreate = new Axxen.CustomControls.AButton();
            this.btnWarehousing = new Axxen.CustomControls.AButton();
            this.btnUnload = new Axxen.CustomControls.AButton();
            this.btnQualityMeasure1 = new Axxen.CustomControls.AButton();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.panMolding.SuspendLayout();
            this.panLoad.SuspendLayout();
            this.aPanel6.SuspendLayout();
            this.panBoxing.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "작업지시 현황";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 735);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(5);
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(15, 140);
            this.aDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(1525, 413);
            this.aDataGridView1.TabIndex = 4;
            // 
            // panMolding
            // 
            this.panMolding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMolding.Controls.Add(this.btnWorkOrderOnOff3);
            this.panMolding.Controls.Add(this.btnWorkOrderQuit3);
            this.panMolding.Controls.Add(this.btnDryGVLoad);
            this.panMolding.Controls.Add(this.btnSetWorker3);
            this.panMolding.Controls.Add(this.btnSetMold);
            this.panMolding.Controls.Add(this.btnSetPressCondition2);
            this.panMolding.Controls.Add(this.btnQualityMeasure3);
            this.panMolding.Location = new System.Drawing.Point(15, 140);
            this.panMolding.Margin = new System.Windows.Forms.Padding(4);
            this.panMolding.Name = "panMolding";
            this.panMolding.Size = new System.Drawing.Size(1525, 165);
            this.panMolding.TabIndex = 5;
            // 
            // btnWorkOrderOnOff3
            // 
            this.btnWorkOrderOnOff3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderOnOff3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderOnOff3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderOnOff3.Location = new System.Drawing.Point(85, 8);
            this.btnWorkOrderOnOff3.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkOrderOnOff3.Name = "btnWorkOrderOnOff3";
            this.btnWorkOrderOnOff3.Size = new System.Drawing.Size(186, 157);
            this.btnWorkOrderOnOff3.TabIndex = 6;
            this.btnWorkOrderOnOff3.Text = "작업시작/종료";
            this.btnWorkOrderOnOff3.UseVisualStyleBackColor = false;
            // 
            // btnWorkOrderQuit3
            // 
            this.btnWorkOrderQuit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderQuit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderQuit3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderQuit3.Location = new System.Drawing.Point(280, 8);
            this.btnWorkOrderQuit3.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkOrderQuit3.Name = "btnWorkOrderQuit3";
            this.btnWorkOrderQuit3.Size = new System.Drawing.Size(186, 157);
            this.btnWorkOrderQuit3.TabIndex = 5;
            this.btnWorkOrderQuit3.Text = "현장마감";
            this.btnWorkOrderQuit3.UseVisualStyleBackColor = false;
            // 
            // btnDryGVLoad
            // 
            this.btnDryGVLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnDryGVLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDryGVLoad.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDryGVLoad.Location = new System.Drawing.Point(476, 8);
            this.btnDryGVLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnDryGVLoad.Name = "btnDryGVLoad";
            this.btnDryGVLoad.Size = new System.Drawing.Size(186, 157);
            this.btnDryGVLoad.TabIndex = 4;
            this.btnDryGVLoad.Text = "건조 대차 로딩";
            this.btnDryGVLoad.UseVisualStyleBackColor = false;
            this.btnDryGVLoad.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetWorker3
            // 
            this.btnSetWorker3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetWorker3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetWorker3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetWorker3.Location = new System.Drawing.Point(671, 8);
            this.btnSetWorker3.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetWorker3.Name = "btnSetWorker3";
            this.btnSetWorker3.Size = new System.Drawing.Size(186, 157);
            this.btnSetWorker3.TabIndex = 3;
            this.btnSetWorker3.Text = "작업자\r\n할당";
            this.btnSetWorker3.UseVisualStyleBackColor = false;
            this.btnSetWorker3.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetMold
            // 
            this.btnSetMold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetMold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMold.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetMold.Location = new System.Drawing.Point(867, 8);
            this.btnSetMold.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetMold.Name = "btnSetMold";
            this.btnSetMold.Size = new System.Drawing.Size(186, 157);
            this.btnSetMold.TabIndex = 2;
            this.btnSetMold.Text = "금형 장착\r\n/탈착";
            this.btnSetMold.UseVisualStyleBackColor = false;
            this.btnSetMold.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetPressCondition2
            // 
            this.btnSetPressCondition2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetPressCondition2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPressCondition2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetPressCondition2.Location = new System.Drawing.Point(1062, 8);
            this.btnSetPressCondition2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPressCondition2.Name = "btnSetPressCondition2";
            this.btnSetPressCondition2.Size = new System.Drawing.Size(186, 157);
            this.btnSetPressCondition2.TabIndex = 1;
            this.btnSetPressCondition2.Text = "공정조건 등록";
            this.btnSetPressCondition2.UseVisualStyleBackColor = false;
            this.btnSetPressCondition2.Click += new System.EventHandler(this.btnClick);
            // 
            // btnQualityMeasure3
            // 
            this.btnQualityMeasure3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnQualityMeasure3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityMeasure3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQualityMeasure3.Location = new System.Drawing.Point(1257, 8);
            this.btnQualityMeasure3.Margin = new System.Windows.Forms.Padding(4);
            this.btnQualityMeasure3.Name = "btnQualityMeasure3";
            this.btnQualityMeasure3.Size = new System.Drawing.Size(186, 157);
            this.btnQualityMeasure3.TabIndex = 0;
            this.btnQualityMeasure3.Text = "품질\r\n측정값\r\n등록";
            this.btnQualityMeasure3.UseVisualStyleBackColor = false;
            this.btnQualityMeasure3.Click += new System.EventHandler(this.btnClick);
            // 
            // panLoad
            // 
            this.panLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLoad.Controls.Add(this.btnWorkOrderOnOff2);
            this.panLoad.Controls.Add(this.btnWorkOrderQuit2);
            this.panLoad.Controls.Add(this.btnWorkOrderCreate2);
            this.panLoad.Controls.Add(this.btnSetWorker2);
            this.panLoad.Controls.Add(this.btnLoadRecordRegister);
            this.panLoad.Controls.Add(this.btnFiringInOut);
            this.panLoad.Controls.Add(this.btnClearDryGV);
            this.panLoad.Controls.Add(this.btnSetPressCondition1);
            this.panLoad.Controls.Add(this.btnQualityMeasure2);
            this.panLoad.Location = new System.Drawing.Point(13, 561);
            this.panLoad.Margin = new System.Windows.Forms.Padding(4);
            this.panLoad.Name = "panLoad";
            this.panLoad.Size = new System.Drawing.Size(1525, 165);
            this.panLoad.TabIndex = 6;
            // 
            // btnWorkOrderOnOff2
            // 
            this.btnWorkOrderOnOff2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderOnOff2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderOnOff2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderOnOff2.Location = new System.Drawing.Point(4, 4);
            this.btnWorkOrderOnOff2.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkOrderOnOff2.Name = "btnWorkOrderOnOff2";
            this.btnWorkOrderOnOff2.Size = new System.Drawing.Size(162, 157);
            this.btnWorkOrderOnOff2.TabIndex = 15;
            this.btnWorkOrderOnOff2.Text = "작업시작/종료";
            this.btnWorkOrderOnOff2.UseVisualStyleBackColor = false;
            // 
            // btnWorkOrderQuit2
            // 
            this.btnWorkOrderQuit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderQuit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderQuit2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderQuit2.Location = new System.Drawing.Point(172, 4);
            this.btnWorkOrderQuit2.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkOrderQuit2.Name = "btnWorkOrderQuit2";
            this.btnWorkOrderQuit2.Size = new System.Drawing.Size(162, 157);
            this.btnWorkOrderQuit2.TabIndex = 14;
            this.btnWorkOrderQuit2.Text = "현장마감";
            this.btnWorkOrderQuit2.UseVisualStyleBackColor = false;
            // 
            // btnWorkOrderCreate2
            // 
            this.btnWorkOrderCreate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderCreate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderCreate2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderCreate2.Location = new System.Drawing.Point(341, 4);
            this.btnWorkOrderCreate2.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkOrderCreate2.Name = "btnWorkOrderCreate2";
            this.btnWorkOrderCreate2.Size = new System.Drawing.Size(162, 157);
            this.btnWorkOrderCreate2.TabIndex = 13;
            this.btnWorkOrderCreate2.Text = "작업지시 생성";
            this.btnWorkOrderCreate2.UseVisualStyleBackColor = false;
            this.btnWorkOrderCreate2.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetWorker2
            // 
            this.btnSetWorker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetWorker2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetWorker2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetWorker2.Location = new System.Drawing.Point(509, 4);
            this.btnSetWorker2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetWorker2.Name = "btnSetWorker2";
            this.btnSetWorker2.Size = new System.Drawing.Size(162, 157);
            this.btnSetWorker2.TabIndex = 12;
            this.btnSetWorker2.Text = "작업자\r\n할당";
            this.btnSetWorker2.UseVisualStyleBackColor = false;
            this.btnSetWorker2.Click += new System.EventHandler(this.btnClick);
            // 
            // btnLoadRecordRegister
            // 
            this.btnLoadRecordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnLoadRecordRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRecordRegister.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoadRecordRegister.Location = new System.Drawing.Point(678, 4);
            this.btnLoadRecordRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadRecordRegister.Name = "btnLoadRecordRegister";
            this.btnLoadRecordRegister.Size = new System.Drawing.Size(162, 157);
            this.btnLoadRecordRegister.TabIndex = 11;
            this.btnLoadRecordRegister.Text = "적재\r\n실적\r\n등록";
            this.btnLoadRecordRegister.UseVisualStyleBackColor = false;
            this.btnLoadRecordRegister.Click += new System.EventHandler(this.btnClick);
            // 
            // btnFiringInOut
            // 
            this.btnFiringInOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnFiringInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiringInOut.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFiringInOut.Location = new System.Drawing.Point(846, 4);
            this.btnFiringInOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiringInOut.Name = "btnFiringInOut";
            this.btnFiringInOut.Size = new System.Drawing.Size(162, 157);
            this.btnFiringInOut.TabIndex = 10;
            this.btnFiringInOut.Text = "요입\r\n/요출";
            this.btnFiringInOut.UseVisualStyleBackColor = false;
            this.btnFiringInOut.Click += new System.EventHandler(this.btnClick);
            // 
            // btnClearDryGV
            // 
            this.btnClearDryGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnClearDryGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDryGV.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClearDryGV.Location = new System.Drawing.Point(1014, 4);
            this.btnClearDryGV.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDryGV.Name = "btnClearDryGV";
            this.btnClearDryGV.Size = new System.Drawing.Size(162, 157);
            this.btnClearDryGV.TabIndex = 9;
            this.btnClearDryGV.Text = "건조대차 비우기";
            this.btnClearDryGV.UseVisualStyleBackColor = false;
            this.btnClearDryGV.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetPressCondition1
            // 
            this.btnSetPressCondition1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetPressCondition1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPressCondition1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetPressCondition1.Location = new System.Drawing.Point(1183, 4);
            this.btnSetPressCondition1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPressCondition1.Name = "btnSetPressCondition1";
            this.btnSetPressCondition1.Size = new System.Drawing.Size(162, 157);
            this.btnSetPressCondition1.TabIndex = 8;
            this.btnSetPressCondition1.Text = "공정조건 등록";
            this.btnSetPressCondition1.UseVisualStyleBackColor = false;
            this.btnSetPressCondition1.Click += new System.EventHandler(this.btnClick);
            // 
            // btnQualityMeasure2
            // 
            this.btnQualityMeasure2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnQualityMeasure2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityMeasure2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQualityMeasure2.Location = new System.Drawing.Point(1351, 4);
            this.btnQualityMeasure2.Margin = new System.Windows.Forms.Padding(4);
            this.btnQualityMeasure2.Name = "btnQualityMeasure2";
            this.btnQualityMeasure2.Size = new System.Drawing.Size(162, 157);
            this.btnQualityMeasure2.TabIndex = 7;
            this.btnQualityMeasure2.Text = "품질\r\n측정값\r\n등록";
            this.btnQualityMeasure2.UseVisualStyleBackColor = false;
            this.btnQualityMeasure2.Click += new System.EventHandler(this.btnClick);
            // 
            // aPanel6
            // 
            this.aPanel6.Controls.Add(this.aButton17);
            this.aPanel6.Controls.Add(this.aButton18);
            this.aPanel6.Controls.Add(this.aButton19);
            this.aPanel6.Controls.Add(this.aButton20);
            this.aPanel6.Controls.Add(this.aButton21);
            this.aPanel6.Controls.Add(this.aButton22);
            this.aPanel6.Controls.Add(this.aButton23);
            this.aPanel6.Controls.Add(this.aButton24);
            this.aPanel6.Controls.Add(this.aButton25);
            this.aPanel6.Location = new System.Drawing.Point(17, 1137);
            this.aPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.aPanel6.Name = "aPanel6";
            this.aPanel6.Size = new System.Drawing.Size(1525, 165);
            this.aPanel6.TabIndex = 7;
            // 
            // aButton17
            // 
            this.aButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton17.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton17.Location = new System.Drawing.Point(8, 4);
            this.aButton17.Margin = new System.Windows.Forms.Padding(4);
            this.aButton17.Name = "aButton17";
            this.aButton17.Size = new System.Drawing.Size(162, 157);
            this.aButton17.TabIndex = 24;
            this.aButton17.Text = "작업시작/종료";
            this.aButton17.UseVisualStyleBackColor = false;
            // 
            // aButton18
            // 
            this.aButton18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton18.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton18.Location = new System.Drawing.Point(176, 4);
            this.aButton18.Margin = new System.Windows.Forms.Padding(4);
            this.aButton18.Name = "aButton18";
            this.aButton18.Size = new System.Drawing.Size(162, 157);
            this.aButton18.TabIndex = 23;
            this.aButton18.Text = "현장마감";
            this.aButton18.UseVisualStyleBackColor = false;
            // 
            // aButton19
            // 
            this.aButton19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton19.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton19.Location = new System.Drawing.Point(345, 4);
            this.aButton19.Margin = new System.Windows.Forms.Padding(4);
            this.aButton19.Name = "aButton19";
            this.aButton19.Size = new System.Drawing.Size(162, 157);
            this.aButton19.TabIndex = 22;
            this.aButton19.Text = "작업지시 생성";
            this.aButton19.UseVisualStyleBackColor = false;
            // 
            // aButton20
            // 
            this.aButton20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton20.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton20.Location = new System.Drawing.Point(513, 4);
            this.aButton20.Margin = new System.Windows.Forms.Padding(4);
            this.aButton20.Name = "aButton20";
            this.aButton20.Size = new System.Drawing.Size(162, 157);
            this.aButton20.TabIndex = 21;
            this.aButton20.Text = "작업자 할당";
            this.aButton20.UseVisualStyleBackColor = false;
            // 
            // aButton21
            // 
            this.aButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton21.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton21.Location = new System.Drawing.Point(681, 4);
            this.aButton21.Margin = new System.Windows.Forms.Padding(4);
            this.aButton21.Name = "aButton21";
            this.aButton21.Size = new System.Drawing.Size(162, 157);
            this.aButton21.TabIndex = 20;
            this.aButton21.Text = "팔레트 생성";
            this.aButton21.UseVisualStyleBackColor = false;
            // 
            // aButton22
            // 
            this.aButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton22.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton22.Location = new System.Drawing.Point(850, 4);
            this.aButton22.Margin = new System.Windows.Forms.Padding(4);
            this.aButton22.Name = "aButton22";
            this.aButton22.Size = new System.Drawing.Size(162, 157);
            this.aButton22.TabIndex = 19;
            this.aButton22.Text = "팔레트 바코드 재발행";
            this.aButton22.UseVisualStyleBackColor = false;
            // 
            // aButton23
            // 
            this.aButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton23.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton23.Location = new System.Drawing.Point(1018, 4);
            this.aButton23.Margin = new System.Windows.Forms.Padding(4);
            this.aButton23.Name = "aButton23";
            this.aButton23.Size = new System.Drawing.Size(162, 157);
            this.aButton23.TabIndex = 18;
            this.aButton23.Text = "입고\r\n등록";
            this.aButton23.UseVisualStyleBackColor = false;
            // 
            // aButton24
            // 
            this.aButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton24.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton24.Location = new System.Drawing.Point(1187, 4);
            this.aButton24.Margin = new System.Windows.Forms.Padding(4);
            this.aButton24.Name = "aButton24";
            this.aButton24.Size = new System.Drawing.Size(162, 157);
            this.aButton24.TabIndex = 17;
            this.aButton24.Text = "언로딩";
            this.aButton24.UseVisualStyleBackColor = false;
            // 
            // aButton25
            // 
            this.aButton25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton25.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton25.Location = new System.Drawing.Point(1355, 4);
            this.aButton25.Margin = new System.Windows.Forms.Padding(4);
            this.aButton25.Name = "aButton25";
            this.aButton25.Size = new System.Drawing.Size(162, 157);
            this.aButton25.TabIndex = 16;
            this.aButton25.Text = "품질\r\n측정값\r\n등록";
            this.aButton25.UseVisualStyleBackColor = false;
            // 
            // panBoxing
            // 
            this.panBoxing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panBoxing.Controls.Add(this.btnWorkOrderOnOff1);
            this.panBoxing.Controls.Add(this.btnWorkOrderQuit1);
            this.panBoxing.Controls.Add(this.btnWorkOrderCreate1);
            this.panBoxing.Controls.Add(this.btnSetWorker1);
            this.panBoxing.Controls.Add(this.btnCreatePallet);
            this.panBoxing.Controls.Add(this.btnBarcordeRecreate);
            this.panBoxing.Controls.Add(this.btnWarehousing);
            this.panBoxing.Controls.Add(this.btnUnload);
            this.panBoxing.Controls.Add(this.btnQualityMeasure1);
            this.panBoxing.Location = new System.Drawing.Point(9, 270);
            this.panBoxing.Margin = new System.Windows.Forms.Padding(4);
            this.panBoxing.Name = "panBoxing";
            this.panBoxing.Size = new System.Drawing.Size(1525, 165);
            this.panBoxing.TabIndex = 16;
            // 
            // btnWorkOrderOnOff1
            // 
            this.btnWorkOrderOnOff1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderOnOff1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderOnOff1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderOnOff1.Location = new System.Drawing.Point(4, 4);
            this.btnWorkOrderOnOff1.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkOrderOnOff1.Name = "btnWorkOrderOnOff1";
            this.btnWorkOrderOnOff1.Size = new System.Drawing.Size(162, 157);
            this.btnWorkOrderOnOff1.TabIndex = 15;
            this.btnWorkOrderOnOff1.Text = "작업시작/종료";
            this.btnWorkOrderOnOff1.UseVisualStyleBackColor = false;
            // 
            // btnWorkOrderQuit1
            // 
            this.btnWorkOrderQuit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderQuit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderQuit1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderQuit1.Location = new System.Drawing.Point(172, 4);
            this.btnWorkOrderQuit1.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkOrderQuit1.Name = "btnWorkOrderQuit1";
            this.btnWorkOrderQuit1.Size = new System.Drawing.Size(162, 157);
            this.btnWorkOrderQuit1.TabIndex = 14;
            this.btnWorkOrderQuit1.Text = "현장마감";
            this.btnWorkOrderQuit1.UseVisualStyleBackColor = false;
            // 
            // btnWorkOrderCreate1
            // 
            this.btnWorkOrderCreate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderCreate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderCreate1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderCreate1.Location = new System.Drawing.Point(341, 4);
            this.btnWorkOrderCreate1.Margin = new System.Windows.Forms.Padding(4);
            this.btnWorkOrderCreate1.Name = "btnWorkOrderCreate1";
            this.btnWorkOrderCreate1.Size = new System.Drawing.Size(162, 157);
            this.btnWorkOrderCreate1.TabIndex = 13;
            this.btnWorkOrderCreate1.Text = "작업지시 생성";
            this.btnWorkOrderCreate1.UseVisualStyleBackColor = false;
            this.btnWorkOrderCreate1.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetWorker1
            // 
            this.btnSetWorker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetWorker1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetWorker1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetWorker1.Location = new System.Drawing.Point(509, 4);
            this.btnSetWorker1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetWorker1.Name = "btnSetWorker1";
            this.btnSetWorker1.Size = new System.Drawing.Size(162, 157);
            this.btnSetWorker1.TabIndex = 12;
            this.btnSetWorker1.Text = "작업자\r\n할당";
            this.btnSetWorker1.UseVisualStyleBackColor = false;
            this.btnSetWorker1.Click += new System.EventHandler(this.btnClick);
            // 
            // btnCreatePallet
            // 
            this.btnCreatePallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnCreatePallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePallet.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreatePallet.Location = new System.Drawing.Point(678, 4);
            this.btnCreatePallet.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatePallet.Name = "btnCreatePallet";
            this.btnCreatePallet.Size = new System.Drawing.Size(162, 157);
            this.btnCreatePallet.TabIndex = 11;
            this.btnCreatePallet.Text = "팔래트\r\n생성";
            this.btnCreatePallet.UseVisualStyleBackColor = false;
            this.btnCreatePallet.Click += new System.EventHandler(this.btnClick);
            // 
            // btnBarcordeRecreate
            // 
            this.btnBarcordeRecreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnBarcordeRecreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcordeRecreate.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBarcordeRecreate.Location = new System.Drawing.Point(846, 4);
            this.btnBarcordeRecreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBarcordeRecreate.Name = "btnBarcordeRecreate";
            this.btnBarcordeRecreate.Size = new System.Drawing.Size(162, 157);
            this.btnBarcordeRecreate.TabIndex = 10;
            this.btnBarcordeRecreate.Text = "팔레트\r\n바코드\r\n재발행";
            this.btnBarcordeRecreate.UseVisualStyleBackColor = false;
            this.btnBarcordeRecreate.Click += new System.EventHandler(this.btnClick);
            // 
            // btnWarehousing
            // 
            this.btnWarehousing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWarehousing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehousing.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWarehousing.Location = new System.Drawing.Point(1014, 4);
            this.btnWarehousing.Margin = new System.Windows.Forms.Padding(4);
            this.btnWarehousing.Name = "btnWarehousing";
            this.btnWarehousing.Size = new System.Drawing.Size(162, 157);
            this.btnWarehousing.TabIndex = 9;
            this.btnWarehousing.Text = "입고등록";
            this.btnWarehousing.UseVisualStyleBackColor = false;
            this.btnWarehousing.Click += new System.EventHandler(this.btnClick);
            // 
            // btnUnload
            // 
            this.btnUnload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnUnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnload.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUnload.Location = new System.Drawing.Point(1183, 4);
            this.btnUnload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(162, 157);
            this.btnUnload.TabIndex = 8;
            this.btnUnload.Text = "언로딩";
            this.btnUnload.UseVisualStyleBackColor = false;
            this.btnUnload.Click += new System.EventHandler(this.btnClick);
            // 
            // btnQualityMeasure1
            // 
            this.btnQualityMeasure1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnQualityMeasure1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityMeasure1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQualityMeasure1.Location = new System.Drawing.Point(1351, 4);
            this.btnQualityMeasure1.Margin = new System.Windows.Forms.Padding(4);
            this.btnQualityMeasure1.Name = "btnQualityMeasure1";
            this.btnQualityMeasure1.Size = new System.Drawing.Size(162, 157);
            this.btnQualityMeasure1.TabIndex = 7;
            this.btnQualityMeasure1.Text = "품질\r\n측정값\r\n등록";
            this.btnQualityMeasure1.UseVisualStyleBackColor = false;
            this.btnQualityMeasure1.Click += new System.EventHandler(this.btnClick);
            // 
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1556, 783);
            this.Controls.Add(this.panBoxing);
            this.Controls.Add(this.aPanel6);
            this.Controls.Add(this.panLoad);
            this.Controls.Add(this.panMolding);
            this.Controls.Add(this.aDataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "WorkOrderForm";
            this.Load += new System.EventHandler(this.WorkOrderForm_Load);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.panMolding, 0);
            this.Controls.SetChildIndex(this.panLoad, 0);
            this.Controls.SetChildIndex(this.aPanel6, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.panBoxing, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.panMolding.ResumeLayout(false);
            this.panLoad.ResumeLayout(false);
            this.aPanel6.ResumeLayout(false);
            this.panBoxing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.ADataGridView aDataGridView1;
        private Axxen.CustomControls.APanel panMolding;
        private Axxen.CustomControls.AButton btnWorkOrderOnOff3;
        private Axxen.CustomControls.AButton btnWorkOrderQuit3;
        private Axxen.CustomControls.AButton btnDryGVLoad;
        private Axxen.CustomControls.AButton btnSetWorker3;
        private Axxen.CustomControls.AButton btnSetMold;
        private Axxen.CustomControls.AButton btnSetPressCondition2;
        private Axxen.CustomControls.AButton btnQualityMeasure3;
        private Axxen.CustomControls.APanel panLoad;
        private Axxen.CustomControls.AButton btnWorkOrderOnOff2;
        private Axxen.CustomControls.AButton btnWorkOrderQuit2;
        private Axxen.CustomControls.AButton btnWorkOrderCreate2;
        private Axxen.CustomControls.AButton btnSetWorker2;
        private Axxen.CustomControls.AButton btnLoadRecordRegister;
        private Axxen.CustomControls.AButton btnFiringInOut;
        private Axxen.CustomControls.AButton btnClearDryGV;
        private Axxen.CustomControls.AButton btnSetPressCondition1;
        private Axxen.CustomControls.AButton btnQualityMeasure2;
        private Axxen.CustomControls.APanel aPanel6;
        private Axxen.CustomControls.AButton aButton17;
        private Axxen.CustomControls.AButton aButton18;
        private Axxen.CustomControls.AButton aButton19;
        private Axxen.CustomControls.AButton aButton20;
        private Axxen.CustomControls.AButton aButton21;
        private Axxen.CustomControls.AButton aButton22;
        private Axxen.CustomControls.AButton aButton23;
        private Axxen.CustomControls.AButton aButton24;
        private Axxen.CustomControls.AButton aButton25;
        private Axxen.CustomControls.APanel panBoxing;
        private Axxen.CustomControls.AButton btnWorkOrderOnOff1;
        private Axxen.CustomControls.AButton btnWorkOrderQuit1;
        private Axxen.CustomControls.AButton btnWorkOrderCreate1;
        private Axxen.CustomControls.AButton btnSetWorker1;
        private Axxen.CustomControls.AButton btnCreatePallet;
        private Axxen.CustomControls.AButton btnBarcordeRecreate;
        private Axxen.CustomControls.AButton btnWarehousing;
        private Axxen.CustomControls.AButton btnUnload;
        private Axxen.CustomControls.AButton btnQualityMeasure1;
    }
}
