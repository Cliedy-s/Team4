namespace Axxen
{
    partial class PRM_PRF_008
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
            this.aTextBox_FindNameByCode2 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aDateTimePickerSearch2 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.aDateTimePickerSearch2);
            this.panTop.Controls.Add(this.aTextBox_FindNameByCode2);
            this.panTop.Controls.Add(this.aTextBox_FindNameByCode1);
            this.panTop.Controls.Add(this.aLabel1);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(35, 43);
            this.aLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(84, 20);
            this.aLabel1.TabIndex = 14;
            this.aLabel1.Text = "비가동일자";
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.types.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(591, 35);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(285, 36);
            this.aTextBox_FindNameByCode1.TabIndex = 18;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            // 
            // aTextBox_FindNameByCode2
            // 
            this.aTextBox_FindNameByCode2.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.CodeType = Axxen.CustomControls.types.WorkCenters;
            this.aTextBox_FindNameByCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.lblNameText = "작업장";
            this.aTextBox_FindNameByCode2.Location = new System.Drawing.Point(901, 35);
            this.aTextBox_FindNameByCode2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aTextBox_FindNameByCode2.Name = "aTextBox_FindNameByCode2";
            this.aTextBox_FindNameByCode2.Size = new System.Drawing.Size(309, 36);
            this.aTextBox_FindNameByCode2.TabIndex = 19;
            this.aTextBox_FindNameByCode2.txtCodeText = "";
            this.aTextBox_FindNameByCode2.txtNameText = "";
            // 
            // aDateTimePickerSearch2
            // 
            this.aDateTimePickerSearch2.ADateTimePickerValue1 = new System.DateTime(2020, 1, 17, 21, 10, 24, 705);
            this.aDateTimePickerSearch2.ADateTimePickerValue2 = new System.DateTime(2020, 1, 24, 20, 21, 3, 736);
            this.aDateTimePickerSearch2.ButtonText = "조회";
            this.aDateTimePickerSearch2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch2.Location = new System.Drawing.Point(129, 31);
            this.aDateTimePickerSearch2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aDateTimePickerSearch2.Name = "aDateTimePickerSearch2";
            this.aDateTimePickerSearch2.Size = new System.Drawing.Size(417, 43);
            this.aDateTimePickerSearch2.TabIndex = 20;
            this.aDateTimePickerSearch2.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.ADateTimePickerSearch2_btnDateTimeSearch_Click);
            // 
            // PRM_PRF_008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1476, 933);
            this.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.Name = "PRM_PRF_008";
            this.Text = "비가동 등록";
            this.Load += new System.EventHandler(this.PRM_PRF_008_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode2;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch2;
    }
}
