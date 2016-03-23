using Kapture.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kapture
{
    static class Uploader
    {
        //9504c8f7ba503c36b56e0ee232035173e8ee0807
        private const string APP_ID = "1a1347e2d67ae06";
        private const string BASE_URL = "https://api.imgur.com/3/image";
        private const int MAX_URI_LENGTH = 32766;

        /// <summary>
        /// Uploads the specified image to Imgur in the specified format.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="format"></param>
        /// <returns>The resulting URL of the image</returns>
        public static UploadedImage ImgurUpload(Image image)
        {
            byte[] imageData;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image is Bitmap ? ImageFormat.Png : image.RawFormat);
                imageData = ms.ToArray();
            }

            
            string base64img = Convert.ToBase64String(imageData);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < base64img.Length; i += MAX_URI_LENGTH)
            {
                sb.Append(Uri.EscapeDataString(base64img.Substring(i, Math.Min(MAX_URI_LENGTH, base64img.Length - i))));
            }

            string uploadRequestString = "key=" + APP_ID + "&title=" + "imageTitle" +
                "&caption=" + "img" + "&image=" + sb.ToString();

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(BASE_URL);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ServicePoint.Expect100Continue = false;
            webRequest.Headers["Authorization"] = "Client-ID " + APP_ID;

            StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());
            streamWriter.Write(uploadRequestString);
            streamWriter.Close();

            WebResponse response = webRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader responseReader = new StreamReader(responseStream);

            return new UploadedImage(image, responseReader.ReadToEnd());
        }

        /*
        public static async Task<string> ImgurUpload3(Bitmap image, ImageFormat format)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Client-ID " + APP_ID);

                var formContent = new FormUrlEncodedContent(new[] {
                    new KeyValuePair<string, string>("image", BitmapToBase64(image, format)),
                    //new KeyValuePair<string, string>("name", "name"),
                    //new KeyValuePair<string, string>("title", "title"),
                    //new KeyValuePair<string, string>("description", "description")
                });
                HttpResponseMessage response = await client.PostAsync(BASE_URL + "upload", formContent);
                return await response.Content.ReadAsStringAsync();
            }
        }
        */
    }
}
