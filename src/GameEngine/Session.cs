using System;
using System.Collections.Generic;

namespace GameEngine
{
    enum Colors { Red, Blue, Green, Yellow};
    public class Session
    {
        Player player = new Player();
        Piece piece = new Piece();
        Die die = new Die();
        Board board = new Board();
        Colors color = new Colors();
        Player[] totalPlayers;
        int currentPlayer = 0;
        int numberOfPlayers = 0;
        
        // Ta emot information från LudoGame
        public Session(string[][] players)
        {
            // Extrahera informationen från parametrarna som Session tar emot.
            numberOfPlayers = players.Length;
            totalPlayers = new Player[numberOfPlayers];

            List<string> colorsInPlay = new List<string>();
            foreach (string[] s in players)
            {
                if (s[1] == "Red")
                {
                    colorsInPlay.Add("Red");
                }
            }
            foreach (string[] s in players)
            {
                if (s[1] == "Blue")
                {
                    colorsInPlay.Add("Blue");
                }
            }
            foreach (string[] s in players)
            {
                if (s[1] == "Green")
                {
                    colorsInPlay.Add("Green");
                }
            }
            foreach (string[] s in players)
            {
                if (s[1] == "Yellow")
                {
                    colorsInPlay.Add("Yellow");
                }
            }
            for (int i = 0; i < numberOfPlayers; i++)
            {
                player = new Player
                {
                    Name = players[i][0],
                    Color = players[i][1]
                };

                for (int j = 0; j < 4; j++)
                {
                    piece = new Piece
                    {
                        Color = players[i][1],
                        Number = j
                    };
                    player.pieces[j] = piece;
                }

                if (Colors.Red.ToString() == player.Color)
                {
                    totalPlayers[colorsInPlay.IndexOf("Red")] = player;
                }
                if (Colors.Blue.ToString() == player.Color)
                {
                    totalPlayers[colorsInPlay.IndexOf("Blue")] = player;
                }
                if (Colors.Green.ToString() == player.Color)
                {
                    totalPlayers[colorsInPlay.IndexOf("Green")] = player;
                }
                if (Colors.Yellow.ToString() == player.Color)
                {
                    totalPlayers[colorsInPlay.IndexOf("Yellow")] = player;
                }
            }
            string startingColor = colorsInPlay[0];
            Run(startingColor);
        }

        // Inf-loop där vi slår tärningar.
        public void Run(string startingColor)
        {
        }

        public int MovePiece(int tmp)
        {
            return 1;
        }

        public int PlayerRoll()
        {
            int tmp = die.Roll();
            MovePiece(tmp);
            return tmp;
        }

        public string GetCurrentPlayer()
        {
            return totalPlayers[currentPlayer].Color;
        }

        public void IncrementCurrentPlayer()
        {
            currentPlayer++;
            if (currentPlayer > totalPlayers.Length)
                currentPlayer = 0;
        }
    }
}