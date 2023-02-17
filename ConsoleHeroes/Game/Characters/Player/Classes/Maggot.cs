using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroes.Game.Characters.Player.Classes
{
    internal class Maggot : Hero
    {
        private const int _startingHealth = 1;
        private const int _startingStrength = 0;
        private const int _startingDexterity = 0;
        private const int _startingIntelligence = 1;

        private const int _strengthGain = 0;
        private const int _dexterityGain = 0;
        private const int _intelligenceGain = 1;

        public Maggot(string name)
        {
            ClassName = "Maggot";
            Experience.Level = 1;
            Health = _startingHealth;
            Attributes = new Attributes(_startingStrength, _startingDexterity, _startingIntelligence);
            AttributesGain = new Attributes(_strengthGain, _dexterityGain, _intelligenceGain);

            AllowedArmorTypes = new ArmorType[] {
                ArmorType.CLOTH_ARMOR };
            AllowedWeaponTypes = new WeaponType[] { };
        }


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
            throw new NotImplementedException();
        }
    }
}
