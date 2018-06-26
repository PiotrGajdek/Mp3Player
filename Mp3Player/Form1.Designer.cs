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
            this.MuteButton = new System.Windows.Forms.Button();
            this.VolDownButton = new System.Windows.Forms.Button();
            this.VolUpButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.AddFolderButton = new System.Windows.Forms.Button();
            this.AddFilesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playlist = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MuteButton
            // 
            this.MuteButton.Location = new System.Drawing.Point(177, 117);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(75, 23);
            this.MuteButton.TabIndex = 25;
            this.MuteButton.Text = "Mute";
            this.MuteButton.UseVisualStyleBackColor = true;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // VolDownButton
            // 
            this.VolDownButton.Location = new System.Drawing.Point(96, 117);
            this.VolDownButton.Name = "VolDownButton";
            this.VolDownButton.Size = new System.Drawing.Size(75, 23);
            this.VolDownButton.TabIndex = 24;
            this.VolDownButton.Text = "Vol Down";
            this.VolDownButton.UseVisualStyleBackColor = true;
            this.VolDownButton.Click += new System.EventHandler(this.VolDownButton_Click);
            // 
            // VolUpButton
            // 
            this.VolUpButton.Location = new System.Drawing.Point(15, 117);
            this.VolUpButton.Name = "VolUpButton";
            this.VolUpButton.Size = new System.Drawing.Size(75, 23);
            this.VolUpButton.TabIndex = 23;
            this.VolUpButton.Text = "Vol Up";
            this.VolUpButton.UseVisualStyleBackColor = true;
            this.VolUpButton.Click += new System.EventHandler(this.VolUpButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Następna odtwarzana piosenka";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(336, 55);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 21;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
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
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Odtwarzana Piosenka";
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(93, 55);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 23);
            this.PrevButton.TabIndex = 17;
            this.PrevButton.Text = "Poprz.";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(255, 55);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 16;
            this.NextButton.Text = "Nast.";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(15, 55);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 15;
            this.PlayButton.Text = "Play/Pause";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "0:00 / 0:00";
            // 
            // playlist
            // 
            this.playlist.FormattingEnabled = true;
            this.playlist.Location = new System.Drawing.Point(12, 158);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(399, 368);
            this.playlist.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 571);
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

