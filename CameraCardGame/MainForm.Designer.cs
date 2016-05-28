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
            this.showCameraVideo = new System.Windows.Forms.Button();
            this.closeCameraVideo = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1CardsLeft = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.round = new System.Windows.Forms.Label();
            this.player2CardsLeft = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.inputURL.Location = new System.Drawing.Point(18, 230);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(163, 20);
            this.inputURL.TabIndex = 1;
            // 
            // showCameraVideo
            // 
            this.showCameraVideo.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCameraVideo.Location = new System.Drawing.Point(75, 251);
            this.showCameraVideo.Name = "showCameraVideo";
            this.showCameraVideo.Size = new System.Drawing.Size(104, 29);
            this.showCameraVideo.TabIndex = 3;
            this.showCameraVideo.Text = "Connect";
            this.showCameraVideo.UseVisualStyleBackColor = true;
            this.showCameraVideo.Click += new System.EventHandler(this.showCameraVideo_Click);
            // 
            // closeCameraVideo
            // 
            this.closeCameraVideo.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeCameraVideo.Location = new System.Drawing.Point(18, 251);
            this.closeCameraVideo.Name = "closeCameraVideo";
            this.closeCameraVideo.Size = new System.Drawing.Size(51, 21);
            this.closeCameraVideo.TabIndex = 4;
            this.closeCameraVideo.Text = "Close";
            this.closeCameraVideo.UseVisualStyleBackColor = true;
            this.closeCameraVideo.Click += new System.EventHandler(this.closeCameraVideo_Click);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.SystemColors.Info;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Location = new System.Drawing.Point(4, 367);
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(184, 318);
            this.messageBox.TabIndex = 6;
            this.messageBox.Text = "";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bell MT", 20F);
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(539, 681);
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
            this.label6.Location = new System.Drawing.Point(539, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Player 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(53, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Video URL";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(4, 345);
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
            this.label2.Location = new System.Drawing.Point(1050, 205);
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
            this.player1CardsLeft.Location = new System.Drawing.Point(1050, 230);
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
            this.label11.Location = new System.Drawing.Point(1050, 322);
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
            this.round.Location = new System.Drawing.Point(1050, 344);
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
            this.player2CardsLeft.Location = new System.Drawing.Point(1054, 453);
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
            this.label13.Location = new System.Drawing.Point(1054, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cards left";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(250, 365);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 110);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(840, 365);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
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
            this.timeLeft.Location = new System.Drawing.Point(1045, 44);
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
            this.label8.Location = new System.Drawing.Point(1041, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Timer";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Health
            // 
            this.player2Health.BackColor = System.Drawing.Color.Transparent;
            this.player2Health.Font = new System.Drawing.Font("Bell MT", 20F);
            this.player2Health.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player2Health.Location = new System.Drawing.Point(617, 620);
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
            this.player1Health.Location = new System.Drawing.Point(617, 177);
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
            this.player2ManaCristals.Location = new System.Drawing.Point(757, 689);
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
            this.player1ManaCristals.Location = new System.Drawing.Point(738, 31);
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
            this.startGame.Location = new System.Drawing.Point(465, 238);
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
            this.button2.Location = new System.Drawing.Point(465, 312);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 60);
            this.button2.TabIndex = 33;
            this.button2.Text = "Options";
            this.button2.UseVisualStyleBackColor = false;
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
            this.button3.Location = new System.Drawing.Point(465, 413);
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
            this.button1.Location = new System.Drawing.Point(4, 705);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 44);
            this.button1.TabIndex = 35;
            this.button1.Text = "Show menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.player2CardsLeft);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.round);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.player1CardsLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.closeCameraVideo);
            this.Controls.Add(this.showCameraVideo);
            this.Controls.Add(this.inputURL);
            this.Controls.Add(this.videoPlayer);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Text = "CameraCardGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoPlayer;
        private System.Windows.Forms.TextBox inputURL;
        private System.Windows.Forms.Button showCameraVideo;
        private System.Windows.Forms.Button closeCameraVideo;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label player1CardsLeft;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label player2CardsLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}

