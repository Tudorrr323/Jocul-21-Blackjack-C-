namespace Jocul_21
{
    partial class Jocul21
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
            components = new System.ComponentModel.Container();
            numeBot = new Label();
            numeJucator = new Label();
            suma1 = new Label();
            suma2 = new Label();
            cartiJucator = new FlowLayoutPanel();
            cartiBot = new FlowLayoutPanel();
            textLose = new Label();
            btnHit = new Button();
            btnStand = new Button();
            btnRestart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            intrebare = new Label();
            nume = new TextBox();
            back = new Label();
            textWin = new Label();
            textDraw = new Label();
            btnStartJoc = new Button();
            intrebareNume = new Label();
            intrebareNume2 = new Label();
            SuspendLayout();
            // 
            // numeBot
            // 
            numeBot.AutoSize = true;
            numeBot.BackColor = Color.Transparent;
            numeBot.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numeBot.Location = new Point(209, 273);
            numeBot.Name = "numeBot";
            numeBot.Size = new Size(101, 29);
            numeBot.TabIndex = 4;
            numeBot.Text = "Andrei";
            numeBot.Visible = false;
            // 
            // numeJucator
            // 
            numeJucator.AutoSize = true;
            numeJucator.BackColor = Color.Transparent;
            numeJucator.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numeJucator.Location = new Point(209, 452);
            numeJucator.Name = "numeJucator";
            numeJucator.Size = new Size(117, 29);
            numeJucator.TabIndex = 5;
            numeJucator.Text = "Jucator";
            numeJucator.Visible = false;
            // 
            // suma1
            // 
            suma1.AutoSize = true;
            suma1.BackColor = Color.Transparent;
            suma1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            suma1.Location = new Point(209, 489);
            suma1.Name = "suma1";
            suma1.Size = new Size(72, 22);
            suma1.TabIndex = 6;
            suma1.Text = "Suma: ";
            suma1.Visible = false;
            // 
            // suma2
            // 
            suma2.AutoSize = true;
            suma2.BackColor = Color.Transparent;
            suma2.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            suma2.Location = new Point(209, 311);
            suma2.Name = "suma2";
            suma2.Size = new Size(72, 22);
            suma2.TabIndex = 7;
            suma2.Text = "Suma: ";
            suma2.Visible = false;
            // 
            // cartiJucator
            // 
            cartiJucator.BackColor = Color.Transparent;
            cartiJucator.Location = new Point(375, 388);
            cartiJucator.Name = "cartiJucator";
            cartiJucator.Size = new Size(724, 170);
            cartiJucator.TabIndex = 8;
            cartiJucator.Visible = false;
            // 
            // cartiBot
            // 
            cartiBot.BackColor = Color.Transparent;
            cartiBot.Location = new Point(375, 200);
            cartiBot.Name = "cartiBot";
            cartiBot.Size = new Size(724, 170);
            cartiBot.TabIndex = 9;
            cartiBot.Visible = false;
            // 
            // textLose
            // 
            textLose.AutoSize = true;
            textLose.BackColor = Color.Transparent;
            textLose.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textLose.ForeColor = Color.Red;
            textLose.Location = new Point(312, 165);
            textLose.Name = "textLose";
            textLose.Size = new Size(557, 32);
            textLose.TabIndex = 10;
            textLose.Text = "Ai pierdut! Ai suma peste 21. Mai joci?";
            textLose.Visible = false;
            // 
            // btnHit
            // 
            btnHit.BackColor = Color.Transparent;
            btnHit.BackgroundImage = Properties.Resources.Deck_of_Cards1;
            btnHit.BackgroundImageLayout = ImageLayout.Stretch;
            btnHit.FlatAppearance.BorderSize = 0;
            btnHit.FlatStyle = FlatStyle.Flat;
            btnHit.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHit.ForeColor = Color.Black;
            btnHit.Location = new Point(90, 257);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(113, 114);
            btnHit.TabIndex = 11;
            btnHit.Text = "HIT!";
            btnHit.UseVisualStyleBackColor = false;
            btnHit.Visible = false;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.BackColor = Color.Transparent;
            btnStand.BackgroundImage = Properties.Resources.palm;
            btnStand.BackgroundImageLayout = ImageLayout.Stretch;
            btnStand.FlatAppearance.BorderSize = 0;
            btnStand.FlatStyle = FlatStyle.Flat;
            btnStand.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnStand.ForeColor = Color.White;
            btnStand.Location = new Point(90, 403);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(113, 111);
            btnStand.TabIndex = 12;
            btnStand.Text = "STAND";
            btnStand.UseVisualStyleBackColor = false;
            btnStand.Visible = false;
            btnStand.Click += btnStand_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Green;
            btnRestart.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestart.ForeColor = Color.Black;
            btnRestart.Location = new Point(422, 644);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(278, 63);
            btnRestart.TabIndex = 13;
            btnRestart.Text = "Joaca din nou!";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Visible = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // intrebare
            // 
            intrebare.AutoSize = true;
            intrebare.BackColor = Color.Transparent;
            intrebare.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            intrebare.Location = new Point(378, 359);
            intrebare.Name = "intrebare";
            intrebare.Size = new Size(281, 38);
            intrebare.TabIndex = 14;
            intrebare.Text = "Cum te cheama?";
            // 
            // nume
            // 
            nume.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nume.ForeColor = Color.Black;
            nume.Location = new Point(652, 359);
            nume.Name = "nume";
            nume.Size = new Size(156, 36);
            nume.TabIndex = 15;
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
            back.TabIndex = 16;
            back.Text = "<-- Catre Meniu";
            back.Click += back_Click;
            back.MouseLeave += back_MouseLeave;
            back.MouseHover += back_MouseHover;
            // 
            // textWin
            // 
            textWin.AutoSize = true;
            textWin.BackColor = Color.Transparent;
            textWin.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textWin.ForeColor = Color.FromArgb(0, 192, 0);
            textWin.Location = new Point(327, 165);
            textWin.Name = "textWin";
            textWin.Size = new Size(481, 32);
            textWin.TabIndex = 17;
            textWin.Text = "Felicitari! Ai castigat! Mai joci?";
            textWin.Visible = false;
            // 
            // textDraw
            // 
            textDraw.AutoSize = true;
            textDraw.BackColor = Color.Transparent;
            textDraw.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textDraw.ForeColor = Color.Yellow;
            textDraw.Location = new Point(327, 165);
            textDraw.Name = "textDraw";
            textDraw.Size = new Size(543, 32);
            textDraw.TabIndex = 18;
            textDraw.Text = "Egal! A fost un meci dificil! Mai joci?";
            textDraw.Visible = false;
            // 
            // btnStartJoc
            // 
            btnStartJoc.BackColor = Color.Green;
            btnStartJoc.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartJoc.ForeColor = Color.Black;
            btnStartJoc.Location = new Point(493, 533);
            btnStartJoc.Name = "btnStartJoc";
            btnStartJoc.Size = new Size(131, 63);
            btnStartJoc.TabIndex = 19;
            btnStartJoc.Text = "Joaca";
            btnStartJoc.UseVisualStyleBackColor = false;
            btnStartJoc.Click += btnStartJoc_Click;
            btnStartJoc.MouseLeave += btnStartJoc_MouseLeave;
            btnStartJoc.MouseHover += btnStartJoc_MouseHover;
            // 
            // intrebareNume
            // 
            intrebareNume.AutoSize = true;
            intrebareNume.BackColor = Color.Transparent;
            intrebareNume.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            intrebareNume.ForeColor = Color.Red;
            intrebareNume.Location = new Point(400, 420);
            intrebareNume.Name = "intrebareNume";
            intrebareNume.Size = new Size(430, 32);
            intrebareNume.TabIndex = 20;
            intrebareNume.Text = "Numele tau este prea lung!";
            intrebareNume.Visible = false;
            // 
            // intrebareNume2
            // 
            intrebareNume2.AutoSize = true;
            intrebareNume2.BackColor = Color.Transparent;
            intrebareNume2.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            intrebareNume2.ForeColor = Color.Red;
            intrebareNume2.Location = new Point(450, 420);
            intrebareNume2.Name = "intrebareNume2";
            intrebareNume2.Size = new Size(285, 32);
            intrebareNume2.TabIndex = 21;
            intrebareNume2.Text = "Scrie numele tau!";
            intrebareNume2.Visible = false;
            // 
            // Jocul21
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 761);
            Controls.Add(intrebareNume2);
            Controls.Add(intrebareNume);
            Controls.Add(btnStand);
            Controls.Add(btnStartJoc);
            Controls.Add(textDraw);
            Controls.Add(textWin);
            Controls.Add(back);
            Controls.Add(nume);
            Controls.Add(intrebare);
            Controls.Add(btnRestart);
            Controls.Add(btnHit);
            Controls.Add(textLose);
            Controls.Add(cartiBot);
            Controls.Add(cartiJucator);
            Controls.Add(suma2);
            Controls.Add(suma1);
            Controls.Add(numeJucator);
            Controls.Add(numeBot);
            DoubleBuffered = true;
            Name = "Jocul21";
            Text = "Jocul 21";
            FormClosing += Jocul21_FormClosing;
            Load += Jocul21_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label numeBot;
        private Label numeJucator;
        private Label suma1;
        private Label suma2;
        private FlowLayoutPanel cartiJucator;
        private FlowLayoutPanel cartiBot;
        private Label textLose;
        private Button btnHit;
        private Button btnStand;
        private Button btnRestart;
        private System.Windows.Forms.Timer timer1;
        private Label intrebare;
        private TextBox nume;
        private Label back;
        private Label textWin;
        private Label textDraw;
        private Button btnStartJoc;
        private Label intrebareNume;
        private Label intrebareNume2;
    }
}