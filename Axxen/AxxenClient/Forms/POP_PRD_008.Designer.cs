namespace AxxenClient.Forms
{
    partial class POP_PRD_008
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
            this.btnUnEquip = new Axxen.CustomControls.AButton();
            this.dgvEquipedMoldList = new Axxen.CustomControls.ADataGridView();
            this.dgvEquipMoldList = new Axxen.CustomControls.ADataGridView();
            this.btnEquip = new Axxen.CustomControls.AButton();
            this.aBigHeaderBox1 = new Axxen.CustomControls.ABigHeaderBox();
            this.aBigHeaderBox2 = new Axxen.CustomControls.ABigHeaderBox();
            this.panBottom.SuspendLayout();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipedMoldList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipMoldList)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel_Header1
            // 
            this.aLabel_Header1.Text = "금형 장착/탈착 등록";
            // 
            // aPanel1
            // 
            this.panBottom.Location = new System.Drawing.Point(0, 593);
            this.panBottom.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btnUnEquip
            // 
            this.btnUnEquip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUnEquip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnUnEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnEquip.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUnEquip.Location = new System.Drawing.Point(493, 373);
            this.btnUnEquip.Name = "btnUnEquip";
            this.btnUnEquip.Size = new System.Drawing.Size(238, 165);
            this.btnUnEquip.TabIndex = 22;
            this.btnUnEquip.Text = "탈착";
            this.btnUnEquip.UseVisualStyleBackColor = false;
            this.btnUnEquip.Click += new System.EventHandler(this.btnUnEquip_Click);
            // 
            // dgvEquipedMoldList
            // 
            this.dgvEquipedMoldList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipedMoldList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipedMoldList.Location = new System.Drawing.Point(737, 160);
            this.dgvEquipedMoldList.Name = "dgvEquipedMoldList";
            this.dgvEquipedMoldList.RowHeadersWidth = 51;
            this.dgvEquipedMoldList.RowTemplate.Height = 23;
            this.dgvEquipedMoldList.Size = new System.Drawing.Size(461, 425);
            this.dgvEquipedMoldList.TabIndex = 19;
            // 
            // dgvEquipMoldList
            // 
            this.dgvEquipMoldList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipMoldList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipMoldList.Location = new System.Drawing.Point(10, 160);
            this.dgvEquipMoldList.Name = "dgvEquipMoldList";
            this.dgvEquipMoldList.RowHeadersWidth = 51;
            this.dgvEquipMoldList.RowTemplate.Height = 23;
            this.dgvEquipMoldList.Size = new System.Drawing.Size(477, 425);
            this.dgvEquipMoldList.TabIndex = 17;
            // 
            // btnEquip
            // 
            this.btnEquip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEquip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquip.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEquip.Location = new System.Drawing.Point(493, 202);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(238, 165);
            this.btnEquip.TabIndex = 26;
            this.btnEquip.Text = "장착";
            this.btnEquip.UseVisualStyleBackColor = false;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // aBigHeaderBox1
            // 
            this.aBigHeaderBox1.allfont = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aBigHeaderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aBigHeaderBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox1.HeaderBoxText = "장착 대상 금형 목록";
            this.aBigHeaderBox1.Location = new System.Drawing.Point(10, 112);
            this.aBigHeaderBox1.Name = "aBigHeaderBox1";
            this.aBigHeaderBox1.Size = new System.Drawing.Size(273, 50);
            this.aBigHeaderBox1.TabIndex = 27;
            // 
            // aBigHeaderBox2
            // 
            this.aBigHeaderBox2.allfont = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aBigHeaderBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.aBigHeaderBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aBigHeaderBox2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aBigHeaderBox2.HeaderBoxText = "장착 금형 목록";
            this.aBigHeaderBox2.Location = new System.Drawing.Point(737, 112);
            this.aBigHeaderBox2.Name = "aBigHeaderBox2";
            this.aBigHeaderBox2.Size = new System.Drawing.Size(273, 50);
            this.aBigHeaderBox2.TabIndex = 28;
            // 
            // POP_PRD_008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1210, 629);
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.btnUnEquip);
            this.Controls.Add(this.dgvEquipedMoldList);
            this.Controls.Add(this.dgvEquipMoldList);
            this.Controls.Add(this.aBigHeaderBox1);
            this.Controls.Add(this.aBigHeaderBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POP_PRD_008";
            this.Load += new System.EventHandler(this.POP_PRD_008_Load);
            this.Controls.SetChildIndex(this.aBigHeaderBox2, 0);
            this.Controls.SetChildIndex(this.aBigHeaderBox1, 0);
            this.Controls.SetChildIndex(this.aPanel2, 0);
            this.Controls.SetChildIndex(this.panBottom, 0);
            this.Controls.SetChildIndex(this.dgvEquipMoldList, 0);
            this.Controls.SetChildIndex(this.dgvEquipedMoldList, 0);
            this.Controls.SetChildIndex(this.btnUnEquip, 0);
            this.Controls.SetChildIndex(this.btnEquip, 0);
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.aPanel2.ResumeLayout(false);
            this.aPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipedMoldList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipMoldList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Axxen.CustomControls.AButton btnUnEquip;
        private Axxen.CustomControls.ADataGridView dgvEquipedMoldList;
        private Axxen.CustomControls.ADataGridView dgvEquipMoldList;
        private Axxen.CustomControls.AButton btnEquip;
        private Axxen.CustomControls.ABigHeaderBox aBigHeaderBox1;
        private Axxen.CustomControls.ABigHeaderBox aBigHeaderBox2;
    }
}
