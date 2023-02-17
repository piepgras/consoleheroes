﻿namespace ConsoleHeroes.Game.Abstracts
{
    internal class Foe : CharacterBase
    {

        private int _experienceWorth;

        public Foe(string name) : base(name)
        {
        }

        public override void DeathQuote()
        {
            throw new NotImplementedException();
        }


        public override void Die(string reason)
        {
            throw new NotImplementedException();
        }
    }
}
