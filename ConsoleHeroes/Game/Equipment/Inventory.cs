using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Equipment.Exceptions;

using ConsoleHeroes.Game.Output;

namespace ConsoleHeroes.Game.Equipment
{
    /// <summary>
    /// Class responsible for all Inventory functionality.
    /// Holds 5 slots for the items equipped by heros.
    /// Holds 5 additional slots to represent the heros backpack.
    /// Also responsible for adding items to the backpack and equipping
    /// items after they've cleared by the individual hero's allowed item types.
    /// Throws Exception on negative backpack size and if backpack is full.
    /// </summary>
    /// <throws>InventoryException</throws>
    internal class Inventory
    {
        // Equipped Items
        private Dictionary<SlotType, Item> _equippedItems = new Dictionary<SlotType, Item>() {
            { SlotType.HEAD_SLOT, null! },
            { SlotType.CHEST_SLOT, null! },
            { SlotType.LEGS_SLOT, null! },
            { SlotType.FEET_SLOT, null! },
            { SlotType.WEAPON_SLOT, null! }
        };

        // Inventory Slots
        private Dictionary<int, Item> _backpack;
        public Dictionary<int, Item> Backpack { get { return _backpack; } }
        public Dictionary<SlotType, Item> EquippedItems { get { return _equippedItems; } }

        public Inventory(int size)
        {
            InitInventory(size);
        }

        private void InitInventory(int size)
        {
            _backpack = new Dictionary<int, Item>();

            if (0 < size)
            {
                for (int i = 1; i <= size; i++)
                {
                    _backpack.Add(i, null!);
                }
            }
            else
            {
                throw new InventoryException("Can't create inventory with negative size!");
            }
        }

        public bool AddItemToBackpack(Item itemToAdd)
        {
            try
            {
                foreach (KeyValuePair<int, Item> item in _backpack)
                {
                    if (item.Value == null)
                    {
                        _backpack[item.Key] = itemToAdd;
                        return true;
                    }
                }
                throw new InventoryException("Backpack is full!");
            }
            catch (InventoryException)
            {
                Narrator.BackpackIsFull();
                return false;
            }

            return false;
        }

        public void MoveItemToBackpackFromEquipped(Item itemToMove)
        {
            try
            {
                //if (){

                //}
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Equip(Item item)
        {
            try
            {
                if (_equippedItems[item.SlotType] == null)
                {
                    _equippedItems[item.SlotType] = item;
                    return true;
                }
                else
                {
                    throw new InventoryException("Equipment slot occupied!");
                }
            }
            catch (InventoryException)
            {
                Narrator.InventorySlotOccupied();
                return false;
            }
        }
    }
}
