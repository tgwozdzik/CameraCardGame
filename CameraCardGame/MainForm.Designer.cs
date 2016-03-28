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
            this.videoPlayer = new AForge.Controls.VideoSourcePlayer();
            this.inputURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showCameraVideo = new System.Windows.Forms.Button();
            this.closeCameraVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoPlayer.Location = new System.Drawing.Point(12, 12);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(348, 225);
            this.videoPlayer.TabIndex = 0;
            this.videoPlayer.Text = "videoPlayer";
            this.videoPlayer.VideoSource = null;
            // 
            // inputURL
            // 
            this.inputURL.Location = new System.Drawing.Point(12, 273);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(348, 20);
            this.inputURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Video URL";
            // 
            // showCameraVideo
            // 
            this.showCameraVideo.Location = new System.Drawing.Point(189, 313);
            this.showCameraVideo.Name = "showCameraVideo";
            this.showCameraVideo.Size = new System.Drawing.Size(171, 41);
            this.showCameraVideo.TabIndex = 3;
            this.showCameraVideo.Text = "Show";
            this.showCameraVideo.UseVisualStyleBackColor = true;
            this.showCameraVideo.Click += new System.EventHandler(this.showCameraVideo_Click);
            // 
            // closeCameraVideo
            // 
            this.closeCameraVideo.Location = new System.Drawing.Point(108, 313);
            this.closeCameraVideo.Name = "closeCameraVideo";
            this.closeCameraVideo.Size = new System.Drawing.Size(75, 41);
            this.closeCameraVideo.TabIndex = 4;
            this.closeCameraVideo.Text = "Close";
            this.closeCameraVideo.UseVisualStyleBackColor = true;
            this.closeCameraVideo.Click += new System.EventHandler(this.closeCameraVideo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 366);
            this.Controls.Add(this.closeCameraVideo);
            this.Controls.Add(this.showCameraVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputURL);
            this.Controls.Add(this.videoPlayer);
            this.Name = "MainForm";
            this.Text = "CameraCardGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoPlayer;
        private System.Windows.Forms.TextBox inputURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showCameraVideo;
        private System.Windows.Forms.Button closeCameraVideo;
    }
}

