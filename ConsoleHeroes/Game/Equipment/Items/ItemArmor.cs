using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroes.Game.Equipment
{
    internal class ItemArmor : Item
    {
        private ArmorType _armorType;
        private int _armor;

        public ArmorType ArmorType { get { return _armorType; } }
        public int Armor { get { return _armor; } }

        public ItemArmor(string name, int requiredLevel, int armor,
                         Attributes attributes, ArmorType type, SlotType slotType)
                         : base(name, requiredLevel, attributes, slotType)
        {
            _armorType = type;
            _armor = armor;
        }
    }
}
