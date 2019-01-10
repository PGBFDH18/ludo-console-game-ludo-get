using System;
using GameEngine;

namespace LudoGame
{
    internal class Program
    {
        private static int numberOfPlayers;

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ludo!");

            while (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                Console.WriteLine("Number of players:");
                try
                {
                    numberOfPlayers = int.Parse(Console.ReadLine());

                    if (numberOfPlayers < 2)
                    {
                        Console.WriteLine("Must be more atleast 2 players");
                    }
                    else if (numberOfPlayers > 4)
                    {
                        Console.WriteLine("Maximum 4 players");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Number of players must be a digit");
                }
            }

            string[][] players = new string[numberOfPlayers][];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Input player{0} name:", i + 1);
                string name = Console.ReadLine();
                Console.WriteLine("Input player{0} color:", i + 1);
                string color = Console.ReadLine();
                players[i] = new string[] { name, color };
            }

            var game = new GameEngine.LudoGame();
            game.StartGame(numberOfPlayers, players);
        }
    }
}