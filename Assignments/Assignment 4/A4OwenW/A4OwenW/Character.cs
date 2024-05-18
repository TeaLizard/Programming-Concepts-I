using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A4OwenW
{
    public class Character : GameMenu
    {
        public string Name;
        public string NameLower;
        public int Level;
        public List<Ability> AbilityList = new();

        public Character(string characterName, int characterLevel, Ability characterAbility)
        {
            Name = characterName;
            NameLower = characterName.ToLower();
            Level = characterLevel;
            AbilityList.Add(characterAbility);
        }

        public Character(string characterName, int characterLevel)
        {
            Name = characterName;
            NameLower = characterName.ToLower();
            Level = characterLevel;
        }

        protected Character()
        {
            // Don't know why this has to be here
        }

        public static void AddAbility(int characterIndex)
        {
            bool abilityDuplicateBool = true;
            while (abilityDuplicateBool)
            {
                abilityDuplicateBool = false;
                string abilityName;
                do
                {
                    Console.WriteLine("What is the name of the ability you would like to add?");
                    Console.WriteLine("");
                    abilityName = Console.ReadLine().Trim();
                    Console.WriteLine("");
                }
                while (IsName(abilityName, "ability") == false);

                foreach (Ability ability in CharacterList[characterIndex].AbilityList)
                {
                    if (ability.AbilityName.ToLower() == abilityName.ToLower())
                    {
                        Console.WriteLine($"{CharacterList[characterIndex].Name} already has this ability.");
                        Console.WriteLine("");
                        abilityDuplicateBool = true;
                    }
                }
                if (abilityDuplicateBool == false)
                {
                    string abilityLevelString;
                    do
                    {
                        Console.WriteLine("What is the level of your ability?");
                        Console.WriteLine("");
                        abilityLevelString = Console.ReadLine().Trim();
                        Console.WriteLine("");
                    }
                    while (IsLevel(abilityLevelString, 0, 5) == false);
                    int abilitylevel = int.Parse(abilityLevelString);

                    CharacterList[characterIndex].AbilityList.Add(new(abilityName, abilitylevel));

                    Console.WriteLine($"{abilityName} has been added.");
                    Console.WriteLine("");
                }
            }
        }

        public static void EditAbility(int characterIndex)
        {
            bool editTypeBool = true;
            while (editTypeBool)
            {
                Console.WriteLine("Would you like to add, edit, or delete an ability?");
                Console.WriteLine("");
                string editType = Console.ReadLine().Trim().ToLower();
                Console.WriteLine("");

                if (editType == "exit")
                {
                    editTypeBool = false;
                    Console.WriteLine("Exciting to main menu...");
                    Console.WriteLine("");
                }
                else if (editType == "add" || editType == "a")
                {
                    editTypeBool = false;
                    AddAbility(characterIndex);
                }
                else if (editType == "delete" || editType == "d")
                {
                    editTypeBool = false;
                    DeleteAbility(characterIndex);
                }
                else if (editType == "edit" || editType == "e")
                {
                    editTypeBool = false;
                    int abilityIndex = -1;
                    string abilityName = "";
                    int abilityLevel = -1;
                    bool whichAbilityBool = true;
                    while (whichAbilityBool)
                    {
                        Console.WriteLine($"Which one of {CharacterList[characterIndex].Name}'s abilities do you want to edit?");
                        Console.WriteLine("");
                        string whichAbility = Console.ReadLine().Trim().ToLower();
                        Console.WriteLine("");

                        foreach (Ability ability in CharacterList[characterIndex].AbilityList)
                        {
                            if (ability.AbilityName.ToLower() == whichAbility.ToLower())
                            {
                                do
                                {
                                    Console.WriteLine("What is the new name of your ability?");
                                    Console.WriteLine("");
                                    abilityName = Console.ReadLine().Trim();
                                    Console.WriteLine("");
                                }
                                while (IsName(abilityName, "ability") == false);
                                Console.WriteLine($"The ability has been changed to {abilityName}.");
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
                                abilityLevel = int.Parse(abilityLevelString);
                                Console.WriteLine($"The level has been set to {abilityLevel}.");
                                Console.WriteLine("");

                                abilityIndex = CharacterList[characterIndex].AbilityList.IndexOf(ability);
                                
                                whichAbilityBool = false;
                            }
                        }
                        if (whichAbilityBool == false)
                        {
                            CharacterList[characterIndex].AbilityList[abilityIndex] = new(abilityName, abilityLevel);
                        }
                        else if (whichAbilityBool)
                        {
                            Console.WriteLine($"{CharacterList[characterIndex].Name} doesn't have this ability.");
                            Console.WriteLine("");
                        }
                    }
                }
            }
        }

        public static void DeleteAbility(int characterIndex)
        {
            int abilityIndex = -1;
            bool whichAbility = true;
            while (whichAbility)
            {
                Console.WriteLine($"Which one of {CharacterList[characterIndex].Name}'s abilities do you want to delete?");
                Console.WriteLine("");
                string abilityName = Console.ReadLine().Trim();
                Console.WriteLine("");

                
                foreach (Ability ability in CharacterList[characterIndex].AbilityList)
                {
                    if (ability.AbilityName.ToLower() == abilityName.ToLower())
                    {
                        abilityIndex = CharacterList[characterIndex].AbilityList.IndexOf(ability);
                        Console.WriteLine($"{abilityName} has been removed.");
                        Console.WriteLine("");
                        whichAbility = false;
                    }
                }
            }
            CharacterList[characterIndex].AbilityList.RemoveAt(abilityIndex);
        }
    }
}
