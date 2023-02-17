using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Exceptions;
using ConsoleHeroes.Game.Modifiers;
using ConsoleHeroes.Game.Output;

namespace ConsoleHeroes.Game.Abstracts
{
    internal abstract class Hero : CharacterBase
    {
        public Inventory _inventory = new Inventory(5);
        private string _className = null!;

        private ArmorType[] _allowedArmorTypes = null!;
        private WeaponType[] _allowedWeaponTypes = null!;

        public string ClassName { get { return _className; } set { _className = value; } }
        public Inventory Inventory { get { return _inventory; } }

        public Hero(string name) : base(name)
        {

        }

        public ArmorType[] AllowedArmorTypes
        {
            get { return _allowedArmorTypes; }
            set { _allowedArmorTypes = value; }
        }
        public WeaponType[] AllowedWeaponTypes
        {
            get { return _allowedWeaponTypes; }
            set { _allowedWeaponTypes = value; }
        }
        // Necessary
        public void Display()
        {
            Narrator.DisplayHero(this);
        }

        public Attributes getTotalAttributes()
        {
            return
                Attributes +
                CheckEquipmentForNull(_inventory.EquippedItems[SlotType.HEAD_SLOT]) +
                CheckEquipmentForNull(_inventory.EquippedItems[SlotType.CHEST_SLOT]) +
                CheckEquipmentForNull(_inventory.EquippedItems[SlotType.LEGS_SLOT]) +
                CheckEquipmentForNull(_inventory.EquippedItems[SlotType.FEET_SLOT]) +
                CheckEquipmentForNull(_inventory.EquippedItems[SlotType.WEAPON_SLOT]);
        }

        private Attributes CheckEquipmentForNull(Item item)
        {
            if (item != null) return item.Attributes;
            else return new Attributes(0, 0, 0);
        }

        public Exception IsItemAllowed(Item item)
        {
            bool allowed = false;
            if (item is ItemArmor)
            {
                if (item is ItemArmor)
                {
                    ItemArmor armor = (ItemArmor)item;
                    foreach (ArmorType armorType in AllowedArmorTypes)
                    {
                        if (armorType == armor.ArmorType &&
                            armor.RequiredLevel <= Experience.Level) allowed = true;
                    }
                }
            }
            else
            {
                ItemWeapon weapon = (ItemWeapon)item;
                foreach (WeaponType weaponType in AllowedWeaponTypes)
                {
                    if (weaponType == weapon.WeaponType &&
                        weapon.RequiredLevel <= Experience.Level) allowed = true;
                }
            }

            try
            {
                if (!allowed)
                {
                    if (item is ItemArmor)
                    {
                        throw new InvalidArmorException("You can't equip this armor!");
                    }
                    else
                    {
                        throw new InvalidWeaponException("You can't equip this weapon!");
                    }
                }
                else
                {
                    _inventory.Equip(item);
                    return new Exception();
                }
            }
            catch (InvalidArmorException)
            {
                Narrator.EquipNotAllowed(item); 
                return new InvalidArmorException("You can't equip this armor!");
            }
            catch (InvalidWeaponException)
            { 
                Narrator.EquipNotAllowed(item);
                return new InvalidWeaponException("You can't equip this weapon!");
            }
        }

        public void LevelUpAttributes()
        {
            Attributes += AttributesGain;
        }

        // Fun

        public abstract void TakeDamageQuote();
        public abstract void VictoryQuote();
    }
}
