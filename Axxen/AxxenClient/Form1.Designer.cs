namespace AxxenClient
{
    partial class Form1
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
            this.aTextBox_Labeled1 = new Axxen.CustomControls.ATextBox_Labeled();
            this.aBorderPanel1 = new AxxenClient.CustomControls.ABorderPanel();
            this.SuspendLayout();
            // 
            // aTextBox_Labeled1
            // 
            this.aTextBox_Labeled1.FontSize = 9F;
            this.aTextBox_Labeled1.LabelText = "lblName";
            this.aTextBox_Labeled1.Location = new System.Drawing.Point(329, 172);
            this.aTextBox_Labeled1.Name = "aTextBox_Labeled1";
            this.aTextBox_Labeled1.Size = new System.Drawing.Size(319, 22);
            this.aTextBox_Labeled1.SplitDistance = 106;
            this.aTextBox_Labeled1.TabIndex = 3;
            this.aTextBox_Labeled1.TextBoxText = "";
            // 
            // aBorderPanel1
            // 
            this.aBorderPanel1.CommonColor = System.Drawing.SystemColors.Control;
            this.aBorderPanel1.Location = new System.Drawing.Point(105, 163);
            this.aBorderPanel1.Name = "aBorderPanel1";
            this.aBorderPanel1.Size = new System.Drawing.Size(200, 100);
            this.aBorderPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aBorderPanel1);
            this.Controls.Add(this.aTextBox_Labeled1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.ATextBox_Labeled aTextBox_Labeled1;
        private CustomControls.ABorderPanel aBorderPanel1;
    }
}

