namespace Jocul_21
{
    partial class Reguli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reguli));
            label1 = new Label();
            title = new Label();
            back = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 228);
            label1.Name = "label1";
            label1.Size = new Size(989, 340);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(447, 176);
            title.Name = "title";
            title.Size = new Size(293, 38);
            title.TabIndex = 1;
            title.Text = "Jocul 21 - Reguli";
            // 
            // back
            // 
            back.AutoSize = true;
            back.BackColor = Color.Transparent;
            back.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            back.ForeColor = Color.FromArgb(255, 128, 128);
            back.Location = new Point(12, 9);
            back.Name = "back";
            back.Size = new Size(196, 29);
            back.TabIndex = 2;
            back.Text = "<-- Catre Meniu";
            back.Click += back_Click;
            back.MouseLeave += back_MouseLeave;
            back.MouseHover += back_MouseHover;
            // 
            // Reguli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 761);
            Controls.Add(back);
            Controls.Add(title);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Reguli";
            Text = "Reguli";
            FormClosing += Reguli_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label title;
        private Label back;
    }
}