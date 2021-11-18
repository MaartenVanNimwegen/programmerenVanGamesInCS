using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace programmerenVanGamesInCS
{
    public class LingoGame
    {
        public LingoGame()
        {
            Timer = 90;

            Words = new List<string>();
            Words.Add("kamer");
            AlreadyGuessedChars = new Dictionary<string, bool>();
        }

        public int Hints { get; set; }
        public string Language { get; set; }
        public int Timer { get; set; }
        public string CurrentWord { get; set; }
        public int CurrentRow { get; set; }
        public string CurrentFirstLetter { get; set; }
        public bool TimerPlaying { get; set; }
        public bool AcceptingInput { get; set; }
        public int Points { get; set; }
        public int Round { get; set; }
        public int WordNumber { get; set; }
        public List <string> Words { get; }
        public Dictionary <string, bool> AlreadyGuessedChars { get; set; }




        public string NewWord()
        {
            Random rnd = new Random();
            int Index = rnd.Next(0, Words.Count);
            string Word = Words.ElementAt(Index);

            return Word;
        }

        public Dictionary<string, string> GuessWord(string Word)
        {
            if (AcceptingInput)
            {
                AcceptingInput = false;

                var IpL = new Dictionary<string, string>(){
                    {"RowYLetterX", "Corectness"}
                };

                int i = 0;

                foreach (char C in CurrentWord)
                {
                    i = i + 1;

                    if (GetCharFromStringWithIndex(Word, i) == C)
                    {
                        IpL["Row" + CurrentRow.ToString() + "Letter" + i.ToString()] = "Correct";
                    }
                    else
                    {
                        bool AnywhereElse = false;

                        foreach (char CorrectChar in CurrentWord)
                        {
                            if (GetCharFromStringWithIndex(Word, i) == CorrectChar)
                            {
                                AnywhereElse = true;

                                IpL["Row" + CurrentRow.ToString() + "Letter" + i.ToString()] = "SemiCorrect";

                                break;
                            }
                        }
                        
                        if (AnywhereElse == false)
                        {
                            IpL["Row" + CurrentRow.ToString() + "Letter" + i.ToString()] = "Incorrect";
                        }
                    }
                }

                return IpL;
            }
            return null;
        }




        public void StartGame()
        {
            /*Thread Timer = new Thread(new ThreadStart(TimerThread));
            Timer.Start();*/


        }





        private char GetCharFromStringWithIndex(string TargetStr, int TargetIndex)
        {
            int SubstringStarter = TargetIndex - 1;
            int SubstringEnder = 1;

            string StrResult = TargetStr.Substring(SubstringStarter, SubstringEnder);
            char CharResult = StrResult.ToCharArray()[0];

            return CharResult;
        }
        private void TimerThread()
        {
            while (true)
            {

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
