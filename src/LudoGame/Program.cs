using System;
using System.Collections.Generic;
using System.IO;
using GameEngine;

namespace LudoGame
{
    internal class Program
    {
        private static List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow" };
        private static int numberOfPlayers;
        private static string[][] players;

        private static void Main(string[] args)
        {
            PrintWellcomeText();
            SetNumberOfPlayers();
            SetPlayers();
            //var game = new GameEngine.LudoGame(players);
            //  game.StartGame(players);
        }

        private static void PrintWellcomeText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var logo = File.ReadAllLines(@"Logo.txt");
            foreach (var item in logo)
                Console.WriteLine(item);
        }

        private static void SetNumberOfPlayers()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            while (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                Console.WriteLine("Input numbers of players:");
                try
                {
                    numberOfPlayers = int.Parse(Console.ReadLine());

                    if (numberOfPlayers < 2)
                        Console.WriteLine("Must be more atleast 2 players");
                    else if (numberOfPlayers > 4)
                        Console.WriteLine("Maximum 4 players");
                }
                catch (Exception)
                {
                    Console.WriteLine("Number of players must be a digit");
                }
            }
            players = new string[numberOfPlayers][];
        }

        private static void SetPlayers()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("\r\nInput player{0} name:", i + 1);
                var name = Console.ReadLine();
                Console.WriteLine("\r\nPlease select player{0} color", i + 1);
                for (int j = 0; j < colors.Count; j++)
                {
                    Console.WriteLine("{0}. {1}", j + 1, colors[j]);
                }
                try
                {
                    int colorIndex = int.Parse(Console.ReadLine());
                    players[i] = new string[] { name, colors[colorIndex - 1] };
                    colors.RemoveAt(colorIndex - 1);
                }
                catch (Exception)
                {
                    Console.WriteLine("Selected color must be a digit.");
                }
            }
        }
    }
}