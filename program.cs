using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharecterSheetCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterRace = "";
            string characterClass = "";
            string title = "the Untitled";
            float health = 5f;
            float mana = 5f;
            float attackpower = 3;
            float attackhaste = 3;

            float stamina = 1f;
            float intellect = 1f;
            float strength = 1f;
            float agility = 1f;

            Console.WriteLine("\nType Character Name and press enter");
            string characterName = Console.ReadLine();

            characterRace = MyCharacterRace(characterRace);
            characterClass = MyCharacterClass(characterClass);

            // Add Race stat to basic stat
            switch (characterRace)
            {
                case "Human":
                    intellect = intellect * 1.4f;
                    break;
                case "Orc":
                    stamina = stamina * 1.4f;
                    break;
                case "Troll":
                    stamina = stamina * 1.1f;
                    agility = agility * 1.3f;
                    break;
                case "Gnome":
                    agility = agility * 1.2f;
                    intellect = intellect * 1.2f;
                    break;
                case "Dwarf":
                    strength = strength * 1.2f;
                    stamina = stamina * 1.2f;
                    break;
                case "Elf":
                    agility = agility * 1.4f;
                    break;
                case "Unknown":
                    agility = agility * 1.4f;
                    break;
            }

            // Add class stat to basic stat
            switch (characterClass)
            {
                case "Hunter":
                    strength = strength * 1.3f;
                    agility = agility * 1.3f;
                    break;
                case "Mage":
                    intellect = intellect * 1.3f;
                    agility = agility * 1.3f;
                    break;
                case "Monk":
                    stamina = stamina * 1.1f;
                    strength = strength * 1.2f;
                    agility = agility * 1.3f;
                    break;
                case "Paladin":
                    stamina = stamina * 1.2f;
                    strength = strength * 1.2f;
                    agility = agility * 1.2f;
                    break;
                case "Shaman":
                    strength = strength * 1.1f;
                    intellect = intellect * 1.2f;
                    agility = agility * 1.3f;
                    break;
                case "Warrior":
                    stamina = stamina * 1.2f;
                    strength = strength * 1.3f;
                    agility = agility * 1.1f;
                    break;
                case "Classless":
                    //Noclass identified
                    break;
            }

            //Calculate health, mana, attackpower, haste from new stats
            health = health * stamina;
            mana = mana * intellect;
            attackpower = attackpower * strength;
            attackhaste = attackhaste * agility;

            // Add title to all race/faction combination
            switch (characterClass)
            {
                case "Hunter":
                    title = HunterRaceTitle(characterRace, title);
                    break;
                case "Mage":
                    title = MageRaceTitle(characterRace, title);
                    break;
                case "Monk":
                    title = MonkRaceTitle(characterRace, title);
                    break;
                case "Paladin":
                    title = PaladinRaceTitle(characterRace, title);
                    break;
                case "Shaman":
                    title = ShamanRaceTitle(characterRace, title);
                    break;
                case "Warrior":
                    title = WarriorRaceTitle(characterRace, title);
                    break;
            }

            Console.Clear();
            Console.WriteLine("\n{0} {1} ({2} {3})\n------------\nHealth: {4:F2}\nMana: {5}\nAttackpower: {6:F2}\nHaste: {7:F2}\nStamina: {8:F2}\nIntellect: {9:F2}\nStrength: {10:F2}\nAgility: {11}\n------------\nPress enter to quit", characterName, title, characterRace, characterClass, health, mana, attackpower, attackhaste, stamina, intellect, strength, agility);
            Console.ReadLine();
        }

        private static string HunterRaceTitle(string characterRace, string title)
        {
            switch (characterRace)
            {
                case "Human":
                    title = "the Marksman";
                    break;
                case "Orc":
                    title = "the Preditor";
                    break;
                case "Troll":
                    title = "the Raptor";
                    break;
                case "Gnome":
                    title = "the Tiny Arrow";
                    break;
                case "Dwarf":
                    title = "the Hunterous";
                    break;
                case "Elf":
                    title = "the Shadowhunter";
                    break;
            }
            return title;
        }

        private static string MageRaceTitle(string characterRace, string title)
        {
            switch (characterRace)
            {
                case "Human":
                    title = "the Merlin";
                    break;
                case "Orc":
                    title = "the Firestarter";
                    break;
                case "Troll":
                    title = "the Firemaker";
                    break;
                case "Gnome":
                    title = "the Tinyblast";
                    break;
                case "Dwarf":
                    title = "the Ashbringer";
                    break;
                case "Elf":
                    title = "the Pyroblast";
                    break;
            }
            return title;
        }

        private static string MonkRaceTitle(string characterRace, string title)
        {
            switch (characterRace)
            {
                case "Human":
                    title = "the Holyness";
                    break;
                case "Orc":
                    title = "the Lightbringer";
                    break;
                case "Troll":
                    title = "the Lightsource";
                    break;
                case "Gnome":
                    title = "the Kneekicker";
                    break;
                case "Dwarf":
                    title = "the Winebringer";
                    break;
                case "Elf":
                    title = "the Naturous";
                    break;
            }
            return title;
        }

        private static string PaladinRaceTitle(string characterRace, string title)
        {
            switch (characterRace)
            {
                case "Human":
                    title = "the Templar";
                    break;
                case "Orc":
                    title = "the Black Knight";
                    break;
                case "Troll":
                    title = "the Beastrider";
                    break;
                case "Gnome":
                    title = "the Crusader";
                    break;
                case "Dwarf":
                    title = "the Iron Dwarf";
                    break;
                case "Elf":
                    title = "the Light Champion";
                    break;
            }
            return title;
        }

        private static string ShamanRaceTitle(string characterRace, string title)
        {
            switch (characterRace)
            {
                case "Human":
                    title = "the Tesla";
                    break;
                case "Orc":
                    title = "the Demonseeker";
                    break;
                case "Troll":
                    title = "the Witch";
                    break;
                case "Gnome":
                    title = "the Little Lightning";
                    break;
                case "Dwarf":
                    title = "the Elemental Source";
                    break;
                case "Elf":
                    title = "the Magic Forrester";
                    break;
            }
            return title;
        }

        private static string WarriorRaceTitle(string characterRace, string title)
        {
            switch (characterRace)
            {
                case "Human":
                    title = "the Lionheart";
                    break;
                case "Orc":
                    title = "the Strong";
                    break;
                case "Troll":
                    title = "the Conquerer";
                    break;
                case "Gnome":
                    title = "the Brave";
                    break;
                case "Dwarf":
                    title = "the Stronghold";
                    break;
                case "Elf":
                    title = "the Wise";
                    break;
            }
            return title;
        }

        private static string MyCharacterRace(string characterRace)
        {
            Console.Clear();
            Console.WriteLine("\nChoose race:\n------------\n1. Human\n2. Orc\n3. Troll\n4. Gnome\n5. Dwarf\n6. Elf\n------------\nPress number and press enter to continue");
            string race = Console.ReadLine();

            switch (race)
            {
                case "1":
                    characterRace = "Human";
                    break;
                case "2":
                    characterRace = "Orc";
                    break;
                case "3":
                    characterRace = "Troll";
                    break;
                case "4":
                    characterRace = "Gnome";
                    break;
                case "5":
                    characterRace = "Dwarf";
                    break;
                case "6":
                    characterRace = "Elf";
                    break;
                default:
                    characterRace = "Unknown";
                    characterRace = MyCharacterRace(characterRace);
                    break;
            }
            return characterRace;
        }

        private static string MyCharacterClass(string characterClass)
        {
            Console.Clear();
            Console.WriteLine("\nChoose class:\n------------\n1. Hunter\n2. Mage\n3. Monk\n4. Paladin\n5. Shaman\n6. Warrior\n------------\nPress number and press enter to continue");
            string chrclass = Console.ReadLine();

            switch (chrclass)
            {
                case "1":
                    characterClass = "Hunter";
                    break;
                case "2":
                    characterClass = "Mage";
                    break;
                case "3":
                    characterClass = "Monk";
                    break;
                case "4":
                    characterClass = "Paladin";
                    break;
                case "5":
                    characterClass = "Shaman";
                    break;
                case "6":
                    characterClass = "Warrior";
                    break;
                default:
                    characterClass = "Classless";
                    characterClass = MyCharacterClass(characterClass);
                    break;
            }
            return characterClass;
        }
    }
}
