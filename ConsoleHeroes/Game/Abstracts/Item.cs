using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Modifiers;

namespace ConsoleHeroes.Game.Abstracts
{
    /// <summary>
    /// Base abstract Item, responsible for
    /// the base of all Armor and Weapons
    /// </summary>
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

        public override bool Equals(object? obj)
        {
            return obj is Item item &&
                   _name == item._name &&
                   EqualityComparer<Attributes>.Default.Equals(_attributes, item._attributes) &&
                   _requiredLevel == item._requiredLevel &&
                   _slotType == item._slotType &&
                   Name == item.Name &&
                   SlotType == item.SlotType &&
                   EqualityComparer<Attributes>.Default.Equals(Attributes, item.Attributes) &&
                   RequiredLevel == item.RequiredLevel;
        }
    }
}
