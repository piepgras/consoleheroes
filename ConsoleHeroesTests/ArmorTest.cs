using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroesTests
{
    public class ArmorTest
    {

        [Fact]
        public void ItemArmorConstructor_CreateItemArmor_CorrectInput()
        {
            // Arrange
            ItemArmor expected = (ItemArmor)ItemDatabase.findItem("Robe of the Void");

            // Act
            ItemArmor actual = new ItemArmor("Robe of the Void", 57, 96, new Attributes(14, 0, 0), ArmorType.CLOTH_ARMOR, SlotType.CHEST_SLOT);

            // Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.RequiredLevel, actual.RequiredLevel);
            Assert.Equal(expected.Armor, actual.Armor);
            //Assert.Equal(expected.Attributes, actual.Attributes);
            Assert.Equal(expected.ArmorType, actual.ArmorType);
            Assert.Equal(expected.SlotType, actual.SlotType);
        }
    }
}
