using System;
using System.Collections.Generic;

namespace GameEngine
{
    enum Colors { Red, Blue, Green, Yellow};
    public class Session
    {
        Player player;
        Piece piece;
        Die d;
        Board board;
        Colors clr;
        Player[] totalPlayers;
        int currentPlayer = 0;
        int numberOfPlayers = 0;

        // Ta emot information från LudoGame
        public Session(string[][] players, string startingColor)
        {
            // Extrahera informationen från parametrarna som Session tar emot.
            numberOfPlayers = players.Length;
            totalPlayers = new Player[numberOfPlayers];
            int eValue;

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
                    player.pieces[i] = piece;
                }

                if (Colors.Red.ToString() == player.Color)
                {
                    eValue = (int)clr;
                    totalPlayers[eValue] = player;
                }
                if (Colors.Blue.ToString() == player.Color)
                {
                    eValue = (int)clr;
                    totalPlayers[eValue] = player;
                }
                if (Colors.Green.ToString() == player.Color)
                {
                    eValue = (int)clr;
                    totalPlayers[eValue] = player;
                }
                if (Colors.Yellow.ToString() == player.Color)
                {
                    eValue = (int)clr;
                    totalPlayers[eValue] = player;
                }
            }
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

        public void PlayerRoll()
        {
            int tmp = d.Roll();
            if (tmp != 6)
            {
                if(currentPlayer >= numberOfPlayers)
                {
                    currentPlayer = 0;
                    MovePiece(tmp);
                }
                else
                {
                    currentPlayer++;
                    MovePiece(tmp);
                }
            }
            else
            {
                MovePiece(tmp);
            }
        }

        public string GetCurrentPlayer()
        {
            return totalPlayers[currentPlayer].Color;
        }
    }
}