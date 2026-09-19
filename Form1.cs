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
            switch (GameInfo.Level) { }
            
        }







    }
}
