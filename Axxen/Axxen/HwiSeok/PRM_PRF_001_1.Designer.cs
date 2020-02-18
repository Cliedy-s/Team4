namespace Axxen.HwiSeok
{
    partial class PRM_PRF_001_1
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
            this.txtNum = new Axxen.CustomControls.ATextBox();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            this.aLabel6 = new Axxen.CustomControls.ALabel();
            this.aLabel7 = new Axxen.CustomControls.ALabel();
            this.aLabel8 = new Axxen.CustomControls.ALabel();
            this.aLabel9 = new Axxen.CustomControls.ALabel();
            this.aLabel10 = new Axxen.CustomControls.ALabel();
            this.txtWo_Status = new Axxen.CustomControls.ATextBox();
            this.txtWorkorderno = new Axxen.CustomControls.ATextBox();
            this.txtItem_Code = new Axxen.CustomControls.ATextBox();
            this.txtItem_Name = new Axxen.CustomControls.ATextBox();
            this.txtWc_Name = new Axxen.CustomControls.ATextBox();
            this.txtIn_Qty_Main = new Axxen.CustomControls.ATextBox();
            this.txtOut_Qty_Main = new Axxen.CustomControls.ATextBox();
            this.txtPrd_Qty = new Axxen.CustomControls.ATextBox();
            this.aLabel_Header1 = new Axxen.CustomControls.ALabel_Header();
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.txtProcess_name = new Axxen.CustomControls.ATextBox();
            this.aLabel11 = new Axxen.CustomControls.ALabel();
            this.txtPrd_Date = new Axxen.CustomControls.ATextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNum.Enabled = false;
            this.txtNum.errorp = null;
            this.txtNum.Location = new System.Drawing.Point(21, 3);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(114, 23);
            this.txtNum.TabIndex = 0;
            this.txtNum.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Location = new System.Drawing.Point(32, 69);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(31, 15);
            this.aLabel1.TabIndex = 1;
            this.aLabel1.Text = "번호";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Location = new System.Drawing.Point(32, 107);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(79, 15);
            this.aLabel2.TabIndex = 2;
            this.aLabel2.Text = "작업지시일자";
            // 
            // aLabel3
            // 
            this.aLabel3.AutoSize = true;
            this.aLabel3.Location = new System.Drawing.Point(32, 145);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(79, 15);
            this.aLabel3.TabIndex = 3;
            this.aLabel3.Text = "작업지시상태";
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(32, 184);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(79, 15);
            this.aLabel4.TabIndex = 4;
            this.aLabel4.Text = "작업지시번호";
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Location = new System.Drawing.Point(32, 224);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(55, 15);
            this.aLabel5.TabIndex = 5;
            this.aLabel5.Text = "품목코드";
            // 
            // aLabel6
            // 
            this.aLabel6.AutoSize = true;
            this.aLabel6.Location = new System.Drawing.Point(32, 263);
            this.aLabel6.Name = "aLabel6";
            this.aLabel6.Size = new System.Drawing.Size(43, 15);
            this.aLabel6.TabIndex = 6;
            this.aLabel6.Text = "품목명";
            // 
            // aLabel7
            // 
            this.aLabel7.AutoSize = true;
            this.aLabel7.Location = new System.Drawing.Point(32, 302);
            this.aLabel7.Name = "aLabel7";
            this.aLabel7.Size = new System.Drawing.Size(43, 15);
            this.aLabel7.TabIndex = 7;
            this.aLabel7.Text = "작업장";
            // 
            // aLabel8
            // 
            this.aLabel8.AutoSize = true;
            this.aLabel8.Location = new System.Drawing.Point(33, 378);
            this.aLabel8.Name = "aLabel8";
            this.aLabel8.Size = new System.Drawing.Size(55, 15);
            this.aLabel8.TabIndex = 8;
            this.aLabel8.Text = "투입수량";
            // 
            // aLabel9
            // 
            this.aLabel9.AutoSize = true;
            this.aLabel9.Location = new System.Drawing.Point(33, 418);
            this.aLabel9.Name = "aLabel9";
            this.aLabel9.Size = new System.Drawing.Size(55, 15);
            this.aLabel9.TabIndex = 9;
            this.aLabel9.Text = "산출수량";
            // 
            // aLabel10
            // 
            this.aLabel10.AutoSize = true;
            this.aLabel10.Location = new System.Drawing.Point(33, 459);
            this.aLabel10.Name = "aLabel10";
            this.aLabel10.Size = new System.Drawing.Size(55, 15);
            this.aLabel10.TabIndex = 10;
            this.aLabel10.Text = "생산수량";
            // 
            // txtWo_Status
            // 
            this.txtWo_Status.BackColor = System.Drawing.Color.White;
            this.txtWo_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWo_Status.errorp = null;
            this.txtWo_Status.Location = new System.Drawing.Point(21, 79);
            this.txtWo_Status.Name = "txtWo_Status";
            this.txtWo_Status.ReadOnly = true;
            this.txtWo_Status.Size = new System.Drawing.Size(227, 23);
            this.txtWo_Status.TabIndex = 11;
            this.txtWo_Status.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWorkorderno
            // 
            this.txtWorkorderno.BackColor = System.Drawing.Color.White;
            this.txtWorkorderno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorkorderno.errorp = null;
            this.txtWorkorderno.Location = new System.Drawing.Point(21, 118);
            this.txtWorkorderno.Name = "txtWorkorderno";
            this.txtWorkorderno.ReadOnly = true;
            this.txtWorkorderno.Size = new System.Drawing.Size(227, 23);
            this.txtWorkorderno.TabIndex = 11;
            this.txtWorkorderno.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtItem_Code
            // 
            this.txtItem_Code.BackColor = System.Drawing.Color.White;
            this.txtItem_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem_Code.errorp = null;
            this.txtItem_Code.Location = new System.Drawing.Point(21, 158);
            this.txtItem_Code.Name = "txtItem_Code";
            this.txtItem_Code.ReadOnly = true;
            this.txtItem_Code.Size = new System.Drawing.Size(147, 23);
            this.txtItem_Code.TabIndex = 11;
            this.txtItem_Code.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtItem_Name
            // 
            this.txtItem_Name.BackColor = System.Drawing.Color.White;
            this.txtItem_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItem_Name.errorp = null;
            this.txtItem_Name.Location = new System.Drawing.Point(21, 197);
            this.txtItem_Name.Name = "txtItem_Name";
            this.txtItem_Name.ReadOnly = true;
            this.txtItem_Name.Size = new System.Drawing.Size(227, 23);
            this.txtItem_Name.TabIndex = 11;
            this.txtItem_Name.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtWc_Name
            // 
            this.txtWc_Name.BackColor = System.Drawing.Color.White;
            this.txtWc_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWc_Name.errorp = null;
            this.txtWc_Name.Location = new System.Drawing.Point(21, 236);
            this.txtWc_Name.Name = "txtWc_Name";
            this.txtWc_Name.ReadOnly = true;
            this.txtWc_Name.Size = new System.Drawing.Size(227, 23);
            this.txtWc_Name.TabIndex = 11;
            this.txtWc_Name.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtIn_Qty_Main
            // 
            this.txtIn_Qty_Main.BackColor = System.Drawing.Color.White;
            this.txtIn_Qty_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIn_Qty_Main.errorp = null;
            this.txtIn_Qty_Main.Location = new System.Drawing.Point(21, 312);
            this.txtIn_Qty_Main.Name = "txtIn_Qty_Main";
            this.txtIn_Qty_Main.ReadOnly = true;
            this.txtIn_Qty_Main.Size = new System.Drawing.Size(156, 23);
            this.txtIn_Qty_Main.TabIndex = 11;
            this.txtIn_Qty_Main.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtOut_Qty_Main
            // 
            this.txtOut_Qty_Main.BackColor = System.Drawing.Color.White;
            this.txtOut_Qty_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOut_Qty_Main.errorp = null;
            this.txtOut_Qty_Main.Location = new System.Drawing.Point(21, 352);
            this.txtOut_Qty_Main.Name = "txtOut_Qty_Main";
            this.txtOut_Qty_Main.ReadOnly = true;
            this.txtOut_Qty_Main.Size = new System.Drawing.Size(156, 23);
            this.txtOut_Qty_Main.TabIndex = 11;
            this.txtOut_Qty_Main.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // txtPrd_Qty
            // 
            this.txtPrd_Qty.BackColor = System.Drawing.Color.White;
            this.txtPrd_Qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrd_Qty.errorp = null;
            this.txtPrd_Qty.Location = new System.Drawing.Point(149, 457);
            this.txtPrd_Qty.Name = "txtPrd_Qty";
            this.txtPrd_Qty.Size = new System.Drawing.Size(156, 23);
            this.txtPrd_Qty.TabIndex = 11;
            this.txtPrd_Qty.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.AutoSize = true;
            this.aLabel_Header1.Font = new System.Drawing.Font("나눔고딕", 25F, System.Drawing.FontStyle.Bold);
            this.aLabel_Header1.Location = new System.Drawing.Point(12, 9);
            this.aLabel_Header1.Name = "aLabel_Header1";
            this.aLabel_Header1.Size = new System.Drawing.Size(145, 39);
            this.aLabel_Header1.TabIndex = 12;
            this.aLabel_Header1.Text = "실적보정";
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.SystemColors.Info;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Location = new System.Drawing.Point(200, 514);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(85, 32);
            this.aButton1.TabIndex = 13;
            this.aButton1.Text = "수정";
            this.aButton1.UseVisualStyleBackColor = false;
            this.aButton1.Click += new System.EventHandler(this.aButton1_Click);
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.SystemColors.Info;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Location = new System.Drawing.Point(312, 514);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(85, 32);
            this.aButton2.TabIndex = 13;
            this.aButton2.Text = "취소";
            this.aButton2.UseVisualStyleBackColor = false;
            this.aButton2.Click += new System.EventHandler(this.aButton2_Click);
            // 
            // txtProcess_name
            // 
            this.txtProcess_name.BackColor = System.Drawing.Color.White;
            this.txtProcess_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcess_name.errorp = null;
            this.txtProcess_name.Location = new System.Drawing.Point(21, 271);
            this.txtProcess_name.Name = "txtProcess_name";
            this.txtProcess_name.ReadOnly = true;
            this.txtProcess_name.Size = new System.Drawing.Size(227, 23);
            this.txtProcess_name.TabIndex = 15;
            this.txtProcess_name.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // aLabel11
            // 
            this.aLabel11.AutoSize = true;
            this.aLabel11.Location = new System.Drawing.Point(32, 338);
            this.aLabel11.Name = "aLabel11";
            this.aLabel11.Size = new System.Drawing.Size(43, 15);
            this.aLabel11.TabIndex = 14;
            this.aLabel11.Text = "공정명";
            // 
            // txtPrd_Date
            // 
            this.txtPrd_Date.BackColor = System.Drawing.Color.White;
            this.txtPrd_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrd_Date.errorp = null;
            this.txtPrd_Date.Location = new System.Drawing.Point(21, 41);
            this.txtPrd_Date.Name = "txtPrd_Date";
            this.txtPrd_Date.ReadOnly = true;
            this.txtPrd_Date.Size = new System.Drawing.Size(227, 23);
            this.txtPrd_Date.TabIndex = 16;
            this.txtPrd_Date.txtType = Axxen.CustomControls.TextType.Normal;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.txtPrd_Date);
            this.panel1.Controls.Add(this.txtWo_Status);
            this.panel1.Controls.Add(this.txtProcess_name);
            this.panel1.Controls.Add(this.txtWorkorderno);
            this.panel1.Controls.Add(this.txtItem_Code);
            this.panel1.Controls.Add(this.txtItem_Name);
            this.panel1.Controls.Add(this.txtWc_Name);
            this.panel1.Controls.Add(this.txtIn_Qty_Main);
            this.panel1.Controls.Add(this.txtOut_Qty_Main);
            this.panel1.Location = new System.Drawing.Point(128, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 384);
            this.panel1.TabIndex = 17;
            // 
            // PRM_PRF_001_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(431, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aLabel11);
            this.Controls.Add(this.aButton2);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aLabel_Header1);
            this.Controls.Add(this.txtPrd_Qty);
            this.Controls.Add(this.aLabel10);
            this.Controls.Add(this.aLabel9);
            this.Controls.Add(this.aLabel8);
            this.Controls.Add(this.aLabel7);
            this.Controls.Add(this.aLabel6);
            this.Controls.Add(this.aLabel5);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.aLabel3);
            this.Controls.Add(this.aLabel2);
            this.Controls.Add(this.aLabel1);
            this.Name = "PRM_PRF_001_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.Load += new System.EventHandler(this.PRM_PRF_001_1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ATextBox txtNum;
        private CustomControls.ALabel aLabel1;
        private CustomControls.ALabel aLabel2;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel4;
        private CustomControls.ALabel aLabel5;
        private CustomControls.ALabel aLabel6;
        private CustomControls.ALabel aLabel7;
        private CustomControls.ALabel aLabel8;
        private CustomControls.ALabel aLabel9;
        private CustomControls.ALabel aLabel10;
        private CustomControls.ATextBox txtWo_Status;
        private CustomControls.ATextBox txtWorkorderno;
        private CustomControls.ATextBox txtItem_Code;
        private CustomControls.ATextBox txtItem_Name;
        private CustomControls.ATextBox txtWc_Name;
        private CustomControls.ATextBox txtIn_Qty_Main;
        private CustomControls.ATextBox txtOut_Qty_Main;
        private CustomControls.ATextBox txtPrd_Qty;
        private CustomControls.ALabel_Header aLabel_Header1;
        private CustomControls.AButton aButton1;
        private CustomControls.AButton aButton2;
        private CustomControls.ATextBox txtProcess_name;
        private CustomControls.ALabel aLabel11;
        private CustomControls.ATextBox txtPrd_Date;
        private System.Windows.Forms.Panel panel1;
    }
}
