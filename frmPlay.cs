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
        }

        stRoundInfo RoundInfo;

        public frmPlay(stGameInfo GameInfoCopy)
        {
            InitializeComponent();
            GameInfo = GameInfoCopy;
        }

        private void frmPlay_Load(object sender, EventArgs e)
        {
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

                await CompareChoices(FirstIndex, SecondIndex);

                FirstIndex = null;
                SecondIndex = null;
                RoundInfo.FirstChoice = false;
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
    }
}