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
            this.modernButton1 = new ModernButton();
            this.modernButton3 = new ModernButton();
            this.modernButton2 = new ModernButton();
            this.modernButton4 = new ModernButton();
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
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMid = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
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
            this.gbLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStartGame
            // 
            this.panelStartGame.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelStartGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartGame.Controls.Add(this.label2);
            this.panelStartGame.Location = new System.Drawing.Point(859, 77);
            this.panelStartGame.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelStartGame.Name = "panelStartGame";
            this.panelStartGame.Size = new System.Drawing.Size(40, 34);
            this.panelStartGame.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Game";
            // 
            // panelHowToPlay
            // 
            this.panelHowToPlay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelHowToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHowToPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHowToPlay.Controls.Add(this.pictureBox1);
            this.panelHowToPlay.Location = new System.Drawing.Point(200, 38);
            this.panelHowToPlay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelHowToPlay.Name = "panelHowToPlay";
            this.panelHowToPlay.Size = new System.Drawing.Size(645, 422);
            this.panelHowToPlay.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MemoryGame1.Properties.Resources.image_2748e566;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 420);
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
            this.panelMainMenue.Location = new System.Drawing.Point(9, 38);
            this.panelMainMenue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMainMenue.Name = "panelMainMenue";
            this.panelMainMenue.Size = new System.Drawing.Size(178, 422);
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
            this.modernButton1.Location = new System.Drawing.Point(9, 29);
            this.modernButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.Size = new System.Drawing.Size(154, 61);
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
            this.modernButton3.Location = new System.Drawing.Point(9, 225);
            this.modernButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modernButton3.Name = "modernButton3";
            this.modernButton3.Size = new System.Drawing.Size(154, 61);
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
            this.modernButton2.Location = new System.Drawing.Point(9, 127);
            this.modernButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modernButton2.Name = "modernButton2";
            this.modernButton2.Size = new System.Drawing.Size(154, 61);
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
            this.modernButton4.Location = new System.Drawing.Point(9, 323);
            this.modernButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modernButton4.Name = "modernButton4";
            this.modernButton4.Size = new System.Drawing.Size(154, 61);
            this.modernButton4.TabIndex = 4;
            this.modernButton4.Text = "Quit";
            this.modernButton4.UseVisualStyleBackColor = false;
            this.modernButton4.Click += new System.EventHandler(this.modernButton4_Click);
            this.modernButton4.MouseEnter += new System.EventHandler(this.modernButton4_MouseEnter);
            this.modernButton4.MouseLeave += new System.EventHandler(this.modernButton4_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.gbNumberOfRounds);
            this.panelSettings.Controls.Add(this.gbNumberOfPlayers);
            this.panelSettings.Controls.Add(this.gbPlayer2Info);
            this.panelSettings.Controls.Add(this.gbPlayer1Info);
            this.panelSettings.Controls.Add(this.gbTimePerRound);
            this.panelSettings.Controls.Add(this.gbLevel);
            this.panelSettings.Location = new System.Drawing.Point(197, 38);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(666, 421);
            this.panelSettings.TabIndex = 6;
            this.panelSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSettings_Paint);
            // 
            // gbNumberOfRounds
            // 
            this.gbNumberOfRounds.Controls.Add(this.label1);
            this.gbNumberOfRounds.Controls.Add(this.numericUpDown1);
            this.gbNumberOfRounds.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumberOfRounds.Location = new System.Drawing.Point(26, 197);
            this.gbNumberOfRounds.Name = "gbNumberOfRounds";
            this.gbNumberOfRounds.Size = new System.Drawing.Size(192, 88);
            this.gbNumberOfRounds.TabIndex = 2;
            this.gbNumberOfRounds.TabStop = false;
            this.gbNumberOfRounds.Text = "Number Of Rounds : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rounds :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(82, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // gbNumberOfPlayers
            // 
            this.gbNumberOfPlayers.Controls.Add(this.rbTwoPlayers);
            this.gbNumberOfPlayers.Controls.Add(this.rbOnePlayer);
            this.gbNumberOfPlayers.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNumberOfPlayers.Location = new System.Drawing.Point(406, 22);
            this.gbNumberOfPlayers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbNumberOfPlayers.Name = "gbNumberOfPlayers";
            this.gbNumberOfPlayers.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbNumberOfPlayers.Size = new System.Drawing.Size(207, 40);
            this.gbNumberOfPlayers.TabIndex = 4;
            this.gbNumberOfPlayers.TabStop = false;
            this.gbNumberOfPlayers.Text = "Number Of Players : ";
            // 
            // rbTwoPlayers
            // 
            this.rbTwoPlayers.AutoSize = true;
            this.rbTwoPlayers.Location = new System.Drawing.Point(109, 17);
            this.rbTwoPlayers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbTwoPlayers.Name = "rbTwoPlayers";
            this.rbTwoPlayers.Size = new System.Drawing.Size(93, 19);
            this.rbTwoPlayers.TabIndex = 1;
            this.rbTwoPlayers.TabStop = true;
            this.rbTwoPlayers.Text = "Tow Players";
            this.rbTwoPlayers.UseVisualStyleBackColor = true;
            this.rbTwoPlayers.CheckedChanged += new System.EventHandler(this.rbTwoPlayers_CheckedChanged);
            // 
            // rbOnePlayer
            // 
            this.rbOnePlayer.AutoSize = true;
            this.rbOnePlayer.Location = new System.Drawing.Point(19, 17);
            this.rbOnePlayer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbOnePlayer.Name = "rbOnePlayer";
            this.rbOnePlayer.Size = new System.Drawing.Size(86, 19);
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
            this.gbPlayer2Info.Location = new System.Drawing.Point(406, 274);
            this.gbPlayer2Info.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbPlayer2Info.Name = "gbPlayer2Info";
            this.gbPlayer2Info.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbPlayer2Info.Size = new System.Drawing.Size(235, 104);
            this.gbPlayer2Info.TabIndex = 3;
            this.gbPlayer2Info.TabStop = false;
            this.gbPlayer2Info.Text = "Player2 Info :";
            // 
            // gbGender2
            // 
            this.gbGender2.Controls.Add(this.rbFemale2);
            this.gbGender2.Controls.Add(this.rbMale2);
            this.gbGender2.Location = new System.Drawing.Point(7, 53);
            this.gbGender2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbGender2.Name = "gbGender2";
            this.gbGender2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbGender2.Size = new System.Drawing.Size(197, 46);
            this.gbGender2.TabIndex = 3;
            this.gbGender2.TabStop = false;
            this.gbGender2.Text = "Gender";
            // 
            // rbFemale2
            // 
            this.rbFemale2.AutoSize = true;
            this.rbFemale2.Location = new System.Drawing.Point(101, 20);
            this.rbFemale2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbFemale2.Name = "rbFemale2";
            this.rbFemale2.Size = new System.Drawing.Size(65, 19);
            this.rbFemale2.TabIndex = 1;
            this.rbFemale2.TabStop = true;
            this.rbFemale2.Text = "Female";
            this.rbFemale2.UseVisualStyleBackColor = true;
            this.rbFemale2.CheckedChanged += new System.EventHandler(this.rbFemale2_CheckedChanged);
            // 
            // rbMale2
            // 
            this.rbMale2.AutoSize = true;
            this.rbMale2.Location = new System.Drawing.Point(11, 20);
            this.rbMale2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbMale2.Name = "rbMale2";
            this.rbMale2.Size = new System.Drawing.Size(52, 19);
            this.rbMale2.TabIndex = 0;
            this.rbMale2.TabStop = true;
            this.rbMale2.Text = "Male";
            this.rbMale2.UseVisualStyleBackColor = true;
            this.rbMale2.CheckedChanged += new System.EventHandler(this.rbMale2_CheckedChanged);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(59, 23);
            this.txtPlayer2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(176, 23);
            this.txtPlayer2.TabIndex = 2;
            this.txtPlayer2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlayer2_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
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
            this.gbPlayer1Info.Location = new System.Drawing.Point(406, 160);
            this.gbPlayer1Info.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbPlayer1Info.Name = "gbPlayer1Info";
            this.gbPlayer1Info.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbPlayer1Info.Size = new System.Drawing.Size(235, 104);
            this.gbPlayer1Info.TabIndex = 2;
            this.gbPlayer1Info.TabStop = false;
            this.gbPlayer1Info.Text = "Player1 Info :";
            // 
            // gbGender1
            // 
            this.gbGender1.Controls.Add(this.rbFemale1);
            this.gbGender1.Controls.Add(this.rbMale1);
            this.gbGender1.Location = new System.Drawing.Point(5, 53);
            this.gbGender1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbGender1.Name = "gbGender1";
            this.gbGender1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbGender1.Size = new System.Drawing.Size(197, 46);
            this.gbGender1.TabIndex = 2;
            this.gbGender1.TabStop = false;
            this.gbGender1.Text = "Gender";
            // 
            // rbFemale1
            // 
            this.rbFemale1.AutoSize = true;
            this.rbFemale1.Location = new System.Drawing.Point(101, 20);
            this.rbFemale1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbFemale1.Name = "rbFemale1";
            this.rbFemale1.Size = new System.Drawing.Size(65, 19);
            this.rbFemale1.TabIndex = 1;
            this.rbFemale1.TabStop = true;
            this.rbFemale1.Text = "Female";
            this.rbFemale1.UseVisualStyleBackColor = true;
            this.rbFemale1.CheckedChanged += new System.EventHandler(this.rbFemale1_CheckedChanged);
            // 
            // rbMale1
            // 
            this.rbMale1.AutoSize = true;
            this.rbMale1.Location = new System.Drawing.Point(11, 20);
            this.rbMale1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbMale1.Name = "rbMale1";
            this.rbMale1.Size = new System.Drawing.Size(52, 19);
            this.rbMale1.TabIndex = 0;
            this.rbMale1.TabStop = true;
            this.rbMale1.Text = "Male";
            this.rbMale1.UseVisualStyleBackColor = true;
            this.rbMale1.CheckedChanged += new System.EventHandler(this.rbMale1_CheckedChanged);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(65, 21);
            this.txtPlayer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(171, 23);
            this.txtPlayer1.TabIndex = 1;
            this.txtPlayer1.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlayer1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "PLayer1 :  ";
            // 
            // gbTimePerRound
            // 
            this.gbTimePerRound.Controls.Add(this.lblTimePerRound);
            this.gbTimePerRound.Controls.Add(this.tbTimePerRound);
            this.gbTimePerRound.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimePerRound.Location = new System.Drawing.Point(178, 22);
            this.gbTimePerRound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbTimePerRound.Name = "gbTimePerRound";
            this.gbTimePerRound.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbTimePerRound.Size = new System.Drawing.Size(210, 129);
            this.gbTimePerRound.TabIndex = 1;
            this.gbTimePerRound.TabStop = false;
            this.gbTimePerRound.Text = "Time Per Round :";
            // 
            // lblTimePerRound
            // 
            this.lblTimePerRound.AutoSize = true;
            this.lblTimePerRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblTimePerRound.Location = new System.Drawing.Point(53, 25);
            this.lblTimePerRound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimePerRound.Name = "lblTimePerRound";
            this.lblTimePerRound.Size = new System.Drawing.Size(95, 36);
            this.lblTimePerRound.TabIndex = 1;
            this.lblTimePerRound.Text = "label3";
            // 
            // tbTimePerRound
            // 
            this.tbTimePerRound.Location = new System.Drawing.Point(5, 61);
            this.tbTimePerRound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTimePerRound.Maximum = 100;
            this.tbTimePerRound.Name = "tbTimePerRound";
            this.tbTimePerRound.Size = new System.Drawing.Size(189, 45);
            this.tbTimePerRound.TabIndex = 0;
            this.tbTimePerRound.ValueChanged += new System.EventHandler(this.tbTimePerRound_ValueChanged);
            // 
            // gbLevel
            // 
            this.gbLevel.Controls.Add(this.rbHard);
            this.gbLevel.Controls.Add(this.rbMid);
            this.gbLevel.Controls.Add(this.rbEasy);
            this.gbLevel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLevel.Location = new System.Drawing.Point(19, 22);
            this.gbLevel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbLevel.Size = new System.Drawing.Size(144, 129);
            this.gbLevel.TabIndex = 0;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level :";
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(17, 90);
            this.rbHard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(53, 19);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // rbMid
            // 
            this.rbMid.AutoSize = true;
            this.rbMid.Location = new System.Drawing.Point(17, 58);
            this.rbMid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbMid.Name = "rbMid";
            this.rbMid.Size = new System.Drawing.Size(46, 19);
            this.rbMid.TabIndex = 1;
            this.rbMid.TabStop = true;
            this.rbMid.Text = "Mid";
            this.rbMid.UseVisualStyleBackColor = true;
            this.rbMid.CheckedChanged += new System.EventHandler(this.rbMid_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(17, 25);
            this.rbEasy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(49, 19);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 496);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelMainMenue);
            this.Controls.Add(this.panelHowToPlay);
            this.Controls.Add(this.panelStartGame);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.gbLevel.ResumeLayout(false);
            this.gbLevel.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbLevel;
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
    }
}

