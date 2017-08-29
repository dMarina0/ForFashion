using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Thread(() =>
            {
                while (true)
                {
                    //pictureBox1.Image = this.TakeScreenshot();
                    Bitmap image = TakeScreenshot();
                    Upload(toByte(image));
                    Thread.Sleep(1);
                }
            }).Start();
        }

        public static byte[] toByte(Image photo)
        {
            MemoryStream ms = new MemoryStream();
            photo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
       
        public  Bitmap TakeScreenshot()
        {
            Rectangle totalSize = Rectangle.Empty;

            foreach (Screen s in Screen.AllScreens)
                totalSize = Rectangle.Union(totalSize, s.Bounds);

            Bitmap screenShotBMP = new Bitmap(totalSize.Width, totalSize.Height, PixelFormat.Format32bppArgb);

            Graphics screenShotGraphics = Graphics.FromImage(screenShotBMP);

            screenShotGraphics.CopyFromScreen(totalSize.X, totalSize.Y, 0, 0, totalSize.Size,
            CopyPixelOperation.SourceCopy);

            screenShotGraphics.Dispose();

            return screenShotBMP;
        }
        private void Upload()
        {
            var actionUrl = "http://localhost:5646/api/Upload";
            var paramFileBytes = toByte(pictureBox1.Image);
            HttpContent bytesContent = new ByteArrayContent(paramFileBytes);
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(bytesContent, "pictureBox1", "pictureBox1.Jpeg");
                var response = client.PostAsync(actionUrl, formData).Result;
                //if (!response.IsSuccessStatusCode)
                //{
                //    return null;
                //}
                //return response.Content.ReadAsStreamAsync().Result;
            }
        }
        private void Upload(byte[] paramFileBytes)
        {
            var actionUrl = "http://localhost:5646/api/Upload";
            HttpContent bytesContent = new ByteArrayContent(paramFileBytes);
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            {
                formData.Add(bytesContent, "pictureBox1", "pictureBox1.Jpeg");
                var response = client.PostAsync(actionUrl, formData).Result;
                //if (!response.IsSuccessStatusCode)
                //{
                //    return null;
                //}
                //return response.Content.ReadAsStreamAsync().Result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.TakeScreenshot();
            Upload();
        }
    }
}
