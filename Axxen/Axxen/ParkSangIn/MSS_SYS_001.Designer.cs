namespace Axxen
{
    partial class MSS_SYS_001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSS_SYS_001));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aLabel3 = new Axxen.CustomControls.ALabel();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.aLabel1 = new Axxen.CustomControls.ALabel();
            this.tvMenu = new Axxen.CustomControls.ATreeView();
            this.dgvSon = new Axxen.CustomControls.ADataGridView();
            this.dgvParent = new Axxen.CustomControls.ADataGridView();
            this.aLabel4 = new Axxen.CustomControls.ALabel();
            this.aLabel5 = new Axxen.CustomControls.ALabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(598, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 22);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 350);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // aLabel3
            // 
            this.aLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabel3.AutoSize = true;
            this.aLabel3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel3.Location = new System.Drawing.Point(623, 9);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(96, 21);
            this.aLabel3.TabIndex = 23;
            this.aLabel3.Text = "메뉴 트리뷰";
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel2.Location = new System.Drawing.Point(30, 351);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(112, 21);
            this.aLabel2.TabIndex = 21;
            this.aLabel2.Text = "메뉴 하위목록";
            // 
            // aLabel1
            // 
            this.aLabel1.AutoSize = true;
            this.aLabel1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.aLabel1.Location = new System.Drawing.Point(30, 13);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(74, 21);
            this.aLabel1.TabIndex = 19;
            this.aLabel1.Text = "메뉴모듈";
            // 
            // tvMenu
            // 
            this.tvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMenu.Location = new System.Drawing.Point(594, 40);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(693, 676);
            this.tvMenu.TabIndex = 2;
            this.tvMenu.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TvMenu_ItemDrag);
            this.tvMenu.DragDrop += new System.Windows.Forms.DragEventHandler(this.TvMenu_DragDrop);
            this.tvMenu.DragEnter += new System.Windows.Forms.DragEventHandler(this.TvMenu_DragEnter);
            this.tvMenu.DragOver += new System.Windows.Forms.DragEventHandler(this.TvMenu_DragOver);
            this.tvMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TvMenu_MouseDown);
            // 
            // dgvSon
            // 
            this.dgvSon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSon.Location = new System.Drawing.Point(3, 375);
            this.dgvSon.Name = "dgvSon";
            this.dgvSon.RowTemplate.Height = 23;
            this.dgvSon.Size = new System.Drawing.Size(585, 341);
            this.dgvSon.TabIndex = 1;
            // 
            // dgvParent
            // 
            this.dgvParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParent.Location = new System.Drawing.Point(4, 40);
            this.dgvParent.Name = "dgvParent";
            this.dgvParent.RowTemplate.Height = 23;
            this.dgvParent.Size = new System.Drawing.Size(585, 304);
            this.dgvParent.TabIndex = 0;
            this.dgvParent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParent_CellDoubleClick);
            // 
            // aLabel4
            // 
            this.aLabel4.AutoSize = true;
            this.aLabel4.Location = new System.Drawing.Point(110, 15);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(48, 15);
            this.aLabel4.TabIndex = 25;
            this.aLabel4.Text = "aLabel4";
            // 
            // aLabel5
            // 
            this.aLabel5.AutoSize = true;
            this.aLabel5.Location = new System.Drawing.Point(148, 356);
            this.aLabel5.Name = "aLabel5";
            this.aLabel5.Size = new System.Drawing.Size(48, 15);
            this.aLabel5.TabIndex = 26;
            this.aLabel5.Text = "aLabel5";
            // 
            // MSS_SYS_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(1299, 719);
            this.Controls.Add(this.aLabel5);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.aLabel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.aLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.dgvSon);
            this.Controls.Add(this.dgvParent);
            this.Name = "MSS_SYS_001";
            this.Text = "메뉴관리";
            this.Load += new System.EventHandler(this.MSS_SYS_001_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ADataGridView dgvParent;
        private CustomControls.ADataGridView dgvSon;
        private CustomControls.ATreeView tvMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.ALabel aLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.ALabel aLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.ALabel aLabel3;
        private CustomControls.ALabel aLabel4;
        private CustomControls.ALabel aLabel5;
    }
}
