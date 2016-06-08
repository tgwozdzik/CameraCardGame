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

        private Card selectedPlayerCard = null;
        private Card attackedOpponentCard = null;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();

            var pos = this.PointToScreen(endTurn.Location);
            pos = pictureBox1.PointToClient(pos);
            endTurn.Parent = pictureBox1;
            endTurn.Location = pos;

            pos = this.PointToScreen(player2card1attack.Location);
            pos = player2card1.PointToClient(pos);
            player2card1attack.Parent = player2card1;
            player2card1attack.Location = pos;

            pos = this.PointToScreen(player2card1health.Location);
            pos = player2card1.PointToClient(pos);
            player2card1health.Parent = player2card1;
            player2card1health.Location = pos;

            pos = this.PointToScreen(player2card2attack.Location);
            pos = player2card2.PointToClient(pos);
            player2card2attack.Parent = player2card2;
            player2card2attack.Location = pos;

            pos = this.PointToScreen(player2card2health.Location);
            pos = player2card2.PointToClient(pos);
            player2card2health.Parent = player2card2;
            player2card2health.Location = pos;

            pos = this.PointToScreen(player2card3attack.Location);
            pos = player2card3.PointToClient(pos);
            player2card3attack.Parent = player2card3;
            player2card3attack.Location = pos;

            pos = this.PointToScreen(player2card3health.Location);
            pos = player2card3.PointToClient(pos);
            player2card3health.Parent = player2card3;
            player2card3health.Location = pos;

            pos = this.PointToScreen(player2card4attack.Location);
            pos = player2card4.PointToClient(pos);
            player2card4attack.Parent = player2card4;
            player2card4attack.Location = pos;

            pos = this.PointToScreen(player2card4health.Location);
            pos = player2card4.PointToClient(pos);
            player2card4health.Parent = player2card4;
            player2card4health.Location = pos;

            pos = this.PointToScreen(player2card5attack.Location);
            pos = player2card5.PointToClient(pos);
            player2card5attack.Parent = player2card5;
            player2card5attack.Location = pos;

            pos = this.PointToScreen(player2card5health.Location);
            pos = player2card5.PointToClient(pos);
            player2card5health.Parent = player2card5;
            player2card5health.Location = pos;

            pos = this.PointToScreen(player2card6attack.Location);
            pos = player2card6.PointToClient(pos);
            player2card6attack.Parent = player2card6;
            player2card6attack.Location = pos;

            pos = this.PointToScreen(player2card6health.Location);
            pos = player2card6.PointToClient(pos);
            player2card6health.Parent = player2card6;
            player2card6health.Location = pos;

            pos = this.PointToScreen(player2card7attack.Location);
            pos = player2card7.PointToClient(pos);
            player2card7attack.Parent = player2card7;
            player2card7attack.Location = pos;

            pos = this.PointToScreen(player2card7health.Location);
            pos = player2card7.PointToClient(pos);
            player2card7health.Parent = player2card7;
            player2card7health.Location = pos;



            pos = this.PointToScreen(player1card1attack.Location);
            pos = player1card1.PointToClient(pos);
            player1card1attack.Parent = player1card1;
            player1card1attack.Location = pos;

            pos = this.PointToScreen(player1card1health.Location);
            pos = player1card1.PointToClient(pos);
            player1card1health.Parent = player1card1;
            player1card1health.Location = pos;

            pos = this.PointToScreen(player1card2attack.Location);
            pos = player1card2.PointToClient(pos);
            player1card2attack.Parent = player1card2;
            player1card2attack.Location = pos;

            pos = this.PointToScreen(player1card2health.Location);
            pos = player1card2.PointToClient(pos);
            player1card2health.Parent = player1card2;
            player1card2health.Location = pos;

            pos = this.PointToScreen(player1card3attack.Location);
            pos = player1card3.PointToClient(pos);
            player1card3attack.Parent = player1card3;
            player1card3attack.Location = pos;

            pos = this.PointToScreen(player1card3health.Location);
            pos = player1card3.PointToClient(pos);
            player1card3health.Parent = player1card3;
            player1card3health.Location = pos;

            pos = this.PointToScreen(player1card4attack.Location);
            pos = player1card4.PointToClient(pos);
            player1card4attack.Parent = player1card4;
            player1card4attack.Location = pos;

            pos = this.PointToScreen(player1card4health.Location);
            pos = player1card4.PointToClient(pos);
            player1card4health.Parent = player1card4;
            player1card4health.Location = pos;

            pos = this.PointToScreen(player1card5attack.Location);
            pos = player1card5.PointToClient(pos);
            player1card5attack.Parent = player1card5;
            player1card5attack.Location = pos;

            pos = this.PointToScreen(player1card5health.Location);
            pos = player1card5.PointToClient(pos);
            player1card5health.Parent = player1card5;
            player1card5health.Location = pos;

            pos = this.PointToScreen(player1card6attack.Location);
            pos = player1card6.PointToClient(pos);
            player1card6attack.Parent = player1card6;
            player1card6attack.Location = pos;

            pos = this.PointToScreen(player1card6health.Location);
            pos = player1card6.PointToClient(pos);
            player1card6health.Parent = player1card6;
            player1card6health.Location = pos;

            pos = this.PointToScreen(player1card7attack.Location);
            pos = player1card7.PointToClient(pos);
            player1card7attack.Parent = player1card7;
            player1card7attack.Location = pos;

            pos = this.PointToScreen(player1card7health.Location);
            pos = player1card7.PointToClient(pos);
            player1card7health.Parent = player1card7;
            player1card7health.Location = pos;

            hideCards();
        }

        private void setPreviewCardCaptions(String cardType) {
            if (cardType == "dragon")
            {
                cardPreviewHealth.Location = new Point(158, 394);
                cardPreviewAttact.Location = new Point(17, 392);
                cardPreviewManaCristals.Location = new Point(16, 196);
            }
            else if (cardType == "rounded")
            {
                cardPreviewHealth.Location = new Point(158, 393);
                cardPreviewAttact.Location = new Point(17, 393);
                cardPreviewManaCristals.Location = new Point(16, 186);
            }
            else
            {
                cardPreviewHealth.Location = new Point(158, 391);
                cardPreviewAttact.Location = new Point(17, 391);
                cardPreviewManaCristals.Location = new Point(16, 188);
            }

            var pos = this.PointToScreen(cardPreviewHealth.Location);
            pos = cardPreview.PointToClient(pos);
            cardPreviewHealth.Parent = cardPreview;
            cardPreviewHealth.Location = pos;

            pos = this.PointToScreen(cardPreviewAttact.Location);
            pos = cardPreview.PointToClient(pos);
            cardPreviewAttact.Parent = cardPreview;
            cardPreviewAttact.Location = pos;

            pos = this.PointToScreen(cardPreviewManaCristals.Location);
            pos = cardPreview.PointToClient(pos);
            cardPreviewManaCristals.Parent = cardPreview;
            cardPreviewManaCristals.Location = pos; 
        }
        private void showCards()
        {
            player2card1.Visible = true;
            player2card1attack.Visible = true;
            player2card1health.Visible = true;
            player2card2.Visible = true;
            player2card2attack.Visible = true;
            player2card2health.Visible = true;
            player2card3.Visible = true;
            player2card3attack.Visible = true;
            player2card3health.Visible = true;
            player2card4.Visible = true;
            player2card4attack.Visible = true;
            player2card4health.Visible = true;
            player2card5.Visible = true;
            player2card5attack.Visible = true;
            player2card5health.Visible = true;
            player2card6.Visible = true;
            player2card6attack.Visible = true;
            player2card6health.Visible = true;
            player2card7.Visible = true;
            player2card7attack.Visible = true;
            player2card7health.Visible = true;

            player1card1.Visible = true;
            player1card1attack.Visible = true;
            player1card1health.Visible = true;
            player1card2.Visible = true;
            player1card2attack.Visible = true;
            player1card2health.Visible = true;
            player1card3.Visible = true;
            player1card3attack.Visible = true;
            player1card3health.Visible = true;
            player1card4.Visible = true;
            player1card4attack.Visible = true;
            player1card4health.Visible = true;
            player1card5.Visible = true;
            player1card5attack.Visible = true;
            player1card5health.Visible = true;
            player1card6.Visible = true;
            player1card6attack.Visible = true;
            player1card6health.Visible = true;
            player1card7.Visible = true;
            player1card7attack.Visible = true;
            player1card7health.Visible = true;
        }
        private void hideCards()
        {
            player2card1.Visible = false;
            player2card1attack.Visible = false;
            player2card1health.Visible = false;
            player2card2.Visible = false;
            player2card2attack.Visible = false;
            player2card2health.Visible = false;
            player2card3.Visible = false;
            player2card3attack.Visible = false;
            player2card3health.Visible = false;
            player2card4.Visible = false;
            player2card4attack.Visible = false;
            player2card4health.Visible = false;
            player2card5.Visible = false;
            player2card5attack.Visible = false;
            player2card5health.Visible = false;
            player2card6.Visible = false;
            player2card6attack.Visible = false;
            player2card6health.Visible = false;
            player2card7.Visible = false;
            player2card7attack.Visible = false;
            player2card7health.Visible = false;

            player1card1.Visible = false;
            player1card1attack.Visible = false;
            player1card1health.Visible = false;
            player1card2.Visible = false;
            player1card2attack.Visible = false;
            player1card2health.Visible = false;
            player1card3.Visible = false;
            player1card3attack.Visible = false;
            player1card3health.Visible = false;
            player1card4.Visible = false;
            player1card4attack.Visible = false;
            player1card4health.Visible = false;
            player1card5.Visible = false;
            player1card5attack.Visible = false;
            player1card5health.Visible = false;
            player1card6.Visible = false;
            player1card6attack.Visible = false;
            player1card6health.Visible = false;
            player1card7.Visible = false;
            player1card7attack.Visible = false;
            player1card7health.Visible = false;
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
            endTurn.Visible = true;

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
            endTurn.Visible = false;

            showMenuButton.Text = "New Game";
        }
        private void cleanAllCards()
        {
            player1card1.Image = null;
            player1card1attack.Text = "";
            player1card1health.Text = "";
            player1card2.Image = null;
            player1card2attack.Text = "";
            player1card2health.Text = "";
            player1card3.Image = null;
            player1card3attack.Text = "";
            player1card3health.Text = "";
            player1card4.Image = null;
            player1card4attack.Text = "";
            player1card4health.Text = "";
            player1card5.Image = null;
            player1card5attack.Text = "";
            player1card5health.Text = "";
            player1card6.Image = null;
            player1card6attack.Text = "";
            player1card6health.Text = "";
            player1card7.Image = null;
            player1card7attack.Text = "";
            player1card7health.Text = "";
            
            player2card1.Image = null;
            player2card1attack.Text = "";
            player2card1health.Text = "";
            player2card2.Image = null;
            player2card2attack.Text = "";
            player2card2health.Text = "";
            player2card3.Image = null;
            player2card3attack.Text = "";
            player2card3health.Text = "";
            player2card4.Image = null;
            player2card4attack.Text = "";
            player2card4health.Text = "";
            player2card5.Image = null;
            player2card5attack.Text = "";
            player2card5health.Text = "";
            player2card6.Image = null;
            player2card6attack.Text = "";
            player2card6health.Text = "";
            player2card7.Image = null;
            player2card7attack.Text = "";
            player2card7health.Text = "";
        }
        private void StartNewGame()
        {
            cleanAllCards();
            showCards();

            gameStatsUpdate.Stop();
            player1Timer.Stop();
            player2Timer.Stop();

            Player player1 = new Player(new List<Card>(), 30, 1);
            Player player2 = new Player(new List<Card>(), 30, 1);

            Card card = new Card(0, "main_hero", "", 30, 0, 0, "false");
            card.setOntableId(0);

            player1.putCard(card);

            card = new Card(8, "main_hero", "", 5, 0, 0, "false");
            card.setOntableId(8);

            player2.putCard(card);

            game = new Game(player1, player2, 1, 1, 180);

            player1Timer.Interval = 500;
            player2Timer.Interval = 500;
            gameStatsUpdate.Interval = 100;

            readedQRCode = null;

            hideMenu();

            yourTurnPlayer1.Visible = true;
            yourTurnPlayer2.Visible = false;

            gameStatsUpdate.Start();
            player1Timer.Start();

            writeMessage("Start New Game!");
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
                writeMessage("Game is live!");
            }
        }
        private void showWinnerMenu(string winner)
        {
            hideCards();
            showMenuButton.Visible = false;
            optionConnectButton.Visible = true;
            optionConnectButton.Text = "New Game";
            congratulation.Text = winner + " wins!";
            congratulation.Visible = true;
            button3.Visible = true;
            endTurn.Visible = false;
        }
        private void showPlayersCristals(int player1Cristals, int player2Cristals){
            if (--player1Cristals >= 0) player1cristal1.Visible = false;
            else player1cristal1.Visible = true;

            if (--player1Cristals >= 0) player1cristal2.Visible = false;
            else player1cristal2.Visible = true;

            if (--player1Cristals >= 0) player1cristal3.Visible = false;
            else player1cristal3.Visible = true;

            if (--player1Cristals >= 0) player1cristal4.Visible = false;
            else player1cristal4.Visible = true;

            if (--player1Cristals >= 0) player1cristal5.Visible = false;
            else player1cristal5.Visible = true;

            if (--player1Cristals >= 0) player1cristal6.Visible = false;
            else player1cristal6.Visible = true;

            if (--player1Cristals >= 0) player1cristal7.Visible = false;
            else player1cristal7.Visible = true;

            if (--player1Cristals >= 0) player1cristal8.Visible = false;
            else player1cristal8.Visible = true;

            if (--player1Cristals >= 0) player1cristal9.Visible = false;
            else player1cristal9.Visible = true;

            if (--player1Cristals >= 0) player1cristal10.Visible = false;
            else player1cristal10.Visible = true;



            if (--player2Cristals >= 0) player2cristal1.Visible = false;
            else player2cristal1.Visible = true;

            if (--player2Cristals >= 0) player2cristal2.Visible = false;
            else player2cristal2.Visible = true;

            if (--player2Cristals >= 0) player2cristal3.Visible = false;
            else player2cristal3.Visible = true;

            if (--player2Cristals >= 0) player2cristal4.Visible = false;
            else player2cristal4.Visible = true;

            if (--player2Cristals >= 0) player2cristal5.Visible = false;
            else player2cristal5.Visible = true;

            if (--player2Cristals >= 0) player2cristal6.Visible = false;
            else player2cristal6.Visible = true;

            if (--player2Cristals >= 0) player2cristal7.Visible = false;
            else player2cristal7.Visible = true;

            if (--player2Cristals >= 0) player2cristal8.Visible = false;
            else player2cristal8.Visible = true;

            if (--player2Cristals >= 0) player2cristal9.Visible = false;
            else player2cristal9.Visible = true;

            if (--player2Cristals >= 0) player2cristal10.Visible = false;
            else player2cristal10.Visible = true;
        }
        private void gameStatsUpdate_Tick(object sender, EventArgs e)
        {            
            if (videoPlayer.VideoSource == null)
            {
                hideCards();
                showMenu();
                writeMessage("Please set up camera source in Options, before starting game!", "warning");
            }

            player1CardsLeft.Text = game.player1.getCardsLeft().ToString();
            player2CardsLeft.Text = game.player2.getCardsLeft().ToString();

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
            player1Health.Text = game.player1.getHealth().ToString();
            player2Health.Text = game.player2.getHealth().ToString();

            if (game.player1.getHealth() <= 0 || game.player2.getHealth() <= 0)
            {
                player1Timer.Stop();
                player2Timer.Stop();
                gameStatsUpdate.Stop();

                hideCards();
                showWinnerMenu(game.player1.getHealth() <= 0 ? "Player2" : "Player1");
                return;
            }

            //ManaCristals
            player1ManaCristals.Text = game.player1.getManaCristals().ToString() + "/" + game.player1.getMaxManaCristals().ToString();
            player2ManaCristals.Text = game.player2.getManaCristals().ToString() + "/" + game.player2.getMaxManaCristals().ToString(); ;

            showPlayersCristals(game.player1.getManaCristals(), game.player2.getManaCristals());

            //Change button caption
            startGame.Text = "Resume";

            if(selectedPlayerCard != null && attackedOpponentCard != null)
            {
                game.fight(selectedPlayerCard, attackedOpponentCard);

                Card selectedPlayerCardTemp = new Card(selectedPlayerCard);
                Card attackedOpponentCardTemp = new Card(attackedOpponentCard);

                if (game.turn == 1)
                {
                    updatePlayer1Cards(selectedPlayerCard);
                    updatePlayer2Cards(attackedOpponentCard);
                }
                else
                {
                    updatePlayer2Cards(selectedPlayerCard);
                    updatePlayer1Cards(attackedOpponentCard);
                }

                selectedPlayerCard.setCardUsed();
                cleanSelectedCards();

                bool clean = game.updatePlayersCard(selectedPlayerCardTemp, attackedOpponentCardTemp);
                if (clean)
                {
                    CardMouseLeave(this, e);
                }
            }
        }
        private void changeTurn() {
            if (game.turn == 1)
            {
                player1Timer.Stop();
                writeMessage("Player2 turn!");
                game.changeTurn();
                game.resetTurnTimer();
                readedQRCode = null;
                game.player2.addCristal();
                game.player2.unlockCards();
                player2Timer.Start();
                game.player2.takeCard();
                yourTurnPlayer2.Visible = true;
                yourTurnPlayer1.Visible = false;
            }
            else
            {
                player2Timer.Stop();
                writeMessage("Player1 turn!");
                game.nextRound();
                game.changeTurn();
                game.resetTurnTimer();
                readedQRCode = null;
                game.player1.addCristal();
                game.player1.unlockCards();
                player1Timer.Start();
                game.player1.takeCard();
                yourTurnPlayer1.Visible = true;
                yourTurnPlayer2.Visible = false;
            }
        }
        private Card readCard() {
            JavaScriptSerializer json;
            Dictionary<string, object> cardData;
            Card card;

            if (readedQRCode != null)
            {
                try
                {
                    json = new JavaScriptSerializer();
                    cardData = json.Deserialize<Dictionary<string, object>>(readedQRCode);
                    card = new Card((int)cardData["id"], (String)cardData["name"], (String)cardData["card_type"], (int)cardData["health"], (int)cardData["attack"], (int)cardData["mana"], (String)cardData["isTaunt"]);
                }
                catch
                {
                    return null;
                }

                readedQRCode = null;

                return card;
            }

            return null;
        }
        private void player2Timer_Tick(object sender, EventArgs e)
        {
            game.decreaseTurnTimer(player2Timer.Interval);

            if (game.turnTimer == 0)
            {
                changeTurn();
            }
            else
            {
                Card card = readCard();

                if (card == null) return;

                if (!game.player2.useMana(card.getManaCristals()))
                {
                    return;
                }

                if (game.player2.isCardOnList(card) || game.player1.isCardOnList(card))
                {
                    game.player2.useMana(-card.getManaCristals());
                    return;
                }
                else
                {
                    game.player2.putCard(card);
                    placePlayer2Card(card);
                }
            }
        }
        private void player1Timer_Tick(object sender, EventArgs e)
        {
            game.decreaseTurnTimer(player1Timer.Interval);

            if (game.turnTimer == 0) {
                changeTurn();
            }
            else
            {
                Card card = readCard();

                if (card == null) return;

                if (!game.player1.useMana(card.getManaCristals()))
                {
                    return;
                }

                if (game.player1.isCardOnList(card) || game.player2.isCardOnList(card))
                {
                    game.player1.useMana(-card.getManaCristals());
                    return;
                }
                else
                {
                    game.player1.putCard(card);
                    placePlayer1Card(card);
                }
                
            }
        }
        private void cleanSelectedCards()
        {
            if (selectedPlayerCard != null)
            {
                if (game.player1.isCardOnList(selectedPlayerCard))
                {
                    PictureBox pictureBoxTemp = (PictureBox)Controls.Find("player1card" + selectedPlayerCard.getOnTableId().ToString(), true)[0];
                    pictureBoxTemp.BorderStyle = BorderStyle.None;
                }
                else
                {
                    PictureBox pictureBoxTemp = (PictureBox)Controls.Find("player2card" + selectedPlayerCard.getOnTableId().ToString(), true)[0];
                    pictureBoxTemp.BorderStyle = BorderStyle.None;
                }

                selectedPlayerCard = null;
            }
            if (attackedOpponentCard != null)
            {
                if (game.player1.isCardOnList(attackedOpponentCard))
                {
                    PictureBox pictureBoxTemp = (PictureBox)Controls.Find("player1card" + attackedOpponentCard.getOnTableId().ToString(), true)[0];
                    pictureBoxTemp.BorderStyle = BorderStyle.None;
                }
                else
                {
                    PictureBox pictureBoxTemp = (PictureBox)Controls.Find("player2card" + attackedOpponentCard.getOnTableId().ToString(), true)[0];
                    pictureBoxTemp.BorderStyle = BorderStyle.None;
                }

                attackedOpponentCard = null;
            }
        }
        private void selectCard(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox) sender;

            if (pictureBox.Image == null && 
                !(pictureBox.Name.Substring(pictureBox.Name.Length - 1, 1) == "8" || pictureBox.Name.Substring(pictureBox.Name.Length - 1, 1) == "0")) return;

            Card card = null;

            int playerId = Int32.Parse(pictureBox.Name.Substring(pictureBox.Name.Length - 6, 1));
            int onTableId = Int32.Parse(pictureBox.Name.Substring(pictureBox.Name.Length - 1, 1));

            if (game.turn == 1)
            {
                if (selectedPlayerCard != null)
                {
                    card = game.player2.getCardOnTable(onTableId);
                }
                else
                {
                    if (playerId == 2 || onTableId == 8 || onTableId == 0) return;
                    card = game.player1.getCardOnTable(onTableId);
                    if (card != null && card.getCardUsageStatus()) card = null;
                }
            }
            else
            {
                if (selectedPlayerCard != null)
                {
                    card = game.player1.getCardOnTable(onTableId);
                }
                else
                {
                    if (playerId == 1 || onTableId == 8 || onTableId == 0) return;
                    card = game.player2.getCardOnTable(onTableId);
                    if (card != null && card.getCardUsageStatus()) card = null;
                }
            }

            if (card == null)
            {
                cleanSelectedCards();
            }
            else
            {
                if (selectedPlayerCard == null)
                {
                    selectedPlayerCard = card;
                }
                else
                {
                    attackedOpponentCard = card;
                }

                pictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
        } 
        private void placePlayer1Card(Card card)
        {
            if (player1card1.Image == null)
            {
                player1card1.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card)); ;
                card.setOntableId(1);
                player1card1.Image = card.getPicture();
                player1card1.Visible = true;
                player1card1attack.Visible = true;
                player1card1health.Visible = true;
                player1card1attack.Text = card.getAttack().ToString();
                player1card1health.Text = card.getHealth().ToString();
                return;
            }

            if (player1card2.Image == null)
            {
                player1card2.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(2);
                player1card2.Image = card.getPicture();
                player1card2.Visible = true;
                player1card2attack.Visible = true;
                player1card2health.Visible = true;
                player1card2attack.Text = card.getAttack().ToString();
                player1card2health.Text = card.getHealth().ToString();
                return;
            }

            if (player1card3.Image == null)
            {
                player1card3.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(3);
                player1card3.Image = card.getPicture();
                player1card3.Visible = true;
                player1card3attack.Visible = true;
                player1card3health.Visible = true;
                player1card3attack.Text = card.getAttack().ToString();
                player1card3health.Text = card.getHealth().ToString();
                return;
            }

            if (player1card4.Image == null)
            {
                player1card4.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(4);
                player1card4.Image = card.getPicture();
                player1card4.Visible = true;
                player1card4attack.Visible = true;
                player1card4health.Visible = true;
                player1card4attack.Text = card.getAttack().ToString();
                player1card4health.Text = card.getHealth().ToString();
                return;
            }

            if (player1card5.Image == null)
            {
                player1card5.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(5);
                player1card5.Image = card.getPicture();
                player1card5.Visible = true;
                player1card5attack.Visible = true;
                player1card5health.Visible = true;
                player1card5attack.Text = card.getAttack().ToString();
                player1card5health.Text = card.getHealth().ToString();
                return;
            }

            if (player1card6.Image == null)
            {
                player1card6.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(6);
                player1card6.Image = card.getPicture();
                player1card6.Visible = true;
                player1card6attack.Visible = true;
                player1card6health.Visible = true;
                player1card6attack.Text = card.getAttack().ToString();
                player1card6health.Text = card.getHealth().ToString();
                return;
            }

            if (player1card7.Image == null)
            {
                player1card7.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(7);
                player1card7.Image = card.getPicture();
                player1card7.Visible = true;
                player1card7attack.Visible = true;
                player1card7health.Visible = true;
                player1card7attack.Text = card.getAttack().ToString();
                player1card7health.Text = card.getHealth().ToString();
                return;
            }
        }
        private void placePlayer2Card(Card card)
        {
            if (player2card1.Image == null)
            {
                player2card1.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(1);
                player2card1.Image = card.getPicture();
                player2card1.Visible = true;
                player2card1attack.Visible = true;
                player2card1health.Visible = true;
                player2card1attack.Text = card.getAttack().ToString();
                player2card1health.Text = card.getHealth().ToString();
                return;
            }

            if (player2card2.Image == null)
            {
                player2card2.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(2);
                player2card2.Image = card.getPicture();
                player2card2.Visible = true;
                player2card2attack.Visible = true;
                player2card2health.Visible = true;
                player2card2attack.Text = card.getAttack().ToString();
                player2card2health.Text = card.getHealth().ToString();
                return;
            }

            if (player2card3.Image == null)
            {
                player2card3.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(3);
                player2card3.Image = card.getPicture();
                player2card3.Visible = true;
                player2card3attack.Visible = true;
                player2card3health.Visible = true;
                player2card3attack.Text = card.getAttack().ToString();
                player2card3health.Text = card.getHealth().ToString();
                return;
            }

            if (player2card4.Image == null)
            {
                player2card4.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(4);
                player2card4.Image = card.getPicture();
                player2card4.Visible = true;
                player2card4attack.Visible = true;
                player2card4health.Visible = true;
                player2card4attack.Text = card.getAttack().ToString();
                player2card4health.Text = card.getHealth().ToString();
                return;
            }

            if (player2card5.Image == null)
            {
                player2card5.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(5);
                player2card5.Image = card.getPicture();
                player2card5.Visible = true;
                player2card5attack.Visible = true;
                player2card5health.Visible = true;
                player2card5attack.Text = card.getAttack().ToString();
                player2card5health.Text = card.getHealth().ToString();
                return;
            }

            if (player2card6.Image == null)
            {
                player2card6.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(6);
                player2card6.Image = card.getPicture();
                player2card6.Visible = true;
                player2card6attack.Visible = true;
                player2card6health.Visible = true;
                player2card6attack.Text = card.getAttack().ToString();
                player2card6health.Text = card.getHealth().ToString();
                return;
            }

            if (player2card7.Image == null)
            {
                player2card7.MouseEnter += new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                card.setOntableId(7);
                player2card7.Image = card.getPicture();
                player2card7.Visible = true;
                player2card7attack.Visible = true;
                player2card7health.Visible = true;
                player2card7attack.Text = card.getAttack().ToString();
                player2card7health.Text = card.getHealth().ToString();
                return;
            }
        }
        private void updatePlayer1Cards(Card card)
        {
            if (card.getId() != 0 && card.getId() != 8)
            {
                Label labelAttack = (Label)Controls.Find("player1card" + card.getOnTableId().ToString() + "attack", true)[0];
                Label labelHealth = (Label)Controls.Find("player1card" + card.getOnTableId().ToString() + "health", true)[0];

                labelAttack.Text = card.getAttack().ToString();
                labelHealth.Text = card.getHealth().ToString();

                if (card.getHealth() <= 0)
                {

                    PictureBox pictureBox = (PictureBox)Controls.Find("player1card" + card.getOnTableId().ToString(), true)[0];

                    pictureBox.Image = null;
                    pictureBox.MouseEnter -= new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                    pictureBox.Visible = false;
                    labelAttack.Visible = false;
                    labelHealth.Visible = false;
                    labelAttack.Text = "";
                    labelHealth.Text = "";
                }
            }
        }
        private void updatePlayer2Cards(Card card)
        {
            if (card.getId() != 0 && card.getId() != 8)
            {
                Label labelAttack = (Label)Controls.Find("player2card" + card.getOnTableId().ToString() + "attack", true)[0];
                Label labelHealth = (Label)Controls.Find("player2card" + card.getOnTableId().ToString() + "health", true)[0];

                labelAttack.Text = card.getAttack().ToString();
                labelHealth.Text = card.getHealth().ToString();

                if (card.getHealth() <= 0)
                {
                    PictureBox pictureBox = (PictureBox)Controls.Find("player2card" + card.getOnTableId().ToString(), true)[0];

                    pictureBox.Image = null;
                    pictureBox.MouseEnter -= new System.EventHandler((sender, e) => CardMouseEnter(sender, e, card));
                    pictureBox.Visible = false;
                    labelAttack.Visible = false;
                    labelHealth.Visible = false;
                    labelAttack.Text = "";
                    labelHealth.Text = "";
                }
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
            if (optionConnectButton.Text == "New Game")
            {
                congratulation.Visible = false;
                optionConnectButton.Text = "Options";
                StartNewGame();
                return;
            }

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
                    optionConnectButton.Text = "Disconnect";
                    MJPEGStream mjpegStream = new MJPEGStream("http://" + inputURL.Text + "/mjpegfeed?640x480");
                    OpenVideoSource(mjpegStream);
                }
                else
                {
                    optionConnectButton.Text = "Connect";
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
            PictureBox pictureBox = (PictureBox)sender;
            if (pictureBox.Image == null) return;

            setPreviewCardCaptions(card.getCardType());

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
            cleanSelectedCards();
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void endTurn_Click(object sender, EventArgs e)
        {
            changeTurn();

            cleanSelectedCards();
        }
    }
}
