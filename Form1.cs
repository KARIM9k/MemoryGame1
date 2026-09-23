using MemoryGame1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame1
{

    public enum enLevel {enEasy=0,enMid=1,enHard=2 };
    public enum enGender {enMale =0, enFemale=1 }; 

    public enum enCharacters {B1=0,B2=1,B3=2,B4=3,B5=4,G1=5,G2=6,G3=7,G4=8,G5=9}; 
   
    public struct stGameInfo 
    {
       public enLevel Level;
       public bool TowPlayers;
       public int NumberOfRounds;
       public int TimePerRound;
       public string NamePlayer1;
       public string NamePlayer2;
       public enGender GenderPlayer1;
       public enGender GenderPlayer2;
       public enCharacters CharacterPlayer1;
       public enCharacters CharacterPlayer2;
       public string Winner;

        public int Player1FinalScore;
        public int Player2FinalScore;

        public void SetDefault()
        {

            Player1FinalScore = 0;
            Player2FinalScore = 0;
            Level = enLevel.enEasy;
            TowPlayers = false;
            NumberOfRounds = 5;
            TimePerRound = 30;

            NamePlayer1 = "Player 1";
            NamePlayer2 = "Player 2";

            GenderPlayer1 = enGender.enMale;
            GenderPlayer2 = enGender.enMale;

            CharacterPlayer1 = enCharacters.B1;
            CharacterPlayer2 = enCharacters.B2;

            Winner = "";
        }
    }



    public partial class Form1 : Form
    {
        stGameInfo GameInfo; 
       
        public Form1()
        {
            InitializeComponent();

            GameInfo = new stGameInfo();
            GameInfo.SetDefault();                

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMainMenue.Visible = true;
            panelMainMenue.BringToFront();
            panelSettings.Visible = false;
            panelHowToPlay.Visible = false;
            panelSettings.Visible = false;

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
        private void ShowPanel(Panel panelToShow)
        {

            panelStartGame.Enabled = false;
            panelStartGame.Visible = false;

            panelHowToPlay.Enabled = false;
            panelHowToPlay.Visible = false;

            panelSettings.Enabled = false;
            panelSettings.Visible = false;

            if (panelToShow != null)
            {
                panelToShow.Enabled = true;
                panelToShow.Visible = true;
                panelToShow.BringToFront();
            }
            
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {

            ShowPanel(panelStartGame);
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {

            ShowPanel(panelSettings);
        }

        private void modernButton3_Click(object sender, EventArgs e)
        {


            ShowPanel(panelHowToPlay);
        }

        private void modernButton4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

        enLevel GetLevelByName(string Level)
        {
            switch (Level)
            {
                case "Easy":
                    return enLevel.enEasy;
                case "Mid":
                    return enLevel.enMid;
                case "Hard":
                    return enLevel.enHard;
                default:return enLevel.enEasy;
            }
        }


        void UpdateLevel(RadioButton Level)
        {
            GameInfo.Level = GetLevelByName(Level.Text);
        }

        void UpdateTimePerRound()
        {
            GameInfo.TimePerRound = tbTimePerRound.Value;
            lblTimePerRound.Text = tbTimePerRound.Value.ToString()+"s"; 
        }

        void UpdateNumberOfPlayers()
        {
            if (rbOnePlayer.Checked)
            {
                GameInfo.TowPlayers = false;
                gbPlayer1Info.Enabled = true;
                gbPlayer2Info.Enabled = false; 
            }
            else if (rbTwoPlayers.Checked)
            {
                GameInfo.TowPlayers = true;
                gbPlayer1Info.Enabled = true;
                gbPlayer2Info.Enabled = true;
            }
        }

        enGender GetGender(RadioButton Gender)
        {
            if (Gender == rbMale1)
                return enGender.enMale;
            else if (Gender == rbFemale1)
                return enGender.enFemale;
            else if (Gender == rbMale2)
                return enGender.enMale;
            else
                return enGender.enFemale; 
        }

        void UpdateGender(RadioButton Gender,int Player)
        {
            if (Player == 1)
            {
                GameInfo.GenderPlayer1 = GetGender(Gender);

            }
            else
            {
                GameInfo.GenderPlayer2 = GetGender(Gender);
            }
           
        } 

      

        private void modernButton1_MouseEnter(object sender, EventArgs e)
        {
            ChangeButton((ModernButton)sender);
        }

        private void modernButton1_MouseLeave(object sender, EventArgs e)
        {
            ChangeToWhiteColor((ModernButton)sender);
        }

        private void modernButton2_MouseEnter(object sender, EventArgs e)
        {
            ChangeButton((ModernButton)sender);

        }

        private void modernButton2_MouseLeave(object sender, EventArgs e)
        {
            ChangeToWhiteColor((ModernButton)sender);

        }

        private void modernButton3_MouseEnter(object sender, EventArgs e)
        {
            ChangeButton((ModernButton)sender);
        }

        private void modernButton3_MouseLeave(object sender, EventArgs e)
        {
            ChangeToWhiteColor((ModernButton)sender);

        }

        private void modernButton4_MouseEnter(object sender, EventArgs e)
        {
            ChangeButton((ModernButton)sender);

        }

        private void modernButton4_MouseLeave(object sender, EventArgs e)
        {
            ChangeToWhiteColor((ModernButton)sender);
        }




        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel((RadioButton)sender);
        }

        private void rbMid_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel((RadioButton)sender);
        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
              UpdateLevel((RadioButton)sender);
        }



        private void rbOnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumberOfPlayers(); 
        }

        private void rbTwoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNumberOfPlayers();
        }

        private void txtPlayer1_TextChanged(object sender, EventArgs e)
        {
          
            GameInfo.NamePlayer1 = txtPlayer1.Text;
            lblStartGamePlayer1.Text = txtPlayer1.Text;           
        }

        private void txtPlayer2_TextChanged(object sender, EventArgs e)
        {
            GameInfo.NamePlayer2 = txtPlayer2.Text;
            lblStartGamePlayer2.Text = txtPlayer2.Text;

        }


        void ChangeCharacters(RadioButton Gender,int Player)
        {
            if (Player==1)
            {
                pb1_1.Enabled = true;
                pb1_2.Enabled = true;
                pb1_3.Enabled = true;
                pb1_4.Enabled = true;
                pb1_5.Enabled = true;

                if (Gender== rbMale1)
                {
                    pb1_1.Image = Resources.B1;
                    pb1_2.Image = Resources.B2;
                    pb1_3.Image = Resources.B3;
                    pb1_4.Image = Resources.B4;
                    pb1_5.Image = Resources.B5;

                    
                }
                else
                {
                    pb1_1.Image = Resources.G1;
                    pb1_2.Image = Resources.G2;
                    pb1_3.Image = Resources.G3;
                    pb1_4.Image = Resources.G4;
                    pb1_5.Image = Resources.G5;
                }
            }
            else
            {
                pb2_1.Enabled = true;
                pb2_2.Enabled = true;
                pb2_3.Enabled = true;
                pb2_4.Enabled = true;
                pb2_5.Enabled = true;
                if (Gender == rbMale2)
                {
                    pb2_1.Image = Resources.B1;
                    pb2_2.Image = Resources.B2;
                    pb2_3.Image = Resources.B3;
                    pb2_4.Image = Resources.B4;
                    pb2_5.Image = Resources.B5;
                }
                else
                {
                    pb2_1.Image = Resources.G1;
                    pb2_2.Image = Resources.G2;
                    pb2_3.Image = Resources.G3;
                    pb2_4.Image = Resources.G4;
                    pb2_5.Image = Resources.G5;
                }
            }
        }

        private void rbMale1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender((RadioButton)sender,1);
            ChangeCharacters((RadioButton)sender, 1);

        }

        private void rbFemale1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender((RadioButton)sender, 1);
            ChangeCharacters((RadioButton)sender, 1);
        }

        private void rbMale2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender((RadioButton)sender, 2);
            ChangeCharacters((RadioButton)sender,2); 
        }

        private void rbFemale2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender((RadioButton)sender, 2);
            ChangeCharacters((RadioButton)sender, 2);
        }


        private void tbTimePerRound_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimePerRound();
        }


        private void txtPlayer1_Validating(object sender, CancelEventArgs e)
        {
            if (gbPlayer1Info.Enabled&&string.IsNullOrEmpty(txtPlayer1.Text))
            {
                e.Cancel = true;
                txtPlayer1.Focus();
                errorProvider1.SetError(txtPlayer1, "Required"); 
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPlayer1, ""); 
            }
        }

        private void txtPlayer2_Validating(object sender, CancelEventArgs e)
        {
            if (gbPlayer2Info.Enabled&&string.IsNullOrEmpty(txtPlayer2.Text))
            {
                e.Cancel = true;
                txtPlayer2.Focus();
                errorProvider1.SetError(txtPlayer2, "Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPlayer2, "");
            }
        }

        enCharacters GetCharacter(PictureBox Character, enGender Gender)
        {
            bool isPlayer1 = Character.Name.StartsWith("pb1_");

            if (isPlayer1)
            {
                
                if (GameInfo.GenderPlayer1 == enGender.enMale)
                {
                    pb1_1.Image = Resources.B1; pb1_2.Image = Resources.B2;
                    pb1_3.Image = Resources.B3; pb1_4.Image = Resources.B4; pb1_5.Image = Resources.B5;
                }
                else
                {
                    pb1_1.Image = Resources.G1; pb1_2.Image = Resources.G2;
                    pb1_3.Image = Resources.G3; pb1_4.Image = Resources.G4; pb1_5.Image = Resources.G5;
                }
            }
            else
            {
                if (GameInfo.GenderPlayer2 == enGender.enMale)
                {
                    pb2_1.Image = Resources.B1; pb2_2.Image = Resources.B2;
                    pb2_3.Image = Resources.B3; pb2_4.Image = Resources.B4; pb2_5.Image = Resources.B5;
                }
                else
                {
                    pb2_1.Image = Resources.G1; pb2_2.Image = Resources.G2;
                    pb2_3.Image = Resources.G3; pb2_4.Image = Resources.G4; pb2_5.Image = Resources.G5;
                }
            }

            PictureBox[] playerPics = isPlayer1
                ? new PictureBox[] { pb1_1, pb1_2, pb1_3, pb1_4, pb1_5 }
                : new PictureBox[] { pb2_1, pb2_2, pb2_3, pb2_4, pb2_5 };

            foreach (var pic in playerPics)
            {
                if (pic != Character)
                {
                    pic.Image = DarkenImage(pic.Image, 0.4f);
                }
            }
            enCharacters selectedCharacter = enCharacters.B1;
            if (Gender == enGender.enMale)
            {
                switch (Character.Name)
                {
                    case "pb1_1": case "pb2_1": selectedCharacter = enCharacters.B1;break;
                    case "pb1_2": case "pb2_2": selectedCharacter = enCharacters.B2; break;
                    case "pb1_3": case "pb2_3": selectedCharacter = enCharacters.B3; break;
                    case "pb1_4": case "pb2_4": selectedCharacter = enCharacters.B4; break;
                    case "pb1_5": case "pb2_5": selectedCharacter = enCharacters.B5; break;
                }
            }
            else
            {
                switch (Character.Name)
                {
                    case "pb1_1": case "pb2_1": selectedCharacter = enCharacters.G1; break;
                    case "pb1_2": case "pb2_2": selectedCharacter = enCharacters.G2; break;
                    case "pb1_3": case "pb2_3": selectedCharacter = enCharacters.G3; break;
                    case "pb1_4": case "pb2_4": selectedCharacter = enCharacters.G4; break;
                    case "pb1_5": case "pb2_5": selectedCharacter = enCharacters.G5; break;
                }
            }

            if (isPlayer1)
            {
                pbStartGamePlayer1.BackgroundImage = GetCharacterImage(selectedCharacter);
            }
            else
            {
                pbStartGamePlayer2.BackgroundImage = GetCharacterImage(selectedCharacter);

            }

            return selectedCharacter;
        
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


        private void pb1_1_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer1 = GetCharacter((PictureBox)sender,GameInfo.GenderPlayer1);
        }

        private void pb1_2_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer1 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer1);
        }

        private void pb1_3_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer1 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer1);

        }

        private void pb1_4_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer1 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer1);
        }

        private void pb1_5_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer1 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer1);
        }

        private void pb2_1_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer2 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer2);
        }

        private void pb2_2_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer2 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer2);
        }

        private void pb2_3_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer2 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer2);
        }

        private void pb2_4_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer2 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer2);
        }

        private void pb2_5_Click(object sender, EventArgs e)
        {
            GameInfo.CharacterPlayer2 = GetCharacter((PictureBox)sender, GameInfo.GenderPlayer2);
        }

        private void txtPlayer1_Enter(object sender, EventArgs e)
        {
            txtPlayer1.BackColor = Color.LightSkyBlue;

        }

        private void txtPlayer2_Enter(object sender, EventArgs e)
        {
            txtPlayer2.BackColor = Color.LightSkyBlue;
        }

        private void txtPlayer1_Leave(object sender, EventArgs e)
        {
            txtPlayer1.BackColor = Color.White;
        }

        private void txtPlayer2_Leave(object sender, EventArgs e)
        {
            txtPlayer2.BackColor = Color.White;

        }

        private void pb1_1_MouseEnter(object sender, EventArgs e)
        {

        }

       

        private void pb1_1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pb1_2_Paint(object sender, PaintEventArgs e)
        {
        }


        private Image DarkenImage(Image image, float brightness = 0.5f)
        {
            if (image == null) return null;

            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
                {
            new float[] {brightness, 0, 0, 0, 0},
            new float[] {0, brightness, 0, 0, 0},
            new float[] {0, 0, brightness, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
                });

                using (System.Drawing.Imaging.ImageAttributes attributes = new System.Drawing.Imaging.ImageAttributes())
                {
                    attributes.SetColorMatrix(colorMatrix);
                    g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                        0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return bmp;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlay Form = new frmPlay(GameInfo);
            Form.ShowDialog();
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            ChangeButton((ModernButton)sender);

        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            ChangeToWhiteColor((ModernButton)sender);

        }
    }
}
