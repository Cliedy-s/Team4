namespace AxxenClient.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.aComboBox1 = new Axxen.CustomControls.AComboBox();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.timetimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // aComboBox1
            // 
            this.aComboBox1.FormattingEnabled = true;
            this.aComboBox1.Location = new System.Drawing.Point(12, 10);
            this.aComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aComboBox1.Name = "aComboBox1";
            this.aComboBox1.Size = new System.Drawing.Size(121, 20);
            this.aComboBox1.TabIndex = 1;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(139, 10);
            this.aButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(75, 18);
            this.aButton1.TabIndex = 2;
            this.aButton1.Text = "열기";
            this.aButton1.UseVisualStyleBackColor = false;
            this.aButton1.Click += new System.EventHandler(this.aButton1_Click);
            // 
            // timetimer
            // 
            this.timetimer.Interval = 1000;
            this.timetimer.Tick += new System.EventHandler(this.timetimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1427, 690);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aComboBox1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.AComboBox aComboBox1;
        private Axxen.CustomControls.AButton aButton1;
        private System.Windows.Forms.Timer timetimer;
    }
}
