namespace Jocul_21
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            startGame = new Button();
            btnReguli = new Button();
            btnExitGame = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(477, 177);
            title.Name = "title";
            title.Size = new Size(235, 57);
            title.TabIndex = 0;
            title.Text = "Jocul 21";
            // 
            // startGame
            // 
            startGame.BackColor = Color.Transparent;
            startGame.BackgroundImage = Properties.Resources.back;
            startGame.BackgroundImageLayout = ImageLayout.Stretch;
            startGame.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            startGame.ForeColor = Color.Black;
            startGame.Location = new Point(505, 292);
            startGame.Name = "startGame";
            startGame.Size = new Size(170, 200);
            startGame.TabIndex = 1;
            startGame.Text = "JOACA";
            startGame.UseVisualStyleBackColor = false;
            startGame.Click += startGame_Click;
            startGame.MouseLeave += startGame_MouseLeave;
            startGame.MouseHover += startGame_MouseHover;
            // 
            // btnReguli
            // 
            btnReguli.BackColor = Color.Transparent;
            btnReguli.BackgroundImage = Properties.Resources.back_black;
            btnReguli.BackgroundImageLayout = ImageLayout.Stretch;
            btnReguli.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReguli.ForeColor = Color.White;
            btnReguli.Location = new Point(195, 292);
            btnReguli.Name = "btnReguli";
            btnReguli.Size = new Size(170, 200);
            btnReguli.TabIndex = 2;
            btnReguli.Text = "REGULI";
            btnReguli.UseVisualStyleBackColor = false;
            btnReguli.Click += btnReguli_Click;
            btnReguli.MouseLeave += btnReguli_MouseLeave;
            btnReguli.MouseHover += btnReguli_MouseHover;
            // 
            // btnExitGame
            // 
            btnExitGame.BackColor = Color.Transparent;
            btnExitGame.BackgroundImage = Properties.Resources.back_red;
            btnExitGame.BackgroundImageLayout = ImageLayout.Stretch;
            btnExitGame.Font = new Font("Stencil", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExitGame.ForeColor = Color.Black;
            btnExitGame.Location = new Point(805, 292);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(170, 200);
            btnExitGame.TabIndex = 3;
            btnExitGame.Text = "IESI DIN JOC";
            btnExitGame.UseVisualStyleBackColor = false;
            btnExitGame.Click += btnExitGame_Click;
            btnExitGame.MouseLeave += btnExitGame_MouseLeave;
            btnExitGame.MouseHover += btnExitGame_MouseHover;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 761);
            Controls.Add(btnExitGame);
            Controls.Add(btnReguli);
            Controls.Add(startGame);
            Controls.Add(title);
            DoubleBuffered = true;
            Name = "MainMenu";
            Text = "Jocul 21 Main Menu";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button startGame;
        private Button btnReguli;
        private Button btnExitGame;
    }
}