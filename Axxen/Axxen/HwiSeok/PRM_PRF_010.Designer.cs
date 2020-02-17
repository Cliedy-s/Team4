namespace Axxen
{
    partial class PRM_PRF_010
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
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aDateTimePickerSearch2 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.aDateTimePickerSearch2);
            this.aPanel1.Controls.Add(this.aTextBox_FindNameByCode1);
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
            this.aHeaderBox2.HeaderBoxText = "상세내역";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(55, 15);
            this.aLabel1.TabIndex = 18;
            this.aLabel1.Text = "근무일자";
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Workers;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "작업자";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(398, 28);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(319, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 22;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            this.aTextBox_FindNameByCode1.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.aTextBox_FindNameByCode1_DotDotDotFormClosing);
            // 
            // aDateTimePickerSearch2
            // 
            this.aDateTimePickerSearch2.ADateTimePickerValue1 = new System.DateTime(2020, 2, 10, 0, 0, 0, 0);
            this.aDateTimePickerSearch2.ADateTimePickerValue2 = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.aDateTimePickerSearch2.ButtonText = "";
            this.aDateTimePickerSearch2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch2.Location = new System.Drawing.Point(88, 23);
            this.aDateTimePickerSearch2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch2.Name = "aDateTimePickerSearch2";
            this.aDateTimePickerSearch2.Size = new System.Drawing.Size(288, 32);
            this.aDateTimePickerSearch2.TabIndex = 23;
            this.aDateTimePickerSearch2.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.aDateTimePickerSearch2_btnDateTimeSearch_Click);
            // 
            // PRM_PRF_010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Name = "PRM_PRF_010";
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PRM_PRF_010_FormClosing);
            this.Load += new System.EventHandler(this.PRM_PRF_010_Load);
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
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch2;
    }
}
