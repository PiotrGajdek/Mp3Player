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
        public MediaPlayer player = new MediaPlayer();
        public bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();
            player.MediaOpened += new System.EventHandler(this.MediaOpened);
            player.MediaEnded += new System.EventHandler(this.MediaEnded);
            timer1.Interval = 500;
        }

        public void MediaOpened(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void MediaEnded(object sender, EventArgs e)
        {
            if (playlist.SelectedIndex + 1 <= playlist.Items.Count - 1)
            {
                playlist.SelectedIndex = playlist.SelectedIndex + 1;
                playSong(playlist.SelectedIndex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                if (player.NaturalDuration.HasTimeSpan)
                {
                    label1.Text = player.Position.ToString(@"mm\:ss") + " / " + player.NaturalDuration.TimeSpan.ToString(@"mm\:ss");
                }
            }
        }

        private void Mute()
        {
            player.Volume = 0;
        }

        private void VolDown()
        {
            player.Volume = player.Volume - 0.05;
        }

        private void VolUp()
        {
            player.Volume = player.Volume + 0.05;
        }

        private void VolUpButton_Click(object sender, EventArgs e)
        {
            VolUp();
        }

        private void VolDownButton_Click(object sender, EventArgs e)
        {
            VolDown();
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            Mute();
        }

        private void AddFilesButton_Click(object sender, EventArgs e)
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

        private void AddFolderButton_Click(object sender, EventArgs e)
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

        public void playSong(int index)
        {
            Uri currentSong = new Uri(playlist.Items[index].ToString());
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
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            playSong(playlist.SelectedIndex);
            isPlaying = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            isPlaying = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                player.Pause();
                isPlaying = false;

            }
            else
            {
                player.Play();
                isPlaying = true;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (playlist.SelectedIndex + 1 <= playlist.Items.Count - 1)
            {
                playlist.SelectedIndex = playlist.SelectedIndex + 1;
                playSong(playlist.SelectedIndex);
            }
            else
            {
                playlist.SelectedIndex = 0;
                playSong(playlist.SelectedIndex);
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (playlist.SelectedIndex - 1 >= 0)
            {
                playlist.SelectedIndex = playlist.SelectedIndex - 1;
                playSong(playlist.SelectedIndex);
            }
            else
            {
                playlist.SelectedIndex = playlist.Items.Count - 1;
                playSong(playlist.SelectedIndex);
            }
        }

    }
}
