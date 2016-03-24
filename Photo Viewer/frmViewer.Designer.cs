namespace Photo_Viewer
{
    partial class frmViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewer));
            this.picShowPicture = new System.Windows.Forms.PictureBox();
            this.mnuPictureContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSelectPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnEnlarge = new System.Windows.Forms.Button();
            this.btnShrink = new System.Windows.Forms.Button();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfirmOnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawBorder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrMainToolBar = new System.Windows.Forms.ToolStrip();
            this.tbbOpenPicture = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbDrawBorder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbOptions = new System.Windows.Forms.ToolStripButton();
            this.tbbGetFileAttributes = new System.Windows.Forms.ToolStripButton();
            this.tbbShowLog = new System.Windows.Forms.ToolStripButton();
            this.sbrStatusStrip = new System.Windows.Forms.StatusStrip();
            this.pnlStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).BeginInit();
            this.mnuPictureContext.SuspendLayout();
            this.mnuMainMenu.SuspendLayout();
            this.tbrMainToolBar.SuspendLayout();
            this.sbrStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picShowPicture
            // 
            this.picShowPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShowPicture.ContextMenuStrip = this.mnuPictureContext;
            this.picShowPicture.Location = new System.Drawing.Point(8, 52);
            this.picShowPicture.Name = "picShowPicture";
            this.picShowPicture.Size = new System.Drawing.Size(320, 258);
            this.picShowPicture.TabIndex = 2;
            this.picShowPicture.TabStop = false;
            this.picShowPicture.MouseLeave += new System.EventHandler(this.picShowPicture_MouseLeave);
            this.picShowPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picShowPicture_MouseMove);
            // 
            // mnuPictureContext
            // 
            this.mnuPictureContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawBorderToolStripMenuItem});
            this.mnuPictureContext.Name = "mnuPictureContext";
            this.mnuPictureContext.Size = new System.Drawing.Size(140, 26);
            this.mnuPictureContext.Opening += new System.ComponentModel.CancelEventHandler(this.mnuPictureContext_Opening);
            // 
            // drawBorderToolStripMenuItem
            // 
            this.drawBorderToolStripMenuItem.Name = "drawBorderToolStripMenuItem";
            this.drawBorderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.drawBorderToolStripMenuItem.Text = "Draw Border";
            // 
            // ofdSelectPicture
            // 
            this.ofdSelectPicture.Filter = "Windows Bitmaps|*.BMP|GIF Images|*.GIF|JPEG Files|*.JPG";
            this.ofdSelectPicture.Title = "Select Picture";
            // 
            // btnEnlarge
            // 
            this.btnEnlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnlarge.Location = new System.Drawing.Point(340, 290);
            this.btnEnlarge.Name = "btnEnlarge";
            this.btnEnlarge.Size = new System.Drawing.Size(21, 23);
            this.btnEnlarge.TabIndex = 4;
            this.btnEnlarge.Text = "+";
            this.btnEnlarge.UseVisualStyleBackColor = true;
            this.btnEnlarge.Click += new System.EventHandler(this.btnEnlarge_Click);
            // 
            // btnShrink
            // 
            this.btnShrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShrink.Location = new System.Drawing.Point(367, 290);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(21, 23);
            this.btnShrink.TabIndex = 5;
            this.btnShrink.Text = "-";
            this.btnShrink.UseVisualStyleBackColor = true;
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(394, 24);
            this.mnuMainMenu.TabIndex = 6;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenPicture,
            this.logToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.mnuConfirmOnExit,
            this.mnuQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuOpenPicture
            // 
            this.mnuOpenPicture.Name = "mnuOpenPicture";
            this.mnuOpenPicture.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenPicture.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenPicture.Text = "&Open Picture";
            this.mnuOpenPicture.Click += new System.EventHandler(this.mnuOpenPicture_Click);
            // 
            // mnuConfirmOnExit
            // 
            this.mnuConfirmOnExit.Checked = true;
            this.mnuConfirmOnExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuConfirmOnExit.Name = "mnuConfirmOnExit";
            this.mnuConfirmOnExit.Size = new System.Drawing.Size(186, 22);
            this.mnuConfirmOnExit.Text = "Confirm on Exit";
            this.mnuConfirmOnExit.Click += new System.EventHandler(this.mnuConfirmOnExit_Click_1);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(186, 22);
            this.mnuQuit.Text = "&Quit";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDrawBorder,
            this.toolStripSeparator1,
            this.mnuOptions});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // mnuDrawBorder
            // 
            this.mnuDrawBorder.Name = "mnuDrawBorder";
            this.mnuDrawBorder.Size = new System.Drawing.Size(152, 22);
            this.mnuDrawBorder.Text = "&Draw Border";
            this.mnuDrawBorder.Click += new System.EventHandler(this.mnuDrawBorder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuOptions
            // 
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(152, 22);
            this.mnuOptions.Text = "&Options";
            this.mnuOptions.Click += new System.EventHandler(this.mnuOptions_Click);
            // 
            // tbrMainToolBar
            // 
            this.tbrMainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbOpenPicture,
            this.toolStripSeparator2,
            this.tbbDrawBorder,
            this.toolStripSeparator3,
            this.tbbOptions,
            this.tbbGetFileAttributes,
            this.tbbShowLog});
            this.tbrMainToolBar.Location = new System.Drawing.Point(0, 24);
            this.tbrMainToolBar.Name = "tbrMainToolBar";
            this.tbrMainToolBar.Size = new System.Drawing.Size(394, 25);
            this.tbrMainToolBar.TabIndex = 8;
            this.tbrMainToolBar.Text = "toolStrip1";
            this.tbrMainToolBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tbrMainToolBar_ItemClicked);
            // 
            // tbbOpenPicture
            // 
            this.tbbOpenPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbOpenPicture.Image = ((System.Drawing.Image)(resources.GetObject("tbbOpenPicture.Image")));
            this.tbbOpenPicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbOpenPicture.Name = "tbbOpenPicture";
            this.tbbOpenPicture.Size = new System.Drawing.Size(23, 22);
            this.tbbOpenPicture.Text = "Open Picture";
            this.tbbOpenPicture.ToolTipText = "Open Picture";
            this.tbbOpenPicture.Click += new System.EventHandler(this.tbbOpenPicture_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbDrawBorder
            // 
            this.tbbDrawBorder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbDrawBorder.Image = ((System.Drawing.Image)(resources.GetObject("tbbDrawBorder.Image")));
            this.tbbDrawBorder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbDrawBorder.Name = "tbbDrawBorder";
            this.tbbDrawBorder.Size = new System.Drawing.Size(23, 22);
            this.tbbDrawBorder.Text = "Draw Border";
            this.tbbDrawBorder.Click += new System.EventHandler(this.tbbDrawBorder_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbOptions
            // 
            this.tbbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbbOptions.Image")));
            this.tbbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbOptions.Name = "tbbOptions";
            this.tbbOptions.Size = new System.Drawing.Size(23, 22);
            this.tbbOptions.Text = "Options";
            this.tbbOptions.Click += new System.EventHandler(this.tbbOptions_Click);
            // 
            // tbbGetFileAttributes
            // 
            this.tbbGetFileAttributes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbGetFileAttributes.Image = ((System.Drawing.Image)(resources.GetObject("tbbGetFileAttributes.Image")));
            this.tbbGetFileAttributes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbGetFileAttributes.Name = "tbbGetFileAttributes";
            this.tbbGetFileAttributes.Size = new System.Drawing.Size(23, 22);
            this.tbbGetFileAttributes.Text = "Get File Attributes";
            this.tbbGetFileAttributes.Click += new System.EventHandler(this.tbbGetFileAttributes_Click);
            // 
            // tbbShowLog
            // 
            this.tbbShowLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbShowLog.Image = ((System.Drawing.Image)(resources.GetObject("tbbShowLog.Image")));
            this.tbbShowLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbShowLog.Name = "tbbShowLog";
            this.tbbShowLog.Size = new System.Drawing.Size(23, 22);
            this.tbbShowLog.Text = "View Photo Log";
            this.tbbShowLog.Click += new System.EventHandler(this.tbbShowLog_Click);
            // 
            // sbrStatusStrip
            // 
            this.sbrStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pnlStatus});
            this.sbrStatusStrip.Location = new System.Drawing.Point(0, 314);
            this.sbrStatusStrip.Name = "sbrStatusStrip";
            this.sbrStatusStrip.Size = new System.Drawing.Size(394, 22);
            this.sbrStatusStrip.TabIndex = 9;
            this.sbrStatusStrip.Text = "Status Strikp";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(96, 17);
            this.pnlStatus.Text = "no image loaded";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(334, 262);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 10;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(334, 275);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 11;
            this.lblY.Text = "Y:";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.propertiesToolStripMenuItem.Text = "&Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(394, 336);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.sbrStatusStrip);
            this.Controls.Add(this.tbrMainToolBar);
            this.Controls.Add(this.btnShrink);
            this.Controls.Add(this.btnEnlarge);
            this.Controls.Add(this.picShowPicture);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmViewer";
            this.Text = "Photo Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewer_FormClosing);
            this.Load += new System.EventHandler(this.frmViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).EndInit();
            this.mnuPictureContext.ResumeLayout(false);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.tbrMainToolBar.ResumeLayout(false);
            this.tbrMainToolBar.PerformLayout();
            this.sbrStatusStrip.ResumeLayout(false);
            this.sbrStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShowPicture;
        private System.Windows.Forms.OpenFileDialog ofdSelectPicture;
        private System.Windows.Forms.Button btnEnlarge;
        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenPicture;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawBorder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuConfirmOnExit;
        private System.Windows.Forms.ContextMenuStrip mnuPictureContext;
        private System.Windows.Forms.ToolStripMenuItem drawBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tbrMainToolBar;
        private System.Windows.Forms.ToolStripButton tbbOpenPicture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbbDrawBorder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbbOptions;
        private System.Windows.Forms.StatusStrip sbrStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel pnlStatus;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.ToolStripButton tbbGetFileAttributes;
        public System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripButton tbbShowLog;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
    }
}

