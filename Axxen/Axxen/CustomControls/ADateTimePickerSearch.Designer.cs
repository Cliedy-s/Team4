namespace Axxen.CustomControls
{
    partial class ADateTimePickerSearch
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
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aDateTimePicker2 = new Axxen.CustomControls.ADateTimePicker();
            this.aDateTimePicker1 = new Axxen.CustomControls.ADateTimePicker();
            this.SuspendLayout();
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(244, 4);
            this.aButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(75, 23);
            this.aButton1.TabIndex = 3;
            this.aButton1.Text = "조회";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(112, 8);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(15, 15);
            this.aLabel1.TabIndex = 2;
            this.aLabel1.Text = "~";
            // 
            // aDateTimePicker2
            // 
            this.aDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker2.Location = new System.Drawing.Point(133, 4);
            this.aDateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePicker2.Name = "aDateTimePicker2";
            this.aDateTimePicker2.Size = new System.Drawing.Size(105, 23);
            this.aDateTimePicker2.TabIndex = 1;
            // 
            // aDateTimePicker1
            // 
            this.aDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker1.Location = new System.Drawing.Point(3, 4);
            this.aDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePicker1.Name = "aDateTimePicker1";
            this.aDateTimePicker1.Size = new System.Drawing.Size(103, 23);
            this.aDateTimePicker1.TabIndex = 0;
            // 
            // ADateTimePickerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.aDateTimePicker2);
            this.Controls.Add(this.aDateTimePicker1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ADateTimePickerSearch";
            this.Size = new System.Drawing.Size(324, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ADateTimePicker aDateTimePicker1;
        private ADateTimePicker aDateTimePicker2;
        private ALabel aLabel1;
        private AButton aButton1;
    }
}
