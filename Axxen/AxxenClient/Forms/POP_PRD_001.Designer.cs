namespace AxxenClient.Forms
{
    partial class POP_PRD_001
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
            this.dgvMain = new Axxen.CustomControls.ADataGridView();
            this.panMolding = new Axxen.CustomControls.APanel();
            this.btnWorkOrderOnOff3 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderQuit3 = new Axxen.CustomControls.AButton();
            this.btnDryGVLoad = new Axxen.CustomControls.AButton();
            this.btnSetWorker3 = new Axxen.CustomControls.AButton();
            this.btnSetMold = new Axxen.CustomControls.AButton();
            this.btnSetPressCondition2 = new Axxen.CustomControls.AButton();
            this.btnQualityMeasure3 = new Axxen.CustomControls.AButton();
            this.panLoad = new Axxen.CustomControls.APanel();
            this.btnWorkOrderCreate2 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderOnOff0 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderQuit2 = new Axxen.CustomControls.AButton();
            this.btnSetWorker2 = new Axxen.CustomControls.AButton();
            this.btnLoadRecordRegister = new Axxen.CustomControls.AButton();
            this.btnFiringInOut = new Axxen.CustomControls.AButton();
            this.btnClearDryGV = new Axxen.CustomControls.AButton();
            this.btnSetPressCondition1 = new Axxen.CustomControls.AButton();
            this.btnQualityMeasure2 = new Axxen.CustomControls.AButton();
            this.btnWorkOrderOnOff2 = new Axxen.CustomControls.AButton();
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
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panMolding.SuspendLayout();
            this.panLoad.SuspendLayout();
            this.panBoxing.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.Location = new System.Drawing.Point(0, 585);
            this.panBottom.Margin = new System.Windows.Forms.Padding(4);
            // 
            // btnNoActive
            // 
            this.btnNoActive.Tag = typeof(AxxenClient.Forms.POP_PRD_016);
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "작업지시 현황";
            // 
            // btnMachineRun
            // 
            this.btnMachineRun.Click += new System.EventHandler(this.btnMachineRun_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 105);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(1186, 344);
            this.dgvMain.TabIndex = 4;
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
            this.panMolding.Location = new System.Drawing.Point(12, 455);
            this.panMolding.Name = "panMolding";
            this.panMolding.Size = new System.Drawing.Size(1186, 124);
            this.panMolding.TabIndex = 5;
            this.panMolding.Visible = false;
            // 
            // btnWorkOrderOnOff3
            // 
            this.btnWorkOrderOnOff3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderOnOff3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderOnOff3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderOnOff3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderOnOff3.Location = new System.Drawing.Point(66, 1);
            this.btnWorkOrderOnOff3.Name = "btnWorkOrderOnOff3";
            this.btnWorkOrderOnOff3.Size = new System.Drawing.Size(145, 118);
            this.btnWorkOrderOnOff3.TabIndex = 6;
            this.btnWorkOrderOnOff3.Text = "작업시작/종료";
            this.btnWorkOrderOnOff3.UseVisualStyleBackColor = false;
            this.btnWorkOrderOnOff3.Click += new System.EventHandler(this.btnWorkOrderToggle);
            // 
            // btnWorkOrderQuit3
            // 
            this.btnWorkOrderQuit3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderQuit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderQuit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderQuit3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderQuit3.Location = new System.Drawing.Point(218, 1);
            this.btnWorkOrderQuit3.Name = "btnWorkOrderQuit3";
            this.btnWorkOrderQuit3.Size = new System.Drawing.Size(145, 118);
            this.btnWorkOrderQuit3.TabIndex = 5;
            this.btnWorkOrderQuit3.Text = "현장마감";
            this.btnWorkOrderQuit3.UseVisualStyleBackColor = false;
            this.btnWorkOrderQuit3.Click += new System.EventHandler(this.btnWorkOrderClose);
            // 
            // btnDryGVLoad
            // 
            this.btnDryGVLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDryGVLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnDryGVLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDryGVLoad.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDryGVLoad.Location = new System.Drawing.Point(370, 1);
            this.btnDryGVLoad.Name = "btnDryGVLoad";
            this.btnDryGVLoad.Size = new System.Drawing.Size(145, 118);
            this.btnDryGVLoad.TabIndex = 4;
            this.btnDryGVLoad.Text = "건조 대차 로딩";
            this.btnDryGVLoad.UseVisualStyleBackColor = false;
            this.btnDryGVLoad.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetWorker3
            // 
            this.btnSetWorker3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetWorker3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetWorker3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetWorker3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetWorker3.Location = new System.Drawing.Point(522, 1);
            this.btnSetWorker3.Name = "btnSetWorker3";
            this.btnSetWorker3.Size = new System.Drawing.Size(145, 118);
            this.btnSetWorker3.TabIndex = 3;
            this.btnSetWorker3.Text = "작업자\r\n할당";
            this.btnSetWorker3.UseVisualStyleBackColor = false;
            this.btnSetWorker3.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetMold
            // 
            this.btnSetMold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetMold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetMold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMold.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetMold.Location = new System.Drawing.Point(674, 1);
            this.btnSetMold.Name = "btnSetMold";
            this.btnSetMold.Size = new System.Drawing.Size(145, 118);
            this.btnSetMold.TabIndex = 2;
            this.btnSetMold.Text = "금형 장착\r\n/탈착";
            this.btnSetMold.UseVisualStyleBackColor = false;
            this.btnSetMold.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetPressCondition2
            // 
            this.btnSetPressCondition2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetPressCondition2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetPressCondition2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPressCondition2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetPressCondition2.Location = new System.Drawing.Point(826, 1);
            this.btnSetPressCondition2.Name = "btnSetPressCondition2";
            this.btnSetPressCondition2.Size = new System.Drawing.Size(145, 118);
            this.btnSetPressCondition2.TabIndex = 1;
            this.btnSetPressCondition2.Text = "공정조건 등록";
            this.btnSetPressCondition2.UseVisualStyleBackColor = false;
            this.btnSetPressCondition2.Click += new System.EventHandler(this.btnClick);
            // 
            // btnQualityMeasure3
            // 
            this.btnQualityMeasure3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQualityMeasure3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnQualityMeasure3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityMeasure3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQualityMeasure3.Location = new System.Drawing.Point(978, 1);
            this.btnQualityMeasure3.Name = "btnQualityMeasure3";
            this.btnQualityMeasure3.Size = new System.Drawing.Size(145, 118);
            this.btnQualityMeasure3.TabIndex = 0;
            this.btnQualityMeasure3.Text = "품질\r\n측정값\r\n등록";
            this.btnQualityMeasure3.UseVisualStyleBackColor = false;
            this.btnQualityMeasure3.Click += new System.EventHandler(this.btnClick);
            // 
            // panLoad
            // 
            this.panLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLoad.Controls.Add(this.btnWorkOrderCreate2);
            this.panLoad.Controls.Add(this.btnWorkOrderOnOff0);
            this.panLoad.Controls.Add(this.btnWorkOrderQuit2);
            this.panLoad.Controls.Add(this.btnSetWorker2);
            this.panLoad.Controls.Add(this.btnLoadRecordRegister);
            this.panLoad.Controls.Add(this.btnFiringInOut);
            this.panLoad.Controls.Add(this.btnClearDryGV);
            this.panLoad.Controls.Add(this.btnSetPressCondition1);
            this.panLoad.Controls.Add(this.btnQualityMeasure2);
            this.panLoad.Location = new System.Drawing.Point(12, 202);
            this.panLoad.Name = "panLoad";
            this.panLoad.Size = new System.Drawing.Size(1186, 124);
            this.panLoad.TabIndex = 6;
            this.panLoad.Visible = false;
            // 
            // btnWorkOrderCreate2
            // 
            this.btnWorkOrderCreate2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderCreate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderCreate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderCreate2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderCreate2.Location = new System.Drawing.Point(265, 3);
            this.btnWorkOrderCreate2.Name = "btnWorkOrderCreate2";
            this.btnWorkOrderCreate2.Size = new System.Drawing.Size(126, 118);
            this.btnWorkOrderCreate2.TabIndex = 13;
            this.btnWorkOrderCreate2.Text = "작업지시 생성";
            this.btnWorkOrderCreate2.UseVisualStyleBackColor = false;
            this.btnWorkOrderCreate2.Click += new System.EventHandler(this.btnClick);
            // 
            // btnWorkOrderOnOff0
            // 
            this.btnWorkOrderOnOff0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderOnOff0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderOnOff0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderOnOff0.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderOnOff0.Location = new System.Drawing.Point(4, 3);
            this.btnWorkOrderOnOff0.Name = "btnWorkOrderOnOff0";
            this.btnWorkOrderOnOff0.Size = new System.Drawing.Size(126, 118);
            this.btnWorkOrderOnOff0.TabIndex = 16;
            this.btnWorkOrderOnOff0.Text = "작업시작/종료";
            this.btnWorkOrderOnOff0.UseVisualStyleBackColor = false;
            this.btnWorkOrderOnOff0.Click += new System.EventHandler(this.btnWorkOrderToggle);
            // 
            // btnWorkOrderQuit2
            // 
            this.btnWorkOrderQuit2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderQuit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderQuit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderQuit2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderQuit2.Location = new System.Drawing.Point(134, 3);
            this.btnWorkOrderQuit2.Name = "btnWorkOrderQuit2";
            this.btnWorkOrderQuit2.Size = new System.Drawing.Size(126, 118);
            this.btnWorkOrderQuit2.TabIndex = 14;
            this.btnWorkOrderQuit2.Text = "현장마감";
            this.btnWorkOrderQuit2.UseVisualStyleBackColor = false;
            this.btnWorkOrderQuit2.Click += new System.EventHandler(this.btnWorkOrderClose);
            // 
            // btnSetWorker2
            // 
            this.btnSetWorker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetWorker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetWorker2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetWorker2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetWorker2.Location = new System.Drawing.Point(396, 3);
            this.btnSetWorker2.Name = "btnSetWorker2";
            this.btnSetWorker2.Size = new System.Drawing.Size(126, 118);
            this.btnSetWorker2.TabIndex = 12;
            this.btnSetWorker2.Text = "작업자\r\n할당";
            this.btnSetWorker2.UseVisualStyleBackColor = false;
            this.btnSetWorker2.Click += new System.EventHandler(this.btnClick);
            // 
            // btnLoadRecordRegister
            // 
            this.btnLoadRecordRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoadRecordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnLoadRecordRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRecordRegister.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoadRecordRegister.Location = new System.Drawing.Point(527, 3);
            this.btnLoadRecordRegister.Name = "btnLoadRecordRegister";
            this.btnLoadRecordRegister.Size = new System.Drawing.Size(126, 118);
            this.btnLoadRecordRegister.TabIndex = 11;
            this.btnLoadRecordRegister.Text = "적재\r\n실적\r\n등록";
            this.btnLoadRecordRegister.UseVisualStyleBackColor = false;
            this.btnLoadRecordRegister.Click += new System.EventHandler(this.btnClick);
            // 
            // btnFiringInOut
            // 
            this.btnFiringInOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiringInOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnFiringInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiringInOut.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFiringInOut.Location = new System.Drawing.Point(658, 3);
            this.btnFiringInOut.Name = "btnFiringInOut";
            this.btnFiringInOut.Size = new System.Drawing.Size(126, 118);
            this.btnFiringInOut.TabIndex = 10;
            this.btnFiringInOut.Text = "요입\r\n/요출";
            this.btnFiringInOut.UseVisualStyleBackColor = false;
            this.btnFiringInOut.Click += new System.EventHandler(this.btnClick);
            // 
            // btnClearDryGV
            // 
            this.btnClearDryGV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearDryGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnClearDryGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDryGV.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClearDryGV.Location = new System.Drawing.Point(789, 3);
            this.btnClearDryGV.Name = "btnClearDryGV";
            this.btnClearDryGV.Size = new System.Drawing.Size(126, 118);
            this.btnClearDryGV.TabIndex = 9;
            this.btnClearDryGV.Text = "건조대차 비우기";
            this.btnClearDryGV.UseVisualStyleBackColor = false;
            this.btnClearDryGV.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetPressCondition1
            // 
            this.btnSetPressCondition1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetPressCondition1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetPressCondition1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPressCondition1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetPressCondition1.Location = new System.Drawing.Point(920, 3);
            this.btnSetPressCondition1.Name = "btnSetPressCondition1";
            this.btnSetPressCondition1.Size = new System.Drawing.Size(126, 118);
            this.btnSetPressCondition1.TabIndex = 8;
            this.btnSetPressCondition1.Text = "공정조건 등록";
            this.btnSetPressCondition1.UseVisualStyleBackColor = false;
            this.btnSetPressCondition1.Click += new System.EventHandler(this.btnClick);
            // 
            // btnQualityMeasure2
            // 
            this.btnQualityMeasure2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQualityMeasure2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnQualityMeasure2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityMeasure2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQualityMeasure2.Location = new System.Drawing.Point(1051, 3);
            this.btnQualityMeasure2.Name = "btnQualityMeasure2";
            this.btnQualityMeasure2.Size = new System.Drawing.Size(126, 118);
            this.btnQualityMeasure2.TabIndex = 7;
            this.btnQualityMeasure2.Text = "품질\r\n측정값\r\n등록";
            this.btnQualityMeasure2.UseVisualStyleBackColor = false;
            this.btnQualityMeasure2.Click += new System.EventHandler(this.btnClick);
            // 
            // btnWorkOrderOnOff2
            // 
            this.btnWorkOrderOnOff2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderOnOff2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderOnOff2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderOnOff2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderOnOff2.Location = new System.Drawing.Point(3, 3);
            this.btnWorkOrderOnOff2.Name = "btnWorkOrderOnOff2";
            this.btnWorkOrderOnOff2.Size = new System.Drawing.Size(126, 118);
            this.btnWorkOrderOnOff2.TabIndex = 15;
            this.btnWorkOrderOnOff2.Text = "작업시작/종료";
            this.btnWorkOrderOnOff2.UseVisualStyleBackColor = false;
            this.btnWorkOrderOnOff2.Click += new System.EventHandler(this.btnWorkOrderToggle);
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
            this.panBoxing.Location = new System.Drawing.Point(12, 326);
            this.panBoxing.Name = "panBoxing";
            this.panBoxing.Size = new System.Drawing.Size(1186, 124);
            this.panBoxing.TabIndex = 16;
            this.panBoxing.Visible = false;
            // 
            // btnWorkOrderOnOff1
            // 
            this.btnWorkOrderOnOff1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderOnOff1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderOnOff1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderOnOff1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderOnOff1.Location = new System.Drawing.Point(3, 3);
            this.btnWorkOrderOnOff1.Name = "btnWorkOrderOnOff1";
            this.btnWorkOrderOnOff1.Size = new System.Drawing.Size(126, 118);
            this.btnWorkOrderOnOff1.TabIndex = 15;
            this.btnWorkOrderOnOff1.Text = "작업시작/종료";
            this.btnWorkOrderOnOff1.UseVisualStyleBackColor = false;
            this.btnWorkOrderOnOff1.Click += new System.EventHandler(this.btnWorkOrderToggle);
            // 
            // btnWorkOrderQuit1
            // 
            this.btnWorkOrderQuit1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderQuit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderQuit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderQuit1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderQuit1.Location = new System.Drawing.Point(134, 3);
            this.btnWorkOrderQuit1.Name = "btnWorkOrderQuit1";
            this.btnWorkOrderQuit1.Size = new System.Drawing.Size(126, 118);
            this.btnWorkOrderQuit1.TabIndex = 14;
            this.btnWorkOrderQuit1.Text = "현장마감";
            this.btnWorkOrderQuit1.UseVisualStyleBackColor = false;
            this.btnWorkOrderQuit1.Click += new System.EventHandler(this.btnWorkOrderClose);
            // 
            // btnWorkOrderCreate1
            // 
            this.btnWorkOrderCreate1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWorkOrderCreate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWorkOrderCreate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOrderCreate1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkOrderCreate1.Location = new System.Drawing.Point(265, 3);
            this.btnWorkOrderCreate1.Name = "btnWorkOrderCreate1";
            this.btnWorkOrderCreate1.Size = new System.Drawing.Size(126, 118);
            this.btnWorkOrderCreate1.TabIndex = 13;
            this.btnWorkOrderCreate1.Text = "작업지시 생성";
            this.btnWorkOrderCreate1.UseVisualStyleBackColor = false;
            this.btnWorkOrderCreate1.Click += new System.EventHandler(this.btnClick);
            // 
            // btnSetWorker1
            // 
            this.btnSetWorker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetWorker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSetWorker1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetWorker1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetWorker1.Location = new System.Drawing.Point(396, 3);
            this.btnSetWorker1.Name = "btnSetWorker1";
            this.btnSetWorker1.Size = new System.Drawing.Size(126, 118);
            this.btnSetWorker1.TabIndex = 12;
            this.btnSetWorker1.Text = "작업자\r\n할당";
            this.btnSetWorker1.UseVisualStyleBackColor = false;
            this.btnSetWorker1.Click += new System.EventHandler(this.btnClick);
            // 
            // btnCreatePallet
            // 
            this.btnCreatePallet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreatePallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnCreatePallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePallet.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreatePallet.Location = new System.Drawing.Point(527, 3);
            this.btnCreatePallet.Name = "btnCreatePallet";
            this.btnCreatePallet.Size = new System.Drawing.Size(126, 118);
            this.btnCreatePallet.TabIndex = 11;
            this.btnCreatePallet.Text = "팔래트\r\n생성";
            this.btnCreatePallet.UseVisualStyleBackColor = false;
            this.btnCreatePallet.Click += new System.EventHandler(this.btnClick);
            // 
            // btnBarcordeRecreate
            // 
            this.btnBarcordeRecreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBarcordeRecreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnBarcordeRecreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcordeRecreate.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBarcordeRecreate.Location = new System.Drawing.Point(658, 3);
            this.btnBarcordeRecreate.Name = "btnBarcordeRecreate";
            this.btnBarcordeRecreate.Size = new System.Drawing.Size(126, 118);
            this.btnBarcordeRecreate.TabIndex = 10;
            this.btnBarcordeRecreate.Text = "팔레트\r\n바코드\r\n재발행";
            this.btnBarcordeRecreate.UseVisualStyleBackColor = false;
            this.btnBarcordeRecreate.Click += new System.EventHandler(this.btnClick);
            // 
            // btnWarehousing
            // 
            this.btnWarehousing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnWarehousing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnWarehousing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehousing.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWarehousing.Location = new System.Drawing.Point(789, 3);
            this.btnWarehousing.Name = "btnWarehousing";
            this.btnWarehousing.Size = new System.Drawing.Size(126, 118);
            this.btnWarehousing.TabIndex = 9;
            this.btnWarehousing.Text = "입고등록";
            this.btnWarehousing.UseVisualStyleBackColor = false;
            this.btnWarehousing.Click += new System.EventHandler(this.btnClick);
            // 
            // btnUnload
            // 
            this.btnUnload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUnload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnUnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnload.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUnload.Location = new System.Drawing.Point(920, 3);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(126, 118);
            this.btnUnload.TabIndex = 8;
            this.btnUnload.Text = "언로딩";
            this.btnUnload.UseVisualStyleBackColor = false;
            this.btnUnload.Click += new System.EventHandler(this.btnClick);
            // 
            // btnQualityMeasure1
            // 
            this.btnQualityMeasure1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQualityMeasure1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnQualityMeasure1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityMeasure1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQualityMeasure1.Location = new System.Drawing.Point(1051, 3);
            this.btnQualityMeasure1.Name = "btnQualityMeasure1";
            this.btnQualityMeasure1.Size = new System.Drawing.Size(126, 118);
            this.btnQualityMeasure1.TabIndex = 7;
            this.btnQualityMeasure1.Text = "품질\r\n측정값\r\n등록";
            this.btnQualityMeasure1.UseVisualStyleBackColor = false;
            this.btnQualityMeasure1.Click += new System.EventHandler(this.btnClick);
            // 
            // POP_PRD_001
            // 
            this.ClientSize = new System.Drawing.Size(1210, 621);
            this.Controls.Add(this.panBoxing);
            this.Controls.Add(this.panLoad);
            this.Controls.Add(this.panMolding);
            this.Controls.Add(this.dgvMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_001";
            this.Text = "작업지시현황";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.POP_PRD_001_FormClosing);
            this.Load += new System.EventHandler(this.WorkOrderForm_Load);
            this.Controls.SetChildIndex(this.dgvMain, 0);
            this.Controls.SetChildIndex(this.panMolding, 0);
            this.Controls.SetChildIndex(this.panLoad, 0);
            this.Controls.SetChildIndex(this.panBoxing, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panMolding.ResumeLayout(false);
            this.panLoad.ResumeLayout(false);
            this.panBoxing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.ADataGridView dgvMain;
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
        private Axxen.CustomControls.AButton btnWorkOrderOnOff0;
    }
}
