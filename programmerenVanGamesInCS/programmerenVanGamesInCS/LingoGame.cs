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

        


        public string NewWord()
        {
            Random rnd = new Random();
            int Index = rnd.Next(1, Words.Count);
            string Word = Words.ElementAt(Index);

            return Word;
        }





        public void StartGame()
        {
            Thread Timer = new Thread(new ThreadStart(TimerThread));
            Timer.Start();


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
