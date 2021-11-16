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
        private void ClearLetterField()
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    string LetterBoxStr = "Row" + y.ToString() + "Letter" + x.ToString();
                    var LetterBox = this.GetType().GetField(LetterBoxStr).GetValue(this);

                    /*LetterBox.Text = ".";*/
                }
            }
        }

        private void ShowGameScreen()
        {
            LettersPanel.Visible = true;
            GamePanel.Visible = true;
        }

        


        private bool LingoWord(LingoGame Lingo)
        {
            string NextWord = Lingo.NewWord();

            string FirstLetter = NextWord.Substring(0, 1);
            Row1Letter1.Text = FirstLetter;

            Lingo.CurrentWord = NextWord;
            Lingo.CurrentRow = 1;
            Lingo.CurrentFirstLetter = FirstLetter;

            Lingo.AcceptingInput = true;
            Lingo.TimerPlaying = true;


            System.Threading.Thread.Sleep(9999999);
            return false;
        }
        private void LingoRound(LingoGame Lingo)
        {
            bool Guessed = LingoWord(Lingo);
        }

        private void DutchBtn_Click(object sender, EventArgs e)
        {
            ClearScreen();
            ShowGameScreen();

            LingoGame Lingo = NewGame("dutch");

            LingoRound(Lingo);
        }

        private LingoGame NewGame(string Language)
        {
            LingoGame NewLingoGame = new LingoGame();
            NewLingoGame.Language = Language;

            return NewLingoGame;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
