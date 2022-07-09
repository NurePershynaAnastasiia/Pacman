namespace PacmanGUI
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Hipster1Label = new System.Windows.Forms.Label();
            this.Hipster2Label = new System.Windows.Forms.Label();
            this.Buy1Btn = new System.Windows.Forms.Button();
            this.Sombrero1Label = new System.Windows.Forms.Label();
            this.Sombrero2Label = new System.Windows.Forms.Label();
            this.Buy2Btn = new System.Windows.Forms.Button();
            this.Buy3Btn = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.Satan1Label = new System.Windows.Forms.Label();
            this.Satan2Label = new System.Windows.Forms.Label();
            this.PointsNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titlePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePictureBox.Location = new System.Drawing.Point(193, 38);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(329, 98);
            this.titlePictureBox.TabIndex = 0;
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
            this.BackBtn.Location = new System.Drawing.Point(35, 667);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(233, 60);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::PacmanGUI.Resources.pacman1;
            this.pictureBox2.Location = new System.Drawing.Point(35, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::PacmanGUI.Resources.pacman2;
            this.pictureBox3.Location = new System.Drawing.Point(35, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = global::PacmanGUI.Resources.pacman3;
            this.pictureBox4.Location = new System.Drawing.Point(35, 471);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(142, 131);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // Hipster1Label
            // 
            this.Hipster1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Hipster1Label.AutoSize = true;
            this.Hipster1Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hipster1Label.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hipster1Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hipster1Label.Location = new System.Drawing.Point(193, 168);
            this.Hipster1Label.Name = "Hipster1Label";
            this.Hipster1Label.Size = new System.Drawing.Size(294, 32);
            this.Hipster1Label.TabIndex = 14;
            this.Hipster1Label.Text = "Hipster Pacman";
            // 
            // Hipster2Label
            // 
            this.Hipster2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Hipster2Label.AutoSize = true;
            this.Hipster2Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hipster2Label.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hipster2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hipster2Label.Location = new System.Drawing.Point(193, 208);
            this.Hipster2Label.Name = "Hipster2Label";
            this.Hipster2Label.Size = new System.Drawing.Size(388, 84);
            this.Hipster2Label.TabIndex = 15;
            this.Hipster2Label.Text = "Good-looking young hipster \r\nguy in a red beanie\r\n\r\nPrice: 20 points";
            // 
            // Buy1Btn
            // 
            this.Buy1Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Buy1Btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Buy1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buy1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.Buy1Btn.FlatAppearance.BorderSize = 3;
            this.Buy1Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.Buy1Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Buy1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buy1Btn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Buy1Btn.Location = new System.Drawing.Point(539, 254);
            this.Buy1Btn.Name = "Buy1Btn";
            this.Buy1Btn.Size = new System.Drawing.Size(193, 47);
            this.Buy1Btn.TabIndex = 16;
            this.Buy1Btn.Tag = "1";
            this.Buy1Btn.Text = "Buy";
            this.Buy1Btn.UseVisualStyleBackColor = false;
            this.Buy1Btn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // Sombrero1Label
            // 
            this.Sombrero1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sombrero1Label.AutoSize = true;
            this.Sombrero1Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sombrero1Label.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sombrero1Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sombrero1Label.Location = new System.Drawing.Point(193, 319);
            this.Sombrero1Label.Name = "Sombrero1Label";
            this.Sombrero1Label.Size = new System.Drawing.Size(374, 32);
            this.Sombrero1Label.TabIndex = 17;
            this.Sombrero1Label.Text = "Pacman in Sombrero";
            // 
            // Sombrero2Label
            // 
            this.Sombrero2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sombrero2Label.AutoSize = true;
            this.Sombrero2Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sombrero2Label.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sombrero2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sombrero2Label.Location = new System.Drawing.Point(193, 359);
            this.Sombrero2Label.Name = "Sombrero2Label";
            this.Sombrero2Label.Size = new System.Drawing.Size(416, 84);
            this.Sombrero2Label.TabIndex = 18;
            this.Sombrero2Label.Text = "He just likes nachos too much\r\n\r\n\r\nPrice: 50 points";
            // 
            // Buy2Btn
            // 
            this.Buy2Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Buy2Btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Buy2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buy2Btn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.Buy2Btn.FlatAppearance.BorderSize = 3;
            this.Buy2Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.Buy2Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Buy2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buy2Btn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Buy2Btn.Location = new System.Drawing.Point(539, 402);
            this.Buy2Btn.Name = "Buy2Btn";
            this.Buy2Btn.Size = new System.Drawing.Size(193, 47);
            this.Buy2Btn.TabIndex = 19;
            this.Buy2Btn.Tag = "2";
            this.Buy2Btn.Text = "Buy";
            this.Buy2Btn.UseVisualStyleBackColor = false;
            this.Buy2Btn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // Buy3Btn
            // 
            this.Buy3Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Buy3Btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Buy3Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buy3Btn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.Buy3Btn.FlatAppearance.BorderSize = 3;
            this.Buy3Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.Buy3Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Buy3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buy3Btn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Buy3Btn.Location = new System.Drawing.Point(539, 555);
            this.Buy3Btn.Name = "Buy3Btn";
            this.Buy3Btn.Size = new System.Drawing.Size(193, 47);
            this.Buy3Btn.TabIndex = 20;
            this.Buy3Btn.Tag = "3";
            this.Buy3Btn.Text = "Buy";
            this.Buy3Btn.UseVisualStyleBackColor = false;
            this.Buy3Btn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pointsLabel.Location = new System.Drawing.Point(373, 682);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(194, 65);
            this.pointsLabel.TabIndex = 21;
            this.pointsLabel.Text = "Points: ";
            // 
            // Satan1Label
            // 
            this.Satan1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Satan1Label.AutoSize = true;
            this.Satan1Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Satan1Label.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Satan1Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Satan1Label.Location = new System.Drawing.Point(193, 471);
            this.Satan1Label.Name = "Satan1Label";
            this.Satan1Label.Size = new System.Drawing.Size(294, 32);
            this.Satan1Label.TabIndex = 22;
            this.Satan1Label.Text = "Satanic Pacman";
            // 
            // Satan2Label
            // 
            this.Satan2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Satan2Label.AutoSize = true;
            this.Satan2Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Satan2Label.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Satan2Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Satan2Label.Location = new System.Drawing.Point(193, 518);
            this.Satan2Label.Name = "Satan2Label";
            this.Satan2Label.Size = new System.Drawing.Size(416, 84);
            this.Satan2Label.TabIndex = 23;
            this.Satan2Label.Text = "Even satan himself is scared \r\nof ghosts\r\n\r\nPrice: 100 points";
            // 
            // PointsNumberLabel
            // 
            this.PointsNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PointsNumberLabel.AutoSize = true;
            this.PointsNumberLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PointsNumberLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PointsNumberLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PointsNumberLabel.Location = new System.Drawing.Point(595, 682);
            this.PointsNumberLabel.Name = "PointsNumberLabel";
            this.PointsNumberLabel.Size = new System.Drawing.Size(0, 65);
            this.PointsNumberLabel.TabIndex = 24;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 831);
            this.Controls.Add(this.PointsNumberLabel);
            this.Controls.Add(this.Buy3Btn);
            this.Controls.Add(this.Satan2Label);
            this.Controls.Add(this.Satan1Label);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.Buy2Btn);
            this.Controls.Add(this.Sombrero2Label);
            this.Controls.Add(this.Sombrero1Label);
            this.Controls.Add(this.Buy1Btn);
            this.Controls.Add(this.Hipster2Label);
            this.Controls.Add(this.Hipster1Label);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.titlePictureBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PictureBox titlePictureBox;
        public Button BackBtn;
        public PictureBox pictureBox2;
        public PictureBox pictureBox3;
        public PictureBox pictureBox4;
        public Label Hipster1Label;
        public Label Hipster2Label;
        public Button Buy1Btn;
        public Label Sombrero1Label;
        public Label Sombrero2Label;
        public Button Buy2Btn;
        public Button Buy3Btn;
        public Label pointsLabel;
        public Label Satan1Label;
        public Label Satan2Label;
        public Label PointsNumberLabel;
    }
}