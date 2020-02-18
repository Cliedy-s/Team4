namespace Axxen
{
    partial class QAM_SQC_005
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
            this.aTextBox_FindNameByCode2 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.aDateTimePickerSearch1);
            this.panTop.Controls.Add(this.aTextBox_FindNameByCode2);
            this.panTop.Controls.Add(this.aTextBox_FindNameByCode1);
            this.panTop.Controls.Add(this.aLabel1);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aTextBox_FindNameByCode2
            // 
            this.aTextBox_FindNameByCode2.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.CodeType = Axxen.CustomControls.DataType.WorkCenters;
            this.aTextBox_FindNameByCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.lblNameText = "작업장";
            this.aTextBox_FindNameByCode2.Location = new System.Drawing.Point(774, 26);
            this.aTextBox_FindNameByCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode2.Name = "aTextBox_FindNameByCode2";
            this.aTextBox_FindNameByCode2.Size = new System.Drawing.Size(318, 27);
            this.aTextBox_FindNameByCode2.TabIndex = 45;
            this.aTextBox_FindNameByCode2.txtCodeText = "";
            this.aTextBox_FindNameByCode2.txtNameText = "";
            this.aTextBox_FindNameByCode2.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.aTextBox_FindNameByCode2_DotDotDotFormClosing);
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(452, 26);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(307, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 44;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            this.aTextBox_FindNameByCode1.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.aTextBox_FindNameByCode1_DotDotDotFormClosing);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(79, 15);
            this.aLabel1.TabIndex = 40;
            this.aLabel1.Text = "작업지시일자";
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 2, 10, 0, 0, 0, 0);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.aDateTimePickerSearch1.ButtonText = "";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(112, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch1.TabIndex = 46;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.aDateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // QAM_SQC_005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Name = "QAM_SQC_005";
            this.Text = "";
            this.Load += new System.EventHandler(this.QAM_SQC_005_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode2;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
    }
}
