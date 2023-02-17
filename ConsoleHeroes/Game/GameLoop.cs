using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Characters;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;
using ConsoleHeroes.Game.Output;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ConsoleHeroesTests")]
namespace ConsoleHeroes.Game
{
    /// <summary>
    /// "main" class responsible for App init and handling of all
    /// game directing and input.
    /// </summary>
    internal class GameLoop
    {
        // Game Constants
        private static string _heroName = null!;
        private static string _heroClass = null!;
        public static Hero _hero;
        static TargetDummy targetDummy = new TargetDummy("Target Dummy");
        static Boolean isBattling = false;

        internal class ConsoleHeroes
        {
            static void Main(string[] args)
            {
                GameLoop.GameIntro();
            }
        }
        internal static void GameIntro()
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            //Narrator.Intro();
            GameStart();
        }

        internal static void GameStart()
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            //Narrator.Welcome();
            //_heroName = HeroCreator.PickName();
            //_heroClass = HeroCreator.PickClass();
            //_hero.VictoryQuote();
            _hero = HeroCreator.CreateHero(_heroName, "Assassin");
            _hero.Display();

            GameDecisions();
        }

        internal static void GameDecisions()
        {
            TextController.readText("PRESS ENTER!");
            Console.Clear();
            string decision = Narrator.Decisions();

            switch (decision)
            {
                case "0":
                    PrepareForBattle();
                    GameDecisions();
                    break;
                case "1":
                    Narrator.DisplayHero(_hero);
                    GameDecisions();
                    break;
                case "2":
                    Narrator.DisplayEquipped(_hero);
                    GameDecisions();
                    break;
                case "3":
                    Narrator.DisplayBackpack(_hero);
                    GameDecisions();
                    break;
                case "4":
                    GameDecisions();
                    break;
                case "5":
                    GameRestart("YOU RESTARTED THE GAME!");
                    break;
                case "9":
                    Cheats();
                    break;
                default:

                    Narrator.NoDecision();
                    GameDecisions();
                    break;
            }
        }

        internal static void Cheats()
        {
            string cheat = Narrator.Cheats();

            switch (cheat)
            {
                case "1":
                    if (_hero.Experience.gainExperience(100)) _hero.LevelUpAttributes();
                    GameDecisions();
                    break;
                case "2":
                    //_hero.gainExperience(100);
                    GameDecisions();
                    break;
                case "3":
                    GameDecisions();
                    break;
                default:
                    Narrator.NoDecision();
                    GameDecisions();
                    break;
            }
        }

        internal static void ManageItems()
        {

        }



        internal static void GameRestart(string reason)
        {
            Narrator.RestartReason(reason);
            Thread.Sleep(4000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            GameStart();
        }

        private static void PrepareForBattle()
        {
            //Narrator.StartBattle(_hero, targetDummy);
            isBattling = true;
            Battle(targetDummy);
        }

        private static void Battle(Foe foe)
        {
            while (isBattling)
            {
                foe.Defend(_hero.Attack(foe, 52));
                _hero.Defend(foe.Attack(_hero, 1));

                if (!foe.isAlive)
                {
                    isBattling = false;
                }
            }

            GameDecisions();
        }
    }
}
