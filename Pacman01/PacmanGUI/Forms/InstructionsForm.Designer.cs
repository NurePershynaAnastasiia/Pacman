namespace PacmanGUI
{
    partial class InstructionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionsForm));
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.labelPacman = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelGhost = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelGhostScared = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelEnergizer1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelCoin = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelWall = new System.Windows.Forms.Label();
            this.labelEnergizer2 = new System.Windows.Forms.Label();
            this.labelBonus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titlePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePictureBox.Location = new System.Drawing.Point(60, 57);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(664, 89);
            this.titlePictureBox.TabIndex = 5;
            this.titlePictureBox.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BackBtn.BackColor = System.Drawing.Color.Teal;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.BackBtn.FlatAppearance.BorderSize = 3;
            this.BackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.Location = new System.Drawing.Point(45, 654);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(245, 57);
            this.BackBtn.TabIndex = 9;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // labelPacman
            // 
            this.labelPacman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPacman.AutoSize = true;
            this.labelPacman.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPacman.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPacman.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPacman.Location = new System.Drawing.Point(170, 178);
            this.labelPacman.Name = "labelPacman";
            this.labelPacman.Size = new System.Drawing.Size(217, 60);
            this.labelPacman.TabIndex = 10;
            this.labelPacman.Text = "PacMan (player) \r\ncontrolled \r\nwith WASD keys";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::PacmanGUI.Resources.pacman0;
            this.pictureBox2.Location = new System.Drawing.Point(45, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::PacmanGUI.Resources.enemy_right;
            this.pictureBox3.Location = new System.Drawing.Point(45, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // labelGhost
            // 
            this.labelGhost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGhost.AutoSize = true;
            this.labelGhost.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGhost.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGhost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGhost.Location = new System.Drawing.Point(170, 274);
            this.labelGhost.Name = "labelGhost";
            this.labelGhost.Size = new System.Drawing.Size(178, 60);
            this.labelGhost.TabIndex = 13;
            this.labelGhost.Text = "Ghost (enemy)\r\nwhich PacMan \r\nhas to avoid";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = global::PacmanGUI.Resources.enemy_scared;
            this.pictureBox4.Location = new System.Drawing.Point(395, 274);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // labelGhostScared
            // 
            this.labelGhostScared.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelGhostScared.AutoSize = true;
            this.labelGhostScared.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGhostScared.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGhostScared.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGhostScared.Location = new System.Drawing.Point(530, 274);
            this.labelGhostScared.Name = "labelGhostScared";
            this.labelGhostScared.Size = new System.Drawing.Size(165, 60);
            this.labelGhostScared.TabIndex = 15;
            this.labelGhostScared.Text = "Scared Ghost\r\n(harmless\r\nenemy)";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Image = global::PacmanGUI.Resources.energizer;
            this.pictureBox5.Location = new System.Drawing.Point(45, 382);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(119, 107);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // labelEnergizer1
            // 
            this.labelEnergizer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEnergizer1.AutoSize = true;
            this.labelEnergizer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnergizer1.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnergizer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnergizer1.Location = new System.Drawing.Point(170, 382);
            this.labelEnergizer1.Name = "labelEnergizer1";
            this.labelEnergizer1.Size = new System.Drawing.Size(451, 40);
            this.labelEnergizer1.TabIndex = 17;
            this.labelEnergizer1.Text = "Energizer which PacMan can eat to \r\nturn Ghosts into Scared mode\r\n";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Image = global::PacmanGUI.Resources.coin;
            this.pictureBox6.Location = new System.Drawing.Point(393, 164);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(119, 101);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // labelCoin
            // 
            this.labelCoin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCoin.AutoSize = true;
            this.labelCoin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCoin.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCoin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCoin.Location = new System.Drawing.Point(533, 164);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(191, 80);
            this.labelCoin.TabIndex = 19;
            this.labelCoin.Text = "Coin, which \r\nPacMan has to \r\neat to \r\nearn Points";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.Image = global::PacmanGUI.Resources.wall;
            this.pictureBox7.Location = new System.Drawing.Point(440, 509);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // labelWall
            // 
            this.labelWall.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWall.AutoSize = true;
            this.labelWall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelWall.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWall.Location = new System.Drawing.Point(530, 509);
            this.labelWall.Name = "labelWall";
            this.labelWall.Size = new System.Drawing.Size(178, 100);
            this.labelWall.TabIndex = 21;
            this.labelWall.Text = "Wall\r\n(impenetrable\r\nobstacle for\r\nPacMan and\r\nEnemies)";
            // 
            // labelEnergizer2
            // 
            this.labelEnergizer2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelEnergizer2.AutoSize = true;
            this.labelEnergizer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEnergizer2.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnergizer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnergizer2.Location = new System.Drawing.Point(170, 444);
            this.labelEnergizer2.Name = "labelEnergizer2";
            this.labelEnergizer2.Size = new System.Drawing.Size(357, 45);
            this.labelEnergizer2.TabIndex = 22;
            this.labelEnergizer2.Text = "When Ghosts are in Scared mode,\r\nPacMan can \"eat\" them to neutralize\r\nfor some ti" +
    "me\r\n";
            // 
            // labelBonus
            // 
            this.labelBonus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBonus.AutoSize = true;
            this.labelBonus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBonus.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBonus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBonus.Location = new System.Drawing.Point(170, 519);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(178, 80);
            this.labelBonus.TabIndex = 23;
            this.labelBonus.Text = "Bonus (adds \r\n10 points to \r\nGeneral Score\r\nif eaten)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::PacmanGUI.Resources.bonus;
            this.pictureBox1.Location = new System.Drawing.Point(45, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 800);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelBonus);
            this.Controls.Add(this.labelEnergizer2);
            this.Controls.Add(this.labelWall);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.labelEnergizer1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.labelGhostScared);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelGhost);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelPacman);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.titlePictureBox);
            this.Controls.Add(this.pictureBox6);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstructionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructionsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InstructionsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public PictureBox titlePictureBox;
        public Button BackBtn;
        public Label labelPacman;
        public PictureBox pictureBox2;
        public PictureBox pictureBox3;
        public Label labelGhost;
        public PictureBox pictureBox4;
        public Label labelGhostScared;
        public PictureBox pictureBox5;
        public Label labelEnergizer1;
        public PictureBox pictureBox6;
        public Label labelCoin;
        public PictureBox pictureBox7;
        public Label labelWall;
        public Label labelEnergizer2;
        public Label labelBonus;
        public PictureBox pictureBox1;
    }
}