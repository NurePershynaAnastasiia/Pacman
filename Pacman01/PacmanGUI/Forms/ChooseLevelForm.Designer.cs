namespace PacmanGUI
{
    partial class ChooseLevelForm
    {
        /// <summary>
        /// Required designer variable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevelForm));
            this.BackBtn = new System.Windows.Forms.Button();
            this.chooseLevelTitlePictureBox = new System.Windows.Forms.PictureBox();
            this.Lvl1Btn = new System.Windows.Forms.Button();
            this.Lvl2Btn = new System.Windows.Forms.Button();
            this.Lvl3Btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RandomMapBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chooseLevelTitlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.BackBtn.Location = new System.Drawing.Point(195, 598);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(268, 62);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // chooseLevelTitlePictureBox
            // 
            this.chooseLevelTitlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chooseLevelTitlePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chooseLevelTitlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseLevelTitlePictureBox.ErrorImage = null;
            this.chooseLevelTitlePictureBox.Location = new System.Drawing.Point(262, 72);
            this.chooseLevelTitlePictureBox.Name = "chooseLevelTitlePictureBox";
            this.chooseLevelTitlePictureBox.Size = new System.Drawing.Size(584, 87);
            this.chooseLevelTitlePictureBox.TabIndex = 11;
            this.chooseLevelTitlePictureBox.TabStop = false;
            // 
            // Lvl1Btn
            // 
            this.Lvl1Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lvl1Btn.BackColor = System.Drawing.Color.Tomato;
            this.Lvl1Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lvl1Btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Lvl1Btn.FlatAppearance.BorderSize = 3;
            this.Lvl1Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Lvl1Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.Lvl1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lvl1Btn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lvl1Btn.Location = new System.Drawing.Point(684, 189);
            this.Lvl1Btn.Name = "Lvl1Btn";
            this.Lvl1Btn.Size = new System.Drawing.Size(306, 61);
            this.Lvl1Btn.TabIndex = 12;
            this.Lvl1Btn.Tag = "1";
            this.Lvl1Btn.Text = "Level 1\r\n";
            this.Lvl1Btn.UseVisualStyleBackColor = false;
            this.Lvl1Btn.Click += new System.EventHandler(this.LvlBtn_Click);
            this.Lvl1Btn.MouseLeave += new System.EventHandler(this.LvlBtn_MouseLeave);
            this.Lvl1Btn.MouseHover += new System.EventHandler(this.LvlBtn_MouseHover);
            // 
            // Lvl2Btn
            // 
            this.Lvl2Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lvl2Btn.BackColor = System.Drawing.Color.Tomato;
            this.Lvl2Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lvl2Btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Lvl2Btn.FlatAppearance.BorderSize = 3;
            this.Lvl2Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Lvl2Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.Lvl2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lvl2Btn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lvl2Btn.Location = new System.Drawing.Point(684, 296);
            this.Lvl2Btn.Name = "Lvl2Btn";
            this.Lvl2Btn.Size = new System.Drawing.Size(306, 61);
            this.Lvl2Btn.TabIndex = 13;
            this.Lvl2Btn.Tag = "2";
            this.Lvl2Btn.Text = "Level 2\r\n";
            this.Lvl2Btn.UseVisualStyleBackColor = false;
            this.Lvl2Btn.Click += new System.EventHandler(this.LvlBtn_Click);
            this.Lvl2Btn.MouseLeave += new System.EventHandler(this.LvlBtn_MouseLeave);
            this.Lvl2Btn.MouseHover += new System.EventHandler(this.LvlBtn_MouseHover);
            // 
            // Lvl3Btn
            // 
            this.Lvl3Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lvl3Btn.BackColor = System.Drawing.Color.Tomato;
            this.Lvl3Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lvl3Btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Lvl3Btn.FlatAppearance.BorderSize = 3;
            this.Lvl3Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Lvl3Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.Lvl3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lvl3Btn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lvl3Btn.Location = new System.Drawing.Point(684, 414);
            this.Lvl3Btn.Name = "Lvl3Btn";
            this.Lvl3Btn.Size = new System.Drawing.Size(306, 61);
            this.Lvl3Btn.TabIndex = 14;
            this.Lvl3Btn.Tag = "3";
            this.Lvl3Btn.Text = "Level 3";
            this.Lvl3Btn.UseVisualStyleBackColor = false;
            this.Lvl3Btn.Click += new System.EventHandler(this.LvlBtn_Click);
            this.Lvl3Btn.MouseLeave += new System.EventHandler(this.LvlBtn_MouseLeave);
            this.Lvl3Btn.MouseHover += new System.EventHandler(this.LvlBtn_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(195, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(697, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // RandomMapBtn
            // 
            this.RandomMapBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RandomMapBtn.BackColor = System.Drawing.Color.Tomato;
            this.RandomMapBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomMapBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.RandomMapBtn.FlatAppearance.BorderSize = 3;
            this.RandomMapBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.RandomMapBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.RandomMapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomMapBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RandomMapBtn.Location = new System.Drawing.Point(684, 516);
            this.RandomMapBtn.Name = "RandomMapBtn";
            this.RandomMapBtn.Size = new System.Drawing.Size(306, 61);
            this.RandomMapBtn.TabIndex = 16;
            this.RandomMapBtn.Tag = "4";
            this.RandomMapBtn.Text = "Random Map";
            this.RandomMapBtn.UseVisualStyleBackColor = false;
            this.RandomMapBtn.Click += new System.EventHandler(this.LvlBtn_Click);
            // 
            // ChooseLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 831);
            this.Controls.Add(this.RandomMapBtn);
            this.Controls.Add(this.Lvl3Btn);
            this.Controls.Add(this.Lvl2Btn);
            this.Controls.Add(this.Lvl1Btn);
            this.Controls.Add(this.chooseLevelTitlePictureBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseLevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Level";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChooseLevelForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chooseLevelTitlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button BackBtn;
        public PictureBox chooseLevelTitlePictureBox;
        public Button Lvl1Btn;
        public Button Lvl2Btn;
        public Button Lvl3Btn;
        public PictureBox pictureBox2;
        public Button RandomMapBtn;
    }
}