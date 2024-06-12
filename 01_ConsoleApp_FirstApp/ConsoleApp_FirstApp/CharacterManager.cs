using System.Collections.Generic;

namespace ConsoleApp_GameOfThrones
{
    public static class CharacterManager
    {
        public static Dictionary<string, List<string>> GetCharacterNames()
        {
            // Define character names for each house
            var characterNames = new Dictionary<string, List<string>>
            {
                { "Stark", new List<string> { "Eddard", "Catelyn", "Jon Snow", "Sansa", "Arya", "Bran", "Rickon" } },
                { "Lannister", new List<string> { "Tywin", "Cersei", "Jaime", "Tyrion" } },
                { "Targaryen", new List<string> { "Aerys", "Rhaegar", "Viserys", "Daenerys" } },
                { "Baratheon", new List<string> { "Robert", "Stannis", "Renly" } },
                { "Greyjoy", new List<string> { "Balon", "Theon", "Yara" } }
            };

            return characterNames;
        }
    }
}
