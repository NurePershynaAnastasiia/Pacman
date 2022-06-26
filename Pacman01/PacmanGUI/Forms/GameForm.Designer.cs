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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxField.Location = new System.Drawing.Point(48, 224);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(1197, 478);
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.backgroundGame;
            this.ClientSize = new System.Drawing.Size(1281, 714);
            this.Controls.Add(this.pictureBoxField);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        public PictureBox pictureBoxField;
        private System.Windows.Forms.Timer timerGame;
    }
}