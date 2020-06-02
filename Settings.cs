// Piranavan Jeyakumar
// 01.22.2018
// Settings
// Where the user can choose their game type and music
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
    public partial class frmSettings : Form
    {
        Boolean blnMusicSelectPJ = false;
        System.Media.SoundPlayer First = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Turnabout Jazz Soul - Track 1 - Ace Attorney - Court Begins Blue Note Scale.wav");
        System.Media.SoundPlayer Second = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Turnabout Jazz Soul - Track 6 - Furio Tigre - Swinging the Tiger.wav");
        System.Media.SoundPlayer Third = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Turnabout Jazz Soul - Track 5 - Miles Edgeworth - Great Revival.wav");
        System.Media.SoundPlayer Fourth = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Gyakuten Meets Orchestra 08 - Trials and Tribulations Ending.wav");
        public frmSettings()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Class1.blnHardPJ = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Class1.blnHardPJ = false;
        }

        private void btnPreview1_Click(object sender, EventArgs e)
        {
            First.PlayLooping();
        }

        private void btnChoose1_Click(object sender, EventArgs e)
        {
            Class1.Music = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Turnabout Jazz Soul - Track 1 - Ace Attorney - Court Begins Blue Note Scale.wav");
            blnMusicSelectPJ = true;
        }

        private void btnPreview2_Click(object sender, EventArgs e)
        {
            Second.PlayLooping();
        }

        private void btnChoose2_Click(object sender, EventArgs e)
        {
            Class1.Music = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Turnabout Jazz Soul - Track 6 - Furio Tigre - Swinging the Tiger.wav");
            blnMusicSelectPJ = true;
        }

        private void btnPreview3_Click(object sender, EventArgs e)
        {
            Third.PlayLooping();
        }

        private void btnChoose3_Click(object sender, EventArgs e)
        {
            Class1.Music = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Turnabout Jazz Soul - Track 5 - Miles Edgeworth - Great Revival.wav");
            blnMusicSelectPJ = true;
        }

        private void btnPreview4_Click(object sender, EventArgs e)
        {
            Fourth.PlayLooping();
        }

        private void btnChoose4_Click(object sender, EventArgs e)
        {
            Class1.Music = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Gyakuten Meets Orchestra 08 - Trials and Tribulations Ending.wav");
            blnMusicSelectPJ = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true || radioButton2.Checked == true && blnMusicSelectPJ == true)
            {
                frmGame Game = new frmGame();
                this.Hide();
                Game.Show();
            }
            else
            {
                MessageBox.Show("Please make sure you have configured all your selections before beginning...");
            }
        }
    }
}
