using Jocul_21.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Jocul_21
{
    public partial class Jocul21 : Form
    {

        int sumaBot = 0, sumaJucator = 0, count = 1, i = 1, j = 1;
        int[] v = { 0 };
        int[] pachetBot;
        public static System.Timers.Timer timer;

        public Jocul21()
        {
            InitializeComponent();
        }

        private void Jocul21_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void Jocul21_Load(object sender, EventArgs e)
        {
            v = new int[53];
            pachetBot = new int[50];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sumaJucator > 21)
            {
                textLose.Visible = true;
                btnRestart.Visible = true;
                btnHit.Enabled = false;
                btnStand.Enabled = false;
                j = 1;

                foreach (PictureBox pictureBox in cartiBot.Controls.OfType<PictureBox>())
                {
                    pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Carti", pachetBot[j] + ".png"));
                    j++;
                }
                suma2.Text = "Suma: " + sumaBot;
                timer1.Stop();
            }
        }

        public void GenerareImagineRandomBot()
        {
            Random random = new Random();
            int numar = random.Next(1, 53);

            while (v[numar] != 0)
            {
                numar = random.Next(1, 53);
            }

            v[numar]++;
            pachetBot[i] = numar;
            i++;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 120;
            pictureBox.Height = 170;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox.Image = Image.FromFile(@"Resources/back.png");
            if (count == 1)
            {
                pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Carti", numar + ".png"));
            }

            cartiBot.Controls.Add(pictureBox);

            if (numar % 13 == 11 || numar % 13 == 12 || numar % 13 == 0)
                numar = 10;
            if (numar % 13 == 1)
                numar = 11;
            sumaBot += numar % 13;

            if (count == 1)
            {
                suma2.Text = "Suma: " + sumaBot + " + ??";
            }
            count++;
            safeWait(300);
        }

        public void GenerareImagineRandomJucator()
        {
            Random random = new Random();
            int numar = random.Next(1, 53);
            while (v[numar] != 0)
            {
                numar = random.Next(1, 53);
            }

            v[numar]++;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 120;
            pictureBox.Height = 170;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Carti", numar + ".png"));

            cartiJucator.Controls.Add(pictureBox);

            if (numar % 13 == 11 || numar % 13 == 12 || numar % 13 == 0)
                numar = 10;
            if (numar % 13 == 1)
                numar = 11;
            sumaJucator += numar % 13;

            suma1.Text = "Suma: " + sumaJucator;
            safeWait(300);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            GenerareImagineRandomJucator();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            textLose.Visible = false;
            btnRestart.Visible = false;
            Jocul21 j = new Jocul21();
            j.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            j = 1;

            while (sumaBot < 17)
            {
                GenerareImagineRandomBot();
            }

            foreach (PictureBox pictureBox in cartiBot.Controls.OfType<PictureBox>())
            {
                pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Carti", pachetBot[j] + ".png"));
                j++;
            }

            if (sumaBot > 21)
            {
                textWin.Visible = true;
                btnRestart.Visible = true;
            }
            else if (sumaBot < sumaJucator)
            {
                textWin.Visible = true;
                btnRestart.Visible = true;
            }
            else if (sumaBot > sumaJucator)
            {
                textLose.Visible = true;
                btnRestart.Visible = true;
            }
            else
            {
                textDraw.Visible = true;
                btnRestart.Visible = true;
            }
            suma2.Text = "Suma: " + sumaBot;
        }

        private async void btnStartJoc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nume.Text) && nume.Text.Length <= 10)
            {
                intrebare.Visible = false;
                btnStartJoc.Visible = false;
                nume.Visible = false;
                numeBot.Visible = true;
                numeJucator.Visible = true;
                numeJucator.Text = nume.Text;
                suma1.Visible = true;
                suma2.Visible = true;
                cartiBot.Visible = true;
                cartiJucator.Visible = true;
                btnHit.Visible = true;
                btnStand.Visible = true;
                intrebareNume.Visible = false;
                intrebareNume2.Visible = false;

                GenerareImagineRandomBot();
                GenerareImagineRandomJucator();
                GenerareImagineRandomBot();
                GenerareImagineRandomJucator();
                timer1.Start();

                if (sumaBot > 21)
                {
                    textWin.Visible = true;
                    btnRestart.Visible = true;
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    j = 1;

                    foreach (PictureBox pictureBox in cartiBot.Controls.OfType<PictureBox>())
                    {
                        pictureBox.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Carti", pachetBot[j] + ".png"));
                        j++;
                    }
                    suma2.Text = "Suma: " + sumaBot;
                }
            }
            else if (nume.Text.Length > 10)
            {
                intrebareNume.Visible = true;
                intrebareNume2.Visible = false;
            }
            else
            {
                intrebareNume2.Visible = true;
                intrebareNume.Visible = false;
            }
        }
        public void safeWait(int milliseconds)
        {
            long tickStop = Environment.TickCount + milliseconds;
            while (Environment.TickCount < tickStop)
            {
                Application.DoEvents();
            }
        }

        private void btnStartJoc_MouseHover(object sender, EventArgs e)
        {
            btnStartJoc.Width = 150;
            btnStartJoc.Height = 90;
        }

        private void btnStartJoc_MouseLeave(object sender, EventArgs e)
        {
            btnStartJoc.Width = 131;
            btnStartJoc.Height = 63;
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            back.Font = new Font(back.Font.FontFamily, 23);
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.Font = new Font(back.Font.FontFamily, 18);
        }
    }
}
