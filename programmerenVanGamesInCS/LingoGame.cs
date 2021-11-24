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
            Hints = 1;
            WordNumber = 1;

            NLWords = new List<string>();
            NLWords.Add("accus");
            NLWords.Add("appel");
            NLWords.Add("aarde");
            NLWords.Add("apart");
            NLWords.Add("airco");
            NLWords.Add("akker");
            NLWords.Add("afzag");
            NLWords.Add("babys");
            NLWords.Add("blijf");
            NLWords.Add("boten");
            NLWords.Add("boren");
            NLWords.Add("broek");
            NLWords.Add("beeld");
            NLWords.Add("blauw");
            NLWords.Add("bloed");
            NLWords.Add("bezig");
            NLWords.Add("chips");
            NLWords.Add("draai");
            NLWords.Add("delen");
            NLWords.Add("dwaas");
            NLWords.Add("droog");
            NLWords.Add("dwaal");
            NLWords.Add("daten");
            NLWords.Add("dozen");
            NLWords.Add("debat");
            NLWords.Add("derde");
            NLWords.Add("drank");
            NLWords.Add("elder");
            NLWords.Add("echte");
            NLWords.Add("enkel");
            NLWords.Add("enorm");
            NLWords.Add("eisen");
            NLWords.Add("fiets");
            NLWords.Add("films");
            NLWords.Add("feest");
            NLWords.Add("falen");
            NLWords.Add("geven");
            NLWords.Add("getal");
            NLWords.Add("groet");
            NLWords.Add("gemak");
            NLWords.Add("goede");
            NLWords.Add("gezin");
            NLWords.Add("horen");
            NLWords.Add("heren");
            NLWords.Add("helft");
            NLWords.Add("hemel");
            NLWords.Add("haast");
            NLWords.Add("hangt");
            NLWords.Add("hobby");
            NLWords.Add("hamer");
            NLWords.Add("ieder");
            NLWords.Add("immer");
            NLWords.Add("icoon");
            NLWords.Add("jaren");
            NLWords.Add("juist");
            NLWords.Add("koken");
            NLWords.Add("kegel");
            NLWords.Add("kubus");
            NLWords.Add("klein");
            NLWords.Add("kreeg");
            NLWords.Add("klant");
            NLWords.Add("komst");
            NLWords.Add("kapot");
            NLWords.Add("kookt");
            NLWords.Add("kroeg");
            NLWords.Add("keren");
            NLWords.Add("koker");
            NLWords.Add("kabel");
            NLWords.Add("koers");
            NLWords.Add("kerst");
            NLWords.Add("kopen");
            NLWords.Add("komen");
            NLWords.Add("lopen");
            NLWords.Add("links");
            NLWords.Add("lucht");
            NLWords.Add("leger");
            NLWords.Add("later");
            NLWords.Add("lonen");
            NLWords.Add("lenen");
            NLWords.Add("laden");
            NLWords.Add("lever");
            NLWords.Add("leren");
            NLWords.Add("lukte");
            NLWords.Add("laars");
            NLWords.Add("losse");
            NLWords.Add("leest");
            NLWords.Add("loont");
            NLWords.Add("leven");
            NLWords.Add("lingo");
            NLWords.Add("leeft");
            NLWords.Add("leert");
            NLWords.Add("lepel");
            NLWords.Add("lezen");
            NLWords.Add("loopt");
            NLWords.Add("koopt");
            NLWords.Add("lager");
            NLWords.Add("leuke");
            NLWords.Add("lieve");
            NLWords.Add("maand");
            NLWords.Add("mooie");
            NLWords.Add("musea");
            NLWords.Add("menig");
            NLWords.Add("motie");
            NLWords.Add("malen");
            NLWords.Add("motor");
            NLWords.Add("molen");
            NLWords.Add("mogen");
            NLWords.Add("muren");
            NLWords.Add("modus");
            NLWords.Add("maken");
            NLWords.Add("maten");
            NLWords.Add("mogen");
            NLWords.Add("markt");
            NLWords.Add("meren");
            NLWords.Add("mertk");
            NLWords.Add("meten");
            NLWords.Add("onder");
            NLWords.Add("onwel");
            NLWords.Add("omdat");
            NLWords.Add("opzet");
            NLWords.Add("ofwel");
            NLWords.Add("optie");
            NLWords.Add("oogst");
            NLWords.Add("ouder");
            NLWords.Add("onzin");
            NLWords.Add("ovaal");
            NLWords.Add("oogje");
            NLWords.Add("omzet");
            NLWords.Add("onder");
            NLWords.Add("oprit");
            NLWords.Add("palen");
            NLWords.Add("piano");
            NLWords.Add("pauze");
            NLWords.Add("praat");
            NLWords.Add("prima");
            NLWords.Add("paren");
            NLWords.Add("pakte");
            NLWords.Add("plein");
            NLWords.Add("poten");
            NLWords.Add("pasen");
            NLWords.Add("plukt");
            NLWords.Add("pegel");
            NLWords.Add("paden");
            NLWords.Add("paard");
            NLWords.Add("paars");
            NLWords.Add("poort");
            NLWords.Add("quota");
            NLWords.Add("robot");
            NLWords.Add("regen");
            NLWords.Add("rugby");
            NLWords.Add("ruist");
            NLWords.Add("radar");
            NLWords.Add("ronde");
            NLWords.Add("recht");
            NLWords.Add("raakt");
            NLWords.Add("radio");
            NLWords.Add("reden");
            NLWords.Add("regel");
            NLWords.Add("recht");
            NLWords.Add("regie");
            NLWords.Add("ritje");
            NLWords.Add("reken");
            NLWords.Add("rente");
            NLWords.Add("roken");
            NLWords.Add("racen");
            NLWords.Add("raken");
            NLWords.Add("raden");
            NLWords.Add("regio");
            NLWords.Add("staan");
            NLWords.Add("stoel");
            NLWords.Add("stoep");
            NLWords.Add("sport");
            NLWords.Add("staat");
            NLWords.Add("straf");
            NLWords.Add("stond");
            NLWords.Add("stuur");
            NLWords.Add("schok");
            NLWords.Add("staal");
            NLWords.Add("steek");
            NLWords.Add("stook");
            NLWords.Add("spalk");
            NLWords.Add("steun");
            NLWords.Add("stapt");
            NLWords.Add("sfeer");
            NLWords.Add("slaap");
            NLWords.Add("speel");
            NLWords.Add("samen");
            NLWords.Add("sjaal");
            NLWords.Add("strak");
            NLWords.Add("snoep");
            NLWords.Add("sloot");
            NLWords.Add("soort");
            NLWords.Add("stoom");
            NLWords.Add("steeg");
            NLWords.Add("schep");
            NLWords.Add("storm");
            NLWords.Add("spoor");
            NLWords.Add("soort");
            NLWords.Add("start");
            NLWords.Add("slaan");
            NLWords.Add("stopt");
            NLWords.Add("truck");
            NLWords.Add("talen");
            NLWords.Add("tafel");
            NLWords.Add("taken");
            NLWords.Add("thuis");
            NLWords.Add("tekst");
            NLWords.Add("trouw");
            NLWords.Add("thema");
            NLWords.Add("tegen");
            NLWords.Add("terug");
            NLWords.Add("tegel");
            NLWords.Add("teken");
            NLWords.Add("tegen");
            NLWords.Add("teken");
            NLWords.Add("trekt");
            NLWords.Add("trein");
            NLWords.Add("trucs");
            NLWords.Add("treft");
            NLWords.Add("typen");
            NLWords.Add("taart");
            NLWords.Add("titel");
            NLWords.Add("tegen");
            NLWords.Add("tonen");
            NLWords.Add("tempo");
            NLWords.Add("tocht");
            NLWords.Add("telde");
            NLWords.Add("velen");
            NLWords.Add("varen");
            NLWords.Add("vaten");
            NLWords.Add("vogel");
            NLWords.Add("volgt");
            NLWords.Add("vaker");
            NLWords.Add("vaart");
            NLWords.Add("vecht");
            NLWords.Add("vindt");
            NLWords.Add("vloot");
            NLWords.Add("verte");
            NLWords.Add("vijfde");
            NLWords.Add("vegen");
            NLWords.Add("vuren");
            NLWords.Add("vroeg");
            NLWords.Add("vorig");
            NLWords.Add("vraag");
            NLWords.Add("vulde");
            NLWords.Add("villa");
            NLWords.Add("virus");
            NLWords.Add("vloog");
            NLWords.Add("vormt");
            NLWords.Add("vloer");
            NLWords.Add("veren");
            NLWords.Add("vrouw");
            NLWords.Add("vezel");
            NLWords.Add("vanaf");
            NLWords.Add("voelt");
            NLWords.Add("vaste");
            NLWords.Add("voert");
            NLWords.Add("vette");
            NLWords.Add("vuile");
            NLWords.Add("video");
            NLWords.Add("vader");
            NLWords.Add("vlees");
            NLWords.Add("vries");
            NLWords.Add("volle");
            NLWords.Add("voedt");
            NLWords.Add("verre");
            NLWords.Add("vrede");
            NLWords.Add("woord");
            NLWords.Add("warme");
            NLWords.Add("wazig");
            NLWords.Add("winst");
            NLWords.Add("werkt");
            NLWords.Add("weken");
            NLWords.Add("woede");
            NLWords.Add("wagen");
            NLWords.Add("weten");
            NLWords.Add("wegen");
            NLWords.Add("weken");
            NLWords.Add("water");
            NLWords.Add("woont");
            NLWords.Add("witte");
            NLWords.Add("wonen");
            NLWords.Add("weven");
            NLWords.Add("wordt");
            NLWords.Add("wacht");
            NLWords.Add("waren");
            NLWords.Add("weren");
            NLWords.Add("waard");
            NLWords.Add("wilde");
            NLWords.Add("welke");
            NLWords.Add("xenon");
            NLWords.Add("yacht");
            NLWords.Add("zwaar");
            NLWords.Add("zeven");
            NLWords.Add("zaken");
            NLWords.Add("zulke");
            NLWords.Add("zowel");
            NLWords.Add("zeker");
            NLWords.Add("zette");
            NLWords.Add("zoals");
            NLWords.Add("zware");
            NLWords.Add("zomer");
            NLWords.Add("zicht");
            NLWords.Add("zeker");
            NLWords.Add("zonde");
            NLWords.Add("zover");
            NLWords.Add("zodra");
            NLWords.Add("zalen");
            NLWords.Add("zowat");
            NLWords.Add("zesde");
            NLWords.Add("zeden");
            NLWords.Add("zadel");
            NLWords.Add("zaten");
            NLWords.Add("zorgt");
            NLWords.Add("zelfs");
            NLWords.Add("zoals");
            NLWords.Add("zocht");
            NLWords.Add("zagen");
            NLWords.Add("zwart");
            NLWords.Add("zoals");
            NLWords.Add("zelfs");
            NLWords.Add("zover");
            NLWords.Add("zwemt");





            ENWords = new List<string>();
            ENWords.Add("rooms");

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

                /*foreach (var IpLD in IpL)
                {
                    if (IpLD.Value == "SemiCorrect")
                    {
                        string LetterStr = GetCharFromStringWithIndex(IpLD.Key, 11).ToString();
                        int LetterInt = Int32.Parse(LetterStr);

                        foreach (var IplD2 in IpL)
                        {
                            if (IplD2.Value != "SemiCorrect")
                            {
                                string LetterStr2 = GetCharFromStringWithIndex(IpLD.Key, 11).ToString();
                                int LetterInt2 = Int32.Parse(LetterStr);


                            }
                        }
                    }
                } */



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
    }
}
