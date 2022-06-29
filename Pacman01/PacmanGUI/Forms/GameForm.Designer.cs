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
            this.pictureBoxField = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.generalScoreLabel = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxField.Location = new System.Drawing.Point(48, 185);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(1197, 396);
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
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreLabel.Location = new System.Drawing.Point(48, 613);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(178, 65);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: ";
            // 
            // generalScoreLabel
            // 
            this.generalScoreLabel.AutoSize = true;
            this.generalScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generalScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.generalScoreLabel.Location = new System.Drawing.Point(48, 689);
            this.generalScoreLabel.Name = "generalScoreLabel";
            this.generalScoreLabel.Size = new System.Drawing.Size(359, 65);
            this.generalScoreLabel.TabIndex = 4;
            this.generalScoreLabel.Text = "General score: ";
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.BackColor = System.Drawing.Color.Transparent;
            this.pauseLabel.Font = new System.Drawing.Font("Lucida Console", 200.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pauseLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseLabel.Location = new System.Drawing.Point(161, 314);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(922, 267);
            this.pauseLabel.TabIndex = 5;
            this.pauseLabel.Text = "Pause";
            this.pauseLabel.Parent = pictureBoxField;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.backgroundGame;
            this.ClientSize = new System.Drawing.Size(1300, 870);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.generalScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pictureBoxField);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Size = new Size(1300, 870);

        }
        #endregion

        public PictureBox pictureBoxField;
        private System.Windows.Forms.Timer timerGame;
        private Label scoreLabel;
        private Label generalScoreLabel;
        public Label pauseLabel;
    }
}