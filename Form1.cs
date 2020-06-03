// Piranavan Jeyakumar
// 12.22.2017
// Culminating Project
// To create a game consisting of all the tools we've learned to use throughout the semester
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
using System.Media;


namespace A8_PiranavanJeyakumar_Culiminating
{
    public partial class frmGame : Form
    {
        // Variable Declaration
        #region
        // Game Over Screen Variables
        frmGameOver GameOver = new frmGameOver();
        // Game Variables
        Boolean blnStartPJ = false;
        // Music
        System.Media.SoundPlayer rp = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Super Smash Bros. Melee - Announcer Ready.wav");
        System.Media.SoundPlayer gp = new System.Media.SoundPlayer(@"E:\A8_PiranavanJeyakumar_Culiminating\A8_PiranavanJeyakumar_Culiminating\Resources\Super Smash Bros. Melee - Announcer Go!.wav");
        // Scroll Speed Variables
        static int[] intObstacleMovementPJ = { 1, 5, 2, 6, 4, 1, 5, 2 };
        int intMovementSpeedPJ = 7;
        // Variables for ship controls and speed
        Boolean blnRightPJ = false;
        Boolean blnLeftPJ = false;
        Boolean blnSpace = false;
        Boolean blnUpPJ = false;
        Boolean blnDownPJ = false;
        int intPlayerScorePJ;
        int intMoveLeftandRightSpeedPJ = 10;
        int intMoveUpandDownSpeedPJ = 12;
        double dblTakenHitsPJ = 5;
        double dblHitterPJ = 1;
        double dblAddedLivesPJ = 1;
        // Variables for Missiles
        PictureBox[] picMissilesPJ = new PictureBox[1];
        Boolean[] blnMissleCollision = { false };
        int intMissileShotsPJ = 0;
        // Variables and Arrays for the obstacles
        PictureBox[] picObstacles = new PictureBox[8];
        Boolean[] blnCollision = { false, false, false, false, false, false, false, false };
        static int[] intObstacle1 = { 50, 30 };
        static int[] intObstacle2 = { 65, 19 };
        static int[] intObstacle3 = { 18, 165 };
        static int[] intObstacle4 = { 80, 30 };
        static int[] intObstacle5 = { 37, 49 };
        static int[] intObstacle6 = { 24, 55 };
        static int[][] intSizesArrayPJ = new int[][] { intObstacle1, intObstacle2, intObstacle3, intObstacle4, intObstacle5, intObstacle6 };
        // Variables for wavy obstacles
        double dblXValuePJ = 0;
        double dblYValuePJ = 0;
        // Points Variables
        PictureBox[] picPointsArrayPJ = new PictureBox[15];
        Boolean[] blnPointsCollisonPJ = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        // Variable for Point Size
        static Size szPointPJ = new Size(15, 15);
        // Colours for the obstacles
        static Color[] ColourArrayPJ = { Color.Crimson, Color.Orange, Color.Green, Color.SkyBlue };
        // Powerup Images
        Image imgShield = Resource1.LotS_Blue_Alien_Energy_Sphere;
        Image imgMissile = Resource1.launcher_clipart_missile_clipart_1285541080;
        #endregion  

        public frmGame()
        {
            InitializeComponent();
        }
        // Input: Key Press
        // Process: Key Press sets Boolean value to true
        // Output: True Boolean Value
        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            // Controls are pressed for moving left and right, boolean variables are set to True

            if (e.KeyCode == Keys.Left)
            {
                blnLeftPJ = true;
            }

            else if (e.KeyCode == Keys.Right)
            {
                blnRightPJ = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                blnUpPJ = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                blnDownPJ = true;
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (blnStartPJ == false)
                {
                    Class1.intPlayerScorePJ = 0;
                    //rp.Play();
                    lblBegin.Text = "Ready?";
                    lblBegin.Refresh();
                    System.Threading.Thread.Sleep(2000);
                    //gp.Play();
                    lblBegin.Text = "Go!";
                    lblBegin.Refresh();
                    System.Threading.Thread.Sleep(750);
                    //Class1.Music.PlayLooping();
                    lblBegin.Visible = false;
                    tmrGameLogic.Enabled = true;
                    tmrObstacles.Enabled = true;
                    blnStartPJ = true;

                }
                blnSpace = true;
            }

        }
        // Input: Key not being pressed
        // Process: Keys that arent being pressed sets a Boolean value to false
        // Output: False Boolean Value
        private void frmGame_KeyUp(object sender, KeyEventArgs e)
        {
            // Controls are not pressed for moving right or left, boolean is set to False

            if (e.KeyCode == Keys.Left)
            {
                blnLeftPJ = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                blnRightPJ = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                blnSpace = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                blnUpPJ = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                blnDownPJ = false;
            }
        }
        // Timer that ticks for as long as the game lasts.
        // Score, Life bar, Death screen and ALL methods and functions of the game are activated here
        private void tmrGameLogic_Tick(object sender, EventArgs e)
        {
            Class1.intPlayerScorePJ++;
            intPlayerScorePJ = Class1.intPlayerScorePJ;
            // Labels display 
            this.lblScore.Text = Class1.intPlayerScorePJ.ToString();
            if(intMissileShotsPJ > 0)
            {
                lblMissileOnOrOff.ForeColor = Color.Red;
                lblMissileOnOrOff.Text = "ON";
            }
            else
            {
                lblMissileOnOrOff.ForeColor = Color.Blue;
                lblMissileOnOrOff.Text = "OFF";
            }
            // Game Over shows if life is less than or equal to 0
            if (prgLife.Value <= 0)
            {
                this.Hide();
                tmrGameLogic.Enabled = false;
                Class1.Music.Stop();
                GameOver.Show();
            }
            // Life decrease 
            prgLife.Value = (int)(dblTakenHitsPJ * 20);
            // Shield Delay
            if (tmrinvincible.Enabled == true)
            {
                tmrDelay.Enabled = true;
            }
            // Methods
            PlayerControls();
            ObstaclesGenerator();
            ObstacleCollision();
            OffScreenObstacles();
            PointGenerator();
            PointCollision();
            OffScreenPoints();
            EnergySetter();
            MissileSetter();
            MissileMover();
            MissileCollision();


        }
        // Input: Boolean variable from KeyDown or KeyUP
        // Process: Corresponding Boolean value will move the player
        // Output: Player location is changed on screen
        public void PlayerControls()
        {
            // Moving Ship left and right within bounds of form
            if (blnRightPJ == true && picPlayer.Right < this.Width - 20)
            {
                picPlayer.Left += intMoveLeftandRightSpeedPJ;
            }
            else if (blnLeftPJ == true && picPlayer.Left > 5)
            {
                picPlayer.Left -= intMoveLeftandRightSpeedPJ;
            }
            else if (blnUpPJ == true && picPlayer.Top > 65)
            {
                picPlayer.Top -= intMoveUpandDownSpeedPJ;
            }
            else if (blnDownPJ == true && picPlayer.Top < 579)
            {
                picPlayer.Top += intMoveUpandDownSpeedPJ;
            }
            else if (blnSpace == true)
            {
                MissileShooter();
            }
        }
        // Process: If there are any null values in the array, another picturebox will be created
        // Output: Another picturebox with colour, size, collision will be displayed on to the screen
        public void PointGenerator()
        {
            Random rndPJ = new Random();
            Point rndPointPJ = new Point();
            for (int i = 0; i < picPointsArrayPJ.Length; i++)
            {
                if (picPointsArrayPJ[i] == null)
                {
                    picPointsArrayPJ[i] = new PictureBox();
                    picPointsArrayPJ[i].Name = "picPoint" + i;
                    picPointsArrayPJ[i].Size = szPointPJ;
                    picPointsArrayPJ[i].BackColor = Color.Purple;
                    rndPointPJ = new Point(rndPJ.Next(3, this.Width - 3), rndPJ.Next(-200, -100));
                    picPointsArrayPJ[i].Location = rndPointPJ;
                    this.Controls.Add(picPointsArrayPJ[i]);
                    blnPointsCollisonPJ[i] = false;
                }
            }
        }
        // Input: Player intersecting with Point picturebox
        // Process: Checking if player intersects with picturebox and picturebox boolean value is false
        // Output: Player score increases
        public void PointCollision()
        {
            for (int i = 0; i < picPointsArrayPJ.Length; i++)
            {
                if (picPointsArrayPJ[i] != null)
                {
                    if (picPlayer.Bounds.IntersectsWith(picPointsArrayPJ[i].Bounds) || picShieldOne.Bounds.IntersectsWith(picPointsArrayPJ[i].Bounds) && blnPointsCollisonPJ[i] == false)
                    {
                        blnPointsCollisonPJ[i] = true;
                        Class1.intPlayerScorePJ += 50;
                        picPointsArrayPJ[i].Visible = false;
                    }
                }
            }
        }
        // Input: Every Point picturebox location
        // Process: Will move all pictureboxes downward
        // Output: New pictureboxes coming from top and present pictureboxes moving down
        public void OffScreenPoints()
        {
            for (int i = 0; i < picPointsArrayPJ.Length; i++)
            {
                if (picPointsArrayPJ[i] != null)
                {
                    if(Class1.intPlayerScorePJ >= 30000)
                    {
                        intMovementSpeedPJ = 8;
                    }
                    else if(Class1.intPlayerScorePJ >= 65000)
                    {
                        intMovementSpeedPJ = 9;
                    }
                    else if(Class1.intPlayerScorePJ >= 100000)
                    {
                        intMovementSpeedPJ = 10;
                    }
                    picPointsArrayPJ[i].Top += intMovementSpeedPJ;
                }
            }
            for (int i = 0; i < picPointsArrayPJ.Length; i++)
            {
                if (picPointsArrayPJ[i].Top > this.Height)
                {
                    // Point is disposed of
                    picPointsArrayPJ[i].Dispose();
                    // Point array value is set to null
                    picPointsArrayPJ[i] = null;
                }
            }
        }
        // Process: Creates obstacles is obstacle array value is null
        // Output: Will display new obstacles on screen
        public void ObstaclesGenerator()
        {
            Random rndPJ = new Random();
            Point rndPointPJ = new Point();
            int intRandomArrayValuePJ;
            // Randomly generates size and location of each obstacle
            for (int i = 0; i < picObstacles.Length; i++)
            {
                if (picObstacles[i] == null)
                {
                    // Adds new obstacle to array
                    picObstacles[i] = new PictureBox();
                    picObstacles[i].Name = "Obstacles" + i;

                    // Generates a random point within form
                    rndPointPJ = new Point(rndPJ.Next(3, this.Width - 3), rndPJ.Next(-200, -50));

                    // Obstacle location is now placed at the point location
                    picObstacles[i].Location = rndPointPJ;

                    // Overlapchecker
                    OverlapChecker();
                    // Chooses random colour from pre-selected colour array
                    picObstacles[i].BackColor = ColourArrayPJ[rndPJ.Next(0, 4)];

                    // Chooses random size from pre-selected sizes array
                    intRandomArrayValuePJ = rndPJ.Next(0, 6);
                    picObstacles[i].Size = new Size(intSizesArrayPJ[intRandomArrayValuePJ][0], intSizesArrayPJ[intRandomArrayValuePJ][1]);

                    // Adds the new obstacle to the controls
                    this.Controls.Add(picObstacles[i]);

                    // Resets collision to false
                    blnCollision[i] = false;
                }
            }
        }
        // Input: Obstacle location
        // Process: If on screen, will constantly move downwards either in a staright line or wave(depends on option select) If Offscreen will dispose the picturebox and set value to null so a new one can be created
        // Output: Pictureboxes moving down or in a wave and New pictureboxes coming from the top
        public void OffScreenObstacles()
        {
            // Moves obstacles downward
            for (int i = 0; i < picObstacles.Length; i++)
            {
                if (picObstacles[i] != null)
                {
                    // Regular Motion
                    if (Class1.blnHardPJ == false)
                    {
                        if(Class1.intPlayerScorePJ >= 35000)
                        {
                            intMovementSpeedPJ = 9;
                        }
                        else if(Class1.intPlayerScorePJ >= 65000)
                        {
                            intMovementSpeedPJ = 11;
                        }
                        else if(Class1.intPlayerScorePJ >= 100000)
                        {
                            intMovementSpeedPJ = 13;
                        }
                        else if(Class1.intPlayerScorePJ >= 150000)
                        {
                            intMovementSpeedPJ = 15;
                        }
                        else if(Class1.intPlayerScorePJ >= 200000)
                        {
                            intMovementSpeedPJ = 18;
                        }
                        else if(Class1.intPlayerScorePJ >= 250000)
                        {
                            intMovementSpeedPJ = 22;
                        }
                        else if(Class1.intPlayerScorePJ >= 300000)
                        {
                            intMovementSpeedPJ = 30;
                        }
                        picObstacles[i].Top += intObstacleMovementPJ[i] + intMovementSpeedPJ;
                    }
                    // Sinusodial Function Motion
                    else if (Class1.blnHardPJ == true)
                    {
                        if (i <= 4)
                        {
                            if (intObstacleMovementPJ[i] != 1 || intObstacleMovementPJ[i] != 2)
                            {
                                picObstacles[i].Top += intObstacleMovementPJ[i] - 2;
                            }
                            dblXValuePJ = picObstacles[i].Top;
                            dblYValuePJ = (int)(500 * Math.Sin(0.01 * dblXValuePJ) + 490);
                            picObstacles[i].Left = (int)dblYValuePJ;
                        }
                        else if (i > 4)
                        {
                            if (intObstacleMovementPJ[i] != 1 || intObstacleMovementPJ[i] != 2)
                            {
                                picObstacles[i].Top += intObstacleMovementPJ[i] - 2;
                            }
                            dblXValuePJ = picObstacles[i].Top;
                            dblYValuePJ = (int)((500 * -1) * Math.Cos(0.01 * dblXValuePJ) + 490);
                            picObstacles[i].Left = (int)dblYValuePJ;

                        }
                    }
                }
            }
            // Checks if obstacles are off screen, to be more precise, above the height of the screen
            for (int i = 0; i < picObstacles.Length; i++)
            {
                if (picObstacles[i].Top > this.Height)
                {
                    // Obstacle is disposed of
                    picObstacles[i].Dispose();
                    // Obstacle array value is set to null
                    picObstacles[i] = null;
                }
            }
        }
        // Input: Player Location
        // Process: If the player intersects with the picturebox while their shield is off and the obstacle collision value is false
        // Output: Player life decreases
        public void ObstacleCollision()
        {
            for (int i = 0; i < picObstacles.Length; i++)
            {
                if (picObstacles[i] != null && tmrinvincible.Enabled == false)
                {
                    if (picObstacles[i].Bounds.IntersectsWith(picPlayer.Bounds) && blnCollision[i] == false)
                    {
                        // Set Obstacle Collision to true
                        blnCollision[i] = true;
                        // Set Obstacle visibility to false
                        picObstacles[i].Visible = false;
                        // Ship lives decreases by 1
                        dblTakenHitsPJ -= dblHitterPJ;
                        if (tmrinvincible.Enabled == false)
                        {
                            tmrinvincible.Enabled = true;
                        }
                    }
                }
            }
        }
        // Input: Obstacle Location
        // Process: If obstacles are intersecting with each other a new point is made and the obstacle is set to that new point
        // Output: Obstacles that are stand alone and not all cluttered up
        public void OverlapChecker()
        {
            // Variable Declaration
            Random rndPJ = new Random();
            Point rndPointPJ = new Point();
            // Looping through obstacle array
            for (int i = 0; i < picObstacles.Length - 1; i++)
            {
                // If two of the obstacles exist
                if (picObstacles[i] != null && picObstacles[i + 1] != null)
                {
                    // While the two obstacles overlap each other
                    while ((picObstacles[i].Bounds.IntersectsWith(picObstacles[i + 1].Bounds)))
                    {
                        // Generates random point
                        rndPointPJ = new Point(rndPJ.Next(3, this.Width - 3), rndPJ.Next(-200, -100));
                        // Places obstacle to the random point
                        picObstacles[i].Location = rndPointPJ;


                    }
                }
            }
        }
        // Input: Player Score and AddedLives variables
        // Process: Depending on Score AddedLives will increase
        // Output: More life per Powerup
        public double dblLifeIncrease(int intPlayerScorePJ, double dblAddedLivesPJ)     
        {
            if (intPlayerScorePJ >= 75000)
            {
                dblAddedLivesPJ = 2;
            }
            else if (intPlayerScorePJ >= 125000)
            {
                dblAddedLivesPJ = 3;
            }
            return dblAddedLivesPJ;
        }
        // Input:  Energy Powerup Location
        // Process: If the player intersects with these while their life is down, they'll be more life. The picturebox will constantly move down. If the picturebox is off screen, a new point for it will be set so it can down from the screen again
        // Output: Powerup increasing your life and moving down
        public void EnergySetter()
        {
            Random rndPJ = new Random();
            picShield.BackgroundImageLayout = ImageLayout.Stretch;
            picShield.Size = new Size(36, 30);
            picShield.BackgroundImage = imgShield;
            picShield.BackColor = Color.Transparent;
            this.Controls.Add(picShield);
            if (picPlayer.Bounds.IntersectsWith(picShield.Bounds) && picShield.Visible == true)
            {
                if (prgLife.Value < 100)
                {
                    dblTakenHitsPJ += dblAddedLivesPJ;

                }
                if(dblTakenHitsPJ > 5)
                {
                    dblTakenHitsPJ = 5;
                }
                picShield.Visible = false;
            }
            if (picShield.Top > this.Height + 1000)
            {
                picShield.Location = new Point(rndPJ.Next(3, this.Width - 3), rndPJ.Next(-200, -100));
                picShield.Visible = true;
            }
            picShield.Top += intMovementSpeedPJ;
        }
        // Input: Missile Powerup Location
        // Process: If the player collects the powerup they can shoot once, if the missile is below a certain height, it's location will be reset, Missile will gradually move down
        // Output: Missile moving down and resetting location when appropriate, will allow player to shoot
        public void MissileSetter()
        {
            Random rndPJ = new Random();
            picMissile.BackgroundImageLayout = ImageLayout.Stretch;
            picMissile.Size = new Size(36, 47);
            picMissile.BackgroundImage = imgMissile;
            picMissile.BackColor = Color.Transparent;
            this.Controls.Add(picMissile);
            if (picPlayer.Bounds.IntersectsWith(picMissile.Bounds) && picMissile.Visible == true)
            {
                intMissileShotsPJ += 1;
                picMissile.Visible = false;
            }
            if (picMissile.Top > this.Height + 2000)
            {
                picMissile.Location = new Point(rndPJ.Next(3, this.Width - 3), rndPJ.Next(-200, -100));
                picMissile.Visible = true;
            }
            picMissile.Top += intMovementSpeedPJ;

        }
        // Input: Player Location and MissileShots Variable
        // Process: MissileShots Variable will decrease by 1, a picturebox is created with a selected point
        // Output: Missile is created ontop of player, MissileShots variable decreased by 1
        public void MissileShooter()
        {
            if (intMissileShotsPJ > 0)
            {
                for (int i = 0; i < picMissilesPJ.Length; i++)
                {
                    if (picMissilesPJ[i] == null)
                    {
                        picMissilesPJ[i] = new PictureBox();
                        picMissilesPJ[i].Size = new Size(6, 12);
                        picMissilesPJ[i].Location = new Point(picPlayer.Left + picPlayer.Width / 2, picPlayer.Top);
                        picMissilesPJ[i].BackColor = Color.White;
                        this.Controls.Add(picMissilesPJ[i]);
                        blnMissleCollision[i] = false;
                        intMissileShotsPJ--;
                    }
                }


            }
        }
        // Input: Missile Location
        // Process: Missile will gradually move up and once off screen will be disposed and set to null
        // Output: Missile moving upwards
        public void MissileMover()
        {
            for (int i = 0; i < picMissilesPJ.Length; i++)
            {
                if (picMissilesPJ[i] != null)
                {
                    picMissilesPJ[i].Top -= intMovementSpeedPJ;
                }
            }

            for (int i = 0; i < picMissilesPJ.Length; i++)
            {
                if (picMissilesPJ[i] != null)
                {
                    if (picMissilesPJ[i].Top < 0)
                    {
                        picMissilesPJ[i].Dispose();
                        picMissilesPJ[i] = null;

                    }
                }
            }
        }
        // Input: Missile Location and Obstacle Location
        // Process: If Missile and Obstacle intersect, both of them will disappear
        // Output: Missile and Obstacles colliding (disappearing from the screen)
        public void MissileCollision()
        {
            for (int i = 0; i < picMissilesPJ.Length; i++)
            {
                for (int o = 0; o < picObstacles.Length; o++)
                {
                    if (picMissilesPJ[i] != null && picObstacles[o] != null)
                    {
                        if (picMissilesPJ[i].Bounds.IntersectsWith(picObstacles[o].Bounds) && blnMissleCollision[i] == false)
                        {
                            picMissilesPJ[i].Visible = false;
                            picMissilesPJ[i].Dispose();
                            picMissilesPJ[i] = null;
                            blnMissleCollision[i] = true;
                            picObstacles[o].Visible = false;
                            blnCollision[o] = true;
                            picObstacles[o].Dispose();
                            picObstacles[o] = null;

                        }
                    }
                }
            }
        }
        // Process: Shield is visible and location is ontop of player
        // Output: Shield ontop of player
        private void tmrinvincible_Tick(object sender, EventArgs e)
        {
            picShieldOne.Visible = true;
            picShieldOne.Location = new Point(picPlayer.Left - 21, picPlayer.Top - 15);
            picShieldOne.BackColor = Color.Transparent;
        }
        // Process: Invincible timer is not enabled, shield is not visible, Delay timer is not enabled
        // Output: Allows the shield to stay on for a period of time before disappearing
        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            tmrinvincible.Enabled = false;
            picShieldOne.Visible = false;
            tmrDelay.Enabled = false;
        }

    }
}
