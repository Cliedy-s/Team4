﻿namespace Axxen
{
    partial class UserSettingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPwdChack = new CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox();
            this.txtPwd = new CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPwd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.aComboBox5 = new Axxen.CustomControls.AComboBox();
            this.aComboBox1 = new Axxen.CustomControls.AComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.btnclose = new Axxen.CustomControls.AButton();
            this.cbbscreen = new Axxen.CustomControls.AComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.aComboBox2 = new Axxen.CustomControls.AComboBox();
            this.aComboBox3 = new Axxen.CustomControls.AComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.aComboBox4 = new Axxen.CustomControls.AComboBox();
            this.aComboBox6 = new Axxen.CustomControls.AComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.aComboBox7 = new Axxen.CustomControls.AComboBox();
            this.aComboBox8 = new Axxen.CustomControls.AComboBox();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "내 회원 정보를 확인해주세요.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPwdChack);
            this.tabPage3.Controls.Add(this.txtPwd);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnPwd);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(617, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "비밀번호 변경";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtPwdChack
            // 
            this.txtPwdChack.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic);
            this.txtPwdChack.ForeColor = System.Drawing.Color.Gray;
            this.txtPwdChack.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtPwdChack.Location = new System.Drawing.Point(161, 162);
            this.txtPwdChack.MaxLength = 15;
            this.txtPwdChack.Name = "txtPwdChack";
            this.txtPwdChack.PasswordChar = '*';
            this.txtPwdChack.PlaceHolderText = null;
            this.txtPwdChack.Size = new System.Drawing.Size(290, 29);
            this.txtPwdChack.TabIndex = 28;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic);
            this.txtPwd.ForeColor = System.Drawing.Color.Gray;
            this.txtPwd.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtPwd.Location = new System.Drawing.Point(161, 91);
            this.txtPwd.MaxLength = 15;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.PlaceHolderText = null;
            this.txtPwd.Size = new System.Drawing.Size(292, 29);
            this.txtPwd.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(161, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "비밀번호 확인";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(161, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "새 비밀번호";
            // 
            // btnPwd
            // 
            this.btnPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPwd.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPwd.Location = new System.Drawing.Point(223, 255);
            this.btnPwd.Name = "btnPwd";
            this.btnPwd.Size = new System.Drawing.Size(158, 43);
            this.btnPwd.TabIndex = 24;
            this.btnPwd.Text = "변경 완료";
            this.btnPwd.UseVisualStyleBackColor = false;
            this.btnPwd.Click += new System.EventHandler(this.BtnPwd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(154, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "비밀번호는 8자리 이상 15자리 이하를 입력하세요.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.ItemSize = new System.Drawing.Size(155, 50);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 389);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 49;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.panel10);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기본 정보";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.aComboBox7);
            this.panel5.Controls.Add(this.aComboBox8);
            this.panel5.Location = new System.Drawing.Point(145, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(455, 45);
            this.panel5.TabIndex = 57;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(37, 201);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(109, 45);
            this.panel6.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "새로고침단축키";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.aComboBox4);
            this.panel7.Controls.Add(this.aComboBox6);
            this.panel7.Location = new System.Drawing.Point(145, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(455, 45);
            this.panel7.TabIndex = 55;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(37, 157);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(109, 45);
            this.panel8.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(16, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "삭제단축키";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.aComboBox2);
            this.panel3.Controls.Add(this.aComboBox3);
            this.panel3.Location = new System.Drawing.Point(145, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 45);
            this.panel3.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(37, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 45);
            this.panel4.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "수정단축키";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.aComboBox5);
            this.panel1.Controls.Add(this.aComboBox1);
            this.panel1.Location = new System.Drawing.Point(145, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 45);
            this.panel1.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "~";
            // 
            // aComboBox5
            // 
            this.aComboBox5.FormattingEnabled = true;
            this.aComboBox5.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "X",
            "T",
            "U",
            "V",
            "W",
            "X",
            "W",
            "Z"});
            this.aComboBox5.Location = new System.Drawing.Point(198, 12);
            this.aComboBox5.Name = "aComboBox5";
            this.aComboBox5.Size = new System.Drawing.Size(165, 20);
            this.aComboBox5.TabIndex = 1;
            // 
            // aComboBox1
            // 
            this.aComboBox1.FormattingEnabled = true;
            this.aComboBox1.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.aComboBox1.Location = new System.Drawing.Point(6, 12);
            this.aComboBox1.Name = "aComboBox1";
            this.aComboBox1.Size = new System.Drawing.Size(165, 20);
            this.aComboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(37, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 45);
            this.panel2.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "추가단축키";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(532, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(68, 23);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Tag = "0";
            this.btnUpdate.Text = "설정";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.cbbscreen);
            this.panel9.Location = new System.Drawing.Point(145, 25);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(455, 45);
            this.panel9.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label23);
            this.panel10.Location = new System.Drawing.Point(37, 25);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(109, 45);
            this.panel10.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(16, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 17);
            this.label23.TabIndex = 5;
            this.label23.Text = "기본화면";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(558, 453);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 51;
            this.btnclose.Text = "닫기";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // cbbscreen
            // 
            this.cbbscreen.FormattingEnabled = true;
            this.cbbscreen.Location = new System.Drawing.Point(6, 12);
            this.cbbscreen.Name = "cbbscreen";
            this.cbbscreen.Size = new System.Drawing.Size(165, 20);
            this.cbbscreen.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "~";
            // 
            // aComboBox2
            // 
            this.aComboBox2.FormattingEnabled = true;
            this.aComboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "X",
            "T",
            "U",
            "V",
            "W",
            "X",
            "W",
            "Z"});
            this.aComboBox2.Location = new System.Drawing.Point(198, 12);
            this.aComboBox2.Name = "aComboBox2";
            this.aComboBox2.Size = new System.Drawing.Size(165, 20);
            this.aComboBox2.TabIndex = 4;
            // 
            // aComboBox3
            // 
            this.aComboBox3.FormattingEnabled = true;
            this.aComboBox3.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.aComboBox3.Location = new System.Drawing.Point(6, 12);
            this.aComboBox3.Name = "aComboBox3";
            this.aComboBox3.Size = new System.Drawing.Size(165, 20);
            this.aComboBox3.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "~";
            // 
            // aComboBox4
            // 
            this.aComboBox4.FormattingEnabled = true;
            this.aComboBox4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "X",
            "T",
            "U",
            "V",
            "W",
            "X",
            "W",
            "Z"});
            this.aComboBox4.Location = new System.Drawing.Point(198, 11);
            this.aComboBox4.Name = "aComboBox4";
            this.aComboBox4.Size = new System.Drawing.Size(165, 20);
            this.aComboBox4.TabIndex = 4;
            // 
            // aComboBox6
            // 
            this.aComboBox6.FormattingEnabled = true;
            this.aComboBox6.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.aComboBox6.Location = new System.Drawing.Point(6, 11);
            this.aComboBox6.Name = "aComboBox6";
            this.aComboBox6.Size = new System.Drawing.Size(165, 20);
            this.aComboBox6.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "~";
            // 
            // aComboBox7
            // 
            this.aComboBox7.FormattingEnabled = true;
            this.aComboBox7.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "X",
            "T",
            "U",
            "V",
            "W",
            "X",
            "W",
            "Z"});
            this.aComboBox7.Location = new System.Drawing.Point(198, 12);
            this.aComboBox7.Name = "aComboBox7";
            this.aComboBox7.Size = new System.Drawing.Size(165, 20);
            this.aComboBox7.TabIndex = 4;
            // 
            // aComboBox8
            // 
            this.aComboBox8.FormattingEnabled = true;
            this.aComboBox8.Items.AddRange(new object[] {
            "Ctrl",
            "Alt",
            "Shift"});
            this.aComboBox8.Location = new System.Drawing.Point(6, 12);
            this.aComboBox8.Name = "aComboBox8";
            this.aComboBox8.Size = new System.Drawing.Size(165, 20);
            this.aComboBox8.TabIndex = 3;
            // 
            // UserSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(644, 487);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "환경설정";
            this.Load += new System.EventHandler(this.UserSettingForm_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox txtPwdChack;
        private CLIP.eForm.Consent.Standard.Management.UI.PlaceHolderTextBox txtPwd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label23;
        private CustomControls.AButton btnclose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.AComboBox aComboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private CustomControls.AComboBox aComboBox5;
        private System.Windows.Forms.Label label12;
        private CustomControls.AComboBox aComboBox7;
        private CustomControls.AComboBox aComboBox8;
        private System.Windows.Forms.Label label11;
        private CustomControls.AComboBox aComboBox4;
        private CustomControls.AComboBox aComboBox6;
        private System.Windows.Forms.Label label10;
        private CustomControls.AComboBox aComboBox2;
        private CustomControls.AComboBox aComboBox3;
        private CustomControls.AComboBox cbbscreen;
    }
}
