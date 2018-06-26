namespace Mp3Player
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.AddFolderButton = new System.Windows.Forms.Button();
            this.AddFilesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playlist = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MuteButton = new System.Windows.Forms.Button();
            this.VolDownButton = new System.Windows.Forms.Button();
            this.VolUpButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Następna odtwarzana piosenka";
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.Location = new System.Drawing.Point(96, 533);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(75, 23);
            this.AddFolderButton.TabIndex = 20;
            this.AddFolderButton.Text = "Dodaj folder";
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // AddFilesButton
            // 
            this.AddFilesButton.Location = new System.Drawing.Point(12, 533);
            this.AddFilesButton.Name = "AddFilesButton";
            this.AddFilesButton.Size = new System.Drawing.Size(75, 23);
            this.AddFilesButton.TabIndex = 19;
            this.AddFilesButton.Text = "Dodaj pliki";
            this.AddFilesButton.UseVisualStyleBackColor = true;
            this.AddFilesButton.Click += new System.EventHandler(this.AddFilesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Odtwarzana Piosenka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "0:00 / 0:00";
            // 
            // playlist
            // 
            this.playlist.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 19;
            this.playlist.Location = new System.Drawing.Point(12, 184);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(386, 327);
            this.playlist.TabIndex = 13;
            this.playlist.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MuteButton
            // 
            this.MuteButton.BackgroundImage = global::Mp3Player.Properties.Resources.mute;
            this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MuteButton.Location = new System.Drawing.Point(348, 128);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(50, 50);
            this.MuteButton.TabIndex = 25;
            this.MuteButton.UseVisualStyleBackColor = true;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // VolDownButton
            // 
            this.VolDownButton.BackgroundImage = global::Mp3Player.Properties.Resources.volumeDown;
            this.VolDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolDownButton.Location = new System.Drawing.Point(180, 128);
            this.VolDownButton.Name = "VolDownButton";
            this.VolDownButton.Size = new System.Drawing.Size(50, 50);
            this.VolDownButton.TabIndex = 24;
            this.VolDownButton.UseVisualStyleBackColor = true;
            this.VolDownButton.Click += new System.EventHandler(this.VolDownButton_Click);
            // 
            // VolUpButton
            // 
            this.VolUpButton.BackgroundImage = global::Mp3Player.Properties.Resources.volumeUp;
            this.VolUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolUpButton.Location = new System.Drawing.Point(15, 128);
            this.VolUpButton.Name = "VolUpButton";
            this.VolUpButton.Size = new System.Drawing.Size(50, 50);
            this.VolUpButton.TabIndex = 23;
            this.VolUpButton.UseVisualStyleBackColor = true;
            this.VolUpButton.Click += new System.EventHandler(this.VolUpButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImage = global::Mp3Player.Properties.Resources.stop;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopButton.Location = new System.Drawing.Point(348, 14);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(50, 50);
            this.StopButton.TabIndex = 21;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.BackgroundImage = global::Mp3Player.Properties.Resources.previous1;
            this.PrevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrevButton.Location = new System.Drawing.Point(180, 12);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(50, 50);
            this.PrevButton.TabIndex = 17;
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackgroundImage = global::Mp3Player.Properties.Resources.next;
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextButton.Location = new System.Drawing.Point(292, 12);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(50, 50);
            this.NextButton.TabIndex = 16;
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = global::Mp3Player.Properties.Resources.play;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Location = new System.Drawing.Point(236, 12);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(50, 50);
            this.PlayButton.TabIndex = 15;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 571);
            this.Controls.Add(this.MuteButton);
            this.Controls.Add(this.VolDownButton);
            this.Controls.Add(this.VolUpButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.AddFolderButton);
            this.Controls.Add(this.AddFilesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playlist);
            this.Name = "Form1";
            this.Text = "Odtwarzacze MP3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MuteButton;
        private System.Windows.Forms.Button VolDownButton;
        private System.Windows.Forms.Button VolUpButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button AddFolderButton;
        private System.Windows.Forms.Button AddFilesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

