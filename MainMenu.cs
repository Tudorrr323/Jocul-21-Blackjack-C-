using System.Reflection.Metadata;

namespace Jocul_21
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startGame_MouseHover(object sender, EventArgs e)
        {
            startGame.Width = 200;
            startGame.Height = 230;
            startGame.Font = new Font(startGame.Font.FontFamily, 33);
        }

        private void startGame_MouseLeave(object sender, EventArgs e)
        {
            startGame.Width = 170;
            startGame.Height = 200;
            startGame.Font = new Font(startGame.Font.FontFamily, 26);
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            Jocul21 f = new Jocul21();
            f.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnReguli_Click(object sender, EventArgs e)
        {
            Reguli r = new Reguli();
            r.Show();
            this.Hide();
        }

        private void btnReguli_MouseHover(object sender, EventArgs e)
        {
            btnReguli.Width = 200;
            btnReguli.Height = 230;
            btnReguli.Font = new Font(btnReguli.Font.FontFamily, 33);
        }

        private void btnReguli_MouseLeave(object sender, EventArgs e)
        {
            btnReguli.Width = 170;
            btnReguli.Height = 200;
            btnReguli.Font = new Font(btnReguli.Font.FontFamily, 26);
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExitGame_MouseHover(object sender, EventArgs e)
        {
            btnExitGame.Width = 200;
            btnExitGame.Height = 230;
            btnExitGame.Font = new Font(btnExitGame.Font.FontFamily, 32);
        }

        private void btnExitGame_MouseLeave(object sender, EventArgs e)
        {
            btnExitGame.Width = 170;
            btnExitGame.Height = 200;
            btnExitGame.Font = new Font(btnExitGame.Font.FontFamily, 26);
        }
    }
}