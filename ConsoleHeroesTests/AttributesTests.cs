using ConsoleHeroes.Game.Characters;
using ConsoleHeroes.Game.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroesTests
{
    public class AttributesTests
    {

        //[Theory]
        //[InlineData(1, 1, 1)]
        //[InlineData(-1, -1, -1)]
        //[InlineData(10, 10, 10)]
        //[InlineData(10.00, 10.00, 10.00)]
        //public void Attributes_CreateAttributesWithStartingAttributes_AttributeWithStartingStats(int strength, int dexterity, int intelligence)
        //{
        //    Arrange
        //   Attributes expectedAttributes;

        //    Act
        //   expectedAttributes = new(strength, dexterity, intelligence);
        //    int actualStrength = expectedAttributes.Strength;
        //    int actualDexterity = expectedAttributes.Dexterity;
        //    int actualIntelligence = expectedAttributes.Intelligence;

        //    Assert
        //    Assert.Equal(strength, actualStrength);
        //    Assert.Equal(dexterity, actualDexterity);
        //    Assert.Equal(intelligence, actualIntelligence);
        //}

        //[Theory]
        //[InlineData(1, 1, 1, 1, 1, 1)]
        //[InlineData(-1, -1, -1, -1, -1, -1)]
        //[InlineData(10, 10, 10, 10, 10, 10)]
        //[InlineData(10.00, 10.00, 10.00, 10.00, 10.00, 10.00)]
        //public void Attributes_CreateAttributesWithStartingAttributesAndGain_AttributeWithStartingAndGain
        //            (int strength, int dexterity, int intelligence,
        //             int strengthGain, int dexterityGain, int intelligenceGain)
        //{
        //    Arrange
        //   Attributes expectedAttributes;

        //    Act
        //   expectedAttributes = new(strength, dexterity, intelligence,
        //                            strengthGain, dexterityGain, intelligenceGain);
        //    int actualStrength = expectedAttributes.Strength;
        //    int actualDexterity = expectedAttributes.Dexterity;
        //    int actualIntelligence = expectedAttributes.Intelligence;
        //    int actualStrengthGain = expectedAttributes.StrengthGain;
        //    int actualDexterityGain = expectedAttributes.DexterityGain;
        //    int actualIntelligenceGain = expectedAttributes.IntelligenceGain;

        //    Assert
        //    Assert.Equal(strength, actualStrength);
        //    Assert.Equal(dexterity, actualDexterity);
        //    Assert.Equal(intelligence, actualIntelligence);
        //    Assert.Equal(strengthGain, actualStrengthGain);
        //    Assert.Equal(dexterityGain, actualDexterityGain);
        //    Assert.Equal(intelligenceGain, actualIntelligenceGain);
        //}

        //[Fact]
        //public void LevelUpAttributes_LevelUpAttributesWithGain_AttributesPlusGain()
        //{
        //    Arrange
        //   Assassin assassin = new Assassin("Ass");
        //    int expectedStrength = assassin.Attributes.Strength + assassin.Attributes.StrengthGain;
        //    int expectedDexterity = assassin.Attributes.Dexterity + assassin.Attributes.DexterityGain;
        //    int expectedIntelligence = assassin.Attributes.Intelligence + assassin.Attributes.IntelligenceGain;
        //    assassin.Experience.gainExperience(100, assassin.Attributes);

        //    Act
        //    int actualStrength = assassin.Attributes.Strength;
        //    int actualDexterity = assassin.Attributes.Dexterity;
        //    int actualIntelligence = assassin.Attributes.Intelligence;

        //    Assert
        //    Assert.Equal(expectedStrength, actualStrength);
        //    Assert.Equal(expectedDexterity, actualDexterity);
        //    Assert.Equal(expectedIntelligence, actualIntelligence);
        //}
    }
}
