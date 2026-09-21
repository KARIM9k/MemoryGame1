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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelStartGame = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHowToPlay = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMainMenue = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSettings = new System.Windows.Forms.Panel();
            this.gbNumberOfRounds = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbNumberOfPlayers = new System.Windows.Forms.GroupBox();
            this.rbTwoPlayers = new System.Windows.Forms.RadioButton();
            this.rbOnePlayer = new System.Windows.Forms.RadioButton();
            this.gbPlayer2Info = new System.Windows.Forms.GroupBox();
            this.gbGender2 = new System.Windows.Forms.GroupBox();
            this.rbFemale2 = new System.Windows.Forms.RadioButton();
            this.rbMale2 = new System.Windows.Forms.RadioButton();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPlayer1Info = new System.Windows.Forms.GroupBox();
            this.gbGender1 = new System.Windows.Forms.GroupBox();
            this.rbFemale1 = new System.Windows.Forms.RadioButton();
            this.rbMale1 = new System.Windows.Forms.RadioButton();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTimePerRound = new System.Windows.Forms.GroupBox();
            this.lblTimePerRound = new System.Windows.Forms.Label();
            this.tbTimePerRound = new System.Windows.Forms.TrackBar();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMid = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.modernButton1 = new ModernButton();
            this.modernButton3 = new ModernButton();
            this.modernButton2 = new ModernButton();
            this.modernButton4 = new ModernButton();
            this.cgbLevel = new CustomGroupBox();
            this.panelStartGame.SuspendLayout();
            this.panelHowToPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMainMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.gbNumberOfRounds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbNumberOfPlayers.SuspendLayout();
            this.gbPlayer2Info.SuspendLayout();
            this.gbGender2.SuspendLayout();
            this.gbPlayer1Info.SuspendLayout();
            this.gbGender1.SuspendLayout();
            this.gbTimePerRound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimePerRound)).BeginInit();
            this.cgbLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStartGame
            // 
            this.panelStartGame.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelStartGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartGame.Controls.Add(this.label2);
            this.panelStartGame.Location = new System.Drawing.Point(1156, 48);
            this.panelStartGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelStartGame.Name = "panelStartGame";
            this.panelStartGame.Size = new System.Drawing.Size(53, 41);
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
            // panelHowToPlay
            // 
            this.panelHowToPlay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelHowToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHowToPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHowToPlay.Controls.Add(this.pictureBox1);
            this.panelHowToPlay.Location = new System.Drawing.Point(267, 47);
            this.panelHowToPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHowToPlay.Name = "panelHowToPlay";
            this.panelHowToPlay.Size = new System.Drawing.Size(859, 519);
            this.panelHowToPlay.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MemoryGame1.Properties.Resources.image_2748e566;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 517);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMainMenue
            // 
            this.panelMainMenue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMainMenue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMainMenue.BackgroundImage")));
            this.panelMainMenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainMenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainMenue.Controls.Add(this.modernButton1);
            this.panelMainMenue.Controls.Add(this.modernButton3);
            this.panelMainMenue.Controls.Add(this.modernButton2);
            this.panelMainMenue.Controls.Add(this.modernButton4);
            this.panelMainMenue.Location = new System.Drawing.Point(12, 47);
            this.panelMainMenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMainMenue.Name = "panelMainMenue";
            this.panelMainMenue.Size = new System.Drawing.Size(237, 519);
            this.panelMainMenue.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.cgbLevel);
            this.panelSettings.Controls.Add(this.gbNumberOfRounds);
            this.panelSettings.Controls.Add(this.gbNumberOfPlayers);
            this.panelSettings.Controls.Add(this.gbPlayer2Info);
            this.panelSettings.Controls.Add(this.gbPlayer1Info);
            this.panelSettings.Controls.Add(this.gbTimePerRound);
            this.panelSettings.Location = new System.Drawing.Point(263, 47);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(887, 518);
            this.panelSettings.TabIndex = 6;
            this.panelSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSettings_Paint);
            // 
            // gbNumberOfRounds
            // 
            this.gbNumberOfRounds.Controls.Add(this.label1);
            this.gbNumberOfRounds.Controls.Add(this.numericUpDown1);
            this.gbNumberOfRounds.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumberOfRounds.Location = new System.Drawing.Point(237, 382);
            this.gbNumberOfRounds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNumberOfRounds.Name = "gbNumberOfRounds";
            this.gbNumberOfRounds.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNumberOfRounds.Size = new System.Drawing.Size(256, 108);
            this.gbNumberOfRounds.TabIndex = 2;
            this.gbNumberOfRounds.TabStop = false;
            this.gbNumberOfRounds.Text = "Number Of Rounds : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rounds :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 54);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 27);
            this.numericUpDown1.TabIndex = 0;
            // 
            // gbNumberOfPlayers
            // 
            this.gbNumberOfPlayers.Controls.Add(this.rbTwoPlayers);
            this.gbNumberOfPlayers.Controls.Add(this.rbOnePlayer);
            this.gbNumberOfPlayers.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumberOfPlayers.Location = new System.Drawing.Point(541, 27);
            this.gbNumberOfPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNumberOfPlayers.Name = "gbNumberOfPlayers";
            this.gbNumberOfPlayers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbNumberOfPlayers.Size = new System.Drawing.Size(276, 49);
            this.gbNumberOfPlayers.TabIndex = 4;
            this.gbNumberOfPlayers.TabStop = false;
            this.gbNumberOfPlayers.Text = "Number Of Players : ";
            // 
            // rbTwoPlayers
            // 
            this.rbTwoPlayers.AutoSize = true;
            this.rbTwoPlayers.Location = new System.Drawing.Point(145, 21);
            this.rbTwoPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTwoPlayers.Name = "rbTwoPlayers";
            this.rbTwoPlayers.Size = new System.Drawing.Size(116, 24);
            this.rbTwoPlayers.TabIndex = 1;
            this.rbTwoPlayers.TabStop = true;
            this.rbTwoPlayers.Text = "Tow Players";
            this.rbTwoPlayers.UseVisualStyleBackColor = true;
            this.rbTwoPlayers.CheckedChanged += new System.EventHandler(this.rbTwoPlayers_CheckedChanged);
            // 
            // rbOnePlayer
            // 
            this.rbOnePlayer.AutoSize = true;
            this.rbOnePlayer.Location = new System.Drawing.Point(25, 21);
            this.rbOnePlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbOnePlayer.Name = "rbOnePlayer";
            this.rbOnePlayer.Size = new System.Drawing.Size(107, 24);
            this.rbOnePlayer.TabIndex = 0;
            this.rbOnePlayer.TabStop = true;
            this.rbOnePlayer.Text = "One Player";
            this.rbOnePlayer.UseVisualStyleBackColor = true;
            this.rbOnePlayer.CheckedChanged += new System.EventHandler(this.rbOnePlayer_CheckedChanged);
            // 
            // gbPlayer2Info
            // 
            this.gbPlayer2Info.Controls.Add(this.gbGender2);
            this.gbPlayer2Info.Controls.Add(this.txtPlayer2);
            this.gbPlayer2Info.Controls.Add(this.label5);
            this.gbPlayer2Info.Enabled = false;
            this.gbPlayer2Info.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer2Info.Location = new System.Drawing.Point(541, 337);
            this.gbPlayer2Info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPlayer2Info.Name = "gbPlayer2Info";
            this.gbPlayer2Info.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPlayer2Info.Size = new System.Drawing.Size(313, 128);
            this.gbPlayer2Info.TabIndex = 3;
            this.gbPlayer2Info.TabStop = false;
            this.gbPlayer2Info.Text = "Player2 Info :";
            // 
            // gbGender2
            // 
            this.gbGender2.Controls.Add(this.rbFemale2);
            this.gbGender2.Controls.Add(this.rbMale2);
            this.gbGender2.Location = new System.Drawing.Point(9, 65);
            this.gbGender2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGender2.Name = "gbGender2";
            this.gbGender2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGender2.Size = new System.Drawing.Size(263, 57);
            this.gbGender2.TabIndex = 3;
            this.gbGender2.TabStop = false;
            this.gbGender2.Text = "Gender";
            // 
            // rbFemale2
            // 
            this.rbFemale2.AutoSize = true;
            this.rbFemale2.Location = new System.Drawing.Point(135, 25);
            this.rbFemale2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFemale2.Name = "rbFemale2";
            this.rbFemale2.Size = new System.Drawing.Size(82, 24);
            this.rbFemale2.TabIndex = 1;
            this.rbFemale2.TabStop = true;
            this.rbFemale2.Text = "Female";
            this.rbFemale2.UseVisualStyleBackColor = true;
            this.rbFemale2.CheckedChanged += new System.EventHandler(this.rbFemale2_CheckedChanged);
            // 
            // rbMale2
            // 
            this.rbMale2.AutoSize = true;
            this.rbMale2.Location = new System.Drawing.Point(15, 25);
            this.rbMale2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMale2.Name = "rbMale2";
            this.rbMale2.Size = new System.Drawing.Size(65, 24);
            this.rbMale2.TabIndex = 0;
            this.rbMale2.TabStop = true;
            this.rbMale2.Text = "Male";
            this.rbMale2.UseVisualStyleBackColor = true;
            this.rbMale2.CheckedChanged += new System.EventHandler(this.rbMale2_CheckedChanged);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(79, 28);
            this.txtPlayer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(233, 27);
            this.txtPlayer2.TabIndex = 2;
            this.txtPlayer2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlayer2_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Player2 :  ";
            // 
            // gbPlayer1Info
            // 
            this.gbPlayer1Info.Controls.Add(this.gbGender1);
            this.gbPlayer1Info.Controls.Add(this.txtPlayer1);
            this.gbPlayer1Info.Controls.Add(this.label3);
            this.gbPlayer1Info.Enabled = false;
            this.gbPlayer1Info.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer1Info.Location = new System.Drawing.Point(541, 197);
            this.gbPlayer1Info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPlayer1Info.Name = "gbPlayer1Info";
            this.gbPlayer1Info.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbPlayer1Info.Size = new System.Drawing.Size(313, 128);
            this.gbPlayer1Info.TabIndex = 2;
            this.gbPlayer1Info.TabStop = false;
            this.gbPlayer1Info.Text = "Player1 Info :";
            // 
            // gbGender1
            // 
            this.gbGender1.Controls.Add(this.rbFemale1);
            this.gbGender1.Controls.Add(this.rbMale1);
            this.gbGender1.Location = new System.Drawing.Point(7, 65);
            this.gbGender1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGender1.Name = "gbGender1";
            this.gbGender1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGender1.Size = new System.Drawing.Size(263, 57);
            this.gbGender1.TabIndex = 2;
            this.gbGender1.TabStop = false;
            this.gbGender1.Text = "Gender";
            // 
            // rbFemale1
            // 
            this.rbFemale1.AutoSize = true;
            this.rbFemale1.Location = new System.Drawing.Point(135, 25);
            this.rbFemale1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFemale1.Name = "rbFemale1";
            this.rbFemale1.Size = new System.Drawing.Size(82, 24);
            this.rbFemale1.TabIndex = 1;
            this.rbFemale1.TabStop = true;
            this.rbFemale1.Text = "Female";
            this.rbFemale1.UseVisualStyleBackColor = true;
            this.rbFemale1.CheckedChanged += new System.EventHandler(this.rbFemale1_CheckedChanged);
            // 
            // rbMale1
            // 
            this.rbMale1.AutoSize = true;
            this.rbMale1.Location = new System.Drawing.Point(15, 25);
            this.rbMale1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMale1.Name = "rbMale1";
            this.rbMale1.Size = new System.Drawing.Size(65, 24);
            this.rbMale1.TabIndex = 0;
            this.rbMale1.TabStop = true;
            this.rbMale1.Text = "Male";
            this.rbMale1.UseVisualStyleBackColor = true;
            this.rbMale1.CheckedChanged += new System.EventHandler(this.rbMale1_CheckedChanged);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(87, 26);
            this.txtPlayer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(227, 27);
            this.txtPlayer1.TabIndex = 1;
            this.txtPlayer1.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlayer1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "PLayer1 :  ";
            // 
            // gbTimePerRound
            // 
            this.gbTimePerRound.Controls.Add(this.lblTimePerRound);
            this.gbTimePerRound.Controls.Add(this.tbTimePerRound);
            this.gbTimePerRound.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimePerRound.Location = new System.Drawing.Point(237, 27);
            this.gbTimePerRound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTimePerRound.Name = "gbTimePerRound";
            this.gbTimePerRound.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTimePerRound.Size = new System.Drawing.Size(280, 159);
            this.gbTimePerRound.TabIndex = 1;
            this.gbTimePerRound.TabStop = false;
            this.gbTimePerRound.Text = "Time Per Round :";
            // 
            // lblTimePerRound
            // 
            this.lblTimePerRound.AutoSize = true;
            this.lblTimePerRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblTimePerRound.Location = new System.Drawing.Point(71, 31);
            this.lblTimePerRound.Name = "lblTimePerRound";
            this.lblTimePerRound.Size = new System.Drawing.Size(118, 42);
            this.lblTimePerRound.TabIndex = 1;
            this.lblTimePerRound.Text = "label3";
            // 
            // tbTimePerRound
            // 
            this.tbTimePerRound.Location = new System.Drawing.Point(7, 75);
            this.tbTimePerRound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTimePerRound.Maximum = 100;
            this.tbTimePerRound.Name = "tbTimePerRound";
            this.tbTimePerRound.Size = new System.Drawing.Size(252, 56);
            this.tbTimePerRound.TabIndex = 0;
            this.tbTimePerRound.ValueChanged += new System.EventHandler(this.tbTimePerRound_ValueChanged);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbHard.Location = new System.Drawing.Point(21, 121);
            this.rbHard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(91, 38);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // rbMid
            // 
            this.rbMid.AutoSize = true;
            this.rbMid.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbMid.Location = new System.Drawing.Point(23, 75);
            this.rbMid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMid.Name = "rbMid";
            this.rbMid.Size = new System.Drawing.Size(82, 38);
            this.rbMid.TabIndex = 1;
            this.rbMid.TabStop = true;
            this.rbMid.Text = "Mid";
            this.rbMid.UseVisualStyleBackColor = true;
            this.rbMid.CheckedChanged += new System.EventHandler(this.rbMid_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.Location = new System.Drawing.Point(21, 29);
            this.rbEasy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(89, 38);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
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
            this.modernButton1.Location = new System.Drawing.Point(17, 38);
            this.modernButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.Size = new System.Drawing.Size(192, 84);
            this.modernButton1.TabIndex = 1;
            this.modernButton1.Text = "Start Game";
            this.modernButton1.UseVisualStyleBackColor = false;
            this.modernButton1.Click += new System.EventHandler(this.modernButton1_Click);
            this.modernButton1.MouseEnter += new System.EventHandler(this.modernButton1_MouseEnter);
            this.modernButton1.MouseLeave += new System.EventHandler(this.modernButton1_MouseLeave);
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
            this.modernButton3.Location = new System.Drawing.Point(17, 267);
            this.modernButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modernButton3.Name = "modernButton3";
            this.modernButton3.Size = new System.Drawing.Size(192, 84);
            this.modernButton3.TabIndex = 3;
            this.modernButton3.Text = "How To Play";
            this.modernButton3.UseVisualStyleBackColor = false;
            this.modernButton3.Click += new System.EventHandler(this.modernButton3_Click);
            this.modernButton3.MouseEnter += new System.EventHandler(this.modernButton3_MouseEnter);
            this.modernButton3.MouseLeave += new System.EventHandler(this.modernButton3_MouseLeave);
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
            this.modernButton2.Location = new System.Drawing.Point(17, 160);
            this.modernButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modernButton2.Name = "modernButton2";
            this.modernButton2.Size = new System.Drawing.Size(192, 84);
            this.modernButton2.TabIndex = 2;
            this.modernButton2.Text = "Settings";
            this.modernButton2.UseVisualStyleBackColor = false;
            this.modernButton2.Click += new System.EventHandler(this.modernButton2_Click);
            this.modernButton2.MouseEnter += new System.EventHandler(this.modernButton2_MouseEnter);
            this.modernButton2.MouseLeave += new System.EventHandler(this.modernButton2_MouseLeave);
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
            this.modernButton4.Location = new System.Drawing.Point(17, 395);
            this.modernButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modernButton4.Name = "modernButton4";
            this.modernButton4.Size = new System.Drawing.Size(192, 84);
            this.modernButton4.TabIndex = 4;
            this.modernButton4.Text = "Quit";
            this.modernButton4.UseVisualStyleBackColor = false;
            this.modernButton4.Click += new System.EventHandler(this.modernButton4_Click);
            this.modernButton4.MouseEnter += new System.EventHandler(this.modernButton4_MouseEnter);
            this.modernButton4.MouseLeave += new System.EventHandler(this.modernButton4_MouseLeave);
            // 
            // cgbLevel
            // 
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1205, 610);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelMainMenue);
            this.Controls.Add(this.panelHowToPlay);
            this.Controls.Add(this.panelStartGame);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Card Mach Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStartGame.ResumeLayout(false);
            this.panelStartGame.PerformLayout();
            this.panelHowToPlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMainMenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.gbNumberOfRounds.ResumeLayout(false);
            this.gbNumberOfRounds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbNumberOfPlayers.ResumeLayout(false);
            this.gbNumberOfPlayers.PerformLayout();
            this.gbPlayer2Info.ResumeLayout(false);
            this.gbPlayer2Info.PerformLayout();
            this.gbGender2.ResumeLayout(false);
            this.gbGender2.PerformLayout();
            this.gbPlayer1Info.ResumeLayout(false);
            this.gbPlayer1Info.PerformLayout();
            this.gbGender1.ResumeLayout(false);
            this.gbGender1.PerformLayout();
            this.gbTimePerRound.ResumeLayout(false);
            this.gbTimePerRound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimePerRound)).EndInit();
            this.cgbLevel.ResumeLayout(false);
            this.cgbLevel.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbTimePerRound;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMid;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox gbPlayer1Info;
        private System.Windows.Forms.Label lblTimePerRound;
        private System.Windows.Forms.TrackBar tbTimePerRound;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbNumberOfRounds;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private CustomGroupBox cgbLevel;
    }
}

