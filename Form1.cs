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
    }



    public partial class Form1 : Form
    {
        stGameInfo GameInfo; 
       
        public Form1()
        {
            InitializeComponent();


            //switch (GameInfo.Level) {
            //    case enLevel.enEasy:
            //    {
            //            break; 
            //    }
            //    case enLevel.enMid:
            //    {
            //            break; 
            //    }
            //    case enLevel.enHard:
            //    {
            //            break; 
            //    }
            
            //}

                     

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

           
        }

        private void txtPlayer2_TextChanged(object sender, EventArgs e)
        {
            GameInfo.NamePlayer2 = txtPlayer2.Text;
        }

       
        void ChangeCharacters(RadioButton Gender,int Player)
        {
            if (Player==1)
            {
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
            if (Gender == enGender.enMale)
            {
                switch (Character.Name)
                {
                    case "pb1_1":
                    case "pb2_1":
                        return enCharacters.B1;

                    case "pb1_2":
                    case "pb2_2":
                        return enCharacters.B2;

                    case "pb1_3":
                    case "pb2_3":
                        return enCharacters.B3;

                    case "pb1_4":
                    case "pb2_4":
                        return enCharacters.B4;

                    case "pb1_5":
                    case "pb2_5":
                        return enCharacters.B5;
                }
            }
            else
            {
                switch (Character.Name)
                {
                    case "pb1_1":
                    case "pb2_1":
                        return enCharacters.G1;

                    case "pb1_2":
                    case "pb2_2":
                        return enCharacters.G2;

                    case "pb1_3":
                    case "pb2_3":
                        return enCharacters.G3;

                    case "pb1_4":
                    case "pb2_4":
                        return enCharacters.G4;

                    case "pb1_5":
                    case "pb2_5":
                        return enCharacters.G5;
                }
            }

            return enCharacters.B1;
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
    }
}
