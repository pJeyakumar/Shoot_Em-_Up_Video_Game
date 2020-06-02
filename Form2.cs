// Piranavan Jeyakumar
// 01.03.2018
// Menu
// To guide the player through the game
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
    public partial class frmMainMenu : Form
    {
        // Variable Declaration
        System.Media.SoundPlayer np = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Gyakuten Meets Orchestra 08 - Apollo Justice Objection Theme.wav");
        public frmMainMenu()
        {
            InitializeComponent();
                np.PlayLooping();   
        }
        // Will show Controls form and hide this form
        private void BtnControls_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmControls frmControls = new frmControls();
            frmControls.Show();
        }
        // Will start settings before going in game and hide this form
        private void btnStart_Click(object sender, EventArgs e)
        {
            np.Stop();
            this.Hide();
            frmSettings Settings = new frmSettings();
            Settings.Show();
        }
        // Will show HighScore and hide this form
        private void btnHighscore_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHighScores HighScores = new frmHighScores();
            HighScores.Show();
        }
    }
}
