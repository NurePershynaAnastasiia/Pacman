namespace PacmanGUI
{
    partial class MenuForm
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
            this.PlayBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShopBtn = new System.Windows.Forms.Button();
            this.InstructionsBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayBtn.AutoSize = true;
            this.PlayBtn.BackColor = System.Drawing.Color.Teal;
            this.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.PlayBtn.FlatAppearance.BorderSize = 3;
            this.PlayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayBtn.Location = new System.Drawing.Point(384, 294);
            this.PlayBtn.MinimumSize = new System.Drawing.Size(100, 50);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(268, 64);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::PacmanGUI.Resources.pacmanName;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(146, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ShopBtn
            // 
            this.ShopBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShopBtn.BackColor = System.Drawing.Color.Teal;
            this.ShopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShopBtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.ShopBtn.FlatAppearance.BorderSize = 3;
            this.ShopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ShopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShopBtn.Location = new System.Drawing.Point(384, 391);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Size = new System.Drawing.Size(268, 62);
            this.ShopBtn.TabIndex = 6;
            this.ShopBtn.Text = "Shop";
            this.ShopBtn.UseVisualStyleBackColor = false;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // InstructionsBtn
            // 
            this.InstructionsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InstructionsBtn.BackColor = System.Drawing.Color.Teal;
            this.InstructionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstructionsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.InstructionsBtn.FlatAppearance.BorderSize = 3;
            this.InstructionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InstructionsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InstructionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructionsBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InstructionsBtn.Location = new System.Drawing.Point(384, 480);
            this.InstructionsBtn.Name = "InstructionsBtn";
            this.InstructionsBtn.Size = new System.Drawing.Size(268, 62);
            this.InstructionsBtn.TabIndex = 7;
            this.InstructionsBtn.Text = "Instructions";
            this.InstructionsBtn.UseVisualStyleBackColor = false;
            this.InstructionsBtn.Click += new System.EventHandler(this.InstructionsBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitBtn.BackColor = System.Drawing.Color.Teal;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.ExitBtn.FlatAppearance.BorderSize = 3;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(384, 569);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(268, 62);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PacmanGUI.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 800);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.InstructionsBtn);
            this.Controls.Add(this.ShopBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayBtn);
            this.DoubleBuffered = true;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button PlayBtn;
        private PictureBox pictureBox1;
        private Button ShopBtn;
        private Button InstructionsBtn;
        private Button ExitBtn;
    }
}