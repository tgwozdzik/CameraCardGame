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

        private Game game;

        public MainForm()
        {
            InitializeComponent();
        }

        public void ControlInvokeRequired(Control control, Action action)
        {
            if (control.InvokeRequired) 
            {
                control.BeginInvoke(new MethodInvoker(delegate { action(); }));
 
            }
            else
            {
                action();
            }
        }

        private void OpenVideoSource(IVideoSource source)
        {
            this.Cursor = Cursors.WaitCursor;
            
            CloseCurrentVideoSource();

            videoPlayer.VideoSource = source;

            source.VideoSourceError += new VideoSourceErrorEventHandler(videoSourceError);
            videoPlayer.Start();
            timer.Start();

            this.Cursor = Cursors.Default;
        }

        private void videoSourceErrorHandler()
        {
            CloseCurrentVideoSource();

            messageBox.SelectionColor = Color.Red;
            messageBox.AppendText("Cannot connect to video source!\n");
            messageBox.SelectionColor = messageBox.ForeColor;

            if (button2.Text != "Options")
            {
                button2.Text = "Connect";
            }
        }

        private void videoSourceError(object sender, VideoSourceErrorEventArgs reason)
        {
            ControlInvokeRequired(videoPlayer, videoSourceErrorHandler);
        }
        
        private void CloseCurrentVideoSource()
        {
            if (videoPlayer.VideoSource != null)
            {
                timer.Stop();
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Bitmap frame = videoPlayer.GetCurrentVideoFrame();

            try 
            {
                ZXing.BarcodeReader reader = new ZXing.BarcodeReader { AutoRotate = true, TryHarder = true };
                ZXing.Result result = reader.Decode(frame);
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            //var pictureBox = new PictureBox();
            //pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox.Size = new Size(75, 110);
            //pictureBox.Location = new Point(260, 60);

            //pictureBox.MouseDown += new MouseEventHandler(PictureBoxMouseDown);
            //pictureBox.MouseUp += new MouseEventHandler(PictureBoxMouseUp);
            //pictureBox.MouseMove += new MouseEventHandler(PictureBoxMouseMove);

            //this.Controls.Add(pictureBox);

            if (videoPlayer.VideoSource == null)
            {
                messageBox.SelectionColor = Color.Red;
                messageBox.AppendText("Please set up camera source in Options, before starting new game!\n");
                messageBox.SelectionColor = messageBox.ForeColor;

                return;
            }

            if (startGame.Text == "Start Game")
            {
                startGame.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button1.Visible = true;

                Player player1 = new Player(new List<Card>(), 30, 0, 0, 30, 1);
                Player player2 = new Player(new List<Card>(), 30, 0, 0, 30, 1);

                game = new Game(player1, player2, 1, 1, 15);

                player1Timer.Interval = 500;
                player2Timer.Interval = 500;
                gameStatsUpdate.Interval = 100;

                gameStatsUpdate.Start();
                player1Timer.Start();

                messageBox.AppendText("Start New Game!\n");
            }
            else
            {
                startGame.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button1.Text = "Show Menu";

                gameStatsUpdate.Enabled = true;

                if (game.turn == 1)
                {
                    player1Timer.Enabled = true;
                }
                else
                {
                    player2Timer.Enabled = true;
                }

                messageBox.AppendText("Game is live!\n");
            }
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

        private void gameStatsUpdate_Tick(object sender, EventArgs e)
        {
            if (videoPlayer.VideoSource == null)
            {
                startGame.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button1.Text = "New Game";

                gameStatsUpdate.Enabled = false;

                if (game.turn == 1)
                {
                    player1Timer.Enabled = false;
                }
                else
                {
                    player2Timer.Enabled = false;
                }

                messageBox.SelectionColor = Color.Red;
                messageBox.AppendText("Please set up camera source in Options, before starting new game!\n");
                messageBox.SelectionColor = messageBox.ForeColor;
            }

            player1CardsLeft.Text = game.player1.cardsLeft.ToString();
            player2CardsLeft.Text = game.player2.cardsLeft.ToString();

            round.Text = game.round.ToString();

            timeLeft.Text = ((int)game.turnTimer).ToString();

            if ((int)game.turnTimer <= 10)
            {
                timeLeft.ForeColor = Color.Red;
            }
            else
            {
                timeLeft.ForeColor = Color.White;
            }

            //Health
            player1Health.Text = game.player1.health.ToString();
            player2Health.Text = game.player2.health.ToString();

            //ManaCristals
            player1ManaCristals.Text = game.player1.manaCristals.ToString() + "/10";
            player2ManaCristals.Text = game.player2.manaCristals.ToString() + "/10";

            //Change button caption
            startGame.Text = "Resume";
        }

        private void player2Timer_Tick(object sender, EventArgs e)
        {
            game.decreaseTurnTimer(player2Timer.Interval);

            if (game.turnTimer == 0)
            {
                player2Timer.Stop();
                messageBox.AppendText("Player1 turn!\n");
                game.nextRound();
                game.changeTurn();
                game.resetTurnTimer();
                player1Timer.Start();
            }
            else
            {
            }
        }

        private void player1Timer_Tick(object sender, EventArgs e)
        {
            game.decreaseTurnTimer(player1Timer.Interval);

            if (game.turnTimer == 0) {
                player1Timer.Stop();
                messageBox.AppendText("Player2 turn!\n");
                game.changeTurn();
                game.resetTurnTimer();
                player2Timer.Start();
            }
            else
            {
            }
        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {
            messageBox.SelectionStart = messageBox.Text.Length;
            messageBox.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Quit")
            {
                CloseCurrentVideoSource();

                if (System.Windows.Forms.Application.MessageLoop)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
            else
            {
                startGame.Visible = true;
                inputURL.Visible = false;
                label5.Visible = false;
                button2.Text = "Options";
                button3.Text = "Quit";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (videoPlayer.VideoSource == null)
            {
                messageBox.SelectionColor = Color.Red;
                messageBox.AppendText("Please set up camera source in Options, before starting new game!\n");
                messageBox.SelectionColor = messageBox.ForeColor;

                return;
            }

            if (button1.Text == "New Game")
            {
                gameStatsUpdate.Stop();
                player1Timer.Stop();
                player2Timer.Stop();

                button1.Text = "Show Menu";

                startGame.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button1.Visible = true;

                Player player1 = new Player(new List<Card>(), 30, 0, 0, 30, 1);
                Player player2 = new Player(new List<Card>(), 30, 0, 0, 30, 1);

                game = new Game(player1, player2, 1, 1, 15);

                player1Timer.Interval = 500;
                player2Timer.Interval = 500;
                gameStatsUpdate.Interval = 100;

                gameStatsUpdate.Start();
                player1Timer.Start();

                messageBox.AppendText("Start New Game!\n");
            }
            else
            {
                startGame.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button1.Text = "New Game";

                gameStatsUpdate.Enabled = false;

                if (game.turn == 1)
                {
                    player1Timer.Enabled = false;
                }
                else
                {
                    player2Timer.Enabled = false;
                }

                messageBox.AppendText("Game paused!\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Options")
            {
                startGame.Visible = false;
                inputURL.Visible = true;
                label5.Visible = true;
                if (videoPlayer.VideoSource == null)
                {
                    button2.Text = "Connect";
                }
                else
                {
                    button2.Text = "Disconnect";
                }
                button2.Text = "Connect";
                button3.Text = "Back";
            }
            else
            {
                if (videoPlayer.VideoSource == null)
                {
                    button2.Text = "Disconnect";
                    MJPEGStream mjpegStream = new MJPEGStream("http://" + inputURL.Text + "/mjpegfeed?640x480");
                    OpenVideoSource(mjpegStream);

                    //if (OpenVideoSource(mjpegStream))
                    //{
                    //    messageBox.SelectionColor = Color.Red;
                    //    messageBox.AppendText("Cannot connect to video source!\n");
                    //    messageBox.SelectionColor = messageBox.ForeColor;

                    //    videoPlayer.VideoSource = null;

                    //    return;
                    //}
                    //else
                    //{
                    //    button2.Text = "Disconnect";
                    //    messageBox.SelectionColor = Color.Green;
                    //    messageBox.AppendText("Connected to the video source!\n");
                    //    messageBox.SelectionColor = messageBox.ForeColor;
                    //}
                }
                else
                {
                    button2.Text = "Connect";
                    CloseCurrentVideoSource();
                }
            }
        }
    }
}
