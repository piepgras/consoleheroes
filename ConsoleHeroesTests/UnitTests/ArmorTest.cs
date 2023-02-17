using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;


namespace ConsoleHeroesTests.UnitTests
{
    public class ArmorTest
    {
        #region Creation
        /// <summary>
        /// Creates an armor, then checks if fields are correct.
        /// </summary>
        [Fact]
        public void Constructor_ItemIsGeneratedCorrectly_GeneratedItem()
        {
            // Arrange
            string name = "Super Cool Sunglasses";
            int requiredLevel = 666;
            int armor = 0;
            Attributes attributes = new(1, 0, 0);
            ArmorType armorType = ArmorType.PLATE_ARMOR;
            SlotType slotType = SlotType.HEAD_SLOT;

            // Act
            ItemArmor actual = new ItemArmor(name, requiredLevel, armor, attributes, armorType, slotType);

            // Assert
            Assert.Equal(name, actual.Name);
            Assert.Equal(requiredLevel, actual.RequiredLevel);
            Assert.Equal(armor, actual.Armor);
            Assert.True(attributes.Equals(actual.Attributes));
            Assert.Equal(armorType, actual.ArmorType);
            Assert.Equal(slotType, actual.SlotType);
        }

        #endregion

        /// <summary>
        /// Creates Item and checks equivalence to what was found in database.
        /// </summary>
        [Fact]
        public void ItemArmorConstructor_IsSameAsDatabase_CorrectArmor()
        {
            // Arrange
            Item expected = new ItemArmor("Rubber Suit", 1, 21, new Attributes(0, 0, 0), ArmorType.PLATE_ARMOR, SlotType.CHEST_SLOT);

            // Act
            Item actual = ItemDatabase.findItem("Rubber Suit");

            // Assert
            Assert.True(expected.Equals(actual));
        }
    }
}
