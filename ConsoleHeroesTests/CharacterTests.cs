using ConsoleHeroes.Game.Characters.Player.Classes;

namespace ConsoleHeroesTests.Managers.Characters.Tests
{
    public class CharTests
    {

        #region HeroCreation
        [Fact]
        public void Assassin_CreateWithName_ReturnsName()
        {
            Assassin assassin = new Assassin("Assassin");

            var result = assassin.Name;

            Assert.Equal("Assassin", result);
        }

        [Fact]
        public void CreateAssassin_WithStartingStrength()
        {
            Assassin assassin = new Assassin("Assassin");

            const int startingStrength = 1;
            

            Assert.Equal(assassin.Attributes.Strength, startingStrength);
        }
        #endregion
    }
}