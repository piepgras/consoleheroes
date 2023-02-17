using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Characters.Classes;
using ConsoleHeroes.Game.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroes.Game.Characters
{
    internal static class HeroCreator
    {
        public static string PickName()
        {
            string _heroName = Narrator.AskName();
            return _heroName = Narrator.NameJudging(_heroName); ;
        }

        public static string PickClass()
        {
            string _heroClass;

            Narrator.CheckExcitement();
            Narrator.IntroduceClasses();

            _heroClass = TextController.readText("I am a: ");

            return _heroClass;
        }

        internal static Hero CreateHero(string heroName, string heroClass)
        {
            string lowerCaseClass = heroClass.ToLower();

            switch (lowerCaseClass)
            {
                case "amazon":
                    return new Amazon(heroName);
                case "assassin":
                    return new Assassin(heroName);
                case "barber":
                    return new Barber(heroName);
                case "druid":
                    return new Druid(heroName);
                case "maggot":
                    return new Maggot(heroName);
                case "necromancer":
                    return new Necromancer(heroName);
                case "paladin":
                    return new Paladin(heroName);
                case "sorceror":
                    return new Sorceror(heroName);
                default:
                    Narrator.DefaultClass();
                    return new Necromancer(heroName);
            }
        }
    }
}
