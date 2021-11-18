using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmerenVanGamesInCS
{
    public partial class Lingo : Form
    {
        LingoGame NewLingoGame = new LingoGame();

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
            ClearLetterField();
        }
        private void ClearLetterField()
        {
            for (int y = 1; y < 5; y++)
            {
                for (int x = 1; x < 5; x++)
                {
                    string LetterBoxStr = "Row" + y.ToString() + "Letter" + x.ToString();
                    var foundControl = this.LettersPanel.Controls.Find(LetterBoxStr, false);

                    if(foundControl.Count() == 1)
                    {
                        foundControl[0].Text = ".";
                    }
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
            ClearLetterField();

            string NextWord = Lingo.NewWord();

            string FirstLetter = NextWord.Substring(0, 1);
            Row1Letter1.Text = FirstLetter;

            Lingo.CurrentWord = NextWord;
            Lingo.CurrentRow = 1;
            Lingo.CurrentFirstLetter = FirstLetter;

            Lingo.AcceptingInput = true;
            Lingo.TimerPlaying = true;


            
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

            LingoGame Lingo = NewGame("nl");

            LingoRound(Lingo);
        }
        private void EnglishBtn_Click(object sender, EventArgs e)
        {
            ClearScreen();
            ShowGameScreen();

            LingoGame Lingo = NewGame("en");

            LingoRound(Lingo);
        }

        private LingoGame NewGame(string Language)
        {
            NewLingoGame.Language = Language;

            return NewLingoGame;
        }

        private void WordInputBox_TextChanged(object sender, EventArgs e)
        {
            string Input = WordInputBox.Text.ToLower();
            int StrLen = Input.Length;
            
            if (StrLen == 5)
            {
                Dictionary<string, string> IpL = NewLingoGame.GuessWord(Input);
                int i = 0;

                if (IpL.ContainsKey("RowYLetterX"))
                {
                    foreach (var LetterInfo in IpL)
                    {
                        if (LetterInfo.Key != "RowYLetterX" && LetterInfo.Value != "Placeholder")
                        {
                            i = i + 1;

                            var foundControl = this.LettersPanel.Controls.Find(LetterInfo.Key, false);

                            if (foundControl.Count() == 1)
                            {
                                var LetterBox = foundControl[0];
                                int im1 = i - 1;
                                LetterBox.Text = Input.Substring(im1, 1);

                                if (LetterInfo.Value == "Correct")
                                {
                                    LetterBox.BackColor = Color.FromArgb(207, 47, 47);
                                    NewLingoGame.AlreadyGuessedChars[im1.ToString()] = true;
                                }
                                else if (LetterInfo.Value == "SemiCorrect")
                                {
                                    LetterBox.BackColor = Color.FromArgb(207, 161, 52);
                                }
                                else if (LetterInfo.Value == "Incorrect")
                                {
                                    LetterBox.BackColor = Color.FromArgb(40, 129, 207);
                                }
                            }

                        }
                    }

                    if (Input == NewLingoGame.CurrentWord)
                    {
                        NewLingoGame.TimerPlaying = false;
                        NewLingoGame.AcceptingInput = false;
                    }
                    else
                    {
                        if (NewLingoGame.CurrentRow <= 4)
                        {
                            NewLingoGame.CurrentRow = NewLingoGame.CurrentRow + 1;
                        }
                        else
                        {
                            /* NEXT WORD */
                        }
                    }
                }
            }
        }


        /* TIMER */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NewLingoGame.TimerPlaying == true && NewLingoGame.Timer > 0)
            {
                NewLingoGame.Timer = NewLingoGame.Timer - 1;
                TimeLabel.Text = "Tijd: " + NewLingoGame.Timer.ToString() +"s";
            }
            else if (NewLingoGame.Timer <= 0)
            {
                /* !TIME OUT! */
            }
        }

        private void Row1Letter3_Click(object sender, EventArgs e)
        {

        }
    }
}
