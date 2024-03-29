﻿namespace Axxen.CustomControls
{
    partial class ABigTextBox_Labeled
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new Axxen.CustomControls.ALabel();
            this.txtValue = new Axxen.CustomControls.ATextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(0, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 32);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValue
            // 
            this.txtValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtValue.BackColor = System.Drawing.Color.White;
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.errorp = null;
            this.txtValue.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtValue.Location = new System.Drawing.Point(108, 6);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(179, 29);
            this.txtValue.TabIndex = 3;
            this.txtValue.txtType = Axxen.CustomControls.TextType.Normal;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValue_KeyPress);
            // 
            // ABigTextBox_Labeled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ABigTextBox_Labeled";
            this.Size = new System.Drawing.Size(292, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ALabel lblName;
        private ATextBox txtValue;
    }
}
