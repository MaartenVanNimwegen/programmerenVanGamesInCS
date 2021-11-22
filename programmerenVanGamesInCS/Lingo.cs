using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmerenVanGamesInCS
{
    public partial class Lingo : Form
    {
        public Lingo()
        {
            InitializeComponent();

            LettersPanel.Visible = false;
            GamePanel.Visible = false;
        }

        private void Lingo_Load(object sender, EventArgs e)
        {

        }
        private void ClearScreen()
        {
            WelcomeLabel.Visible = false;
            ChooseLanguageLabel.Visible = false;
            DutchBtn.Visible = false;
            EnglishBtn.Visible = false;
            LettersPanel.Visible = false;
            GamePanel.Visible = false;
        }

        private void ShowGameScreen()
        {
            LettersPanel.Visible = true;
            GamePanel.Visible = true;
        }

        




        private void DutchBtn_Click(object sender, EventArgs e)
        {
            ClearScreen();
            ShowGameScreen();
        }

        private LingoGame NewGame()
        {
            LingoGame myLingoGame = new LingoGame();

            return myLingoGame;
        }

        private void Start()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Row1Letter4_Click(object sender, EventArgs e)
        {

        }

        private void Row1Letter3_Click(object sender, EventArgs e)
        {

        }
    }
}
