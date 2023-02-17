namespace ConsoleHeroes.Game.Abstracts
{
    internal class Foe : CharacterBase
    {

        private int _experienceWorth;

        public Foe(string name) : base(name)
        {
        }

        public override double Attack()
        {
            throw new NotImplementedException();
        }

        public override void DeathQuote()
        {
            throw new NotImplementedException();
        }

        public override double Defend(double incomingDamage)
        {
            throw new NotImplementedException();
        }

        public override void Die(string reason)
        {
            throw new NotImplementedException();
        }
    }
}
