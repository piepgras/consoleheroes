using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Modifiers;

namespace ConsoleHeroes.Game.Equipment
{
    /// <summary>
    /// Inherits from item, is responsible for all the
    /// fields relevant to Weapon Items.
    /// </summary>
    internal class ItemWeapon : Item
    {
        private WeaponType _weaponType;
        private double _damage;

        public double Damage { get { return _damage; } set { _damage = value; } }

        public WeaponType WeaponType { get { return _weaponType; } }

        public ItemWeapon(string name, int requiredLevel, double damage,
                          Attributes attributes, WeaponType weaponType)
                          : base(name, requiredLevel, attributes, SlotType.WEAPON_SLOT)
        {
            _weaponType = weaponType;
            _damage = damage;
        }
    }
}
