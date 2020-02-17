namespace Axxen
{
    partial class PRM_PRF_009
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
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.btnExecl = new Axxen.CustomControls.AButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.btnExecl);
            this.panTop.Controls.Add(this.aTextBox_FindNameByCode1);
            this.panTop.Controls.Add(this.aDateTimePickerSearch1);
            this.panTop.Controls.Add(this.aLabel1);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(55, 15);
            this.aLabel1.TabIndex = 14;
            this.aLabel1.Text = "근무일자";
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 2, 10, 0, 0, 0, 0);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 2, 17, 0, 0, 0, 0);
            this.aDateTimePickerSearch1.ButtonText = "";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(88, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch1.TabIndex = 15;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.aDateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Workers;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "작업자";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(394, 28);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(321, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 16;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            this.aTextBox_FindNameByCode1.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.aTextBox_FindNameByCode1_DotDotDotFormClosing);
            // 
            // btnExecl
            // 
            this.btnExecl.BackColor = System.Drawing.SystemColors.Info;
            this.btnExecl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecl.Location = new System.Drawing.Point(874, 28);
            this.btnExecl.Name = "btnExecl";
            this.btnExecl.Size = new System.Drawing.Size(168, 23);
            this.btnExecl.TabIndex = 17;
            this.btnExecl.Text = "엑셀 저장";
            this.btnExecl.UseVisualStyleBackColor = false;
            this.btnExecl.Click += new System.EventHandler(this.btnExecl_Click);
            // 
            // PRM_PRF_009
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Name = "PRM_PRF_009";
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PRM_PRF_009_FormClosing);
            this.Load += new System.EventHandler(this.PRM_PRF_009_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
        private CustomControls.AButton btnExecl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
