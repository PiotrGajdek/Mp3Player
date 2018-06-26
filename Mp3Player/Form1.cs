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
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);
        
        public MediaPlayer player = new MediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Mute()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
               (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void VolDown()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
               (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
               (IntPtr)APPCOMMAND_VOLUME_UP);
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
    }
}
