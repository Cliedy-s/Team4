namespace Axxen.CustomControls
{
    partial class ATextBox_FindNameByCode
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
            this.txtCode = new Axxen.CustomControls.ATextBox();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.txtName = new Axxen.CustomControls.ATextBox();
            this.lblName = new Axxen.CustomControls.ALabel();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.errorp = null;
            this.txtCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.Location = new System.Drawing.Point(104, 2);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(85, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aButton1
            // 
            this.aButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aButton1.BackColor = System.Drawing.SystemColors.Info;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(195, 2);
            this.aButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(34, 23);
            this.aButton1.TabIndex = 1;
            this.aButton1.Text = "...";
            this.aButton1.UseVisualStyleBackColor = false;
            this.aButton1.Click += new System.EventHandler(this.aButton1_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.errorp = null;
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(235, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(135, 23);
            this.txtName.TabIndex = 2;
            this.txtName.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Location = new System.Drawing.Point(0, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ATextBox_FindNameByCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.txtCode);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ATextBox_FindNameByCode";
            this.Size = new System.Drawing.Size(373, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATextBox txtCode;
        private AButton aButton1;
        private ATextBox txtName;
        private ALabel lblName;
    }
}
