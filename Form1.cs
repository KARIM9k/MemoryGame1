using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame1
{

    public enum enLevel {enEasy=0,enMid=1,enHard=2 };
    public enum enGender {Male =0, Female=1 }; 

    public struct stGameInfo 
    {
       public enLevel Level;
       public bool TowPlayers;
       public int NumberOfRounds;
       public int TimePerRound;
       public string NamePlayer1;
       public string NamePlayer2;
       public string GenderPlayer1;
       public string GenderPlayer2;
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

        private void panelSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        void UpdateLevel(enLevel Level)
        {
            GameInfo.Level = Level;
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


        void UpdateGender(string Gender,int Player)
        {
            if (Player == 1)
            {
                GameInfo.GenderPlayer1 = Gender; 
            }
            else
            {
                GameInfo.GenderPlayer2 = Gender;
            }
        } 

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel(enLevel.enEasy); 
        }

        private void rbMid_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel(enLevel.enMid);
        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLevel(enLevel.enHard);
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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimePerRound(); 
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

        private void rbMale1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender("Male",1); 
        }

        private void rbFemale1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender("Female", 1);
        }

        private void rbMale2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender("Male", 2);
        }

        private void rbFemale2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGender("Female", 2);
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
    }
}
