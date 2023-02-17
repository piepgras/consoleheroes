using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Equipment;
using ConsoleHeroes.Game.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHeroes.Game.Output
{
    internal static class Narrator
    {
        private static string _heroName = null!;
        private static string _className = null!;

        public static void Intro()
        {
            Console.Clear();

            TextController.writeText(25, ConsoleColor.DarkMagenta, ConsoleColor.Black,
            "piepgras entertainment presents");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.DarkRed, "");
            TextController.writeText(100, ConsoleColor.Yellow, ConsoleColor.DarkRed,
            "Dablo IV:");
            TextController.writeText(45, ConsoleColor.Yellow, ConsoleColor.DarkRed,
            "Lord of Microtransactions");
            TextController.writeText(30, ConsoleColor.Yellow, ConsoleColor.DarkRed,
            "(GOTY Edition)");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.DarkRed, "");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.DarkRed, "");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.DarkRed,
            "*epic cinematic here*");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.DarkRed, "");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.DarkRed, "");
        }

        public static void Welcome()
        {
            TextController.writeText(40, ConsoleColor.White, ConsoleColor.DarkGray,
            "ROGUE ENCAMPMENT:");
            TextController.writeText(25, ConsoleColor.White, ConsoleColor.Black,
            "You find yourself standing in the middle of Rogue Encampment");
            TextController.writeText(25, ConsoleColor.White, ConsoleColor.Black,
            "A shredded elderly man approaches you:");
            TextController.writeText(25, ConsoleColor.White, ConsoleColor.Black, "");
        }

        public static string AskName()
        {
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            "My name is Decked Out Cane, what is yours?");
            return TextController.readText("My name is: ");
        }

        public static string NameJudging(string heroName)
        {
            if (heroName == null || heroName == "")
            {
                TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
                "Nothing.. really?");
                TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
                "I'm just gonna go ahead and name you myself..");
                TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
                "Henceforth you shall be know as...");
                TextController.writeText(0, ConsoleColor.Blue, ConsoleColor.Black, "");
                TextController.writeText(40, ConsoleColor.Red, ConsoleColor.Black,
                "the boring one.");

                heroName = "the boring one";
            }

            TextController.writeText(0, ConsoleColor.Blue, ConsoleColor.Black, "");
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            $"You really chose the name.. {heroName}..?");
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            "I mean I don't usually judge, but...");
            TextController.writeText(110, ConsoleColor.Blue, ConsoleColor.Black,
            "..wow...");
            TextController.writeText(0, ConsoleColor.Blue, ConsoleColor.Black, "");

            _heroName = heroName;
            return heroName;
        }

        public static void CheckExcitement()
        {
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            $"Anyway.. {_heroName}..");
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            $"Seeing as you're clearly the adventerous type");
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            "Lets pick a class for you!");
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black, "");
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            "Are you ready? *drumroll*");

            string _excitementString = TextController.readText("I cannot contain my: ");

            if (_excitementString.Length == 0)
            {
                TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
                "You're just a ray of sunshine aren't you?");
            }
            else if (_excitementString.Length > 0 && _excitementString.Length < 5)
            {
                TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
                $"{_excitementString[0]}.. sorry I wasn't listening.. ANYWAY!");
            }
            else
            {
                TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
                $"... *cough* fascinating..");
            }

            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            "As you clearly have a hard time making decisions,");
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black,
            "I've narrowed down your choices to these 8 classes:");
            TextController.writeText(40, ConsoleColor.Blue, ConsoleColor.Black, "");
        }

        public static void IntroduceClasses()
        {
            // Barbarian
            TextController.writeText(45, ConsoleColor.Green, ConsoleColor.Black,
            "BARBER :");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "Skilled with razors and scissors.. I guess.");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black, "");

            // Assassin
            TextController.writeText(45, ConsoleColor.Green, ConsoleColor.Black,
            "ASSASSIN :");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "Also skilled with razors and scissors.. I guess..");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "Something, something it's a trap..");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black, "");

            // Furry
            TextController.writeText(45, ConsoleColor.Green, ConsoleColor.Black,
            "DRUID :");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "It's just a furry, ngl..");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black, "");

            // Paladin
            TextController.writeText(45, ConsoleColor.Green, ConsoleColor.Black,
            "PALADIN :");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "The black white knight");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black, "");

            // Amazon
            TextController.writeText(45, ConsoleColor.Green, ConsoleColor.Black,
            "AMAZON :");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "Bows, arrows, spears, javelins.. I doubt I'll implement them all.");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "Also junk in the trunk.");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black, "");

            // Sorceror
            TextController.writeText(45, ConsoleColor.Green, ConsoleColor.Black,
            "SORCEROR :");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "I swear.. if I see another Frozen Orb build.......");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black, "");

            // Necromancer
            TextController.writeText(45, ConsoleColor.Green, ConsoleColor.Black,
            "NECROMANCER :");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "Totally not a necrophiliac.");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black, "");

            // Maggot
            TextController.writeText(45, ConsoleColor.Green, ConsoleColor.Black,
            "MAGGOT :");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "A small worm like creature.");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            "Decked Out Cane's personal recommendation to you!");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black, "");


            // CHOOSE YOUR FIGHTER
            TextController.writeText(10, ConsoleColor.Green, ConsoleColor.Black,
            "Pick one:");
            TextController.writeText(10, ConsoleColor.Green, ConsoleColor.Black,
            "BARBER, ASSASSIN, DRUID, PALADIN,");
            TextController.writeText(10, ConsoleColor.Green, ConsoleColor.Black,
             "AMAZON, SORCEROR, NECROMANCER, MAGGOT.");
        }

        internal static void RestartReason(string reason)
        {
            TextController.writeText(0, ConsoleColor.Black, ConsoleColor.White, "");
            TextController.writeText(0, ConsoleColor.Black, ConsoleColor.White, "");
            TextController.writeText(0, ConsoleColor.Black, ConsoleColor.White, "");
            TextController.writeText(100, ConsoleColor.Red, ConsoleColor.White,
            $"{reason}");
            TextController.writeText(40, ConsoleColor.Black, ConsoleColor.White,
            "It appears that our story ends here.. loser.");
            TextController.writeText(0, ConsoleColor.Black, ConsoleColor.White, "");
            TextController.writeText(25, ConsoleColor.Red, ConsoleColor.White,
            "(Restarting in 5..)");
            TextController.writeText(0, ConsoleColor.Black, ConsoleColor.White, "");
        }

        internal static void StartBattle(Hero hero, Foe foe)
        {
            TextController.writeText(0, ConsoleColor.Red, ConsoleColor.DarkCyan, "");
            TextController.writeText(10, ConsoleColor.Red, ConsoleColor.DarkCyan,
            "******* BATTLE *******");
            TextController.writeText(10, ConsoleColor.Red, ConsoleColor.DarkCyan,
            $"{hero.Name} VERSUS {foe.Name}");
        }

        internal static void EndBattle()
        {
            TextController.writeText(0, ConsoleColor.Red, ConsoleColor.DarkCyan, "");
            TextController.writeText(10, ConsoleColor.Red, ConsoleColor.DarkCyan,
            "xxxxxx VICTORY xxxxxx");
        }

        internal static void TakeDamage(string name, double damageAfterMitigation)
        {
            TextController.writeText(15, ConsoleColor.Red, ConsoleColor.Black,
            $"{name} took {damageAfterMitigation} damage after mitigation");
        }

        internal static void DealDamage(string name, CharacterBase defendingCharacter, double damage)
        {
            TextController.writeText(15, ConsoleColor.Red, ConsoleColor.Black,
            $"{name} dealt {damage}!");
            TextController.writeText(15, ConsoleColor.Red, ConsoleColor.Black,
            $"{defendingCharacter.Name} has {defendingCharacter.Health} health left!");
        }

        internal static void LevelUp(int level, int currentExperience, int experienceNeededForNextLevel)
        {
            TextController.writeText(25, ConsoleColor.Black, ConsoleColor.Yellow,
            $"DING! LEVEL UP: {level - 1} -> {level}!");
            TextController.writeText(10, ConsoleColor.Black, ConsoleColor.Yellow,
            $"Experience: {currentExperience}/{experienceNeededForNextLevel}!");
        }

        internal static void ExperienceGain(int experienceGained, int currentExperience, int experienceNeedToLevel)
        {
            TextController.writeText(5, ConsoleColor.Black, ConsoleColor.Yellow,
            $"Gained {experienceGained} XP | TOTAL: {currentExperience}/{experienceNeedToLevel} !");
        }

        internal static void UpdatedAttributes(int strength, int dexterity, int intelligence,
                                               int strengthGain, int dexterityGain, int intelligenceGain)
        {
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.Black,
            $"Attribute Gain:");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.Black,
            $"Strength: {strength}(+{strengthGain})  =  {strength + strengthGain}");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.Black,
            $"Dexterity: {dexterity}(+{dexterityGain})  =  {dexterity + dexterityGain}");
            TextController.writeText(0, ConsoleColor.Yellow, ConsoleColor.Black,
            $"Intelligence: {intelligence}(+{intelligenceGain})  =  {intelligence + intelligenceGain}");
        }

        internal static void BackpackIsFull()
        {
            TextController.writeText(15, ConsoleColor.Red, ConsoleColor.Black,
            $"_inventory is full!");
        }

        internal static void InventorySlotOccupied()
        {
            TextController.writeText(15, ConsoleColor.Red, ConsoleColor.Black,
            $"_inventory slot occupied!");
        }

        internal static void DisplayHero(Hero hero)
        {
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            $"|------------[ {hero.Name} ]-----------|");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            $"[ {hero.ClassName} ]");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"LEVEL: {hero.Experience.Level} | XP: {hero.Experience.CurrentExperience}/{hero.Experience.ExperienceNeededToLevel}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"Health: {hero.Health}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"Strength: {hero.Attributes.Strength} [Level Gain: + {hero.AttributesGain.Strength}]+" +
            $"   |  With Gear: {hero.getTotalAttributes().Strength}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"Dexterity: {hero.Attributes.Dexterity} [Level Gain: + {hero.AttributesGain.Dexterity}]+" +
            $"   |  With Gear: {hero.getTotalAttributes().Dexterity}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"Strength: {hero.Attributes.Intelligence} [Level Gain: + {hero.AttributesGain.Intelligence}]+" +
            $"   |  With Gear: {hero.getTotalAttributes().Intelligence}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"[ DAMAGE: ]");

            DisplayEquipped(hero);
            DisplayBackpack(hero);
        }

        internal static void DisplayEquipped(Hero hero)
        {
            string head, chest, legs, feet, weapon;

            if (hero.Inventory.EquippedItems[SlotType.HEAD_SLOT] != null)
            {
                head = hero.Inventory.EquippedItems[SlotType.HEAD_SLOT].Name;
            }
            else { head = "Empty"; }
            if (hero.Inventory.EquippedItems[SlotType.CHEST_SLOT] != null)
            {
                chest = hero.Inventory.EquippedItems[SlotType.CHEST_SLOT].Name;
            }
            else { chest = "Empty"; }
            if (hero.Inventory.EquippedItems[SlotType.LEGS_SLOT] != null)
            {
                legs = hero.Inventory.EquippedItems[SlotType.LEGS_SLOT].Name;
            }
            else { legs = "Empty"; }
            if (hero.Inventory.EquippedItems[SlotType.FEET_SLOT] != null)
            {
                feet = hero.Inventory.EquippedItems[SlotType.FEET_SLOT].Name;
            }
            else { feet = "Empty"; }
            if (hero.Inventory.EquippedItems[SlotType.WEAPON_SLOT] != null)
            {
                weapon = hero.Inventory.EquippedItems[SlotType.WEAPON_SLOT].Name;
            }
            else { weapon = "Empty"; }

            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            $"v------v-----[ EQUIPPED ]-----v-----v");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"HEAD SLOT:    {head}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"CHEST SLOT:    {chest}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"LEGS SLOT:    {legs}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"FEET SLOT:    {feet}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"WEAPON SLOT:    {weapon}");
        }

        internal static void DisplayBackpack(Hero hero)
        {
            string slot1, slot2, slot3, slot4, slot5;

            if (hero.Inventory.Backpack[1] != null)
            {
                slot1 = hero.Inventory.Backpack[1].Name;
            }
            else { slot1 = "Empty"; }
            if (hero.Inventory.Backpack[2] != null)
            {
                slot2 = hero.Inventory.Backpack[2].Name;
            }
            else { slot2 = "Empty"; }
            if (hero.Inventory.Backpack[3] != null)
            {
                slot3 = hero.Inventory.Backpack[3].Name;
            }
            else { slot3 = "Empty"; }
            if (hero.Inventory.Backpack[4] != null)
            {
                slot4 = hero.Inventory.Backpack[4].Name;
            }
            else { slot4 = "Empty"; }
            if (hero.Inventory.Backpack[5] != null)
            {
                slot5 = hero.Inventory.Backpack[5].Name;
            }
            else { slot5 = "Empty"; }

            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            $"v------v-----[ INVENTORY ]-----v-----v");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"SLOT #1: {slot1}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"SLOT #2: {slot1}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"SLOT #3: {slot1}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"SLOT #4: {slot1}");
            TextController.writeText(0, ConsoleColor.DarkYellow, ConsoleColor.Black,
            $"SLOT #5: {slot1}");
        }

        internal static void NoLoot()
        {
            TextController.writeText(10, ConsoleColor.Red, ConsoleColor.Black,
            $"You found no loot.. bummer..");
        }

        internal static string Decisions()
        {
            TextController.writeText(0, ConsoleColor.Red, ConsoleColor.White,
            $"MAKE A DECISION (write a number):");
            TextController.writeText(0, ConsoleColor.White, ConsoleColor.Black,
            $" 0 : FIGHT!    |   1 : Character     |  2 : Equipped");
            TextController.writeText(0, ConsoleColor.White, ConsoleColor.Black,
            $"3 : Backpack  |   4 : Manage Items  |  5 : Restart");
            TextController.writeText(0, ConsoleColor.White, ConsoleColor.Black,
            $"                  9 : View Cheats                 ");

            return TextController.readText("DECISION #: ");
        }

        internal static void NoDecision()
        {
            TextController.writeText(0, ConsoleColor.Red, ConsoleColor.White,
            $"I know it's hard to make decisions.. but try again!");
        }

        internal static string Cheats()
        {
            TextController.writeText(0, ConsoleColor.Red, ConsoleColor.White,
            $"");
            TextController.writeText(0, ConsoleColor.White, ConsoleColor.Black,
            $" 1 : Gain 100XP  |   2 : Loot Random Item  |  3 : No Cheat");

            return TextController.readText("CHEAT #: ");
        }

        internal static void DefaultClass()
        {
            TextController.writeText(0, ConsoleColor.Blue, ConsoleColor.Black,
            $"");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            $"Good job not picking any of the choices I gave you..");
            TextController.writeText(10, ConsoleColor.Blue, ConsoleColor.Black,
            $"I'll just decide that you're a Necromancer..");
            TextController.writeText(30, ConsoleColor.Blue, ConsoleColor.Black,
            $"As there's clearly something wrong with you!");
        }

        internal static void EquipNotAllowed(Item item)
        {
            TextController.writeText(10, ConsoleColor.Red, ConsoleColor.Black,
            $"You can't equip {item.Name}..");
        }
    }
}
