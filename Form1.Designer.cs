namespace MyVideoChat
{
    partial class Form1
    {
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mnuDevices;
        private System.Windows.Forms.MenuItem mnuVideoDevices;
        private System.Windows.Forms.MenuItem mnuAudioDevices;
        private System.Windows.Forms.MenuItem mnuVideoCompressors;
        private System.Windows.Forms.MenuItem mnuAudioCompressors;
        private System.Windows.Forms.MenuItem mnuVideoSources;
        private System.Windows.Forms.MenuItem mnuAudioSources;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem mnuAudioChannels;
        private System.Windows.Forms.MenuItem mnuAudioSamplingRate;
        private System.Windows.Forms.MenuItem mnuAudioSampleSizes;
        private System.Windows.Forms.MenuItem mnuFrameSizes;
        private System.Windows.Forms.MenuItem mnuFrameRates;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem mnuPropertyPages;
        private System.Windows.Forms.MenuItem mnuVideoCaps;
        private System.Windows.Forms.MenuItem mnuAudioCaps;
        private System.Windows.Forms.MenuItem mnuChannel;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem mnuInputType;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox PeerIP_TXT;
        private System.Windows.Forms.Button button_PuchVideo;
        private System.Windows.Forms.PictureBox pictureBox_Remote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.TextBox ChatTable;
        public System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mnuDevices = new System.Windows.Forms.MenuItem();
            this.mnuVideoDevices = new System.Windows.Forms.MenuItem();
            this.mnuAudioDevices = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuVideoCompressors = new System.Windows.Forms.MenuItem();
            this.mnuAudioCompressors = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mnuVideoSources = new System.Windows.Forms.MenuItem();
            this.mnuFrameSizes = new System.Windows.Forms.MenuItem();
            this.mnuFrameRates = new System.Windows.Forms.MenuItem();
            this.mnuVideoCaps = new System.Windows.Forms.MenuItem();
            this.mnuAudioSources = new System.Windows.Forms.MenuItem();
            this.mnuAudioChannels = new System.Windows.Forms.MenuItem();
            this.mnuAudioSamplingRate = new System.Windows.Forms.MenuItem();
            this.mnuAudioSampleSizes = new System.Windows.Forms.MenuItem();
            this.mnuAudioCaps = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuChannel = new System.Windows.Forms.MenuItem();
            this.mnuInputType = new System.Windows.Forms.MenuItem();
            this.mnuPropertyPages = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PeerIP_TXT = new System.Windows.Forms.TextBox();
            this.button_PuchVideo = new System.Windows.Forms.Button();
            this.pictureBox_Remote = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.ChatTable = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LocalIPTXT = new System.Windows.Forms.TextBox();
            this.panelVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Remote)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDevices,
            this.menuItem7});
            // 
            // mnuDevices
            // 
            this.mnuDevices.Index = 0;
            this.mnuDevices.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuVideoDevices,
            this.mnuAudioDevices,
            this.menuItem4,
            this.mnuVideoCompressors,
            this.mnuAudioCompressors});
            this.mnuDevices.Text = "Devices";
            // 
            // mnuVideoDevices
            // 
            this.mnuVideoDevices.Index = 0;
            this.mnuVideoDevices.Text = "Video Devices";
            // 
            // mnuAudioDevices
            // 
            this.mnuAudioDevices.Index = 1;
            this.mnuAudioDevices.Text = "Audio Devices";
            this.mnuAudioDevices.Visible = false;
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            this.menuItem4.Visible = false;
            // 
            // mnuVideoCompressors
            // 
            this.mnuVideoCompressors.Index = 3;
            this.mnuVideoCompressors.Text = "Video Compressors";
            this.mnuVideoCompressors.Visible = false;
            // 
            // mnuAudioCompressors
            // 
            this.mnuAudioCompressors.Index = 4;
            this.mnuAudioCompressors.Text = "Audio Compressors";
            this.mnuAudioCompressors.Visible = false;
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuVideoSources,
            this.mnuFrameSizes,
            this.mnuFrameRates,
            this.mnuVideoCaps,
            this.mnuAudioSources,
            this.mnuAudioChannels,
            this.mnuAudioSamplingRate,
            this.mnuAudioSampleSizes,
            this.mnuAudioCaps,
            this.menuItem3,
            this.mnuChannel,
            this.mnuInputType,
            this.mnuPropertyPages,
            this.menuItem8});
            this.menuItem7.Text = "Options";
            // 
            // mnuVideoSources
            // 
            this.mnuVideoSources.Index = 0;
            this.mnuVideoSources.Text = "Video Sources";
            this.mnuVideoSources.Visible = false;
            // 
            // mnuFrameSizes
            // 
            this.mnuFrameSizes.Index = 1;
            this.mnuFrameSizes.Text = "Video Frame Size";
            // 
            // mnuFrameRates
            // 
            this.mnuFrameRates.Index = 2;
            this.mnuFrameRates.Text = "Video Frame Rate";
            // 
            // mnuVideoCaps
            // 
            this.mnuVideoCaps.Index = 3;
            this.mnuVideoCaps.Text = "Video Capabilities...";
            // 
            // mnuAudioSources
            // 
            this.mnuAudioSources.Index = 4;
            this.mnuAudioSources.Text = "Audio Sources";
            this.mnuAudioSources.Visible = false;
            // 
            // mnuAudioChannels
            // 
            this.mnuAudioChannels.Index = 5;
            this.mnuAudioChannels.Text = "Audio Channels";
            this.mnuAudioChannels.Visible = false;
            // 
            // mnuAudioSamplingRate
            // 
            this.mnuAudioSamplingRate.Index = 6;
            this.mnuAudioSamplingRate.Text = "Audio Sampling Rate";
            this.mnuAudioSamplingRate.Visible = false;
            // 
            // mnuAudioSampleSizes
            // 
            this.mnuAudioSampleSizes.Index = 7;
            this.mnuAudioSampleSizes.Text = "Audio Sample Size";
            this.mnuAudioSampleSizes.Visible = false;
            // 
            // mnuAudioCaps
            // 
            this.mnuAudioCaps.Index = 8;
            this.mnuAudioCaps.Text = "Audio Capabilities...";
            this.mnuAudioCaps.Visible = false;
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 9;
            this.menuItem3.Text = "-";
            this.menuItem3.Visible = false;
            // 
            // mnuChannel
            // 
            this.mnuChannel.Index = 10;
            this.mnuChannel.Text = "TV Tuner Channel";
            this.mnuChannel.Visible = false;
            // 
            // mnuInputType
            // 
            this.mnuInputType.Index = 11;
            this.mnuInputType.Text = "TV Tuner Input Type";
            this.mnuInputType.Visible = false;
            // 
            // mnuPropertyPages
            // 
            this.mnuPropertyPages.Index = 12;
            this.mnuPropertyPages.Text = "PropertyPages";
            this.mnuPropertyPages.Visible = false;
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 13;
            this.menuItem8.Text = "-";
            this.menuItem8.Visible = false;
            // 
            // panelVideo
            // 
            this.panelVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVideo.Controls.Add(this.pictureBox);
            this.panelVideo.ForeColor = System.Drawing.Color.White;
            this.panelVideo.Location = new System.Drawing.Point(27, 12);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(360, 257);
            this.panelVideo.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(360, 257);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Peer IP";
            // 
            // PeerIP_TXT
            // 
            this.PeerIP_TXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeerIP_TXT.Location = new System.Drawing.Point(70, 288);
            this.PeerIP_TXT.Name = "PeerIP_TXT";
            this.PeerIP_TXT.Size = new System.Drawing.Size(237, 23);
            this.PeerIP_TXT.TabIndex = 12;
            // 
            // button_PuchVideo
            // 
            this.button_PuchVideo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PuchVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_PuchVideo.Location = new System.Drawing.Point(321, 285);
            this.button_PuchVideo.Name = "button_PuchVideo";
            this.button_PuchVideo.Size = new System.Drawing.Size(155, 29);
            this.button_PuchVideo.TabIndex = 11;
            this.button_PuchVideo.Text = "Start Pouching Video";
            this.button_PuchVideo.UseVisualStyleBackColor = true;
            this.button_PuchVideo.Click += new System.EventHandler(this.button_PuchVideo_Click);
            // 
            // pictureBox_Remote
            // 
            this.pictureBox_Remote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Remote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox_Remote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Remote.Location = new System.Drawing.Point(406, 12);
            this.pictureBox_Remote.Name = "pictureBox_Remote";
            this.pictureBox_Remote.Size = new System.Drawing.Size(330, 257);
            this.pictureBox_Remote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Remote.TabIndex = 14;
            this.pictureBox_Remote.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(497, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "End and Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(38, 382);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(194, 20);
            this.Message.TabIndex = 17;
            // 
            // ChatTable
            // 
            this.ChatTable.Location = new System.Drawing.Point(487, 382);
            this.ChatTable.Name = "ChatTable";
            this.ChatTable.Size = new System.Drawing.Size(265, 20);
            this.ChatTable.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 20);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LocalIPTXT
            // 
            this.LocalIPTXT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalIPTXT.Location = new System.Drawing.Point(70, 326);
            this.LocalIPTXT.Name = "LocalIPTXT";
            this.LocalIPTXT.Size = new System.Drawing.Size(237, 23);
            this.LocalIPTXT.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.LocalIPTXT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.ChatTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_Remote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PeerIP_TXT);
            this.Controls.Add(this.button_PuchVideo);
            this.Controls.Add(this.panelVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyVideoChatExample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.P2PVideoCall_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.P2PVideoCall_Load);
            this.panelVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Remote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public System.Windows.Forms.TextBox LocalIPTXT;
    }
}

