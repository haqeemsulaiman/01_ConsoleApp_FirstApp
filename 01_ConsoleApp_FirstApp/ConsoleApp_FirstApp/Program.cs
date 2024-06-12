using System;

namespace ConsoleApp_GameOfThrones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game of Thrones!");
            HouseManager.IterateThroughList();

            // Simulate a battle
            House winner = HouseManager.SimulateBattle();
            Console.WriteLine($"The winner of the battle is House {winner.Name}!");

            // Get character names for each house
            var characterNames = HouseManager.GetCharacterNames();
            foreach (var houseName in characterNames.Keys)
            {
                Console.WriteLine($"Characters of House {houseName}: {string.Join(", ", characterNames[houseName])}");
            }

            Console.ReadKey();
        }

        /*Expected Output

        Welcome to the Game of Thrones News!
        House Stark, Territory: Winterfell, Type: Noble
        House Lannister, Territory: Casterly Rock, Type: Royal
        House Targaryen, Territory: Dragonstone, Type: Dragon
        House Baratheon, Territory: Storm's End, Type: Feudal
        House Greyjoy, Territory: Pyke, Type: Ironborn
        A battle is about to start between House {...} and House {...}...
        The winner of the battle is House {...}!
        Characters of House Stark: Eddard, Catelyn, Jon Snow, Sansa, Arya, Bran, Rickon
        Characters of House Lannister: Tywin, Cersei, Jaime, Tyrion
        Characters of House Targaryen: Aerys, Rhaegar, Viserys, Daenerys
        Characters of House Baratheon: Robert, Stannis, Renly
        Characters of House Greyjoy: Balon, Theon, Yara

        */
    }
}
