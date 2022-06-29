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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buy1Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Buy2Btn = new System.Windows.Forms.Button();
            this.Buy3Btn = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::PacmanGUI.Resources.textShop;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(213, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(213, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hipster Pacman";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(213, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 84);
            this.label2.TabIndex = 15;
            this.label2.Text = "Good-looking young hipster \r\nguy in a red beanie\r\n\r\nPrice: 20 points";
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
            this.Buy1Btn.Text = "Buy";
            this.Buy1Btn.UseVisualStyleBackColor = false;
            this.Buy1Btn.Click += new System.EventHandler(this.Buy1Btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(193, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pacman in Sombrero";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(193, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 84);
            this.label4.TabIndex = 18;
            this.label4.Text = "He just likes nachos too much\r\n\r\n\r\nPrice: 50 points";
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
            this.Buy2Btn.Text = "Buy";
            this.Buy2Btn.UseVisualStyleBackColor = false;
            this.Buy2Btn.Click += new System.EventHandler(this.Buy2Btn_Click);
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
            this.Buy3Btn.Text = "Buy";
            this.Buy3Btn.UseVisualStyleBackColor = false;
            this.Buy3Btn.Click += new System.EventHandler(this.Buy3Btn_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pointsLabel.Location = new System.Drawing.Point(373, 662);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(194, 65);
            this.pointsLabel.TabIndex = 21;
            this.pointsLabel.Text = "Points: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(193, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Satanic Pacman";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(193, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 84);
            this.label6.TabIndex = 23;
            this.label6.Text = "Even satan himself is scared \r\nof ghosts\r\n\r\nPrice: 100 points";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 831);
            this.Controls.Add(this.Buy3Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.Buy2Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Buy1Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button BackBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        public Button Buy1Btn;
        private Label label3;
        private Label label4;
        public Button Buy2Btn;
        public Button Buy3Btn;
        private Label pointsLabel;
        private Label label5;
        private Label label6;
    }
}