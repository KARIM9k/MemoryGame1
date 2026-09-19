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


            switch (GameInfo.Level) {
                case enLevel.enEasy:
                {
                        break; 
                }
                case enLevel.enMid:
                {
                        break; 
                }
                case enLevel.enHard:
                {
                        break; 
                }
            
            }
           

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
        private void ShowPanel(Panel panelToShow)
        {
            panelMainMenue.Visible = false;

            panelStartGame.Visible = false;
            
            panelHowToPlay.Visible = false;

            panelSettings.Visible = false;

            if (panelToShow != null)
            {
                panelToShow.Visible = true;
                panelToShow.BringToFront();
            }
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {

            ChangeButton((ModernButton)sender);
            ShowPanel(panelStartGame);
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {

            ChangeButton((ModernButton)sender);
            ShowPanel(panelSettings);
        }

        private void modernButton3_Click(object sender, EventArgs e)
        {
            ChangeButton((ModernButton)sender);


            ShowPanel(panelHowToPlay);
        }

        private void modernButton4_Click(object sender, EventArgs e)
        {
            ChangeButton((ModernButton)sender);

        }
    }
}
