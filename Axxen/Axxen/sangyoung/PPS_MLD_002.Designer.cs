﻿namespace Axxen
{
    partial class PPS_MLD_002
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
            this.dotWorkCenter = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.dotItem = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.aDateTimePickerSearch1);
            this.panTop.Controls.Add(this.dotWorkCenter);
            this.panTop.Controls.Add(this.dotItem);
            this.panTop.Controls.Add(this.aLabel1);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // dotWorkCenter
            // 
            this.dotWorkCenter.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotWorkCenter.CodeType = Axxen.CustomControls.DataType.WorkCenters;
            this.dotWorkCenter.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotWorkCenter.lblNameText = "작업장";
            this.dotWorkCenter.Location = new System.Drawing.Point(709, 26);
            this.dotWorkCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dotWorkCenter.Name = "dotWorkCenter";
            this.dotWorkCenter.Size = new System.Drawing.Size(229, 27);
            this.dotWorkCenter.TabIndex = 23;
            this.dotWorkCenter.txtCodeText = "";
            this.dotWorkCenter.txtNameText = "";
            this.dotWorkCenter.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.ATextBox_FindNameByCode1_DotDotDotFormClosing);
            // 
            // dotItem
            // 
            this.dotItem.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotItem.CodeType = Axxen.CustomControls.DataType.Items;
            this.dotItem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dotItem.lblNameText = "품목";
            this.dotItem.Location = new System.Drawing.Point(439, 26);
            this.dotItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dotItem.Name = "dotItem";
            this.dotItem.Size = new System.Drawing.Size(221, 27);
            this.dotItem.TabIndex = 22;
            this.dotItem.txtCodeText = "";
            this.dotItem.txtNameText = "";
            this.dotItem.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.ATextBox_FindNameByCode1_DotDotDotFormClosing);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(55, 15);
            this.aLabel1.TabIndex = 18;
            this.aLabel1.Text = "생산일자";
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 2, 3, 12, 8, 57, 809);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 2, 10, 12, 8, 57, 809);
            this.aDateTimePickerSearch1.ButtonText = "조회";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(88, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch1.TabIndex = 24;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.ADateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // PPS_MLD_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Name = "PPS_MLD_002";
            this.Activated += new System.EventHandler(this.PPS_MLD_002_Activated);
            this.Deactivate += new System.EventHandler(this.PPS_MLD_002_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPS_MLD_002_FormClosed);
            this.Load += new System.EventHandler(this.PPS_MLD_002_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ATextBox_FindNameByCode dotWorkCenter;
        private CustomControls.ATextBox_FindNameByCode dotItem;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
    }
}
