using ConsoleHeroes.Game.Characters.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroesTests.UnitTests
{
    public class LevelTests
    {
        /// <summary>
        /// Level 2 after receiving 100 XP.
        /// </summary>
        [Fact]
        public void Experience_Gain100ExperienceAndLevelUp_LevelPlusOne()
        {
            // Arrange
            int experience = 100;
            int expected = 2;
            Druid dudu = new Druid("Sean");

            // Act
            if (dudu.Experience.gainExperience(experience)) dudu.LevelUpAttributes();

            // Assert
            Assert.Equal(expected, dudu.Experience.Level);
        }
    }
}
