using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Characters;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Equipment.Exceptions;
using System.Drawing;

namespace ConsoleHeroesTests
{
    public class InventoryTests
    {

        #region Creation
        [Fact]
        public void Constructor_InitBackpackWithSize_BackpackWithSize()
        {
            // Arrange
            int size = 5;
            Inventory inventory = new Inventory(size);
            int expected = size;

            // Act
            int actual = inventory.Backpack.Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InitBackpackWithZeroOrNegativeSize_InvalidBackPackSizeExceptionMessage(int size)
        {
            // Arrange & Act & Assert 
            Exception thrownException = Assert.Throws<InventoryException>(() => new Inventory(size));
            Assert.Equal("Can't create inventory with negative size!", thrownException.Message);
        }
        #endregion

        #region Adding & Moving Items in backpack
        [Fact]
        public void AddItemToBackpack_AddSingleItem_ItemInBackpack()
        {
            // Arrange
            int chanceInPercent = 100;
            int inventorySize = 1;
            int slotIndex = 1;
            Item expected = ItemDatabase.findRandomItemWithChance(chanceInPercent);
            Inventory inventory = new Inventory(inventorySize);

            // Act
            inventory.AddItemToBackpack(expected);
            Item actual = inventory.Backpack[slotIndex];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddItemToBackpack_AddSingleItemToFullBackpack_BackpackFullMessage()
        {
            // Arrange
            int chanceInPercent = 100;
            int inventorySize = 1;
            int slotIndex = 1;
            Item itemOne = ItemDatabase.findRandomItemWithChance(chanceInPercent);
            Item itemTwo = ItemDatabase.findRandomItemWithChance(chanceInPercent);
            Inventory inventory = new Inventory(inventorySize);
            inventory.AddItemToBackpack(itemOne);
            bool expected = false;

            // Act
            bool actual = inventory.AddItemToBackpack(itemTwo);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equip_EquipItem_ItemShouldBeEquipped()
        {
            // Arrange
            int chanceInPercent = 100;
            int inventorySize = 5;
            Inventory inventory = new Inventory(inventorySize);
            Item expected = ItemDatabase.findRandomItemWithChance(chanceInPercent);
            SlotType slotType = expected.SlotType;

            // Act
            inventory.Equip(expected);
            Item actual = inventory.EquippedItems[slotType];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equip_EquipItemToOccupiedSlot_ThrowInventoryException()
        {
            // Arrange
            int chanceInPercent = 100;
            int inventorySize = 5;
            Inventory inventory = new Inventory(inventorySize);
            Item item = ItemDatabase.findRandomItemWithChance(chanceInPercent);
            inventory.Equip(item);
            bool expected = false;

            // Act
            bool actual = inventory.Equip(item); 

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}
