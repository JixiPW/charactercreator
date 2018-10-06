using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charactersheetcreator
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

            Console.WriteLine("Type Character Name and press enter");
            string characterName = Console.ReadLine();

            characterRace = MyCharacterRace(characterRace);
            characterClass = MyCharacterClass(characterClass);

            // Add Race stat to basic stat
            if (characterRace == "Human")
            {
                intellect = intellect * 1.4f;
            }
            else if (characterRace == "Orc")
            {
                stamina = stamina * 1.4f;
            }
            else if (characterRace == "Troll")
            {
                stamina = stamina * 1.1f;
                agility = agility * 1.3f;
            }
            else if (characterRace == "Gnome")
            {
                agility = agility * 1.2f;
                intellect = intellect * 1.2f;
            }
            else if (characterRace == "Dwarf")
            {
                strength = strength * 1.2f;
                stamina = stamina * 1.2f;
            }
            else if (characterRace == "Elf")
            {
                agility = agility * 1.4f;
            }

            // Add class stat to basic stat
            else if (characterClass == "Hunter")
            {
                strength = strength * 1.3f;
                agility = agility * 1.3f;
            }
            else if (characterClass == "Mage")
            {
                intellect = intellect * 1.3f;
                agility = agility * 1.3f;
            }
            else if (characterClass == "Monk")
            {
                stamina = stamina * 1.1f;
                strength = strength * 1.2f;
                agility = agility * 1.3f;
            }
            else if (characterClass == "Paladin")
            {
                stamina = stamina * 1.2f;
                strength = strength * 1.2f;
                agility = agility * 1.2f;
            }
            else if (characterClass == "Shaman")
            {
                strength = strength * 1.1f;
                intellect = intellect * 1.2f;
                agility = agility * 1.3f;

            }
            else if (characterClass == "Warrior")
            {
                stamina = stamina * 1.2f;
                strength = strength * 1.3f;
                agility = agility * 1.1f;
            }

            //Calculate health, mana, attackpower, haste from new stats
            health = health * stamina;
            mana = mana * intellect;
            attackpower = attackpower * strength;
            attackhaste = attackhaste * agility;

            // Add title to all race/faction combination
            if (characterClass == "Hunter" && characterRace == "Human")
            {
                title = "the Marksman";
            }
            else if (characterClass == "Hunter" && characterRace == "Orc")
            {
                title = "the Preditor";
            }
            else if (characterClass == "Hunter" && characterRace == "Troll")
            {
                title = "the Raptor";
            }
            else if (characterClass == "" && characterRace == "Gnome")
            {
                title = "the Tiny Arrow";
            }
            else if (characterClass == "Hunter" && characterRace == "Dwarf")
            {
                title = "the Hunterous";
            }
            else if (characterClass == "Hunter" && characterRace == "Elf")
            {
                title = "the Shadowhunter";
            }
            else if (characterClass == "Mage" && characterRace == "Human")
            {
                title = "the Merlin";
            }
            else if (characterClass == "Mage" && characterRace == "Orc")
            {
                title = "the Firestarter";
            }
            else if (characterClass == "Mage" && characterRace == "Troll")
            {
                title = "the Firemaker";
            }
            else if (characterClass == "Mage" && characterRace == "Gnome")
            {
                title = "the Tinyblast";
            }
            else if (characterClass == "Mage" && characterRace == "Dwarf")
            {
                title = "the Ashbringer";
            }
            else if (characterClass == "Mage" && characterRace == "Elf")
            {
                title = "the Pyroblast";
            }
            else if (characterClass == "Monk" && characterRace == "Human")
            {
                title = "the Holyness";
            }
            else if (characterClass == "Monk" && characterRace == "Orc")
            {
                title = "the Lightbringer";
            }
            else if (characterClass == "Monk" && characterRace == "Troll")
            {
                title = "the Lightsource";
            }
            else if (characterClass == "Monk" && characterRace == "Gnome")
            {
                title = "the Kneekicker";
            }
            else if (characterClass == "Monk" && characterRace == "Dwarf")
            {
                title = "the Winebringer";
            }
            else if (characterClass == "Monk" && characterRace == "Elf")
            {
                title = "the Naturous";
            }
            else if (characterClass == "Paladin" && characterRace == "Human")
            {
                title = "the Templar";
            }
            else if (characterClass == "Paladin" && characterRace == "Orc")
            {
                title = "the Black Knight";
            }
            else if (characterClass == "Paladin" && characterRace == "Troll")
            {
                title = "the Beastrider";
            }
            else if (characterClass == "Paladin" && characterRace == "Gnome")
            {
                title = "the Crusader";
            }
            else if (characterClass == "Paladin" && characterRace == "Dwarf")
            {
                title = "the Iron Dwarf";
            }
            else if (characterClass == "Paladin" && characterRace == "Elf")
            {
                title = "the Light Champion";
            }
            else if (characterClass == "Shaman" && characterRace == "Human")
            {
                title = "the Tesla";
            }
            else if (characterClass == "Shaman" && characterRace == "Orc")
            {
                title = "the Demonseeker";
            }
            else if (characterClass == "Shaman" && characterRace == "Troll")
            {
                title = "the Witch";
            }
            else if (characterClass == "Shaman" && characterRace == "Gnome")
            {
                title = "the Little Lightning";
            }
            else if (characterClass == "Shaman" && characterRace == "Dwarf")
            {
                title = "the Elemental Source";
            }
            else if (characterClass == "Shaman" && characterRace == "Elf")
            {
                title = "the Magic Forrester";
            }
            else if (characterClass == "Warrior" && characterRace == "Human")
            {
                title = "the Lionheart";
            }
            else if (characterClass == "Warrior" && characterRace == "Orc")
            {
                title = "the Strong";
            }
            else if (characterClass == "Warrior" && characterRace == "Troll")
            {
                title = "the Conquerer";
            }
            else if (characterClass == "Warrior" && characterRace == "Gnome")
            {
                title = "the Brave";
            }
            else if (characterClass == "Warrior" && characterRace == "Dwarf")
            {
                title = "the Stronghold";
            }
            else if (characterClass == "Warrior" && characterRace == "Elf")
            {
                title = "the Wise";
            }

            Console.Clear();
            Console.WriteLine("\n{0} {1} ({2} {3})\n\nHealth: {4:F2}\nMana: {5}\nAttackpower: {6:F2}\nHaste: {7:F2}\nStamina: {8:F2}\nIntellect: {9:F2}\nStrength: {10:F2}\nAgility: {11}\n\nPress enter to quit", characterName, title, characterRace, characterClass, health, mana, attackpower, attackhaste, stamina, intellect, strength, agility);
            Console.ReadLine();
        }

        private static string MyCharacterRace(string characterRace)
        {
            Console.Clear();
            Console.WriteLine("Choose race: \n\n1. Human\n2. Orc\n3. Troll\n4. Gnome\n5. Dwarf\n6. Elf\n\nPress number and press enter to continue");
            string race = Console.ReadLine();

            if (race == "1")
            {
                characterRace = "Human";
            }
            else if (race == "2")
            {
                characterRace = "Orc";
            }
            else if (race == "3")
            {
                characterRace = "Troll";
            }
            else if (race == "4")
            {
                characterRace = "Gnome";
            }
            else if (race == "5")
            {
                characterRace = "Dwarf";
            }
            else if (race == "6")
            {
                characterRace = "Elf";
            }
            else
            {
                MyCharacterRace(characterRace);
            }

            return characterRace;
        }

        private static string MyCharacterClass(string characterClass)
        {
            Console.Clear();
            Console.WriteLine("Choose class: \n\n1. Hunter\n2. Mage\n3. Monk\n4. Paladin\n5. Shaman\n6. Warrior\n\nPress number and press enter to continue");
            string chrclass = Console.ReadLine();

            if (chrclass == "1")
            {
                characterClass = "Hunter";
            }
            else if (chrclass == "2")
            {
                characterClass = "Mage";
            }
            else if (chrclass == "3")
            {
                characterClass = "Monk";
            }
            else if (chrclass == "4")
            {
                characterClass = "Paladin";
            }
            else if (chrclass == "5")
            {
                characterClass = "Shaman";
            }
            else if (chrclass == "6")
            {
                characterClass = "Warrior";
            }
            else
            {
                MyCharacterClass(characterClass);
            }

            return characterClass;
        }
        
    }
}
