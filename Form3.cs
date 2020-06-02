// Piranavan Jeyakumar
// 01.20.2018
// Controls
// To show the player the ropes on how to play the game
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
    public partial class frmControls : Form
    {
        public frmControls()
        {
            InitializeComponent();
        }   
        // Will show Main Menu form and hide this one
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMain = new frmMainMenu();
            this.Hide();
            frmMain.Show();
        }
    }
}
