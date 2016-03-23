using Kapture.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapture
{
    class UploadedImage : IDisposable
    {
        private Image _image;
        private string _response;

        public UploadedImage(Image image, string response)
        {
            _image = image;
            _response = response;
        }

        public bool Success()
        {
            return _response.Contains("\"success\":true");
        }

        public string ID()
        {
            return _response.Split(new[] { "id\":\"" }, StringSplitOptions.None)[1].Split('\"')[0];
        }

        public string URL()
        {
            return "http://i.imgur.com/" + ID();
        }

        public string DirectURL()
        {
            return URL() + "." + Format().ToString().ToLower();
        }

        public ImageFormat Format()
        {
            return _image is Bitmap ? ImageFormat.Png : _image.RawFormat;
        }


        public void Save(string baseDirectory)
        {
            _image.Save(
                string.Format("{0}{1}.{2}",
                    baseDirectory,
                    ID(),
                    Format().ToString().ToLower()));
        }

        public void Handle()
        {
            if (!Success())
                throw new Exception("Upload was not successful:\n" + _response);

            if (Settings.Default.OpenLink)
                Process.Start(DirectURL());

            if (Settings.Default.LocalCopyDirectory != "")
                Save(Settings.Default.LocalCopyDirectory);

            if (Settings.Default.LinkToClipboard)
                Clipboard.SetText(DirectURL());

            if (Settings.Default.ImageToClipboard)
                Clipboard.SetImage(_image);

            Settings.Default.UploadedImages.Add(URL() + " " + DateTime.Now.ToShortDateString());
            Dispose();
        }

        public void Dispose()
        {
            _image.Dispose();
        }
    }
}
