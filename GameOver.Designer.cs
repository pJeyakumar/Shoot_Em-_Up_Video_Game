namespace A8_PiranavanJeyakumar_Culiminating
{
    partial class frmGameOver
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
            this.btnToHighscores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToHighscores
            // 
            this.btnToHighscores.BackColor = System.Drawing.Color.Black;
            this.btnToHighscores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToHighscores.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToHighscores.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnToHighscores.Location = new System.Drawing.Point(385, 400);
            this.btnToHighscores.Name = "btnToHighscores";
            this.btnToHighscores.Size = new System.Drawing.Size(178, 60);
            this.btnToHighscores.TabIndex = 0;
            this.btnToHighscores.Text = "Continue?";
            this.btnToHighscores.UseVisualStyleBackColor = false;
            this.btnToHighscores.Click += new System.EventHandler(this.btnToHighscores_Click);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A8_PiranavanJeyakumar_Culiminating.Resource1.game_over_retro_arcade_digital_blue_style_1_nngybqf7pg__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 596);
            this.Controls.Add(this.btnToHighscores);
            this.Name = "frmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToHighscores;
    }
}