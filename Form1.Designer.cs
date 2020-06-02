namespace A8_PiranavanJeyakumar_Culiminating
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrGameLogic = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrinvincible = new System.Windows.Forms.Timer(this.components);
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.prgLife = new System.Windows.Forms.ProgressBar();
            this.lblBegin = new System.Windows.Forms.Label();
            this.tmrObstacles = new System.Windows.Forms.Timer(this.components);
            this.picMissile = new System.Windows.Forms.PictureBox();
            this.picShield = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picShieldOne = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMissileOnOrOff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMissile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShieldOne)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGameLogic
            // 
            this.tmrGameLogic.Interval = 1;
            this.tmrGameLogic.Tick += new System.EventHandler(this.tmrGameLogic_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-13, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Life";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(669, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(766, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(170, 35);
            this.lblScore.TabIndex = 5;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrinvincible
            // 
            this.tmrinvincible.Interval = 1;
            this.tmrinvincible.Tick += new System.EventHandler(this.tmrinvincible_Tick);
            // 
            // tmrDelay
            // 
            this.tmrDelay.Interval = 2500;
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // prgLife
            // 
            this.prgLife.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.prgLife.Location = new System.Drawing.Point(69, 0);
            this.prgLife.Name = "prgLife";
            this.prgLife.Size = new System.Drawing.Size(187, 35);
            this.prgLife.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgLife.TabIndex = 7;
            this.prgLife.Value = 100;
            // 
            // lblBegin
            // 
            this.lblBegin.BackColor = System.Drawing.Color.Transparent;
            this.lblBegin.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegin.ForeColor = System.Drawing.Color.White;
            this.lblBegin.Location = new System.Drawing.Point(261, 180);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(455, 101);
            this.lblBegin.TabIndex = 10;
            this.lblBegin.Text = "Press Space";
            this.lblBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrObstacles
            // 
            this.tmrObstacles.Interval = 200;
            // 
            // picMissile
            // 
            this.picMissile.BackgroundImage = global::A8_PiranavanJeyakumar_Culiminating.Resource1.launcher_clipart_missile_clipart_1285541080;
            this.picMissile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMissile.Location = new System.Drawing.Point(964, 422);
            this.picMissile.Name = "picMissile";
            this.picMissile.Size = new System.Drawing.Size(36, 47);
            this.picMissile.TabIndex = 11;
            this.picMissile.TabStop = false;
            // 
            // picShield
            // 
            this.picShield.BackgroundImage = global::A8_PiranavanJeyakumar_Culiminating.Resource1.LotS_Blue_Alien_Energy_Sphere;
            this.picShield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picShield.Location = new System.Drawing.Point(964, 371);
            this.picShield.Name = "picShield";
            this.picShield.Size = new System.Drawing.Size(36, 30);
            this.picShield.TabIndex = 9;
            this.picShield.TabStop = false;
            this.picShield.Visible = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::A8_PiranavanJeyakumar_Culiminating.Resource1.OriginalShip;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(465, 559);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(51, 50);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picShieldOne
            // 
            this.picShieldOne.BackColor = System.Drawing.Color.Transparent;
            this.picShieldOne.BackgroundImage = global::A8_PiranavanJeyakumar_Culiminating.Resource1.spr_shield;
            this.picShieldOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picShieldOne.Location = new System.Drawing.Point(441, 543);
            this.picShieldOne.Name = "picShieldOne";
            this.picShieldOne.Size = new System.Drawing.Size(100, 86);
            this.picShieldOne.TabIndex = 6;
            this.picShieldOne.TabStop = false;
            this.picShieldOne.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Missile";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMissileOnOrOff
            // 
            this.lblMissileOnOrOff.BackColor = System.Drawing.Color.Transparent;
            this.lblMissileOnOrOff.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissileOnOrOff.ForeColor = System.Drawing.Color.White;
            this.lblMissileOnOrOff.Location = new System.Drawing.Point(104, 588);
            this.lblMissileOnOrOff.Name = "lblMissileOnOrOff";
            this.lblMissileOnOrOff.Size = new System.Drawing.Size(64, 35);
            this.lblMissileOnOrOff.TabIndex = 13;
            this.lblMissileOnOrOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(955, 632);
            this.ControlBox = false;
            this.Controls.Add(this.lblMissileOnOrOff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picMissile);
            this.Controls.Add(this.picShield);
            this.Controls.Add(this.prgLife);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picShieldOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asteroid Blaster";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picMissile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShieldOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmrGameLogic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrinvincible;
        private System.Windows.Forms.PictureBox picShieldOne;
        private System.Windows.Forms.Timer tmrDelay;
        private System.Windows.Forms.ProgressBar prgLife;
        private System.Windows.Forms.PictureBox picShield;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.PictureBox picMissile;
        private System.Windows.Forms.Timer tmrObstacles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMissileOnOrOff;
    }
}

