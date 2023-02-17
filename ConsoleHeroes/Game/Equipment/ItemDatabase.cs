using ConsoleHeroes.Game.Abstracts;
using ConsoleHeroes.Game.Enums;
using ConsoleHeroes.Game.Modifiers;
using ConsoleHeroes.Game.Output;

namespace ConsoleHeroes.Game.Equipment
{
    /// <summary>
    /// Singleton responsible for holding all items for the game.
    /// Also responsible for finding items (by name) and returning.
    /// Also capable of selecting random items by chance, for loot drops.
    /// Throws item not found exception.
    /// </summary>
    /// <throws>Exception(Item not found)</throws>
    internal sealed class ItemDatabase
    {
        private static ItemDatabase instance = null!;

        private static readonly Item[] _weapons = {
            // AXES
            new ItemWeapon("The Worst Axe", 1, 4, new Attributes(1,0,0), WeaponType.AXE_WEAPON),
            new ItemWeapon("Steel Axe", 4, 17, new Attributes(4,0,0), WeaponType.AXE_WEAPON),
            new ItemWeapon("Axecalibur", 17, 94, new Attributes(18,10,0), WeaponType.AXE_WEAPON),

            // SCISSORS
            new ItemWeapon("Sissy Scissors", 1, 2, new Attributes(1,2,0), WeaponType.SCISSORS_WEAPON),
            new ItemWeapon("Fiskars", 5, 4, new Attributes(3,8,0), WeaponType.SCISSORS_WEAPON),
            new ItemWeapon("The Best Scissors", 15, 42, new Attributes(13,32,0), WeaponType.SCISSORS_WEAPON),

            // RAZORS
            new ItemWeapon("Rusty Razor", 1, 2, new Attributes(0,2,0), WeaponType.RAZOR_WEAPON),
            new ItemWeapon("Gillette", 2, 3, new Attributes(0,3,0), WeaponType.RAZOR_WEAPON),
            new ItemWeapon("True Barber", 21, 51, new Attributes(12,41,0), WeaponType.RAZOR_WEAPON),

            // SWORDS
            new ItemWeapon("Tiny Needle", 1, 3, new Attributes(0,4,0), WeaponType.SWORD_WEAPON),
            new ItemWeapon("Bastard Sword", 6, 10, new Attributes(2,10,0), WeaponType.SWORD_WEAPON),
            new ItemWeapon("Excalibur", 60, 1337, new Attributes(1337,1337,1337), WeaponType.SWORD_WEAPON),

            // WANDS
            new ItemWeapon("Magic Stick", 1, 5, new Attributes(0,1,7), WeaponType.WAND_WEAPON),
            new ItemWeapon("Magic Wand", 8, 15, new Attributes(2,0,21), WeaponType.WAND_WEAPON),
            new ItemWeapon("Holy Locket", 27, 283, new Attributes(10, 5, 210), WeaponType.WAND_WEAPON),

            // BOWS
            new ItemWeapon("Stick With String", 1, 3, new Attributes(0,2,0), WeaponType.BOW_WEAPON),
            new ItemWeapon("Recurve Bow", 8, 19, new Attributes(4,17,7), WeaponType.BOW_WEAPON),
            new ItemWeapon("Rhok'delar", 50, 142, new Attributes(32, 121, 42), WeaponType.BOW_WEAPON),

            // STAFFS
            new ItemWeapon("Walking Stick", 1, 5, new Attributes(1, 3, 8), WeaponType.STAFF_WEAPON),
            new ItemWeapon("Quaterstaff", 8, 21, new Attributes(3, 12, 22), WeaponType.STAFF_WEAPON),
            new ItemWeapon("The White Staff", 9001, 9001, new Attributes(9001, 9001, 9001), WeaponType.STAFF_WEAPON),

            // HAMMERS
            new ItemWeapon("Stone Hammer", 1, 6, new Attributes(4, 0, 0), WeaponType.HAMMER_WEAPON),
            new ItemWeapon("Glacial Hammer", 14, 44, new Attributes(44, 0, 0), WeaponType.HAMMER_WEAPON),
            new ItemWeapon("Hand of Ragnaros", 1, 0, new Attributes(-1, -1, -1), WeaponType.HAMMER_WEAPON),
        };

        private static readonly Item[] _armors = {
            // HEADS
                //CLOTH
                new ItemArmor("Cowboy Hat", 1, 1, new Attributes(0,0,1), ArmorType.CLOTH_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Cap", 11, 42, new Attributes(12,41,21), ArmorType.CLOTH_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Wizard Hat", 42, 152, new Attributes(0,124,0), ArmorType.CLOTH_ARMOR, SlotType.HEAD_SLOT ),
                
                // LEATHER
                new ItemArmor("Hood", 1, 1, new Attributes(0,0,1), ArmorType.LEATHER_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Ghostshroud", 11, 42, new Attributes(12,41,21), ArmorType.LEATHER_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Bloodfang Hood", 42, 152, new Attributes(0,124,0), ArmorType.LEATHER_ARMOR, SlotType.HEAD_SLOT ),

                // MAIL
                new ItemArmor("Nosering Helmet", 1, 21, new Attributes(0,0,0), ArmorType.MAIL_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Ringbrynje", 11, 42, new Attributes(12,41,21), ArmorType.MAIL_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Hunter Gear Drop Sucks", 42, 152, new Attributes(0,124,0), ArmorType.MAIL_ARMOR, SlotType.HEAD_SLOT ),

                // PLATE
                new ItemArmor("Metal Box", 1, 21, new Attributes(0,0,0), ArmorType.PLATE_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Helm of Iron Will", 11, 42, new Attributes(12,41,21), ArmorType.PLATE_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Bucket", 42, 152, new Attributes(0,124,0), ArmorType.PLATE_ARMOR, SlotType.HEAD_SLOT ),

                // LATEX
                new ItemArmor("Gimp Mask", 1, 21, new Attributes(0,0,0), ArmorType.PLATE_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("Sexy Time Mask", 11, 42, new Attributes(12,41,21), ArmorType.PLATE_ARMOR, SlotType.HEAD_SLOT ),
                new ItemArmor("EXPO Mask", 42, 152, new Attributes(0,124,0), ArmorType.PLATE_ARMOR, SlotType.HEAD_SLOT ),

            // CHESTS
                //CLOTH
                new ItemArmor("Novice Robe", 1, 1, new Attributes(0,0,1), ArmorType.CLOTH_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Learned Robe", 11, 42, new Attributes(12,41,21), ArmorType.CLOTH_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Wizard Robe", 42, 152, new Attributes(0,124,0), ArmorType.CLOTH_ARMOR, SlotType.CHEST_SLOT ),
                
                // LEATHER
                new ItemArmor("Jacket", 1, 1, new Attributes(0,0,1), ArmorType.LEATHER_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Jacket with Spikes", 11, 42, new Attributes(12,41,21), ArmorType.LEATHER_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Jacket with Spikes and Backtag", 42, 152, new Attributes(0,124,0), ArmorType.LEATHER_ARMOR, SlotType.CHEST_SLOT ),

                // MAIL
                new ItemArmor("Store Patter", 1, 21, new Attributes(0,0,0), ArmorType.MAIL_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("You got mail", 11, 42, new Attributes(12,41,21), ArmorType.MAIL_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Hunter Loot", 42, 152, new Attributes(0,124,0), ArmorType.MAIL_ARMOR, SlotType.CHEST_SLOT ),

                // PLATE
                new ItemArmor("Store Patter Igen", 1, 21, new Attributes(0,0,0), ArmorType.PLATE_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Plate Jacket", 11, 42, new Attributes(12,41,21), ArmorType.PLATE_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Why Did I make So Many Items", 42, 152, new Attributes(0,124,0), ArmorType.PLATE_ARMOR, SlotType.CHEST_SLOT ),

                // LATEX
                new ItemArmor("Rubber Suit", 1, 21, new Attributes(0,0,0), ArmorType.PLATE_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Inflation Suit", 11, 42, new Attributes(12,41,21), ArmorType.PLATE_ARMOR, SlotType.CHEST_SLOT ),
                new ItemArmor("Inflation Suit with Breathing Tube", 42, 152, new Attributes(0,124,0), ArmorType.PLATE_ARMOR, SlotType.CHEST_SLOT ),

            // LEGS
                //CLOTH
                new ItemArmor("Ripped Undies", 1, 1, new Attributes(0,0,1), ArmorType.CLOTH_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Undies", 11, 42, new Attributes(12,41,21), ArmorType.CLOTH_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Leopard Pattern Undies", 42, 152, new Attributes(0,124,0), ArmorType.CLOTH_ARMOR, SlotType.LEGS_SLOT ),
                
                // LEATHER
                new ItemArmor("Leather Jeans", 1, 1, new Attributes(0,0,1), ArmorType.LEATHER_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Cowboy Wrangler Jeans", 11, 42, new Attributes(12,41,21), ArmorType.LEATHER_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Humanskin Pants", 42, 152, new Attributes(0,124,0), ArmorType.LEATHER_ARMOR, SlotType.LEGS_SLOT ),

                // MAIL
                new ItemArmor("I", 1, 21, new Attributes(0,0,0), ArmorType.MAIL_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Am", 11, 42, new Attributes(12,41,21), ArmorType.MAIL_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Almost There", 42, 152, new Attributes(0,124,0), ArmorType.MAIL_ARMOR, SlotType.LEGS_SLOT ),

                // PLATE
                new ItemArmor("Uncomfy Plate Leggins", 1, 21, new Attributes(0,0,0), ArmorType.PLATE_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Comfy Plate Leggings", 11, 42, new Attributes(12,41,21), ArmorType.PLATE_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Luxurious Plate Leggings with Door", 42, 152, new Attributes(0,124,0), ArmorType.PLATE_ARMOR, SlotType.LEGS_SLOT ),

                // LATEX
                new ItemArmor("Sexy Pants", 1, 21, new Attributes(0,0,0), ArmorType.PLATE_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Revolting Pants", 11, 42, new Attributes(12,41,21), ArmorType.PLATE_ARMOR, SlotType.LEGS_SLOT ),
                new ItemArmor("Delete These Pants", 42, 152, new Attributes(0,124,0), ArmorType.PLATE_ARMOR, SlotType.LEGS_SLOT ),

            // FEET
                //CLOTH
                new ItemArmor("Cloth Socks", 1, 1, new Attributes(0,0,1), ArmorType.CLOTH_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Sneakers", 11, 42, new Attributes(12,41,21), ArmorType.CLOTH_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Sneakers without Laces", 42, 152, new Attributes(0,124,0), ArmorType.CLOTH_ARMOR, SlotType.FEET_SLOT ),
                
                // LEATHER
                new ItemArmor("Casual Shoes", 1, 1, new Attributes(0,0,1), ArmorType.LEATHER_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Business Shoes", 11, 42, new Attributes(12,41,21), ArmorType.LEATHER_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Wedding Shoes", 42, 152, new Attributes(0,124,0), ArmorType.LEATHER_ARMOR, SlotType.FEET_SLOT ),

                // MAIL
                new ItemArmor("Lego Boots", 1, 21, new Attributes(0,0,0), ArmorType.MAIL_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Artrithis Boots", 11, 42, new Attributes(12,41,21), ArmorType.MAIL_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("I Don't Like Mail Items", 42, 152, new Attributes(0,124,0), ArmorType.MAIL_ARMOR, SlotType.FEET_SLOT ),

                // PLATE
                new ItemArmor("Reinforced Work Boot", 1, 21, new Attributes(0,0,0), ArmorType.PLATE_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Knight Boots", 11, 42, new Attributes(12,41,21), ArmorType.PLATE_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Lava Walkers", 42, 152, new Attributes(0,124,0), ArmorType.PLATE_ARMOR, SlotType.FEET_SLOT ),

                // LATEX
                new ItemArmor("Rubber Socks", 1, 21, new Attributes(0,0,0), ArmorType.PLATE_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Rubber Socks with Toes", 11, 42, new Attributes(12,41,21), ArmorType.PLATE_ARMOR, SlotType.FEET_SLOT ),
                new ItemArmor("Not Rubber Socks", 42, 152, new Attributes(0,124,0), ArmorType.PLATE_ARMOR, SlotType.FEET_SLOT ),
        };

        public static Item[] Weapons { get { return _weapons; } }
        public static Item[] Armors { get { return _armors; } }

        public static ItemDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ItemDatabase();
                }
                return instance;
            }
        }

        public static Item findItem(string name)
        {
            try
            {
                foreach (Item item in _weapons)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }

                foreach (Item item in _armors)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Item not found");
            }

            throw new Exception($"{name} wasn't found in item database!");
        }

        public static Item findRandomItemWithChance(int chanceInPercent)
        {
            Random randomNumber = new Random();

            if (randomNumber.Next(100) < chanceInPercent)
            {
                Random randomZeroOrOne = new Random();

                if (randomZeroOrOne.Next(2) == 0)
                {
                    Random whichRandomWeapon = new Random();
                    Item newItem = _weapons[whichRandomWeapon.Next(_weapons.Length)];
                    return newItem;
                }
                else
                {
                    Random whichRandomArmor = new Random();
                    Item newItem = _armors[whichRandomArmor.Next(_armors.Length)];
                    return newItem;
                }
            }
            else
            {
                Narrator.NoLoot();
                return null!;
            }
        }
    }
}
