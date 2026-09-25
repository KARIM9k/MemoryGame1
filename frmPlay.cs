using MemoryGame1.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame1
{
    public partial class frmPlay : Form
    {
        public enum enPictures { enAirPlane = 0, enApple = 1, enBarcelona, enCar, enCat, enChair, enCockroach, enEgg, enMonkey, enRealMadrid, enSwan, enWhale }
        private stGameInfo GameInfo;

        private int _CurrentRound = 1;
        private int _Player1RoundsWon = 0;
        private int _Player2RoundsWon = 0;
        private bool FirstPlayerTurn = true;

        private RoundedPictureBox FirstIndex = null;
        private RoundedPictureBox SecondIndex = null;

        private bool isProcessing = false;

        private struct stRoundInfo
        {
            public int Player1Score;
            public int Player2Score;
            public List<string> PicturesNames;
            public string FirstImage;
            public string SecondImage;
            public bool FirstChoice;
            public int TimePerRound; 
        }

        stRoundInfo RoundInfo;

        public frmPlay(stGameInfo GameInfoCopy)
        {
            InitializeComponent();
            GameInfo = GameInfoCopy;
        }

        private Image GetCharacterImage(enCharacters character)
        {
            switch (character)
            {
                case enCharacters.B1: return Resources.B1;
                case enCharacters.B2: return Resources.B2;
                case enCharacters.B3: return Resources.B3;
                case enCharacters.B4: return Resources.B4;
                case enCharacters.B5: return Resources.B5;
                case enCharacters.G1: return Resources.G1;
                case enCharacters.G2: return Resources.G2;
                case enCharacters.G3: return Resources.G3;
                case enCharacters.G4: return Resources.G4;
                case enCharacters.G5: return Resources.G5;
                default: return Resources.B1;
            }
        }
        

        private void SetViewControls()
        {

            lblPlayerTurn.Text = GameInfo.NamePlayer1;
            lblPlayer1NameInfrmPlay.Text = GameInfo.NamePlayer1;
            lblPlayer2NameInfrmPlay.Text = GameInfo.NamePlayer2;

            pbPlayer1ImageInfrmPlay.Image = GetCharacterImage(GameInfo.CharacterPlayer1);
            pbPlayer2ImageInfrmPlay.Image = GetCharacterImage(GameInfo.CharacterPlayer2);

        }
        private void frmPlay_Load(object sender, EventArgs e)
        {
            SetViewControls();
            StartPlay();
        }

        private string GetPictureNameFromEnum(enPictures Pic)
        {
            switch (Pic)
            {
                case enPictures.enAirPlane: return "AirPlane";
                case enPictures.enApple: return "Appel";
                case enPictures.enBarcelona: return "Barcelona";
                case enPictures.enCar: return "Car";
                case enPictures.enCat: return "Cat";
                case enPictures.enChair: return "Chair";
                case enPictures.enCockroach: return "Cockroach";
                case enPictures.enEgg: return "Egg";
                case enPictures.enMonkey: return "Monkey";
                case enPictures.enRealMadrid: return "Real Madrid";
                case enPictures.enSwan: return "Swan";
                case enPictures.enWhale: return "Whale";
                default: return "Appel";
            }
        }

        private void FillPictureVector(int NumberOfPic)
        {

            RoundInfo.Player1Score = 0;
            RoundInfo.Player2Score = 0;
            lblPlayer1Score.Text = "0";
            lblPlayer2Score.Text = "0";
             
            HashSet<string> PicVectorSet = new HashSet<string>();
            Random random = new Random();

            while (PicVectorSet.Count < NumberOfPic)
            {
                int Number = random.Next(0, 12);
                enPictures Pic = (enPictures)Number;
                string PicName = GetPictureNameFromEnum(Pic);
                PicVectorSet.Add(PicName);
            }

            List<string> PicVector = new List<string>();
            foreach (var item in PicVectorSet)
            {
                PicVector.Add(item);
                PicVector.Add(item);
            }

            PicVector = PicVector.OrderBy(x => Guid.NewGuid()).ToList();
            RoundInfo.PicturesNames = PicVector;
            RoundInfo.FirstChoice = false;
            lblPlayerTurn.Text = GameInfo.NamePlayer1;


        }

        private void StartPlay()
        {
            lblRounds.Text = $"{_CurrentRound}/{GameInfo.NumberOfRounds}";
            switch (GameInfo.Level)
            {
                case enLevel.enEasy:
                    FillPictureVector(3);
                    GetPicBoxes(6, 245, 220);
                    break;
                case enLevel.enMid:
                    FillPictureVector(6);
                    GetPicBoxes(12, 160, 165);
                    break;
                case enLevel.enHard:
                    FillPictureVector(12);
                    GetPicBoxes(24, 120, 110);
                    break;
            }
            ResetAndStartTimer(); 
        }

        private void GetPicBoxes(int NumberOfPic, int Height, int Width)
        {
            PlayGamePanel.Controls.Clear();
            for (int i = 1; i <= NumberOfPic; i++)
            {
                RoundedPictureBox PicBox = new RoundedPictureBox();
                PicBox.Width = Width;
                PicBox.Height = Height;
                PicBox.Image = Resources.download__8_;
                PicBox.SizeMode = PictureBoxSizeMode.StretchImage;

                PicBox.Tag = i;
                PicBox.Click += PictureBox_Click;

                PlayGamePanel.Controls.Add(PicBox);
            }
        }

        private Image GetImageFromVector(string ImageName)
        {
            switch (ImageName)
            {
                case "AirPlane": return Resources.Airplane;
                case "Appel": return Resources.Apple;
                case "Barcelona": return Resources.Barcelona;
                case "Car": return Resources.Car;
                case "Cat": return Resources.Cat;
                case "Chair": return Resources.Chair;
                case "Cockroach": return Resources.cockroach;
                case "Egg": return Resources.Egg;
                case "Monkey": return Resources.monkey;
                case "Real Madrid": return Resources.Real_Madrid;
                case "Swan": return Resources.Swan;
                case "Whale": return Resources.whale;
                default: return Resources.Real_Madrid;
            }
        }

        private async void PictureBox_Click(object sender, EventArgs e)
        {

            if (isProcessing) return;

            RoundedPictureBox clickedPic = sender as RoundedPictureBox;

            if (!clickedPic.Enabled) return;

            if (clickedPic == FirstIndex) return;

            if (clickedPic != null && clickedPic.Tag != null)
            {
                int index = (int)clickedPic.Tag;
                string ImageName = RoundInfo.PicturesNames[index - 1];
                Image pic = GetImageFromVector(ImageName);
                clickedPic.Image = pic;
                await StartGame(clickedPic);
            }
        }

        private async Task StartGame(RoundedPictureBox clickedPic)
        {
           
           
            if (!RoundInfo.FirstChoice)
            {

                RoundInfo.FirstImage = RoundInfo.PicturesNames[(int)clickedPic.Tag - 1];
                FirstIndex = clickedPic;
                RoundInfo.FirstChoice = true;
            }
            else
            {

                RoundInfo.SecondImage = RoundInfo.PicturesNames[(int)clickedPic.Tag - 1];
                SecondIndex = clickedPic;
                timer1.Stop();

                await CompareChoices(FirstIndex, SecondIndex);

                FirstIndex = null;
                SecondIndex = null;
                RoundInfo.FirstChoice = false;

                if (CheckIfRoundFinished())
                {
                    await HandleRoundEnd();
                }
                else
                {
                    ResetAndStartTimer();
                }

            }
              
        }

        private async Task CompareChoices(RoundedPictureBox pic1, RoundedPictureBox pic2)
        {
            bool Matched = RoundInfo.FirstImage == RoundInfo.SecondImage;

            if (Matched)
            {
                if (FirstPlayerTurn)
                    RoundInfo.Player1Score++;
                else
                    RoundInfo.Player2Score++;


                pic1.Enabled = false;
                pic2.Enabled = false;

                //if we want to change turn when the player get true answer
                FirstPlayerTurn = !FirstPlayerTurn;
               

            }
            else
            {
                isProcessing = true;

                await Task.Delay(1500);

                pic1.Image = Resources.download__8_;
                pic2.Image = Resources.download__8_;

                FirstPlayerTurn = !FirstPlayerTurn;

                isProcessing = false;
            }
            
            lblPlayer1Score.Text = RoundInfo.Player1Score.ToString();
            lblPlayer2Score.Text = RoundInfo.Player2Score.ToString();
            lblPlayerTurn.Text = FirstPlayerTurn ? GameInfo.NamePlayer1 : GameInfo.NamePlayer2;
        }

        private void ResetAndStartTimer()
        {
            timer1.Stop();
            RoundInfo.TimePerRound = GameInfo.TimePerRound;
            lblTimer.Text = RoundInfo.TimePerRound.ToString()+'s';
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            RoundInfo.TimePerRound--;
            lblTimer.Text = RoundInfo.TimePerRound.ToString()+'s'; 
            if (RoundInfo.TimePerRound == 0)
            {
                timer1.Stop();

                if (FirstIndex != null)
                {
                   
                    FirstIndex.Image = Resources.download__8_;
                    FirstIndex = null; 
                }

                RoundInfo.FirstChoice = false;

                FirstPlayerTurn = !FirstPlayerTurn;
                lblPlayerTurn.Text = FirstPlayerTurn ? GameInfo.NamePlayer1 : GameInfo.NamePlayer2;

                ResetAndStartTimer();
            }
        }

        private void btnClosefrmPlay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeButton(ModernButton sender)
        {
            if (this.Controls != null)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is ModernButton btn)
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                        btn.BorderSize = 2;
                        btn.BorderColor = Color.FromArgb(180, 195, 210);
                    }
                }
            }

            ModernButton clickedButton = (ModernButton)sender;
            clickedButton.BackColor = Color.FromArgb(70, 110, 150);
            clickedButton.ForeColor = Color.White;
            clickedButton.BorderSize = 0;
        }
        private void ChangeToWhiteColor(ModernButton sender)
        {
            if (sender is ModernButton btn)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.BorderColor = Color.FromArgb(180, 195, 210);
                btn.BorderSize = 2;

            }
        }

        private void btnClosefrmPlay_MouseEnter(object sender, EventArgs e)
        {
            ChangeButton((ModernButton)sender);
        }

        private void btnClosefrmPlay_MouseLeave(object sender, EventArgs e)
        {
            ChangeToWhiteColor((ModernButton)sender);
        }

        private bool CheckIfRoundFinished()
        {
            foreach(Control ctrl in PlayGamePanel.Controls)
            {
                if(ctrl is RoundedPictureBox pic && pic.Enabled)
                {
                    return false;
                }
            }
            return true;
        }

        private async Task HandleRoundEnd()
        {
            timer1.Stop();

            string roundWinner = "";
            if (RoundInfo.Player1Score > RoundInfo.Player2Score)
            {
                _Player1RoundsWon++;
                roundWinner = $"Round {_CurrentRound} Winner: {GameInfo.NamePlayer1}";
            }
            else if (RoundInfo.Player2Score > RoundInfo.Player1Score)
            {
                _Player2RoundsWon++;
                roundWinner = $"Round {_CurrentRound} Winner: {GameInfo.NamePlayer2}";
            }
            else
            {
                roundWinner = $"Round {_CurrentRound} ended in a Draw!";
            }

            if (_CurrentRound >= GameInfo.NumberOfRounds)
            {
                MessageBox.Show($"{roundWinner}\n\nAll rounds have been completed!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowFinalWinner();
            }
            else
            {
                MessageBox.Show($"{roundWinner}\n\nClick OK to start the next round.", $"Round {_CurrentRound} Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _CurrentRound++;
                StartPlay();
            }
        }

        private void ShowFinalWinner()
        {
            string message = "";

            if (_Player1RoundsWon > _Player2RoundsWon)
            {
                message = $"🏆 Congratulations! The overall winner is {GameInfo.NamePlayer1}\nWon {_Player1RoundsWon} out of {GameInfo.NumberOfRounds} rounds.";
            }
            else if (_Player2RoundsWon > _Player1RoundsWon)
            {
                message = $"🏆 Congratulations! The overall winner is {GameInfo.NamePlayer2}\nWon {_Player2RoundsWon} out of {GameInfo.NumberOfRounds} rounds.";
            }
            else
            {
                message = $"🤝 The game ended in a overall Draw ({_Player1RoundsWon} - {_Player2RoundsWon})!";
            }

            MessageBox.Show(message, "Final Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }




    }
}