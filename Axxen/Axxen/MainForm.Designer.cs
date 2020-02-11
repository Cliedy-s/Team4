namespace Axxen
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.aPanel1 = new Axxen.CustomControls.APanel();
            this.btnManuReflash = new System.Windows.Forms.Button();
            this.aPanel2 = new Axxen.CustomControls.APanel();
            this.btnBookmark = new System.Windows.Forms.Button();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.ctmBookMark = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.즐겨찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.전체닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aLabel2 = new Axxen.CustomControls.ALabel();
            this.lblSubtitle = new Axxen.CustomControls.ALabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnBookmark = new Axxen.CustomControls.APanel();
            this.toolbook = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtoncencle = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tvBookMark = new System.Windows.Forms.TreeView();
            this.메모장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계산기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지뢰찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.문자표ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.aPanel1.SuspendLayout();
            this.aPanel2.SuspendLayout();
            this.ctmBookMark.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnBookmark.SuspendLayout();
            this.toolbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.aPanel1);
            this.panelMenu.Controls.Add(this.aPanel2);
            this.panelMenu.Controls.Add(this.tvMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 131);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 833);
            this.panelMenu.TabIndex = 5;
            // 
            // aPanel1
            // 
            this.aPanel1.Controls.Add(this.btnManuReflash);
            this.aPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.aPanel1.Location = new System.Drawing.Point(0, 0);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.Size = new System.Drawing.Size(267, 43);
            this.aPanel1.TabIndex = 10;
            // 
            // btnManuReflash
            // 
            this.btnManuReflash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.btnManuReflash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManuReflash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnManuReflash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManuReflash.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnManuReflash.ForeColor = System.Drawing.Color.Black;
            this.btnManuReflash.Location = new System.Drawing.Point(0, 0);
            this.btnManuReflash.Name = "btnManuReflash";
            this.btnManuReflash.Size = new System.Drawing.Size(267, 43);
            this.btnManuReflash.TabIndex = 8;
            this.btnManuReflash.Text = "메뉴";
            this.btnManuReflash.UseVisualStyleBackColor = false;
            this.btnManuReflash.Click += new System.EventHandler(this.BtnManuReflash_Click);
            // 
            // aPanel2
            // 
            this.aPanel2.Controls.Add(this.btnBookmark);
            this.aPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aPanel2.Location = new System.Drawing.Point(0, 790);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.Size = new System.Drawing.Size(267, 43);
            this.aPanel2.TabIndex = 9;
            // 
            // btnBookmark
            // 
            this.btnBookmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBookmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBookmark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookmark.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBookmark.Location = new System.Drawing.Point(0, 0);
            this.btnBookmark.Name = "btnBookmark";
            this.btnBookmark.Size = new System.Drawing.Size(267, 43);
            this.btnBookmark.TabIndex = 8;
            this.btnBookmark.Text = "즐겨찾기";
            this.btnBookmark.UseVisualStyleBackColor = false;
            this.btnBookmark.Click += new System.EventHandler(this.BtnBookmark_Click);
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.White;
            this.tvMenu.ContextMenuStrip = this.ctmBookMark;
            this.tvMenu.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tvMenu.Location = new System.Drawing.Point(3, 297);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(261, 491);
            this.tvMenu.TabIndex = 7;
            this.tvMenu.DoubleClick += new System.EventHandler(this.TvMenu_DoubleClick);
            // 
            // ctmBookMark
            // 
            this.ctmBookMark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.즐겨찾기ToolStripMenuItem});
            this.ctmBookMark.Name = "contextMenuStrip";
            this.ctmBookMark.Size = new System.Drawing.Size(123, 26);
            // 
            // 즐겨찾기ToolStripMenuItem
            // 
            this.즐겨찾기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("즐겨찾기ToolStripMenuItem.Image")));
            this.즐겨찾기ToolStripMenuItem.Name = "즐겨찾기ToolStripMenuItem";
            this.즐겨찾기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.즐겨찾기ToolStripMenuItem.Text = "즐겨찾기";
            this.즐겨찾기ToolStripMenuItem.Click += new System.EventHandler(this.즐겨찾기ToolStripMenuItem_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl2.Location = new System.Drawing.Point(267, 131);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1355, 24);
            this.tabControl2.TabIndex = 12;
            this.tabControl2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem);
            this.tabControl2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl2_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전체닫기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // 전체닫기ToolStripMenuItem
            // 
            this.전체닫기ToolStripMenuItem.Name = "전체닫기ToolStripMenuItem";
            this.전체닫기ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.전체닫기ToolStripMenuItem.Text = "전체 닫기";
            this.전체닫기ToolStripMenuItem.Click += new System.EventHandler(this.전체닫기ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.aLabel2);
            this.panel1.Controls.Add(this.lblSubtitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(267, 918);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 46);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // aLabel2
            // 
            this.aLabel2.AutoSize = true;
            this.aLabel2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.aLabel2.Location = new System.Drawing.Point(53, 18);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(73, 17);
            this.aLabel2.TabIndex = 20;
            this.aLabel2.Text = "위치 정보 :";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubtitle.Location = new System.Drawing.Point(132, 18);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(0, 17);
            this.lblSubtitle.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메모장ToolStripMenuItem,
            this.계산기ToolStripMenuItem,
            this.지뢰찾기ToolStripMenuItem,
            this.문자표ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1622, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.BackgroundImage = global::Axxen.Properties.Resources.MianLoGo;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(250, 70);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 97);
            // 
            // tsbInsert
            // 
            this.tsbInsert.AutoSize = false;
            this.tsbInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsert.Image")));
            this.tsbInsert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbInsert.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsert.Name = "tsbInsert";
            this.tsbInsert.Size = new System.Drawing.Size(50, 57);
            this.tsbInsert.Text = "추가";
            this.tsbInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbInsert.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsert.ToolTipText = "추가";
            this.tsbInsert.Click += new System.EventHandler(this.TsbInsert_Click);
            // 
            // tsbtnUpdate
            // 
            this.tsbtnUpdate.AutoSize = false;
            this.tsbtnUpdate.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdate.Image")));
            this.tsbtnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdate.Name = "tsbtnUpdate";
            this.tsbtnUpdate.Size = new System.Drawing.Size(50, 57);
            this.tsbtnUpdate.Text = "수정";
            this.tsbtnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnUpdate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnUpdate.ToolTipText = "수정";
            this.tsbtnUpdate.Click += new System.EventHandler(this.TsbtnUpdate_Click_1);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.AutoSize = false;
            this.tsbtnDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(50, 57);
            this.tsbtnDelete.Text = "삭제";
            this.tsbtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnDelete.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.ToolTipText = "삭제";
            this.tsbtnDelete.Click += new System.EventHandler(this.TsbtnDelete_Click);
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.AutoSize = false;
            this.tsbtnRefresh.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(60, 57);
            this.tsbtnRefresh.Text = "새로고침";
            this.tsbtnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnRefresh.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnRefresh.ToolTipText = "새로고침";
            this.tsbtnRefresh.Click += new System.EventHandler(this.TsbtnRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 97);
            // 
            // toolStripButtonSetting
            // 
            this.toolStripButtonSetting.AutoSize = false;
            this.toolStripButtonSetting.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetting.Image")));
            this.toolStripButtonSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButtonSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetting.Name = "toolStripButtonSetting";
            this.toolStripButtonSetting.Size = new System.Drawing.Size(85, 85);
            this.toolStripButtonSetting.Text = "환경설정";
            this.toolStripButtonSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButtonSetting.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButtonSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSetting.ToolTipText = "환경설정";
            this.toolStripButtonSetting.Click += new System.EventHandler(this.ToolStripButtonSetting_Click);
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(111, 94);
            this.toolStripLabel.Text = "환영합니다.";
            this.toolStripLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(239)))), ((int)(((byte)(245)))));
            this.toolStrip1.BackgroundImage = global::Axxen.Properties.Resources.MainBar;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tsbInsert,
            this.tsbtnUpdate,
            this.tsbtnDelete,
            this.tsbtnRefresh,
            this.toolStripSeparator2,
            this.toolStripButtonSetting,
            this.toolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1622, 97);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnBookmark
            // 
            this.pnBookmark.BackColor = System.Drawing.Color.White;
            this.pnBookmark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBookmark.Controls.Add(this.toolbook);
            this.pnBookmark.Controls.Add(this.tvBookMark);
            this.pnBookmark.Location = new System.Drawing.Point(268, 450);
            this.pnBookmark.Name = "pnBookmark";
            this.pnBookmark.Size = new System.Drawing.Size(253, 467);
            this.pnBookmark.TabIndex = 7;
            this.pnBookmark.Visible = false;
            // 
            // toolbook
            // 
            this.toolbook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButtoncencle,
            this.toolStripLabel1});
            this.toolbook.Location = new System.Drawing.Point(0, 0);
            this.toolbook.Name = "toolbook";
            this.toolbook.Size = new System.Drawing.Size(251, 25);
            this.toolbook.TabIndex = 1;
            this.toolbook.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButtoncencle
            // 
            this.toolStripButtoncencle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtoncencle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtoncencle.Image")));
            this.toolStripButtoncencle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtoncencle.Name = "toolStripButtoncencle";
            this.toolStripButtoncencle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtoncencle.Text = "취소";
            this.toolStripButtoncencle.ToolTipText = "닫기";
            this.toolStripButtoncencle.Click += new System.EventHandler(this.ToolStripButtoncencle_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "즐겨찾기";
            // 
            // tvBookMark
            // 
            this.tvBookMark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvBookMark.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tvBookMark.Location = new System.Drawing.Point(0, 27);
            this.tvBookMark.Name = "tvBookMark";
            this.tvBookMark.Size = new System.Drawing.Size(251, 438);
            this.tvBookMark.TabIndex = 0;
            this.tvBookMark.DoubleClick += new System.EventHandler(this.TvBookMark_DoubleClick);
            // 
            // 메모장ToolStripMenuItem
            // 
            this.메모장ToolStripMenuItem.Name = "메모장ToolStripMenuItem";
            this.메모장ToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
            this.메모장ToolStripMenuItem.Text = "메모장";
            this.메모장ToolStripMenuItem.Click += new System.EventHandler(this.메모장ToolStripMenuItem_Click);
            // 
            // 계산기ToolStripMenuItem
            // 
            this.계산기ToolStripMenuItem.Name = "계산기ToolStripMenuItem";
            this.계산기ToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
            this.계산기ToolStripMenuItem.Text = "계산기";
            this.계산기ToolStripMenuItem.Click += new System.EventHandler(this.계산기ToolStripMenuItem_Click);
            // 
            // 지뢰찾기ToolStripMenuItem
            // 
            this.지뢰찾기ToolStripMenuItem.Name = "지뢰찾기ToolStripMenuItem";
            this.지뢰찾기ToolStripMenuItem.Size = new System.Drawing.Size(67, 30);
            this.지뢰찾기ToolStripMenuItem.Text = "지뢰찾기";
            this.지뢰찾기ToolStripMenuItem.Click += new System.EventHandler(this.지뢰찾기ToolStripMenuItem_Click);
            // 
            // 문자표ToolStripMenuItem
            // 
            this.문자표ToolStripMenuItem.Name = "문자표ToolStripMenuItem";
            this.문자표ToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
            this.문자표ToolStripMenuItem.Text = "문자표";
            this.문자표ToolStripMenuItem.Click += new System.EventHandler(this.문자표ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 964);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.pnBookmark);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = " ";
            this.Text = "SPOK-MES";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.aPanel1.ResumeLayout(false);
            this.aPanel2.ResumeLayout(false);
            this.ctmBookMark.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnBookmark.ResumeLayout(false);
            this.pnBookmark.PerformLayout();
            this.toolbook.ResumeLayout(false);
            this.toolbook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TreeView tvMenu;
        private CustomControls.APanel aPanel2;
        private System.Windows.Forms.Button btnBookmark;
        private CustomControls.APanel pnBookmark;
        private System.Windows.Forms.ContextMenuStrip ctmBookMark;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기ToolStripMenuItem;
        private CustomControls.APanel aPanel1;
        private CustomControls.ALabel lblSubtitle;
        private CustomControls.ALabel aLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView tvBookMark;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 전체닫기ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.ToolStrip toolbook;
        private System.Windows.Forms.ToolStripButton toolStripButtoncencle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInsert;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetting;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.Button btnManuReflash;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem 메모장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계산기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지뢰찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 문자표ToolStripMenuItem;
    }
}