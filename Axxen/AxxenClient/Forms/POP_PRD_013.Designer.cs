﻿namespace AxxenClient.Forms
{
    partial class POP_PRD_013
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
            this.aButton1 = new Axxen.CustomControls.AButton();
            this.aDataGridView2 = new Axxen.CustomControls.ADataGridView();
            this.aDataGridView1 = new Axxen.CustomControls.ADataGridView();
            this.aButton2 = new Axxen.CustomControls.AButton();
            this.aButton3 = new Axxen.CustomControls.AButton();
            this.aBigHeaderBox1 = new Axxen.CustomControls.ABigHeaderBox();
            this.aBigHeaderBox2 = new Axxen.CustomControls.ABigHeaderBox();
            this.aBigTextBox_Searchable1 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.aBigTextBox_Searchable2 = new Axxen.CustomControls.ABigTextBox_Searchable();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "작업자 할당";
            // 
            // aPanel1
            // 
            this.aPanel1.Location = new System.Drawing.Point(0, 593);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // aButton1
            // 
            this.aButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton1.Location = new System.Drawing.Point(519, 460);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(154, 123);
            this.aButton1.TabIndex = 29;
            this.aButton1.Text = "작업자\r\n전체 해제\r\n→";
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aDataGridView2
            // 
            this.aDataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView2.Location = new System.Drawing.Point(679, 196);
            this.aDataGridView2.Name = "aDataGridView2";
            this.aDataGridView2.RowHeadersWidth = 51;
            this.aDataGridView2.RowTemplate.Height = 23;
            this.aDataGridView2.Size = new System.Drawing.Size(521, 389);
            this.aDataGridView2.TabIndex = 28;
            // 
            // aDataGridView1
            // 
            this.aDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridView1.Location = new System.Drawing.Point(12, 196);
            this.aDataGridView1.Name = "aDataGridView1";
            this.aDataGridView1.RowHeadersWidth = 51;
            this.aDataGridView1.RowTemplate.Height = 23;
            this.aDataGridView1.Size = new System.Drawing.Size(501, 389);
            this.aDataGridView1.TabIndex = 27;
            // 
            // aButton2
            // 
            this.aButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton2.Location = new System.Drawing.Point(519, 329);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(154, 123);
            this.aButton2.TabIndex = 35;
            this.aButton2.Text = "작업자\r\n해제\r\n→";
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // aButton3
            // 
            this.aButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.aButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aButton3.Location = new System.Drawing.Point(519, 200);
            this.aButton3.Name = "aButton3";
            this.aButton3.Size = new System.Drawing.Size(154, 123);
            this.aButton3.TabIndex = 36;
            this.aButton3.Text = "작업자\r\n할당\r\n←";
            this.aButton3.UseVisualStyleBackColor = false;
            // 
            // aBigHeaderBox1
            // 
            this.aBigHeaderBox1.allfont = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aBigHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aBigHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox1.HeaderBoxText = "할당 작업자";
            this.aBigHeaderBox1.Location = new System.Drawing.Point(12, 150);
            this.aBigHeaderBox1.Name = "aBigHeaderBox1";
            this.aBigHeaderBox1.Size = new System.Drawing.Size(273, 50);
            this.aBigHeaderBox1.TabIndex = 37;
            // 
            // aBigHeaderBox2
            // 
            this.aBigHeaderBox2.allfont = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aBigHeaderBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aBigHeaderBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aBigHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox2.HeaderBoxText = "할당 대상 작업자";
            this.aBigHeaderBox2.Location = new System.Drawing.Point(679, 150);
            this.aBigHeaderBox2.Name = "aBigHeaderBox2";
            this.aBigHeaderBox2.Size = new System.Drawing.Size(273, 50);
            this.aBigHeaderBox2.TabIndex = 38;
            // 
            // aBigTextBox_Searchable1
            // 
            this.aBigTextBox_Searchable1.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable1.LabelText = "작업장";
            this.aBigTextBox_Searchable1.Location = new System.Drawing.Point(12, 104);
            this.aBigTextBox_Searchable1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_Searchable1.Name = "aBigTextBox_Searchable1";
            this.aBigTextBox_Searchable1.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_Searchable1.TabIndex = 39;
            this.aBigTextBox_Searchable1.TextBoxText = "";
            this.aBigTextBox_Searchable1.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // aBigTextBox_Searchable2
            // 
            this.aBigTextBox_Searchable2.allfont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigTextBox_Searchable2.LabelText = "할당 작업자 수";
            this.aBigTextBox_Searchable2.Location = new System.Drawing.Point(489, 104);
            this.aBigTextBox_Searchable2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aBigTextBox_Searchable2.Name = "aBigTextBox_Searchable2";
            this.aBigTextBox_Searchable2.Size = new System.Drawing.Size(469, 42);
            this.aBigTextBox_Searchable2.TabIndex = 40;
            this.aBigTextBox_Searchable2.TextBoxText = "";
            this.aBigTextBox_Searchable2.TextBoxType = Axxen.CustomControls.type.Normal;
            // 
            // POP_PRD_013
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.aButton3);
            this.Controls.Add(this.aButton2);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aDataGridView2);
            this.Controls.Add(this.aDataGridView1);
            this.Controls.Add(this.aBigHeaderBox2);
            this.Controls.Add(this.aBigHeaderBox1);
            this.Controls.Add(this.aBigTextBox_Searchable2);
            this.Controls.Add(this.aBigTextBox_Searchable1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_013";
            this.Controls.SetChildIndex(this.aBigTextBox_Searchable1, 0);
            this.Controls.SetChildIndex(this.aBigTextBox_Searchable2, 0);
            this.Controls.SetChildIndex(this.aBigHeaderBox1, 0);
            this.Controls.SetChildIndex(this.aBigHeaderBox2, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.aPanel1, 0);
            this.Controls.SetChildIndex(this.aDataGridView1, 0);
            this.Controls.SetChildIndex(this.aDataGridView2, 0);
            this.Controls.SetChildIndex(this.aButton1, 0);
            this.Controls.SetChildIndex(this.aButton2, 0);
            this.Controls.SetChildIndex(this.aButton3, 0);
            this.aPanel1.ResumeLayout(false);
            this.aPanel1.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.AButton aButton1;
        private Axxen.CustomControls.ADataGridView aDataGridView2;
        private Axxen.CustomControls.ADataGridView aDataGridView1;
        private Axxen.CustomControls.AButton aButton2;
        private Axxen.CustomControls.AButton aButton3;
        private Axxen.CustomControls.ABigHeaderBox aBigHeaderBox1;
        private Axxen.CustomControls.ABigHeaderBox aBigHeaderBox2;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable1;
        private Axxen.CustomControls.ABigTextBox_Searchable aBigTextBox_Searchable2;
    }
}
