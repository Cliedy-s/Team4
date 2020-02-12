namespace Axxen
{
    partial class QAM_SQC_002
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
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.btnadd = new Axxen.CustomControls.AButton();
            this.btndelete = new Axxen.CustomControls.AButton();
            this.aTextBox_FindNameByCode1 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aTextBox_FindNameByCode2 = new Axxen.CustomControls.ATextBox_FindNameByCode();
            this.aDateTimePickerSearch1 = new Axxen.CustomControls.ADateTimePickerSearch();
            this.lblnum = new Axxen.CustomControls.ALabel();
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).BeginInit();
            this.aSplitContainer1.Panel1.SuspendLayout();
            this.aSplitContainer1.Panel2.SuspendLayout();
            this.aSplitContainer1.SuspendLayout();
            this.aGroupBox2.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // aSplitContainer1
            // 
            // 
            // aHeaderBox1
            // 
            this.aHeaderBox1.HeaderBoxText = "작업지시";
            // 
            // aHeaderBox2
            // 
            this.aHeaderBox2.HeaderBoxText = "측정이력";
            // 
            // aGroupBox1
            // 
            this.aGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.aGroupBox1.Size = new System.Drawing.Size(203, 561);
            this.aGroupBox1.Text = "검사항목";
            // 
            // aGroupBox2
            // 
            this.aGroupBox2.Controls.Add(this.lblnum);
            this.aGroupBox2.Controls.Add(this.btndelete);
            this.aGroupBox2.Controls.Add(this.btnadd);
            this.aGroupBox2.Location = new System.Drawing.Point(206, 0);
            this.aGroupBox2.Size = new System.Drawing.Size(653, 561);
            this.aGroupBox2.Text = "측정값";
            this.aGroupBox2.Controls.SetChildIndex(this.btnadd, 0);
            this.aGroupBox2.Controls.SetChildIndex(this.btndelete, 0);
            this.aGroupBox2.Controls.SetChildIndex(this.lblnum, 0);
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.aDateTimePickerSearch1);
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode2);
            this.aPanel2.Controls.Add(this.aTextBox_FindNameByCode1);
            this.aPanel2.Controls.Add(this.aLabel1);
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(27, 32);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(55, 15);
            this.aLabel1.TabIndex = 22;
            this.aLabel1.Text = "생산일자";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(6, 23);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "측정회차 추가";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(127, 23);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "측정회차 삭제";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // aTextBox_FindNameByCode1
            // 
            this.aTextBox_FindNameByCode1.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.CodeType = Axxen.CustomControls.DataType.Processes;
            this.aTextBox_FindNameByCode1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode1.lblNameText = "공정";
            this.aTextBox_FindNameByCode1.Location = new System.Drawing.Point(476, 26);
            this.aTextBox_FindNameByCode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode1.Name = "aTextBox_FindNameByCode1";
            this.aTextBox_FindNameByCode1.Size = new System.Drawing.Size(218, 27);
            this.aTextBox_FindNameByCode1.TabIndex = 26;
            this.aTextBox_FindNameByCode1.txtCodeText = "";
            this.aTextBox_FindNameByCode1.txtNameText = "";
            this.aTextBox_FindNameByCode1.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.aTextBox_FindNameByCode1_DotDotDotFormClosing);
            // 
            // aTextBox_FindNameByCode2
            // 
            this.aTextBox_FindNameByCode2.allfont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.CodeType = Axxen.CustomControls.DataType.WorkCenters;
            this.aTextBox_FindNameByCode2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aTextBox_FindNameByCode2.lblNameText = "작업장";
            this.aTextBox_FindNameByCode2.Location = new System.Drawing.Point(714, 26);
            this.aTextBox_FindNameByCode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aTextBox_FindNameByCode2.Name = "aTextBox_FindNameByCode2";
            this.aTextBox_FindNameByCode2.Size = new System.Drawing.Size(230, 27);
            this.aTextBox_FindNameByCode2.TabIndex = 27;
            this.aTextBox_FindNameByCode2.txtCodeText = "";
            this.aTextBox_FindNameByCode2.txtNameText = "";
            this.aTextBox_FindNameByCode2.DotDotDotFormClosing += new Axxen.CustomControls.ATextBox_FindNameByCode.SearchFormClosing(this.aTextBox_FindNameByCode2_DotDotDotFormClosing);
            // 
            // aDateTimePickerSearch1
            // 
            this.aDateTimePickerSearch1.ADateTimePickerValue1 = new System.DateTime(2020, 2, 5, 18, 34, 50, 374);
            this.aDateTimePickerSearch1.ADateTimePickerValue2 = new System.DateTime(2020, 2, 12, 18, 34, 50, 374);
            this.aDateTimePickerSearch1.ButtonText = "조회";
            this.aDateTimePickerSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aDateTimePickerSearch1.Location = new System.Drawing.Point(88, 23);
            this.aDateTimePickerSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aDateTimePickerSearch1.Name = "aDateTimePickerSearch1";
            this.aDateTimePickerSearch1.Size = new System.Drawing.Size(324, 32);
            this.aDateTimePickerSearch1.TabIndex = 28;
            this.aDateTimePickerSearch1.btnDateTimeSearch_Click += new Axxen.CustomControls.ADateTimePickerSearch.SearchButtonClick(this.aDateTimePickerSearch1_btnDateTimeSearch_Click);
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(261, 27);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(0, 15);
            this.lblnum.TabIndex = 3;
            // 
            // QAM_SQC_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1148, 700);
            this.ControlBox = false;
            this.Name = "QAM_SQC_002";
            this.Text = "품질측정값등록";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QAM_SQC_002_FormClosing);
            this.Load += new System.EventHandler(this.QAM_SQC_002_Load);
            this.aSplitContainer1.Panel1.ResumeLayout(false);
            this.aSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aSplitContainer1)).EndInit();
            this.aSplitContainer1.ResumeLayout(false);
            this.aGroupBox2.ResumeLayout(false);
            this.aGroupBox2.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.AButton btndelete;
        private CustomControls.AButton btnadd;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode2;
        private CustomControls.ATextBox_FindNameByCode aTextBox_FindNameByCode1;
        private CustomControls.ADateTimePickerSearch aDateTimePickerSearch1;
        private CustomControls.ALabel lblnum;
    }
}
