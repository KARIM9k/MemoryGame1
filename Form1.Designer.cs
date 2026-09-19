namespace MemoryGame1
{
    partial class Form1
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
            this.panelStartGame = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelHowToPlay = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMainMenue = new System.Windows.Forms.Panel();
            this.modernButton1 = new ModernButton();
            this.modernButton3 = new ModernButton();
            this.modernButton2 = new ModernButton();
            this.modernButton4 = new ModernButton();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbMid = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.gbTimePerRound = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblTimePerRound = new System.Windows.Forms.Label();
            this.gbPlayer1Info = new System.Windows.Forms.GroupBox();
            this.gbPlayer2Info = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.gbGender1 = new System.Windows.Forms.GroupBox();
            this.rbMale1 = new System.Windows.Forms.RadioButton();
            this.rbFemale1 = new System.Windows.Forms.RadioButton();
            this.gbGender2 = new System.Windows.Forms.GroupBox();
            this.rbFemale2 = new System.Windows.Forms.RadioButton();
            this.rbMale2 = new System.Windows.Forms.RadioButton();
            this.gbNumberOfPlayers = new System.Windows.Forms.GroupBox();
            this.rbOnePlayer = new System.Windows.Forms.RadioButton();
            this.rbTwoPlayers = new System.Windows.Forms.RadioButton();
            this.panelMainMenue.SuspendLayout();
            this.panelStartGame.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelHowToPlay.SuspendLayout();
            this.panelMainMenue.SuspendLayout();
            this.gbLevel.SuspendLayout();
            this.gbTimePerRound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.gbPlayer1Info.SuspendLayout();
            this.gbPlayer2Info.SuspendLayout();
            this.gbGender1.SuspendLayout();
            this.gbGender2.SuspendLayout();
            this.gbNumberOfPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStartGame
            // 
            this.panelStartGame.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelStartGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartGame.Controls.Add(this.label2);
            this.panelStartGame.Location = new System.Drawing.Point(1147, 114);
            this.panelStartGame.Name = "panelStartGame";
            this.panelStartGame.Size = new System.Drawing.Size(53, 42);
            this.panelStartGame.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 69);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Game";
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.gbNumberOfPlayers);
            this.panelSettings.Controls.Add(this.gbPlayer2Info);
            this.panelSettings.Controls.Add(this.gbPlayer1Info);
            this.panelSettings.Controls.Add(this.gbTimePerRound);
            this.panelSettings.Controls.Add(this.gbLevel);
            this.panelSettings.Location = new System.Drawing.Point(255, 46);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(859, 519);
            this.panelSettings.TabIndex = 6;
            this.panelSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSettings_Paint);
            // 
            // panelHowToPlay
            // 
            this.panelHowToPlay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelHowToPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHowToPlay.Controls.Add(this.label4);
            this.panelHowToPlay.Location = new System.Drawing.Point(1145, 55);
            this.panelHowToPlay.Name = "panelHowToPlay";
            this.panelHowToPlay.Size = new System.Drawing.Size(55, 53);
            this.panelHowToPlay.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 69);
            this.label4.TabIndex = 0;
            this.label4.Text = "How To Play";
            // 
            // gbLevel
            // 
            this.gbLevel.Controls.Add(this.rbHard);
            this.gbLevel.Controls.Add(this.rbMid);
            this.gbLevel.Controls.Add(this.rbEasy);
            this.gbLevel.Location = new System.Drawing.Point(23, 27);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(192, 158);
            this.gbLevel.TabIndex = 0;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level :";
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(22, 30);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(59, 20);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // rbMid
            // 
            this.rbMid.AutoSize = true;
            this.rbMid.Location = new System.Drawing.Point(22, 71);
            this.rbMid.Name = "rbMid";
            this.rbMid.Size = new System.Drawing.Size(50, 20);
            this.rbMid.TabIndex = 1;
            this.rbMid.TabStop = true;
            this.rbMid.Text = "Mid";
            this.rbMid.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(22, 111);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(58, 20);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // gbTimePerRound
            // 
            this.gbTimePerRound.Controls.Add(this.lblTimePerRound);
            this.gbTimePerRound.Controls.Add(this.trackBar1);
            this.gbTimePerRound.Location = new System.Drawing.Point(237, 27);
            this.gbTimePerRound.Name = "gbTimePerRound";
            this.gbTimePerRound.Size = new System.Drawing.Size(280, 158);
            this.gbTimePerRound.TabIndex = 1;
            this.gbTimePerRound.TabStop = false;
            this.gbTimePerRound.Text = "Time Per Round :";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 75);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(252, 56);
            this.trackBar1.TabIndex = 0;
            // 
            // lblTimePerRound
            // 
            this.lblTimePerRound.AutoSize = true;
            this.lblTimePerRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblTimePerRound.Location = new System.Drawing.Point(71, 30);
            this.lblTimePerRound.Name = "lblTimePerRound";
            this.lblTimePerRound.Size = new System.Drawing.Size(118, 42);
            this.lblTimePerRound.TabIndex = 1;
            this.lblTimePerRound.Text = "label3";
            // 
            // gbPlayer1Info
            // 
            this.gbPlayer1Info.Controls.Add(this.gbGender1);
            this.gbPlayer1Info.Controls.Add(this.txtPlayer1);
            this.gbPlayer1Info.Controls.Add(this.label3);
            this.gbPlayer1Info.Location = new System.Drawing.Point(541, 197);
            this.gbPlayer1Info.Name = "gbPlayer1Info";
            this.gbPlayer1Info.Size = new System.Drawing.Size(297, 128);
            this.gbPlayer1Info.TabIndex = 2;
            this.gbPlayer1Info.TabStop = false;
            this.gbPlayer1Info.Text = "Player1 Info :";
            // 
            // gbPlayer2Info
            // 
            this.gbPlayer2Info.Controls.Add(this.gbGender2);
            this.gbPlayer2Info.Controls.Add(this.txtPlayer2);
            this.gbPlayer2Info.Controls.Add(this.label5);
            this.gbPlayer2Info.Location = new System.Drawing.Point(541, 338);
            this.gbPlayer2Info.Name = "gbPlayer2Info";
            this.gbPlayer2Info.Size = new System.Drawing.Size(297, 128);
            this.gbPlayer2Info.TabIndex = 3;
            this.gbPlayer2Info.TabStop = false;
            this.gbPlayer2Info.Text = "Player2 Info :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "PLayer1 :  ";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(86, 26);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(190, 22);
            this.txtPlayer1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Player2 :  ";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(78, 28);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(194, 22);
            this.txtPlayer2.TabIndex = 2;
            // 
            // gbGender1
            // 
            this.gbGender1.Controls.Add(this.rbFemale1);
            this.gbGender1.Controls.Add(this.rbMale1);
            this.gbGender1.Location = new System.Drawing.Point(6, 66);
            this.gbGender1.Name = "gbGender1";
            this.gbGender1.Size = new System.Drawing.Size(262, 56);
            this.gbGender1.TabIndex = 2;
            this.gbGender1.TabStop = false;
            this.gbGender1.Text = "Gender";
            // 
            // rbMale1
            // 
            this.rbMale1.AutoSize = true;
            this.rbMale1.Location = new System.Drawing.Point(15, 24);
            this.rbMale1.Name = "rbMale1";
            this.rbMale1.Size = new System.Drawing.Size(58, 20);
            this.rbMale1.TabIndex = 0;
            this.rbMale1.TabStop = true;
            this.rbMale1.Text = "Male";
            this.rbMale1.UseVisualStyleBackColor = true;
            // 
            // rbFemale1
            // 
            this.rbFemale1.AutoSize = true;
            this.rbFemale1.Location = new System.Drawing.Point(135, 24);
            this.rbFemale1.Name = "rbFemale1";
            this.rbFemale1.Size = new System.Drawing.Size(74, 20);
            this.rbFemale1.TabIndex = 1;
            this.rbFemale1.TabStop = true;
            this.rbFemale1.Text = "Female";
            this.rbFemale1.UseVisualStyleBackColor = true;
            // 
            // gbGender2
            // 
            this.gbGender2.Controls.Add(this.rbFemale2);
            this.gbGender2.Controls.Add(this.rbMale2);
            this.gbGender2.Location = new System.Drawing.Point(10, 66);
            this.gbGender2.Name = "gbGender2";
            this.gbGender2.Size = new System.Drawing.Size(262, 56);
            this.gbGender2.TabIndex = 3;
            this.gbGender2.TabStop = false;
            this.gbGender2.Text = "Gender";
            // 
            // rbFemale2
            // 
            this.rbFemale2.AutoSize = true;
            this.rbFemale2.Location = new System.Drawing.Point(135, 24);
            this.rbFemale2.Name = "rbFemale2";
            this.rbFemale2.Size = new System.Drawing.Size(74, 20);
            this.rbFemale2.TabIndex = 1;
            this.rbFemale2.TabStop = true;
            this.rbFemale2.Text = "Female";
            this.rbFemale2.UseVisualStyleBackColor = true;
            // 
            // rbMale2
            // 
            this.rbMale2.AutoSize = true;
            this.rbMale2.Location = new System.Drawing.Point(15, 24);
            this.rbMale2.Name = "rbMale2";
            this.rbMale2.Size = new System.Drawing.Size(58, 20);
            this.rbMale2.TabIndex = 0;
            this.rbMale2.TabStop = true;
            this.rbMale2.Text = "Male";
            this.rbMale2.UseVisualStyleBackColor = true;
            // 
            // gbNumberOfPlayers
            // 
            this.gbNumberOfPlayers.Controls.Add(this.rbTwoPlayers);
            this.gbNumberOfPlayers.Controls.Add(this.rbOnePlayer);
            this.gbNumberOfPlayers.Location = new System.Drawing.Point(541, 27);
            this.gbNumberOfPlayers.Name = "gbNumberOfPlayers";
            this.gbNumberOfPlayers.Size = new System.Drawing.Size(276, 50);
            this.gbNumberOfPlayers.TabIndex = 4;
            this.gbNumberOfPlayers.TabStop = false;
            this.gbNumberOfPlayers.Text = "Number Of Players : ";
            // 
            // rbOnePlayer
            // 
            this.rbOnePlayer.AutoSize = true;
            this.rbOnePlayer.Location = new System.Drawing.Point(25, 21);
            this.rbOnePlayer.Name = "rbOnePlayer";
            this.rbOnePlayer.Size = new System.Drawing.Size(95, 20);
            this.rbOnePlayer.TabIndex = 0;
            this.rbOnePlayer.TabStop = true;
            this.rbOnePlayer.Text = "One Player";
            this.rbOnePlayer.UseVisualStyleBackColor = true;
            // 
            // rbTwoPlayers
            // 
            this.rbTwoPlayers.AutoSize = true;
            this.rbTwoPlayers.Location = new System.Drawing.Point(145, 21);
            this.rbTwoPlayers.Name = "rbTwoPlayers";
            this.rbTwoPlayers.Size = new System.Drawing.Size(103, 20);
            this.rbTwoPlayers.TabIndex = 1;
            this.rbTwoPlayers.TabStop = true;
            this.rbTwoPlayers.Text = "Tow Players";
            this.rbTwoPlayers.UseVisualStyleBackColor = true;
            // 
            // panelMainMenue
            // 
            this.panelMainMenue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMainMenue.BackgroundImage = global::MemoryGame1.Properties.Resources.image_640b8fd7;
            this.panelMainMenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainMenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainMenue.Controls.Add(this.modernButton1);
            this.panelMainMenue.Controls.Add(this.modernButton3);
            this.panelMainMenue.Controls.Add(this.modernButton2);
            this.panelMainMenue.Controls.Add(this.modernButton4);
            this.panelMainMenue.Location = new System.Drawing.Point(12, 46);
            this.panelMainMenue.Name = "panelMainMenue";
            this.panelMainMenue.Size = new System.Drawing.Size(237, 519);
            this.panelMainMenue.TabIndex = 5;
            // 
            // modernButton1
            // 
            this.modernButton1.BackColor = System.Drawing.Color.White;
            this.modernButton1.BorderColor = System.Drawing.Color.LightGray;
            this.modernButton1.BorderRadius = 20;
            this.modernButton1.BorderSize = 2;
            this.modernButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modernButton1.FlatAppearance.BorderSize = 0;
            this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.modernButton1.ForeColor = System.Drawing.Color.Black;
            this.modernButton1.Location = new System.Drawing.Point(22, 31);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.Size = new System.Drawing.Size(187, 78);
            this.modernButton1.TabIndex = 1;
            this.modernButton1.Text = "Start Game";
            this.modernButton1.UseVisualStyleBackColor = false;
            this.modernButton1.Click += new System.EventHandler(this.modernButton1_Click);
            // 
            // modernButton3
            // 
            this.modernButton3.BackColor = System.Drawing.Color.White;
            this.modernButton3.BorderColor = System.Drawing.Color.LightGray;
            this.modernButton3.BorderRadius = 20;
            this.modernButton3.BorderSize = 2;
            this.modernButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modernButton3.FlatAppearance.BorderSize = 0;
            this.modernButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.modernButton3.ForeColor = System.Drawing.Color.Black;
            this.modernButton3.Location = new System.Drawing.Point(22, 269);
            this.modernButton3.Name = "modernButton3";
            this.modernButton3.Size = new System.Drawing.Size(187, 78);
            this.modernButton3.TabIndex = 3;
            this.modernButton3.Text = "How To Play";
            this.modernButton3.UseVisualStyleBackColor = false;
            this.modernButton3.Click += new System.EventHandler(this.modernButton3_Click);
            // 
            // modernButton2
            // 
            this.modernButton2.BackColor = System.Drawing.Color.White;
            this.modernButton2.BorderColor = System.Drawing.Color.LightGray;
            this.modernButton2.BorderRadius = 20;
            this.modernButton2.BorderSize = 2;
            this.modernButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modernButton2.FlatAppearance.BorderSize = 0;
            this.modernButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.modernButton2.ForeColor = System.Drawing.Color.Black;
            this.modernButton2.Location = new System.Drawing.Point(22, 150);
            this.modernButton2.Name = "modernButton2";
            this.modernButton2.Size = new System.Drawing.Size(187, 78);
            this.modernButton2.TabIndex = 2;
            this.modernButton2.Text = "Settings";
            this.modernButton2.UseVisualStyleBackColor = false;
            this.modernButton2.Click += new System.EventHandler(this.modernButton2_Click);
            // 
            // modernButton4
            // 
            this.modernButton4.BackColor = System.Drawing.Color.White;
            this.modernButton4.BorderColor = System.Drawing.Color.LightGray;
            this.modernButton4.BorderRadius = 20;
            this.modernButton4.BorderSize = 2;
            this.modernButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modernButton4.FlatAppearance.BorderSize = 0;
            this.modernButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.modernButton4.ForeColor = System.Drawing.Color.Black;
            this.modernButton4.Location = new System.Drawing.Point(22, 388);
            this.modernButton4.Name = "modernButton4";
            this.modernButton4.Size = new System.Drawing.Size(187, 78);
            this.modernButton4.TabIndex = 4;
            this.modernButton4.Text = "Quit";
            this.modernButton4.UseVisualStyleBackColor = false;
            this.modernButton4.Click += new System.EventHandler(this.modernButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1210, 612);
            this.Controls.Add(this.panelMainMenue);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelHowToPlay);
            this.Controls.Add(this.panelStartGame);
            this.Name = "Form1";
            this.Text = "Card Mach Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStartGame.ResumeLayout(false);
            this.panelStartGame.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelHowToPlay.ResumeLayout(false);
            this.panelHowToPlay.PerformLayout();
            this.gbLevel.ResumeLayout(false);
            this.gbLevel.PerformLayout();
            this.gbTimePerRound.ResumeLayout(false);
            this.gbTimePerRound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.gbPlayer1Info.ResumeLayout(false);
            this.gbPlayer1Info.PerformLayout();
            this.gbPlayer2Info.ResumeLayout(false);
            this.gbPlayer2Info.PerformLayout();
            this.gbGender1.ResumeLayout(false);
            this.gbGender1.PerformLayout();
            this.gbGender2.ResumeLayout(false);
            this.gbGender2.PerformLayout();
            this.gbNumberOfPlayers.ResumeLayout(false);
            this.gbNumberOfPlayers.PerformLayout();
            this.panelMainMenue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ModernButton modernButton1;
        private ModernButton modernButton2;
        private ModernButton modernButton3;
        private ModernButton modernButton4;
        private System.Windows.Forms.Panel panelMainMenue;
        private System.Windows.Forms.Panel panelStartGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelHowToPlay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbTimePerRound;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMid;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox gbPlayer1Info;
        private System.Windows.Forms.Label lblTimePerRound;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox gbPlayer2Info;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbGender1;
        private System.Windows.Forms.RadioButton rbFemale1;
        private System.Windows.Forms.RadioButton rbMale1;
        private System.Windows.Forms.GroupBox gbGender2;
        private System.Windows.Forms.RadioButton rbFemale2;
        private System.Windows.Forms.RadioButton rbMale2;
        private System.Windows.Forms.GroupBox gbNumberOfPlayers;
        private System.Windows.Forms.RadioButton rbTwoPlayers;
        private System.Windows.Forms.RadioButton rbOnePlayer;
    }
}

