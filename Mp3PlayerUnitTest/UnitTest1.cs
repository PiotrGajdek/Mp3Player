using System;
using System.Windows.Forms;
using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mp3Player;

namespace Mp3Player.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void Tests()
        {
            Form1 form1 = new Form1();
            MediaPlayer player = new MediaPlayer();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                form1.PlaySong(player, openFileDialog.FileName);

                Assert.IsTrue(player.CanPause);
            }


 
        }
    }
}



