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
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.generalScoreTextBox = new System.Windows.Forms.TextBox();
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
            // scoreTextBox
            // 
            this.scoreTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.scoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreTextBox.Enabled = false;
            this.scoreTextBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.scoreTextBox.Location = new System.Drawing.Point(48, 599);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.ReadOnly = true;
            this.scoreTextBox.Size = new System.Drawing.Size(227, 64);
            this.scoreTextBox.TabIndex = 1;
            this.scoreTextBox.Text = "Score: 0\r\n";
            // 
            // generalScoreTextBox
            // 
            this.generalScoreTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.generalScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generalScoreTextBox.Enabled = false;
            this.generalScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generalScoreTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.generalScoreTextBox.Location = new System.Drawing.Point(48, 680);
            this.generalScoreTextBox.Name = "generalScoreTextBox";
            this.generalScoreTextBox.ReadOnly = true;
            this.generalScoreTextBox.Size = new System.Drawing.Size(404, 64);
            this.generalScoreTextBox.TabIndex = 2;
            this.generalScoreTextBox.Text = "General score: ";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.backgroundGame;
            this.ClientSize = new System.Drawing.Size(1281, 831);
            this.Controls.Add(this.generalScoreTextBox);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.pictureBoxField);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public PictureBox pictureBoxField;
        private System.Windows.Forms.Timer timerGame;
        public TextBox scoreTextBox;
        public TextBox generalScoreTextBox;
    }
}