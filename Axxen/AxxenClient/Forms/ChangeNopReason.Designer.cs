namespace AxxenClient.Forms
{
    partial class ChangeNopReason
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
            this.cboNopMa = new Axxen.CustomControls.AComboBox();
            this.cboNopMi = new Axxen.CustomControls.AComboBox();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.lblWcName = new Axxen.CustomControls.ALabel();
            this.btnSet = new Axxen.CustomControls.AButton();
            this.btnCancel = new Axxen.CustomControls.AButton();
            this.SuspendLayout();
            // 
            // cboNopMa
            // 
            this.cboNopMa.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboNopMa.FormattingEnabled = true;
            this.cboNopMa.Location = new System.Drawing.Point(71, 70);
            this.cboNopMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNopMa.Name = "cboNopMa";
            this.cboNopMa.Size = new System.Drawing.Size(336, 38);
            this.cboNopMa.TabIndex = 0;
            this.cboNopMa.SelectedIndexChanged += new System.EventHandler(this.cboNopMa_SelectedIndexChanged);
            // 
            // cboNopMi
            // 
            this.cboNopMi.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboNopMi.FormattingEnabled = true;
            this.cboNopMi.Location = new System.Drawing.Point(71, 109);
            this.cboNopMi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNopMi.Name = "cboNopMi";
            this.cboNopMi.Size = new System.Drawing.Size(336, 38);
            this.cboNopMi.TabIndex = 1;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.Location = new System.Drawing.Point(12, 7);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(58, 21);
            this.aLabel1.TabIndex = 2;
            this.aLabel1.Text = "작업장";
            // 
            // lblWcName
            // 
            this.lblWcName.AutoSize = true;
            this.lblWcName.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWcName.Location = new System.Drawing.Point(12, 28);
            this.lblWcName.Name = "lblWcName";
            this.lblWcName.Size = new System.Drawing.Size(139, 32);
            this.lblWcName.TabIndex = 3;
            this.lblWcName.Text = "lblWcName";
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSet.Location = new System.Drawing.Point(185, 151);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(109, 39);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "설정";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(298, 151);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChangeNopReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(419, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lblWcName);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.cboNopMi);
            this.Controls.Add(this.cboNopMa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeNopReason";
            this.Text = "비가동 사유 변경";
            this.Load += new System.EventHandler(this.ChangeNopReason_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Axxen.CustomControls.AComboBox cboNopMa;
        private Axxen.CustomControls.AComboBox cboNopMi;
        private Axxen.CustomControls.ALabel aLabel1;
        private Axxen.CustomControls.ALabel lblWcName;
        private Axxen.CustomControls.AButton btnSet;
        private Axxen.CustomControls.AButton btnCancel;
    }
}
