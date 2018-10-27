using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class frm_MusicPlayer_EN : Form
    {
        string[] paths, files; //ساخت آرایه ای از نوع رشته برای ذخیره نام و مسیر آهنگ ها
        bool stop = false;
        bool repeat = false;//default repeat off

        List<string> myList = new List<string>(); // ساخت لیست
        public frm_MusicPlayer_EN()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void pbx_Exit_Click(object sender, EventArgs e)
        {
            //Code to Close The App
            this.Close();
        }

        private void btn_SelectSongs_Click(object sender, EventArgs e)
        {
            //انتخاب آهنگ ها
            OpenFileDialog ofd = new OpenFileDialog();
            //انتخاب چند فایل 
            ofd.Multiselect = true;
            ofd.CheckFileExists = true;
            ofd.Filter = "Audios Only (*.mp3;*.wav;*.ogg;*.aac;*.amr;*.wma;*.m4a)|*.mp3;*.wav;*.ogg;*.aac;*.amr;*.wma;*.m4a";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;//ذخیره نام آهنگ ها در آرایه
                paths = ofd.FileNames;//ذخیره مسیر اهنگ ها در آرایه

                //نمایش عنوان آهنگ ها در لیست باکس
                for (int i = 0; i < files.Length; i++)
                {
                    if (!listBoxSongs.Items.Contains(files[i]))
                    {
                        listBoxSongs.Items.Add(files[i].Replace(".mp3", " "));//نمایش آهنگ ها در لیست باکس
                    }
                }
                myList.AddRange(paths);      //اضافه کردن مسیر آهنگ جدید
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // تبدیل لیست به آرایه
            var myArray = myList.ToArray();
            //کد پخش موزیک

            stop = false;
            if (listBoxSongs.SelectedIndex >= 0)
            {
                axWindowsMediaPlayer1.URL = myArray[listBoxSongs.SelectedIndex];
                my_tooltip.SetToolTip(listBoxSongs, listBoxSongs.Text.ToString());
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)
            {
                double dur = axWindowsMediaPlayer1.currentMedia.duration;
                progressBar1.Maximum = (int)dur;
            }

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)//تغییر ایکون پلی
            {
                pbx_Play_Pause.Image = Properties.Resources.pause;
                pictureBox1.Visible = false;
            }
            else
            {
                pbx_Play_Pause.Image = Properties.Resources.play;

            }
            if (stop == false)
            {
                if (repeat == true)
                {
                    if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        timer2.Start();
                    }
                }
                else
                {
                    if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
                    {
                        timer1.Enabled = true;
                        timer2.Start();
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int va = trackBar1.Value * 10;
            axWindowsMediaPlayer1.settings.volume = va;
            my_tooltip.SetToolTip(trackBar1, "Volume" + va);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            if (listBoxSongs.SelectedIndex < listBoxSongs.Items.Count - 1)
            {
                listBoxSongs.SelectedIndex++;
                timer1.Enabled = false;
            }
            else
            {
                pictureBox1.Visible = true;
                progressBar1.Value = 0;
                lbl_actual.Text = "00:00:00";
                lbl_remaining.Text = "00:00:00";
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MyTimer();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying || axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                // Get mouse position(x) minus the width of the progressbar (so beginning of the progressbar is mousepos = 0 //
                float absoluteMouse = (PointToClient(MousePosition).X - progressBar1.Bounds.X);
                // Calculate the factor for converting the position (progbarWidth/100) //
                float calcFactor = progressBar1.Width / (float)progressBar1.Maximum;
                // In the end convert the absolute mouse value to a relative mouse value by dividing the absolute mouse by the calcfactor //
                float relativeMouse = absoluteMouse / calcFactor;
                // Set the calculated relative value to the progressbar //
                progressBar1.Value = Convert.ToInt32(relativeMouse);
                //تغییر مقدار فعلی موقعیت اهنگ به مقدار جدید پروگس بار 
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
            }
        }

        private void pbx_Play_Pause_Click(object sender, EventArgs e)
        {
            stop = false;
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }

            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void pbx_Stop_Click(object sender, EventArgs e)
        {
            stop = true;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            pictureBox1.Visible = true;
            progressBar1.Value = 0;
            lbl_actual.Text = "00:00:00";
            lbl_remaining.Text = "00:00:00";
        }

        private void pbx_Pre_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex > 0)//تا زمانی که شماره ایندکس از 0 بزرگ تر باشد یعنی به انتهای لیست نرسیده باشد
            {
                listBoxSongs.SelectedIndex -= 1;
            }
        }

        private void pbx_Next_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex < listBoxSongs.Items.Count - 1)//تا زمانی که شماره ایندکس از تعداد آهنگ -1 کوچکتر است
            {
                listBoxSongs.SelectedIndex += 1;
            }
        }

        private void pbx_Mute_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.settings.mute == false)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                pbx_Mute.Image = Properties.Resources.mute;
                pbx_Mute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                pbx_Mute.Image = Properties.Resources.unmute;
                pbx_Mute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        private void pbx_Repeat_Click(object sender, EventArgs e)
        {
            if (repeat == false)
            {
                repeat = true;
                pbx_Repeat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                repeat = false;
                pbx_Repeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        private void pbx_Mute_MouseHover(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.settings.mute == false)
            {
                my_tooltip.SetToolTip(pbx_Mute, "Mute: OFF");
            }
            else
            {
                my_tooltip.SetToolTip(pbx_Mute, "Mute: ON");
            }
        }

        private void pbx_Repeat_MouseHover(object sender, EventArgs e)
        {
            if (repeat == false)
            {
                my_tooltip.SetToolTip(pbx_Repeat, "Repeat: OFF");
            }
            else
            {
                my_tooltip.SetToolTip(pbx_Repeat, "Repeat: ON");
            }
        }

        private void pbx_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //////////////////////////////////////****** My Function *****/////////////////////
        public void MyTimer()
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                int Total = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);
                progressBar1.Maximum = Total;
                string format = null;
                if (Total < 3600)
                {
                    format = "00:";
                }
                // lbl_total.Text = format + axWindowsMediaPlayer1.currentMedia.durationString;

                int ACTUAL = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                if (ACTUAL < 3600)
                {
                    format = "00:";
                }
                if (ACTUAL < Total)
                {
                    lbl_actual.Text = format + axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                    progressBar1.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                    decimal rem = Total - ACTUAL;
                    decimal hours = Math.Floor(rem / 3600);
                    decimal min = Math.Floor((rem / 60) - (hours * 60));
                    decimal sec = rem - (min * 60) - (hours * 3600);

                    string h = hours.ToString("00");
                    string m = min.ToString("00");
                    string s = sec.ToString("00");

                    lbl_remaining.Text = h + ":" + m + ":" + s;
                    my_tooltip.SetToolTip(progressBar1, lbl_actual.Text + " / " + lbl_remaining.Text);
                }
                else
                {
                    timer2.Stop();
                    progressBar1.Value = 0;
                    // lbl_total.Text = "0";
                    lbl_actual.Text = "00:00:00";
                    lbl_remaining.Text = "00:00:00";

                }
            }
        }
    }
}
