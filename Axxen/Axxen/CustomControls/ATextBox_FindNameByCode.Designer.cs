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
            this.aTextBox1 = new Axxen.CustomControls.ATextBox();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aTextBox2 = new Axxen.CustomControls.ATextBox();
            this.SuspendLayout();
            // 
            // aTextBox1
            // 
            this.aTextBox1.BackColor = System.Drawing.Color.White;
            this.aTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTextBox1.errorp = null;
            this.aTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox1.Location = new System.Drawing.Point(1, 2);
            this.aTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox1.Name = "aTextBox1";
            this.aTextBox1.Size = new System.Drawing.Size(38, 23);
            this.aTextBox1.TabIndex = 0;
            this.aTextBox1.txtType = Axxen.CustomControls.ATextBox.type.Normal;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(42, 2);
            this.aButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(34, 23);
            this.aButton1.TabIndex = 1;
            this.aButton1.Text = "...";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aTextBox2
            // 
            this.aTextBox2.BackColor = System.Drawing.Color.White;
            this.aTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aTextBox2.errorp = null;
            this.aTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox2.Location = new System.Drawing.Point(79, 2);
            this.aTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox2.Name = "aTextBox2";
            this.aTextBox2.ReadOnly = true;
            this.aTextBox2.Size = new System.Drawing.Size(97, 23);
            this.aTextBox2.TabIndex = 2;
            this.aTextBox2.txtType = Axxen.CustomControls.ATextBox.type.Normal;
            // 
            // ATextBox_FindNameByCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aTextBox2);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aTextBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ATextBox_FindNameByCode";
            this.Size = new System.Drawing.Size(178, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ATextBox aTextBox1;
        private AButton aButton1;
        private ATextBox aTextBox2;
    }
}
