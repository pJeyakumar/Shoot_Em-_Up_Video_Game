namespace A8_PiranavanJeyakumar_Culiminating
{
    partial class frmMainMenu
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnControls = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picUnderline = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUnderline)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnStart.Location = new System.Drawing.Point(414, 524);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(219, 119);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "BEGIN";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHighscore
            // 
            this.btnHighscore.BackColor = System.Drawing.Color.Black;
            this.btnHighscore.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighscore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHighscore.Location = new System.Drawing.Point(826, 524);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(231, 119);
            this.btnHighscore.TabIndex = 1;
            this.btnHighscore.Text = "HIGHSCORES";
            this.btnHighscore.UseVisualStyleBackColor = false;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // btnControls
            // 
            this.btnControls.BackColor = System.Drawing.Color.Black;
            this.btnControls.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControls.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnControls.Location = new System.Drawing.Point(12, 524);
            this.btnControls.Name = "btnControls";
            this.btnControls.Size = new System.Drawing.Size(219, 119);
            this.btnControls.TabIndex = 2;
            this.btnControls.Text = "CONTROLS";
            this.btnControls.UseVisualStyleBackColor = false;
            this.btnControls.Click += new System.EventHandler(this.BtnControls_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Niagara Engraved", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitle.Location = new System.Drawing.Point(242, -3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(591, 178);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Asteroid Blasters";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picUnderline
            // 
            this.picUnderline.BackColor = System.Drawing.Color.DarkRed;
            this.picUnderline.Location = new System.Drawing.Point(306, 125);
            this.picUnderline.Name = "picUnderline";
            this.picUnderline.Size = new System.Drawing.Size(446, 10);
            this.picUnderline.TabIndex = 4;
            this.picUnderline.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A8_PiranavanJeyakumar_Culiminating.Resource1._0JhfDyO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 655);
            this.ControlBox = false;
            this.Controls.Add(this.picUnderline);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnControls);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picUnderline)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.Button btnControls;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picUnderline;
    }
}