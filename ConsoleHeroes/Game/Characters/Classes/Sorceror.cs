using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroes.Game.Characters.Classes
{
    internal class Sorceror : Hero
    {
        private const int _startingHealth = 100;
        private const int _startingStrength = 2;
        private const int _startingDexterity = 1;
        private const int _startingIntelligence = 6;

        private const int _strengthGain = 1;
        private const int _dexterityGain = 2;
        private const int _intelligenceGain = 5;

        public Sorceror(string name) : base(name)
        {
            ClassName = "Sorceror";
            Experience.Level = 1;
            Health = _startingHealth;
            Attributes = new Attributes(_startingStrength, _startingDexterity, _startingIntelligence);
            AttributesGain = new Attributes(_strengthGain, _dexterityGain, _intelligenceGain);

            AllowedArmorTypes = new ArmorType[] {
                ArmorType.CLOTH_ARMOR };
            AllowedWeaponTypes = new WeaponType[] {
                WeaponType.WAND_WEAPON,
                WeaponType.STAFF_WEAPON };
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
