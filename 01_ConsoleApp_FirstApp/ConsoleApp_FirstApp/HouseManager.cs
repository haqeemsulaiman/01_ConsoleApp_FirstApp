using System;
using System.Collections.Generic;

namespace ConsoleApp_GameOfThrones
{
    public static class HouseManager
    {
        public static void IterateThroughList()
        {
            var houses = new List<House>
            {
                new House() { Name="Stark", Territory="Winterfell", HouseType=new HouseType('N')},
                new House() { Name="Lannister", Territory="Casterly Rock", HouseType=new HouseType('R')},
                new House() { Name="Targaryen", Territory="Dragonstone", HouseType=new HouseType('D')},
                new House() { Name="Baratheon", Territory="Storm's End", HouseType=new HouseType('F')},
                new House() { Name="Greyjoy", Territory="Pyke", HouseType=new HouseType('I')}
            };

            foreach (House house in houses)
            {
                Console.WriteLine($"House {house.Name}, Territory: {house.Territory}, Type: {house.HouseType.TypeName}");
            }
        }

        public static House SimulateBattle()
        {
            Random random = new Random();
            var houses = new List<House>
            {
                new House() { Name="Stark", Territory="Winterfell", HouseType=new HouseType('N')},
                new House() { Name="Lannister", Territory="Casterly Rock", HouseType=new HouseType('R')},
                new House() { Name="Targaryen", Territory="Dragonstone", HouseType=new HouseType('D')},
                new House() { Name="Baratheon", Territory="Storm's End", HouseType=new HouseType('F')},
                new House() { Name="Greyjoy", Territory="Pyke", HouseType=new HouseType('I')}
            };

            int index1 = random.Next(0, houses.Count);
            int index2 = random.Next(0, houses.Count);
            while (index1 == index2) // Ensure we have two different houses
            {
                index2 = random.Next(0, houses.Count);
            }

            houses[1].Name = "Atreides";
            House house1 = houses[index1];
            House house2 = houses[index2];

            Console.WriteLine($"A battle is about to start between House {house1.Name} and House {house2.Name}...");

            int winnerIndex = random.Next(0, 2);
            return winnerIndex == 0 ? house1 : house2;
        }

        public static Dictionary<string, List<string>> GetCharacterNames()
        {
            return CharacterManager.GetCharacterNames();
        }
    }
}
