using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace A4OwenW
{
    public class GameMenu : Program
    {
        protected static List<Character> CharacterList = new();

        public static void Menu()
        {
            Console.WriteLine("Enter one of the following:");
            Console.WriteLine("1. Add a new character");
            Console.WriteLine("2. Edit existing character");
            Console.WriteLine("3. Delete character");
            Console.WriteLine("4. Display all characters");
            Console.WriteLine("5. Exit");
            Console.WriteLine("");

            string? answer = Console.ReadLine();
            Console.WriteLine("");
            string answerTrim = answer.Trim();
            string answerLower = answerTrim.ToLower();

            if (answerLower == "1" || answerLower == "add" || answerLower == "new")
            {
                AddCharacter();
            }
            else if (answerLower == "2" || answerLower == "edit")
            {
                EditCharacter();
            }
            else if (answerLower == "3" || answerLower == "delete")
            {
                DeleteCharacter();
            }
            else if (answerLower == "4" || answerLower == "display")
            {
                DisplayCharacters();
            }
            else if (answerLower == "5" || answerLower == "exit")
            {
                EndGame = true;
            }
            else
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("");
            }
            
        }

        protected static void AddCharacter()
        {
            string name = "";
            bool duplicateName = true;
            while (duplicateName)
            {
                do
                {
                    Console.WriteLine("What is the name of your character?");
                    Console.WriteLine("");
                    name = Console.ReadLine().Trim();
                    Console.WriteLine("");
                }
                while (IsName(name, "character") == false);

                duplicateName = false;
                foreach (Character character in CharacterList)
                {
                    if (name.ToLower() == character.NameLower)
                    {
                        Console.WriteLine("Name already in use.");
                        Console.WriteLine("");
                        duplicateName = true;
                    }
                }
            }
            Console.WriteLine($"The name has been set to {name}.");
            Console.WriteLine("");

            string levelString;
            do
            {
                Console.WriteLine("What is the level of your character?");
                Console.WriteLine("");
                levelString = Console.ReadLine().Trim();
                Console.WriteLine("");
            }
            while (IsLevel(levelString, 1, 7) == false);
            int level = int.Parse(levelString);
            Console.WriteLine($"The level has been set to {level}.");
            Console.WriteLine("");

            string abilityName;
            do
            {
                Console.WriteLine("What is the name of your ability?");
                Console.WriteLine("");
                abilityName = Console.ReadLine().Trim();
                Console.WriteLine("");
            }
            while (IsName(abilityName, "ability") == false);
            Console.WriteLine($"The first ability has been set to {abilityName}.");
            Console.WriteLine("");

            string abilityLevelString;
            do
            {
                Console.WriteLine("What is the level of your ability?");
                Console.WriteLine("");
                abilityLevelString = Console.ReadLine().Trim();
                Console.WriteLine("");
            }
            while (IsLevel(abilityLevelString, 0, 5) == false);
            int abilityLevel = int.Parse(abilityLevelString);
            Console.WriteLine($"The level has been set to {abilityLevel}.");
            Console.WriteLine("");

            Ability ability = new(abilityName, abilityLevel);
            CharacterList.Add(new Character(name, level, ability));
        }

        protected static void EditCharacter()
        {
            int characterIndex = -1;
            bool characterExists = true;
            bool exitMethod = false;
            bool isCharacter = false;

            Console.WriteLine("What is the name of the character you would like to edit?");
            Console.WriteLine("");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("");
                
            if (name.ToLower() == "exit")
            {
                Console.WriteLine("Exiting to main menu...");
                Console.WriteLine("");
                exitMethod = true;
            }
            else
            {
                foreach (Character character in CharacterList)
                {
                    if (character.NameLower == name.ToLower())
                    {
                        isCharacter = true;
                        characterIndex = CharacterList.IndexOf(character);
                    }
                }
                if (isCharacter == false)
                {
                    Console.WriteLine("Character not found.");
                    Console.WriteLine("");
                    characterExists = false;
                }
            }
            if (characterExists && exitMethod == false)
            {
                Console.WriteLine($"{CharacterList[characterIndex].Name}'s stats:");
                Console.WriteLine("");
                Console.WriteLine($"Level: {CharacterList[characterIndex].Level}");
                foreach (Ability ability in CharacterList[characterIndex].AbilityList)
                {
                    Console.WriteLine($"Ability #{CharacterList[characterIndex].AbilityList.IndexOf(ability) + 1}: {ability.AbilityName}");
                    Console.WriteLine($"Ability level: {ability.AbilityLevel}");
                }
                Console.WriteLine("");

                bool editWhatBool = true;
                while (editWhatBool)
                {
                    Console.WriteLine("What would you like to edit? (Name, Level, Ability)");
                    Console.WriteLine("");
                    string edit = Console.ReadLine().Trim().ToLower();
                    Console.WriteLine("");

                    if (edit == "exit")
                    {
                        Console.WriteLine("Exiting to main menu...");
                        Console.WriteLine("");
                        editWhatBool = false;
                    }
                    else if (edit == "n" || edit == "name")
                    {
                        editWhatBool = false;
                        EditCharacterName(characterIndex);
                    }
                    else if (edit == "l" || edit == "level")
                    {
                        editWhatBool = false;
                        EditCharacterLevel(characterIndex);
                    }
                    else if (edit == "a" || edit == "ability")
                    {
                        editWhatBool = false;
                        Character.EditAbility(characterIndex);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Name', 'Level', or 'Ability'.");
                        Console.WriteLine("");
                    }
                }
            }
        }

        protected static void DeleteCharacter()
        {
            bool isCharacter = false;
            int characterIndex = -1;
            int level = 0;

            Console.WriteLine("What is the name of the character you would like to delete?");
            Console.WriteLine("");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("");

            if (name.ToLower() != "exit")
            {
                foreach (Character character in CharacterList)
                {
                    if (character.NameLower == name.ToLower())
                    {
                        isCharacter = true;
                        name = character.Name;
                        level = character.Level;
                        characterIndex = CharacterList.IndexOf(character);
                    }
                }
                if (isCharacter)
                {
                    bool confirmLoopBool = true;
                    while (confirmLoopBool)
                    {
                        Console.WriteLine($"{name} has been found. Confirm delete? (y/n)");
                        Console.WriteLine("");
                        string confirmDeleteString = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine("");

                        if (confirmDeleteString == "y" || confirmDeleteString == "yes")
                        {
                            CharacterList.RemoveAt(characterIndex);
                            Console.WriteLine($"Character {name}, level {level} has been successfully removed.");
                            Console.WriteLine("");
                            confirmLoopBool = false;
                        }
                        else if (confirmDeleteString == "n" || confirmDeleteString == "no")
                        {
                            Console.WriteLine($"{name} has not been removed.");
                            Console.WriteLine("");
                            confirmLoopBool = false;
                        }
                    }
                }
                else if (isCharacter == false)
                {
                    Console.WriteLine("Character not found.");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Exiting to main menu...");
                Console.WriteLine("");
            }
        }

        protected static void DisplayCharacters()
        {
            foreach (Character character in CharacterList)
            {
                Console.WriteLine($"Name: {character.Name}");
                Console.WriteLine($"Level: {character.Level}");
                Console.WriteLine("");

                int abilityIndex = 0;
                foreach (Ability ability in character.AbilityList)
                {
                    Console.WriteLine($"Ability #{abilityIndex + 1}: {ability.AbilityName}");
                    Console.WriteLine($"Level: {ability.AbilityLevel}");
                    Console.WriteLine("");
                    abilityIndex++;
                }
                Console.WriteLine("");
            }
        }

        protected static void EditCharacterName(int characterIndex)
        {
            string name;
            bool duplicateName = true;
            while (duplicateName)
            {
                do
                {
                    Console.WriteLine("What would you like to change your character's name to?");
                    Console.WriteLine("");
                    name = Console.ReadLine().Trim();
                    Console.WriteLine("");
                }
                while (IsName(name, "character") == false);

                if (name.ToLower() != "exit")
                {
                    duplicateName = false;
                    foreach (Character character in CharacterList)
                    {
                        if (name.ToLower() == character.NameLower)
                        {
                            Console.WriteLine("Name already in use.");
                            Console.WriteLine("");
                            duplicateName = true;
                        }
                    }
                    if (duplicateName == false)
                    {
                        CharacterList[characterIndex].Name = name;
                        CharacterList[characterIndex].NameLower = name.ToLower();
                        Console.WriteLine($"The new name has been set to {name}.");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Exiting to main menu...");
                    Console.WriteLine("");
                }
            }
        }

        protected static void EditCharacterLevel(int characterIndex)
        {
            bool exitMethod = false;
            string levelString;
            do
            {
                Console.WriteLine("What is the new level of your character?");
                Console.WriteLine("");
                levelString = Console.ReadLine().Trim();
                Console.WriteLine("");

                if (levelString.ToLower() == "exit")
                {
                    exitMethod = true;
                    Console.WriteLine("Exiting to main menu...");
                    Console.WriteLine("");
                }
            }
            while (IsLevel(levelString, 1, 7) == false && exitMethod == false);

            if (exitMethod == false)
            {
                int level = int.Parse(levelString);

                CharacterList[characterIndex].Level = level;
                Console.WriteLine($"{CharacterList[characterIndex].Name}'s level has been changed to {level}.");
                Console.WriteLine("");
            }
        }

        public static bool IsName(string name, string type)
        {
            if (name == "" || name == null && type == "character")
            {
                Console.WriteLine("Please enter a name.");
                Console.WriteLine("");
                return false;
            }
            else if (name == "" || name == null && type == "ability")
            {
                Console.WriteLine("Please enter an ability name.");
                Console.WriteLine("");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsLevel(string level)
        {
            if (int.TryParse(level, out _))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("");
                return false;
            }
        }

        public static bool IsLevel(string level, int lowestLevel, int highestLevel)
        {
            if (int.TryParse(level, out int levelInt))
            {
                if (levelInt >= lowestLevel && levelInt <= highestLevel)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Level must be from {lowestLevel}-{highestLevel}.");
                    Console.WriteLine("");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("");
                return false;
            }
        }
    }
}
