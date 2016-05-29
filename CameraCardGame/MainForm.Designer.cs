namespace CameraCardGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.videoPlayer = new AForge.Controls.VideoSourcePlayer();
            this.inputURL = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1CardsLeft = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.round = new System.Windows.Forms.Label();
            this.player2CardsLeft = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.player2card4 = new System.Windows.Forms.PictureBox();
            this.player1Timer = new System.Windows.Forms.Timer(this.components);
            this.player2Timer = new System.Windows.Forms.Timer(this.components);
            this.gameStatsUpdate = new System.Windows.Forms.Timer(this.components);
            this.timeLeft = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.player2Health = new System.Windows.Forms.Label();
            this.player1Health = new System.Windows.Forms.Label();
            this.player2ManaCristals = new System.Windows.Forms.Label();
            this.player1ManaCristals = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.player2card2 = new System.Windows.Forms.PictureBox();
            this.player2card1 = new System.Windows.Forms.PictureBox();
            this.player2card3 = new System.Windows.Forms.PictureBox();
            this.player2card5 = new System.Windows.Forms.PictureBox();
            this.player2card7 = new System.Windows.Forms.PictureBox();
            this.player2card6 = new System.Windows.Forms.PictureBox();
            this.player1card1 = new System.Windows.Forms.PictureBox();
            this.player1card3 = new System.Windows.Forms.PictureBox();
            this.player1card2 = new System.Windows.Forms.PictureBox();
            this.player1card4 = new System.Windows.Forms.PictureBox();
            this.player1card5 = new System.Windows.Forms.PictureBox();
            this.player1card7 = new System.Windows.Forms.PictureBox();
            this.player1card6 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoPlayer.Location = new System.Drawing.Point(4, 36);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(184, 125);
            this.videoPlayer.TabIndex = 0;
            this.videoPlayer.Text = "videoPlayer";
            this.videoPlayer.VideoSource = null;
            // 
            // inputURL
            // 
            this.inputURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputURL.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputURL.Location = new System.Drawing.Point(474, 265);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(255, 31);
            this.inputURL.TabIndex = 1;
            this.inputURL.Text = "10.0.0.102:4747";
            this.inputURL.Visible = false;
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.SystemColors.Info;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Location = new System.Drawing.Point(4, 515);
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(184, 189);
            this.messageBox.TabIndex = 6;
            this.messageBox.Text = "";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bell MT", 20F);
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(548, 719);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Live camera preview";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bell MT", 20F);
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(548, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Game log";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1063, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cards left";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1CardsLeft
            // 
            this.player1CardsLeft.BackColor = System.Drawing.Color.Transparent;
            this.player1CardsLeft.Font = new System.Drawing.Font("Bell MT", 20F);
            this.player1CardsLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player1CardsLeft.Location = new System.Drawing.Point(1063, 249);
            this.player1CardsLeft.Name = "player1CardsLeft";
            this.player1CardsLeft.Size = new System.Drawing.Size(134, 30);
            this.player1CardsLeft.TabIndex = 18;
            this.player1CardsLeft.Text = "0";
            this.player1CardsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Bell MT", 14F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(1063, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Rund";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // round
            // 
            this.round.BackColor = System.Drawing.Color.Transparent;
            this.round.Font = new System.Drawing.Font("Bell MT", 20F);
            this.round.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.round.Location = new System.Drawing.Point(1063, 363);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(134, 30);
            this.round.TabIndex = 21;
            this.round.Text = "0";
            this.round.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2CardsLeft
            // 
            this.player2CardsLeft.BackColor = System.Drawing.Color.Transparent;
            this.player2CardsLeft.Font = new System.Drawing.Font("Bell MT", 20F);
            this.player2CardsLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player2CardsLeft.Location = new System.Drawing.Point(1067, 472);
            this.player2CardsLeft.Name = "player2CardsLeft";
            this.player2CardsLeft.Size = new System.Drawing.Size(130, 30);
            this.player2CardsLeft.TabIndex = 23;
            this.player2CardsLeft.Text = "0";
            this.player2CardsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Bell MT", 14F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(1067, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cards left";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2card4
            // 
            this.player2card4.BackColor = System.Drawing.Color.Transparent;
            this.player2card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2card4.Location = new System.Drawing.Point(335, 398);
            this.player2card4.Margin = new System.Windows.Forms.Padding(1);
            this.player2card4.Name = "player2card4";
            this.player2card4.Size = new System.Drawing.Size(103, 130);
            this.player2card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2card4.TabIndex = 24;
            this.player2card4.TabStop = false;
            this.player2card4.MouseEnter += new System.EventHandler(this.player2CardMouseEnter);
            this.player2card4.MouseLeave += new System.EventHandler(this.player2CardMouseLeave);
            // 
            // player1Timer
            // 
            this.player1Timer.Tick += new System.EventHandler(this.player1Timer_Tick);
            // 
            // player2Timer
            // 
            this.player2Timer.Tick += new System.EventHandler(this.player2Timer_Tick);
            // 
            // gameStatsUpdate
            // 
            this.gameStatsUpdate.Tick += new System.EventHandler(this.gameStatsUpdate_Tick);
            // 
            // timeLeft
            // 
            this.timeLeft.BackColor = System.Drawing.Color.Transparent;
            this.timeLeft.Font = new System.Drawing.Font("Bell MT", 20F);
            this.timeLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeLeft.Location = new System.Drawing.Point(1058, 63);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(139, 30);
            this.timeLeft.TabIndex = 27;
            this.timeLeft.Text = "0";
            this.timeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bell MT", 14F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(1063, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Timer";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Health
            // 
            this.player2Health.BackColor = System.Drawing.Color.Transparent;
            this.player2Health.Font = new System.Drawing.Font("Bell MT", 20F);
            this.player2Health.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player2Health.Location = new System.Drawing.Point(626, 651);
            this.player2Health.Name = "player2Health";
            this.player2Health.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player2Health.Size = new System.Drawing.Size(50, 30);
            this.player2Health.TabIndex = 28;
            this.player2Health.Text = "0";
            this.player2Health.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1Health
            // 
            this.player1Health.BackColor = System.Drawing.Color.Transparent;
            this.player1Health.Font = new System.Drawing.Font("Bell MT", 20F);
            this.player1Health.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player1Health.Location = new System.Drawing.Point(627, 186);
            this.player1Health.Name = "player1Health";
            this.player1Health.Size = new System.Drawing.Size(50, 30);
            this.player1Health.TabIndex = 29;
            this.player1Health.Text = "0";
            this.player1Health.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2ManaCristals
            // 
            this.player2ManaCristals.BackColor = System.Drawing.Color.Transparent;
            this.player2ManaCristals.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ManaCristals.ForeColor = System.Drawing.SystemColors.Desktop;
            this.player2ManaCristals.Location = new System.Drawing.Point(770, 725);
            this.player2ManaCristals.Name = "player2ManaCristals";
            this.player2ManaCristals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player2ManaCristals.Size = new System.Drawing.Size(70, 30);
            this.player2ManaCristals.TabIndex = 30;
            this.player2ManaCristals.Text = "0/10";
            this.player2ManaCristals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1ManaCristals
            // 
            this.player1ManaCristals.BackColor = System.Drawing.Color.Transparent;
            this.player1ManaCristals.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ManaCristals.ForeColor = System.Drawing.SystemColors.Desktop;
            this.player1ManaCristals.Location = new System.Drawing.Point(749, 34);
            this.player1ManaCristals.Name = "player1ManaCristals";
            this.player1ManaCristals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.player1ManaCristals.Size = new System.Drawing.Size(70, 30);
            this.player1ManaCristals.TabIndex = 31;
            this.player1ManaCristals.Text = "0/10";
            this.player1ManaCristals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.Transparent;
            this.startGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGame.FlatAppearance.BorderSize = 0;
            this.startGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGame.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Image = ((System.Drawing.Image)(resources.GetObject("startGame.Image")));
            this.startGame.Location = new System.Drawing.Point(473, 247);
            this.startGame.Margin = new System.Windows.Forms.Padding(1);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(255, 60);
            this.startGame.TabIndex = 13;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(473, 316);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 60);
            this.button2.TabIndex = 33;
            this.button2.Text = "Options";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(473, 417);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 60);
            this.button3.TabIndex = 34;
            this.button3.Text = "Quit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "Show menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bell MT", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(474, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Video URL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // player2card2
            // 
            this.player2card2.BackColor = System.Drawing.Color.Transparent;
            this.player2card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2card2.Location = new System.Drawing.Point(442, 388);
            this.player2card2.Margin = new System.Windows.Forms.Padding(1);
            this.player2card2.Name = "player2card2";
            this.player2card2.Size = new System.Drawing.Size(103, 130);
            this.player2card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2card2.TabIndex = 38;
            this.player2card2.TabStop = false;
            this.player2card2.MouseEnter += new System.EventHandler(this.player2CardMouseEnter);
            this.player2card2.MouseLeave += new System.EventHandler(this.player2CardMouseLeave);
            // 
            // player2card1
            // 
            this.player2card1.BackColor = System.Drawing.Color.Transparent;
            this.player2card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2card1.Location = new System.Drawing.Point(549, 378);
            this.player2card1.Margin = new System.Windows.Forms.Padding(1);
            this.player2card1.Name = "player2card1";
            this.player2card1.Size = new System.Drawing.Size(103, 130);
            this.player2card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2card1.TabIndex = 39;
            this.player2card1.TabStop = false;
            this.player2card1.MouseEnter += new System.EventHandler(this.player2CardMouseEnter);
            this.player2card1.MouseLeave += new System.EventHandler(this.player2CardMouseLeave);
            // 
            // player2card3
            // 
            this.player2card3.BackColor = System.Drawing.Color.Transparent;
            this.player2card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2card3.Location = new System.Drawing.Point(654, 388);
            this.player2card3.Margin = new System.Windows.Forms.Padding(1);
            this.player2card3.Name = "player2card3";
            this.player2card3.Size = new System.Drawing.Size(103, 130);
            this.player2card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2card3.TabIndex = 40;
            this.player2card3.TabStop = false;
            this.player2card3.MouseEnter += new System.EventHandler(this.player2CardMouseEnter);
            this.player2card3.MouseLeave += new System.EventHandler(this.player2CardMouseLeave);
            // 
            // player2card5
            // 
            this.player2card5.BackColor = System.Drawing.Color.Transparent;
            this.player2card5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2card5.Location = new System.Drawing.Point(760, 398);
            this.player2card5.Margin = new System.Windows.Forms.Padding(1);
            this.player2card5.Name = "player2card5";
            this.player2card5.Size = new System.Drawing.Size(103, 130);
            this.player2card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2card5.TabIndex = 41;
            this.player2card5.TabStop = false;
            this.player2card5.MouseEnter += new System.EventHandler(this.player2CardMouseEnter);
            this.player2card5.MouseLeave += new System.EventHandler(this.player2CardMouseLeave);
            // 
            // player2card7
            // 
            this.player2card7.BackColor = System.Drawing.Color.Transparent;
            this.player2card7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2card7.Location = new System.Drawing.Point(866, 418);
            this.player2card7.Margin = new System.Windows.Forms.Padding(1);
            this.player2card7.Name = "player2card7";
            this.player2card7.Size = new System.Drawing.Size(103, 130);
            this.player2card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2card7.TabIndex = 42;
            this.player2card7.TabStop = false;
            this.player2card7.MouseEnter += new System.EventHandler(this.player2CardMouseEnter);
            this.player2card7.MouseLeave += new System.EventHandler(this.player2CardMouseLeave);
            // 
            // player2card6
            // 
            this.player2card6.BackColor = System.Drawing.Color.Transparent;
            this.player2card6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player2card6.Location = new System.Drawing.Point(230, 408);
            this.player2card6.Margin = new System.Windows.Forms.Padding(1);
            this.player2card6.Name = "player2card6";
            this.player2card6.Size = new System.Drawing.Size(103, 130);
            this.player2card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2card6.TabIndex = 43;
            this.player2card6.TabStop = false;
            this.player2card6.MouseEnter += new System.EventHandler(this.player2CardMouseEnter);
            this.player2card6.MouseLeave += new System.EventHandler(this.player2CardMouseLeave);
            // 
            // player1card1
            // 
            this.player1card1.BackColor = System.Drawing.Color.Transparent;
            this.player1card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1card1.Location = new System.Drawing.Point(549, 238);
            this.player1card1.Margin = new System.Windows.Forms.Padding(1);
            this.player1card1.Name = "player1card1";
            this.player1card1.Size = new System.Drawing.Size(103, 130);
            this.player1card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1card1.TabIndex = 44;
            this.player1card1.TabStop = false;
            this.player1card1.MouseEnter += new System.EventHandler(this.player1CardMouseEnter);
            this.player1card1.MouseLeave += new System.EventHandler(this.player1CardMouseLeave);
            // 
            // player1card3
            // 
            this.player1card3.BackColor = System.Drawing.Color.Transparent;
            this.player1card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1card3.Location = new System.Drawing.Point(654, 228);
            this.player1card3.Margin = new System.Windows.Forms.Padding(1);
            this.player1card3.Name = "player1card3";
            this.player1card3.Size = new System.Drawing.Size(103, 130);
            this.player1card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1card3.TabIndex = 45;
            this.player1card3.TabStop = false;
            this.player1card3.MouseEnter += new System.EventHandler(this.player1CardMouseEnter);
            this.player1card3.MouseLeave += new System.EventHandler(this.player1CardMouseLeave);
            // 
            // player1card2
            // 
            this.player1card2.BackColor = System.Drawing.Color.Transparent;
            this.player1card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1card2.Location = new System.Drawing.Point(442, 228);
            this.player1card2.Margin = new System.Windows.Forms.Padding(1);
            this.player1card2.Name = "player1card2";
            this.player1card2.Size = new System.Drawing.Size(103, 130);
            this.player1card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1card2.TabIndex = 46;
            this.player1card2.TabStop = false;
            this.player1card2.MouseEnter += new System.EventHandler(this.player1CardMouseEnter);
            this.player1card2.MouseLeave += new System.EventHandler(this.player1CardMouseLeave);
            // 
            // player1card4
            // 
            this.player1card4.BackColor = System.Drawing.Color.Transparent;
            this.player1card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1card4.Location = new System.Drawing.Point(335, 218);
            this.player1card4.Margin = new System.Windows.Forms.Padding(1);
            this.player1card4.Name = "player1card4";
            this.player1card4.Size = new System.Drawing.Size(103, 130);
            this.player1card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1card4.TabIndex = 47;
            this.player1card4.TabStop = false;
            this.player1card4.MouseEnter += new System.EventHandler(this.player1CardMouseEnter);
            this.player1card4.MouseLeave += new System.EventHandler(this.player1CardMouseLeave);
            // 
            // player1card5
            // 
            this.player1card5.BackColor = System.Drawing.Color.Transparent;
            this.player1card5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1card5.Location = new System.Drawing.Point(760, 218);
            this.player1card5.Margin = new System.Windows.Forms.Padding(1);
            this.player1card5.Name = "player1card5";
            this.player1card5.Size = new System.Drawing.Size(103, 130);
            this.player1card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1card5.TabIndex = 48;
            this.player1card5.TabStop = false;
            this.player1card5.MouseEnter += new System.EventHandler(this.player1CardMouseEnter);
            this.player1card5.MouseLeave += new System.EventHandler(this.player1CardMouseLeave);
            // 
            // player1card7
            // 
            this.player1card7.BackColor = System.Drawing.Color.Transparent;
            this.player1card7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1card7.Location = new System.Drawing.Point(866, 208);
            this.player1card7.Margin = new System.Windows.Forms.Padding(1);
            this.player1card7.Name = "player1card7";
            this.player1card7.Size = new System.Drawing.Size(103, 130);
            this.player1card7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1card7.TabIndex = 49;
            this.player1card7.TabStop = false;
            this.player1card7.MouseEnter += new System.EventHandler(this.player1CardMouseEnter);
            this.player1card7.MouseLeave += new System.EventHandler(this.player1CardMouseLeave);
            // 
            // player1card6
            // 
            this.player1card6.BackColor = System.Drawing.Color.Transparent;
            this.player1card6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player1card6.Location = new System.Drawing.Point(230, 208);
            this.player1card6.Margin = new System.Windows.Forms.Padding(1);
            this.player1card6.Name = "player1card6";
            this.player1card6.Size = new System.Drawing.Size(103, 130);
            this.player1card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1card6.TabIndex = 50;
            this.player1card6.TabStop = false;
            this.player1card6.MouseEnter += new System.EventHandler(this.player1CardMouseEnter);
            this.player1card6.MouseLeave += new System.EventHandler(this.player1CardMouseLeave);
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Location = new System.Drawing.Point(3, 191);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(197, 261);
            this.pictureBox16.TabIndex = 51;
            this.pictureBox16.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.player1card6);
            this.Controls.Add(this.player1card7);
            this.Controls.Add(this.player1card5);
            this.Controls.Add(this.player1card4);
            this.Controls.Add(this.player2card6);
            this.Controls.Add(this.player2card7);
            this.Controls.Add(this.player2card5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputURL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.player1ManaCristals);
            this.Controls.Add(this.player2ManaCristals);
            this.Controls.Add(this.player1Health);
            this.Controls.Add(this.player2Health);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.player2card4);
            this.Controls.Add(this.player2CardsLeft);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.round);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.player1CardsLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.player1card1);
            this.Controls.Add(this.player1card3);
            this.Controls.Add(this.player2card2);
            this.Controls.Add(this.player2card1);
            this.Controls.Add(this.player2card3);
            this.Controls.Add(this.player1card2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Text = "CameraCardGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.player2card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoPlayer;
        private System.Windows.Forms.TextBox inputURL;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player1CardsLeft;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label player2CardsLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox player2card4;
        private System.Windows.Forms.Timer player1Timer;
        private System.Windows.Forms.Timer player2Timer;
        private System.Windows.Forms.Timer gameStatsUpdate;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label player2Health;
        private System.Windows.Forms.Label player1Health;
        private System.Windows.Forms.Label player2ManaCristals;
        private System.Windows.Forms.Label player1ManaCristals;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox player2card2;
        private System.Windows.Forms.PictureBox player2card1;
        private System.Windows.Forms.PictureBox player2card3;
        private System.Windows.Forms.PictureBox player2card5;
        private System.Windows.Forms.PictureBox player2card7;
        private System.Windows.Forms.PictureBox player2card6;
        private System.Windows.Forms.PictureBox player1card1;
        private System.Windows.Forms.PictureBox player1card3;
        private System.Windows.Forms.PictureBox player1card2;
        private System.Windows.Forms.PictureBox player1card4;
        private System.Windows.Forms.PictureBox player1card5;
        private System.Windows.Forms.PictureBox player1card7;
        private System.Windows.Forms.PictureBox player1card6;
        private System.Windows.Forms.PictureBox pictureBox16;
    }
}

