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
        private bool moving;
        private Point startLocation;

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
            
            //messageBox.AppendText(decodedData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            var pictureBox = new PictureBox();
            pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(200, 260);
            pictureBox.Location = new Point(260, 60);

            pictureBox.MouseDown += new MouseEventHandler(PictureBoxMouseDown);
            pictureBox.MouseUp += new MouseEventHandler(PictureBoxMouseUp);
            pictureBox.MouseMove += new MouseEventHandler(PictureBoxMouseMove);

            splitContainer1.Panel2.Controls.Add(pictureBox);
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            startLocation = e.Location;
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            messageBox.AppendText("mouseUp");
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {

            Control control = (Control) sender;

            if (moving)
            {
                control.Left += e.Location.X - startLocation.X;
                control.Top += e.Location.Y - startLocation.Y;
            }
        }
    }
}
