namespace MusicPlayerApp
{
    partial class frm_MusicPlayer_EN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MusicPlayer_EN));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btn_SelectSongs = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_actual = new System.Windows.Forms.Label();
            this.lbl_remaining = new System.Windows.Forms.Label();
            this.lbl_Footer = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pbx_Play_Pause = new System.Windows.Forms.PictureBox();
            this.pbx_Minimize = new System.Windows.Forms.PictureBox();
            this.pbx_Exit = new System.Windows.Forms.PictureBox();
            this.pbx_Stop = new System.Windows.Forms.PictureBox();
            this.pbx_Pre = new System.Windows.Forms.PictureBox();
            this.pbx_Mute = new System.Windows.Forms.PictureBox();
            this.pbx_Repeat = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.my_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbx_Next = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Play_Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Pre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Mute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Repeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Next)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkRed;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.pbx_Minimize);
            this.TopPanel.Controls.Add(this.pbx_Exit);
            this.TopPanel.Controls.Add(this.lbl_Logo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.ForeColor = System.Drawing.Color.White;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(707, 53);
            this.TopPanel.TabIndex = 20;
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.AutoSize = true;
            this.lbl_Logo.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logo.Location = new System.Drawing.Point(16, 13);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(125, 25);
            this.lbl_Logo.TabIndex = 0;
            this.lbl_Logo.Text = "Music Palyer";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 15;
            this.listBoxSongs.Location = new System.Drawing.Point(488, 54);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(216, 274);
            this.listBoxSongs.TabIndex = 21;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btn_SelectSongs
            // 
            this.btn_SelectSongs.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_SelectSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectSongs.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_SelectSongs.ForeColor = System.Drawing.Color.White;
            this.btn_SelectSongs.Location = new System.Drawing.Point(488, 328);
            this.btn_SelectSongs.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btn_SelectSongs.Name = "btn_SelectSongs";
            this.btn_SelectSongs.Size = new System.Drawing.Size(216, 55);
            this.btn_SelectSongs.TabIndex = 0;
            this.btn_SelectSongs.Text = "Select Songs";
            this.btn_SelectSongs.UseVisualStyleBackColor = false;
            this.btn_SelectSongs.Click += new System.EventHandler(this.btn_SelectSongs_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 54);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(431, 275);
            this.axWindowsMediaPlayer1.TabIndex = 23;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar1.Location = new System.Drawing.Point(67, 335);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 27);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lbl_actual
            // 
            this.lbl_actual.AutoSize = true;
            this.lbl_actual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_actual.Location = new System.Drawing.Point(12, 342);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(49, 13);
            this.lbl_actual.TabIndex = 25;
            this.lbl_actual.Text = "00:00:00";
            // 
            // lbl_remaining
            // 
            this.lbl_remaining.AutoSize = true;
            this.lbl_remaining.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_remaining.Location = new System.Drawing.Point(370, 342);
            this.lbl_remaining.Name = "lbl_remaining";
            this.lbl_remaining.Size = new System.Drawing.Size(49, 13);
            this.lbl_remaining.TabIndex = 26;
            this.lbl_remaining.Text = "00:00:00";
            // 
            // lbl_Footer
            // 
            this.lbl_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Footer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Footer.Location = new System.Drawing.Point(0, 415);
            this.lbl_Footer.Name = "lbl_Footer";
            this.lbl_Footer.Size = new System.Drawing.Size(707, 15);
            this.lbl_Footer.TabIndex = 27;
            this.lbl_Footer.Text = "Developed By : HooMaN  -  ©  2018";
            this.lbl_Footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(437, 53);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 276);
            this.trackBar1.TabIndex = 28;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.my_tooltip.SetToolTip(this.trackBar1, "Volume 50");
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pbx_Play_Pause
            // 
            this.pbx_Play_Pause.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Play_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Play_Pause.Image = global::MusicPlayerApp.Properties.Resources.play;
            this.pbx_Play_Pause.Location = new System.Drawing.Point(3, 369);
            this.pbx_Play_Pause.Name = "pbx_Play_Pause";
            this.pbx_Play_Pause.Size = new System.Drawing.Size(50, 50);
            this.pbx_Play_Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Play_Pause.TabIndex = 29;
            this.pbx_Play_Pause.TabStop = false;
            this.my_tooltip.SetToolTip(this.pbx_Play_Pause, "Play/Pause");
            this.pbx_Play_Pause.Click += new System.EventHandler(this.pbx_Play_Pause_Click);
            // 
            // pbx_Minimize
            // 
            this.pbx_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Minimize.Image = global::MusicPlayerApp.Properties.Resources.minimize;
            this.pbx_Minimize.Location = new System.Drawing.Point(614, 7);
            this.pbx_Minimize.Name = "pbx_Minimize";
            this.pbx_Minimize.Size = new System.Drawing.Size(37, 37);
            this.pbx_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Minimize.TabIndex = 1;
            this.pbx_Minimize.TabStop = false;
            this.pbx_Minimize.Click += new System.EventHandler(this.pbx_Minimize_Click);
            // 
            // pbx_Exit
            // 
            this.pbx_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Exit.Image = global::MusicPlayerApp.Properties.Resources.Close;
            this.pbx_Exit.Location = new System.Drawing.Point(657, 7);
            this.pbx_Exit.Name = "pbx_Exit";
            this.pbx_Exit.Size = new System.Drawing.Size(37, 37);
            this.pbx_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Exit.TabIndex = 1;
            this.pbx_Exit.TabStop = false;
            this.pbx_Exit.Click += new System.EventHandler(this.pbx_Exit_Click);
            // 
            // pbx_Stop
            // 
            this.pbx_Stop.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Stop.Image = global::MusicPlayerApp.Properties.Resources.Stop;
            this.pbx_Stop.Location = new System.Drawing.Point(59, 377);
            this.pbx_Stop.Name = "pbx_Stop";
            this.pbx_Stop.Size = new System.Drawing.Size(35, 35);
            this.pbx_Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Stop.TabIndex = 29;
            this.pbx_Stop.TabStop = false;
            this.my_tooltip.SetToolTip(this.pbx_Stop, "Stop");
            this.pbx_Stop.Click += new System.EventHandler(this.pbx_Stop_Click);
            // 
            // pbx_Pre
            // 
            this.pbx_Pre.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Pre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Pre.Image = global::MusicPlayerApp.Properties.Resources.previous;
            this.pbx_Pre.Location = new System.Drawing.Point(100, 377);
            this.pbx_Pre.Name = "pbx_Pre";
            this.pbx_Pre.Size = new System.Drawing.Size(35, 35);
            this.pbx_Pre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Pre.TabIndex = 29;
            this.pbx_Pre.TabStop = false;
            this.my_tooltip.SetToolTip(this.pbx_Pre, "Previous");
            this.pbx_Pre.Click += new System.EventHandler(this.pbx_Pre_Click);
            // 
            // pbx_Mute
            // 
            this.pbx_Mute.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Mute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Mute.Image = global::MusicPlayerApp.Properties.Resources.mute;
            this.pbx_Mute.Location = new System.Drawing.Point(182, 377);
            this.pbx_Mute.Name = "pbx_Mute";
            this.pbx_Mute.Size = new System.Drawing.Size(35, 35);
            this.pbx_Mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Mute.TabIndex = 29;
            this.pbx_Mute.TabStop = false;
            this.pbx_Mute.Click += new System.EventHandler(this.pbx_Mute_Click);
            this.pbx_Mute.MouseHover += new System.EventHandler(this.pbx_Mute_MouseHover);
            // 
            // pbx_Repeat
            // 
            this.pbx_Repeat.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Repeat.Image = global::MusicPlayerApp.Properties.Resources.repeat;
            this.pbx_Repeat.Location = new System.Drawing.Point(223, 377);
            this.pbx_Repeat.Name = "pbx_Repeat";
            this.pbx_Repeat.Size = new System.Drawing.Size(35, 35);
            this.pbx_Repeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Repeat.TabIndex = 29;
            this.pbx_Repeat.TabStop = false;
            this.my_tooltip.SetToolTip(this.pbx_Repeat, "Select One or More Track");
            this.pbx_Repeat.Click += new System.EventHandler(this.pbx_Repeat_Click);
            this.pbx_Repeat.MouseHover += new System.EventHandler(this.pbx_Repeat_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicPlayerApp.Properties.Resources.BackgrounMusic;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pbx_Next
            // 
            this.pbx_Next.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Next.Image = global::MusicPlayerApp.Properties.Resources.next;
            this.pbx_Next.Location = new System.Drawing.Point(141, 377);
            this.pbx_Next.Name = "pbx_Next";
            this.pbx_Next.Size = new System.Drawing.Size(35, 35);
            this.pbx_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Next.TabIndex = 29;
            this.pbx_Next.TabStop = false;
            this.my_tooltip.SetToolTip(this.pbx_Next, "Next");
            this.pbx_Next.Click += new System.EventHandler(this.pbx_Next_Click);
            // 
            // frm_MusicPlayer_EN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 430);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbx_Repeat);
            this.Controls.Add(this.pbx_Mute);
            this.Controls.Add(this.pbx_Next);
            this.Controls.Add(this.pbx_Pre);
            this.Controls.Add(this.pbx_Stop);
            this.Controls.Add(this.pbx_Play_Pause);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbl_Footer);
            this.Controls.Add(this.lbl_remaining);
            this.Controls.Add(this.lbl_actual);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btn_SelectSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MusicPlayer_EN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Play_Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Pre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Mute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Repeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Next)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pbx_Minimize;
        private System.Windows.Forms.PictureBox pbx_Exit;
        private System.Windows.Forms.Label lbl_Logo;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btn_SelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_actual;
        private System.Windows.Forms.Label lbl_remaining;
        private System.Windows.Forms.Label lbl_Footer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pbx_Play_Pause;
        private System.Windows.Forms.PictureBox pbx_Stop;
        private System.Windows.Forms.PictureBox pbx_Pre;
        private System.Windows.Forms.PictureBox pbx_Mute;
        private System.Windows.Forms.PictureBox pbx_Repeat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolTip my_tooltip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbx_Next;
    }
}

