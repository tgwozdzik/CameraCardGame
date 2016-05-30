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
using System.Web.Script.Serialization;

using AForge.Video;
using AForge.Video.DirectShow;

using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using System.Runtime.InteropServices;

namespace CameraCardGame
{
    public partial class MainForm : Form
    {
        private Game game;
        private String readedQRCode = null;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();

            var pos = this.PointToScreen(cardPreviewHealth.Location);
            pos = cardPreview.PointToClient(pos);
            cardPreviewHealth.Parent = cardPreview;
            cardPreviewHealth.Location = pos;
            cardPreviewHealth.Parent = cardPreview;

            pos = this.PointToScreen(cardPreviewAttact.Location);
            pos = cardPreview.PointToClient(pos);
            cardPreviewAttact.Parent = cardPreview;
            cardPreviewAttact.Location = pos;
            cardPreviewAttact.Parent = cardPreview;

            pos = this.PointToScreen(cardPreviewManaCristals.Location);
            pos = cardPreview.PointToClient(pos);
            cardPreviewManaCristals.Parent = cardPreview;
            cardPreviewManaCristals.Location = pos;
            cardPreviewManaCristals.Parent = cardPreview;

            hideCards();
        }

        private void showCards()
        {
            player1card1.Visible = true;
            player1card2.Visible = true;
            player1card3.Visible = true;
            player1card4.Visible = true;
            player1card5.Visible = true;
            player1card6.Visible = true;
            player1card7.Visible = true;

            player2card1.Visible = true;
            player2card2.Visible = true;
            player2card3.Visible = true;
            player2card4.Visible = true;
            player2card5.Visible = true;
            player2card6.Visible = true;
            player2card7.Visible = true;
        }

        private void hideCards()
        {
            player1card1.Visible = false;
            player1card2.Visible = false;
            player1card3.Visible = false;
            player1card4.Visible = false;
            player1card5.Visible = false;
            player1card6.Visible = false;
            player1card7.Visible = false;

            player2card1.Visible = false;
            player2card2.Visible = false;
            player2card3.Visible = false;
            player2card4.Visible = false;
            player2card5.Visible = false;
            player2card6.Visible = false;
            player2card7.Visible = false;
        }

        private void hideMenu()
        {
            gameStatsUpdate.Enabled = true;

            if (game.turn == 1)
            {
                player1Timer.Enabled = true;
            }
            else
            {
                player2Timer.Enabled = true;
            }

            startGame.Visible = false;
            optionConnectButton.Visible = false;
            button3.Visible = false;
            showMenuButton.Visible = true;

            showMenuButton.Text = "Show Menu";
        }

        private void showMenu()
        {
            gameStatsUpdate.Enabled = false;

            if (game.turn == 1)
            {
                player1Timer.Enabled = false;
            }
            else
            {
                player2Timer.Enabled = false;
            }

            startGame.Visible = true;
            optionConnectButton.Visible = true;
            button3.Visible = true;

            showMenuButton.Text = "New Game";
        }

        private void cleanAllCards()
        {
            player1card1.Image = null;
            player1card2.Image = null;
            player1card3.Image = null;
            player1card4.Image = null;
            player1card5.Image = null;
            player1card6.Image = null;
            player1card7.Image = null;
            
            player2card1.Image = null;
            player2card2.Image = null;
            player2card3.Image = null;
            player2card4.Image = null;
            player2card5.Image = null;
            player2card6.Image = null;
            player2card7.Image = null;
        }

        private void StartNewGame()
        {
            cleanAllCards();
            showCards();

            gameStatsUpdate.Stop();
            player1Timer.Stop();
            player2Timer.Stop();

            Player player1 = new Player(new List<Card>(), 30, 0, 0, 30, 10);
            Player player2 = new Player(new List<Card>(), 30, 0, 0, 30, 1);

            game = new Game(player1, player2, 1, 1, 120);

            player1Timer.Interval = 500;
            player2Timer.Interval = 500;
            gameStatsUpdate.Interval = 100;

            readedQRCode = null;

            hideMenu();

            gameStatsUpdate.Start();
            player1Timer.Start();

            messageBox.AppendText("Start New Game!\n");
        }

        private void ControlInvokeRequired(Control control, Action action)
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
            QRReaderTimer.Start();

            this.Cursor = Cursors.Default;
        }

        private void writeMessage(String text, String mode = "normal")
        {
            if (mode == "warning")
            {
                messageBox.SelectionColor = Color.Red;
                messageBox.AppendText(text + "\n");
                messageBox.SelectionColor = messageBox.ForeColor;
            }

            if (mode == "normal")
            {
                messageBox.AppendText(text + "\n");
            }

            messageBox.SelectionStart = messageBox.Text.Length;
            messageBox.ScrollToCaret();
        }

        private void videoSourceErrorHandler()
        {
            CloseCurrentVideoSource();

            writeMessage("Cannot connect to video source!", "warning");

            if (optionConnectButton.Text != "Options")
            {
                optionConnectButton.Text = "Connect";
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
                QRReaderTimer.Stop();
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
                ZXing.BarcodeReader reader = new ZXing.BarcodeReader { TryHarder = true };
                ZXing.Result result = reader.Decode(frame);

                readedQRCode = result.Text;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoPlayer.VideoSource == null)
            {
                writeMessage("Please set up camera source in Options, before starting game!", "warning");
                return;
            }

            if (startGame.Text == "Start Game")
            {
                StartNewGame();
                showCards();
            }
            else
            {
                hideMenu();
                showCards();
                writeMessage("Game is live!\n");
            }
        }

        private void gameStatsUpdate_Tick(object sender, EventArgs e)
        {
            if (videoPlayer.VideoSource == null)
            {
                showMenu();
                writeMessage("Please set up camera source in Options, before starting game!", "warning");
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
                writeMessage("Player1 turn!\n");
                game.nextRound();
                game.changeTurn();
                game.resetTurnTimer();
                player1Timer.Start();
                game.player1.vaitingForQRCode = false;
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
                writeMessage("Player2 turn!\n");
                game.changeTurn();
                game.resetTurnTimer();
                player2Timer.Start();
            }
            else
            {
                if (readedQRCode != null)
                {
                    JavaScriptSerializer json = new JavaScriptSerializer();
                    Dictionary<string, object> cardData = json.Deserialize<Dictionary<string, object>>(readedQRCode);

                    Card card;
                    try
                    {
                        card = new Card((int)cardData["id"], (String)cardData["name"], (int)cardData["health"], (int)cardData["attack"], (int)cardData["mana"], (String)cardData["isTaunt"]);
                    }
                    catch(Exception exception)
                    {
                        return;
                    }

                    if (!game.player1.useMana(card.getManaCristals()))
                    {
                        return;
                    }

                    if (!game.player1.putCard(card))
                    {
                        game.player1.useMana(-card.getManaCristals());
                        return;
                    }
                    else
                    {
                        placePlayer1Card(card);
                    }
                }
            }
        }

        private void placePlayer1Card(Card card)
        {
            if (player1card1.Image == null)
            {
                player1card1.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                player1card1.Image = card.getPicture();
                player1card1.Visible = true;
                return;
            }

            if (player1card2.Image == null)
            {
                player1card2.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                player1card2.Image = card.getPicture();
                player1card2.Visible = true;
                return;
            }

            if (player1card3.Image == null)
            {
                player1card3.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                player1card3.Image = card.getPicture();
                player1card3.Visible = true;
                return;
            }

            if (player1card4.Image == null)
            {
                player1card4.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                player1card4.Image = card.getPicture();
                player1card4.Visible = true;
                return;
            }

            if (player1card5.Image == null)
            {
                player1card5.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                player1card5.Image = card.getPicture();
                player1card5.Visible = true;
                return;
            }

            if (player1card6.Image == null)
            {
                player1card6.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                player1card6.Image = card.getPicture();
                player1card6.Visible = true;
                return;
            }

            if (player1card7.Image == null)
            {
                player1card7.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                player1card7.Image = card.getPicture();
                player1card7.Visible = true;
                return;
            }
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
                optionConnectButton.Text = "Options";
                button3.Text = "Quit";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (videoPlayer.VideoSource == null)
            {
                writeMessage("Please set up camera source in Options, before starting game!", "warning");
                return;
            }

            if (showMenuButton.Text == "New Game")
            {
                StartNewGame();
                hideCards();
            }
            else
            {
                hideCards();
                showMenu();
                writeMessage("Game paused!\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (optionConnectButton.Text == "Options")
            {
                startGame.Visible = false;
                inputURL.Visible = true;
                label5.Visible = true;

                if (videoPlayer.VideoSource == null)
                {
                    optionConnectButton.Text = "Connect";
                }
                else
                {
                    optionConnectButton.Text = "Disconnect";
                }

                button3.Text = "Back";
            }
            else
            {
                if (videoPlayer.VideoSource == null)
                {
                    MJPEGStream mjpegStream = new MJPEGStream("http://" + inputURL.Text + "/mjpegfeed?640x480");
                    OpenVideoSource(mjpegStream);
                }
                else
                {
                    CloseCurrentVideoSource();
                }
            }
        }

        private void CardMouseLeave(object sender, EventArgs e)
        {
            cardPreview.Visible = false;
            cardPreviewAttact.Visible = false;
            cardPreviewHealth.Visible = false;
            cardPreviewManaCristals.Visible = false;

            cardPreview.Image = null;
        }

        private void CardMouseEnter(object sender, EventArgs e, Card card)
        {
            cardPreview.Visible = true;
            cardPreview.Image = card.getPicture();

            cardPreviewAttact.Visible = true;
            cardPreviewAttact.Text = card.getAttack().ToString();

            cardPreviewHealth.Visible = true;
            cardPreviewHealth.Text = card.getHealth().ToString();

            cardPreviewManaCristals.Visible = true;
            cardPreviewManaCristals.Text = card.getManaCristals().ToString();

            cardPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
