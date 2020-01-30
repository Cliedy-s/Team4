namespace Axxen
{
    partial class PRM_PRF_002_1
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
            this.aTextBox1 = new Axxen.CustomControls.ATextBox();
            this.aBigHeaderBox1 = new Axxen.CustomControls.ABigHeaderBox();
            this.aButton3 = new Axxen.CustomControls.AButton();
            this.aButton4 = new Axxen.CustomControls.AButton();
            this.SuspendLayout();
            // 
            // aTextBox1
            // 
            this.aTextBox1.BackColor = System.Drawing.Color.White;
            this.aTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTextBox1.errorp = null;
            this.aTextBox1.Location = new System.Drawing.Point(12, 83);
            this.aTextBox1.Multiline = true;
            this.aTextBox1.Name = "aTextBox1";
            this.aTextBox1.Size = new System.Drawing.Size(273, 71);
            this.aTextBox1.TabIndex = 0;
            this.aTextBox1.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aBigHeaderBox1
            // 
            this.aBigHeaderBox1.allfont = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aBigHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aBigHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox1.HeaderBoxText = "등급상세 수정";
            this.aBigHeaderBox1.Location = new System.Drawing.Point(12, 12);
            this.aBigHeaderBox1.Name = "aBigHeaderBox1";
            this.aBigHeaderBox1.Size = new System.Drawing.Size(273, 50);
            this.aBigHeaderBox1.TabIndex = 1;
            // 
            // aButton3
            // 
            this.aButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Location = new System.Drawing.Point(200, 171);
            this.aButton3.Name = "aButton3";
            this.aButton3.Size = new System.Drawing.Size(85, 32);
            this.aButton3.TabIndex = 14;
            this.aButton3.Text = "취소";
            this.aButton3.UseVisualStyleBackColor = false;
            this.aButton3.Click += new System.EventHandler(this.aButton3_Click);
            // 
            // aButton4
            // 
            this.aButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton4.Location = new System.Drawing.Point(100, 171);
            this.aButton4.Name = "aButton4";
            this.aButton4.Size = new System.Drawing.Size(85, 32);
            this.aButton4.TabIndex = 15;
            this.aButton4.Text = "수정";
            this.aButton4.UseVisualStyleBackColor = false;
            this.aButton4.Click += new System.EventHandler(this.aButton4_Click);
            // 
            // PRM_PRF_002_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(304, 215);
            this.Controls.Add(this.aButton3);
            this.Controls.Add(this.aButton4);
            this.Controls.Add(this.aBigHeaderBox1);
            this.Controls.Add(this.aTextBox1);
            this.Name = "PRM_PRF_002_1";
            this.Text = "등급상세 수정";
            this.Load += new System.EventHandler(this.PRM_PRF_002_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ATextBox aTextBox1;
        private CustomControls.ABigHeaderBox aBigHeaderBox1;
        private CustomControls.AButton aButton3;
        private CustomControls.AButton aButton4;
    }
}
