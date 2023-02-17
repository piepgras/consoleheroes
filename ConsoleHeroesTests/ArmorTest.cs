using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;


namespace ConsoleHeroesTests
{
    public class ArmorTest
    {

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
