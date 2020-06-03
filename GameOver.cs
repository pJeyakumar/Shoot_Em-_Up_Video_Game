// Piranavan Jeyakumar
// 01.16.2018
// Game Over
// Will display itself once player loses
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A8_PiranavanJeyakumar_Culiminating
{
    public partial class frmGameOver : Form
    {
        // Variable Declaration
        //System.Media.SoundPlayer np = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Turnabout Jazz Soul - Track 8 - Godot - The Fragrance of Dark Coffee.wav");

        public frmGameOver()
        {
            InitializeComponent();
            //np.PlayLooping();
        }
        // Will go to HighScore form and hide this one
        private void btnToHighscores_Click(object sender, EventArgs e)
        {
            //np.Stop();
            this.Hide();
            frmHighScores HighScores = new frmHighScores();
            HighScores.Show();

            
        }
    }
}
