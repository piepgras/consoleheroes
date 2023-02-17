using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;
using ConsoleHeroes.Game.Output;

namespace ConsoleHeroes.Game.Characters.Player.Classes
{
    internal class Assassin : Hero
    {
        private const int _startingHealth = 100;
        private const int _startingStrength = 2;
        private const int _startingDexterity = 6;
        private const int _startingIntelligence = 1;

        private const int _strengthGain = 1;
        private const int _dexterityGain = 4;
        private const int _intelligenceGain = 1;

        public Assassin(string name)
        {
            ClassName = "Assassin";
            Experience.Level = 1;
            Health = _startingHealth;
            Attributes = new Attributes(_startingStrength, _startingDexterity, _startingIntelligence);
            AttributesGain = new Attributes(_strengthGain, _dexterityGain, _intelligenceGain);

            AllowedArmorTypes = new ArmorType[] {
                ArmorType.CLOTH_ARMOR,
                ArmorType.LEATHER_ARMOR,
                ArmorType.LATEX_ARMOR };
            AllowedWeaponTypes = new WeaponType[] {
                WeaponType.SCISSORS_WEAPON,
                WeaponType.RAZOR_WEAPON };
        }


        //public override double Defend(double incomingDamage)
        //{
        //    double damageAfterMitigation = incomingDamage * 0.9;
        //    Health -= damageAfterMitigation;
        //    return damageAfterMitigation;
        //}

        public override void DeathQuote()
        {
            throw new NotImplementedException();
        }

        public override void Die(string reason)
        {
            throw new NotImplementedException();
        }

        public override void TakeDamageQuote()
        {
            throw new NotImplementedException();
        }

        public override void VictoryQuote()
        {
            TextController.writeText(30, ConsoleColor.White, ConsoleColor.Black,
                                  "So dark. Perfect.");
        }
    }
}
