using MemoryGame1.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame1
{
    public partial class frmPlay : Form
    {

       public enum enPictures {enAirPlane=0,enApple=1,enBarcelona,enCar,enCat,enChair,enCockroach,enEgg,enMonkey,enRealMadrid,enSwan,enWhale }
        private stGameInfo GameInfo;

        private struct stRoundInfo
        {
            public int Player1Score;
            public int Player2Score;

            public List<string> PicturesNames;
            
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
                case enPictures.enAirPlane:
                    return "AirPlane";
                case enPictures.enApple:
                    return "Appel"; 
                case enPictures.enBarcelona:
                    return "Barcelona"; 
                case enPictures.enCar:
                    return "Car"; 
                case enPictures.enCat:
                    return "Cat";
                case enPictures.enChair:
                    return "Chair"; 
                case enPictures.enCockroach:
                    return "Cockroach";
                case enPictures.enEgg:
                    return "Egg"; 
                case enPictures.enMonkey:
                    return "Monkey"; 
                case enPictures.enRealMadrid:
                    return "Real Madrid"; 
                case enPictures.enSwan:
                    return "Swan";
                case enPictures.enWhale:
                    return "Whale";
                default:
                    return "Appel"; 
            }
        }
        private void FillPictureVector(int NumberOfPic)
        {
            HashSet<string> PicVectorSet = new HashSet<string>();
            int cnt = 0;
            Random random = new Random();

            while (cnt != NumberOfPic)
            {
                int Number=random.Next(0, 11);
                enPictures Pic = (enPictures)Number;
                string PicName = GetPictureNameFromEnum(Pic);
                PicVectorSet.Add(PicName);
            }
            List<string> PicVector = new List<string>();
            while (PicVector.Count() != 0)
            {
                string temp = PicVectorSet.First();
                PicVector.Add(temp);
                PicVector.Add(temp);
                PicVectorSet.Remove(PicVectorSet.First());
            }
            PicVector = PicVector.OrderBy(x => Guid.NewGuid()).ToList();
            RoundInfo.PicturesNames = PicVector;
                
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
                    FillPictureVector(3);
                    GetPicBoxes(12, 160, 165);
                    break;
                case enLevel.enHard:
                    FillPictureVector(3);
                    GetPicBoxes(24, 120,110);
                    break;
                
            }
        }

        private void GetPicBoxes(int NumberOfPic,int Height,int Width)
        {
            PlayGamePanel.Controls.Clear();
            for(int i = 1; i <= NumberOfPic; i++)
            {
                RoundedPictureBox PicBox = new RoundedPictureBox();
                PicBox.Width = Width;
                PicBox.Height = Height;
                PicBox.Image = Resources.download__8_;
                PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                PicBox.Tag = i;
                SetPictures((int)PicBox.Tag);


                PlayGamePanel.Controls.Add(PicBox);
            }
            StartGame();
        }

        private void SetPictures( int PicTag)
        {

        }

        private void StartGame()
        {

        }
    }
}
