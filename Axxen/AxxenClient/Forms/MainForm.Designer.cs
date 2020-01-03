namespace AxxenClient.Forms
{
    partial class MainForm
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
            this.aDataGridView1 = new AxxenClient.CustomControls.ADataGridView();
            this.btnWorkStartEnd = new AxxenClient.CustomControls.AButton();
            this.panFor1 = new AxxenClient.CustomControls.APanel();
            this.aButton6 = new AxxenClient.CustomControls.AButton();
            this.aButton7 = new AxxenClient.CustomControls.AButton();
            this.aButton8 = new AxxenClient.CustomControls.AButton();
            this.aButton3 = new AxxenClient.CustomControls.AButton();
            this.aButton4 = new AxxenClient.CustomControls.AButton();
            this.aButton2 = new AxxenClient.CustomControls.AButton();
            this.panFor2 = new AxxenClient.CustomControls.APanel();
            this.aButton15 = new AxxenClient.CustomControls.AButton();
            this.aButton16 = new AxxenClient.CustomControls.AButton();
            this.aButton5 = new AxxenClient.CustomControls.AButton();
            this.aButton9 = new AxxenClient.CustomControls.AButton();
            this.aButton10 = new AxxenClient.CustomControls.AButton();
            this.aButton11 = new AxxenClient.CustomControls.AButton();
            this.aButton12 = new AxxenClient.CustomControls.AButton();
            this.aButton13 = new AxxenClient.CustomControls.AButton();
            this.aButton14 = new AxxenClient.CustomControls.AButton();
            this.panFor3 = new AxxenClient.CustomControls.APanel();
            this.aButton17 = new AxxenClient.CustomControls.AButton();
            this.aButton18 = new AxxenClient.CustomControls.AButton();
            this.aButton19 = new AxxenClient.CustomControls.AButton();
            this.aButton20 = new AxxenClient.CustomControls.AButton();
            this.aButton21 = new AxxenClient.CustomControls.AButton();
            this.aButton22 = new AxxenClient.CustomControls.AButton();
            this.aButton23 = new AxxenClient.CustomControls.AButton();
            this.aButton24 = new AxxenClient.CustomControls.AButton();
            this.aButton25 = new AxxenClient.CustomControls.AButton();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.panFor1.SuspendLayout();
            this.panFor2.SuspendLayout();
            this.panFor3.SuspendLayout();
            this.SuspendLayout();
            // 
            // aLabel1
            // 
            this.aLabel1.Size = new System.Drawing.Size(31, 15);
            this.aLabel1.Text = "시간";
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Location = new System.Drawing.Point(193, 29);
            this.aLabel_Header1.Size = new System.Drawing.Size(826, 39);
            this.aLabel_Header1.Text = "작업지시 현황";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 928);
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(0, 99);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(1210, 417);
            this.aDataGridView1.TabIndex = 4;
            // 
            // btnWorkStartEnd
            // 
            this.btnWorkStartEnd.BackColor = System.Drawing.Color.White;
            this.btnWorkStartEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkStartEnd.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWorkStartEnd.Location = new System.Drawing.Point(25, 7);
            this.btnWorkStartEnd.Name = "btnWorkStartEnd";
            this.btnWorkStartEnd.Size = new System.Drawing.Size(154, 120);
            this.btnWorkStartEnd.TabIndex = 5;
            this.btnWorkStartEnd.Text = "작업시작 /  종료";
            this.btnWorkStartEnd.UseVisualStyleBackColor = false;
            // 
            // panFor1
            // 
            this.panFor1.Controls.Add(this.aButton6);
            this.panFor1.Controls.Add(this.aButton7);
            this.panFor1.Controls.Add(this.aButton8);
            this.panFor1.Controls.Add(this.aButton3);
            this.panFor1.Controls.Add(this.aButton4);
            this.panFor1.Controls.Add(this.aButton2);
            this.panFor1.Controls.Add(this.btnWorkStartEnd);
            this.panFor1.Location = new System.Drawing.Point(0, 515);
            this.panFor1.Name = "panFor1";
            this.panFor1.Size = new System.Drawing.Size(1210, 138);
            this.panFor1.TabIndex = 6;
            // 
            // aButton6
            // 
            this.aButton6.BackColor = System.Drawing.Color.White;
            this.aButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton6.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton6.Location = new System.Drawing.Point(1033, 7);
            this.aButton6.Name = "aButton6";
            this.aButton6.Size = new System.Drawing.Size(154, 120);
            this.aButton6.TabIndex = 11;
            this.aButton6.Text = "품질\r\n측정값\r\n등록";
            this.aButton6.UseVisualStyleBackColor = false;
            // 
            // aButton7
            // 
            this.aButton7.BackColor = System.Drawing.Color.White;
            this.aButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton7.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton7.Location = new System.Drawing.Point(865, 7);
            this.aButton7.Name = "aButton7";
            this.aButton7.Size = new System.Drawing.Size(154, 120);
            this.aButton7.TabIndex = 10;
            this.aButton7.Text = " 공정조건   등록";
            this.aButton7.UseVisualStyleBackColor = false;
            // 
            // aButton8
            // 
            this.aButton8.BackColor = System.Drawing.Color.White;
            this.aButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton8.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton8.Location = new System.Drawing.Point(697, 7);
            this.aButton8.Name = "aButton8";
            this.aButton8.Size = new System.Drawing.Size(154, 120);
            this.aButton8.TabIndex = 9;
            this.aButton8.Text = "금형 장착 / 탈착";
            this.aButton8.UseVisualStyleBackColor = false;
            // 
            // aButton3
            // 
            this.aButton3.BackColor = System.Drawing.Color.White;
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton3.Location = new System.Drawing.Point(529, 7);
            this.aButton3.Name = "aButton3";
            this.aButton3.Size = new System.Drawing.Size(154, 120);
            this.aButton3.TabIndex = 8;
            this.aButton3.Text = "작업자 할당";
            this.aButton3.UseVisualStyleBackColor = false;
            // 
            // aButton4
            // 
            this.aButton4.BackColor = System.Drawing.Color.White;
            this.aButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton4.Location = new System.Drawing.Point(361, 7);
            this.aButton4.Name = "aButton4";
            this.aButton4.Size = new System.Drawing.Size(154, 120);
            this.aButton4.TabIndex = 7;
            this.aButton4.Text = "건조 대차   로딩";
            this.aButton4.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.Color.White;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton2.Location = new System.Drawing.Point(193, 7);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(154, 120);
            this.aButton2.TabIndex = 6;
            this.aButton2.Text = "현장마감";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // panFor2
            // 
            this.panFor2.Controls.Add(this.aButton15);
            this.panFor2.Controls.Add(this.aButton16);
            this.panFor2.Controls.Add(this.aButton5);
            this.panFor2.Controls.Add(this.aButton9);
            this.panFor2.Controls.Add(this.aButton10);
            this.panFor2.Controls.Add(this.aButton11);
            this.panFor2.Controls.Add(this.aButton12);
            this.panFor2.Controls.Add(this.aButton13);
            this.panFor2.Controls.Add(this.aButton14);
            this.panFor2.Location = new System.Drawing.Point(1, 654);
            this.panFor2.Name = "panFor2";
            this.panFor2.Size = new System.Drawing.Size(1210, 138);
            this.panFor2.TabIndex = 12;
            // 
            // aButton15
            // 
            this.aButton15.BackColor = System.Drawing.Color.White;
            this.aButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton15.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton15.Location = new System.Drawing.Point(1054, 8);
            this.aButton15.Name = "aButton15";
            this.aButton15.Size = new System.Drawing.Size(125, 120);
            this.aButton15.TabIndex = 13;
            this.aButton15.Text = "품질\r\n측정값\r\n등록";
            this.aButton15.UseVisualStyleBackColor = false;
            // 
            // aButton16
            // 
            this.aButton16.BackColor = System.Drawing.Color.White;
            this.aButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton16.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton16.Location = new System.Drawing.Point(926, 8);
            this.aButton16.Name = "aButton16";
            this.aButton16.Size = new System.Drawing.Size(125, 120);
            this.aButton16.TabIndex = 12;
            this.aButton16.Text = "공정조건 등록";
            this.aButton16.UseVisualStyleBackColor = false;
            // 
            // aButton5
            // 
            this.aButton5.BackColor = System.Drawing.Color.White;
            this.aButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton5.Location = new System.Drawing.Point(798, 8);
            this.aButton5.Name = "aButton5";
            this.aButton5.Size = new System.Drawing.Size(125, 120);
            this.aButton5.TabIndex = 11;
            this.aButton5.Text = "건조대차 비우기";
            this.aButton5.UseVisualStyleBackColor = false;
            // 
            // aButton9
            // 
            this.aButton9.BackColor = System.Drawing.Color.White;
            this.aButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton9.Location = new System.Drawing.Point(670, 8);
            this.aButton9.Name = "aButton9";
            this.aButton9.Size = new System.Drawing.Size(125, 120);
            this.aButton9.TabIndex = 10;
            this.aButton9.Text = "  요입  / 요출";
            this.aButton9.UseVisualStyleBackColor = false;
            // 
            // aButton10
            // 
            this.aButton10.BackColor = System.Drawing.Color.White;
            this.aButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton10.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton10.Location = new System.Drawing.Point(542, 8);
            this.aButton10.Name = "aButton10";
            this.aButton10.Size = new System.Drawing.Size(125, 120);
            this.aButton10.TabIndex = 9;
            this.aButton10.Text = "적재 실적 등록";
            this.aButton10.UseVisualStyleBackColor = false;
            // 
            // aButton11
            // 
            this.aButton11.BackColor = System.Drawing.Color.White;
            this.aButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton11.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton11.Location = new System.Drawing.Point(414, 8);
            this.aButton11.Name = "aButton11";
            this.aButton11.Size = new System.Drawing.Size(125, 120);
            this.aButton11.TabIndex = 8;
            this.aButton11.Text = " 작업자  할당";
            this.aButton11.UseVisualStyleBackColor = false;
            // 
            // aButton12
            // 
            this.aButton12.BackColor = System.Drawing.Color.White;
            this.aButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton12.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton12.Location = new System.Drawing.Point(286, 8);
            this.aButton12.Name = "aButton12";
            this.aButton12.Size = new System.Drawing.Size(125, 120);
            this.aButton12.TabIndex = 7;
            this.aButton12.Text = "작업지시 생성";
            this.aButton12.UseVisualStyleBackColor = false;
            // 
            // aButton13
            // 
            this.aButton13.BackColor = System.Drawing.Color.White;
            this.aButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton13.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton13.Location = new System.Drawing.Point(158, 8);
            this.aButton13.Name = "aButton13";
            this.aButton13.Size = new System.Drawing.Size(125, 120);
            this.aButton13.TabIndex = 6;
            this.aButton13.Text = "현장마감";
            this.aButton13.UseVisualStyleBackColor = false;
            // 
            // aButton14
            // 
            this.aButton14.BackColor = System.Drawing.Color.White;
            this.aButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton14.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton14.Location = new System.Drawing.Point(30, 8);
            this.aButton14.Name = "aButton14";
            this.aButton14.Size = new System.Drawing.Size(125, 120);
            this.aButton14.TabIndex = 5;
            this.aButton14.Text = "작업시작 /\r\n종료";
            this.aButton14.UseVisualStyleBackColor = false;
            // 
            // panFor3
            // 
            this.panFor3.Controls.Add(this.aButton17);
            this.panFor3.Controls.Add(this.aButton18);
            this.panFor3.Controls.Add(this.aButton19);
            this.panFor3.Controls.Add(this.aButton20);
            this.panFor3.Controls.Add(this.aButton21);
            this.panFor3.Controls.Add(this.aButton22);
            this.panFor3.Controls.Add(this.aButton23);
            this.panFor3.Controls.Add(this.aButton24);
            this.panFor3.Controls.Add(this.aButton25);
            this.panFor3.Location = new System.Drawing.Point(0, 792);
            this.panFor3.Name = "panFor3";
            this.panFor3.Size = new System.Drawing.Size(1210, 138);
            this.panFor3.TabIndex = 14;
            // 
            // aButton17
            // 
            this.aButton17.BackColor = System.Drawing.Color.White;
            this.aButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton17.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton17.Location = new System.Drawing.Point(1054, 8);
            this.aButton17.Name = "aButton17";
            this.aButton17.Size = new System.Drawing.Size(125, 120);
            this.aButton17.TabIndex = 13;
            this.aButton17.Text = "품질\r\n측정값\r\n등록";
            this.aButton17.UseVisualStyleBackColor = false;
            // 
            // aButton18
            // 
            this.aButton18.BackColor = System.Drawing.Color.White;
            this.aButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton18.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton18.Location = new System.Drawing.Point(926, 8);
            this.aButton18.Name = "aButton18";
            this.aButton18.Size = new System.Drawing.Size(125, 120);
            this.aButton18.TabIndex = 12;
            this.aButton18.Text = "언로딩";
            this.aButton18.UseVisualStyleBackColor = false;
            // 
            // aButton19
            // 
            this.aButton19.BackColor = System.Drawing.Color.White;
            this.aButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton19.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton19.Location = new System.Drawing.Point(798, 8);
            this.aButton19.Name = "aButton19";
            this.aButton19.Size = new System.Drawing.Size(125, 120);
            this.aButton19.TabIndex = 11;
            this.aButton19.Text = "입고등록";
            this.aButton19.UseVisualStyleBackColor = false;
            // 
            // aButton20
            // 
            this.aButton20.BackColor = System.Drawing.Color.White;
            this.aButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton20.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton20.Location = new System.Drawing.Point(670, 8);
            this.aButton20.Name = "aButton20";
            this.aButton20.Size = new System.Drawing.Size(125, 120);
            this.aButton20.TabIndex = 10;
            this.aButton20.Text = "팔레트\r\n바코드\r\n재발행";
            this.aButton20.UseVisualStyleBackColor = false;
            // 
            // aButton21
            // 
            this.aButton21.BackColor = System.Drawing.Color.White;
            this.aButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton21.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton21.Location = new System.Drawing.Point(542, 8);
            this.aButton21.Name = "aButton21";
            this.aButton21.Size = new System.Drawing.Size(125, 120);
            this.aButton21.TabIndex = 9;
            this.aButton21.Text = " 팔레트  생성";
            this.aButton21.UseVisualStyleBackColor = false;
            // 
            // aButton22
            // 
            this.aButton22.BackColor = System.Drawing.Color.White;
            this.aButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton22.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton22.Location = new System.Drawing.Point(414, 8);
            this.aButton22.Name = "aButton22";
            this.aButton22.Size = new System.Drawing.Size(125, 120);
            this.aButton22.TabIndex = 8;
            this.aButton22.Text = " 작업자  할당";
            this.aButton22.UseVisualStyleBackColor = false;
            // 
            // aButton23
            // 
            this.aButton23.BackColor = System.Drawing.Color.White;
            this.aButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton23.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton23.Location = new System.Drawing.Point(286, 8);
            this.aButton23.Name = "aButton23";
            this.aButton23.Size = new System.Drawing.Size(125, 120);
            this.aButton23.TabIndex = 7;
            this.aButton23.Text = "작업지시 생성";
            this.aButton23.UseVisualStyleBackColor = false;
            // 
            // aButton24
            // 
            this.aButton24.BackColor = System.Drawing.Color.White;
            this.aButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton24.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton24.Location = new System.Drawing.Point(158, 8);
            this.aButton24.Name = "aButton24";
            this.aButton24.Size = new System.Drawing.Size(125, 120);
            this.aButton24.TabIndex = 6;
            this.aButton24.Text = "현장마감";
            this.aButton24.UseVisualStyleBackColor = false;
            // 
            // aButton25
            // 
            this.aButton25.BackColor = System.Drawing.Color.White;
            this.aButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton25.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton25.Location = new System.Drawing.Point(30, 8);
            this.aButton25.Name = "aButton25";
            this.aButton25.Size = new System.Drawing.Size(125, 120);
            this.aButton25.TabIndex = 5;
            this.aButton25.Text = "작업시작 / 종료";
            this.aButton25.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 964);
            this.Controls.Add(this.panFor3);
            this.Controls.Add(this.panFor2);
            this.Controls.Add(this.panFor1);
            this.Controls.Add(this.aDataGridView1);
            this.Name = "MainForm";
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.panFor1, 0);
            this.Controls.SetChildIndex(this.panFor2, 0);
            this.Controls.SetChildIndex(this.panFor3, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.panFor1.ResumeLayout(false);
            this.panFor2.ResumeLayout(false);
            this.panFor3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxxenClient.CustomControls.ADataGridView aDataGridView1;
        private AxxenClient.CustomControls.AButton btnWorkStartEnd;
        private AxxenClient.CustomControls.APanel panFor1;
        private AxxenClient.CustomControls.AButton aButton6;
        private AxxenClient.CustomControls.AButton aButton7;
        private AxxenClient.CustomControls.AButton aButton8;
        private AxxenClient.CustomControls.AButton aButton3;
        private AxxenClient.CustomControls.AButton aButton4;
        private AxxenClient.CustomControls.AButton aButton2;
        private AxxenClient.CustomControls.APanel panFor2;
        private AxxenClient.CustomControls.AButton aButton15;
        private AxxenClient.CustomControls.AButton aButton16;
        private AxxenClient.CustomControls.AButton aButton5;
        private AxxenClient.CustomControls.AButton aButton9;
        private AxxenClient.CustomControls.AButton aButton10;
        private AxxenClient.CustomControls.AButton aButton11;
        private AxxenClient.CustomControls.AButton aButton12;
        private AxxenClient.CustomControls.AButton aButton13;
        private AxxenClient.CustomControls.AButton aButton14;
        private AxxenClient.CustomControls.APanel panFor3;
        private AxxenClient.CustomControls.AButton aButton17;
        private AxxenClient.CustomControls.AButton aButton18;
        private AxxenClient.CustomControls.AButton aButton19;
        private AxxenClient.CustomControls.AButton aButton20;
        private AxxenClient.CustomControls.AButton aButton21;
        private AxxenClient.CustomControls.AButton aButton22;
        private AxxenClient.CustomControls.AButton aButton23;
        private AxxenClient.CustomControls.AButton aButton24;
        private AxxenClient.CustomControls.AButton aButton25;
    }
}
