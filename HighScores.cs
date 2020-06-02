// Piranavan Jeyakumar
// 01.19/2018
// HighScore
// Will display past highscores and player's highscore if they beat one of the high scores
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Added Libraries
using System.IO;

namespace A8_PiranavanJeyakumar_Culiminating
{
    public partial class frmHighScores : Form
    {
        // Variable Declaration
        FileInfo s = new FileInfo("HighScores.txt");
        string strFileInputPJ = null;
        int[] intOldScoresPJ = new int[6];
        int intCounterPJ = 0;
        int intTempValuePJ = 0;
        int intReplacePJ = 0;
        public frmHighScores()
        {
            InitializeComponent();
            HighScores();

        }   
        // Will go to Main Menu form and hide this one
        private void btnMainMenu_Click(object sender, EventArgs e)
        {

            // Go back to main menu
            this.Hide();
            frmMainMenu MainMenu = new frmMainMenu();
            MainMenu.Show();
        }
        // Input: Gets the high scores from the file and the players highscores
        // Process: Sorts out the highscores from greatest to least and will add the player's highscore if it is greater than  at least 1 of the 5 highscores
        // Output: Displays all highscores and highlights player's highscore 
        public void HighScores()
        {
            StreamReader Scores = s.OpenText();
            // Get old high scores
            while ((strFileInputPJ = Scores.ReadLine()) != null)
            {
                intOldScoresPJ[intCounterPJ] = Int32.Parse(strFileInputPJ);
                intCounterPJ++;
            }
            // Sets Player Score to last Array value to set up for bubble sorting
            intOldScoresPJ[5] = Class1.intPlayerScorePJ;
            // Bubble Sort
            for (int i = 0; i < intOldScoresPJ.Length; i++)
            {
                for (int j = 0; j < intOldScoresPJ.Length - 1; j++)
                {
                    if (intOldScoresPJ[j] < intOldScoresPJ[j + 1])
                    {   
                        intTempValuePJ = intOldScoresPJ[j];
                        intOldScoresPJ[j] = intOldScoresPJ[j + 1];
                        intOldScoresPJ[j + 1] = intTempValuePJ;
                    }

                }
            }
            // Remembers Player Array Number
            for(int i = 0; i < intOldScoresPJ.Length; i++)
            {
                if (intOldScoresPJ[i] == Class1.intPlayerScorePJ)
                {
                    intReplacePJ = i;
                }
            }
            lblScoreOne.Text = intOldScoresPJ[0].ToString();
            lblScoreTwo.Text = intOldScoresPJ[1].ToString();
            lblScoreThree.Text = intOldScoresPJ[2].ToString();
            lblScoreFour.Text = intOldScoresPJ[3].ToString();
            lblScoreFive.Text = intOldScoresPJ[4].ToString();
            // Differentiates Player Score from others
            if (intOldScoresPJ[intReplacePJ].ToString() == lblScoreOne.Text)
            {
                lblScoreOne.BackColor = Color.Red;
            }
            else if (intOldScoresPJ[intReplacePJ].ToString() == lblScoreTwo.Text)
            {
                lblScoreTwo.BackColor = Color.BlueViolet;
            }
            else if (intOldScoresPJ[intReplacePJ].ToString() == lblScoreThree.Text)
            {
                lblScoreThree.BackColor = Color.BlueViolet;
            }
            else if (intOldScoresPJ[intReplacePJ].ToString() == lblScoreFour.Text)
            {
                lblScoreFour.BackColor = Color.BlueViolet;
            }
            else if (intOldScoresPJ[intReplacePJ].ToString() == lblScoreFive.Text)
            {
                lblScoreFive.BackColor = Color.BlueViolet;
            }
            Scores.Close();
            // Writes new scores to file
            StreamWriter Write = s.CreateText();
            for(int i = 0; i < intOldScoresPJ.Length; i++)
            {
                Write.WriteLine(intOldScoresPJ[i].ToString());
            }
            Write.Close();
        }
    }
}
