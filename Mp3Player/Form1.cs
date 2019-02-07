using System;
using System.Web;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Linq;
using System.Collections.Generic;

namespace Mp3Player
{

    public partial class Form1 : Form
    {
        #region Variables
        public MediaPlayer player;
        public bool isPlaying;
        #endregion

        #region Form1
        public Form1()
        {
            InitializeComponent();
            player = new MediaPlayer();
            isPlaying = false;
            player.MediaOpened += new System.EventHandler(this.MediaOpened);
            player.MediaEnded += new System.EventHandler(this.MediaEnded);
            timer1.Interval = 500;
        }
        #endregion

        #region MediaOpened
        private void MediaOpened(object sender, EventArgs e)
        {
            MediaOpened();
        }
        #endregion

        #region MediaEnded
        private void MediaEnded(object sender, EventArgs e)
        {
            MediaEnded();
        }
        #endregion

        #region timer1_Tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTick();
        }
        #endregion

        #region VolUpButton_Click
        private void VolUpButton_Click(object sender, EventArgs e)
        {
            VolUp(player);
        }
        #endregion

        #region VolDownButton_Click
        private void VolDownButton_Click(object sender, EventArgs e)
        {
            VolDown(player);
        }
        #endregion

        #region MuteButton_Click
        private void MuteButton_Click(object sender, EventArgs e)
        {
            Mute(player);
        }
        #endregion

        #region AddFilesButton_Click
        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            AddFiles();
        }
        #endregion

        #region AddFolderButton_Click
        private void AddFolderButton_Click(object sender, EventArgs e)
        {
            AddFolder();
        }
        #endregion

        #region listBox1_DoubleClick
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            PlaySong();
        }
        #endregion

        #region StopButton_Click
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopSong(player);
        }
        #endregion

        #region PlayButton_Click
        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayPauseSong();
        }
        #endregion

        #region NextButton_Click
        private void NextButton_Click(object sender, EventArgs e)
        {
            NextSong();
        }
        #endregion

        #region PrevButton_Click
        private void PrevButton_Click(object sender, EventArgs e)
        {
            PrevSong();
        }
        #endregion

        #region MediaOpened
        public void MediaOpened()
        {
            timer1.Start();
        }
        #endregion

        #region MediaEnded
        public void MediaEnded()
        {
            if (playlist.SelectedIndex + 1 <= playlist.Items.Count - 1)
            {
                playlist.SelectedIndex = playlist.SelectedIndex + 1;
                PlaySong(player, playlist.SelectedItem.ToString());
            }
        }
        #endregion

        #region TimerTick
        public void TimerTick()
        {
            if (timer1.Enabled)
            {
                if (player.NaturalDuration.HasTimeSpan)
                {
                    label1.Text = player.Position.ToString(@"mm\:ss") + " / " + player.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
                }
            }
        }
        #endregion

        #region AddFiles
        public void AddFiles()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                playlist.Items.AddRange(openFileDialog1.FileNames);
            }

            if (playlist.SelectedIndex + 1 <= playlist.Items.Count - 1)
            {
                Uri nextSong = new Uri(playlist.Items[playlist.SelectedIndex + 1].ToString());
                label3.Text = "Następna Piosenka : " + HttpUtility.UrlDecode(nextSong.Segments[nextSong.Segments.Length - 1]).ToString();
            }
            else
            {
                label3.Text = "Następna Piosenka :";
            }
        }
        #endregion

        #region AddFolder
        public void AddFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                playlist.Items.AddRange(Directory.GetFiles(folderBrowserDialog1.SelectedPath));
                Directory.GetDirectories(folderBrowserDialog1.SelectedPath)
                    .ToList()
                    .ForEach((path) =>
                    {
                        playlist.Items.AddRange(Directory.GetFiles(path));
                    });
            }
        }
        #endregion

        #region PlaySong
        public void PlaySong(MediaPlayer player, string path)
        {
            Uri currentSong = new Uri(path);
            player.Open(currentSong);
            label2.Text = "Odtwarzana Piosenka : " + HttpUtility.UrlDecode(currentSong.Segments[currentSong.Segments.Length - 1]).ToString();
            if (playlist.SelectedIndex + 1 <= playlist.Items.Count - 1)
            {
                Uri nextSong = new Uri(playlist.Items[playlist.SelectedIndex + 1].ToString());
                label3.Text = "Następna Piosenka : " + HttpUtility.UrlDecode(nextSong.Segments[nextSong.Segments.Length - 1]).ToString();
            }
            else
            {
                label3.Text = "Następna Piosenka :";
            }
            player.Play();
            PlayButton.BackgroundImage = Properties.Resources.pause;
        }
        #endregion

        #region StopSong
        public void StopSong(MediaPlayer player)
        {
            player.Stop();
            PlayButton.BackgroundImage = Properties.Resources.play;
            isPlaying = false;
        }
        #endregion

        #region PlaySong
        public void PlaySong()
        {
            PlaySong(player,playlist.SelectedItem.ToString());
            isPlaying = true;
        }
        #endregion

        #region PlayPauseSong
        public void PlayPauseSong()
        {
            if (isPlaying)
            {
                player.Pause();
                PlayButton.BackgroundImage = Properties.Resources.play;
                isPlaying = false;

            }
            else
            {
                player.Play();
                PlayButton.BackgroundImage = Properties.Resources.pause;
                isPlaying = true;
            }
        }
        #endregion

        #region PrevSong
        public void PrevSong()
        {
            if (playlist.SelectedIndex - 1 >= 0)
            {
                playlist.SelectedIndex = playlist.SelectedIndex - 1;
                PlaySong(player, playlist.SelectedItem.ToString());
            }
            else
            {
                playlist.SelectedIndex = playlist.Items.Count - 1;
                PlaySong(player, playlist.SelectedItem.ToString());
            }
        }
        #endregion

        #region NextSong
        public void NextSong()
        {
            if (playlist.SelectedIndex + 1 <= playlist.Items.Count - 1)
            {
                playlist.SelectedIndex = playlist.SelectedIndex + 1;
                PlaySong(player, playlist.SelectedItem.ToString());
            }
            else
            {
                playlist.SelectedIndex = 0;
                PlaySong(player, playlist.SelectedItem.ToString());
            }
        }
        #endregion

        #region Mute
        public void Mute(MediaPlayer player)
        {
            player.Volume = 0;
        }
        #endregion

        #region VolDown
        public void VolDown(MediaPlayer player)
        {
            player.Volume = player.Volume - 0.05;
        }
        #endregion

        #region VolUp
        public void VolUp(MediaPlayer player)
        {
            player.Volume = player.Volume + 0.05;
        }
        #endregion

    }
}
