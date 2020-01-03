namespace Axxen.HwiSeok
{
    partial class PRM_PRF_007
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
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aButton3 = new Axxen.CustomControls.AButton();
            this.SuspendLayout();
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(22, 21);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(228, 149);
            this.aButton1.TabIndex = 0;
            this.aButton1.Text = "대차명/상태\r\n작업지시번호/\r\n품목코드/품목명\r\n수량/로딩시간\r\n\r\n";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Location = new System.Drawing.Point(277, 21);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(228, 149);
            this.aButton2.TabIndex = 1;
            this.aButton2.Text = "대차명/상태\r\n작업지시번호/\r\n품목코드/품목명\r\n수량/로딩시간\r\n";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aButton3
            // 
            this.aButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Location = new System.Drawing.Point(932, 21);
            this.aButton3.Name = "aButton3";
            this.aButton3.Size = new System.Drawing.Size(204, 667);
            this.aButton3.TabIndex = 2;
            this.aButton3.Text = "비어있는 대차 목록";
            this.aButton3.UseVisualStyleBackColor = false;
            // 
            // PRM_PRF_007
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Controls.Add(this.aButton3);
            this.Controls.Add(this.aButton2);
            this.Controls.Add(this.aButton1);
            this.Name = "PRM_PRF_007";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.AButton aButton1;
        private CustomControls.AButton aButton2;
        private CustomControls.AButton aButton3;
    }
}
