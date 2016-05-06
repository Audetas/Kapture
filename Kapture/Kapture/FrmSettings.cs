using Kapture.Properties;
using KUI.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapture
{
    public partial class FrmSettings : FlatWindow
    {
        private const int ID_FOREMOST = 1;
        private const int ID_SCREEN = 2;
        private const int ID_REGION = 3;
        private const int ID_SCREENS = 4;
        private const int ID_FILE = 5;
        private const int ID_CLIPBOARD = 7;
        private bool _hide = true;
        SoundPlayer _player = new SoundPlayer(Resources.Chime);

        public FrmSettings()
        {
            InitializeComponent();
            icoTray.Icon = Resources.Icon;
            icoTray.ShowBalloonTip(1000);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                switch (m.WParam.ToInt32())
                {
                    case ID_FOREMOST:
                        CaptureWindow(); break;
                    case ID_SCREEN:
                        CaptureScreen(); break;
                    case ID_REGION:
                        CaptureRegion(); break;
                    case ID_SCREENS:
                        CaptureScreens(); break;
                    case ID_FILE:
                        UploadFile(); break;
                    case ID_CLIPBOARD:
                        UploadClipboard(); break;
                }
            }
        }

        private void FrmSettings_Load(object sender, EventArgs ea)
        {
            chkImageToClipboard.Checked = Settings.Default.ImageToClipboard;
            chkLinkToClipboard.Checked = Settings.Default.LinkToClipboard;
            chkOpenLink.Checked = Settings.Default.OpenLink;
            chkSaveLocal.Checked = Settings.Default.LocalCopyDirectory != "";

            Win32.RegisterHotKey(Handle, ID_FOREMOST , Win32.MOD_CONTROL | Win32.MOD_SHIFT, Keys.D1.GetHashCode());
            Win32.RegisterHotKey(Handle, ID_SCREEN   , Win32.MOD_CONTROL | Win32.MOD_SHIFT, Keys.D2.GetHashCode());
            Win32.RegisterHotKey(Handle, ID_REGION   , Win32.MOD_CONTROL | Win32.MOD_SHIFT, Keys.D3.GetHashCode());
            Win32.RegisterHotKey(Handle, ID_SCREENS  , Win32.MOD_CONTROL | Win32.MOD_SHIFT, Keys.D4.GetHashCode());
            Win32.RegisterHotKey(Handle, ID_FILE     , Win32.MOD_CONTROL | Win32.MOD_SHIFT, Keys.D5.GetHashCode());
            Win32.RegisterHotKey(Handle, ID_CLIPBOARD, Win32.MOD_CONTROL | Win32.MOD_SHIFT, Keys.D6.GetHashCode());

            btnCaptureRegion.Click += (s, e) => CaptureRegion();
            btnCaptureScreen.Click += (s, e) => CaptureScreen();
            btnCaptureScreens.Click += (s, e) => CaptureScreens();
            btnUpload.Click += (s, e) => UploadFile();
            btnUploadClipboard.Click += (s, e) => UploadClipboard();
            icoTray.MouseDoubleClick += (s, e) => Show();
            btnSettings.Click += (s, e) => Show();
            btnExit.Click += (s, e) => Hide();
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Win32.UnregisterHotKey(Handle, ID_FOREMOST);
            Win32.UnregisterHotKey(Handle, ID_SCREEN);
            Win32.UnregisterHotKey(Handle, ID_REGION);
            Win32.UnregisterHotKey(Handle, ID_SCREENS);
            Win32.UnregisterHotKey(Handle, ID_FILE);
            Win32.UnregisterHotKey(Handle, ID_CLIPBOARD);
        }

        private void FrmSettings_Shown(object sender, EventArgs e)
        {
            if (_hide && !Settings.Default.FirstTime) Hide();
            _hide = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.FirstTime = false;
            Settings.Default.LocalCopyDirectory = chkSaveLocal.Checked
                ? Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                : string.Empty;
            Settings.Default.OpenLink = chkOpenLink.Checked;
            Settings.Default.LinkToClipboard = chkLinkToClipboard.Checked;
            Settings.Default.ImageToClipboard = chkImageToClipboard.Checked;
            Settings.Default.Save();

            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstUploads_DoubleClick(object sender, EventArgs e)
        {
            if (lstUploads.SelectedItem != null)
                Process.Start(lstUploads.SelectedItem.ToString().Split(' ')[0]);
        }

        private void FrmSettings_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                lstUploads.SuspendLayout();
                lstUploads.Items.Clear();
                lstUploads.Items.AddRange(Settings.Default.UploadedImages.Cast<string>().ToArray());
                lstUploads.ResumeLayout();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Settings.Default.UploadedImages.Clear();
            lstUploads.Items.Clear();
        }

        #region Screenshotting
        public void BeginWork(Action task)
        {
            icoTray.Icon = Resources.Icon_Loading;
            try
            {
                task();

                if (Settings.Default.NotifyCompletion)
                    icoTray.ShowBalloonTip(1500, "Kapture", "Upload Complete!", ToolTipIcon.None);
                else
                    _player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "There was a problem while taking the screenshot:\n\n" + ex, "Kapture",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            icoTray.Icon = Resources.Icon;
        }

        public void CaptureWindow()
        {
            BeginWork(() =>
            {
                Uploader.ImgurUpload(
                    ScreenShotter.CaptureWindow(Win32.GetForegroundWindow())
                ).Handle();
            });
        }

        public void CaptureScreen()
        {
            BeginWork(() =>
            {
                Uploader.ImgurUpload(
                    ScreenShotter.CaptureScreen(Cursor.Position)
                ).Handle();
            });
        }

        public void CaptureScreens()
        {
            BeginWork(() =>
            {
                Uploader.ImgurUpload(
                    ScreenShotter.CaptureScreens()
                ).Handle();
            });
        }

        public void CaptureRegion()
        {
            FrmSelect select = new FrmSelect(Screen.FromPoint(Cursor.Position));
            select.ShowDialog();

            if (select.DialogResult == DialogResult.OK)
            {
                BeginWork(() =>
                {
                    Uploader.ImgurUpload(
                        ScreenShotter.CaptureRegion(
#pragma warning disable CS1690 // Accessing a member on a field of a marshal-by-reference class may cause a runtime exception
                            select.Selected.X,
                            select.Selected.Y,
                            select.Selected.Width,
                            select.Selected.Height
#pragma warning restore CS1690 // Accessing a member on a field of a marshal-by-reference class may cause a runtime exception
                        )
                    ).Handle();
                });
            }
        }

        public void UploadFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif"; ;

            if (open.ShowDialog() == DialogResult.OK)
            {
                BeginWork(() =>
                {
                    Uploader.ImgurUpload(
                        Image.FromFile(open.FileName)
                    ).Handle();
                });
            }
        }

        public void UploadClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                BeginWork(() =>
                {
                    Uploader.ImgurUpload(
                        Clipboard.GetImage()
                    ).Handle();
                });
            }
        }
        #endregion
    }
}
