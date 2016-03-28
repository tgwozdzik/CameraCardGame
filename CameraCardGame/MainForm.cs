using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using AForge.Video;
using AForge.Video.DirectShow;

using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace CameraCardGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void showCameraVideo_Click(object sender, EventArgs e)
        {
            MJPEGStream mjpegStream = new MJPEGStream("http://" + inputURL.Text + "/mjpegfeed?640x480");

            OpenVideoSource(mjpegStream);
        }

        private void OpenVideoSource(IVideoSource source)
        {
            this.Cursor = Cursors.WaitCursor;
            
            CloseCurrentVideoSource();

            videoPlayer.VideoSource = source;
            videoPlayer.Start();
            
            this.Cursor = Cursors.Default;
        }

        private void CloseCurrentVideoSource()
        {
            if (videoPlayer.VideoSource != null)
            {
                videoPlayer.SignalToStop();

                for (int i = 0; i < 30; i++)
                {
                    if (!videoPlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoPlayer.IsRunning)
                {
                    videoPlayer.Stop();
                }

                videoPlayer.VideoSource = null;
            }
        }

        private void closeCameraVideo_Click(object sender, EventArgs e)
        {
            CloseCurrentVideoSource();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Bitmap frame = videoPlayer.GetCurrentVideoFrame();

            string decodedData = "";

            try 
            {
                ZXing.BarcodeReader reader = new ZXing.BarcodeReader { AutoRotate = true, TryHarder = true };
                ZXing.Result result = reader.Decode(frame);

                decodedData = result.Text;
            }
            catch 
            {
                decodedData = "QRCode not found.";
            }
            

            messageBox.Text = decodedData;
        }
    }
}
