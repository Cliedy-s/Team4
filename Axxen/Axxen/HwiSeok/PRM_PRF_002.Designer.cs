﻿namespace Axxen
{
    partial class PRM_PRF_002
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
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aButton3 = new Axxen.CustomControls.AButton();
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
            this.aPanel1.Controls.Add(this.aButton3);
            this.aPanel1.Controls.Add(this.aButton2);
            this.aPanel1.Controls.Add(this.aButton1);
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
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(749, 28);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(114, 23);
            this.aButton1.TabIndex = 10;
            this.aButton1.Text = "작업지시 마감";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Location = new System.Drawing.Point(869, 28);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(114, 23);
            this.aButton2.TabIndex = 10;
            this.aButton2.Text = "팔렛트 마감";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aButton3
            // 
            this.aButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Location = new System.Drawing.Point(989, 28);
            this.aButton3.Name = "aButton3";
            this.aButton3.Size = new System.Drawing.Size(114, 23);
            this.aButton3.TabIndex = 10;
            this.aButton3.Text = "등급상세 수정";
            this.aButton3.UseVisualStyleBackColor = false;
            // 
            // aDateTimePickerSearch2
            // 
            this.aDateTimePickerSearch2.ADateTimePickerValue1 = new System.DateTime(2020, 1, 7, 17, 5, 21, 134);
            this.aDateTimePickerSearch2.ADateTimePickerValue2 = new System.DateTime(2020, 1, 14, 17, 5, 21, 138);
            this.aDateTimePickerSearch2.ButtonText = "조회";
            this.aDateTimePickerSearch2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch2.Location = new System.Drawing.Point(88, 23);
            this.aDateTimePickerSearch2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch2.Name = "aDateTimePickerSearch2";
            this.aDateTimePickerSearch2.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch2.TabIndex = 11;
            this.aDateTimePickerSearch2.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.aDateTimePickerSearch2_btnDateTimeSearch_Click);
            // 
            // PRM_PRF_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "PRM_PRF_002";
            this.Text = "포장 팔렛트 마감";
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
        private CustomControls.AButton aButton3;
        private CustomControls.AButton aButton2;
        private CustomControls.AButton aButton1;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch2;
    }
}
