using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MySql.Data.MySqlClient;

namespace programmerenVanGamesInCS
{
    public class LingoGame
    {
        public LingoGame()
        {
            Timer = 90;
            Hints = 1;
            WordNumber = 1;

            NLWords = SQL2List("nl");
            ENWords = SQL2List("en");

            AlreadyGuessedChars = new Dictionary<int, bool>();
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
        public List<string> NLWords { get; }
        public List<string> ENWords { get; }
        public Dictionary <int, bool> AlreadyGuessedChars { get; set; }




        public string NewWord(string Language)
        {
            string Word = "";

            if (Language == "nl")
            {
                Random rnd = new Random();
                int Index = rnd.Next(0, NLWords.Count);
                Word = NLWords.ElementAt(Index);
            }
            else if (Language == "en")
            {
                Random rnd = new Random();
                int Index = rnd.Next(0, ENWords.Count);
                Word = ENWords.ElementAt(Index);
            }
            

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
                        AlreadyGuessedChars[i] = true;
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

                foreach (var IpLD in IpL)
                {
                    if (IpLD.Value == "SemiCorrect")
                    {
                        string LetterStr = GetCharFromStringWithIndex(IpLD.Key, 11).ToString();
                        int LetterInt = Int32.Parse(LetterStr);

                        foreach (var CorrectData in AlreadyGuessedChars)
                        {
                            
                        }
                    }
                }



                AcceptingInput = true;
                return IpL;
            }
            return null;
        }








        private char GetCharFromStringWithIndex(string TargetStr, int TargetIndex)
        {
            int SubstringStarter = TargetIndex - 1;
            int SubstringEnder = 1;

            string StrResult = TargetStr.Substring(SubstringStarter, SubstringEnder);
            char CharResult = StrResult.ToCharArray()[0];

            return CharResult;
        }

        private List<string> SQL2List(string Language)
        {
            List<string> Words = new List<string>();

            string query = "SELECT * FROM words WHERE language = '" + Language + "'";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Words.Add(reader.GetString(1));
                        }
                    }
                    reader.Close();

                }
            }

            return Words;
        }
    }
}
