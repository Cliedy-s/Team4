namespace AxxenClient.Forms
{
    partial class InputBox
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
            this.txtQty = new Axxen.CustomControls.ABigTextBox_Labeled();
            this.btnToSearch = new Axxen.CustomControls.AButton();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtQty.LabelText = "생산수량";
            this.txtQty.Location = new System.Drawing.Point(13, 15);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(292, 41);
            this.txtQty.TabIndex = 0;
            this.txtQty.TextBoxText = "";
            this.txtQty.TextBoxType = Axxen.CustomControls.TextType.Numeric;
            // 
            // btnToSearch
            // 
            this.btnToSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToSearch.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnToSearch.Location = new System.Drawing.Point(303, 21);
            this.btnToSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnToSearch.Name = "btnToSearch";
            this.btnToSearch.Size = new System.Drawing.Size(69, 29);
            this.btnToSearch.TabIndex = 39;
            this.btnToSearch.Text = "생산";
            this.btnToSearch.UseVisualStyleBackColor = false;
            this.btnToSearch.Click += new System.EventHandler(this.btnToSearch_Click);
            // 
            // aButton1
            // 
            this.aButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(375, 21);
            this.aButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(69, 29);
            this.aButton1.TabIndex = 40;
            this.aButton1.Text = "취소";
            this.aButton1.UseVisualStyleBackColor = false;
            this.aButton1.Click += new System.EventHandler(this.aButton1_Click);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(460, 69);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.btnToSearch);
            this.Controls.Add(this.txtQty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputBox";
            this.Text = "생산수량입력";
            this.ResumeLayout(false);

        }

        #endregion

        private Axxen.CustomControls.ABigTextBox_Labeled txtQty;
        private Axxen.CustomControls.AButton btnToSearch;
        private Axxen.CustomControls.AButton aButton1;
    }
}
