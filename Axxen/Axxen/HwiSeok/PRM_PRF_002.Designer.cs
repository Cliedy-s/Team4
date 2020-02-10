namespace Axxen
{
    partial class PRM_PRF_002
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components 
            ;

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
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.btnWorkorderno = new Axxen.CustomControls.AButton();
            this.btnPallet = new Axxen.CustomControls.AButton();
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.aDateTimePickerSearch1);
            this.aPanel1.Controls.Add(this.btnPallet);
            this.aPanel1.Controls.Add(this.btnWorkorderno);
            this.aPanel1.Controls.Add(this.aLabel1);
            // 
            // aSplitContainer1
            // 
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "팔렛트 목록";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(55, 15);
            this.aLabel1.TabIndex = 6;
            this.aLabel1.Text = "생산일자";
            // 
            // btnWorkorderno
            // 
            this.btnWorkorderno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWorkorderno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkorderno.Location = new System.Drawing.Point(849, 28);
            this.btnWorkorderno.Name = "btnWorkorderno";
            this.btnWorkorderno.Size = new System.Drawing.Size(114, 23);
            this.btnWorkorderno.TabIndex = 10;
            this.btnWorkorderno.Text = "작업지시 마감";
            this.btnWorkorderno.UseVisualStyleBackColor = false;
            this.btnWorkorderno.Click += new System.EventHandler(this.btnWorkorderno_Click);
            // 
            // btnPallet
            // 
            this.btnPallet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPallet.Location = new System.Drawing.Point(986, 28);
            this.btnPallet.Name = "btnPallet";
            this.btnPallet.Size = new System.Drawing.Size(114, 23);
            this.btnPallet.TabIndex = 10;
            this.btnPallet.Text = "팔렛트 마감";
            this.btnPallet.UseVisualStyleBackColor = false;
            this.btnPallet.Click += new System.EventHandler(this.btnPallet_Click);
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 2, 3, 12, 8, 31, 479);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 2, 10, 12, 8, 31, 479);
            this.aDateTimePickerSearch1.ButtonText = "조회";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(88, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch1.TabIndex = 11;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.aDateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // PRM_PRF_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Name = "PRM_PRF_002";
            this.Text = "포장 팔렛트 마감";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PRM_PRF_002_FormClosing);
            this.Load += new System.EventHandler(this.PRM_PRF_002_Load);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.ALabel aLabel1;
        private CustomControls.AButton btnPallet;
        private CustomControls.AButton btnWorkorderno;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
    }
}
