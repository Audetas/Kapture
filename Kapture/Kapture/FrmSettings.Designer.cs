namespace Kapture
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.sepHotkeys = new KUI.Controls.FlatSeperator();
            this.chkSaveLocal = new KUI.Controls.FlatCheckBox();
            this.lblForemost = new KUI.Controls.FlatLabel();
            this.lblFullscreen = new KUI.Controls.FlatLabel();
            this.lblRegion = new KUI.Controls.FlatLabel();
            this.chkOpenLink = new KUI.Controls.FlatCheckBox();
            this.lblAuthor = new KUI.Controls.FlatLabel();
            this.sepInfo = new KUI.Controls.FlatSeperator();
            this.sepOptions = new KUI.Controls.FlatSeperator();
            this.lblOptions = new KUI.Controls.FlatLabel();
            this.lblHotkeys = new KUI.Controls.FlatLabel();
            this.lblInfo = new KUI.Controls.FlatLabel();
            this.btnSave = new KUI.Controls.FlatAcceptButton();
            this.icoTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.sepTop = new System.Windows.Forms.ToolStripSeparator();
            this.btnCaptureScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaptureScreens = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaptureRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.sepMiddle = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUploadClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.sepBottom = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new KUI.Controls.FlatLabel();
            this.lbl2 = new KUI.Controls.FlatLabel();
            this.lbl3 = new KUI.Controls.FlatLabel();
            this.lbl4 = new KUI.Controls.FlatLabel();
            this.lblScreens = new KUI.Controls.FlatLabel();
            this.lbl5 = new KUI.Controls.FlatLabel();
            this.lblFile = new KUI.Controls.FlatLabel();
            this.lbl6 = new KUI.Controls.FlatLabel();
            this.lblClipboard = new KUI.Controls.FlatLabel();
            this.chkLinkToClipboard = new KUI.Controls.FlatCheckBox();
            this.chkImageToClipboard = new KUI.Controls.FlatCheckBox();
            this.lstUploads = new System.Windows.Forms.ListBox();
            this.btnClear = new KUI.Controls.FlatCancelButton();
            this.cmsTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // sepHotkeys
            // 
            this.sepHotkeys.Horizontal = true;
            this.sepHotkeys.Location = new System.Drawing.Point(5, 182);
            this.sepHotkeys.Name = "sepHotkeys";
            this.sepHotkeys.Size = new System.Drawing.Size(290, 10);
            this.sepHotkeys.TabIndex = 1;
            this.sepHotkeys.Text = "flatSeperator1";
            // 
            // chkSaveLocal
            // 
            this.chkSaveLocal.Checked = false;
            this.chkSaveLocal.Location = new System.Drawing.Point(5, 59);
            this.chkSaveLocal.Name = "chkSaveLocal";
            this.chkSaveLocal.Size = new System.Drawing.Size(290, 23);
            this.chkSaveLocal.TabIndex = 2;
            this.chkSaveLocal.Text = "Save local copy to My Pictures";
            // 
            // lblForemost
            // 
            this.lblForemost.Location = new System.Drawing.Point(111, 198);
            this.lblForemost.Name = "lblForemost";
            this.lblForemost.Size = new System.Drawing.Size(184, 23);
            this.lblForemost.TabIndex = 6;
            this.lblForemost.Text = "Capture foremost window";
            // 
            // lblFullscreen
            // 
            this.lblFullscreen.Location = new System.Drawing.Point(111, 227);
            this.lblFullscreen.Name = "lblFullscreen";
            this.lblFullscreen.Size = new System.Drawing.Size(184, 23);
            this.lblFullscreen.TabIndex = 7;
            this.lblFullscreen.Text = "Capture full screen";
            // 
            // lblRegion
            // 
            this.lblRegion.Location = new System.Drawing.Point(111, 256);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(184, 23);
            this.lblRegion.TabIndex = 8;
            this.lblRegion.Text = "Capture region";
            // 
            // chkOpenLink
            // 
            this.chkOpenLink.Checked = false;
            this.chkOpenLink.Location = new System.Drawing.Point(5, 90);
            this.chkOpenLink.Name = "chkOpenLink";
            this.chkOpenLink.Size = new System.Drawing.Size(290, 23);
            this.chkOpenLink.TabIndex = 9;
            this.chkOpenLink.Text = "Open link in browser";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAuthor.Location = new System.Drawing.Point(5, 392);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(209, 23);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Kapture Uploader by Alec Audet";
            // 
            // sepInfo
            // 
            this.sepInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sepInfo.Horizontal = true;
            this.sepInfo.Location = new System.Drawing.Point(5, 376);
            this.sepInfo.Name = "sepInfo";
            this.sepInfo.Size = new System.Drawing.Size(290, 10);
            this.sepInfo.TabIndex = 11;
            this.sepInfo.Text = "flatSeperator2";
            // 
            // sepOptions
            // 
            this.sepOptions.Horizontal = true;
            this.sepOptions.Location = new System.Drawing.Point(5, 42);
            this.sepOptions.Name = "sepOptions";
            this.sepOptions.Size = new System.Drawing.Size(290, 10);
            this.sepOptions.TabIndex = 12;
            this.sepOptions.Text = "flatSeperator3";
            // 
            // lblOptions
            // 
            this.lblOptions.Location = new System.Drawing.Point(5, 37);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(49, 16);
            this.lblOptions.TabIndex = 13;
            this.lblOptions.Text = "Options";
            // 
            // lblHotkeys
            // 
            this.lblHotkeys.Location = new System.Drawing.Point(5, 177);
            this.lblHotkeys.Name = "lblHotkeys";
            this.lblHotkeys.Size = new System.Drawing.Size(49, 16);
            this.lblHotkeys.TabIndex = 14;
            this.lblHotkeys.Text = "Hotkeys";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.Location = new System.Drawing.Point(5, 372);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 16);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "Info";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(220, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // icoTray
            // 
            this.icoTray.BalloonTipText = "Kapture is running";
            this.icoTray.BalloonTipTitle = "Kapture Uploader";
            this.icoTray.ContextMenuStrip = this.cmsTray;
            this.icoTray.Text = "Kapture Sceenshot Assistant";
            this.icoTray.Visible = true;
            // 
            // cmsTray
            // 
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings,
            this.sepTop,
            this.btnCaptureScreen,
            this.btnCaptureScreens,
            this.btnCaptureRegion,
            this.sepMiddle,
            this.btnUpload,
            this.btnUploadClipboard,
            this.sepBottom,
            this.btnExit});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(177, 176);
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(176, 22);
            this.btnSettings.Text = "Open Settings";
            // 
            // sepTop
            // 
            this.sepTop.Name = "sepTop";
            this.sepTop.Size = new System.Drawing.Size(173, 6);
            // 
            // btnCaptureScreen
            // 
            this.btnCaptureScreen.Name = "btnCaptureScreen";
            this.btnCaptureScreen.Size = new System.Drawing.Size(176, 22);
            this.btnCaptureScreen.Text = "Capture Screen";
            // 
            // btnCaptureScreens
            // 
            this.btnCaptureScreens.Name = "btnCaptureScreens";
            this.btnCaptureScreens.Size = new System.Drawing.Size(176, 22);
            this.btnCaptureScreens.Text = "Capture All Screens";
            // 
            // btnCaptureRegion
            // 
            this.btnCaptureRegion.Name = "btnCaptureRegion";
            this.btnCaptureRegion.Size = new System.Drawing.Size(176, 22);
            this.btnCaptureRegion.Text = "Capture Region";
            // 
            // sepMiddle
            // 
            this.sepMiddle.Name = "sepMiddle";
            this.sepMiddle.Size = new System.Drawing.Size(173, 6);
            // 
            // btnUpload
            // 
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(176, 22);
            this.btnUpload.Text = "Upload Image";
            // 
            // btnUploadClipboard
            // 
            this.btnUploadClipboard.Name = "btnUploadClipboard";
            this.btnUploadClipboard.Size = new System.Drawing.Size(176, 22);
            this.btnUploadClipboard.Text = "Upload Clipboard";
            // 
            // sepBottom
            // 
            this.sepBottom.Name = "sepBottom";
            this.sepBottom.Size = new System.Drawing.Size(173, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 22);
            this.btnExit.Text = "Exit";
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(5, 198);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 23);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "CTRL + SHIFT + 1";
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(5, 227);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 23);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "CTRL + SHIFT + 2";
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(5, 256);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 23);
            this.lbl3.TabIndex = 19;
            this.lbl3.Text = "CTRL + SHIFT + 3";
            // 
            // lbl4
            // 
            this.lbl4.Location = new System.Drawing.Point(5, 285);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 23);
            this.lbl4.TabIndex = 21;
            this.lbl4.Text = "CTRL + SHIFT + 4";
            // 
            // lblScreens
            // 
            this.lblScreens.Location = new System.Drawing.Point(111, 285);
            this.lblScreens.Name = "lblScreens";
            this.lblScreens.Size = new System.Drawing.Size(184, 23);
            this.lblScreens.TabIndex = 20;
            this.lblScreens.Text = "Capture all screens";
            // 
            // lbl5
            // 
            this.lbl5.Location = new System.Drawing.Point(5, 314);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(100, 23);
            this.lbl5.TabIndex = 23;
            this.lbl5.Text = "CTRL + SHIFT + 5";
            // 
            // lblFile
            // 
            this.lblFile.Location = new System.Drawing.Point(111, 314);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(184, 23);
            this.lblFile.TabIndex = 22;
            this.lblFile.Text = "Upload file";
            // 
            // lbl6
            // 
            this.lbl6.Location = new System.Drawing.Point(5, 343);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(100, 23);
            this.lbl6.TabIndex = 25;
            this.lbl6.Text = "CTRL + SHIFT + 6";
            // 
            // lblClipboard
            // 
            this.lblClipboard.Location = new System.Drawing.Point(111, 343);
            this.lblClipboard.Name = "lblClipboard";
            this.lblClipboard.Size = new System.Drawing.Size(184, 23);
            this.lblClipboard.TabIndex = 24;
            this.lblClipboard.Text = "Upload from clipboard";
            // 
            // chkLinkToClipboard
            // 
            this.chkLinkToClipboard.Checked = false;
            this.chkLinkToClipboard.Location = new System.Drawing.Point(5, 119);
            this.chkLinkToClipboard.Name = "chkLinkToClipboard";
            this.chkLinkToClipboard.Size = new System.Drawing.Size(290, 23);
            this.chkLinkToClipboard.TabIndex = 26;
            this.chkLinkToClipboard.Text = "Copy link to clipboard";
            // 
            // chkImageToClipboard
            // 
            this.chkImageToClipboard.Checked = false;
            this.chkImageToClipboard.Location = new System.Drawing.Point(5, 148);
            this.chkImageToClipboard.Name = "chkImageToClipboard";
            this.chkImageToClipboard.Size = new System.Drawing.Size(290, 23);
            this.chkImageToClipboard.TabIndex = 27;
            this.chkImageToClipboard.Text = "Copy raw image to clipboard";
            // 
            // lstUploads
            // 
            this.lstUploads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUploads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lstUploads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUploads.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUploads.ForeColor = System.Drawing.Color.White;
            this.lstUploads.FormattingEnabled = true;
            this.lstUploads.IntegralHeight = false;
            this.lstUploads.ItemHeight = 14;
            this.lstUploads.Location = new System.Drawing.Point(301, 36);
            this.lstUploads.Name = "lstUploads";
            this.lstUploads.Size = new System.Drawing.Size(259, 345);
            this.lstUploads.TabIndex = 28;
            this.lstUploads.DoubleClick += new System.EventHandler(this.lstUploads_DoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Image = null;
            this.btnClear.Location = new System.Drawing.Point(301, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(259, 24);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear Uploads";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 416);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstUploads);
            this.Controls.Add(this.chkImageToClipboard);
            this.Controls.Add(this.chkLinkToClipboard);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblClipboard);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblScreens);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblHotkeys);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.sepOptions);
            this.Controls.Add(this.sepInfo);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.chkOpenLink);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblFullscreen);
            this.Controls.Add(this.lblForemost);
            this.Controls.Add(this.chkSaveLocal);
            this.Controls.Add(this.sepHotkeys);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(565, 1000);
            this.MinimumSize = new System.Drawing.Size(565, 416);
            this.Name = "FrmSettings";
            this.Text = "Kapture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.Shown += new System.EventHandler(this.FrmSettings_Shown);
            this.VisibleChanged += new System.EventHandler(this.FrmSettings_VisibleChanged);
            this.cmsTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private KUI.Controls.FlatSeperator sepHotkeys;
        private KUI.Controls.FlatCheckBox chkSaveLocal;
        private KUI.Controls.FlatLabel lblForemost;
        private KUI.Controls.FlatLabel lblFullscreen;
        private KUI.Controls.FlatLabel lblRegion;
        private KUI.Controls.FlatCheckBox chkOpenLink;
        private KUI.Controls.FlatLabel lblAuthor;
        private KUI.Controls.FlatSeperator sepInfo;
        private KUI.Controls.FlatSeperator sepOptions;
        private KUI.Controls.FlatLabel lblOptions;
        private KUI.Controls.FlatLabel lblHotkeys;
        private KUI.Controls.FlatLabel lblInfo;
        private KUI.Controls.FlatAcceptButton btnSave;
        private System.Windows.Forms.NotifyIcon icoTray;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem btnSettings;
        private System.Windows.Forms.ToolStripSeparator sepTop;
        private System.Windows.Forms.ToolStripMenuItem btnCaptureScreen;
        private System.Windows.Forms.ToolStripMenuItem btnCaptureScreens;
        private System.Windows.Forms.ToolStripMenuItem btnCaptureRegion;
        private System.Windows.Forms.ToolStripSeparator sepBottom;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripSeparator sepMiddle;
        private System.Windows.Forms.ToolStripMenuItem btnUpload;
        private KUI.Controls.FlatLabel lbl1;
        private KUI.Controls.FlatLabel lbl2;
        private KUI.Controls.FlatLabel lbl3;
        private KUI.Controls.FlatLabel lbl4;
        private KUI.Controls.FlatLabel lblScreens;
        private KUI.Controls.FlatLabel lbl5;
        private KUI.Controls.FlatLabel lblFile;
        private KUI.Controls.FlatLabel lbl6;
        private KUI.Controls.FlatLabel lblClipboard;
        private KUI.Controls.FlatCheckBox chkLinkToClipboard;
        private KUI.Controls.FlatCheckBox chkImageToClipboard;
        private System.Windows.Forms.ListBox lstUploads;
        private System.Windows.Forms.ToolStripMenuItem btnUploadClipboard;
        private KUI.Controls.FlatCancelButton btnClear;
    }
}

