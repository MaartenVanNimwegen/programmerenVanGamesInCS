using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmerenVanGamesInCS
{
    public class LingoGame
    {
        public LingoGame()
        {
            Timer = 90;
        }

        public int Hints { get; set; }
        public string Language { get; set; }
        public int Timer { get; set; }
        public string CurrentWord { get; set; }
        public int CurrentRow { get; set; }
        public string CurrentFirstLetter { get; set; }
        public bool TimerPlaying { get; set; }
        public int Points { get; set; }
        public int Round { get; set; }
        public int WordNumber { get; set; }
        


        public string NewWord()
        {


            return "";
        }
    }
}
