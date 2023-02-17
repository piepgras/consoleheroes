using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Characters.Player.Classes;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;

namespace ConsoleHeroesTests
{
    public class HeroTests
    {
        #region Creation
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void HeroAttributes_BaseHero_BaseAttributes()
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
        [Fact]
        public void Hero_EquipOneItem_ItemEquipped()
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

        public void Hero_EquipTwoItems_ItemsEquipped()
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


        #endregion





    }
}
