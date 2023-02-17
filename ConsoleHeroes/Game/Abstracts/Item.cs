using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroes.Game.Abstracts
{
    internal abstract class Item
    {
        private string _name;

        private Attributes _attributes;
        private int _requiredLevel;
        private SlotType _slotType;

        public string Name { get { return _name; } set { _name = value; } }
        public SlotType SlotType { get { return _slotType; } set { _slotType = value; } }
        public Attributes Attributes { get { return _attributes; } set { _attributes = value; } }
        public int RequiredLevel { get { return _requiredLevel; } set { _requiredLevel = value; } }

        public Item() { }

        public Item(string name, int requiredLevel, Attributes attributes)
        {
            _name = name;
            _requiredLevel = requiredLevel;
            _attributes = attributes;
        }

        public Item(string name, int requiredLevel, Attributes attributes, SlotType slotType)
        {
            _name = name;
            _requiredLevel = requiredLevel;
            _attributes = attributes;
            _slotType = slotType;
        }
    }
}
