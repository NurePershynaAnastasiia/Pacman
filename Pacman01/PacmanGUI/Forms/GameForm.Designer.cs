namespace PacmanGUI
{
    partial class GameForm
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pictureBoxField = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.generalScoreLabel = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.PressPauseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxField.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxField.Location = new System.Drawing.Point(64, 143);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(1181, 433);
            this.pictureBoxField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxField.TabIndex = 0;
            this.pictureBoxField.TabStop = false;
            this.pictureBoxField.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxField_Paint);
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 400;
            this.timerGame.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreLabel.Location = new System.Drawing.Point(48, 579);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(178, 65);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: ";
            // 
            // generalScoreLabel
            // 
            this.generalScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.generalScoreLabel.AutoSize = true;
            this.generalScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generalScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.generalScoreLabel.Location = new System.Drawing.Point(48, 658);
            this.generalScoreLabel.Name = "generalScoreLabel";
            this.generalScoreLabel.Size = new System.Drawing.Size(359, 65);
            this.generalScoreLabel.TabIndex = 4;
            this.generalScoreLabel.Text = "General score: ";
            // 
            // pauseLabel
            // 
            this.pauseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.BackColor = System.Drawing.Color.Transparent;
            this.pauseLabel.Font = new System.Drawing.Font("Lucida Console", 200.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pauseLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseLabel.Location = new System.Drawing.Point(140, 277);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(922, 267);
            this.pauseLabel.TabIndex = 5;
            this.pauseLabel.Text = "Pause";
            // 
            // PressPauseLabel
            // 
            this.PressPauseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PressPauseLabel.AutoSize = true;
            this.PressPauseLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PressPauseLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PressPauseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PressPauseLabel.Location = new System.Drawing.Point(695, 593);
            this.PressPauseLabel.Name = "PressPauseLabel";
            this.PressPauseLabel.Size = new System.Drawing.Size(287, 47);
            this.PressPauseLabel.TabIndex = 6;
            this.PressPauseLabel.Text = "Press P to Pause";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.bgGameGif;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 831);
            this.Controls.Add(this.PressPauseLabel);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.generalScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pictureBoxField);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public PictureBox pictureBoxField;
        public System.Windows.Forms.Timer timerGame;
        public Label scoreLabel;
        public Label generalScoreLabel;
        public Label pauseLabel;
        public Label PressPauseLabel;
    }
}