using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Characters.Classes;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroesTests.UnitTests
{
    public class DamageTests
    {
        /// <summary>
        /// Calculate damage for base Assassin.
        /// </summary>
        [Fact]
        public void Hero_CorrectBaseDamage_ReturnDamage()
        {
            // Arrange
            Assassin ass = new Assassin("Sean");
                                       //Weapon damage ( 1 + (BaseDexterity / 100))
            double expected = Math.Round(1 * (1 + (6.0 / 100.0)), 2);

            // Act
            double actual = ass.Attack();

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Calculate damage for level 2 Assassin with item.
        /// </summary>
        [Fact]
        public void Hero_CorrectBaseDamageLevel2AndItem_ReturnDamage()
        {
            // Arrange
            int experience = 100;
            Assassin ass = new Assassin("Sean");
            Item item = ItemDatabase.findItem("Sissy Scissors");
                                       //Weapon damage ( 1 + (BaseDexterity / 100)
            double expected = Math.Round(2 * (1 + (12.0 / 100.0)), 2);

            // Act
            if (ass.Experience.gainExperience(experience)) ass.LevelUpAttributes();
            ass.IsItemAllowed(item);
            double actual = ass.Attack();

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Calculate damage with weapon replaced.
        /// </summary>
        [Fact]
        public void Hero_DamageAfterReplacedWeapon_ReturnDamage()
        {
            // Arrange
            Assassin assassin = new Assassin("Sean");
            Item itemFirst = ItemDatabase.findItem("Sissy Scissors");
            Item itemSecond = ItemDatabase.findItem("Tiny Needle");
                                       //Weapon damage ( 1 + (BaseDexterity / 100)
            double expected = Math.Round(3 * (1 + (10.0 / 100.0)), 2);

            // Act
            assassin.IsItemAllowed(itemFirst);
            assassin.Inventory.EquippedItems[SlotType.WEAPON_SLOT] = null!;
            assassin.IsItemAllowed(itemSecond);
            double actual = assassin.Attack();

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Calculate damage with all 5 slots filled.
        /// </summary>
        [Fact]
        public void Hero_DamageWithFullEquipment_ReturnDamage()
        {
            // Arrange
            Druid druid = new Druid("Sean");
            Item head = ItemDatabase.findItem("Hood");
            Item chest = ItemDatabase.findItem("Jacket");
            Item legs = ItemDatabase.findItem("Leather Jeans");
            Item feet = ItemDatabase.findItem("Casual Shoes");
            Item weapon = ItemDatabase.findItem("Walking Stick");
            double expected = Math.Round(5 * (1 + (16.0 / 100.0)), 2);

            // Act
            druid.IsItemAllowed(head);
            druid.IsItemAllowed(chest);
            druid.IsItemAllowed(legs);
            druid.IsItemAllowed(feet);
            druid.IsItemAllowed(weapon);
            double actual = druid.Attack();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
