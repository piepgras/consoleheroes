using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;


namespace ConsoleHeroesTests.UnitTests
{
    public class WeaponTest
    {
        #region Creation
        /// <summary>
        /// Creates a weapon, then checks if fields are correct.
        /// </summary>
        [Fact]
        public void Constructor_ItemIsGeneratedCorrectly_GeneratedItem()
        {
            // Arrange
            string name = "Stick";
            int requiredLevel = 1;
            int damage = 1;
            Attributes attributes = new(1, 1, 1);
            WeaponType weaponType = WeaponType.STAFF_WEAPON;

            // Act
            ItemWeapon actual = new ItemWeapon(name, requiredLevel, damage, attributes, weaponType);

            // Assert
            Assert.Equal(name, actual.Name);
            Assert.Equal(requiredLevel, actual.RequiredLevel);
            Assert.Equal(damage, actual.Damage);
            Assert.True(attributes.Equals(actual.Attributes));
            Assert.Equal(weaponType, actual.WeaponType);
            Assert.Equal(SlotType.WEAPON_SLOT, actual.SlotType);
        }
        #endregion

        /// <summary>
        /// Creates Item and checks equivalence to what was found in database.
        /// </summary>
        [Fact]
        public void ItemWeaponConstructor_IsSameAsDatabase_CorrectWeapon()
        {
            // Arrange
            Item expected = new ItemWeapon("Rhok'delar", 50, 142, new Attributes(32, 121, 42), WeaponType.BOW_WEAPON);

            // Act
            Item actual = ItemDatabase.findItem("Rhok'delar");

            // Assert
            Assert.True(expected.Equals(actual));
        }
    }
}
