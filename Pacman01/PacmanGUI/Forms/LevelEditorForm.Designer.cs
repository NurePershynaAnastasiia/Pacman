namespace PacmanGUI
{
    partial class LevelEditorForm
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
            this.GameElementsLabel = new System.Windows.Forms.Label();
            this.PacmanPictureBox = new System.Windows.Forms.PictureBox();
            this.EnemyPictureBox = new System.Windows.Forms.PictureBox();
            this.CoinPictureBox = new System.Windows.Forms.PictureBox();
            this.WallPictureBox = new System.Windows.Forms.PictureBox();
            this.EnergizerPictureBox = new System.Windows.Forms.PictureBox();
            this.FieldSizeLabel = new System.Windows.Forms.Label();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PacmanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergizerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameElementsLabel
            // 
            this.GameElementsLabel.AutoSize = true;
            this.GameElementsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameElementsLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameElementsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameElementsLabel.Location = new System.Drawing.Point(908, 96);
            this.GameElementsLabel.Name = "GameElementsLabel";
            this.GameElementsLabel.Size = new System.Drawing.Size(316, 37);
            this.GameElementsLabel.TabIndex = 0;
            this.GameElementsLabel.Text = "Game Elements";
            // 
            // PacmanPictureBox
            // 
            this.PacmanPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PacmanPictureBox.BackgroundImage = global::PacmanGUI.Resources.pacman0;
            this.PacmanPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PacmanPictureBox.Location = new System.Drawing.Point(920, 147);
            this.PacmanPictureBox.Name = "PacmanPictureBox";
            this.PacmanPictureBox.Size = new System.Drawing.Size(70, 70);
            this.PacmanPictureBox.TabIndex = 1;
            this.PacmanPictureBox.TabStop = false;
            this.PacmanPictureBox.Tag = "pacman";
            this.PacmanPictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // EnemyPictureBox
            // 
            this.EnemyPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnemyPictureBox.BackgroundImage = global::PacmanGUI.Resources.enemy_right;
            this.EnemyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnemyPictureBox.Location = new System.Drawing.Point(1094, 147);
            this.EnemyPictureBox.Name = "EnemyPictureBox";
            this.EnemyPictureBox.Size = new System.Drawing.Size(70, 70);
            this.EnemyPictureBox.TabIndex = 2;
            this.EnemyPictureBox.TabStop = false;
            this.EnemyPictureBox.Tag = "enemy";
            this.EnemyPictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // CoinPictureBox
            // 
            this.CoinPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CoinPictureBox.BackgroundImage = global::PacmanGUI.Resources.coin;
            this.CoinPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoinPictureBox.Location = new System.Drawing.Point(920, 240);
            this.CoinPictureBox.Name = "CoinPictureBox";
            this.CoinPictureBox.Size = new System.Drawing.Size(70, 70);
            this.CoinPictureBox.TabIndex = 3;
            this.CoinPictureBox.TabStop = false;
            this.CoinPictureBox.Tag = "coin";
            this.CoinPictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // WallPictureBox
            // 
            this.WallPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WallPictureBox.BackgroundImage = global::PacmanGUI.Resources.wall;
            this.WallPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WallPictureBox.Location = new System.Drawing.Point(1094, 240);
            this.WallPictureBox.Name = "WallPictureBox";
            this.WallPictureBox.Size = new System.Drawing.Size(70, 70);
            this.WallPictureBox.TabIndex = 4;
            this.WallPictureBox.TabStop = false;
            this.WallPictureBox.Tag = "wall";
            this.WallPictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // EnergizerPictureBox
            // 
            this.EnergizerPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnergizerPictureBox.BackgroundImage = global::PacmanGUI.Resources.energizer;
            this.EnergizerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnergizerPictureBox.Location = new System.Drawing.Point(920, 333);
            this.EnergizerPictureBox.Name = "EnergizerPictureBox";
            this.EnergizerPictureBox.Size = new System.Drawing.Size(70, 70);
            this.EnergizerPictureBox.TabIndex = 5;
            this.EnergizerPictureBox.TabStop = false;
            this.EnergizerPictureBox.Tag = "energizer";
            this.EnergizerPictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // FieldSizeLabel
            // 
            this.FieldSizeLabel.AutoSize = true;
            this.FieldSizeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FieldSizeLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FieldSizeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FieldSizeLabel.Location = new System.Drawing.Point(937, 426);
            this.FieldSizeLabel.Name = "FieldSizeLabel";
            this.FieldSizeLabel.Size = new System.Drawing.Size(247, 37);
            this.FieldSizeLabel.TabIndex = 6;
            this.FieldSizeLabel.Text = "Field Size";
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeightNumericUpDown.Location = new System.Drawing.Point(1081, 485);
            this.HeightNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.HeightNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(120, 34);
            this.HeightNumericUpDown.TabIndex = 7;
            this.HeightNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WidthNumericUpDown.Location = new System.Drawing.Point(1081, 567);
            this.WidthNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.WidthNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(120, 34);
            this.WidthNumericUpDown.TabIndex = 8;
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HeightLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HeightLabel.Location = new System.Drawing.Point(906, 485);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(149, 37);
            this.HeightLabel.TabIndex = 9;
            this.HeightLabel.Text = "Height";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WidthLabel.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WidthLabel.Location = new System.Drawing.Point(918, 567);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(127, 37);
            this.WidthLabel.TabIndex = 10;
            this.WidthLabel.Text = "Width";
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
            this.BackBtn.Location = new System.Drawing.Point(84, 709);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(233, 60);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateBtn.BackColor = System.Drawing.Color.Tomato;
            this.CreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.CreateBtn.FlatAppearance.BorderSize = 3;
            this.CreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.CreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateBtn.Location = new System.Drawing.Point(983, 623);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(181, 60);
            this.CreateBtn.TabIndex = 13;
            this.CreateBtn.Tag = "";
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayBtn.BackColor = System.Drawing.Color.Teal;
            this.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.PlayBtn.FlatAppearance.BorderSize = 3;
            this.PlayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn.Location = new System.Drawing.Point(968, 709);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(233, 60);
            this.PlayBtn.TabIndex = 14;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemovePictureBox.BackgroundImage = global::PacmanGUI.Resources.Remove;
            this.RemovePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemovePictureBox.Location = new System.Drawing.Point(1094, 333);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(70, 70);
            this.RemovePictureBox.TabIndex = 15;
            this.RemovePictureBox.TabStop = false;
            this.RemovePictureBox.Click += new System.EventHandler(this.RemovePictureBox_Click);
            // 
            // LevelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.bgGameGif;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 831);
            this.Controls.Add(this.RemovePictureBox);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.FieldSizeLabel);
            this.Controls.Add(this.EnergizerPictureBox);
            this.Controls.Add(this.WallPictureBox);
            this.Controls.Add(this.CoinPictureBox);
            this.Controls.Add(this.EnemyPictureBox);
            this.Controls.Add(this.PacmanPictureBox);
            this.Controls.Add(this.GameElementsLabel);
            this.DoubleBuffered = true;
            this.Name = "LevelEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelEditorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LevelEditorForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PacmanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergizerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GameElementsLabel;
        private PictureBox PacmanPictureBox;
        private PictureBox EnemyPictureBox;
        private PictureBox CoinPictureBox;
        private PictureBox WallPictureBox;
        private PictureBox EnergizerPictureBox;
        private Label FieldSizeLabel;
        private NumericUpDown HeightNumericUpDown;
        private NumericUpDown WidthNumericUpDown;
        private Label HeightLabel;
        private Label WidthLabel;
        public Button BackBtn;
        public Button CreateBtn;
        public Button PlayBtn;
        private PictureBox RemovePictureBox;
    }
}