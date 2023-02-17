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
    internal class Amazon : Hero
    {
        private const int _startingHealth = 80;
        private const int _startingStrength = 1;
        private const int _startingDexterity = 7;
        private const int _startingIntelligence = 1;

        private const int _strengthGain = 1;
        private const int _dexterityGain = 5;
        private const int _intelligenceGain = 1;

        public Amazon(string name) : base(name)
        {
            ClassName = "Amazon";
            Experience.Level = 1;
            Health = _startingHealth;
            Attributes = new Attributes(_startingStrength, _startingDexterity, _startingIntelligence);
            AttributesGain = new Attributes(_strengthGain, _dexterityGain, _intelligenceGain);

            AllowedArmorTypes = new ArmorType[] {
                ArmorType.CLOTH_ARMOR,
                ArmorType.LEATHER_ARMOR};
            AllowedWeaponTypes = new WeaponType[] {
                WeaponType.BOW_WEAPON,
                WeaponType.AXE_WEAPON,
                WeaponType.STAFF_WEAPON,
                WeaponType.SWORD_WEAPON };
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
