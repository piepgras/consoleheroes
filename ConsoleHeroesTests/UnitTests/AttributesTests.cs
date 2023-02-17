using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Characters;
using ConsoleHeroes.Game.Characters.Classes;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroesTests.UnitTests
{
    public class AttributesTests
    {
        /// <summary>
        /// Checks if a hero is created with right starting attributes.
        /// </summary>
        [Fact]
        public void Attributes_CreateWithStartingAttributes_CorrectAttributes()
        {
           // Arrange
           Attributes expected = new Attributes(2,2,3);
           Necromancer necromancer = new Necromancer("Sean");

            // Act
            Attributes actual = necromancer.Attributes;

            // Assert
            Assert.True(expected.Equals(actual));
        }

        /// <summary>
        /// Attributes should match after level up.
        /// </summary>
        [Fact]
        public void Attributes_BaseAttributeLevelUpMatch_HeroCorrectAttributes()
        {
            // Arrange
            int experience = 100;
            Attributes expectedBase = new Attributes(2, 2, 3);
            Attributes expectedGain = new Attributes(2, 1, 3);
            Attributes expected = expectedBase + expectedGain;
            Necromancer necromancer = new Necromancer("Sean");

            // Act
            if (necromancer.Experience.gainExperience(experience)) necromancer.LevelUpAttributes();
            Attributes actual = necromancer.getTotalAttributes();

            // Assert
            Assert.True(expected.Equals(actual));
        }

        /// <summary>
        /// Attribute match with one item equipped.
        /// </summary>
        [Fact]
        public void Attributes_OneItem_BaseAttributeAndItemAttributesMatch()
        {
            // Arrange
            Attributes expected = new Attributes(2, 3, 10);
            Item item = ItemDatabase.findItem("Magic Stick");
            Necromancer necromancer = new Necromancer("Sean");

            // Act
            necromancer.IsItemAllowed(item);
            Attributes actual = necromancer.getTotalAttributes();

            // Assert
            Assert.True(expected.Equals(actual));
        }

        /// <summary>
        /// Attribute match with two items equipped.
        /// </summary>
        [Fact]
        public void Attributes_TwoItems_BaseAttributeAndItemAttributesMatch()
        {
            // Arrange
            Attributes expected = new Attributes(6, 4, 2);
            Item itemOne = ItemDatabase.findItem("Sissy Scissors");
            Item itemTwo = ItemDatabase.findItem("Cowboy Hat");
            Barber barber = new Barber("Sean");

            // Act
            barber.IsItemAllowed(itemOne);
            barber.IsItemAllowed(itemTwo);
            Attributes actual = barber.getTotalAttributes();

            // Assert
            Assert.True(expected.Equals(actual));
        }

        /// <summary>
        /// Attribute match with two items equipped and then one removed.
        /// </summary>
        [Fact]
        public void Attributes_TwoItemsAndRemoveOne_BaseAttributeAndItemAttributesMatch()
        {
            // Arrange
            Attributes expected = new Attributes(8, 2, 4);
            Item itemOne = ItemDatabase.findItem("Stone Hammer");
            Item itemTwo = ItemDatabase.findItem("Cowboy Hat");
            Paladin paladin = new Paladin("Sean");

            // Act
            paladin.IsItemAllowed(itemOne);
            paladin.IsItemAllowed(itemTwo);
            paladin.Inventory.EquippedItems[SlotType.HEAD_SLOT] = null;
            Attributes actual = paladin.getTotalAttributes();

            // Assert
            Assert.True(expected.Equals(actual));
        }
    }
}
