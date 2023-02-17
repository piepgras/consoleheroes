using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Modifiers;

namespace ConsoleHeroes.Game.Equipment
{
    internal class ItemWeapon : Item
    {
        private WeaponType _weaponType;
        private int _damage;

        public WeaponType WeaponType { get { return _weaponType; } }

        public ItemWeapon(string name, int requiredLevel, int damage,
                          Attributes attributes, WeaponType weaponType)
                          : base(name, requiredLevel, attributes, SlotType.WEAPON_SLOT)
        {
            _weaponType = weaponType;
            _damage = damage;
        }
    }
}
