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
    internal class Necromancer : Hero
    {
        private const int _startingHealth = 130;
        private const int _startingStrength = 2;
        private const int _startingDexterity = 2;
        private const int _startingIntelligence = 3;

        private const int _strengthGain = 2;
        private const int _dexterityGain = 1;
        private const int _intelligenceGain = 3;

        public Necromancer(string name)
        {
            ClassName = "Necromancer";
            Experience.Level = 1;
            Health = _startingHealth;
            Attributes = new Attributes(_startingStrength, _startingDexterity, _startingIntelligence);
            AttributesGain = new Attributes(_strengthGain, _dexterityGain, _intelligenceGain);

            AllowedArmorTypes = new ArmorType[] {
                ArmorType.CLOTH_ARMOR,
                ArmorType.LEATHER_ARMOR,
                ArmorType.MAIL_ARMOR };
            AllowedWeaponTypes = new WeaponType[] {
                WeaponType.WAND_WEAPON,
                WeaponType.STAFF_WEAPON,
                WeaponType.HAMMER_WEAPON };
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
