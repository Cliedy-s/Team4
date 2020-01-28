namespace Axxen
{
    partial class PPS_MLD_001
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
            this.txtName = new Axxen.CustomControls.ATextBox_Labeled();
            this.txtCode = new Axxen.CustomControls.ATextBox_Labeled();
            this.cboGroup = new Axxen.CustomControls.AComboBox();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.txtMoldCode = new Axxen.CustomControls.ATextBox_Labeled();
            this.txtMoldGroup = new Axxen.CustomControls.ATextBox_Labeled();
            this.txtMoldName = new Axxen.CustomControls.ATextBox_Labeled();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.numHit = new System.Windows.Forms.NumericUpDown();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.dtpInDate = new Axxen.CustomControls.ADateTimePicker();
            this.dtpLastEquip = new Axxen.CustomControls.ADateTimePicker();
            this.aLabel6 = new Axxen.CustomControls.ALabel();
            this.txtRemark = new Axxen.CustomControls.ATextBox();
            this.txtCost = new Axxen.CustomControls.ATextBox_Labeled();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHit)).BeginInit();
            this.SuspendLayout();
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.txtName);
            this.aPanel2.Controls.Add(this.txtCode);
            this.aPanel2.Controls.Add(this.aLabel1);
            this.aPanel2.Controls.Add(this.cboGroup);
            // 
            // aSplitContainer1
            // 
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.txtCost);
            this.aPanel1.Controls.Add(this.txtRemark);
            this.aPanel1.Controls.Add(this.aLabel6);
            this.aPanel1.Controls.Add(this.dtpLastEquip);
            this.aPanel1.Controls.Add(this.dtpInDate);
            this.aPanel1.Controls.Add(this.aLabel4);
            this.aPanel1.Controls.Add(this.aLabel3);
            this.aPanel1.Controls.Add(this.numHit);
            this.aPanel1.Controls.Add(this.aLabel2);
            this.aPanel1.Controls.Add(this.txtMoldName);
            this.aPanel1.Controls.Add(this.txtMoldGroup);
            this.aPanel1.Controls.Add(this.txtMoldCode);
            this.aPanel1.Controls.SetChildIndex(this.aHeaderBox2, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtMoldCode, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtMoldGroup, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtMoldName, 0);
            this.aPanel1.Controls.SetChildIndex(this.aLabel2, 0);
            this.aPanel1.Controls.SetChildIndex(this.numHit, 0);
            this.aPanel1.Controls.SetChildIndex(this.aLabel3, 0);
            this.aPanel1.Controls.SetChildIndex(this.aLabel4, 0);
            this.aPanel1.Controls.SetChildIndex(this.dtpInDate, 0);
            this.aPanel1.Controls.SetChildIndex(this.dtpLastEquip, 0);
            this.aPanel1.Controls.SetChildIndex(this.aLabel6, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtRemark, 0);
            this.aPanel1.Controls.SetChildIndex(this.txtCost, 0);
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "조회내역";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "입력정보";
            // 
            // txtName
            // 
            this.txtName.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.LabelText = "금형 명";
            this.txtName.Location = new System.Drawing.Point(346, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 23);
            this.txtName.TabIndex = 18;
            this.txtName.TextBoxText = "";
            this.txtName.TextBoxType = Axxen.CustomControls.type.Normal;
            this.txtName.TextKeyPress += new Axxen.CustomControls.ATextBox_Labeled.TextEnterKeyPress(this.Text_TextKeyPress);
            // 
            // txtCode
            // 
            this.txtCode.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.LabelText = "금형 코드";
            this.txtCode.Location = new System.Drawing.Point(27, 32);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(212, 23);
            this.txtCode.TabIndex = 17;
            this.txtCode.TextBoxText = "";
            this.txtCode.TextBoxType = Axxen.CustomControls.type.Normal;
            this.txtCode.TextKeyPress += new Axxen.CustomControls.ATextBox_Labeled.TextEnterKeyPress(this.Text_TextKeyPress);
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(698, 32);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(106, 23);
            this.cboGroup.TabIndex = 16;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.CboDate_SelectedIndexChanged);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(637, 35);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(55, 15);
            this.aLabel1.TabIndex = 15;
            this.aLabel1.Text = "금형그룹";
            // 
            // txtMoldCode
            // 
            this.txtMoldCode.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldCode.LabelText = "금형코드";
            this.txtMoldCode.Location = new System.Drawing.Point(257, 12);
            this.txtMoldCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoldCode.Name = "txtMoldCode";
            this.txtMoldCode.Size = new System.Drawing.Size(212, 23);
            this.txtMoldCode.TabIndex = 18;
            this.txtMoldCode.TextBoxText = "";
            this.txtMoldCode.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // txtMoldGroup
            // 
            this.txtMoldGroup.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldGroup.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldGroup.LabelText = "금형그룹";
            this.txtMoldGroup.Location = new System.Drawing.Point(257, 74);
            this.txtMoldGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoldGroup.Name = "txtMoldGroup";
            this.txtMoldGroup.Size = new System.Drawing.Size(212, 23);
            this.txtMoldGroup.TabIndex = 19;
            this.txtMoldGroup.TextBoxText = "";
            this.txtMoldGroup.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // txtMoldName
            // 
            this.txtMoldName.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMoldName.LabelText = "금형명";
            this.txtMoldName.Location = new System.Drawing.Point(257, 43);
            this.txtMoldName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoldName.Name = "txtMoldName";
            this.txtMoldName.Size = new System.Drawing.Size(212, 23);
            this.txtMoldName.TabIndex = 20;
            this.txtMoldName.TextBoxText = "";
            this.txtMoldName.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(527, 18);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(55, 15);
            this.aLabel2.TabIndex = 22;
            this.aLabel2.Text = "보장타수";
            // 
            // numHit
            // 
            this.numHit.Location = new System.Drawing.Point(611, 12);
            this.numHit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHit.Name = "numHit";
            this.numHit.Size = new System.Drawing.Size(104, 23);
            this.numHit.TabIndex = 23;
            this.numHit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Location = new System.Drawing.Point(527, 49);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(55, 15);
            this.aLabel3.TabIndex = 24;
            this.aLabel3.Text = "입고일자";
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(527, 80);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(79, 15);
            this.aLabel4.TabIndex = 25;
            this.aLabel4.Text = "최종장착일시";
            // 
            // dtpInDate
            // 
            this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInDate.Location = new System.Drawing.Point(611, 43);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(134, 23);
            this.dtpInDate.TabIndex = 28;
            // 
            // dtpLastEquip
            // 
            this.dtpLastEquip.CustomFormat = "yyyy-MM-dd hh-mm";
            this.dtpLastEquip.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLastEquip.Location = new System.Drawing.Point(612, 76);
            this.dtpLastEquip.Name = "dtpLastEquip";
            this.dtpLastEquip.Size = new System.Drawing.Size(142, 23);
            this.dtpLastEquip.TabIndex = 28;
            // 
            // aLabel6
            // 
            this.aLabel6.AutoSize = true;
            this.aLabel6.Location = new System.Drawing.Point(836, 42);
            this.aLabel6.Name = "aLabel6";
            this.aLabel6.Size = new System.Drawing.Size(31, 15);
            this.aLabel6.TabIndex = 29;
            this.aLabel6.Text = "비고";
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.White;
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.errorp = null;
            this.txtRemark.Location = new System.Drawing.Point(839, 60);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(263, 37);
            this.txtRemark.TabIndex = 30;
            this.txtRemark.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtCost
            // 
            this.txtCost.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCost.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCost.LabelText = "구입금액";
            this.txtCost.Location = new System.Drawing.Point(835, 7);
            this.txtCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(227, 29);
            this.txtCost.TabIndex = 31;
            this.txtCost.TextBoxText = "";
            this.txtCost.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // PPS_MLD_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.Name = "PPS_MLD_001";
            this.Text = "/";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PPS_MLD_001_FormClosed);
            this.Load += new System.EventHandler(this.PPS_MLD_001_Load);
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.ATextBox_Labeled txtName;
        private CustomControls.ATextBox_Labeled txtCode;
        private CustomControls.AComboBox cboGroup;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ALabel aLabel4;
        private CustomControls.ALabel aLabel3;
        private System.Windows.Forms.NumericUpDown numHit;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ATextBox_Labeled txtMoldName;
        private CustomControls.ATextBox_Labeled txtMoldGroup;
        private CustomControls.ATextBox_Labeled txtMoldCode;
        private CustomControls.ATextBox txtRemark;
        private CustomControls.ALabel aLabel6;
        private CustomControls.ADateTimePicker dtpLastEquip;
        private CustomControls.ADateTimePicker dtpInDate;
        private CustomControls.ATextBox_Labeled txtCost;
    }
}
