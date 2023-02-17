using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Characters.Classes;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Exceptions;
using ConsoleHeroes.Game.Modifiers;
using Xunit;

namespace ConsoleHeroesTests
{
    public class HeroTests
    {
        #region Creation
        /// <summary>
        /// Checks if a Amazon Hero is created with the correct fields.
        /// </summary>
        /// <returns>Hero with correct fields</returns>
        [Fact]
        public void Hero_CheckIfGeneratedCorrectly_CorrectFields()
        {
            // Arrange
            string expectedName = "Sean";
            int expectedLevel = 1;
            int expectedHealth = 80;
            Attributes expectedAttributes = new Attributes(1, 7, 1);
            Attributes expectedAttributesGain = new Attributes(1, 5, 1);

            // Act
            Amazon actual = new Amazon("Sean");

            // Assert
            Assert.Equal(expectedName, actual.Name);
            Assert.Equal(expectedLevel, actual.Experience.Level);
            Assert.Equal(expectedHealth, actual.Health);
            Assert.True(expectedAttributes.Equals(actual.Attributes));
            Assert.True(expectedAttributesGain.Equals(actual.AttributesGain));
        }
        #endregion

        #region Attributes
        /// <summary>
        /// 
        /// </summary>
        /// <returns> </returns>
        [Fact]
        public void Hero_LevelUpAttributes_CorrectAttributes()
        {
            // Arrange
            Amazon amazon = new Amazon("Sean");
            int expected = 2;

            // Act
            amazon.Experience.gainExperience(100);

            Assert.Equal(expected, amazon.Experience.Level);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> </returns>
        [Fact]
        public void Hero_BaseHeroWithBaseAttributes_BaseAttributes()
        {
            // Arrange
            Sorceror sorceror = new Sorceror("Sean");
            Attributes expected = sorceror.Attributes;

            // Act
            Attributes actual = sorceror.getTotalAttributes();

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Equipping
        /// <summary>
        /// Tries to equip 1 item to hero.
        /// </summary>
        /// <returns>Hero with 1 item equipped</returns>
        [Fact]
        public void Hero_EquipOneItem_TotalAttributesWithItems()
        {
            // Arrange
            Sorceror sorceror = new Sorceror("Sean");
            Item item = ItemDatabase.findItem("Cloth Socks");
            Attributes expected = sorceror.Attributes + item.Attributes;
            sorceror.IsItemAllowed(item);

            // Act
            Attributes actual = sorceror.getTotalAttributes();

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tries to equip 2 items to hero.
        /// </summary>
        /// <returns>Hero with 2 items equipped</returns>
        [Fact]
        public void Hero_EquipTwoItems_TotalAttributesWithItems()
        {
            // Arrange
            Sorceror sorceror = new Sorceror("Sean");
            Item itemOne = ItemDatabase.findItem("Cloth Socks");
            Item itemTwo = ItemDatabase.findItem("Novice Robe");
            Attributes expected = sorceror.Attributes +
                                  itemOne.Attributes +
                                  itemTwo.Attributes;
            sorceror.IsItemAllowed(itemOne);
            sorceror.IsItemAllowed(itemTwo);

            // Act
            Attributes actual = sorceror.getTotalAttributes();

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Tries to equip 3 items to hero.
        /// </summary>
        /// <returns>Hero with 3 items equipped</returns>
        [Fact]
        public void Hero_EquipThreeItems_TotalAttributesWithItems()
        {
            // Arrange
            Sorceror sorceror = new Sorceror("Sean");
            Item itemOne = ItemDatabase.findItem("Cloth Socks");
            Item itemTwo = ItemDatabase.findItem("Novice Robe");
            Item itemThree = ItemDatabase.findItem("Magic Stick");
            Attributes expected = sorceror.Attributes +
                                  itemOne.Attributes +
                                  itemTwo.Attributes +
                                  itemThree.Attributes;

            sorceror.IsItemAllowed(itemOne);
            sorceror.IsItemAllowed(itemTwo);
            sorceror.IsItemAllowed(itemThree);

            // Act
            Attributes actual = sorceror.getTotalAttributes();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_EquipInvalidArmor_InvalidArmorException()
        {
            // Arrange
            Sorceror sorceror = new Sorceror("Sean");
            ItemArmor item = (ItemArmor)ItemDatabase.findItem("Store Patter");

            // Act & Assert
            Exception thrownException = sorceror.IsItemAllowed(item);
            Assert.Equal("You can't equip this armor!", thrownException.Message);
        }

        [Fact]
        public void Hero_EquipInvalidWeapon_InvalidWeaponException()
        {
            // Arrange
            Sorceror sorceror = new Sorceror("Sean");
            Item item = ItemDatabase.findItem("Excalibur");

            // Act & Assert
            Exception thrownException = sorceror.IsItemAllowed(item);
            Assert.Equal("You can't equip this weapon!", thrownException.Message);
        }
        #endregion
    }
}
